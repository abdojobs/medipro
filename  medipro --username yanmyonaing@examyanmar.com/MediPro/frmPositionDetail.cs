﻿using System;
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
    public partial class frmPositionDetail : Form
    {
        clsSQL SqlDb = new clsSQL();

        public frmPositionDetail()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateForm()
        {
            bool value = true;
            if (txtPosition.Text.Length < 1)
            {
                MessageBox.Show("Please enter position.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                txtPosition.Focus();
            }
            return value;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == true)
            {
                int SpecCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblPosition WHERE position=@Position AND isDelete=0", new MySqlParameter("@Position", txtPosition.Text.Trim()));

                if (SpecCnt > 0 && cmdSave.Tag.ToString() == "Add")
                {
                    MessageBox.Show("Your specialize is already exit. Please check your position.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPosition.Focus();
                    txtPosition.SelectAll();
                }
                else
                {
                    if (txtPosition.Tag.ToString().Length > 0)
                    {
                        int PosiIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblPosition WHERE positionPK=@PositionPK AND isDelete=0", new MySqlParameter("@PositionPK", txtPosition.Tag.ToString()));

                        if (PosiIDCnt > 0)
                        {
                            SqlDb.ExecuteQuery("UPDATE tblPosition SET position=@Position,isActive=@IsActive,updateDate=NOW(),updatePK=@UpdatePK WHERE positionPK=@PositionPK",
                                            new MySqlParameter("@PositionPK", txtPosition.Tag.ToString()),
                                            new MySqlParameter("@Position", txtPosition.Text.Trim()),
                                            new MySqlParameter("@IsActive", chkIsActive.EditValue),
                                            new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK.ToString()));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Update Position.");

                            MessageBox.Show("Update is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        int PosiID = SqlDb.ExecuteScalar<int>("Call getID ('tblPosition')");

                        int PosiIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblPosition WHERE positionPK=@PositionPK AND isDelete=0", new MySqlParameter("@PositionPK", PosiID));

                        if (PosiIDCnt < 1)
                        {
                            SqlDb.ExecuteQuery("INSERT INTO tblPosition(positionPK,position,isActive,updateDate,updatePK,createDate,createPK) " +
                                                "VALUES(@PositionPK,@Position,@IsActive,NOW(),@updatePK,NOW(),@createPK)",
                                                new MySqlParameter("@PositionPK", PosiID),
                                                new MySqlParameter("@Position", txtPosition.Text.Trim()),
                                                new MySqlParameter("@IsActive", chkIsActive.EditValue),
                                                new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK),
                                                new MySqlParameter("@createPK", AppVariable.CURRENT_USER_PK));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Add New Position.");

                            DialogResult dr = MessageBox.Show("Save is successful. Do you want to create other position?", "MediPro :: Clinic System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (dr == DialogResult.Yes)
                            {
                                txtPosition.Text = string.Empty;
                                txtPosition.Tag = string.Empty;

                                chkIsActive.EditValue = true;

                                txtPosition.Focus();
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
    }
}
