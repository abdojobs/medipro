using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MediPro.Class;
using System.Data.SqlClient;

namespace MediPro
{
    public partial class frmFrequency : Form
    {
        clsSQL SqlDb = new clsSQL();
        DataRow drFrequency;
        int curIndex;

        public frmFrequency()
        {
            InitializeComponent();
        }

        private void grdViewFrequency_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GetDataRow();
        }

        private void frmFrequency_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            int y = (Screen.PrimaryScreen.WorkingArea.Height - pnlBackground.Height) / 2;
            int x = (Screen.PrimaryScreen.WorkingArea.Width - pnlBackground.Width) / 2;

            pnlBackground.Location = new Point(x, y);

            BindingFrequency();

            GetDataRow();
        }

        private void grdViewFrequency_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            GetDataRow();
        }

        private void grdViewFrequency_DoubleClick(object sender, EventArgs e)
        {
            Edit();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            if (SqlDb.IsAllow(AppVariable.CURRENT_SUB_MENU, AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsInsert") == true)
            {
                curIndex = grdViewFrequency.RowCount;

                frmFrequencyDetail FrequencyDetailForm = new frmFrequencyDetail();

                FrequencyDetailForm.txtFrequency.Tag = string.Empty;
                FrequencyDetailForm.txtFrequency.Text = string.Empty;
                FrequencyDetailForm.cboTreatmentType.Tag = string.Empty;
                FrequencyDetailForm.cmdSave.Tag = "Add";
                FrequencyDetailForm.ShowDialog();

                BindingFrequency();
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void BindingFrequency()
        {
            DataSet dsDiagnosis = SqlDb.GetDataSet("SELECT tblFrequency.frequencyPK, tblFrequency.frequency, tblTreatmentType.treatmentType, tblFrequency.isActive, tblFrequency.treatmentPK " +
                                                    "FROM tblFrequency INNER JOIN tblTreatmentType ON tblFrequency.treatmentPK = tblTreatmentType.treatmentPK WHERE isDelete = 0");
            grdFrequency.DataSource = dsDiagnosis.Tables[0];

            grdViewFrequency.FocusedRowHandle = curIndex;
        }

        private void GetDataRow()
        {
            if (grdViewFrequency.RowCount > 0)
            {
                drFrequency = grdViewFrequency.GetDataRow(grdViewFrequency.FocusedRowHandle);
            }
        }

        private void Edit()
        {
            if (SqlDb.IsAllow(AppVariable.CURRENT_SUB_MENU, AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsEdit") == true)
            {
                curIndex = grdViewFrequency.GetDataSourceRowIndex(grdViewFrequency.FocusedRowHandle);

                frmFrequencyDetail FrequencyDetailForm = new frmFrequencyDetail();

                FrequencyDetailForm.txtFrequency.Tag = drFrequency.ItemArray[0].ToString();
                FrequencyDetailForm.txtFrequency.Text = drFrequency.ItemArray[1].ToString();
                FrequencyDetailForm.cboTreatmentType.Tag = drFrequency.ItemArray[4].ToString();
                FrequencyDetailForm.chkIsActive.EditValue = bool.Parse(drFrequency.ItemArray[3].ToString());
                FrequencyDetailForm.cmdSave.Tag = "Edit";

                FrequencyDetailForm.ShowDialog();

                BindingFrequency();
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet dsDiagnosis = SqlDb.GetDataSet("SELECT tblFrequency.frequencyPK, tblFrequency.frequency, tblTreatmentType.treatmentType, tblFrequency.isActive, tblFrequency.treatmentPK " +
                                                    "FROM tblFrequency INNER JOIN tblTreatmentType ON tblFrequency.treatmentPK = tblTreatmentType.treatmentPK WHERE isDelete = 0 and tblFrequency.frequency like '%"+txtSearch.Text+"%'");
            grdFrequency.DataSource = dsDiagnosis.Tables[0];

            grdViewFrequency.FocusedRowHandle = curIndex;
        }
    }
}
