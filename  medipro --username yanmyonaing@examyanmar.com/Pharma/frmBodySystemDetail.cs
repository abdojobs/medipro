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
    public partial class frmBodySystemDetail : Form
    {
        clsSQL SqlDb = new clsSQL();

        public frmBodySystemDetail()
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
                int Cnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblBodySystem WHERE systemName=@systemName AND isDelete=0", new SqlParameter("@systemName", txtName.Text.Trim()));

                if (Cnt > 0 && cmdSave.Tag.ToString() == "Add")
                {
                    MessageBox.Show("Your Body System is already exit. Please check your Body System.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                    txtName.SelectAll();
                }
                else
                {
                    if (txtName.Tag.ToString().Length > 0)
                    {
                        int LabIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblBodySystem WHERE systemPK=@systemPK AND isDelete=0", new SqlParameter("@systemPK", txtName.Tag.ToString()));

                        if (LabIDCnt > 0)
                        {
                            SqlDb.ExecuteQuery("UPDATE tblBodySystem SET systemName=@systemName,isActive=@IsActive,updateDate=SYSDATETIME(),updatePK=@UpdatePK WHERE systemPK=@systemPK",
                                            new SqlParameter("@systemPK", int.Parse(txtName.Tag.ToString())),
                                            new SqlParameter("@systemName", txtName.Text.Trim()),
                                            new SqlParameter("@IsActive", chkIsActive.EditValue),
                                            new SqlParameter("@updatePK", AppVariable.CURRENT_USER_PK.ToString()));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Update Test Name.");

                            MessageBox.Show("Update is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        int LabID = SqlDb.ExecuteScalar<int>("getID tblBodySystem");

                        int LabIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblBodySystem WHERE systemPK=@systemPK AND isDelete=0", new SqlParameter("@systemPK", LabID));

                        if (LabIDCnt < 1)
                        {
                            SqlDb.ExecuteQuery("INSERT INTO tblBodySystem(systemPK,systemName,isActive,updateDate,updatePK,createDate,createPK) " +
                                                "VALUES(@systemPK,@systemName,@IsActive,SYSDATETIME(),@updatePK,SYSDATETIME(),@createPK)",
                                                new SqlParameter("@systemPK", LabID),
                                                new SqlParameter("@systemName", txtName.Text.Trim()),
                                                new SqlParameter("@IsActive", chkIsActive.EditValue),
                                                new SqlParameter("@updatePK", AppVariable.CURRENT_USER_PK),
                                                new SqlParameter("@createPK", AppVariable.CURRENT_USER_PK));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Add New Body System.");

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
                MessageBox.Show("Please enter Body System.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                txtName.Focus();
            }
            return value;
        }
    }
}
