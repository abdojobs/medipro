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
    public partial class frmPositions : Form
    {
        clsSQL SqlDb = new clsSQL();
        DataRow drPosition;
        int curIndex;

        public frmPositions()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdViewPosition_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GetDataRow();
        }

        private void grdViewPosition_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            GetDataRow();
        }

        private void grdViewPosition_DoubleClick(object sender, EventArgs e)
        {
            Edit();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            if (SqlDb.IsAllow(AppVariable.CURRENT_SUB_MENU, AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsInsert") == true)
            {
                curIndex = grdViewPosition.RowCount;

                frmPositionDetail PositionDetailForm = new frmPositionDetail();

                PositionDetailForm.txtPosition.Tag = string.Empty;
                PositionDetailForm.txtPosition.Text = string.Empty;
                PositionDetailForm.cmdSave.Tag = "Add";
                PositionDetailForm.ShowDialog();

                BindingPosition();
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

        private void frmPositions_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            int y = (Screen.PrimaryScreen.WorkingArea.Height - pnlBackground.Height) / 2;
            int x = (Screen.PrimaryScreen.WorkingArea.Width - pnlBackground.Width) / 2;

            pnlBackground.Location = new Point(x, y);

            BindingPosition();

            GetDataRow();
        }

        private void BindingPosition()
        {
            DataSet dsPosition = SqlDb.GetDataSet("SELECT positionPK, position, isActive FROM tblPosition WHERE isDelete = 0");
            grdPosition.DataSource = dsPosition.Tables[0];

            grdViewPosition.FocusedRowHandle = curIndex;
        }

        private void GetDataRow()
        {
            if (grdViewPosition.RowCount > 0)
            {
                drPosition = grdViewPosition.GetDataRow(grdViewPosition.FocusedRowHandle);
            }
        }

        private void Edit()
        {
            if (SqlDb.IsAllow(AppVariable.CURRENT_SUB_MENU, AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsEdit") == true)
            {
                curIndex = grdViewPosition.GetDataSourceRowIndex(grdViewPosition.FocusedRowHandle);

                frmPositionDetail PositionDetailForm = new frmPositionDetail();

                PositionDetailForm.txtPosition.Tag = drPosition.ItemArray[0].ToString();
                PositionDetailForm.txtPosition.Text = drPosition.ItemArray[1].ToString();
                PositionDetailForm.chkIsActive.EditValue = bool.Parse(drPosition.ItemArray[2].ToString());
                PositionDetailForm.cmdSave.Tag = "Edit";

                PositionDetailForm.ShowDialog();

                BindingPosition();
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet dsPosition = SqlDb.GetDataSet("SELECT positionPK, position, isActive FROM tblPosition WHERE isDelete = 0 and position like '%"+txtSearch.Text+"%'");
            grdPosition.DataSource = dsPosition.Tables[0];

            grdViewPosition.FocusedRowHandle = curIndex;
        }
    }
}
