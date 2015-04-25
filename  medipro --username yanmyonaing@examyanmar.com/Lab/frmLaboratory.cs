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
    public partial class frmLaboratory : Form
    {
        clsSQL SqlDb = new clsSQL();
        DataRow drLab;
        int curIndex;

        public frmLaboratory()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLaboratory_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            int y = (Screen.PrimaryScreen.WorkingArea.Height - pnlBackground.Height) / 2;
            int x = (Screen.PrimaryScreen.WorkingArea.Width - pnlBackground.Width) / 2;

            pnlBackground.Location = new Point(x, y);

            BindingLab();

            GetDataRow();
        }

        private void BindingLab()
        {
            DataSet dsLab = SqlDb.GetDataSet("SELECT labPK, labName, isActive FROM tblLaboratory WHERE isDelete = 0");
            grdLaboratory.DataSource = dsLab.Tables[0];

            grdViewLaboratory.FocusedRowHandle = curIndex;
        }

        private void GetDataRow()
        {
            if (grdViewLaboratory.RowCount > 0)
            {
                drLab = grdViewLaboratory.GetDataRow(grdViewLaboratory.FocusedRowHandle);
            }
        }

        private void Edit()
        {
            if (SqlDb.IsAllow(AppVariable.CURRENT_SUB_MENU, AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsEdit") == true)
            {
                curIndex = grdViewLaboratory.GetDataSourceRowIndex(grdViewLaboratory.FocusedRowHandle);

                frmLaboratoryDetail LabDetailForm = new frmLaboratoryDetail();

                LabDetailForm.txtName.Tag = drLab.ItemArray[0].ToString();
                LabDetailForm.txtName.Text = drLab.ItemArray[1].ToString();
                LabDetailForm.chkIsActive.EditValue = bool.Parse(drLab.ItemArray[2].ToString());
                LabDetailForm.cmdSave.Tag = "Edit";

                LabDetailForm.ShowDialog();

                BindingLab();
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            if (SqlDb.IsAllow(AppVariable.CURRENT_SUB_MENU, AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsInsert") == true)
            {
                curIndex = grdViewLaboratory.RowCount;

                frmLaboratoryDetail LabDetailForm = new frmLaboratoryDetail();

                LabDetailForm.txtName.Tag = string.Empty;
                LabDetailForm.txtName.Text = string.Empty;
                LabDetailForm.cmdSave.Tag = "Add";
                LabDetailForm.ShowDialog();

                BindingLab();
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

        private void grdViewLaboratory_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GetDataRow();
        }

        private void grdViewLaboratory_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            GetDataRow();
        }

        private void grdViewLaboratory_DoubleClick(object sender, EventArgs e)
        {
            Edit();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet dsLab = SqlDb.GetDataSet("SELECT labPK, labName, isActive FROM tblLaboratory WHERE isDelete = 0 and labName like '%"+txtSearch.Text+"%'");
            grdLaboratory.DataSource = dsLab.Tables[0];

            grdViewLaboratory.FocusedRowHandle = curIndex;
        }
    }
}
