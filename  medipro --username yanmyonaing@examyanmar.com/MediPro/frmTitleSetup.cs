using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using exaCore;

namespace MediPro
{
    public partial class frmTitleSetup : Form
    {
        clsSQL SqlDb = new clsSQL();

        DataRow drTitle;
        int curIndex;

        public frmTitleSetup()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTitleSetup_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
            int y = (Screen.PrimaryScreen.WorkingArea.Height - pnlBackground.Height) /2;
            int x = (Screen.PrimaryScreen.WorkingArea.Width - pnlBackground.Width) / 2;

            pnlBackground.Location = new Point(x, y);

            BindingTitle();

            if (grdViewTitle.RowCount > 0)
            {
                drTitle = grdViewTitle.GetDataRow(grdViewTitle.FocusedRowHandle);
            }
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            if (SqlDb.IsAllow(AppVariable.CURRENT_SUB_MENU, AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsInsert") == true)
            {
                curIndex = grdViewTitle.RowCount;

                frmTitleDetail TitleDetailForm = new frmTitleDetail();

                TitleDetailForm.txtTitle.Tag = string.Empty;
                TitleDetailForm.txtTitle.Text = string.Empty;
                TitleDetailForm.cmdSave.Tag = "Add";
                TitleDetailForm.ShowDialog();

                BindingTitle();
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BindingTitle()
        {
            DataSet dsTitle = SqlDb.GetDataSet("SELECT titlePK, TitleName, isActive FROM tblTitle WHERE isDelete = 0");
            grdTitle.DataSource = dsTitle.Tables[0];

            grdViewTitle.FocusedRowHandle = curIndex;
        }

        private void grdViewTitle_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (grdViewTitle.RowCount > 0)
            {
                drTitle = grdViewTitle.GetDataRow(grdViewTitle.FocusedRowHandle);
            }
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            //if (SqlDb.IsAllow(AppVariable.CURRENT_SUB_MENU, AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsEdit") == true)
            //{
            //    frmTitleDetail TitleDetailForm = new frmTitleDetail();

            //    TitleDetailForm.txtTitle.Tag = drTitle.ItemArray[0].ToString();
            //    TitleDetailForm.txtTitle.Text = drTitle.ItemArray[1].ToString();
            //    TitleDetailForm.chkIsActive.EditValue = bool.Parse(drTitle.ItemArray[2].ToString());
            //    TitleDetailForm.cmdSave.Tag = "Edit";

            //    TitleDetailForm.ShowDialog();

            //    BindingTitle();
            //}
            //else
            //{
            //    MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void grdViewTitle_DoubleClick(object sender, EventArgs e)
        {
            if (SqlDb.IsAllow(AppVariable.CURRENT_SUB_MENU, AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsEdit") == true)
            {
                curIndex = grdViewTitle.GetDataSourceRowIndex(grdViewTitle.FocusedRowHandle);

                frmTitleDetail TitleDetailForm = new frmTitleDetail();

                TitleDetailForm.txtTitle.Tag = drTitle.ItemArray[0].ToString();
                TitleDetailForm.txtTitle.Text = drTitle.ItemArray[1].ToString();
                TitleDetailForm.chkIsActive.EditValue = bool.Parse(drTitle.ItemArray[2].ToString());
                TitleDetailForm.cmdSave.Tag = "Edit";

                TitleDetailForm.ShowDialog();

                BindingTitle();
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void grdViewTitle_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (grdViewTitle.RowCount > 0)
            {
                drTitle = grdViewTitle.GetDataRow(grdViewTitle.FocusedRowHandle);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet dsTitle = SqlDb.GetDataSet("SELECT titlePK, TitleName, isActive FROM tblTitle WHERE isDelete = 0 and TitleName like '%"+txtSearch.Text+"'");
            grdTitle.DataSource = dsTitle.Tables[0];

            grdViewTitle.FocusedRowHandle = curIndex;
        }
    }
}
