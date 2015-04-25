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
    public partial class frmFrequencyDetail : Form
    {
        clsSQL SqlDb = new clsSQL();

        public frmFrequencyDetail()
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
                int FreCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblFrequency WHERE frequency=@Frequency AND isDelete=0", new MySqlParameter("@Frequency", txtFrequency.Text.Trim()));

                if (FreCnt > 0 && cmdSave.Tag.ToString() == "Add")
                {
                    MessageBox.Show("Your specialize is already exit. Please check your frequency.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFrequency.Focus();
                    txtFrequency.SelectAll();
                }
                else
                {
                    if (txtFrequency.Tag.ToString().Length > 0)
                    {
                        int FreIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblFrequency WHERE frequencyPK=@FrequencyPK AND isDelete=0", new MySqlParameter("@FrequencyPK", txtFrequency.Tag.ToString()));

                        if (FreIDCnt > 0)
                        {
                            SqlDb.ExecuteQuery("UPDATE tblFrequency SET frequency=@Frequency,treatmentPK=@TreatmentPK,isActive=@IsActive,updateDate=NOW(),updatePK=@UpdatePK WHERE frequencyPK=@FrequencyPK",
                                            new MySqlParameter("@FrequencyPK", txtFrequency.Tag.ToString()),
                                            new MySqlParameter("@Frequency", txtFrequency.Text.Trim()),
                                            new MySqlParameter("@TreatmentPK", cboTreatmentType.SelectedValue),
                                            new MySqlParameter("@IsActive", chkIsActive.EditValue),
                                            new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK.ToString()));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Update Frequency.");

                            MessageBox.Show("Update is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        int FreID = SqlDb.ExecuteScalar<int>("getID tblFrequency");

                        int FreIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblFrequency WHERE frequencyPK=@FrequencyPK AND isDelete=0", new MySqlParameter("@FrequencyPK", FreID));

                        if (FreIDCnt < 1)
                        {
                            SqlDb.ExecuteQuery("INSERT INTO tblFrequency(frequencyPK,frequency,treatmentPK,isActive,updateDate,updatePK,createDate,createPK) " +
                                                "VALUES(@FrequencyPK,@Frequency,@TreatmentPK,@IsActive,NOW(),@updatePK,NOW(),@createPK)",
                                                new MySqlParameter("@FrequencyPK", FreID),
                                                new MySqlParameter("@Frequency", txtFrequency.Text.Trim()),
                                                new MySqlParameter("@TreatmentPK", cboTreatmentType.SelectedValue),
                                                new MySqlParameter("@IsActive", chkIsActive.EditValue),
                                                new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK),
                                                new MySqlParameter("@createPK", AppVariable.CURRENT_USER_PK));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Add New Frequency.");

                            DialogResult dr = MessageBox.Show("Save is successful. Do you want to create other frequency?", "MediPro :: Clinic System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (dr == DialogResult.Yes)
                            {
                                txtFrequency.Text = string.Empty;
                                txtFrequency.Tag = string.Empty;

                                chkIsActive.EditValue = true;

                                txtFrequency.Focus();
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

        private void BindingTrementType()
        {
            DataSet dsTreatment = SqlDb.GetDataSet("SELECT treatmentPK, treatmentType FROM tblTreatmentType");

            try
            {
                cboTreatmentType.DataSource = dsTreatment.Tables[0];
                cboTreatmentType.DisplayMember = "treatmentType";
                cboTreatmentType.ValueMember = "treatmentPK";
                cboTreatmentType.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidateForm()
        {
            bool value = true;
            if (txtFrequency.Text.Length < 1)
            {
                MessageBox.Show("Please enter Frequency.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                txtFrequency.Focus();
            }
            else if (cboTreatmentType.Text.Length < 1)
            {
                MessageBox.Show("Please select Treatment Type.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                cboTreatmentType.Focus();
            }
            
            return value;
        }

        private void frmFrequencyDetail_Load(object sender, EventArgs e)
        {
            BindingTrementType();

            if (cmdSave.Tag.ToString() == "Add")
                FormClean("Add");

            if (cmdSave.Tag.ToString() == "Edit")
                cboTreatmentType.SelectedValue = cboTreatmentType.Tag.ToString(); 
        }

        private void FormClean(string status)
        {
            if (status == "Add")
            {
                txtFrequency.Text = string.Empty;
                txtFrequency.Tag = string.Empty;

                cboTreatmentType.SelectedIndex = -1;
                chkIsActive.Checked = true;
            }            
        }
    }
}
