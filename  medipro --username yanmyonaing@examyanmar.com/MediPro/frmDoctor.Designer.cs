namespace MediPro
{
    partial class frmDoctor
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
            this.grdDoctor = new DevExpress.XtraGrid.GridControl();
            this.grdViewDoctor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColSpecialize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColHomePhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColMobilePhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositorychkIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.grdColName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColtitlePK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColSpecializePK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnl2 = new DevExpress.XtraEditors.PanelControl();
            this.cmdExit = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNew = new DevExpress.XtraEditors.SimpleButton();
            this.pnl3 = new DevExpress.XtraEditors.PanelControl();
            this.cmdSearch = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.cmdEdit = new DevExpress.XtraEditors.SimpleButton();
            this.pnl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbl1 = new System.Windows.Forms.Label();
            this.grdColPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColPositionPK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCoSamaNo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBackground)).BeginInit();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewDoctor)).BeginInit();
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
            // pnlBackground
            // 
            this.pnlBackground.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.pnlBackground.Appearance.Options.UseBackColor = true;
            this.pnlBackground.Controls.Add(this.grdDoctor);
            this.pnlBackground.Controls.Add(this.pnl2);
            this.pnlBackground.Controls.Add(this.pnl1);
            this.pnlBackground.Location = new System.Drawing.Point(33, 24);
            this.pnlBackground.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.pnlBackground.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1000, 678);
            this.pnlBackground.TabIndex = 2;
            // 
            // grdDoctor
            // 
            this.grdDoctor.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdDoctor.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdDoctor.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdDoctor.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdDoctor.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdDoctor.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.grdDoctor.Location = new System.Drawing.Point(15, 76);
            this.grdDoctor.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdDoctor.MainView = this.grdViewDoctor;
            this.grdDoctor.Name = "grdDoctor";
            this.grdDoctor.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositorychkIsActive});
            this.grdDoctor.Size = new System.Drawing.Size(970, 527);
            this.grdDoctor.TabIndex = 2;
            this.grdDoctor.UseEmbeddedNavigator = true;
            this.grdDoctor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewDoctor});
            // 
            // grdViewDoctor
            // 
            this.grdViewDoctor.Appearance.Empty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grdViewDoctor.Appearance.Empty.Options.UseBackColor = true;
            this.grdViewDoctor.Appearance.EvenRow.BackColor = System.Drawing.Color.OldLace;
            this.grdViewDoctor.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdViewDoctor.Appearance.FocusedCell.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewDoctor.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grdViewDoctor.Appearance.FocusedRow.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewDoctor.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdViewDoctor.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdViewDoctor.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdViewDoctor.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewDoctor.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grdViewDoctor.Appearance.SelectedRow.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewDoctor.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grdViewDoctor.ColumnPanelRowHeight = 30;
            this.grdViewDoctor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColID,
            this.grdColFullName,
            this.grdColSpecialize,
            this.grdColPosition,
            this.grdCoSamaNo,
            this.grdColHomePhone,
            this.grdColMobilePhone,
            this.grdColGender,
            this.grdColIsActive,
            this.grdColEmail,
            this.grdColName,
            this.grdColtitlePK,
            this.grdColSpecializePK,
            this.grdColPositionPK});
            this.grdViewDoctor.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdViewDoctor.GridControl = this.grdDoctor;
            this.grdViewDoctor.Name = "grdViewDoctor";
            this.grdViewDoctor.OptionsView.EnableAppearanceEvenRow = true;
            this.grdViewDoctor.OptionsView.ShowDetailButtons = false;
            this.grdViewDoctor.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grdViewDoctor.OptionsView.ShowGroupPanel = false;
            this.grdViewDoctor.OptionsView.ShowIndicator = false;
            this.grdViewDoctor.RowHeight = 25;
            this.grdViewDoctor.ViewCaptionHeight = 30;
            this.grdViewDoctor.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdViewDoctor_RowClick);
            this.grdViewDoctor.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdViewDoctor_FocusedRowChanged);
            this.grdViewDoctor.DoubleClick += new System.EventHandler(this.grdViewDoctor_DoubleClick);
            // 
            // grdColID
            // 
            this.grdColID.Caption = "DoctorPK";
            this.grdColID.FieldName = "doctorPK";
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
            this.grdColFullName.FieldName = "doctorName";
            this.grdColFullName.Name = "grdColFullName";
            this.grdColFullName.OptionsColumn.AllowEdit = false;
            this.grdColFullName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
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
            this.grdColFullName.Width = 180;
            // 
            // grdColSpecialize
            // 
            this.grdColSpecialize.Caption = "Specialize";
            this.grdColSpecialize.FieldName = "specialize";
            this.grdColSpecialize.Name = "grdColSpecialize";
            this.grdColSpecialize.OptionsColumn.AllowEdit = false;
            this.grdColSpecialize.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.grdColSpecialize.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColSpecialize.OptionsColumn.AllowMove = false;
            this.grdColSpecialize.OptionsColumn.AllowShowHide = false;
            this.grdColSpecialize.OptionsColumn.AllowSize = false;
            this.grdColSpecialize.OptionsColumn.FixedWidth = true;
            this.grdColSpecialize.OptionsColumn.ReadOnly = true;
            this.grdColSpecialize.Visible = true;
            this.grdColSpecialize.VisibleIndex = 1;
            this.grdColSpecialize.Width = 150;
            // 
            // grdColHomePhone
            // 
            this.grdColHomePhone.Caption = "Home Phone";
            this.grdColHomePhone.FieldName = "homePhone";
            this.grdColHomePhone.Name = "grdColHomePhone";
            this.grdColHomePhone.OptionsColumn.AllowEdit = false;
            this.grdColHomePhone.OptionsColumn.AllowFocus = false;
            this.grdColHomePhone.OptionsColumn.AllowMove = false;
            this.grdColHomePhone.OptionsColumn.AllowShowHide = false;
            this.grdColHomePhone.OptionsColumn.AllowSize = false;
            this.grdColHomePhone.OptionsColumn.ReadOnly = true;
            this.grdColHomePhone.Visible = true;
            this.grdColHomePhone.VisibleIndex = 4;
            this.grdColHomePhone.Width = 145;
            // 
            // grdColMobilePhone
            // 
            this.grdColMobilePhone.Caption = "Mobile Phone";
            this.grdColMobilePhone.FieldName = "mobilePhone";
            this.grdColMobilePhone.Name = "grdColMobilePhone";
            this.grdColMobilePhone.OptionsColumn.AllowEdit = false;
            this.grdColMobilePhone.OptionsColumn.AllowFocus = false;
            this.grdColMobilePhone.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColMobilePhone.OptionsColumn.AllowMove = false;
            this.grdColMobilePhone.OptionsColumn.AllowShowHide = false;
            this.grdColMobilePhone.OptionsColumn.AllowSize = false;
            this.grdColMobilePhone.OptionsColumn.ReadOnly = true;
            this.grdColMobilePhone.Visible = true;
            this.grdColMobilePhone.VisibleIndex = 5;
            this.grdColMobilePhone.Width = 132;
            // 
            // grdColGender
            // 
            this.grdColGender.Caption = "Gender";
            this.grdColGender.FieldName = "gender";
            this.grdColGender.Name = "grdColGender";
            this.grdColGender.OptionsColumn.AllowEdit = false;
            this.grdColGender.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColGender.OptionsColumn.AllowMove = false;
            this.grdColGender.OptionsColumn.AllowShowHide = false;
            this.grdColGender.OptionsColumn.AllowSize = false;
            this.grdColGender.OptionsColumn.ReadOnly = true;
            this.grdColGender.Visible = true;
            this.grdColGender.VisibleIndex = 6;
            this.grdColGender.Width = 71;
            // 
            // grdColEmail
            // 
            this.grdColEmail.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grdColEmail.AppearanceHeader.Options.UseFont = true;
            this.grdColEmail.Caption = "Email Address";
            this.grdColEmail.FieldName = "email";
            this.grdColEmail.Name = "grdColEmail";
            this.grdColEmail.OptionsColumn.AllowEdit = false;
            this.grdColEmail.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.grdColEmail.OptionsColumn.AllowMove = false;
            this.grdColEmail.OptionsColumn.AllowShowHide = false;
            this.grdColEmail.OptionsColumn.AllowSize = false;
            this.grdColEmail.OptionsColumn.FixedWidth = true;
            this.grdColEmail.OptionsColumn.ReadOnly = true;
            this.grdColEmail.Width = 180;
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
            this.grdColIsActive.VisibleIndex = 7;
            this.grdColIsActive.Width = 70;
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
            // grdColName
            // 
            this.grdColName.Caption = "Doctor";
            this.grdColName.FieldName = "doctor";
            this.grdColName.Name = "grdColName";
            this.grdColName.Width = 141;
            // 
            // grdColtitlePK
            // 
            this.grdColtitlePK.Caption = "TitlePK";
            this.grdColtitlePK.FieldName = "titlePK";
            this.grdColtitlePK.Name = "grdColtitlePK";
            this.grdColtitlePK.Width = 152;
            // 
            // grdColSpecializePK
            // 
            this.grdColSpecializePK.Caption = "SpecializePK";
            this.grdColSpecializePK.FieldName = "specializePK";
            this.grdColSpecializePK.Name = "grdColSpecializePK";
            this.grdColSpecializePK.Width = 120;
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
            this.lbl1.Size = new System.Drawing.Size(166, 19);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Doctor Information";
            // 
            // grdColPosition
            // 
            this.grdColPosition.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grdColPosition.AppearanceHeader.Options.UseFont = true;
            this.grdColPosition.Caption = "Position";
            this.grdColPosition.FieldName = "position";
            this.grdColPosition.Name = "grdColPosition";
            this.grdColPosition.OptionsColumn.AllowEdit = false;
            this.grdColPosition.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.grdColPosition.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColPosition.OptionsColumn.AllowMove = false;
            this.grdColPosition.OptionsColumn.AllowShowHide = false;
            this.grdColPosition.OptionsColumn.AllowSize = false;
            this.grdColPosition.OptionsColumn.FixedWidth = true;
            this.grdColPosition.OptionsColumn.ReadOnly = true;
            this.grdColPosition.Visible = true;
            this.grdColPosition.VisibleIndex = 2;
            this.grdColPosition.Width = 120;
            // 
            // grdColPositionPK
            // 
            this.grdColPositionPK.Caption = "PositionPK";
            this.grdColPositionPK.FieldName = "positionPK";
            this.grdColPositionPK.Name = "grdColPositionPK";
            // 
            // grdCoSamaNo
            // 
            this.grdCoSamaNo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grdCoSamaNo.AppearanceHeader.Options.UseFont = true;
            this.grdCoSamaNo.Caption = "SAMA No.";
            this.grdCoSamaNo.FieldName = "samaNo";
            this.grdCoSamaNo.Name = "grdCoSamaNo";
            this.grdCoSamaNo.OptionsColumn.AllowEdit = false;
            this.grdCoSamaNo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.grdCoSamaNo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdCoSamaNo.OptionsColumn.AllowMove = false;
            this.grdCoSamaNo.OptionsColumn.AllowShowHide = false;
            this.grdCoSamaNo.OptionsColumn.AllowSize = false;
            this.grdCoSamaNo.OptionsColumn.FixedWidth = true;
            this.grdCoSamaNo.OptionsColumn.ReadOnly = true;
            this.grdCoSamaNo.Visible = true;
            this.grdCoSamaNo.VisibleIndex = 3;
            this.grdCoSamaNo.Width = 100;
            // 
            // frmDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1071, 722);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoctor";
            this.Text = "frmDoctor";
            this.Load += new System.EventHandler(this.frmDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBackground)).EndInit();
            this.pnlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewDoctor)).EndInit();
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

        private DevExpress.XtraEditors.PanelControl pnlBackground;
        private DevExpress.XtraGrid.GridControl grdDoctor;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewDoctor;
        private DevExpress.XtraGrid.Columns.GridColumn grdColID;
        private DevExpress.XtraGrid.Columns.GridColumn grdColFullName;
        private DevExpress.XtraGrid.Columns.GridColumn grdColSpecialize;
        private DevExpress.XtraGrid.Columns.GridColumn grdColHomePhone;
        private DevExpress.XtraGrid.Columns.GridColumn grdColMobilePhone;
        private DevExpress.XtraGrid.Columns.GridColumn grdColIsActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositorychkIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn grdColtitlePK;
        private DevExpress.XtraGrid.Columns.GridColumn grdColSpecializePK;
        private DevExpress.XtraGrid.Columns.GridColumn grdColName;
        private DevExpress.XtraEditors.PanelControl pnl2;
        private DevExpress.XtraEditors.PanelControl pnl3;
        private DevExpress.XtraEditors.SimpleButton cmdSearch;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.PanelControl pnl1;
        private System.Windows.Forms.Label lbl1;
        private DevExpress.XtraEditors.SimpleButton cmdExit;
        private DevExpress.XtraEditors.SimpleButton cmdEdit;
        private DevExpress.XtraEditors.SimpleButton cmdNew;
        private DevExpress.XtraGrid.Columns.GridColumn grdColEmail;
        private DevExpress.XtraGrid.Columns.GridColumn grdColGender;
        private DevExpress.XtraGrid.Columns.GridColumn grdColPosition;
        private DevExpress.XtraGrid.Columns.GridColumn grdColPositionPK;
        private DevExpress.XtraGrid.Columns.GridColumn grdCoSamaNo;
    }
}