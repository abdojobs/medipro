using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MediPro.Class;

namespace MediPro
{
    public partial class frmSpecializeDetail : Form
    {
        Class.clsSQL SqlDb = new Class.clsSQL();

        public frmSpecializeDetail()
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
                int SpecCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblSpecialize WHERE specialize=@Specialize AND isDelete=0", new SqlParameter("@Specialize", txtSpecialize.Text.Trim()));

                if (SpecCnt > 0 && cmdSave.Tag.ToString() == "Add")
                {
                    MessageBox.Show("Your specialize is already exit. Please check your title.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSpecialize.Focus();
                    txtSpecialize.SelectAll();
                }
                else
                {
                    if (txtSpecialize.Tag.ToString().Length > 0)
                    {
                        int SpecIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblSpecialize WHERE specializePK=@SpecializePK AND isDelete=0", new SqlParameter("@SpecializePK", txtSpecialize.Tag.ToString()));

                        if (SpecIDCnt > 0)
                        {
                            SqlDb.ExecuteQuery("UPDATE tblSpecialize SET specialize=@Specialize,isActive=@IsActive,updateDate=SYSDATETIME(),updatePK=@UpdatePK WHERE specializePK=@SpecializePK",
                                            new SqlParameter("@SpecializePK", int.Parse(txtSpecialize.Tag.ToString())),
                                            new SqlParameter("@Specialize", txtSpecialize.Text.Trim()),
                                            new SqlParameter("@IsActive", chkIsActive.EditValue),
                                            new SqlParameter("@updatePK", AppVariable.CURRENT_USER_PK.ToString()));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Update Specialize.");

                            MessageBox.Show("Update is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        int SpecID = SqlDb.ExecuteScalar<int>("getID tblSpecialize");

                        int SpecIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblSpecialize WHERE specializePK=@SpecializePK AND isDelete=0", new SqlParameter("@SpecializePK", SpecID));

                        if (SpecIDCnt < 1)
                        {
                            SqlDb.ExecuteQuery("INSERT INTO tblSpecialize(specializePK,specialize,isActive,updateDate,updatePK,createDate,createPK) " +
                                                "VALUES(@SpecializePK,@Specialize,@IsActive,SYSDATETIME(),@updatePK,SYSDATETIME(),@createPK)",
                                                new SqlParameter("@SpecializePK", SpecID),
                                                new SqlParameter("@Specialize", txtSpecialize.Text.Trim()),
                                                new SqlParameter("@IsActive", chkIsActive.EditValue),
                                                new SqlParameter("@updatePK", AppVariable.CURRENT_USER_PK),
                                                new SqlParameter("@createPK", AppVariable.CURRENT_USER_PK));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Add New Specialize.");

                            DialogResult dr = MessageBox.Show("Save is successful. Do you want to create new specialize?", "MediPro :: Clinic System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (dr == DialogResult.Yes)
                            {
                                txtSpecialize.Text = string.Empty;
                                txtSpecialize.Tag = string.Empty;

                                chkIsActive.EditValue = true;

                                txtSpecialize.Focus();
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
            if (txtSpecialize.Text.Length < 1)
            {
                MessageBox.Show("Please enter title.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                txtSpecialize.Focus();
            }
            return value;
        }
    }
}
