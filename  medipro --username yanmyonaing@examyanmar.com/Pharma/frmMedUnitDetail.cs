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

namespace Pharma
{
    public partial class frmMedUnitDetail : Form
    {
        clsSQL SqlDb = new clsSQL();

        public frmMedUnitDetail()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == true)
            {
                int Cnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblMedUnit WHERE medUnitName=@MedUnitName AND isDelete=0 AND medUnitPK <>@medUnitPK", new MySqlParameter("@MedUnitName", txtName.Text.Trim()), new MySqlParameter("@medUnitPK", txtName.Tag.ToString()));

                if (Cnt > 0 )
                {
                    MessageBox.Show("Your Medicine Unit Name is already exit. Please check your Medicine Unit Name.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                    txtName.SelectAll();
                }
                else
                {
                    if (txtName.Tag.ToString().Length > 0)
                    {
                        int LabIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblMedUnit WHERE medUnitPK=@MedUnitPK AND isDelete=0", new MySqlParameter("@MedUnitPK", txtName.Tag.ToString()));

                        if (LabIDCnt > 0)
                        {
                            SqlDb.ExecuteQuery("UPDATE tblMedUnit SET medUnitName=@MedUnitName,isActive=@IsActive,updateDate=NOW(),updatePK=@UpdatePK WHERE medUnitPK=@MedUnitPK",
                                            new MySqlParameter("@MedUnitPK", int.Parse(txtName.Tag.ToString())),
                                            new MySqlParameter("@medUnitName", txtName.Text.Trim()),
                                            new MySqlParameter("@IsActive", chkIsActive.EditValue),
                                            new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK.ToString()));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Update Test Name.");

                            MessageBox.Show("Update is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        int LabID = SqlDb.ExecuteScalar<int>("getID tblMedUnit");

                        int LabIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblMedUnit WHERE medUnitPK=@MedUnitPK AND isDelete=0", new MySqlParameter("@MedUnitPK", LabID));

                        if (LabIDCnt < 1)
                        {
                            SqlDb.ExecuteQuery("INSERT INTO tblMedUnit(medUnitPK,medUnitName,isActive,updateDate,updatePK,createDate,createPK) " +
                                                "VALUES(@MedUnitPK,@MedUnitName,@IsActive,NOW(),@updatePK,NOW(),@createPK)",
                                                new MySqlParameter("@MedUnitPK", LabID),
                                                new MySqlParameter("@MedUnitName", txtName.Text.Trim()),
                                                new MySqlParameter("@IsActive", chkIsActive.EditValue),
                                                new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK),
                                                new MySqlParameter("@createPK", AppVariable.CURRENT_USER_PK));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Add New Medicine Unit Name.");

                             DialogResult dr = MessageBox.Show("Save is successful. Do you want to create another record?", "MediPro :: Clinic System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (dr == DialogResult.Yes)
                            {
                                txtName.Text = string.Empty;
                                txtName.Tag = string.Empty;

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
                MessageBox.Show("Please enter Medicine Unit name.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                txtName.Focus();
            }
            return value;
        }
    }
}
