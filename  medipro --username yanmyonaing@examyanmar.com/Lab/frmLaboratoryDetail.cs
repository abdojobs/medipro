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

namespace Lab
{
    public partial class frmLaboratoryDetail : Form
    {
        clsSQL SqlDb = new clsSQL();

        public frmLaboratoryDetail()
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
                int LabCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblLaboratory WHERE labName=@labName AND isDelete=0 AND labPK<>@labPK ", new MySqlParameter("@labName", txtName.Text.Trim()), new MySqlParameter("@labPK",txtName.Tag));

                if (LabCnt > 0)
                {
                    MessageBox.Show("Your Lab name is already exit. Please check your Lab name.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                    txtName.SelectAll();
                }
                else
                {
                    if (txtName.Tag.ToString().Length > 0)
                    {
                        int LabIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblLaboratory WHERE labPK=@labPK AND isDelete=0", new MySqlParameter("@labPK", txtName.Tag.ToString()));

                        if (LabIDCnt > 0)
                        {
                            SqlDb.ExecuteQuery("UPDATE tblLaboratory SET labName=@labName,isActive=@IsActive,updateDate=NOW(),updatePK=@UpdatePK WHERE labPK=@labPK",
                                            new MySqlParameter("@labPK", int.Parse(txtName.Tag.ToString())),
                                            new MySqlParameter("@labName", txtName.Text.Trim()),
                                            new MySqlParameter("@IsActive", chkIsActive.EditValue),
                                            new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK.ToString()));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Update Test Name.");

                            MessageBox.Show("Update is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        int LabID = SqlDb.ExecuteScalar<int>("Call getID ('tblLaboratory')");

                        int LabIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblLaboratory WHERE labPK=@labPK AND isDelete=0", new MySqlParameter("@labPK", LabID));

                        if (LabIDCnt < 1)
                        {
                            SqlDb.ExecuteQuery("INSERT INTO tblLaboratory(labPK,labName,isActive,updateDate,updatePK,createDate,createPK) " +
                                                "VALUES(@labPK,@labName,@IsActive,NOW(),@updatePK,NOW(),@createPK)",
                                                new MySqlParameter("@labPK", LabID),
                                                new MySqlParameter("@labName", txtName.Text.Trim()),
                                                new MySqlParameter("@IsActive", chkIsActive.EditValue),
                                                new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK),
                                                new MySqlParameter("@createPK", AppVariable.CURRENT_USER_PK));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Add New Test Name.");

                             DialogResult dr = MessageBox.Show("Save is successful. Do you want to create other test name?", "MediPro :: Clinic System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
                MessageBox.Show("Please enter Lab name.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                txtName.Focus();
            }
            return value;
        }
    }
}
