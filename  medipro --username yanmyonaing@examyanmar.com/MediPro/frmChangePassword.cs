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

namespace MediPro
{
    public partial class frmChangePassword : Form
    {
        clsSQL SqlDb = new clsSQL();

        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == true)
            {
                int UserCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM sysUser WHERE PK = @PK AND passw = @PWD AND isDelete = 0", 
                                                        new MySqlParameter("@PK", AppVariable.CURRENT_USER_PK),
                                                        new MySqlParameter("@PWD", Crypto.Encrypt(txtCurPassw.Text.Trim())));

                if (UserCnt < 1)
                {
                    MessageBox.Show("Your Current Password is not much.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCurPassw.Focus();
                    txtCurPassw.Select(0, txtCurPassw.Text.Length);
                }
                else
                {
                    SqlDb.ExecuteQuery("UPDATE sysUser SET passw=@PWD,updatePK=@updatePK,updateDate=NOW() WHERE PK=@PK",
                                    new MySqlParameter("@PK", AppVariable.CURRENT_USER_PK),
                                    new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK),
                                    new MySqlParameter("@PWD", Crypto.Encrypt(txtNewPassw.Text.Trim())));

                    sysLogs.logsDetail(1, "Change Password.");

                    MessageBox.Show("Update is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool ValidateForm()
        {
            bool value = true;
            if (txtCurPassw.Text.Length < 1)
            {
                MessageBox.Show("Please enter Current Password.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                txtCurPassw.Focus();
            }
            else if (txtNewPassw.Text.Length < 1)
            {
                MessageBox.Show("Please enter New Password.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                txtNewPassw.Focus();
            }
            else if (txtConfirmPassw.Text.Length < 1)
            {
                MessageBox.Show("Please enter Confirm Password.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                txtConfirmPassw.Focus();
            }
            else if (txtNewPassw.Text.Trim() != txtConfirmPassw.Text.Trim())
            {
                MessageBox.Show("Your New and Confirm Password is not much.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                txtNewPassw.Focus();
                txtNewPassw.Select(0, txtNewPassw.Text.Length);
            }

            return value;
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
