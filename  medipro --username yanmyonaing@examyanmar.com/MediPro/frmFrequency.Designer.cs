namespace MediPro
{
    partial class frmFrequency
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
            this.grdFrequency = new DevExpress.XtraGrid.GridControl();
            this.grdViewFrequency = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColPK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColTreadmentType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColDiagnosis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositorychkIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.grdColTreatmentPK = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.grdFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewFrequency)).BeginInit();
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
            this.pnlBackground.Controls.Add(this.grdFrequency);
            this.pnlBackground.Controls.Add(this.panelControl2);
            this.pnlBackground.Controls.Add(this.panelControl1);
            this.pnlBackground.Location = new System.Drawing.Point(21, 21);
            this.pnlBackground.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlBackground.LookAndFeel.UseWindowsXPTheme = true;
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1000, 678);
            this.pnlBackground.TabIndex = 4;
            // 
            // grdFrequency
            // 
            this.grdFrequency.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdFrequency.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdFrequency.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdFrequency.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdFrequency.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdFrequency.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.grdFrequency.Location = new System.Drawing.Point(15, 71);
            this.grdFrequency.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdFrequency.MainView = this.grdViewFrequency;
            this.grdFrequency.Name = "grdFrequency";
            this.grdFrequency.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositorychkIsActive});
            this.grdFrequency.Size = new System.Drawing.Size(970, 527);
            this.grdFrequency.TabIndex = 1;
            this.grdFrequency.UseEmbeddedNavigator = true;
            this.grdFrequency.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewFrequency});
            // 
            // grdViewFrequency
            // 
            this.grdViewFrequency.Appearance.Empty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grdViewFrequency.Appearance.Empty.Options.UseBackColor = true;
            this.grdViewFrequency.Appearance.EvenRow.BackColor = System.Drawing.Color.OldLace;
            this.grdViewFrequency.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdViewFrequency.Appearance.FocusedCell.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewFrequency.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grdViewFrequency.Appearance.FocusedRow.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewFrequency.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdViewFrequency.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdViewFrequency.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdViewFrequency.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewFrequency.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grdViewFrequency.Appearance.SelectedRow.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewFrequency.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grdViewFrequency.ColumnPanelRowHeight = 30;
            this.grdViewFrequency.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColPK,
            this.grdColTreadmentType,
            this.grdColDiagnosis,
            this.grdColIsActive,
            this.grdColTreatmentPK});
            this.grdViewFrequency.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdViewFrequency.GridControl = this.grdFrequency;
            this.grdViewFrequency.Name = "grdViewFrequency";
            this.grdViewFrequency.OptionsView.EnableAppearanceEvenRow = true;
            this.grdViewFrequency.OptionsView.ShowDetailButtons = false;
            this.grdViewFrequency.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grdViewFrequency.OptionsView.ShowGroupPanel = false;
            this.grdViewFrequency.OptionsView.ShowIndicator = false;
            this.grdViewFrequency.RowHeight = 25;
            this.grdViewFrequency.ViewCaptionHeight = 30;
            this.grdViewFrequency.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdViewFrequency_RowClick);
            this.grdViewFrequency.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdViewFrequency_FocusedRowChanged);
            this.grdViewFrequency.DoubleClick += new System.EventHandler(this.grdViewFrequency_DoubleClick);
            // 
            // grdColPK
            // 
            this.grdColPK.Caption = "FrequencyPK";
            this.grdColPK.FieldName = "frequencyPK";
            this.grdColPK.Name = "grdColPK";
            this.grdColPK.OptionsColumn.AllowEdit = false;
            this.grdColPK.OptionsColumn.AllowMove = false;
            this.grdColPK.OptionsColumn.AllowShowHide = false;
            this.grdColPK.OptionsColumn.AllowSize = false;
            this.grdColPK.OptionsColumn.ReadOnly = true;
            // 
            // grdColTreadmentType
            // 
            this.grdColTreadmentType.Caption = "Treatment Type";
            this.grdColTreadmentType.FieldName = "treatmentType";
            this.grdColTreadmentType.Name = "grdColTreadmentType";
            this.grdColTreadmentType.OptionsColumn.AllowEdit = false;
            this.grdColTreadmentType.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColTreadmentType.OptionsColumn.AllowMove = false;
            this.grdColTreadmentType.OptionsColumn.AllowShowHide = false;
            this.grdColTreadmentType.OptionsColumn.AllowSize = false;
            this.grdColTreadmentType.OptionsColumn.FixedWidth = true;
            this.grdColTreadmentType.OptionsColumn.ReadOnly = true;
            this.grdColTreadmentType.Visible = true;
            this.grdColTreadmentType.VisibleIndex = 1;
            this.grdColTreadmentType.Width = 250;
            // 
            // grdColDiagnosis
            // 
            this.grdColDiagnosis.Caption = "Frequency";
            this.grdColDiagnosis.FieldName = "frequency";
            this.grdColDiagnosis.Name = "grdColDiagnosis";
            this.grdColDiagnosis.OptionsColumn.AllowEdit = false;
            this.grdColDiagnosis.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColDiagnosis.OptionsColumn.AllowMove = false;
            this.grdColDiagnosis.OptionsColumn.AllowShowHide = false;
            this.grdColDiagnosis.OptionsColumn.AllowSize = false;
            this.grdColDiagnosis.OptionsColumn.FixedWidth = true;
            this.grdColDiagnosis.OptionsColumn.ReadOnly = true;
            this.grdColDiagnosis.Visible = true;
            this.grdColDiagnosis.VisibleIndex = 0;
            this.grdColDiagnosis.Width = 800;
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
            this.grdColIsActive.VisibleIndex = 2;
            this.grdColIsActive.Width = 120;
            // 
            // repositorychkIsActive
            // 
            this.repositorychkIsActive.AutoHeight = false;
            this.repositorychkIsActive.LookAndFeel.SkinName = "VS2010";
            this.repositorychkIsActive.LookAndFeel.UseDefaultLookAndFeel = false;
            this.repositorychkIsActive.Name = "repositorychkIsActive";
            // 
            // grdColTreatmentPK
            // 
            this.grdColTreatmentPK.Caption = "treadmentPK";
            this.grdColTreatmentPK.FieldName = "treatmentPK";
            this.grdColTreatmentPK.Name = "grdColTreatmentPK";
            this.grdColTreatmentPK.OptionsColumn.AllowEdit = false;
            this.grdColTreatmentPK.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColTreatmentPK.OptionsColumn.AllowMove = false;
            this.grdColTreatmentPK.OptionsColumn.FixedWidth = true;
            this.grdColTreatmentPK.OptionsColumn.ReadOnly = true;
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
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frequency Setup";
            // 
            // frmFrequency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1040, 720);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFrequency";
            this.Text = "Frequency Setup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFrequency_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBackground)).EndInit();
            this.pnlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewFrequency)).EndInit();
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
        private DevExpress.XtraGrid.GridControl grdFrequency;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewFrequency;
        private DevExpress.XtraGrid.Columns.GridColumn grdColPK;
        private DevExpress.XtraGrid.Columns.GridColumn grdColTreadmentType;
        private DevExpress.XtraGrid.Columns.GridColumn grdColDiagnosis;
        private DevExpress.XtraGrid.Columns.GridColumn grdColIsActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositorychkIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn grdColTreatmentPK;
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