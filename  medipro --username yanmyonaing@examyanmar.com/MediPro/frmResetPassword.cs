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

namespace MediPro
{
    public partial class frmResetPassword : Form
    {
        clsSQL SqlDb = new clsSQL();

        public frmResetPassword()
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
                int UserCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM sysUser WHERE PK = @PK AND isDelete =0", new SqlParameter("@PK", txtNewPassw.Tag.ToString()));

                if (UserCnt > 0 && cmdSave.Tag.ToString() == "Edit")
                {
                    SqlDb.ExecuteQuery("UPDATE sysUser SET passw=@Passw,updatePK,updateDate=SYSDATETIME() WHERE PK=@UserID",
                                    new SqlParameter("@UserID", txtNewPassw.Tag.ToString()),
                                    new SqlParameter("@updatePK", AppVariable.CURRENT_USER_PK),
                                    new SqlParameter("@Passw", Crypto.Encrypt(txtNewPassw.Text.Trim())));

                    sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Reset Password.");

                    MessageBox.Show("Update is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool ValidateForm()
        {
            bool value = true;
            if (txtNewPassw.Text.Length < 1)
            {
                MessageBox.Show("Please enter New Passwrod.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
            }
            else if (txtConfirmPassw.Text.Length < 1)
            {
                MessageBox.Show("Please enter Confirm Password.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
            }
            else if (txtNewPassw.Text.Trim() != txtConfirmPassw.Text.Trim())
            {
                MessageBox.Show("Your password is not much.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
            }
            
            return value;
        }

    }
}
