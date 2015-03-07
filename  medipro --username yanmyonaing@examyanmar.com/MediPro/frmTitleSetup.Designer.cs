namespace MediPro
{
    partial class frmTitleSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTitleSetup));
            this.pnlBackground = new DevExpress.XtraEditors.PanelControl();
            this.grdTitle = new DevExpress.XtraGrid.GridControl();
            this.grdViewTitle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositorychkIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNew = new DevExpress.XtraEditors.SimpleButton();
            this.cmdEdit = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBackground)).BeginInit();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorychkIsActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.pnlBackground.Appearance.Options.UseBackColor = true;
            this.pnlBackground.Controls.Add(this.grdTitle);
            this.pnlBackground.Controls.Add(this.panelControl2);
            this.pnlBackground.Controls.Add(this.panelControl1);
            this.pnlBackground.Location = new System.Drawing.Point(6, 10);
            this.pnlBackground.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlBackground.LookAndFeel.UseWindowsXPTheme = true;
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1000, 678);
            this.pnlBackground.TabIndex = 0;
            // 
            // grdTitle
            // 
            this.grdTitle.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdTitle.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdTitle.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdTitle.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdTitle.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdTitle.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.grdTitle.Location = new System.Drawing.Point(15, 71);
            this.grdTitle.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdTitle.MainView = this.grdViewTitle;
            this.grdTitle.Name = "grdTitle";
            this.grdTitle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositorychkIsActive});
            this.grdTitle.Size = new System.Drawing.Size(970, 527);
            this.grdTitle.TabIndex = 1;
            this.grdTitle.UseEmbeddedNavigator = true;
            this.grdTitle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewTitle});
            // 
            // grdViewTitle
            // 
            this.grdViewTitle.Appearance.Empty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grdViewTitle.Appearance.Empty.Options.UseBackColor = true;
            this.grdViewTitle.Appearance.EvenRow.BackColor = System.Drawing.Color.OldLace;
            this.grdViewTitle.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdViewTitle.Appearance.FocusedCell.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewTitle.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grdViewTitle.Appearance.FocusedRow.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewTitle.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdViewTitle.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdViewTitle.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdViewTitle.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewTitle.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grdViewTitle.Appearance.SelectedRow.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewTitle.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grdViewTitle.ColumnPanelRowHeight = 30;
            this.grdViewTitle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColID,
            this.grdColTitle,
            this.grdColIsActive});
            this.grdViewTitle.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdViewTitle.GridControl = this.grdTitle;
            this.grdViewTitle.Name = "grdViewTitle";
            this.grdViewTitle.OptionsView.EnableAppearanceEvenRow = true;
            this.grdViewTitle.OptionsView.ShowDetailButtons = false;
            this.grdViewTitle.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grdViewTitle.OptionsView.ShowGroupPanel = false;
            this.grdViewTitle.OptionsView.ShowIndicator = false;
            this.grdViewTitle.RowHeight = 25;
            this.grdViewTitle.ViewCaptionHeight = 30;
            this.grdViewTitle.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdViewTitle_RowClick);
            this.grdViewTitle.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdViewTitle_FocusedRowChanged);
            this.grdViewTitle.DoubleClick += new System.EventHandler(this.grdViewTitle_DoubleClick);
            // 
            // grdColID
            // 
            this.grdColID.Caption = "Title ID";
            this.grdColID.FieldName = "titlePK";
            this.grdColID.Name = "grdColID";
            this.grdColID.OptionsColumn.AllowEdit = false;
            this.grdColID.OptionsColumn.AllowMove = false;
            this.grdColID.OptionsColumn.AllowShowHide = false;
            this.grdColID.OptionsColumn.AllowSize = false;
            this.grdColID.OptionsColumn.ReadOnly = true;
            // 
            // grdColTitle
            // 
            this.grdColTitle.Caption = "Title";
            this.grdColTitle.FieldName = "TitleName";
            this.grdColTitle.Name = "grdColTitle";
            this.grdColTitle.OptionsColumn.AllowEdit = false;
            this.grdColTitle.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColTitle.OptionsColumn.AllowMove = false;
            this.grdColTitle.OptionsColumn.AllowShowHide = false;
            this.grdColTitle.OptionsColumn.AllowSize = false;
            this.grdColTitle.OptionsColumn.FixedWidth = true;
            this.grdColTitle.OptionsColumn.ReadOnly = true;
            this.grdColTitle.OptionsFilter.AllowAutoFilter = false;
            this.grdColTitle.OptionsFilter.AllowFilter = false;
            this.grdColTitle.Visible = true;
            this.grdColTitle.VisibleIndex = 0;
            this.grdColTitle.Width = 800;
            // 
            // grdColIsActive
            // 
            this.grdColIsActive.AppearanceHeader.Options.UseTextOptions = true;
            this.grdColIsActive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdColIsActive.Caption = "IsActive";
            this.grdColIsActive.ColumnEdit = this.repositorychkIsActive;
            this.grdColIsActive.FieldName = "isActive";
            this.grdColIsActive.Name = "grdColIsActive";
            this.grdColIsActive.OptionsColumn.AllowEdit = false;
            this.grdColIsActive.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColIsActive.OptionsColumn.AllowMove = false;
            this.grdColIsActive.OptionsColumn.AllowShowHide = false;
            this.grdColIsActive.OptionsColumn.AllowSize = false;
            this.grdColIsActive.OptionsColumn.FixedWidth = true;
            this.grdColIsActive.OptionsColumn.ReadOnly = true;
            this.grdColIsActive.Visible = true;
            this.grdColIsActive.VisibleIndex = 1;
            this.grdColIsActive.Width = 168;
            // 
            // repositorychkIsActive
            // 
            this.repositorychkIsActive.AutoHeight = false;
            this.repositorychkIsActive.LookAndFeel.SkinName = "VS2010";
            this.repositorychkIsActive.LookAndFeel.UseDefaultLookAndFeel = false;
            this.repositorychkIsActive.Name = "repositorychkIsActive";
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.OldLace;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.simpleButton2);
            this.panelControl2.Controls.Add(this.cmdNew);
            this.panelControl2.Controls.Add(this.cmdEdit);
            this.panelControl2.Location = new System.Drawing.Point(1, 612);
            this.panelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl2.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(997, 64);
            this.panelControl2.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.Controls.Add(this.simpleButton3);
            this.panelControl3.Controls.Add(this.txtSearch);
            this.panelControl3.Location = new System.Drawing.Point(15, 14);
            this.panelControl3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.panelControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(332, 38);
            this.panelControl3.TabIndex = 1;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = global::MediPro.Properties.Resources.search;
            this.simpleButton3.Location = new System.Drawing.Point(294, 8);
            this.simpleButton3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.simpleButton3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(25, 19);
            this.simpleButton3.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(10, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(279, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton2.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.Location = new System.Drawing.Point(883, 17);
            this.simpleButton2.LookAndFeel.SkinName = "Seven Classic";
            this.simpleButton2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(94, 34);
            this.simpleButton2.TabIndex = 0;
            this.simpleButton2.Text = "Exit";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // cmdNew
            // 
            this.cmdNew.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdNew.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.cmdNew.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNew.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cmdNew.Appearance.Options.UseBackColor = true;
            this.cmdNew.Appearance.Options.UseFont = true;
            this.cmdNew.Appearance.Options.UseForeColor = true;
            this.cmdNew.Location = new System.Drawing.Point(775, 17);
            this.cmdNew.LookAndFeel.SkinName = "Seven Classic";
            this.cmdNew.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(94, 34);
            this.cmdNew.TabIndex = 0;
            this.cmdNew.Text = "New";
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
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
            this.cmdEdit.Location = new System.Drawing.Point(775, 17);
            this.cmdEdit.LookAndFeel.SkinName = "Seven Classic";
            this.cmdEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(94, 34);
            this.cmdEdit.TabIndex = 0;
            this.cmdEdit.Text = "Edit";
            this.cmdEdit.Visible = false;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Location = new System.Drawing.Point(1, 1);
            this.panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(997, 55);
            this.panelControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title Setup";
            // 
            // frmTitleSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1012, 707);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTitleSetup";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title Setup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTitleSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBackground)).EndInit();
            this.pnlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorychkIsActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlBackground;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl grdTitle;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewTitle;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton cmdEdit;
        private DevExpress.XtraEditors.SimpleButton cmdNew;
        private DevExpress.XtraGrid.Columns.GridColumn grdColID;
        private DevExpress.XtraGrid.Columns.GridColumn grdColTitle;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraGrid.Columns.GridColumn grdColIsActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositorychkIsActive;
    }
}