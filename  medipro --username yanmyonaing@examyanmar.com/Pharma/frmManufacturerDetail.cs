using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using exaCore;
using System.Globalization;

namespace Pharma
{
    public partial class frmManufacturerDetail : Form
    {
        clsSQL SqlDb = new clsSQL();

        public frmManufacturerDetail()
        {
            InitializeComponent();
            cboCountry.Items.Clear();           
            foreach (string c in GetCountries())
            {
                cboCountry.Items.Add(c);
            }

        }

        private List<string> GetCountries()
        {
            List<string> countryNames = new List<string>();
            foreach (CultureInfo cul in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                RegionInfo country = new RegionInfo(cul.LCID);
                countryNames.Add(country.DisplayName.ToString());
                
            }
            countryNames.Remove("People's Republic of China");
            countryNames.Add("China");
            countryNames.Add("Myanmar");

            return countryNames.OrderBy(i=>i).Distinct().ToList();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == true)
            {
                int Cnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblManufacturer WHERE manuName=@manuName AND isDelete=0", new MySqlParameter("@manuName", txtName.Text.Trim()));

                if (Cnt > 0 && cmdSave.Tag.ToString() == "Add")
                {
                    MessageBox.Show("Your Manufacturer is already exit. Please check your Manufacturer.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                    txtName.SelectAll();
                }
                else
                {
                    if (txtName.Tag.ToString().Length > 0)
                    {
                        int LabIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblManufacturer WHERE manuPK=@manuPK AND isDelete=0", new MySqlParameter("@manuPK", txtName.Tag.ToString()));

                        if (LabIDCnt > 0)
                        {
                            SqlDb.ExecuteQuery("UPDATE tblManufacturer SET manuName=@manuName, manuContact=@manuContact,manuAddress=@manuAddress,manuEmail=@manuEmail,manuCountry=@manuCountry,isActive=@IsActive,updateDate=NOW(),updatePK=@UpdatePK WHERE manuPK=@manuPK",
                                            new MySqlParameter("@manuPK", int.Parse(txtName.Tag.ToString())),
                                            new MySqlParameter("@manuName", txtName.Text.Trim()),
                                            new MySqlParameter("@manuContact",txtContact.Text.Trim()),
                                            new MySqlParameter("@manuAddress",txtAddress.Text.Trim()),
                                            new MySqlParameter("@manuEmail",txtEmail.Text.Trim()),
                                            new MySqlParameter("@manuCountry",cboCountry.Text.Trim()),
                                            new MySqlParameter("@IsActive", chkIsActive.EditValue),
                                            new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK.ToString()));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Update Test Name.");

                            MessageBox.Show("Update is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        int LabID = SqlDb.ExecuteScalar<int>("getID tblManufacturer");

                        int LabIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblManufacturer WHERE manuPK=@manuPK AND isDelete=0", new MySqlParameter("@manuPK", LabID));

                        if (LabIDCnt < 1)
                        {
                            SqlDb.ExecuteQuery("INSERT INTO tblManufacturer(manuPK,manuName,manuContact,manuAddress,manuEmail,manuCountry,isActive,updateDate,updatePK,createDate,createPK) " +
                                                "VALUES(@manuPK,@manuName,@manuContact,@manuAddress,@manuEmail,@manuCountry, @IsActive,NOW(),@updatePK,NOW(),@createPK)",
                                                new MySqlParameter("@manuPK", LabID),
                                                new MySqlParameter("@manuName", txtName.Text.Trim()),
                                                new MySqlParameter("@manuContact", txtContact.Text.Trim()),
                                                new MySqlParameter("@manuAddress", txtAddress.Text.Trim()),
                                                new MySqlParameter("@manuEmail", txtEmail.Text.Trim()),
                                                new MySqlParameter("@manuCountry", cboCountry.Text.Trim()),
                                                new MySqlParameter("@IsActive", chkIsActive.EditValue),
                                                new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK),
                                                new MySqlParameter("@createPK", AppVariable.CURRENT_USER_PK));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Add New Manufacturer.");

                             DialogResult dr = MessageBox.Show("Save is successful. Do you want to create another record?", "MediPro :: Clinic System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (dr == DialogResult.Yes)
                            {
                                txtName.Text = string.Empty;
                                txtName.Tag = string.Empty;
                                txtContact.Text = string.Empty;
                                txtAddress.Text = string.Empty;
                                txtEmail.Text = string.Empty;
                                cboCountry.Text = string.Empty;

                                chkIsActive.EditValue = true;

                                txtName.Focus();
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                    }
                }
            }
        }

        private bool ValidateForm()
        {
            bool value = true;
            if (txtName.Text.Length < 1)
            {
                MessageBox.Show("Please enter Manufacturer.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                txtName.Focus();
            }

            return value;
        }
    }
}
