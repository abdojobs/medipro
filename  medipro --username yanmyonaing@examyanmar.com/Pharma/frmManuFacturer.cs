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

namespace Pharma
{
    public partial class frmManufacturer : Form
    {
        clsSQL SqlDb = new clsSQL();
        DataRow dr;
        int curIndex;

        public frmManufacturer()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManufacturer_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            int y = (Screen.PrimaryScreen.WorkingArea.Height - pnlBackground.Height) / 2;
            int x = (Screen.PrimaryScreen.WorkingArea.Width - pnlBackground.Width) / 2;

            pnlBackground.Location = new Point(x, y);

            Binding();

            GetDataRow();
        }

        private void Binding()
        {
            DataSet ds = SqlDb.GetDataSet("SELECT manuPK, manuName,manuContact,manuAddress,manuEmail,manuCountry, isActive FROM tblManufacturer WHERE isDelete = 0");
            grd.DataSource = ds.Tables[0];

            grdView.FocusedRowHandle = curIndex;
        }

        private void GetDataRow()
        {
            if (grdView.RowCount > 0)
            {
                dr = grdView.GetDataRow(grdView.FocusedRowHandle);
            }
        }

        private void Edit()
        {
            if (SqlDb.IsAllow(AppVariable.CURRENT_SUB_MENU, AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsEdit") == true)
            {
                curIndex = grdView.GetDataSourceRowIndex(grdView.FocusedRowHandle);

                frmManufacturerDetail detailForm = new frmManufacturerDetail();

                detailForm.txtName.Tag = dr.ItemArray[0].ToString();
                detailForm.txtName.Text = dr.ItemArray[1].ToString();
                detailForm.txtContact.Text = dr.ItemArray[2].ToString();
                detailForm.txtAddress.Text = dr.ItemArray[3].ToString();
                detailForm.txtEmail.Text = dr.ItemArray[4].ToString();
                detailForm.cboCountry.Text = dr.ItemArray[5].ToString();
                detailForm.chkIsActive.EditValue = bool.Parse(dr.ItemArray[6].ToString());
                detailForm.cmdSave.Tag = "Edit";

                detailForm.ShowDialog();

                Binding();
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
                curIndex = grdView.RowCount;

                frmManufacturerDetail detailForm = new frmManufacturerDetail();

                detailForm.txtName.Tag = string.Empty;
                detailForm.txtName.Text = string.Empty;
                detailForm.cmdSave.Tag = "Add";
                detailForm.ShowDialog();

                Binding();
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

        private void grdView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GetDataRow();
        }

        private void grdView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            GetDataRow();
        }

        private void grdView_DoubleClick(object sender, EventArgs e)
        {
            Edit();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = SqlDb.GetDataSet("SELECT manuPK, manuName,manuContact,manuAddress,manuEmail,manuCountry, isActive FROM tblManufacturer WHERE isDelete = 0 and manuName like '%" + txtSearch.Text + "%'");
            grd.DataSource = ds.Tables[0];

            grdView.FocusedRowHandle = curIndex;
        }
    }
}
