namespace Lab
{
    partial class frmPatients
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
            this.grdPatient = new DevExpress.XtraGrid.GridControl();
            this.grdViewPatient = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColRegNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColPatientName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColFatherName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColNRC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColDOB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColTitlePK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColRegDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositorychkIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.cmdExit = new DevExpress.XtraEditors.SimpleButton();
            this.cmdEdit = new DevExpress.XtraEditors.SimpleButton();
            this.cmdViewDetail = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNew = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBackground)).BeginInit();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorychkIsActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.pnlBackground.Appearance.Options.UseBackColor = true;
            this.pnlBackground.Controls.Add(this.grdPatient);
            this.pnlBackground.Controls.Add(this.panelControl2);
            this.pnlBackground.Controls.Add(this.panelControl1);
            this.pnlBackground.Location = new System.Drawing.Point(24, 13);
            this.pnlBackground.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlBackground.LookAndFeel.UseWindowsXPTheme = true;
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1000, 678);
            this.pnlBackground.TabIndex = 1;
            // 
            // grdPatient
            // 
            this.grdPatient.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdPatient.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdPatient.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdPatient.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdPatient.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdPatient.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.grdPatient.Location = new System.Drawing.Point(15, 71);
            this.grdPatient.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdPatient.MainView = this.grdViewPatient;
            this.grdPatient.Name = "grdPatient";
            this.grdPatient.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositorychkIsActive});
            this.grdPatient.Size = new System.Drawing.Size(970, 527);
            this.grdPatient.TabIndex = 1;
            this.grdPatient.UseEmbeddedNavigator = true;
            this.grdPatient.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewPatient});
            // 
            // grdViewPatient
            // 
            this.grdViewPatient.Appearance.Empty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grdViewPatient.Appearance.Empty.Options.UseBackColor = true;
            this.grdViewPatient.Appearance.EvenRow.BackColor = System.Drawing.Color.OldLace;
            this.grdViewPatient.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdViewPatient.Appearance.FocusedCell.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewPatient.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grdViewPatient.Appearance.FocusedRow.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewPatient.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdViewPatient.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdViewPatient.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdViewPatient.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewPatient.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grdViewPatient.Appearance.SelectedRow.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewPatient.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grdViewPatient.ColumnPanelRowHeight = 30;
            this.grdViewPatient.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColRegNo,
            this.grdColPatientName,
            this.grdColFatherName,
            this.grdColNRC,
            this.grdColDOB,
            this.grdColGender,
            this.grdColPhone,
            this.grdColEmail,
            this.grdColTitlePK,
            this.grdColRegDate,
            this.grdColName,
            this.grdColAddress});
            this.grdViewPatient.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdViewPatient.GridControl = this.grdPatient;
            this.grdViewPatient.Name = "grdViewPatient";
            this.grdViewPatient.OptionsView.EnableAppearanceEvenRow = true;
            this.grdViewPatient.OptionsView.ShowDetailButtons = false;
            this.grdViewPatient.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grdViewPatient.OptionsView.ShowGroupPanel = false;
            this.grdViewPatient.OptionsView.ShowIndicator = false;
            this.grdViewPatient.RowHeight = 25;
            this.grdViewPatient.ViewCaptionHeight = 30;
            this.grdViewPatient.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdViewPatient_RowClick);
            this.grdViewPatient.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdViewPatient_FocusedRowChanged);
            this.grdViewPatient.DoubleClick += new System.EventHandler(this.grdViewPatient_DoubleClick);
            // 
            // grdColRegNo
            // 
            this.grdColRegNo.Caption = "Reg No";
            this.grdColRegNo.FieldName = "RegNo";
            this.grdColRegNo.Name = "grdColRegNo";
            this.grdColRegNo.OptionsColumn.AllowEdit = false;
            this.grdColRegNo.OptionsColumn.AllowMove = false;
            this.grdColRegNo.OptionsColumn.AllowShowHide = false;
            this.grdColRegNo.OptionsColumn.AllowSize = false;
            this.grdColRegNo.OptionsColumn.ReadOnly = true;
            this.grdColRegNo.Visible = true;
            this.grdColRegNo.VisibleIndex = 0;
            this.grdColRegNo.Width = 125;
            // 
            // grdColPatientName
            // 
            this.grdColPatientName.Caption = "Patient\'s Name";
            this.grdColPatientName.FieldName = "FullName";
            this.grdColPatientName.Name = "grdColPatientName";
            this.grdColPatientName.OptionsColumn.AllowEdit = false;
            this.grdColPatientName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColPatientName.OptionsColumn.AllowMove = false;
            this.grdColPatientName.OptionsColumn.AllowShowHide = false;
            this.grdColPatientName.OptionsColumn.AllowSize = false;
            this.grdColPatientName.OptionsColumn.FixedWidth = true;
            this.grdColPatientName.OptionsColumn.ReadOnly = true;
            this.grdColPatientName.Visible = true;
            this.grdColPatientName.VisibleIndex = 1;
            this.grdColPatientName.Width = 150;
            // 
            // grdColFatherName
            // 
            this.grdColFatherName.Caption = "Father\'s Name";
            this.grdColFatherName.FieldName = "FatherName";
            this.grdColFatherName.Name = "grdColFatherName";
            this.grdColFatherName.OptionsColumn.AllowEdit = false;
            this.grdColFatherName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColFatherName.OptionsColumn.AllowMove = false;
            this.grdColFatherName.OptionsColumn.AllowShowHide = false;
            this.grdColFatherName.OptionsColumn.AllowSize = false;
            this.grdColFatherName.OptionsColumn.FixedWidth = true;
            this.grdColFatherName.OptionsColumn.ReadOnly = true;
            this.grdColFatherName.Visible = true;
            this.grdColFatherName.VisibleIndex = 3;
            this.grdColFatherName.Width = 153;
            // 
            // grdColNRC
            // 
            this.grdColNRC.AppearanceHeader.Options.UseTextOptions = true;
            this.grdColNRC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.grdColNRC.Caption = "NRC No / PassPort";
            this.grdColNRC.FieldName = "NRC";
            this.grdColNRC.Name = "grdColNRC";
            this.grdColNRC.OptionsColumn.AllowEdit = false;
            this.grdColNRC.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColNRC.OptionsColumn.AllowMove = false;
            this.grdColNRC.OptionsColumn.AllowShowHide = false;
            this.grdColNRC.OptionsColumn.AllowSize = false;
            this.grdColNRC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.grdColNRC.OptionsColumn.FixedWidth = true;
            this.grdColNRC.OptionsColumn.ReadOnly = true;
            this.grdColNRC.Visible = true;
            this.grdColNRC.VisibleIndex = 2;
            this.grdColNRC.Width = 130;
            // 
            // grdColDOB
            // 
            this.grdColDOB.Caption = "Date of Birth";
            this.grdColDOB.FieldName = "DOB";
            this.grdColDOB.Name = "grdColDOB";
            this.grdColDOB.OptionsColumn.AllowFocus = false;
            this.grdColDOB.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColDOB.OptionsColumn.AllowMove = false;
            this.grdColDOB.OptionsColumn.AllowShowHide = false;
            this.grdColDOB.OptionsColumn.AllowSize = false;
            this.grdColDOB.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.grdColDOB.OptionsColumn.FixedWidth = true;
            this.grdColDOB.OptionsColumn.ReadOnly = true;
            this.grdColDOB.Visible = true;
            this.grdColDOB.VisibleIndex = 4;
            this.grdColDOB.Width = 118;
            // 
            // grdColGender
            // 
            this.grdColGender.Caption = "Gender";
            this.grdColGender.FieldName = "Gender";
            this.grdColGender.Name = "grdColGender";
            this.grdColGender.OptionsColumn.AllowFocus = false;
            this.grdColGender.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColGender.OptionsColumn.AllowMove = false;
            this.grdColGender.OptionsColumn.AllowShowHide = false;
            this.grdColGender.OptionsColumn.AllowSize = false;
            this.grdColGender.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.grdColGender.OptionsColumn.FixedWidth = true;
            this.grdColGender.OptionsColumn.ReadOnly = true;
            this.grdColGender.Visible = true;
            this.grdColGender.VisibleIndex = 5;
            this.grdColGender.Width = 86;
            // 
            // grdColPhone
            // 
            this.grdColPhone.Caption = "Phone No.";
            this.grdColPhone.FieldName = "Phone";
            this.grdColPhone.Name = "grdColPhone";
            this.grdColPhone.OptionsColumn.AllowFocus = false;
            this.grdColPhone.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColPhone.OptionsColumn.AllowMove = false;
            this.grdColPhone.OptionsColumn.AllowShowHide = false;
            this.grdColPhone.OptionsColumn.AllowSize = false;
            this.grdColPhone.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.grdColPhone.OptionsColumn.FixedWidth = true;
            this.grdColPhone.OptionsColumn.ReadOnly = true;
            this.grdColPhone.Visible = true;
            this.grdColPhone.VisibleIndex = 6;
            this.grdColPhone.Width = 206;
            // 
            // grdColEmail
            // 
            this.grdColEmail.Caption = "E-mail Address";
            this.grdColEmail.FieldName = "Email";
            this.grdColEmail.Name = "grdColEmail";
            this.grdColEmail.Width = 165;
            // 
            // grdColTitlePK
            // 
            this.grdColTitlePK.Caption = "TitlePK";
            this.grdColTitlePK.FieldName = "titlePK";
            this.grdColTitlePK.Name = "grdColTitlePK";
            // 
            // grdColRegDate
            // 
            this.grdColRegDate.Caption = "RegDate";
            this.grdColRegDate.FieldName = "RegDate";
            this.grdColRegDate.Name = "grdColRegDate";
            // 
            // grdColName
            // 
            this.grdColName.Caption = "Name";
            this.grdColName.FieldName = "Name";
            this.grdColName.Name = "grdColName";
            // 
            // grdColAddress
            // 
            this.grdColAddress.Caption = "Address";
            this.grdColAddress.FieldName = "Address";
            this.grdColAddress.Name = "grdColAddress";
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
            this.panelControl2.Controls.Add(this.cmdViewDetail);
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
            this.panelControl3.Controls.Add(this.textEdit1);
            this.panelControl3.Location = new System.Drawing.Point(15, 14);
            this.panelControl3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.panelControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(332, 38);
            this.panelControl3.TabIndex = 1;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = global::Lab.Properties.Resources.search;
            this.simpleButton3.Location = new System.Drawing.Point(294, 8);
            this.simpleButton3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.simpleButton3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(25, 19);
            this.simpleButton3.TabIndex = 1;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(10, 8);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(279, 20);
            this.textEdit1.TabIndex = 0;
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
            this.cmdExit.Location = new System.Drawing.Point(883, 16);
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
            this.cmdEdit.Location = new System.Drawing.Point(775, 16);
            this.cmdEdit.LookAndFeel.SkinName = "Seven Classic";
            this.cmdEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(94, 34);
            this.cmdEdit.TabIndex = 0;
            this.cmdEdit.Text = "Edit";
            this.cmdEdit.Visible = false;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdViewDetail
            // 
            this.cmdViewDetail.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdViewDetail.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.cmdViewDetail.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdViewDetail.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cmdViewDetail.Appearance.Options.UseBackColor = true;
            this.cmdViewDetail.Appearance.Options.UseFont = true;
            this.cmdViewDetail.Appearance.Options.UseForeColor = true;
            this.cmdViewDetail.Location = new System.Drawing.Point(356, 16);
            this.cmdViewDetail.LookAndFeel.SkinName = "Seven Classic";
            this.cmdViewDetail.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdViewDetail.Name = "cmdViewDetail";
            this.cmdViewDetail.Size = new System.Drawing.Size(141, 34);
            this.cmdViewDetail.TabIndex = 0;
            this.cmdViewDetail.Text = "View Detail";
            this.cmdViewDetail.Click += new System.EventHandler(this.cmdViewDetail_Click);
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
            this.cmdNew.Location = new System.Drawing.Point(775, 16);
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
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patients";
            // 
            // frmPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 713);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPatients";
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.frmPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBackground)).EndInit();
            this.pnlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorychkIsActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlBackground;
        private DevExpress.XtraGrid.GridControl grdPatient;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewPatient;
        private DevExpress.XtraGrid.Columns.GridColumn grdColRegNo;
        private DevExpress.XtraGrid.Columns.GridColumn grdColPatientName;
        private DevExpress.XtraGrid.Columns.GridColumn grdColFatherName;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositorychkIsActive;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton cmdExit;
        private DevExpress.XtraEditors.SimpleButton cmdEdit;
        private DevExpress.XtraEditors.SimpleButton cmdNew;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn grdColNRC;
        private DevExpress.XtraGrid.Columns.GridColumn grdColDOB;
        private DevExpress.XtraGrid.Columns.GridColumn grdColGender;
        private DevExpress.XtraGrid.Columns.GridColumn grdColPhone;
        private DevExpress.XtraGrid.Columns.GridColumn grdColEmail;
        private DevExpress.XtraGrid.Columns.GridColumn grdColTitlePK;
        private DevExpress.XtraGrid.Columns.GridColumn grdColRegDate;
        private DevExpress.XtraEditors.SimpleButton cmdViewDetail;
        private DevExpress.XtraGrid.Columns.GridColumn grdColName;
        private DevExpress.XtraGrid.Columns.GridColumn grdColAddress;
    }
}