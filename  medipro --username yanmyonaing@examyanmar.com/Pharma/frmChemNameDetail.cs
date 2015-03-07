using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using exaCore;

namespace Pharma
{
    public partial class frmChemNameDetail : Form
    {
        clsSQL SqlDb = new clsSQL();

        public frmChemNameDetail()
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
                int Cnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblChemName WHERE chemName=@chemName AND isDelete=0", new SqlParameter("@chemName", txtName.Text.Trim()));

                if (Cnt > 0 && cmdSave.Tag.ToString() == "Add")
                {
                    MessageBox.Show("Your Chemical Name is already exit. Please check your Chemical Name.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                    txtName.SelectAll();
                }
                else
                {
                    if (txtName.Tag.ToString().Length > 0)
                    {
                        int LabIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblChemName WHERE chemNamePK=@chemNamePK AND isDelete=0", new SqlParameter("@chemNamePK", txtName.Tag.ToString()));

                        if (LabIDCnt > 0)
                        {
                            SqlDb.ExecuteQuery("UPDATE tblChemName SET chemName=@chemName,isActive=@IsActive,updateDate=SYSDATETIME(),updatePK=@UpdatePK WHERE chemNamePK=@chemNamePK",
                                            new SqlParameter("@chemNamePK", int.Parse(txtName.Tag.ToString())),
                                            new SqlParameter("@chemName", txtName.Text.Trim()),
                                            new SqlParameter("@IsActive", chkIsActive.EditValue),
                                            new SqlParameter("@updatePK", AppVariable.CURRENT_USER_PK.ToString()));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Update Test Name.");

                            MessageBox.Show("Update is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        int LabID = SqlDb.ExecuteScalar<int>("getID tblChemName");

                        int LabIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblChemName WHERE chemNamePK=@chemNamePK AND isDelete=0", new SqlParameter("@chemNamePK", LabID));

                        if (LabIDCnt < 1)
                        {
                            SqlDb.ExecuteQuery("INSERT INTO tblChemName(chemNamePK,chemName,isActive,updateDate,updatePK,createDate,createPK) " +
                                                "VALUES(@chemNamePK,@chemName,@IsActive,SYSDATETIME(),@updatePK,SYSDATETIME(),@createPK)",
                                                new SqlParameter("@chemNamePK", LabID),
                                                new SqlParameter("@chemName", txtName.Text.Trim()),
                                                new SqlParameter("@IsActive", chkIsActive.EditValue),
                                                new SqlParameter("@updatePK", AppVariable.CURRENT_USER_PK),
                                                new SqlParameter("@createPK", AppVariable.CURRENT_USER_PK));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Add New Chemical Name.");

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
                MessageBox.Show("Please enter Chemical name.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                txtName.Focus();
            }
            return value;
        }
    }
}
