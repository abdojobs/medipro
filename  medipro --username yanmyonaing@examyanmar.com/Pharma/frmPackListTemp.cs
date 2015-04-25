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

namespace Pharma
{
    public partial class frmPackListTemp : Form
    {
        clsSQL SqlDb = new clsSQL();
        DataRow drPackListTemp;
        int curIndex;

        public frmPackListTemp()
        {
            InitializeComponent();
        }

        private void grdViewPackListTemp_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GetDataRow();
        }

        private void grdViewPackListTemp_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            GetDataRow();
        }

        private void grdViewPackListTemp_DoubleClick(object sender, EventArgs e)
        {
            Edit();
        }

        private void frmPackListTemp_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            int y = (Screen.PrimaryScreen.WorkingArea.Height - pnlBackground.Height) / 2;
            int x = (Screen.PrimaryScreen.WorkingArea.Width - pnlBackground.Width) / 2;

            pnlBackground.Location = new Point(x, y);

            BindingPackListTemp();

            GetDataRow();
        }

        private void BindingPackListTemp()
        {
            DataSet dsPackListTemp = SqlDb.GetDataSet("SELECT packListPK, packListName, isActive FROM tblPackListTemp WHERE isDelete = 0");
            grdPackListTemp.DataSource = dsPackListTemp.Tables[0];

            grdViewPackListTemp.FocusedRowHandle = curIndex;
        }

        private void GetDataRow()
        {
            if (grdViewPackListTemp.RowCount > 0)
            {
                drPackListTemp = grdViewPackListTemp.GetDataRow(grdViewPackListTemp.FocusedRowHandle);
            }
        }

        private void Edit()
        {

            curIndex = grdViewPackListTemp.GetDataSourceRowIndex(grdViewPackListTemp.FocusedRowHandle);

            frmPackListTempDetail PackListTempDetailForm = new frmPackListTempDetail();

            PackListTempDetailForm.txtPackListTempName.Tag = drPackListTemp.ItemArray[0].ToString();
            PackListTempDetailForm.txtPackListTempName.Text = drPackListTemp.ItemArray[1].ToString();
            PackListTempDetailForm.chkIsActive.Checked = bool.Parse(drPackListTemp.ItemArray[2].ToString());
            PackListTempDetailForm.cmdSave.Tag = "Edit";

            PackListTempDetailForm.ShowDialog();

            BindingPackListTemp();
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
                curIndex = grdViewPackListTemp.RowCount;

                frmPackListTempDetail DiagnosisDetailForm = new frmPackListTempDetail();                

                DiagnosisDetailForm.txtPackListTempName.Tag = '0';
                DiagnosisDetailForm.txtPackListTempName.Text = string.Empty;
                DiagnosisDetailForm.cmdSave.Tag = "Add";
                DiagnosisDetailForm.ShowDialog();

                BindingPackListTemp();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet dsPackListTemp = SqlDb.GetDataSet("SELECT packListPK, packListName, isActive FROM tblPackListTemp WHERE isDelete = 0 and PackListTemp like '%" + txtSearch.Text + "%'");
            grdPackListTemp.DataSource = dsPackListTemp.Tables[0];

            grdViewPackListTemp.FocusedRowHandle = curIndex;
        }
    }
}
