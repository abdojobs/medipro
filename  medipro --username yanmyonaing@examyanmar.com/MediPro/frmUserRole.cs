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
    public partial class frmUserRole : Form
    {
        clsSQL SqlDb = new clsSQL();
        DataRow drUserRole;
        int curIndex;

        public frmUserRole()
        {
            InitializeComponent();
        }

        private void grdViewUserRole_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GetDataRow();
        }

        private void grdViewUserRole_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            GetDataRow();
        }

        private void grdViewUserRole_DoubleClick(object sender, EventArgs e)
        {
            Edit();
        }

        private void frmUserRole_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            int y = (Screen.PrimaryScreen.WorkingArea.Height - pnlBackground.Height) / 2;
            int x = (Screen.PrimaryScreen.WorkingArea.Width - pnlBackground.Width) / 2;

            pnlBackground.Location = new Point(x, y);

            BindingUserRole();

            GetDataRow();
        }

        private void BindingUserRole()
        {
            DataSet dsUserRole = SqlDb.GetDataSet("SELECT rolePK, roleName, isActive FROM sysroles WHERE isDelete = 0");
            grdUserRole.DataSource = dsUserRole.Tables[0];

            grdViewUserRole.FocusedRowHandle = curIndex;
        }

        private void GetDataRow()
        {
            if (grdViewUserRole.RowCount > 0)
            {
                drUserRole = grdViewUserRole.GetDataRow(grdViewUserRole.FocusedRowHandle);
            }
        }

        private void Edit()
        {
            curIndex = grdViewUserRole.RowCount;

            frmUserRoleDetail.intRolePK = int.Parse(drUserRole["rolePK"].ToString());

            frmUserRoleDetail UserRoleDetailForm = new frmUserRoleDetail();

            UserRoleDetailForm.ShowDialog();

            BindingUserRole();
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
                curIndex = grdViewUserRole.RowCount;

                frmUserRoleDetail.intRolePK = 0;
                frmUserRoleDetail UserRoleDetailForm = new frmUserRoleDetail();
                UserRoleDetailForm.ShowDialog();

                BindingUserRole();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet dsUserRole = SqlDb.GetDataSet("SELECT rolePK, roleName, isActive FROM sysroles WHERE isDelete = 0 and roleName like '%" + txtSearch.Text + "%'");
            grdUserRole.DataSource = dsUserRole.Tables[0];

            grdViewUserRole.FocusedRowHandle = curIndex;
        }
    }
}
