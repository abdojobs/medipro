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
    public partial class frmUserLevel : Form
    {
        clsSQL SqlDb = new clsSQL();

        DataRow drUserLevel;
        int CurMainMenuID;
        int CurLevelID;
        int curIndex;

        public frmUserLevel()
        {
            InitializeComponent();
        }

        private void frmUserLevel_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            int y = (Screen.PrimaryScreen.WorkingArea.Height - pnlUserLevel.Height) / 2;
            int x = (Screen.PrimaryScreen.WorkingArea.Width - pnlUserLevel.Width) / 2;

            pnlUserLevel.Location = new Point(x, y);

            BindingUserLevel();
            
            if (grdViewUserLevel.RowCount > 0)
            {
                drUserLevel = grdViewUserLevel.GetDataRow(grdViewUserLevel.FocusedRowHandle);
                CurLevelID = int.Parse(drUserLevel.ItemArray[0].ToString());
            }

            BindingMainMenu();
            BindingUserLevelDefine();
        }

        private void cmdCreate_Click(object sender, EventArgs e)
        {
            curIndex = grdViewUserLevel.RowCount;

            frmUserLevelDetail UserLevelDetailForm = new frmUserLevelDetail();

            UserLevelDetailForm.txtUserLevel.Tag = string.Empty;
            UserLevelDetailForm.txtUserLevel.Text = string.Empty;
            UserLevelDetailForm.cmdSave.Tag = "Add";

            UserLevelDetailForm.ShowDialog();
            BindingUserLevel();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BindingUserLevel()
        {
            DataSet dsUserLevel = SqlDb.GetDataSet("SELECT levelPK, UserLevel, isActive FROM sysUserLevel WHERE isDeleted = 0");
            grdUserLevel.DataSource = dsUserLevel.Tables[0];

            grdViewUserLevel.FocusedRowHandle = curIndex;
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            curIndex = grdViewUserLevel.GetDataSourceRowIndex(grdViewUserLevel.FocusedRowHandle);

            frmUserLevelDetail UserLevelDetailForm = new frmUserLevelDetail();

            UserLevelDetailForm.txtUserLevel.Tag = drUserLevel.ItemArray[0].ToString();
            UserLevelDetailForm.txtUserLevel.Text = drUserLevel.ItemArray[1].ToString();
            UserLevelDetailForm.chkIsActive.EditValue = bool.Parse(drUserLevel.ItemArray[2].ToString());
            UserLevelDetailForm.cmdSave.Tag = "Edit";

            UserLevelDetailForm.ShowDialog();

            BindingUserLevel();
        }

        private void grdViewUserLevel_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (grdViewUserLevel.RowCount > 0)
            {
                drUserLevel = grdViewUserLevel.GetDataRow(grdViewUserLevel.FocusedRowHandle);

                CurLevelID = int.Parse(drUserLevel.ItemArray[0].ToString());

                BindingchkMainMenu();
                BindingUserLevelDefine();
            }
        }

        private void BindingMainMenu()
        {
            DataSet dsUserLevel = dsUserLevel = SqlDb.GetDataSet("SELECT PK, main_menu FROM sysMainMenu");

            try
            {
                cboMainMenu.DisplayMember = "main_menu";
                cboMainMenu.ValueMember = "PK";
                cboMainMenu.DataSource = dsUserLevel.Tables[0];
                //cboMainMenu.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboMainMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurMainMenuID = int.Parse(cboMainMenu.SelectedValue.ToString());

            BindingchkMainMenu();
            BindingUserLevelDefine();
        }

        private void BindingchkMainMenu()
        {
            bool viewMainMenu = SqlDb.IsViewMainMenu(CurMainMenuID.ToString(), CurLevelID.ToString());

            if (viewMainMenu == true)
            {
                chkMainMenuView.EditValue = true;
            }
            else
            {
                chkMainMenuView.EditValue = false;
            }
        }

        private void BindingUserLevelDefine()
        {
            DataSet dsULDefine = SqlDb.GetDataSet("SELECT sysLevelDefine.PK, sysSubMenu.sub_menu, sysLevelDefine.dataView, sysLevelDefine.dataInsert, " +
                                                "sysLevelDefine.dataEdit, sysLevelDefine.dataDelete, sysLevelDefine.dataPrint, sysLevelDefine.levelPK, " +
                                                "sysLevelDefine.mainmenuPK, sysLevelDefine.submenuPK " +
                                                "FROM sysLevelDefine INNER JOIN sysMainMenu ON sysLevelDefine.mainmenuPK = sysMainMenu.PK INNER JOIN " +
                                                "sysSubMenu ON sysLevelDefine.submenuPK = sysSubMenu.PK INNER JOIN sysUserLevel ON sysLevelDefine.levelPK = sysUserLevel.levelPK " +
                                                "WHERE sysLevelDefine.levelPK = @LevelPK AND sysLevelDefine.mainmenuPK = @MainMenuPK",
                                                new SqlParameter("@LevelPK", CurLevelID),
                                                new SqlParameter("@MainMenuPK", CurMainMenuID));
            grdSubMenu.DataSource = dsULDefine.Tables[0];
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            SqlDb.ExecuteQuery("UPDATE sysMainMenuDefine SET IsView=@IsView WHERE mainmenuPK = @MainMenuPK AND levelPK = @LevelPK",
                                new SqlParameter("@MainMenuPK", CurMainMenuID),
                                new SqlParameter("@LevelPK", CurLevelID),
                                new SqlParameter("@IsView", chkMainMenuView.EditValue));

            for (int i = 0; i < grdViewSubMenu.RowCount; i++)
            {
                SqlDb.ExecuteQuery("UPDATE sysLevelDefine SET dataView = @DataView , dataInsert = @DataInsert , dataEdit = @DataEdit , dataDelete = @DataDelete WHERE PK = @PK",
                                new SqlParameter("@DataView", (grdViewSubMenu.GetRowCellDisplayText(i, "dataView").ToString() == "Checked") ? true : false),
                                new SqlParameter("@DataInsert", (grdViewSubMenu.GetRowCellDisplayText(i, "dataInsert").ToString() == "Checked") ? true : false),
                                new SqlParameter("@DataEdit", (grdViewSubMenu.GetRowCellDisplayText(i, "dataEdit").ToString() == "Checked") ? true : false),
                                new SqlParameter("@DataDelete", (grdViewSubMenu.GetRowCellDisplayText(i, "dataDelete").ToString() == "Checked") ? true : false),
                                new SqlParameter("@PK", grdViewSubMenu.GetRowCellDisplayText(i, "PK").ToString()));
            }

            DialogResult = MessageBox.Show("Save is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void grdViewUserLevel_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (grdViewUserLevel.RowCount > 0)
            {
                drUserLevel = grdViewUserLevel.GetDataRow(grdViewUserLevel.FocusedRowHandle);

                CurLevelID = int.Parse(drUserLevel.ItemArray[0].ToString());

                BindingchkMainMenu();
                BindingUserLevelDefine();
            }
        }

        private void grdViewUserLevel_DoubleClick(object sender, EventArgs e)
        {
            curIndex = grdViewUserLevel.GetDataSourceRowIndex(grdViewUserLevel.FocusedRowHandle);

            frmUserLevelDetail UserLevelDetailForm = new frmUserLevelDetail();

            UserLevelDetailForm.txtUserLevel.Tag = drUserLevel.ItemArray[0].ToString();
            UserLevelDetailForm.txtUserLevel.Text = drUserLevel.ItemArray[1].ToString();
            UserLevelDetailForm.chkIsActive.EditValue = bool.Parse(drUserLevel.ItemArray[2].ToString());
            UserLevelDetailForm.cmdSave.Tag = "Edit";

            UserLevelDetailForm.ShowDialog();

            BindingUserLevel();
        }
    }
}
