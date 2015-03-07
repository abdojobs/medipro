namespace Lab
{
    partial class frmLabCategory
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
            this.pnlBackground = new DevExpress.XtraEditors.PanelControl();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grdView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColPK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColLabCatName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositorychkIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.pnl2 = new DevExpress.XtraEditors.PanelControl();
            this.cmdExit = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNew = new DevExpress.XtraEditors.SimpleButton();
            this.pnl3 = new DevExpress.XtraEditors.PanelControl();
            this.cmdSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.cmdEdit = new DevExpress.XtraEditors.SimpleButton();
            this.pnl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBackground)).BeginInit();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorychkIsActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl2)).BeginInit();
            this.pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnl3)).BeginInit();
            this.pnl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl1)).BeginInit();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.pnlBackground.Appearance.Options.UseBackColor = true;
            this.pnlBackground.Controls.Add(this.grd);
            this.pnlBackground.Controls.Add(this.pnl2);
            this.pnlBackground.Controls.Add(this.pnl1);
            this.pnlBackground.Location = new System.Drawing.Point(15, 14);
            this.pnlBackground.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.pnlBackground.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1000, 678);
            this.pnlBackground.TabIndex = 3;
            // 
            // grd
            // 
            this.grd.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grd.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grd.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grd.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grd.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grd.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.grd.Location = new System.Drawing.Point(15, 76);
            this.grd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grd.MainView = this.grdView;
            this.grd.Name = "grd";
            this.grd.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositorychkIsActive});
            this.grd.Size = new System.Drawing.Size(970, 527);
            this.grd.TabIndex = 2;
            this.grd.UseEmbeddedNavigator = true;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdView});
            // 
            // grdView
            // 
            this.grdView.Appearance.Empty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grdView.Appearance.Empty.Options.UseBackColor = true;
            this.grdView.Appearance.EvenRow.BackColor = System.Drawing.Color.OldLace;
            this.grdView.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdView.Appearance.FocusedCell.BackColor = System.Drawing.Color.SkyBlue;
            this.grdView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grdView.Appearance.FocusedRow.BackColor = System.Drawing.Color.SkyBlue;
            this.grdView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdView.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.SkyBlue;
            this.grdView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grdView.Appearance.SelectedRow.BackColor = System.Drawing.Color.SkyBlue;
            this.grdView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grdView.ColumnPanelRowHeight = 30;
            this.grdView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColPK,
            this.grdColLabCatName,
            this.grdColIsActive});
            this.grdView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdView.GridControl = this.grd;
            this.grdView.Name = "grdView";
            this.grdView.OptionsView.EnableAppearanceEvenRow = true;
            this.grdView.OptionsView.ShowDetailButtons = false;
            this.grdView.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grdView.OptionsView.ShowGroupPanel = false;
            this.grdView.OptionsView.ShowIndicator = false;
            this.grdView.RowHeight = 25;
            this.grdView.ViewCaptionHeight = 30;
            this.grdView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdView_RowClick);
            this.grdView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdView_FocusedRowChanged);
            this.grdView.DoubleClick += new System.EventHandler(this.grdView_DoubleClick);
            // 
            // grdColPK
            // 
            this.grdColPK.Caption = "labPK";
            this.grdColPK.FieldName = "PK";
            this.grdColPK.Name = "grdColPK";
            this.grdColPK.OptionsColumn.AllowEdit = false;
            this.grdColPK.OptionsColumn.AllowMove = false;
            this.grdColPK.OptionsColumn.AllowShowHide = false;
            this.grdColPK.OptionsColumn.AllowSize = false;
            this.grdColPK.OptionsColumn.ReadOnly = true;
            // 
            // grdColLabCatName
            // 
            this.grdColLabCatName.Caption = "Lab Category";
            this.grdColLabCatName.FieldName = "labCatName";
            this.grdColLabCatName.Name = "grdColLabCatName";
            this.grdColLabCatName.OptionsColumn.AllowEdit = false;
            this.grdColLabCatName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColLabCatName.OptionsColumn.AllowMove = false;
            this.grdColLabCatName.OptionsColumn.AllowShowHide = false;
            this.grdColLabCatName.OptionsColumn.AllowSize = false;
            this.grdColLabCatName.OptionsColumn.ReadOnly = true;
            this.grdColLabCatName.Visible = true;
            this.grdColLabCatName.VisibleIndex = 0;
            this.grdColLabCatName.Width = 898;
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
            this.grdColIsActive.VisibleIndex = 1;
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
            // pnl2
            // 
            this.pnl2.Appearance.BackColor = System.Drawing.Color.OldLace;
            this.pnl2.Appearance.Options.UseBackColor = true;
            this.pnl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnl2.Controls.Add(this.cmdExit);
            this.pnl2.Controls.Add(this.cmdNew);
            this.pnl2.Controls.Add(this.pnl3);
            this.pnl2.Controls.Add(this.cmdEdit);
            this.pnl2.Location = new System.Drawing.Point(1, 612);
            this.pnl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.pnl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnl2.Margin = new System.Windows.Forms.Padding(0);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(997, 64);
            this.pnl2.TabIndex = 0;
            // 
            // cmdExit
            // 
            this.cmdExit.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdExit.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.cmdExit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmdExit.Appearance.Options.UseBackColor = true;
            this.cmdExit.Appearance.Options.UseFont = true;
            this.cmdExit.Appearance.Options.UseForeColor = true;
            this.cmdExit.Location = new System.Drawing.Point(890, 16);
            this.cmdExit.LookAndFeel.SkinName = "Seven Classic";
            this.cmdExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(94, 34);
            this.cmdExit.TabIndex = 2;
            this.cmdExit.Text = "Exit";
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
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
            this.cmdNew.Location = new System.Drawing.Point(674, 16);
            this.cmdNew.LookAndFeel.SkinName = "Seven Classic";
            this.cmdNew.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(94, 34);
            this.cmdNew.TabIndex = 4;
            this.cmdNew.Text = "New";
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // pnl3
            // 
            this.pnl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pnl3.Appearance.Options.UseBackColor = true;
            this.pnl3.Controls.Add(this.cmdSearch);
            this.pnl3.Controls.Add(this.txtSearch);
            this.pnl3.Location = new System.Drawing.Point(15, 14);
            this.pnl3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.pnl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(332, 38);
            this.pnl3.TabIndex = 1;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Image = global::Lab.Properties.Resources.search;
            this.cmdSearch.Location = new System.Drawing.Point(294, 8);
            this.cmdSearch.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.cmdSearch.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(25, 19);
            this.cmdSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(10, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(279, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            this.cmdEdit.Location = new System.Drawing.Point(782, 16);
            this.cmdEdit.LookAndFeel.SkinName = "Seven Classic";
            this.cmdEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(94, 34);
            this.cmdEdit.TabIndex = 3;
            this.cmdEdit.Text = "Edit";
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
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
            this.lbl1.Size = new System.Drawing.Size(169, 19);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Lab Category Setup";
            // 
            // frmLabCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1027, 704);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLabCategory";
            this.Text = "Laboratory Setup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLabCat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBackground)).EndInit();
            this.pnlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorychkIsActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl2)).EndInit();
            this.pnl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnl3)).EndInit();
            this.pnl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl1)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlBackground;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grdView;
        private DevExpress.XtraGrid.Columns.GridColumn grdColPK;
        private DevExpress.XtraGrid.Columns.GridColumn grdColLabCatName;
        private DevExpress.XtraGrid.Columns.GridColumn grdColIsActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositorychkIsActive;
        private DevExpress.XtraEditors.PanelControl pnl2;
        private DevExpress.XtraEditors.SimpleButton cmdExit;
        private DevExpress.XtraEditors.SimpleButton cmdNew;
        private DevExpress.XtraEditors.PanelControl pnl3;
        private DevExpress.XtraEditors.SimpleButton cmdSearch;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.SimpleButton cmdEdit;
        private DevExpress.XtraEditors.PanelControl pnl1;
        private System.Windows.Forms.Label lbl1;
    }
}