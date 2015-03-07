namespace MediPro
{
    partial class frmBooking
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
            this.components = new System.ComponentModel.Container();
            this.repositorycboDay = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryFromTime = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.repositoryToTime = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.pnl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cmdSave = new DevExpress.XtraEditors.SimpleButton();
            this.cmdExit = new DevExpress.XtraEditors.SimpleButton();
            this.luePatient = new DevExpress.XtraEditors.LookUpEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cboOption = new System.Windows.Forms.ComboBox();
            this.grpClinicTime = new DevExpress.XtraEditors.GroupControl();
            this.grdCTbyDoctor = new DevExpress.XtraGrid.GridControl();
            this.grdViewClinicTime = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColctdPK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColfromTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColtoTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColDoctorPK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdClinicTime = new DevExpress.XtraEditors.SimpleButton();
            this.lueDoctor = new DevExpress.XtraEditors.LookUpEdit();
            this.dteBookingDate = new DevExpress.XtraEditors.DateEdit();
            this.grpPatientType = new System.Windows.Forms.GroupBox();
            this.radioRegPatient = new System.Windows.Forms.RadioButton();
            this.radioNewPatient = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLastBookingTime = new System.Windows.Forms.Label();
            this.lblTokenNo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPatientName = new DevExpress.XtraEditors.TextEdit();
            this.backstageViewTabItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.backstageViewTabItem2 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.backstageViewButtonItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.backstageViewItemSeparator1 = new DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repositorycboDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryFromTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryToTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl1)).BeginInit();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luePatient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpClinicTime)).BeginInit();
            this.grpClinicTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCTbyDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewClinicTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDoctor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteBookingDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteBookingDate.Properties)).BeginInit();
            this.grpPatientType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientName.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.pnl1.Size = new System.Drawing.Size(571, 46);
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
            this.lbl1.Size = new System.Drawing.Size(69, 18);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Booking";
            // 
            // txtRegNo
            // 
            this.txtRegNo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegNo.Location = new System.Drawing.Point(358, 156);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.ReadOnly = true;
            this.txtRegNo.Size = new System.Drawing.Size(190, 20);
            this.txtRegNo.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(35, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "Patient\'s Name";
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.BackColor = System.Drawing.Color.Transparent;
            this.lblRegNo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegNo.ForeColor = System.Drawing.Color.Navy;
            this.lblRegNo.Location = new System.Drawing.Point(356, 141);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(48, 14);
            this.lblRegNo.TabIndex = 11;
            this.lblRegNo.Text = "Reg No.";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Navy;
            this.label22.Location = new System.Drawing.Point(35, 201);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 14);
            this.label22.TabIndex = 11;
            this.label22.Text = "Doctor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(130, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 14);
            this.label1.TabIndex = 12;
            this.label1.Text = ":";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Navy;
            this.label23.Location = new System.Drawing.Point(130, 201);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(10, 14);
            this.label23.TabIndex = 12;
            this.label23.Text = ":";
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cmdSave.Appearance.Options.UseFont = true;
            this.cmdSave.Appearance.Options.UseForeColor = true;
            this.cmdSave.Location = new System.Drawing.Point(394, 452);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 26);
            this.cmdSave.TabIndex = 6;
            this.cmdSave.Text = "Save";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Appearance.ForeColor = System.Drawing.Color.Red;
            this.cmdExit.Appearance.Options.UseFont = true;
            this.cmdExit.Appearance.Options.UseForeColor = true;
            this.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdExit.Location = new System.Drawing.Point(475, 452);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 26);
            this.cmdExit.TabIndex = 7;
            this.cmdExit.Text = "Close";
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // luePatient
            // 
            this.luePatient.Location = new System.Drawing.Point(142, 156);
            this.luePatient.Name = "luePatient";
            this.luePatient.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.luePatient.Properties.Appearance.Options.UseFont = true;
            this.luePatient.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.luePatient.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.luePatient.Properties.AutoSearchColumnIndex = 1;
            this.luePatient.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luePatient.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RegNo", 120, "Reg No."),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 150, "Patient\'s Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FatherName", 150, "Father\'s Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DOB", 100, "DOB"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NRC", 150, "NRC / Passport")});
            this.luePatient.Properties.DisplayMember = "Name";
            this.luePatient.Properties.DropDownRows = 10;
            this.luePatient.Properties.LookAndFeel.SkinName = "Metropolis";
            this.luePatient.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.luePatient.Properties.NullText = "";
            this.luePatient.Properties.PopupWidth = 650;
            this.luePatient.Properties.ValueMember = "RegNo";
            this.luePatient.Size = new System.Drawing.Size(211, 20);
            this.luePatient.TabIndex = 2;
            this.luePatient.EditValueChanged += new System.EventHandler(this.luePatient_EditValueChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.cboOption);
            this.panelControl1.Controls.Add(this.grpClinicTime);
            this.panelControl1.Controls.Add(this.cmdClinicTime);
            this.panelControl1.Controls.Add(this.lueDoctor);
            this.panelControl1.Controls.Add(this.dteBookingDate);
            this.panelControl1.Controls.Add(this.grpPatientType);
            this.panelControl1.Controls.Add(this.luePatient);
            this.panelControl1.Controls.Add(this.cmdExit);
            this.panelControl1.Controls.Add(this.cmdSave);
            this.panelControl1.Controls.Add(this.label23);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.label22);
            this.panelControl1.Controls.Add(this.lblRegNo);
            this.panelControl1.Controls.Add(this.label8);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.lblLastBookingTime);
            this.panelControl1.Controls.Add(this.lblTokenNo);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.txtRegNo);
            this.panelControl1.Controls.Add(this.pnl1);
            this.panelControl1.Controls.Add(this.txtPatientName);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.LookAndFeel.UseWindowsXPTheme = true;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(573, 499);
            this.panelControl1.TabIndex = 1;
            // 
            // cboOption
            // 
            this.cboOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cboOption.FormattingEnabled = true;
            this.cboOption.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.cboOption.Location = new System.Drawing.Point(358, 241);
            this.cboOption.Name = "cboOption";
            this.cboOption.Size = new System.Drawing.Size(192, 21);
            this.cboOption.TabIndex = 5;
            this.cboOption.SelectedIndexChanged += new System.EventHandler(this.cboOption_SelectedIndexChanged);
            // 
            // grpClinicTime
            // 
            this.grpClinicTime.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.grpClinicTime.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.grpClinicTime.AppearanceCaption.Options.UseFont = true;
            this.grpClinicTime.AppearanceCaption.Options.UseForeColor = true;
            this.grpClinicTime.Controls.Add(this.grdCTbyDoctor);
            this.grpClinicTime.Location = new System.Drawing.Point(38, 281);
            this.grpClinicTime.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grpClinicTime.Name = "grpClinicTime";
            this.grpClinicTime.Size = new System.Drawing.Size(339, 198);
            this.grpClinicTime.TabIndex = 23;
            this.grpClinicTime.Text = "Clinic Time of Dr Name";
            // 
            // grdCTbyDoctor
            // 
            this.grdCTbyDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCTbyDoctor.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdCTbyDoctor.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdCTbyDoctor.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdCTbyDoctor.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdCTbyDoctor.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdCTbyDoctor.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.grdCTbyDoctor.Location = new System.Drawing.Point(2, 21);
            this.grdCTbyDoctor.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdCTbyDoctor.MainView = this.grdViewClinicTime;
            this.grdCTbyDoctor.Name = "grdCTbyDoctor";
            this.grdCTbyDoctor.Size = new System.Drawing.Size(335, 175);
            this.grdCTbyDoctor.TabIndex = 2;
            this.grdCTbyDoctor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.grdViewClinicTime.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.grdViewClinicTime.ColumnPanelRowHeight = 30;
            this.grdViewClinicTime.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColctdPK,
            this.grdColDay,
            this.grdColfromTime,
            this.grdColtoTime,
            this.grdColDoctorPK});
            this.grdViewClinicTime.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdViewClinicTime.GridControl = this.grdCTbyDoctor;
            this.grdViewClinicTime.Name = "grdViewClinicTime";
            this.grdViewClinicTime.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.grdViewClinicTime.OptionsBehavior.FocusLeaveOnTab = true;
            this.grdViewClinicTime.OptionsCustomization.AllowColumnMoving = false;
            this.grdViewClinicTime.OptionsCustomization.AllowColumnResizing = false;
            this.grdViewClinicTime.OptionsCustomization.AllowFilter = false;
            this.grdViewClinicTime.OptionsCustomization.AllowGroup = false;
            this.grdViewClinicTime.OptionsCustomization.AllowQuickHideColumns = false;
            this.grdViewClinicTime.OptionsCustomization.AllowSort = false;
            this.grdViewClinicTime.OptionsView.EnableAppearanceEvenRow = true;
            this.grdViewClinicTime.OptionsView.ShowDetailButtons = false;
            this.grdViewClinicTime.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grdViewClinicTime.OptionsView.ShowGroupPanel = false;
            this.grdViewClinicTime.OptionsView.ShowIndicator = false;
            this.grdViewClinicTime.RowHeight = 25;
            this.grdViewClinicTime.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll;
            this.grdViewClinicTime.ViewCaptionHeight = 30;
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
            this.grdColDay.OptionsColumn.AllowEdit = false;
            this.grdColDay.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.grdColDay.OptionsColumn.AllowIncrementalSearch = false;
            this.grdColDay.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColDay.OptionsColumn.AllowMove = false;
            this.grdColDay.OptionsColumn.AllowShowHide = false;
            this.grdColDay.OptionsColumn.AllowSize = false;
            this.grdColDay.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.grdColDay.OptionsColumn.FixedWidth = true;
            this.grdColDay.OptionsColumn.ReadOnly = true;
            this.grdColDay.Visible = true;
            this.grdColDay.VisibleIndex = 0;
            this.grdColDay.Width = 150;
            // 
            // grdColfromTime
            // 
            this.grdColfromTime.Caption = "From Time";
            this.grdColfromTime.ColumnEdit = this.repositoryFromTime;
            this.grdColfromTime.DisplayFormat.FormatString = "h:mm tt";
            this.grdColfromTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.grdColfromTime.FieldName = "fromTime";
            this.grdColfromTime.Name = "grdColfromTime";
            this.grdColfromTime.OptionsColumn.AllowEdit = false;
            this.grdColfromTime.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.grdColfromTime.OptionsColumn.AllowIncrementalSearch = false;
            this.grdColfromTime.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColfromTime.OptionsColumn.AllowMove = false;
            this.grdColfromTime.OptionsColumn.AllowShowHide = false;
            this.grdColfromTime.OptionsColumn.AllowSize = false;
            this.grdColfromTime.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.grdColfromTime.OptionsColumn.FixedWidth = true;
            this.grdColfromTime.OptionsColumn.ReadOnly = true;
            this.grdColfromTime.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.grdColfromTime.Visible = true;
            this.grdColfromTime.VisibleIndex = 1;
            this.grdColfromTime.Width = 121;
            // 
            // grdColtoTime
            // 
            this.grdColtoTime.Caption = "To Time";
            this.grdColtoTime.ColumnEdit = this.repositoryToTime;
            this.grdColtoTime.DisplayFormat.FormatString = "h:mm tt";
            this.grdColtoTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.grdColtoTime.FieldName = "toTime";
            this.grdColtoTime.Name = "grdColtoTime";
            this.grdColtoTime.OptionsColumn.AllowEdit = false;
            this.grdColtoTime.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.grdColtoTime.OptionsColumn.AllowIncrementalSearch = false;
            this.grdColtoTime.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColtoTime.OptionsColumn.AllowMove = false;
            this.grdColtoTime.OptionsColumn.AllowShowHide = false;
            this.grdColtoTime.OptionsColumn.AllowSize = false;
            this.grdColtoTime.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.grdColtoTime.OptionsColumn.FixedWidth = true;
            this.grdColtoTime.OptionsColumn.ReadOnly = true;
            this.grdColtoTime.OptionsFilter.AllowAutoFilter = false;
            this.grdColtoTime.OptionsFilter.AllowFilter = false;
            this.grdColtoTime.Visible = true;
            this.grdColtoTime.VisibleIndex = 2;
            this.grdColtoTime.Width = 123;
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
            // cmdClinicTime
            // 
            this.cmdClinicTime.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdClinicTime.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmdClinicTime.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.cmdClinicTime.Appearance.Options.UseBackColor = true;
            this.cmdClinicTime.Appearance.Options.UseFont = true;
            this.cmdClinicTime.Appearance.Options.UseForeColor = true;
            this.cmdClinicTime.Appearance.Options.UseTextOptions = true;
            this.cmdClinicTime.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cmdClinicTime.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdClinicTime.Image = global::MediPro.Properties.Resources.timebydoctor16;
            this.cmdClinicTime.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmdClinicTime.Location = new System.Drawing.Point(352, 198);
            this.cmdClinicTime.Margin = new System.Windows.Forms.Padding(0);
            this.cmdClinicTime.Name = "cmdClinicTime";
            this.cmdClinicTime.Size = new System.Drawing.Size(25, 20);
            this.cmdClinicTime.TabIndex = 3;
            this.cmdClinicTime.ToolTip = "Click information for Doctor\'s Clinic Time ";
            this.cmdClinicTime.Click += new System.EventHandler(this.cmdClinicTime_Click);
            // 
            // lueDoctor
            // 
            this.lueDoctor.Location = new System.Drawing.Point(142, 198);
            this.lueDoctor.Name = "lueDoctor";
            this.lueDoctor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lueDoctor.Properties.Appearance.Options.UseFont = true;
            this.lueDoctor.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lueDoctor.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lueDoctor.Properties.AutoSearchColumnIndex = 1;
            this.lueDoctor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDoctor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DoctorPK", "doctorPK", 120, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("doctor", 150, "Doctor"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("specialize", 150, "Specialize"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("position", 100, "Position")});
            this.lueDoctor.Properties.DisplayMember = "doctor";
            this.lueDoctor.Properties.DropDownRows = 10;
            this.lueDoctor.Properties.LookAndFeel.SkinName = "Metropolis";
            this.lueDoctor.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lueDoctor.Properties.NullText = "";
            this.lueDoctor.Properties.PopupWidth = 650;
            this.lueDoctor.Properties.ValueMember = "doctorPK";
            this.lueDoctor.Size = new System.Drawing.Size(211, 20);
            this.lueDoctor.TabIndex = 3;
            this.lueDoctor.EditValueChanged += new System.EventHandler(this.lueDoctor_EditValueChanged);
            // 
            // dteBookingDate
            // 
            this.dteBookingDate.EditValue = null;
            this.dteBookingDate.Location = new System.Drawing.Point(142, 242);
            this.dteBookingDate.Name = "dteBookingDate";
            this.dteBookingDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dteBookingDate.Properties.Appearance.Options.UseFont = true;
            this.dteBookingDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteBookingDate.Properties.DisplayFormat.FormatString = "D";
            this.dteBookingDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteBookingDate.Properties.Mask.EditMask = "D";
            this.dteBookingDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteBookingDate.Size = new System.Drawing.Size(211, 20);
            this.dteBookingDate.TabIndex = 4;
            this.dteBookingDate.EditValueChanged += new System.EventHandler(this.dteBookingDate_EditValueChanged);
            // 
            // grpPatientType
            // 
            this.grpPatientType.Controls.Add(this.radioRegPatient);
            this.grpPatientType.Controls.Add(this.radioNewPatient);
            this.grpPatientType.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPatientType.ForeColor = System.Drawing.Color.Navy;
            this.grpPatientType.Location = new System.Drawing.Point(35, 70);
            this.grpPatientType.Name = "grpPatientType";
            this.grpPatientType.Size = new System.Drawing.Size(317, 54);
            this.grpPatientType.TabIndex = 0;
            this.grpPatientType.TabStop = false;
            this.grpPatientType.Text = "Paitent Type";
            // 
            // radioRegPatient
            // 
            this.radioRegPatient.AutoSize = true;
            this.radioRegPatient.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRegPatient.ForeColor = System.Drawing.Color.Navy;
            this.radioRegPatient.Location = new System.Drawing.Point(172, 24);
            this.radioRegPatient.Name = "radioRegPatient";
            this.radioRegPatient.Size = new System.Drawing.Size(127, 18);
            this.radioRegPatient.TabIndex = 1;
            this.radioRegPatient.TabStop = true;
            this.radioRegPatient.Text = "&Registered Patient";
            this.radioRegPatient.UseVisualStyleBackColor = true;
            this.radioRegPatient.CheckedChanged += new System.EventHandler(this.radioRegPatient_CheckedChanged);
            // 
            // radioNewPatient
            // 
            this.radioNewPatient.AutoSize = true;
            this.radioNewPatient.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNewPatient.ForeColor = System.Drawing.Color.Navy;
            this.radioNewPatient.Location = new System.Drawing.Point(58, 24);
            this.radioNewPatient.Name = "radioNewPatient";
            this.radioNewPatient.Size = new System.Drawing.Size(90, 18);
            this.radioNewPatient.TabIndex = 0;
            this.radioNewPatient.TabStop = true;
            this.radioNewPatient.Text = "&New Patient";
            this.radioNewPatient.UseVisualStyleBackColor = true;
            this.radioNewPatient.CheckedChanged += new System.EventHandler(this.radioNewPatient_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(474, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(130, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(355, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 14);
            this.label7.TabIndex = 11;
            this.label7.Text = "Option";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(385, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Last Booking Time :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(35, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "Booking Date";
            // 
            // lblLastBookingTime
            // 
            this.lblLastBookingTime.BackColor = System.Drawing.Color.Transparent;
            this.lblLastBookingTime.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastBookingTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLastBookingTime.Location = new System.Drawing.Point(401, 199);
            this.lblLastBookingTime.Name = "lblLastBookingTime";
            this.lblLastBookingTime.Size = new System.Drawing.Size(144, 24);
            this.lblLastBookingTime.TabIndex = 11;
            this.lblLastBookingTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTokenNo
            // 
            this.lblTokenNo.BackColor = System.Drawing.Color.Transparent;
            this.lblTokenNo.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTokenNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTokenNo.Location = new System.Drawing.Point(485, 89);
            this.lblTokenNo.Name = "lblTokenNo";
            this.lblTokenNo.Size = new System.Drawing.Size(63, 29);
            this.lblTokenNo.TabIndex = 11;
            this.lblTokenNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(380, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Last Token No.";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(142, 156);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtPatientName.Properties.Appearance.Options.UseFont = true;
            this.txtPatientName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPatientName.Properties.LookAndFeel.SkinName = "Metropolis";
            this.txtPatientName.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtPatientName.Properties.MaxLength = 30;
            this.txtPatientName.Size = new System.Drawing.Size(211, 20);
            this.txtPatientName.TabIndex = 2;
            // 
            // backstageViewTabItem1
            // 
            this.backstageViewTabItem1.Caption = "backstageViewTabItem1";
            this.backstageViewTabItem1.Name = "backstageViewTabItem1";
            this.backstageViewTabItem1.Selected = false;
            // 
            // backstageViewTabItem2
            // 
            this.backstageViewTabItem2.Caption = "backstageViewTabItem2";
            this.backstageViewTabItem2.Name = "backstageViewTabItem2";
            this.backstageViewTabItem2.Selected = false;
            // 
            // backstageViewButtonItem1
            // 
            this.backstageViewButtonItem1.Caption = "backstageViewButtonItem1";
            this.backstageViewButtonItem1.Name = "backstageViewButtonItem1";
            // 
            // backstageViewItemSeparator1
            // 
            this.backstageViewItemSeparator1.Name = "backstageViewItemSeparator1";
            // 
            // myTimer
            // 
            this.myTimer.Interval = 10;
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(577, 503);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBooking";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.frmBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositorycboDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryFromTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryToTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl1)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luePatient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpClinicTime)).EndInit();
            this.grpClinicTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCTbyDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewClinicTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDoctor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteBookingDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteBookingDate.Properties)).EndInit();
            this.grpPatientType.ResumeLayout(false);
            this.grpPatientType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnl1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label23;
        public DevExpress.XtraEditors.SimpleButton cmdSave;
        private DevExpress.XtraEditors.SimpleButton cmdExit;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox grpPatientType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        public DevExpress.XtraEditors.DateEdit dteBookingDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton cmdClinicTime;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem1;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem2;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem backstageViewButtonItem1;
        private DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator backstageViewItemSeparator1;
        private DevExpress.XtraEditors.GroupControl grpClinicTime;
        private System.Windows.Forms.Timer myTimer;
        private DevExpress.XtraGrid.GridControl grdCTbyDoctor;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewClinicTime;
        private DevExpress.XtraGrid.Columns.GridColumn grdColctdPK;
        private DevExpress.XtraGrid.Columns.GridColumn grdColDay;
        private DevExpress.XtraGrid.Columns.GridColumn grdColfromTime;
        private DevExpress.XtraGrid.Columns.GridColumn grdColtoTime;
        private DevExpress.XtraGrid.Columns.GridColumn grdColDoctorPK;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositorycboDay;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryFromTime;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryToTime;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cboOption;
        protected System.Windows.Forms.TextBox txtRegNo;
        public DevExpress.XtraEditors.LookUpEdit luePatient;
        public System.Windows.Forms.RadioButton radioRegPatient;
        public System.Windows.Forms.RadioButton radioNewPatient;
        public System.Windows.Forms.Label lblTokenNo;
        public System.Windows.Forms.Label lblLastBookingTime;
        public DevExpress.XtraEditors.LookUpEdit lueDoctor;
        public DevExpress.XtraEditors.TextEdit txtPatientName;

    }
}