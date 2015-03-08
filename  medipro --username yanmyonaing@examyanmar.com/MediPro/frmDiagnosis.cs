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
    public partial class frmDiagnosis : Form
    {
        clsSQL SqlDb = new clsSQL();
        DataRow drDiagnosis;
        int curIndex;

        public frmDiagnosis()
        {
            InitializeComponent();
        }

        private void grdViewDiagnosis_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GetDataRow();
        }

        private void grdViewDiagnosis_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            GetDataRow();
        }

        private void grdViewDiagnosis_DoubleClick(object sender, EventArgs e)
        {
            Edit();
        }

        private void frmDiagnosis_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            int y = (Screen.PrimaryScreen.WorkingArea.Height - pnlBackground.Height) / 2;
            int x = (Screen.PrimaryScreen.WorkingArea.Width - pnlBackground.Width) / 2;

            pnlBackground.Location = new Point(x, y);

            BindingDiagnosis();

            GetDataRow();
        }

        private void BindingDiagnosis()
        {
            DataSet dsDiagnosis = SqlDb.GetDataSet("SELECT diagnosisPK, diagnosis, isActive FROM tblDiagnosis WHERE isDelete = 0");
            grdDiagnosis.DataSource = dsDiagnosis.Tables[0];

            grdViewDiagnosis.FocusedRowHandle = curIndex;
        }

        private void GetDataRow()
        {
            if (grdViewDiagnosis.RowCount > 0)
            {
                drDiagnosis = grdViewDiagnosis.GetDataRow(grdViewDiagnosis.FocusedRowHandle);
            }
        }

        private void Edit()
        {
            if (SqlDb.IsAllow(AppVariable.CURRENT_SUB_MENU, AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsEdit") == true)
            {
                curIndex = grdViewDiagnosis.GetDataSourceRowIndex(grdViewDiagnosis.FocusedRowHandle);

                frmDiagnosisDetail DiagnosisDetailForm = new frmDiagnosisDetail();

                DiagnosisDetailForm.txtDiagnosis.Tag = drDiagnosis.ItemArray[0].ToString();
                DiagnosisDetailForm.txtDiagnosis.Text = drDiagnosis.ItemArray[1].ToString();
                DiagnosisDetailForm.chkIsActive.EditValue = bool.Parse(drDiagnosis.ItemArray[2].ToString());
                DiagnosisDetailForm.cmdSave.Tag = "Edit";

                DiagnosisDetailForm.ShowDialog();

                BindingDiagnosis();
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

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            if (SqlDb.IsAllow(AppVariable.CURRENT_SUB_MENU, AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsInsert") == true)
            {
                curIndex = grdViewDiagnosis.RowCount;

                frmDiagnosisDetail DiagnosisDetailForm = new frmDiagnosisDetail();

                DiagnosisDetailForm.txtDiagnosis.Tag = string.Empty;
                DiagnosisDetailForm.txtDiagnosis.Text = string.Empty;
                DiagnosisDetailForm.cmdSave.Tag = "Add";
                DiagnosisDetailForm.ShowDialog();

                BindingDiagnosis();
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet dsDiagnosis = SqlDb.GetDataSet("SELECT diagnosisPK, diagnosis, isActive FROM tblDiagnosis WHERE isDelete = 0 and diagnosis like '%"+txtSearch.Text+"%'");
            grdDiagnosis.DataSource = dsDiagnosis.Tables[0];

            grdViewDiagnosis.FocusedRowHandle = curIndex;
        }
    }
}
