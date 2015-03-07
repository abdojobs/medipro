namespace MediPro
{
    partial class frmUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlUser = new DevExpress.XtraEditors.PanelControl();
            this.grdUser = new DevExpress.XtraGrid.GridControl();
            this.grdViewUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColLoginID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColUserLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColLevelPK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositorychkIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.grdColCreater = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdUpdater = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdUpdateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnl2 = new DevExpress.XtraEditors.PanelControl();
            this.cmdDeleteUser = new DevExpress.XtraEditors.SimpleButton();
            this.cmdPWDReset = new DevExpress.XtraEditors.SimpleButton();
            this.pnl3 = new DevExpress.XtraEditors.PanelControl();
            this.cmdSearch = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.cmdEdit = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCreate = new DevExpress.XtraEditors.SimpleButton();
            this.pnl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUser)).BeginInit();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorychkIsActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl2)).BeginInit();
            this.pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnl3)).BeginInit();
            this.pnl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl1)).BeginInit();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUser
            // 
            this.pnlUser.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.pnlUser.Appearance.Options.UseBackColor = true;
            this.pnlUser.Controls.Add(this.grdUser);
            this.pnlUser.Controls.Add(this.pnl2);
            this.pnlUser.Controls.Add(this.pnl1);
            this.pnlUser.Location = new System.Drawing.Point(11, 33);
            this.pnlUser.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.pnlUser.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlUser.Margin = new System.Windows.Forms.Padding(0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(1000, 678);
            this.pnlUser.TabIndex = 1;
            // 
            // grdUser
            // 
            this.grdUser.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdUser.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdUser.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdUser.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdUser.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdUser.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.grdUser.Location = new System.Drawing.Point(15, 76);
            this.grdUser.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdUser.MainView = this.grdViewUser;
            this.grdUser.Name = "grdUser";
            this.grdUser.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositorychkIsActive});
            this.grdUser.Size = new System.Drawing.Size(970, 527);
            this.grdUser.TabIndex = 2;
            this.grdUser.UseEmbeddedNavigator = true;
            this.grdUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewUser});
            // 
            // grdViewUser
            // 
            this.grdViewUser.Appearance.Empty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grdViewUser.Appearance.Empty.Options.UseBackColor = true;
            this.grdViewUser.Appearance.EvenRow.BackColor = System.Drawing.Color.OldLace;
            this.grdViewUser.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdViewUser.Appearance.FocusedCell.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewUser.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grdViewUser.Appearance.FocusedRow.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewUser.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdViewUser.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdViewUser.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdViewUser.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewUser.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grdViewUser.Appearance.SelectedRow.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewUser.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grdViewUser.ColumnPanelRowHeight = 30;
            this.grdViewUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColID,
            this.grdColFullName,
            this.grdColLoginID,
            this.grdColUserLevel,
            this.grdColLevelPK,
            this.grdColIsActive,
            this.grdColCreater,
            this.grdColCreatedDate,
            this.grdUpdater,
            this.grdUpdateDate});
            this.grdViewUser.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdViewUser.GridControl = this.grdUser;
            this.grdViewUser.Name = "grdViewUser";
            this.grdViewUser.OptionsView.EnableAppearanceEvenRow = true;
            this.grdViewUser.OptionsView.ShowDetailButtons = false;
            this.grdViewUser.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grdViewUser.OptionsView.ShowGroupPanel = false;
            this.grdViewUser.OptionsView.ShowIndicator = false;
            this.grdViewUser.RowHeight = 25;
            this.grdViewUser.ViewCaptionHeight = 30;
            this.grdViewUser.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdViewUser_RowClick);
            this.grdViewUser.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdViewUser_FocusedRowChanged);
            this.grdViewUser.DoubleClick += new System.EventHandler(this.grdViewUser_DoubleClick);
            // 
            // grdColID
            // 
            this.grdColID.Caption = "UserID";
            this.grdColID.FieldName = "PK";
            this.grdColID.Name = "grdColID";
            this.grdColID.OptionsColumn.AllowEdit = false;
            this.grdColID.OptionsColumn.AllowMove = false;
            this.grdColID.OptionsColumn.AllowShowHide = false;
            this.grdColID.OptionsColumn.AllowSize = false;
            this.grdColID.OptionsColumn.ReadOnly = true;
            // 
            // grdColFullName
            // 
            this.grdColFullName.Caption = "Full Name";
            this.grdColFullName.FieldName = "name";
            this.grdColFullName.Name = "grdColFullName";
            this.grdColFullName.OptionsColumn.AllowEdit = false;
            this.grdColFullName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColFullName.OptionsColumn.AllowMove = false;
            this.grdColFullName.OptionsColumn.AllowShowHide = false;
            this.grdColFullName.OptionsColumn.AllowSize = false;
            this.grdColFullName.OptionsColumn.FixedWidth = true;
            this.grdColFullName.OptionsColumn.ReadOnly = true;
            this.grdColFullName.OptionsFilter.AllowAutoFilter = false;
            this.grdColFullName.OptionsFilter.AllowFilter = false;
            this.grdColFullName.Visible = true;
            this.grdColFullName.VisibleIndex = 0;
            this.grdColFullName.Width = 250;
            // 
            // grdColLoginID
            // 
            this.grdColLoginID.Caption = "Login ID";
            this.grdColLoginID.FieldName = "login";
            this.grdColLoginID.Name = "grdColLoginID";
            this.grdColLoginID.OptionsColumn.AllowEdit = false;
            this.grdColLoginID.OptionsColumn.AllowFocus = false;
            this.grdColLoginID.OptionsColumn.AllowMove = false;
            this.grdColLoginID.OptionsColumn.AllowShowHide = false;
            this.grdColLoginID.OptionsColumn.AllowSize = false;
            this.grdColLoginID.OptionsColumn.FixedWidth = true;
            this.grdColLoginID.OptionsColumn.ReadOnly = true;
            this.grdColLoginID.Visible = true;
            this.grdColLoginID.VisibleIndex = 1;
            this.grdColLoginID.Width = 283;
            // 
            // grdColUserLevel
            // 
            this.grdColUserLevel.Caption = "User Level";
            this.grdColUserLevel.FieldName = "UserLevel";
            this.grdColUserLevel.Name = "grdColUserLevel";
            this.grdColUserLevel.OptionsColumn.AllowEdit = false;
            this.grdColUserLevel.OptionsColumn.AllowFocus = false;
            this.grdColUserLevel.OptionsColumn.AllowMove = false;
            this.grdColUserLevel.OptionsColumn.AllowShowHide = false;
            this.grdColUserLevel.OptionsColumn.AllowSize = false;
            this.grdColUserLevel.OptionsColumn.ReadOnly = true;
            this.grdColUserLevel.Visible = true;
            this.grdColUserLevel.VisibleIndex = 2;
            this.grdColUserLevel.Width = 285;
            // 
            // grdColLevelPK
            // 
            this.grdColLevelPK.Caption = "UserLevelPK";
            this.grdColLevelPK.FieldName = "levelPK";
            this.grdColLevelPK.Name = "grdColLevelPK";
            // 
            // grdColIsActive
            // 
            this.grdColIsActive.AppearanceHeader.Options.UseTextOptions = true;
            this.grdColIsActive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdColIsActive.Caption = "Is Active";
            this.grdColIsActive.ColumnEdit = this.repositorychkIsActive;
            this.grdColIsActive.FieldName = "isActive";
            this.grdColIsActive.Name = "grdColIsActive";
            this.grdColIsActive.OptionsColumn.AllowEdit = false;
            this.grdColIsActive.OptionsColumn.AllowFocus = false;
            this.grdColIsActive.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColIsActive.OptionsColumn.AllowMove = false;
            this.grdColIsActive.OptionsColumn.AllowShowHide = false;
            this.grdColIsActive.OptionsColumn.AllowSize = false;
            this.grdColIsActive.OptionsColumn.FixedWidth = true;
            this.grdColIsActive.OptionsColumn.ReadOnly = true;
            this.grdColIsActive.Visible = true;
            this.grdColIsActive.VisibleIndex = 3;
            this.grdColIsActive.Width = 150;
            // 
            // repositorychkIsActive
            // 
            this.repositorychkIsActive.AutoHeight = false;
            this.repositorychkIsActive.DisplayValueChecked = "1";
            this.repositorychkIsActive.DisplayValueUnchecked = "0";
            this.repositorychkIsActive.LookAndFeel.SkinName = "VS2010";
            this.repositorychkIsActive.LookAndFeel.UseDefaultLookAndFeel = false;
            this.repositorychkIsActive.Name = "repositorychkIsActive";
            this.repositorychkIsActive.ReadOnly = true;
            // 
            // grdColCreater
            // 
            this.grdColCreater.Caption = "Creater";
            this.grdColCreater.FieldName = "createPK";
            this.grdColCreater.Name = "grdColCreater";
            this.grdColCreater.Width = 152;
            // 
            // grdColCreatedDate
            // 
            this.grdColCreatedDate.Caption = "Created Date";
            this.grdColCreatedDate.FieldName = "createDate";
            this.grdColCreatedDate.Name = "grdColCreatedDate";
            this.grdColCreatedDate.Width = 120;
            // 
            // grdUpdater
            // 
            this.grdUpdater.Caption = "Updater";
            this.grdUpdater.FieldName = "updatePK";
            this.grdUpdater.Name = "grdUpdater";
            this.grdUpdater.Width = 141;
            // 
            // grdUpdateDate
            // 
            this.grdUpdateDate.Caption = "Update Date";
            this.grdUpdateDate.FieldName = "updateDate";
            this.grdUpdateDate.Name = "grdUpdateDate";
            this.grdUpdateDate.Width = 120;
            // 
            // pnl2
            // 
            this.pnl2.Appearance.BackColor = System.Drawing.Color.OldLace;
            this.pnl2.Appearance.Options.UseBackColor = true;
            this.pnl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnl2.Controls.Add(this.cmdDeleteUser);
            this.pnl2.Controls.Add(this.cmdPWDReset);
            this.pnl2.Controls.Add(this.pnl3);
            this.pnl2.Controls.Add(this.cmdClose);
            this.pnl2.Controls.Add(this.cmdEdit);
            this.pnl2.Controls.Add(this.cmdCreate);
            this.pnl2.Location = new System.Drawing.Point(1, 612);
            this.pnl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.pnl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnl2.Margin = new System.Windows.Forms.Padding(0);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(997, 64);
            this.pnl2.TabIndex = 0;
            // 
            // cmdDeleteUser
            // 
            this.cmdDeleteUser.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdDeleteUser.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.cmdDeleteUser.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDeleteUser.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmdDeleteUser.Appearance.Options.UseBackColor = true;
            this.cmdDeleteUser.Appearance.Options.UseFont = true;
            this.cmdDeleteUser.Appearance.Options.UseForeColor = true;
            this.cmdDeleteUser.Location = new System.Drawing.Point(716, 16);
            this.cmdDeleteUser.LookAndFeel.SkinName = "Seven Classic";
            this.cmdDeleteUser.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdDeleteUser.Name = "cmdDeleteUser";
            this.cmdDeleteUser.Size = new System.Drawing.Size(112, 34);
            this.cmdDeleteUser.TabIndex = 3;
            this.cmdDeleteUser.Text = "Delete User";
            this.cmdDeleteUser.Visible = false;
            // 
            // cmdPWDReset
            // 
            this.cmdPWDReset.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdPWDReset.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.cmdPWDReset.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPWDReset.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cmdPWDReset.Appearance.Options.UseBackColor = true;
            this.cmdPWDReset.Appearance.Options.UseFont = true;
            this.cmdPWDReset.Appearance.Options.UseForeColor = true;
            this.cmdPWDReset.Location = new System.Drawing.Point(596, 16);
            this.cmdPWDReset.LookAndFeel.SkinName = "Seven Classic";
            this.cmdPWDReset.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdPWDReset.Name = "cmdPWDReset";
            this.cmdPWDReset.Size = new System.Drawing.Size(112, 34);
            this.cmdPWDReset.TabIndex = 2;
            this.cmdPWDReset.Text = "Reset Password";
            this.cmdPWDReset.Click += new System.EventHandler(this.cmdPWDReset_Click);
            // 
            // pnl3
            // 
            this.pnl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pnl3.Appearance.Options.UseBackColor = true;
            this.pnl3.Controls.Add(this.cmdSearch);
            this.pnl3.Controls.Add(this.textEdit1);
            this.pnl3.Location = new System.Drawing.Point(15, 14);
            this.pnl3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.pnl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(332, 38);
            this.pnl3.TabIndex = 1;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Image = global::MediPro.Properties.Resources.search;
            this.cmdSearch.Location = new System.Drawing.Point(294, 8);
            this.cmdSearch.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.cmdSearch.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(25, 19);
            this.cmdSearch.TabIndex = 1;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(10, 8);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(279, 20);
            this.textEdit1.TabIndex = 0;
            // 
            // cmdClose
            // 
            this.cmdClose.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdClose.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.cmdClose.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmdClose.Appearance.Options.UseBackColor = true;
            this.cmdClose.Appearance.Options.UseFont = true;
            this.cmdClose.Appearance.Options.UseForeColor = true;
            this.cmdClose.Location = new System.Drawing.Point(870, 16);
            this.cmdClose.LookAndFeel.SkinName = "Seven Classic";
            this.cmdClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(112, 34);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.Text = "Exit";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdEdit.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.cmdEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEdit.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cmdEdit.Appearance.Options.UseBackColor = true;
            this.cmdEdit.Appearance.Options.UseFont = true;
            this.cmdEdit.Appearance.Options.UseForeColor = true;
            this.cmdEdit.Location = new System.Drawing.Point(476, 16);
            this.cmdEdit.LookAndFeel.SkinName = "Seven Classic";
            this.cmdEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(112, 34);
            this.cmdEdit.TabIndex = 0;
            this.cmdEdit.Text = "Edit User";
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdCreate
            // 
            this.cmdCreate.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdCreate.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.cmdCreate.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCreate.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cmdCreate.Appearance.Options.UseBackColor = true;
            this.cmdCreate.Appearance.Options.UseFont = true;
            this.cmdCreate.Appearance.Options.UseForeColor = true;
            this.cmdCreate.Location = new System.Drawing.Point(356, 16);
            this.cmdCreate.LookAndFeel.SkinName = "Seven Classic";
            this.cmdCreate.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdCreate.Name = "cmdCreate";
            this.cmdCreate.Size = new System.Drawing.Size(112, 34);
            this.cmdCreate.TabIndex = 0;
            this.cmdCreate.Text = "Create User";
            this.cmdCreate.Click += new System.EventHandler(this.cmdCreate_Click);
            // 
            // pnl1
            // 
            this.pnl1.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.pnl1.Appearance.Options.UseBackColor = true;
            this.pnl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnl1.Controls.Add(this.lbl1);
            this.pnl1.Location = new System.Drawing.Point(1, 1);
            this.pnl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.pnl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnl1.Margin = new System.Windows.Forms.Padding(0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(997, 55);
            this.pnl1.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(14, 24);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(149, 19);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "User Information";
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 744);
            this.Controls.Add(this.pnlUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "User Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlUser)).EndInit();
            this.pnlUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorychkIsActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl2)).EndInit();
            this.pnl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnl3)).EndInit();
            this.pnl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl1)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlUser;
        private DevExpress.XtraEditors.PanelControl pnl2;
        private DevExpress.XtraEditors.PanelControl pnl3;
        private DevExpress.XtraEditors.SimpleButton cmdSearch;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private DevExpress.XtraEditors.SimpleButton cmdEdit;
        private DevExpress.XtraEditors.SimpleButton cmdCreate;
        private DevExpress.XtraEditors.PanelControl pnl1;
        private System.Windows.Forms.Label lbl1;
        private DevExpress.XtraGrid.GridControl grdUser;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewUser;
        private DevExpress.XtraGrid.Columns.GridColumn grdColID;
        private DevExpress.XtraGrid.Columns.GridColumn grdColFullName;
        private DevExpress.XtraGrid.Columns.GridColumn grdColLoginID;
        private DevExpress.XtraGrid.Columns.GridColumn grdColUserLevel;
        private DevExpress.XtraGrid.Columns.GridColumn grdColCreater;
        private DevExpress.XtraGrid.Columns.GridColumn grdColCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn grdUpdater;
        private DevExpress.XtraGrid.Columns.GridColumn grdUpdateDate;
        private DevExpress.XtraEditors.SimpleButton cmdDeleteUser;
        private DevExpress.XtraEditors.SimpleButton cmdPWDReset;
        private DevExpress.XtraGrid.Columns.GridColumn grdColIsActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositorychkIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn grdColLevelPK;
    }
}