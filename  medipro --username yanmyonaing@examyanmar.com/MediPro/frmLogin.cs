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
    public partial class frmLogin : Form
    {
        private int loginCnt = 0;
        clsSQL SqlDb = new clsSQL();

        public frmLogin()
        {
            InitializeComponent();
            string oops= Crypto.Decrypt("T3l2QbbtnWmqBNVxtTiEiIghsR7YIA+bGcMOi9lGJiQ=");
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            bool ConStatus = SqlDb.TestConnection();

            if (ConStatus == false)
            {
                MessageBox.Show("Please check network connection!", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //BindingUserLevel();

                txtLogin.Focus();
            }
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            if (loginCnt == 3)
            {
                Application.ExitThread();
            }
            else if (ValidateForm() == true)
            {
                //string Login = SqlDb.ExecuteScalar<string>("SELECT login FROM sysUser WHERE login=@Login AND passw=@PWD AND levelPK=@LevelPK AND isDelete=@isDelete AND isActive=@isActive",
                //                                        new SqlParameter("@login", txtLogin.Text.Trim()),
                //                                        new SqlParameter("@PWD", Crypto.Encrypt(txtPassword.Text.Trim())),
                //                                        new SqlParameter("@LevelPK", cboUserLevel.SelectedValue),
                //                                        new SqlParameter("@isDelete", false),
                //                                        new SqlParameter("@isActive", true));

                string Login = SqlDb.ExecuteScalar<string>("SELECT login FROM sysUser WHERE login=@Login AND passw=@PWD AND isDelete=@isDelete AND isActive=@isActive",
                                                        new SqlParameter("@login", txtLogin.Text.Trim()),
                                                        new SqlParameter("@PWD", Crypto.Encrypt(txtPassword.Text.Trim())),
                                                        new SqlParameter("@isDelete", false),
                                                        new SqlParameter("@isActive", true));

                int AuthCnt = (Login == txtLogin.Text.Trim()) ? 1 : 0;                
                
                if (AuthCnt > 0)
                {
                    DataSet dsUser = SqlDb.GetDataSet("SELECT PK, name, login, levelPK FROM sysUser WHERE login=@Login AND passw=@PWD AND isDelete=@isDelete AND isActive=@isActive",
                                                     new SqlParameter("@login", txtLogin.Text.Trim()),
                                                        new SqlParameter("@PWD", Crypto.Encrypt(txtPassword.Text.Trim())),
                                                        new SqlParameter("@isDelete", false),
                                                        new SqlParameter("@isActive", true));

                    AppVariable.CURRENT_USER_PK = int.Parse(dsUser.Tables[0].Rows[0]["PK"].ToString());
                    AppVariable.CURRENT_USER_FULLNAME = dsUser.Tables[0].Rows[0]["name"].ToString();
                    AppVariable.CURRENT_USER_LEVEL_ID = int.Parse(dsUser.Tables[0].Rows[0]["levelPK"].ToString());
                    AppVariable.CURRENT_LOGIN_ID = dsUser.Tables[0].Rows[0]["login"].ToString();

                    sysLogs.logs_login();
                    
                    Main MainForm = new Main();
                    MainForm.Show();

                    this.Hide();
                }
                else
                {
                    loginCnt = loginCnt++;
                    MessageBox.Show("Your Login Information is not valid. Please try again.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLogin.Focus();
                }                
            }
        }

        //private void BindingUserLevel()
        //{
        //    DataSet dsUserLevel = new DataSet();

        //    dsUserLevel = SqlDb.GetDataSet("SELECT levelPK, UserLevel FROM sysUserLevel");

        //    try
        //    {
        //        cboUserLevel.DataSource = dsUserLevel.Tables[0];
        //        cboUserLevel.DisplayMember = "UserLevel";
        //        cboUserLevel.ValueMember = "levelPK";
        //        cboUserLevel.SelectedIndex = -1;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private bool ValidateForm()
        {
            bool value = true;
            if (txtLogin.Text.Length < 1)
            {
                MessageBox.Show("Please enter Login ID.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                txtLogin.Focus();
            }
            else if (txtPassword.Text.Length < 1)
            {
                MessageBox.Show("Please enter Password.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                txtPassword.Focus();
            }
            return value;
        }
    }
}
