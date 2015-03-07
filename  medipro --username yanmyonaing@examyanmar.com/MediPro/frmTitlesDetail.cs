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
    public partial class frmTitleDetail : Form
    {
        Class.clsSQL SqlDb = new Class.clsSQL();

        public frmTitleDetail()
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
                int TitleCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblTitle WHERE TitleName=@TitleName AND isDelete=0", new SqlParameter("@TitleName", txtTitle.Text.Trim()));

                if (TitleCnt > 0 && cmdSave.Tag.ToString() == "Add")
                {
                    MessageBox.Show("Your title is already exit. Please check your title.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTitle.Focus();
                    txtTitle.SelectAll();
                }
                else
                {
                    if (txtTitle.Tag.ToString().Length > 0)
                    {
                        int TitleIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblTitle WHERE titlePK=@TitlePK AND isDelete=0", new SqlParameter("@TitlePK", txtTitle.Tag.ToString()));

                        if (TitleIDCnt > 0)
                        {
                            SqlDb.ExecuteQuery("UPDATE tblTitle SET TitleName=@TitleName,isActive=@IsActive,updateDate=SYSDATETIME(),updatePK=@UpdatePK WHERE titlePK=@TitlePK",
                                            new SqlParameter("@TitlePK", int.Parse(Convert.ToString(txtTitle.Tag))),
                                            new SqlParameter("@TitleName", txtTitle.Text),
                                            new SqlParameter("@IsActive", chkIsActive.EditValue),
                                            new SqlParameter("@updatePK", AppVariable.CURRENT_USER_PK));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Update Title.");

                            MessageBox.Show("Update is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        int TitleID = SqlDb.ExecuteScalar<int>("getID tblTitle");

                        int TitleIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblTitle WHERE titlePK=@TitlePK AND isDeleted=0", new SqlParameter("@TitlePK", TitleID));

                        if (TitleIDCnt < 1)
                        {
                            SqlDb.ExecuteQuery("INSERT INTO tblTitle(titlePK,TitleName,isActive,updateDate,updatePK,createDate,createPK) " +
                                                "VALUES(@TitlePK,@TitleName,@IsActive,SYSDATETIME(),@updatePK,SYSDATETIME(),@createPK)",
                                                new SqlParameter("@TitlePK", TitleID),
                                                new SqlParameter("@TitleName", txtTitle.Text),
                                                new SqlParameter("@IsActive", chkIsActive.EditValue),
                                                new SqlParameter("@updatePK", AppVariable.CURRENT_USER_PK),
                                                new SqlParameter("@createPK", AppVariable.CURRENT_USER_PK));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Add New Title.");

                            DialogResult dr = MessageBox.Show("Save is successful. Do you want to create new title?", "MediPro :: Clinic System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (dr == DialogResult.Yes)
                            {
                                txtTitle.Text = string.Empty;
                                txtTitle.Tag = string.Empty;

                                chkIsActive.EditValue = true;

                                txtTitle.Focus();
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
            if (txtTitle.Text.Length < 1)
            {
                MessageBox.Show("Please enter title.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
            }
            return value;
        }
    }
}
