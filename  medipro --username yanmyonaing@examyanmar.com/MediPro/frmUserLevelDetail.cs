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
    public partial class frmUserLevelDetail : Form
    {
        clsSQL SqlDb = new clsSQL();
        
        public frmUserLevelDetail()
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
                int UserLevelCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM sysUserLevel WHERE user_level=@UserLevel AND isDeleted=0", new MySqlParameter("@UserLevel", txtUserLevel.Text.Trim()));

                if (UserLevelCnt > 0 && cmdSave.Tag.ToString() == "Add")
                {
                    MessageBox.Show("Your user level is already exit. Please check your user level.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserLevel.SelectAll();
                }
                else
                {
                    if (txtUserLevel.Tag.ToString().Length > 0)
                    {
                        int UserLevelIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM sysUserLevel WHERE levelPK=@LevelPK AND isDeleted=0", new MySqlParameter("@LevelPK", txtUserLevel.Tag.ToString()));

                        if (UserLevelIDCnt > 0 )
                        {
                            SqlDb.ExecuteQuery("UPDATE sysUserLevel SET UserLevel=@UserLevel,IsActive=@IsActive,updatedDate=@updatedDate WHERE levelPK=@LevelPK",
                                            new MySqlParameter("@LevelPK", int.Parse(Convert.ToString(txtUserLevel.Tag))),
                                            new MySqlParameter("@UserLevel", txtUserLevel.Text),
                                            new MySqlParameter("@IsActive", chkIsActive.EditValue),
                                            new MySqlParameter("@updatedDate", DateTime.Now));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Update User Level.");

                            MessageBox.Show("Update is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        int CurUserLevelID = SqlDb.ExecuteScalar<int>("Call getID ('sysUserLevel')");

                        int UserLevelIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM sysUserLevel WHERE levelPK=@LevelPK AND isDeleted=0", new MySqlParameter("@LevelPK", CurUserLevelID));

                        if (UserLevelIDCnt < 1)
                        {
                            SqlDb.ExecuteQuery("INSERT INTO sysUserLevel(levelPK,UserLevel,IsActive,updatedDate,createdDate) " +
                                                "VALUES(@LevelPK,@UserLevel,@IsActive,@updatedDate,@createdDate)",
                                                new MySqlParameter("@LevelPK", CurUserLevelID),
                                                new MySqlParameter("@UserLevel", txtUserLevel.Text),
                                                new MySqlParameter("@IsActive", chkIsActive.EditValue),
                                                new MySqlParameter("@updatedDate", DateTime.Now),
                                                new MySqlParameter("@createdDate", DateTime.Now));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Add New User Level.");

                            DataSet dsMainMenu = SqlDb.GetDataSet("SELECT PK FROM sysMainMenu");

                            for (int i = 0; i < dsMainMenu.Tables[0].Rows.Count; i++)
                            {
                                SqlDb.ExecuteQuery("INSERT INTO sysMainMenuDefine(mainmenuPK,levelPK,IsView) VALUES(@MainMenuPK,@LevelPK,@IsView)",
                                                    new MySqlParameter("@MainMenuPK", int.Parse(dsMainMenu.Tables[0].Rows[i]["PK"].ToString())),
                                                    new MySqlParameter("@LevelPK", CurUserLevelID),
                                                    new MySqlParameter("@IsView", true));

                                DataSet dsSubMenu = SqlDb.GetDataSet("SELECT PK FROM sysSubMenu WHERE mainPK = @MainMenuPK", 
                                                    new MySqlParameter("@MainMenuPK", int.Parse(dsMainMenu.Tables[0].Rows[i]["PK"].ToString())));

                                for (int s = 0; s < dsSubMenu.Tables[0].Rows.Count; s++)
                                {
                                    SqlDb.ExecuteQuery("INSERT INTO sysLevelDefine(levelPK,mainmenuPK,submenuPK,dataView,dataInsert,dataEdit,dataDelete,dataPrint) " +
                                                        "VALUES(@LevelPK,@MainMenuPK,@SubMenuPK,@DataView,@DataInsert,@DataEdit,@DataDelete,@DataPrint)",
                                                        new MySqlParameter("@LevelPK", CurUserLevelID),
                                                        new MySqlParameter("@SubMenuPK", int.Parse(dsSubMenu.Tables[0].Rows[s]["PK"].ToString())),
                                                        new MySqlParameter("@MainMenuPK", int.Parse(dsMainMenu.Tables[0].Rows[i]["PK"].ToString())),
                                                        new MySqlParameter("@DataView", true),
                                                        new MySqlParameter("@DataInsert", true),
                                                        new MySqlParameter("@DataEdit", true),
                                                        new MySqlParameter("@DataDelete", true),
                                                        new MySqlParameter("@DataPrint", true));
                                }
                            }                             

                            DialogResult = MessageBox.Show("Save is successful. Do you want to create new user level?", "MediPro :: Clinic System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (DialogResult == DialogResult.Yes)
                            {
                                txtUserLevel.Text = string.Empty;
                                txtUserLevel.Tag = string.Empty;

                                chkIsActive.EditValue = true;

                                txtUserLevel.Focus();
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
            if (txtUserLevel.Text.Length < 1)
            {
                MessageBox.Show("Please enter user level.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
            }
            return value;
        }
    }
}
