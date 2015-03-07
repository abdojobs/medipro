namespace MediPro
{
    partial class frmClinicTimeByDoctor
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
            this.cboDay = new System.Windows.Forms.ComboBox();
            this.grdClinicTime = new DevExpress.XtraGrid.GridControl();
            this.grdViewClinicTime = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColctdPK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositorycboDay = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.grdOption = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositorycboOption = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.grdColfromTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryFromTime = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.grdColtoTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryToTime = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.grdColDoctorPK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboDoctor = new System.Windows.Forms.ComboBox();
            this.cmdSave = new DevExpress.XtraEditors.SimpleButton();
            this.cmdDelete = new DevExpress.XtraEditors.SimpleButton();
            this.cmdExit = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.pnl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClinicTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewClinicTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorycboDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorycboOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryFromTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryToTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl1)).BeginInit();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.cboDay);
            this.panelControl1.Controls.Add(this.grdClinicTime);
            this.panelControl1.Controls.Add(this.cboDoctor);
            this.panelControl1.Controls.Add(this.cmdSave);
            this.panelControl1.Controls.Add(this.cmdDelete);
            this.panelControl1.Controls.Add(this.cmdExit);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.label23);
            this.panelControl1.Controls.Add(this.label22);
            this.panelControl1.Controls.Add(this.pnl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.LookAndFeel.UseWindowsXPTheme = true;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(527, 453);
            this.panelControl1.TabIndex = 0;
            // 
            // cboDay
            // 
            this.cboDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDay.FormattingEnabled = true;
            this.cboDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cboDay.Location = new System.Drawing.Point(120, 114);
            this.cboDay.Name = "cboDay";
            this.cboDay.Size = new System.Drawing.Size(229, 21);
            this.cboDay.TabIndex = 21;
            this.cboDay.SelectedValueChanged += new System.EventHandler(this.cboDoctor_SelectedValueChanged);
            // 
            // grdClinicTime
            // 
            this.grdClinicTime.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdClinicTime.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdClinicTime.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdClinicTime.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdClinicTime.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdClinicTime.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.grdClinicTime.Location = new System.Drawing.Point(39, 154);
            this.grdClinicTime.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdClinicTime.MainView = this.grdViewClinicTime;
            this.grdClinicTime.Name = "grdClinicTime";
            this.grdClinicTime.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositorycboDay,
            this.repositoryFromTime,
            this.repositoryToTime,
            this.repositorycboOption});
            this.grdClinicTime.Size = new System.Drawing.Size(456, 245);
            this.grdClinicTime.TabIndex = 1;
            this.grdClinicTime.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewClinicTime});
            // 
            // grdViewClinicTime
            // 
            this.grdViewClinicTime.Appearance.EvenRow.BackColor = System.Drawing.Color.OldLace;
            this.grdViewClinicTime.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdViewClinicTime.Appearance.FocusedRow.BackColor = System.Drawing.Color.Cornsilk;
            this.grdViewClinicTime.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdViewClinicTime.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdViewClinicTime.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdViewClinicTime.Appearance.SelectedRow.BackColor = System.Drawing.Color.Cornsilk;
            this.grdViewClinicTime.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grdViewClinicTime.ColumnPanelRowHeight = 30;
            this.grdViewClinicTime.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColctdPK,
            this.grdColDay,
            this.grdOption,
            this.grdColfromTime,
            this.grdColtoTime,
            this.grdColDoctorPK});
            this.grdViewClinicTime.GridControl = this.grdClinicTime;
            this.grdViewClinicTime.Name = "grdViewClinicTime";
            this.grdViewClinicTime.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.grdViewClinicTime.OptionsBehavior.FocusLeaveOnTab = true;
            this.grdViewClinicTime.OptionsCustomization.AllowColumnMoving = false;
            this.grdViewClinicTime.OptionsCustomization.AllowColumnResizing = false;
            this.grdViewClinicTime.OptionsCustomization.AllowFilter = false;
            this.grdViewClinicTime.OptionsCustomization.AllowGroup = false;
            this.grdViewClinicTime.OptionsCustomization.AllowQuickHideColumns = false;
            this.grdViewClinicTime.OptionsCustomization.AllowSort = false;
            this.grdViewClinicTime.OptionsNavigation.AutoFocusNewRow = true;
            this.grdViewClinicTime.OptionsView.EnableAppearanceEvenRow = true;
            this.grdViewClinicTime.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grdViewClinicTime.OptionsView.ShowDetailButtons = false;
            this.grdViewClinicTime.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grdViewClinicTime.OptionsView.ShowGroupPanel = false;
            this.grdViewClinicTime.OptionsView.ShowIndicator = false;
            this.grdViewClinicTime.RowHeight = 25;
            this.grdViewClinicTime.ViewCaptionHeight = 30;
            this.grdViewClinicTime.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdViewClinicTime_RowClick);
            this.grdViewClinicTime.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdViewClinicTime_FocusedRowChanged);
            this.grdViewClinicTime.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdViewClinicTime_CellValueChanged);
            this.grdViewClinicTime.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.grdViewClinicTime_ValidateRow);
            // 
            // grdColctdPK
            // 
            this.grdColctdPK.Caption = "ctdPK";
            this.grdColctdPK.FieldName = "ctdPK";
            this.grdColctdPK.Name = "grdColctdPK";
            this.grdColctdPK.OptionsColumn.AllowEdit = false;
            this.grdColctdPK.OptionsColumn.AllowMove = false;
            this.grdColctdPK.OptionsColumn.AllowShowHide = false;
            this.grdColctdPK.OptionsColumn.AllowSize = false;
            this.grdColctdPK.OptionsColumn.ReadOnly = true;
            // 
            // grdColDay
            // 
            this.grdColDay.AppearanceHeader.Options.UseTextOptions = true;
            this.grdColDay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdColDay.Caption = "Day";
            this.grdColDay.ColumnEdit = this.repositorycboDay;
            this.grdColDay.FieldName = "clinicDay";
            this.grdColDay.Name = "grdColDay";
            this.grdColDay.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.grdColDay.OptionsColumn.AllowIncrementalSearch = false;
            this.grdColDay.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColDay.OptionsColumn.AllowMove = false;
            this.grdColDay.OptionsColumn.AllowShowHide = false;
            this.grdColDay.OptionsColumn.AllowSize = false;
            this.grdColDay.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.grdColDay.OptionsColumn.FixedWidth = true;
            this.grdColDay.Width = 130;
            // 
            // repositorycboDay
            // 
            this.repositorycboDay.AutoHeight = false;
            this.repositorycboDay.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositorycboDay.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.repositorycboDay.Name = "repositorycboDay";
            // 
            // grdOption
            // 
            this.grdOption.Caption = "Option";
            this.grdOption.ColumnEdit = this.repositorycboOption;
            this.grdOption.FieldName = "ctdOption";
            this.grdOption.Name = "grdOption";
            this.grdOption.Width = 124;
            // 
            // repositorycboOption
            // 
            this.repositorycboOption.AutoHeight = false;
            this.repositorycboOption.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositorycboOption.DropDownRows = 3;
            this.repositorycboOption.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.repositorycboOption.Name = "repositorycboOption";
            // 
            // grdColfromTime
            // 
            this.grdColfromTime.Caption = "From Time";
            this.grdColfromTime.ColumnEdit = this.repositoryFromTime;
            this.grdColfromTime.DisplayFormat.FormatString = "d";
            this.grdColfromTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.grdColfromTime.FieldName = "fromTime";
            this.grdColfromTime.Name = "grdColfromTime";
            this.grdColfromTime.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.grdColfromTime.OptionsColumn.AllowIncrementalSearch = false;
            this.grdColfromTime.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColfromTime.OptionsColumn.AllowMove = false;
            this.grdColfromTime.OptionsColumn.AllowShowHide = false;
            this.grdColfromTime.OptionsColumn.AllowSize = false;
            this.grdColfromTime.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.grdColfromTime.OptionsColumn.FixedWidth = true;
            this.grdColfromTime.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.grdColfromTime.Visible = true;
            this.grdColfromTime.VisibleIndex = 0;
            this.grdColfromTime.Width = 100;
            // 
            // repositoryFromTime
            // 
            this.repositoryFromTime.AutoHeight = false;
            this.repositoryFromTime.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryFromTime.DisplayFormat.FormatString = "h:mm tt";
            this.repositoryFromTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryFromTime.Mask.EditMask = "h:mm tt";
            this.repositoryFromTime.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryFromTime.Name = "repositoryFromTime";
            // 
            // grdColtoTime
            // 
            this.grdColtoTime.Caption = "To Time";
            this.grdColtoTime.ColumnEdit = this.repositoryToTime;
            this.grdColtoTime.DisplayFormat.FormatString = "h:mm tt";
            this.grdColtoTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.grdColtoTime.FieldName = "toTime";
            this.grdColtoTime.Name = "grdColtoTime";
            this.grdColtoTime.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.grdColtoTime.OptionsColumn.AllowIncrementalSearch = false;
            this.grdColtoTime.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColtoTime.OptionsColumn.AllowMove = false;
            this.grdColtoTime.OptionsColumn.AllowShowHide = false;
            this.grdColtoTime.OptionsColumn.AllowSize = false;
            this.grdColtoTime.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.grdColtoTime.OptionsColumn.FixedWidth = true;
            this.grdColtoTime.Visible = true;
            this.grdColtoTime.VisibleIndex = 1;
            this.grdColtoTime.Width = 100;
            // 
            // repositoryToTime
            // 
            this.repositoryToTime.AutoHeight = false;
            this.repositoryToTime.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryToTime.DisplayFormat.FormatString = "h:mm tt";
            this.repositoryToTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryToTime.Mask.EditMask = "h:mm tt";
            this.repositoryToTime.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryToTime.Name = "repositoryToTime";
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
            // cboDoctor
            // 
            this.cboDoctor.DisplayMember = "doctor";
            this.cboDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoctor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cboDoctor.FormattingEnabled = true;
            this.cboDoctor.Location = new System.Drawing.Point(120, 77);
            this.cboDoctor.Name = "cboDoctor";
            this.cboDoctor.Size = new System.Drawing.Size(230, 21);
            this.cboDoctor.TabIndex = 0;
            this.cboDoctor.ValueMember = "doctorPK";
            this.cboDoctor.SelectedValueChanged += new System.EventHandler(this.cboDoctor_SelectedValueChanged);
            // 
            // cmdSave
            // 
            this.cmdSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cmdSave.Appearance.Options.UseFont = true;
            this.cmdSave.Appearance.Options.UseForeColor = true;
            this.cmdSave.Location = new System.Drawing.Point(336, 414);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 26);
            this.cmdSave.TabIndex = 3;
            this.cmdSave.Text = "Save";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.Appearance.ForeColor = System.Drawing.Color.Red;
            this.cmdDelete.Appearance.Options.UseFont = true;
            this.cmdDelete.Appearance.Options.UseForeColor = true;
            this.cmdDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdDelete.Location = new System.Drawing.Point(40, 414);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 26);
            this.cmdDelete.TabIndex = 2;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Appearance.ForeColor = System.Drawing.Color.Red;
            this.cmdExit.Appearance.Options.UseFont = true;
            this.cmdExit.Appearance.Options.UseForeColor = true;
            this.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdExit.Location = new System.Drawing.Point(420, 414);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 26);
            this.cmdExit.TabIndex = 4;
            this.cmdExit.Text = "Close";
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(104, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(36, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "Day";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Navy;
            this.label23.Location = new System.Drawing.Point(104, 80);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(10, 14);
            this.label23.TabIndex = 12;
            this.label23.Text = ":";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Navy;
            this.label22.Location = new System.Drawing.Point(35, 80);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 14);
            this.label22.TabIndex = 11;
            this.label22.Text = "Doctor";
            // 
            // pnl1
            // 
            this.pnl1.Appearance.BackColor = System.Drawing.Color.Silver;
            this.pnl1.Appearance.Options.UseBackColor = true;
            this.pnl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnl1.Controls.Add(this.lbl1);
            this.pnl1.Location = new System.Drawing.Point(1, 1);
            this.pnl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.pnl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnl1.Margin = new System.Windows.Forms.Padding(0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(526, 46);
            this.pnl1.TabIndex = 20;
            this.pnl1.TabStop = true;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(10, 19);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(167, 18);
            this.lbl1.TabIndex = 20;
            this.lbl1.Text = "Clinic Time By Doctor";
            // 
            // frmClinicTimeByDoctor
            // 
            this.AcceptButton = this.cmdSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.cmdExit;
            this.ClientSize = new System.Drawing.Size(531, 457);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClinicTimeByDoctor";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinic Time By Doctor";
            this.Load += new System.EventHandler(this.frmClinicTimeByDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClinicTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewClinicTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorycboDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorycboOption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryFromTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryToTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl1)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        public System.Windows.Forms.ComboBox cboDoctor;
        private DevExpress.XtraEditors.SimpleButton cmdExit;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private DevExpress.XtraEditors.PanelControl pnl1;
        private System.Windows.Forms.Label lbl1;
        private DevExpress.XtraGrid.GridControl grdClinicTime;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewClinicTime;
        private DevExpress.XtraGrid.Columns.GridColumn grdColctdPK;
        private DevExpress.XtraGrid.Columns.GridColumn grdColDay;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositorycboDay;
        private DevExpress.XtraGrid.Columns.GridColumn grdColfromTime;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryFromTime;
        private DevExpress.XtraGrid.Columns.GridColumn grdColtoTime;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryToTime;
        private DevExpress.XtraGrid.Columns.GridColumn grdColDoctorPK;
        private DevExpress.XtraEditors.SimpleButton cmdDelete;
        private DevExpress.XtraEditors.SimpleButton cmdSave;
        private DevExpress.XtraGrid.Columns.GridColumn grdOption;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositorycboOption;
        private System.Windows.Forms.ComboBox cboDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}