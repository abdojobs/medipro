namespace MediPro
{
    partial class frmVisitPatientsbyDoctor
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.imgPatient = new System.Windows.Forms.PictureBox();
            this.grdTodayVisitPatients = new DevExpress.XtraGrid.GridControl();
            this.grdViewTodayVisitPatients = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColPK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColTokenNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColPatientName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColDoctorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColIsRegistered = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.grdColVisitStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColDoctorPK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColVPK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColRegNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbl1 = new System.Windows.Forms.Label();
            this.cmdOK = new DevExpress.XtraEditors.SimpleButton();
            this.cmdExit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTodayVisitPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewTodayVisitPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl1)).BeginInit();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.imgPatient);
            this.panelControl1.Controls.Add(this.grdTodayVisitPatients);
            this.panelControl1.Controls.Add(this.pnl1);
            this.panelControl1.Controls.Add(this.cmdOK);
            this.panelControl1.Controls.Add(this.cmdExit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.LookAndFeel.UseWindowsXPTheme = true;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(959, 320);
            this.panelControl1.TabIndex = 4;
            // 
            // imgPatient
            // 
            this.imgPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPatient.Location = new System.Drawing.Point(847, 59);
            this.imgPatient.Name = "imgPatient";
            this.imgPatient.Size = new System.Drawing.Size(105, 114);
            this.imgPatient.TabIndex = 21;
            this.imgPatient.TabStop = false;
            // 
            // grdTodayVisitPatients
            // 
            this.grdTodayVisitPatients.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdTodayVisitPatients.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdTodayVisitPatients.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdTodayVisitPatients.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdTodayVisitPatients.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdTodayVisitPatients.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.grdTodayVisitPatients.Location = new System.Drawing.Point(10, 59);
            this.grdTodayVisitPatients.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdTodayVisitPatients.MainView = this.grdViewTodayVisitPatients;
            this.grdTodayVisitPatients.Name = "grdTodayVisitPatients";
            this.grdTodayVisitPatients.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.grdTodayVisitPatients.Size = new System.Drawing.Size(830, 250);
            this.grdTodayVisitPatients.TabIndex = 20;
            this.grdTodayVisitPatients.UseEmbeddedNavigator = true;
            this.grdTodayVisitPatients.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewTodayVisitPatients});
            // 
            // grdViewTodayVisitPatients
            // 
            this.grdViewTodayVisitPatients.Appearance.EvenRow.BackColor = System.Drawing.Color.OldLace;
            this.grdViewTodayVisitPatients.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdViewTodayVisitPatients.Appearance.FocusedRow.BackColor = System.Drawing.Color.Cornsilk;
            this.grdViewTodayVisitPatients.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdViewTodayVisitPatients.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdViewTodayVisitPatients.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdViewTodayVisitPatients.Appearance.SelectedRow.BackColor = System.Drawing.Color.Cornsilk;
            this.grdViewTodayVisitPatients.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grdViewTodayVisitPatients.ColumnPanelRowHeight = 30;
            this.grdViewTodayVisitPatients.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColPK,
            this.grdColTokenNo,
            this.grdColPatientName,
            this.grdColDoctorName,
            this.grdTime,
            this.grdColIsRegistered,
            this.grdColVisitStatus,
            this.grdColDoctorPK,
            this.grdColVPK,
            this.grdColRegNo});
            this.grdViewTodayVisitPatients.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdViewTodayVisitPatients.GridControl = this.grdTodayVisitPatients;
            this.grdViewTodayVisitPatients.Name = "grdViewTodayVisitPatients";
            this.grdViewTodayVisitPatients.OptionsView.EnableAppearanceEvenRow = true;
            this.grdViewTodayVisitPatients.OptionsView.ShowDetailButtons = false;
            this.grdViewTodayVisitPatients.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grdViewTodayVisitPatients.OptionsView.ShowGroupPanel = false;
            this.grdViewTodayVisitPatients.OptionsView.ShowIndicator = false;
            this.grdViewTodayVisitPatients.RowHeight = 25;
            this.grdViewTodayVisitPatients.ViewCaptionHeight = 30;
            this.grdViewTodayVisitPatients.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdViewTodayVisitPatients_RowClick);
            this.grdViewTodayVisitPatients.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdViewTodayVisitPatients_FocusedRowChanged);
            // 
            // grdColPK
            // 
            this.grdColPK.Caption = "BookingPK";
            this.grdColPK.FieldName = "PK";
            this.grdColPK.Name = "grdColPK";
            this.grdColPK.OptionsColumn.AllowEdit = false;
            this.grdColPK.OptionsColumn.AllowMove = false;
            this.grdColPK.OptionsColumn.AllowShowHide = false;
            this.grdColPK.OptionsColumn.AllowSize = false;
            this.grdColPK.OptionsColumn.ReadOnly = true;
            // 
            // grdColTokenNo
            // 
            this.grdColTokenNo.AppearanceHeader.Options.UseTextOptions = true;
            this.grdColTokenNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdColTokenNo.Caption = "Token No.";
            this.grdColTokenNo.FieldName = "tokenNo";
            this.grdColTokenNo.Name = "grdColTokenNo";
            this.grdColTokenNo.OptionsColumn.AllowEdit = false;
            this.grdColTokenNo.OptionsColumn.AllowFocus = false;
            this.grdColTokenNo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.grdColTokenNo.OptionsColumn.AllowIncrementalSearch = false;
            this.grdColTokenNo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColTokenNo.OptionsColumn.AllowMove = false;
            this.grdColTokenNo.OptionsColumn.AllowShowHide = false;
            this.grdColTokenNo.OptionsColumn.AllowSize = false;
            this.grdColTokenNo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.grdColTokenNo.OptionsColumn.ReadOnly = true;
            this.grdColTokenNo.Visible = true;
            this.grdColTokenNo.VisibleIndex = 0;
            this.grdColTokenNo.Width = 100;
            // 
            // grdColPatientName
            // 
            this.grdColPatientName.Caption = "Patient\'s Name";
            this.grdColPatientName.FieldName = "patientName";
            this.grdColPatientName.Name = "grdColPatientName";
            this.grdColPatientName.OptionsColumn.AllowEdit = false;
            this.grdColPatientName.OptionsColumn.AllowFocus = false;
            this.grdColPatientName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.grdColPatientName.OptionsColumn.AllowIncrementalSearch = false;
            this.grdColPatientName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColPatientName.OptionsColumn.AllowMove = false;
            this.grdColPatientName.OptionsColumn.AllowShowHide = false;
            this.grdColPatientName.OptionsColumn.AllowSize = false;
            this.grdColPatientName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.grdColPatientName.OptionsColumn.ReadOnly = true;
            this.grdColPatientName.Visible = true;
            this.grdColPatientName.VisibleIndex = 1;
            this.grdColPatientName.Width = 200;
            // 
            // grdColDoctorName
            // 
            this.grdColDoctorName.Caption = "Doctor";
            this.grdColDoctorName.FieldName = "doctorName";
            this.grdColDoctorName.Name = "grdColDoctorName";
            this.grdColDoctorName.OptionsColumn.AllowEdit = false;
            this.grdColDoctorName.OptionsColumn.AllowFocus = false;
            this.grdColDoctorName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.grdColDoctorName.OptionsColumn.AllowIncrementalSearch = false;
            this.grdColDoctorName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColDoctorName.OptionsColumn.AllowMove = false;
            this.grdColDoctorName.OptionsColumn.AllowShowHide = false;
            this.grdColDoctorName.OptionsColumn.AllowSize = false;
            this.grdColDoctorName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.grdColDoctorName.OptionsColumn.ReadOnly = true;
            this.grdColDoctorName.Width = 167;
            // 
            // grdTime
            // 
            this.grdTime.Caption = "Time";
            this.grdTime.FieldName = "abTime";
            this.grdTime.Name = "grdTime";
            this.grdTime.OptionsColumn.AllowEdit = false;
            this.grdTime.OptionsColumn.AllowFocus = false;
            this.grdTime.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.grdTime.OptionsColumn.AllowIncrementalSearch = false;
            this.grdTime.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdTime.OptionsColumn.AllowMove = false;
            this.grdTime.OptionsColumn.AllowShowHide = false;
            this.grdTime.OptionsColumn.AllowSize = false;
            this.grdTime.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.grdTime.OptionsColumn.ReadOnly = true;
            this.grdTime.Visible = true;
            this.grdTime.VisibleIndex = 2;
            this.grdTime.Width = 89;
            // 
            // grdColIsRegistered
            // 
            this.grdColIsRegistered.Caption = "Is Registered";
            this.grdColIsRegistered.ColumnEdit = this.repositoryItemCheckEdit2;
            this.grdColIsRegistered.FieldName = "isNew";
            this.grdColIsRegistered.Name = "grdColIsRegistered";
            this.grdColIsRegistered.OptionsColumn.AllowEdit = false;
            this.grdColIsRegistered.OptionsColumn.AllowFocus = false;
            this.grdColIsRegistered.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.grdColIsRegistered.OptionsColumn.AllowIncrementalSearch = false;
            this.grdColIsRegistered.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColIsRegistered.OptionsColumn.AllowMove = false;
            this.grdColIsRegistered.OptionsColumn.AllowShowHide = false;
            this.grdColIsRegistered.OptionsColumn.AllowSize = false;
            this.grdColIsRegistered.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.grdColIsRegistered.OptionsColumn.ReadOnly = true;
            this.grdColIsRegistered.Visible = true;
            this.grdColIsRegistered.VisibleIndex = 3;
            this.grdColIsRegistered.Width = 141;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.DisplayValueChecked = "1";
            this.repositoryItemCheckEdit2.DisplayValueUnchecked = "0";
            this.repositoryItemCheckEdit2.LookAndFeel.SkinName = "VS2010";
            this.repositoryItemCheckEdit2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // grdColVisitStatus
            // 
            this.grdColVisitStatus.Caption = "Visit Status";
            this.grdColVisitStatus.FieldName = "abType";
            this.grdColVisitStatus.Name = "grdColVisitStatus";
            this.grdColVisitStatus.OptionsColumn.AllowEdit = false;
            this.grdColVisitStatus.OptionsColumn.AllowFocus = false;
            this.grdColVisitStatus.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.grdColVisitStatus.OptionsColumn.AllowIncrementalSearch = false;
            this.grdColVisitStatus.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColVisitStatus.OptionsColumn.AllowMove = false;
            this.grdColVisitStatus.OptionsColumn.AllowShowHide = false;
            this.grdColVisitStatus.OptionsColumn.AllowSize = false;
            this.grdColVisitStatus.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.grdColVisitStatus.OptionsColumn.ReadOnly = true;
            this.grdColVisitStatus.Visible = true;
            this.grdColVisitStatus.VisibleIndex = 4;
            this.grdColVisitStatus.Width = 169;
            // 
            // grdColDoctorPK
            // 
            this.grdColDoctorPK.AppearanceHeader.Options.UseTextOptions = true;
            this.grdColDoctorPK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdColDoctorPK.Caption = "DoctorID";
            this.grdColDoctorPK.FieldName = "doctorPK";
            this.grdColDoctorPK.Name = "grdColDoctorPK";
            this.grdColDoctorPK.OptionsColumn.AllowEdit = false;
            this.grdColDoctorPK.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColDoctorPK.OptionsColumn.AllowMove = false;
            this.grdColDoctorPK.OptionsColumn.AllowShowHide = false;
            this.grdColDoctorPK.OptionsColumn.AllowSize = false;
            this.grdColDoctorPK.OptionsColumn.FixedWidth = true;
            this.grdColDoctorPK.OptionsColumn.ReadOnly = true;
            this.grdColDoctorPK.OptionsFilter.AllowAutoFilter = false;
            this.grdColDoctorPK.OptionsFilter.AllowFilter = false;
            this.grdColDoctorPK.Width = 250;
            // 
            // grdColVPK
            // 
            this.grdColVPK.Caption = "VisitPK";
            this.grdColVPK.FieldName = "visitPK";
            this.grdColVPK.Name = "grdColVPK";
            // 
            // grdColRegNo
            // 
            this.grdColRegNo.Caption = "RegNo";
            this.grdColRegNo.FieldName = "RegNo";
            this.grdColRegNo.Name = "grdColRegNo";
            // 
            // pnl1
            // 
            this.pnl1.Appearance.BackColor = System.Drawing.Color.Silver;
            this.pnl1.Appearance.Options.UseBackColor = true;
            this.pnl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnl1.Controls.Add(this.lbl1);
            this.pnl1.Enabled = false;
            this.pnl1.Location = new System.Drawing.Point(1, 1);
            this.pnl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.pnl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnl1.Margin = new System.Windows.Forms.Padding(0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(957, 46);
            this.pnl1.TabIndex = 19;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(10, 19);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(158, 18);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Today Visit Patients";
            // 
            // cmdOK
            // 
            this.cmdOK.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOK.Appearance.ForeColor = System.Drawing.Color.Red;
            this.cmdOK.Appearance.Options.UseFont = true;
            this.cmdOK.Appearance.Options.UseForeColor = true;
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdOK.Location = new System.Drawing.Point(852, 242);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(94, 24);
            this.cmdOK.TabIndex = 3;
            this.cmdOK.Text = "OK";
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Appearance.ForeColor = System.Drawing.Color.Red;
            this.cmdExit.Appearance.Options.UseFont = true;
            this.cmdExit.Appearance.Options.UseForeColor = true;
            this.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdExit.Location = new System.Drawing.Point(852, 276);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(94, 24);
            this.cmdExit.TabIndex = 3;
            this.cmdExit.Text = "Close";
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // frmVisitPatientsbyDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(963, 324);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVisitPatientsbyDoctor";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmVisitPatientsbyDoctor";
            this.Load += new System.EventHandler(this.frmVisitPatientsbyDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTodayVisitPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewTodayVisitPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl1)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdExit;
        private DevExpress.XtraGrid.GridControl grdTodayVisitPatients;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewTodayVisitPatients;
        private DevExpress.XtraGrid.Columns.GridColumn grdColPK;
        private DevExpress.XtraGrid.Columns.GridColumn grdColTokenNo;
        private DevExpress.XtraGrid.Columns.GridColumn grdColPatientName;
        private DevExpress.XtraGrid.Columns.GridColumn grdColDoctorName;
        private DevExpress.XtraGrid.Columns.GridColumn grdTime;
        private DevExpress.XtraGrid.Columns.GridColumn grdColIsRegistered;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn grdColVisitStatus;
        private DevExpress.XtraGrid.Columns.GridColumn grdColDoctorPK;
        private DevExpress.XtraGrid.Columns.GridColumn grdColVPK;
        private DevExpress.XtraGrid.Columns.GridColumn grdColRegNo;
        private DevExpress.XtraEditors.PanelControl pnl1;
        private System.Windows.Forms.Label lbl1;
        private DevExpress.XtraEditors.SimpleButton cmdOK;
        private System.Windows.Forms.PictureBox imgPatient;
    }
}