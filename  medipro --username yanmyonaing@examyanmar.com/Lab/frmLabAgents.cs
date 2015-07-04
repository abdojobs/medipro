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
using System.Data;

namespace Lab
{
    public partial class frmLabAgents : Form
    {
        clsSQL SqlDb = new clsSQL();
        DataRow dr;
        int curIndex;

        public frmLabAgents()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLabAgents_Load(object sender, EventArgs e)
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
            DataSet ds = SqlDb.GetDataSet("SELECT * FROM tblAgent");
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

                frmLabAgent detailForm = new frmLabAgent();

                detailForm.txtName.Tag = dr["agentPK"].ToString();
                detailForm.txtName.Text = dr["agentName"].ToString();
                detailForm.txtPhone.Text = dr["agentPhone"].ToString();
                detailForm.txtAddress.Text = dr["agentAddress"].ToString();
                detailForm.txtRemarks.Text = dr["agentRemarks"].ToString();

                detailForm.chkIsActive.EditValue = true;
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

                frmLabAgent detailForm = new frmLabAgent();

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
            DataSet ds = SqlDb.GetDataSet("SELECT * FROM tblAgent WHERE agentName like '%" + txtSearch.Text + "%'");
            grd.DataSource = ds.Tables[0];

            grdView.FocusedRowHandle = curIndex;
        }
    }
}
