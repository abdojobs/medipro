using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using exaCore;
using MySql.Data.MySqlClient;

namespace MediPro
{
    public partial class frmUserDetail : Form
    {
        clsSQL SqlDb = new clsSQL();
        
        public frmUserDetail()
        {
            InitializeComponent();

            BindingUserLevel();
        }

        private void frmUserDetail_Load(object sender, EventArgs e)
        {
            if (cmdSave.Tag.ToString() == "Edit")
                cboUserLevel.SelectedValue = cboUserLevel.Tag.ToString();

            txtFullName.Focus();
        }

        private void BindingUserLevel()
        {
            DataSet dsUserLevel = new DataSet();

            dsUserLevel = SqlDb.GetDataSet("SELECT levelPK, UserLevel FROM sysUserLevel");

            try
            {
                cboUserLevel.DataSource = dsUserLevel.Tables[0];
                cboUserLevel.DisplayMember = "UserLevel";
                cboUserLevel.ValueMember = "levelPK";
                cboUserLevel.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == true)
            {
                int UserCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM sysUser WHERE  login=@Login AND isDelete =0", new MySqlParameter("@login", txtLoginID.Text.Trim()));

                if (UserCnt > 0 && cmdSave.Tag.ToString() == "Add")
                {
                    MessageBox.Show("Your Login ID is already exit. Please check your Login ID.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLoginID.SelectAll();
                }
                else
                {
                    if (txtLoginID.Tag.ToString().Length > 0)
                    {
                        int UserIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM sysUser WHERE PK=@PK AND isDelete=0", new MySqlParameter("@PK", txtLoginID.Tag.ToString()));

                        if (UserIDCnt > 0)
                        {
                            SqlDb.ExecuteQuery("UPDATE sysUser SET name=@FullName,login=@LoginID,levelPK=@LevelPK,IsActive=@IsActive,updateDate=NOW() WHERE PK=@UserID",
                                            new MySqlParameter("@UserID", int.Parse(Convert.ToString(txtLoginID.Tag))),
                                            new MySqlParameter("@FullName", txtFullName.Text),
                                            new MySqlParameter("@LoginID", txtLoginID.Text),
                                            new MySqlParameter("@LevelPK", cboUserLevel.SelectedValue),
                                            new MySqlParameter("@IsActive", chkIsActive.EditValue));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Update User Info.");

                            MessageBox.Show("Update is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        int CurUserID = SqlDb.ExecuteScalar<int>("getID sysUser");

                        int UserIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM sysUser WHERE PK=@UserID AND isDelete=0", new MySqlParameter("@UserID", CurUserID));

                        if (UserIDCnt < 1)
                        {
                            string pwd = Crypto.Encrypt("passw0rd");

                            SqlDb.ExecuteQuery("INSERT INTO sysUser(PK,name,login,passw,levelPK,IsActive,updateDate,createDate) " +
                                                "VALUES(@UserID,@FullName,@LoginID,@PSW,@LevelPK,@IsActive,NOW(),NOW())",
                                                new MySqlParameter("@UserID", CurUserID),
                                                new MySqlParameter("@FullName", txtFullName.Text),
                                                new MySqlParameter("@LoginID", txtLoginID.Text),
                                                new MySqlParameter("@LevelPK", cboUserLevel.SelectedValue),
                                                new MySqlParameter("@PSW", pwd),
                                                new MySqlParameter("@IsActive", chkIsActive.EditValue));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Add New User");

                            DialogResult = MessageBox.Show("Save is successful. Do you want to create new user?", "MediPro :: Clinic System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (DialogResult == DialogResult.Yes)
                            {
                                FormClean();
                                txtFullName.Focus();
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
            if (txtFullName.Text.Length < 1)
            {
                MessageBox.Show("Please enter Full Name.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
            }
            else if (txtLoginID.Text.Length < 1)
            {
                MessageBox.Show("Please enter Login ID.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
            }
            else if (cboUserLevel.Text.Length < 1)
            {
                MessageBox.Show("Please select user level.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
            }

            return value;
        }

        private void FormClean()
        {
            txtFullName.Text = string.Empty;
            txtLoginID.Text = string.Empty;
            txtLoginID.Tag = string.Empty;
            cboUserLevel.SelectedIndex = -1;
            chkIsActive.EditValue = true;
        }
    }
}
