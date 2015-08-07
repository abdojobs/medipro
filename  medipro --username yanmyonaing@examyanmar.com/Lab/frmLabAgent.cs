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
    public partial class frmLabAgent : Form
    {
        clsSQL SqlDb = new clsSQL();

        public frmLabAgent()
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
                int LabCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblagent WHERE agentName=@agentName and agentPK<>@agentPK ", new MySqlParameter("@agentName", txtName.Text.Trim()), new MySqlParameter("@agentPK", txtName.Tag));

                if (LabCnt > 0)
                {
                    MessageBox.Show("Agent Name you provided is already exit. Please check your Agent name.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                    txtName.SelectAll();
                }
                else
                {
                    if (txtName.Tag.ToString().Length > 0)
                    {
                        int LabIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblAgent WHERE agentPK=@agentPK ", new MySqlParameter("@agentPK", txtName.Tag.ToString()));

                        if (LabIDCnt > 0)
                        {
                            SqlDb.ExecuteQuery("UPDATE tblAgent SET agentName=@agentName,agentAddress=@agentAddress,agentPhone=@agentPhone,agentRemarks=@agentRemarks,updateDate=NOW(),updatePK=@UpdatePK WHERE agentPK=@agentPK",
                                            new MySqlParameter("@agentPK", int.Parse(txtName.Tag.ToString())),
                                            new MySqlParameter("@agentName", txtName.Text.Trim()),
                                            new MySqlParameter("@agentAddress",txtAddress.Text.Trim()),
                                            new MySqlParameter("@agentPhone",txtPhone.Text.Trim()),
                                            new MySqlParameter("@agentRemarks",txtRemarks.Text.Trim()),
                                            new MySqlParameter("@IsActive", chkIsActive.EditValue),
                                            new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK.ToString()));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Update Agent Name.");

                            MessageBox.Show("Update is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        int LabID = SqlDb.ExecuteScalar<int>("Call getID ('tblagent')");

                        int LabIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblAgent WHERE agentPK=@agentPK", new MySqlParameter("@agentPK", LabID));

                        if (LabIDCnt < 1)
                        {
                            SqlDb.ExecuteQuery("INSERT INTO tblAgent(agentPK,agentName,agentPhone,agentAddress,agentRemarks,updateDate,updatePK,createDate,createPK) " +
                                                "VALUES(@agentPK,@agentName,@agentPhone,@agentAddress,@agentRemarks,NOW(),@updatePK,NOW(),@createPK)",
                                                 new MySqlParameter("@agentPK", LabID),
                                                new MySqlParameter("@agentName", txtName.Text.Trim()),
                                                new MySqlParameter("@agentAddress", txtAddress.Text.Trim()),
                                                new MySqlParameter("@agentPhone", txtPhone.Text.Trim()),
                                                new MySqlParameter("@agentRemarks", txtRemarks.Text.Trim()),
                                                new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK),
                                                new MySqlParameter("@createPK", AppVariable.CURRENT_USER_PK));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Add New Agent Name.");

                             DialogResult dr = MessageBox.Show("Save is successful. Do you want to create other test name?", "MediPro :: Clinic System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (dr == DialogResult.Yes)
                            {
                                txtName.Text = string.Empty;
                                txtName.Tag = string.Empty;
                                txtRemarks.Text = string.Empty;
                                txtAddress.Text = string.Empty;
                                txtPhone.Text = string.Empty;
                                

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
