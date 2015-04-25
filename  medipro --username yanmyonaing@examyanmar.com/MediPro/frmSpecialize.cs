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
    public partial class frmSpecialize : Form
    {
        clsSQL SqlDb = new clsSQL();
        DataRow drSpecialize;
        int curIndex;

        public frmSpecialize()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSpecialize_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            int y = (Screen.PrimaryScreen.WorkingArea.Height - pnlBackground.Height) / 2;
            int x = (Screen.PrimaryScreen.WorkingArea.Width - pnlBackground.Width) / 2;

            pnlBackground.Location = new Point(x, y);

            BindingSpecialize();

            if (grdViewSpecialize.RowCount > 0)
            {                
                drSpecialize= grdViewSpecialize.GetDataRow(grdViewSpecialize.FocusedRowHandle);
            }
        }

        private void BindingSpecialize()
        {
            DataSet dsSpecialize = SqlDb.GetDataSet("SELECT specializePK, specialize, isActive FROM tblSpecialize WHERE isDelete = 0");
            grdSpecialize.DataSource = dsSpecialize.Tables[0];

            grdViewSpecialize.FocusedRowHandle = curIndex;
        }

        private void grdViewSpecialize_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (grdViewSpecialize.RowCount > 0)
            {
                drSpecialize = grdViewSpecialize.GetDataRow(grdViewSpecialize.FocusedRowHandle);
            }
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            if (SqlDb.IsAllow(AppVariable.CURRENT_SUB_MENU, AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsInsert") == true)
            {
                curIndex = grdViewSpecialize.RowCount;

                frmSpecializeDetail SpecializeDetailForm = new frmSpecializeDetail();

                SpecializeDetailForm.txtSpecialize.Tag = string.Empty;
                SpecializeDetailForm.txtSpecialize.Text = string.Empty;
                SpecializeDetailForm.cmdSave.Tag = "Add";
                SpecializeDetailForm.ShowDialog();

                BindingSpecialize();
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            if (SqlDb.IsAllow(AppVariable.CURRENT_SUB_MENU, AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsEdit") == true)
            {
                curIndex = grdViewSpecialize.GetDataSourceRowIndex(grdViewSpecialize.FocusedRowHandle);

                frmSpecializeDetail SpecializeDetailForm = new frmSpecializeDetail();

                SpecializeDetailForm.txtSpecialize.Tag = drSpecialize.ItemArray[0].ToString();
                SpecializeDetailForm.txtSpecialize.Text = drSpecialize.ItemArray[1].ToString();
                SpecializeDetailForm.chkIsActive.EditValue = bool.Parse(drSpecialize.ItemArray[2].ToString());
                SpecializeDetailForm.cmdSave.Tag = "Edit";

                SpecializeDetailForm.ShowDialog();

                BindingSpecialize();
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void grdViewSpecialize_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (grdViewSpecialize.RowCount > 0)
            {
                drSpecialize = grdViewSpecialize.GetDataRow(grdViewSpecialize.FocusedRowHandle);
            }
        }

        private void grdViewSpecialize_DoubleClick(object sender, EventArgs e)
        {
            if (SqlDb.IsAllow(AppVariable.CURRENT_SUB_MENU, AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsEdit") == true)
            {
                curIndex = grdViewSpecialize.GetDataSourceRowIndex(grdViewSpecialize.FocusedRowHandle);

                frmSpecializeDetail SpecializeDetailForm = new frmSpecializeDetail();

                SpecializeDetailForm.txtSpecialize.Tag = drSpecialize.ItemArray[0].ToString();
                SpecializeDetailForm.txtSpecialize.Text = drSpecialize.ItemArray[1].ToString();
                SpecializeDetailForm.chkIsActive.EditValue = bool.Parse(drSpecialize.ItemArray[2].ToString());
                SpecializeDetailForm.cmdSave.Tag = "Edit";

                SpecializeDetailForm.ShowDialog();

                BindingSpecialize();
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet dsSpecialize = SqlDb.GetDataSet("SELECT specializePK, specialize, isActive FROM tblSpecialize WHERE isDelete = 0 and specialize like '%"+txtSearch.Text +"%'");
            grdSpecialize.DataSource = dsSpecialize.Tables[0];

            grdViewSpecialize.FocusedRowHandle = curIndex;
        }
    }
}
