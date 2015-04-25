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
    public partial class frmUser : Form
    {

        clsSQL SqlDb = new clsSQL();

        DataRow drUser;
        int curIndex;

        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            int y = (Screen.PrimaryScreen.WorkingArea.Height - pnlUser.Height) / 2;
            int x = (Screen.PrimaryScreen.WorkingArea.Width - pnlUser.Width) / 2;

            pnlUser.Location = new Point(x, y);

            BindingUser();

            if (grdViewUser.RowCount > 0)
            {
                drUser = grdViewUser.GetDataRow(grdViewUser.FocusedRowHandle);
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdCreate_Click(object sender, EventArgs e)
        {
            if (SqlDb.IsAllow(AppVariable.CURRENT_SUB_MENU, AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsInsert") == true)
            {
                curIndex = grdViewUser.RowCount;

                frmUserDetail UserDetailForm = new frmUserDetail();

                UserDetailForm.txtLoginID.Tag = string.Empty;
                UserDetailForm.cmdSave.Tag = "Add";

                UserDetailForm.ShowDialog();

                BindingUser();
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BindingUser()
        {
            DataSet dsUser = SqlDb.GetDataSet("SELECT sysUser.PK, sysUser.name, sysUser.login, sysUser.passw, sysUserLevel.UserLevel, sysUser.levelPK, " +
                                            "sysUser.createPK, sysUser.createDate, sysUser.updatePK, sysUser.updateDate, sysUser.isActive " +
                                            "FROM sysUser INNER JOIN sysUserLevel ON sysUser.levelPK = sysUserLevel.levelPK WHERE isDelete = 0");
            grdUser.DataSource = dsUser.Tables[0];

            grdViewUser.FocusedRowHandle = curIndex;
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void grdViewUser_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (grdViewUser.RowCount > 0)
            {
                drUser = grdViewUser.GetDataRow(grdViewUser.FocusedRowHandle);
            }
        }

        private void grdViewUser_DoubleClick(object sender, EventArgs e)
        {
            Edit();
        }

        private void grdViewUser_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (grdViewUser.RowCount > 0)
            {
                drUser = grdViewUser.GetDataRow(grdViewUser.FocusedRowHandle);
            }
        }

        private void cmdPWDReset_Click(object sender, EventArgs e)
        {
            if (SqlDb.IsAllow(AppVariable.CURRENT_SUB_MENU, AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsEdit") == true)
            {
                curIndex = grdViewUser.GetDataSourceRowIndex(grdViewUser.FocusedRowHandle);

                frmResetPassword ResetPasswordForm = new frmResetPassword();

                ResetPasswordForm.txtNewPassw.Tag = drUser.ItemArray[0].ToString();
                ResetPasswordForm.lblUserName.Text = drUser.ItemArray[1].ToString();
                ResetPasswordForm.lblLoginID.Text = drUser.ItemArray[2].ToString();
                ResetPasswordForm.cmdSave.Tag = "Edit";

                ResetPasswordForm.ShowDialog();

                BindingUser();
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Edit()
        {
            if (SqlDb.IsAllow(AppVariable.CURRENT_SUB_MENU, AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsEdit") == true)
            {
                curIndex = grdViewUser.GetDataSourceRowIndex(grdViewUser.FocusedRowHandle);

                frmUserDetail UserDetailForm = new frmUserDetail();

                UserDetailForm.txtLoginID.Tag = drUser.ItemArray[0].ToString();
                UserDetailForm.txtFullName.Text = drUser.ItemArray[1].ToString();
                UserDetailForm.txtLoginID.Text = drUser.ItemArray[2].ToString();
                UserDetailForm.cboUserLevel.Tag = drUser.ItemArray[5].ToString();
                UserDetailForm.chkIsActive.EditValue = bool.Parse(drUser.ItemArray[10].ToString());
                UserDetailForm.cmdSave.Tag = "Edit";

                UserDetailForm.ShowDialog();

                BindingUser();
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
