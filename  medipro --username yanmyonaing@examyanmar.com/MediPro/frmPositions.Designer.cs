namespace MediPro
{
    partial class frmPositions
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
            this.grdPosition = new DevExpress.XtraGrid.GridControl();
            this.grdViewPosition = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColPK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositorychkIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.cmdExit = new DevExpress.XtraEditors.SimpleButton();
            this.cmdEdit = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNew = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBackground)).BeginInit();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewPosition)).BeginInit();
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
            this.pnlBackground.Controls.Add(this.grdPosition);
            this.pnlBackground.Controls.Add(this.panelControl2);
            this.pnlBackground.Controls.Add(this.panelControl1);
            this.pnlBackground.Location = new System.Drawing.Point(20, 15);
            this.pnlBackground.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlBackground.LookAndFeel.UseWindowsXPTheme = true;
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1000, 678);
            this.pnlBackground.TabIndex = 2;
            // 
            // grdPosition
            // 
            this.grdPosition.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdPosition.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdPosition.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdPosition.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdPosition.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdPosition.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.grdPosition.Location = new System.Drawing.Point(15, 71);
            this.grdPosition.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdPosition.MainView = this.grdViewPosition;
            this.grdPosition.Name = "grdPosition";
            this.grdPosition.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositorychkIsActive});
            this.grdPosition.Size = new System.Drawing.Size(970, 527);
            this.grdPosition.TabIndex = 1;
            this.grdPosition.UseEmbeddedNavigator = true;
            this.grdPosition.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewPosition});
            // 
            // grdViewPosition
            // 
            this.grdViewPosition.Appearance.Empty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grdViewPosition.Appearance.Empty.Options.UseBackColor = true;
            this.grdViewPosition.Appearance.EvenRow.BackColor = System.Drawing.Color.OldLace;
            this.grdViewPosition.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdViewPosition.Appearance.FocusedCell.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewPosition.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grdViewPosition.Appearance.FocusedRow.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewPosition.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdViewPosition.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdViewPosition.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdViewPosition.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewPosition.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grdViewPosition.Appearance.SelectedRow.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewPosition.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grdViewPosition.ColumnPanelRowHeight = 30;
            this.grdViewPosition.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColPK,
            this.grdColPosition,
            this.grdColIsActive});
            this.grdViewPosition.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdViewPosition.GridControl = this.grdPosition;
            this.grdViewPosition.Name = "grdViewPosition";
            this.grdViewPosition.OptionsView.EnableAppearanceEvenRow = true;
            this.grdViewPosition.OptionsView.ShowDetailButtons = false;
            this.grdViewPosition.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grdViewPosition.OptionsView.ShowGroupPanel = false;
            this.grdViewPosition.OptionsView.ShowIndicator = false;
            this.grdViewPosition.RowHeight = 25;
            this.grdViewPosition.ViewCaptionHeight = 30;
            this.grdViewPosition.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdViewPosition_RowClick);
            this.grdViewPosition.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdViewPosition_FocusedRowChanged);
            this.grdViewPosition.DoubleClick += new System.EventHandler(this.grdViewPosition_DoubleClick);
            // 
            // grdColPK
            // 
            this.grdColPK.Caption = "PositionPK";
            this.grdColPK.FieldName = "specializePK";
            this.grdColPK.Name = "grdColPK";
            this.grdColPK.OptionsColumn.AllowEdit = false;
            this.grdColPK.OptionsColumn.AllowMove = false;
            this.grdColPK.OptionsColumn.AllowShowHide = false;
            this.grdColPK.OptionsColumn.AllowSize = false;
            this.grdColPK.OptionsColumn.ReadOnly = true;
            // 
            // grdColPosition
            // 
            this.grdColPosition.Caption = "Position";
            this.grdColPosition.FieldName = "position";
            this.grdColPosition.Name = "grdColPosition";
            this.grdColPosition.OptionsColumn.AllowEdit = false;
            this.grdColPosition.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColPosition.OptionsColumn.AllowMove = false;
            this.grdColPosition.OptionsColumn.AllowShowHide = false;
            this.grdColPosition.OptionsColumn.AllowSize = false;
            this.grdColPosition.OptionsColumn.FixedWidth = true;
            this.grdColPosition.OptionsColumn.ReadOnly = true;
            this.grdColPosition.Visible = true;
            this.grdColPosition.VisibleIndex = 0;
            this.grdColPosition.Width = 800;
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
            this.grdColIsActive.OptionsFilter.AllowAutoFilter = false;
            this.grdColIsActive.OptionsFilter.AllowFilter = false;
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
            this.panelControl2.Controls.Add(this.cmdExit);
            this.panelControl2.Controls.Add(this.cmdEdit);
            this.panelControl2.Controls.Add(this.cmdNew);
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
            // cmdExit
            // 
            this.cmdExit.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdExit.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.cmdExit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmdExit.Appearance.Options.UseBackColor = true;
            this.cmdExit.Appearance.Options.UseFont = true;
            this.cmdExit.Appearance.Options.UseForeColor = true;
            this.cmdExit.Location = new System.Drawing.Point(883, 17);
            this.cmdExit.LookAndFeel.SkinName = "Seven Classic";
            this.cmdExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(94, 34);
            this.cmdExit.TabIndex = 0;
            this.cmdExit.Text = "Exit";
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
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
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
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
            this.cmdNew.Location = new System.Drawing.Point(667, 17);
            this.cmdNew.LookAndFeel.SkinName = "Seven Classic";
            this.cmdNew.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(94, 34);
            this.cmdNew.TabIndex = 0;
            this.cmdNew.Text = "New";
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
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
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Position Setup";
            // 
            // frmPositions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1049, 713);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPositions";
            this.Text = "Position Setup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPositions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBackground)).EndInit();
            this.pnlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewPosition)).EndInit();
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
        private DevExpress.XtraGrid.GridControl grdPosition;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewPosition;
        private DevExpress.XtraGrid.Columns.GridColumn grdColPK;
        private DevExpress.XtraGrid.Columns.GridColumn grdColPosition;
        private DevExpress.XtraGrid.Columns.GridColumn grdColIsActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositorychkIsActive;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.SimpleButton cmdExit;
        private DevExpress.XtraEditors.SimpleButton cmdEdit;
        private DevExpress.XtraEditors.SimpleButton cmdNew;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
    }
}