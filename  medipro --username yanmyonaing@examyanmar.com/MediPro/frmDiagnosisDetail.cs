﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using exaCore;
using System.Data.SqlClient;

namespace MediPro
{
    public partial class frmDiagnosisDetail : Form
    {
        clsSQL SqlDb = new clsSQL();

        public frmDiagnosisDetail()
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
                int DiagCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblDiagnosis WHERE diagnosis=@Diagnosis AND isDelete=0", new SqlParameter("@Diagnosis", txtDiagnosis.Text.Trim()));

                if (DiagCnt > 0 && cmdSave.Tag.ToString() == "Add")
                {
                    MessageBox.Show("Your specialize is already exit. Please check your diagnosis.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDiagnosis.Focus();
                    txtDiagnosis.SelectAll();
                }
                else
                {
                    if (txtDiagnosis.Tag.ToString().Length > 0)
                    {
                        int DiagIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblDiagnosis WHERE diagnosisPK=@DiagnosisPK AND isDelete=0", new SqlParameter("@DiagnosisPK", txtDiagnosis.Tag.ToString()));

                        if (DiagIDCnt > 0)
                        {
                            SqlDb.ExecuteQuery("UPDATE tblDiagnosis SET diagnosis=@Diagnosis,isActive=@IsActive,updateDate=SYSDATETIME(),updatePK=@UpdatePK WHERE diagnosisPK=@DiagnosisPK",
                                            new SqlParameter("@DiagnosisPK", txtDiagnosis.Tag.ToString()),
                                            new SqlParameter("@Diagnosis", txtDiagnosis.Text.Trim()),
                                            new SqlParameter("@IsActive", chkIsActive.EditValue),
                                            new SqlParameter("@updatePK", AppVariable.CURRENT_USER_PK.ToString()));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Update diagnosis.");

                            MessageBox.Show("Update is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        int DiagID = SqlDb.ExecuteScalar<int>("getID tblDiagnosis");

                        int DiagIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblDiagnosis WHERE diagnosisPK=@DiagnosisPK AND isDelete=0", new SqlParameter("@DiagnosisPK", DiagID));

                        if (DiagIDCnt < 1)
                        {
                            SqlDb.ExecuteQuery("INSERT INTO tblDiagnosis(diagnosisPK,diagnosis,isActive,updateDate,updatePK,createDate,createPK) " +
                                                "VALUES(@DiagnosisPK,@Diagnosis,@IsActive,SYSDATETIME(),@updatePK,SYSDATETIME(),@createPK)",
                                                new SqlParameter("@DiagnosisPK", DiagID),
                                                new SqlParameter("@Diagnosis", txtDiagnosis.Text.Trim()),
                                                new SqlParameter("@IsActive", chkIsActive.EditValue),
                                                new SqlParameter("@updatePK", AppVariable.CURRENT_USER_PK),
                                                new SqlParameter("@createPK", AppVariable.CURRENT_USER_PK));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Add New diagnosis.");

                            DialogResult dr = MessageBox.Show("Save is successful. Do you want to create other diagnosis?", "MediPro :: Clinic System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (dr == DialogResult.Yes)
                            {
                                txtDiagnosis.Text = string.Empty;
                                txtDiagnosis.Tag = string.Empty;

                                chkIsActive.EditValue = true;

                                txtDiagnosis.Focus();
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
            if (txtDiagnosis.Text.Length < 1)
            {
                MessageBox.Show("Please enter diagnosis.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                txtDiagnosis.Focus();
            }
            return value;
        }
    }
}
