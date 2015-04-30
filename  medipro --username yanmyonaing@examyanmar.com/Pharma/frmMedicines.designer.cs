namespace Pharma
{
    partial class frmMedicines
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
            this.grdMedicine = new DevExpress.XtraGrid.GridControl();
            this.grdViewMedicine = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMedPK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSystemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManuName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManuCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.resChkIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.grdColTitlePK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColRegDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositorychkIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.cmdExit = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNew = new DevExpress.XtraEditors.SimpleButton();
            this.cmdEdit = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBackground)).BeginInit();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resChkIsActive)).BeginInit();
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
            this.pnlBackground.Controls.Add(this.grdMedicine);
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
            // grdMedicine
            // 
            this.grdMedicine.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdMedicine.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdMedicine.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdMedicine.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdMedicine.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdMedicine.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.grdMedicine.Location = new System.Drawing.Point(15, 71);
            this.grdMedicine.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdMedicine.MainView = this.grdViewMedicine;
            this.grdMedicine.Name = "grdMedicine";
            this.grdMedicine.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositorychkIsActive,
            this.resChkIsActive});
            this.grdMedicine.Size = new System.Drawing.Size(970, 527);
            this.grdMedicine.TabIndex = 1;
            this.grdMedicine.UseEmbeddedNavigator = true;
            this.grdMedicine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewMedicine});
            // 
            // grdViewMedicine
            // 
            this.grdViewMedicine.Appearance.Empty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grdViewMedicine.Appearance.Empty.Options.UseBackColor = true;
            this.grdViewMedicine.Appearance.EvenRow.BackColor = System.Drawing.Color.OldLace;
            this.grdViewMedicine.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdViewMedicine.Appearance.FocusedCell.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewMedicine.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grdViewMedicine.Appearance.FocusedRow.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewMedicine.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdViewMedicine.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdViewMedicine.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdViewMedicine.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewMedicine.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grdViewMedicine.Appearance.SelectedRow.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewMedicine.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grdViewMedicine.ColumnPanelRowHeight = 30;
            this.grdViewMedicine.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMedPK,
            this.colMedName,
            this.colChemName,
            this.colMedType,
            this.colSystemName,
            this.colManuName,
            this.colManuCountry,
            this.colIsActive,
            this.grdColTitlePK,
            this.grdColRegDate,
            this.grdColName,
            this.grdColAddress});
            this.grdViewMedicine.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdViewMedicine.GridControl = this.grdMedicine;
            this.grdViewMedicine.Name = "grdViewMedicine";
            this.grdViewMedicine.OptionsView.EnableAppearanceEvenRow = true;
            this.grdViewMedicine.OptionsView.ShowDetailButtons = false;
            this.grdViewMedicine.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grdViewMedicine.OptionsView.ShowGroupPanel = false;
            this.grdViewMedicine.OptionsView.ShowIndicator = false;
            this.grdViewMedicine.RowHeight = 25;
            this.grdViewMedicine.ViewCaptionHeight = 30;
            this.grdViewMedicine.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdViewMedicine_RowClick);
            this.grdViewMedicine.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdViewMedicine_FocusedRowChanged);
            this.grdViewMedicine.DoubleClick += new System.EventHandler(this.grdViewPatient_DoubleClick);
            // 
            // colMedPK
            // 
            this.colMedPK.Caption = "medPK";
            this.colMedPK.FieldName = "medPK";
            this.colMedPK.Name = "colMedPK";
            this.colMedPK.OptionsColumn.AllowEdit = false;
            this.colMedPK.OptionsColumn.AllowMove = false;
            this.colMedPK.OptionsColumn.AllowShowHide = false;
            this.colMedPK.OptionsColumn.AllowSize = false;
            this.colMedPK.OptionsColumn.ReadOnly = true;
            this.colMedPK.Width = 125;
            // 
            // colMedName
            // 
            this.colMedName.Caption = "Brand Name";
            this.colMedName.FieldName = "medName";
            this.colMedName.Name = "colMedName";
            this.colMedName.OptionsColumn.AllowEdit = false;
            this.colMedName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMedName.OptionsColumn.AllowMove = false;
            this.colMedName.OptionsColumn.AllowShowHide = false;
            this.colMedName.OptionsColumn.AllowSize = false;
            this.colMedName.OptionsColumn.FixedWidth = true;
            this.colMedName.OptionsColumn.ReadOnly = true;
            this.colMedName.Visible = true;
            this.colMedName.VisibleIndex = 0;
            this.colMedName.Width = 150;
            // 
            // colChemName
            // 
            this.colChemName.Caption = "Chemical Name";
            this.colChemName.FieldName = "chemName";
            this.colChemName.Name = "colChemName";
            this.colChemName.OptionsColumn.AllowEdit = false;
            this.colChemName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colChemName.OptionsColumn.AllowMove = false;
            this.colChemName.OptionsColumn.AllowShowHide = false;
            this.colChemName.OptionsColumn.AllowSize = false;
            this.colChemName.OptionsColumn.FixedWidth = true;
            this.colChemName.OptionsColumn.ReadOnly = true;
            this.colChemName.Visible = true;
            this.colChemName.VisibleIndex = 2;
            this.colChemName.Width = 153;
            // 
            // colMedType
            // 
            this.colMedType.AppearanceHeader.Options.UseTextOptions = true;
            this.colMedType.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colMedType.Caption = "Category";
            this.colMedType.FieldName = "medTypeName";
            this.colMedType.Name = "colMedType";
            this.colMedType.OptionsColumn.AllowEdit = false;
            this.colMedType.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMedType.OptionsColumn.AllowMove = false;
            this.colMedType.OptionsColumn.AllowShowHide = false;
            this.colMedType.OptionsColumn.AllowSize = false;
            this.colMedType.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colMedType.OptionsColumn.FixedWidth = true;
            this.colMedType.OptionsColumn.ReadOnly = true;
            this.colMedType.Visible = true;
            this.colMedType.VisibleIndex = 1;
            this.colMedType.Width = 130;
            // 
            // colSystemName
            // 
            this.colSystemName.Caption = "Body System";
            this.colSystemName.FieldName = "systemName";
            this.colSystemName.Name = "colSystemName";
            this.colSystemName.OptionsColumn.AllowFocus = false;
            this.colSystemName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colSystemName.OptionsColumn.AllowMove = false;
            this.colSystemName.OptionsColumn.AllowShowHide = false;
            this.colSystemName.OptionsColumn.AllowSize = false;
            this.colSystemName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSystemName.OptionsColumn.FixedWidth = true;
            this.colSystemName.OptionsColumn.ReadOnly = true;
            this.colSystemName.Visible = true;
            this.colSystemName.VisibleIndex = 3;
            this.colSystemName.Width = 118;
            // 
            // colManuName
            // 
            this.colManuName.Caption = "Manufacturer";
            this.colManuName.FieldName = "manuName";
            this.colManuName.Name = "colManuName";
            this.colManuName.OptionsColumn.AllowFocus = false;
            this.colManuName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colManuName.OptionsColumn.AllowMove = false;
            this.colManuName.OptionsColumn.AllowShowHide = false;
            this.colManuName.OptionsColumn.AllowSize = false;
            this.colManuName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colManuName.OptionsColumn.FixedWidth = true;
            this.colManuName.OptionsColumn.ReadOnly = true;
            this.colManuName.Visible = true;
            this.colManuName.VisibleIndex = 4;
            this.colManuName.Width = 150;
            // 
            // colManuCountry
            // 
            this.colManuCountry.Caption = "Country";
            this.colManuCountry.FieldName = "manuCountry";
            this.colManuCountry.Name = "colManuCountry";
            this.colManuCountry.OptionsColumn.AllowFocus = false;
            this.colManuCountry.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colManuCountry.OptionsColumn.AllowMove = false;
            this.colManuCountry.OptionsColumn.AllowShowHide = false;
            this.colManuCountry.OptionsColumn.AllowSize = false;
            this.colManuCountry.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colManuCountry.OptionsColumn.FixedWidth = true;
            this.colManuCountry.OptionsColumn.ReadOnly = true;
            this.colManuCountry.Visible = true;
            this.colManuCountry.VisibleIndex = 5;
            this.colManuCountry.Width = 150;
            // 
            // colIsActive
            // 
            this.colIsActive.Caption = "Is Active";
            this.colIsActive.ColumnEdit = this.resChkIsActive;
            this.colIsActive.FieldName = "isActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.OptionsColumn.AllowEdit = false;
            this.colIsActive.OptionsColumn.AllowMove = false;
            this.colIsActive.OptionsColumn.AllowShowHide = false;
            this.colIsActive.OptionsColumn.AllowSize = false;
            this.colIsActive.OptionsColumn.ReadOnly = true;
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 6;
            this.colIsActive.Width = 100;
            // 
            // resChkIsActive
            // 
            this.resChkIsActive.AutoHeight = false;
            this.resChkIsActive.Caption = "";
            this.resChkIsActive.Name = "resChkIsActive";
            this.resChkIsActive.ReadOnly = true;
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
            this.panelControl2.Controls.Add(this.btnDelete);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.cmdExit);
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
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Appearance.Options.UseForeColor = true;
            this.btnDelete.Location = new System.Drawing.Point(783, 16);
            this.btnDelete.LookAndFeel.SkinName = "Seven Classic";
            this.btnDelete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 34);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.simpleButton3.Image = global::Pharma.Properties.Resources.search;
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
            // cmdNew
            // 
            this.cmdNew.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdNew.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.cmdNew.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNew.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cmdNew.Appearance.Options.UseBackColor = true;
            this.cmdNew.Appearance.Options.UseFont = true;
            this.cmdNew.Appearance.Options.UseForeColor = true;
            this.cmdNew.Location = new System.Drawing.Point(583, 16);
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
            this.cmdEdit.Location = new System.Drawing.Point(683, 16);
            this.cmdEdit.LookAndFeel.SkinName = "Seven Classic";
            this.cmdEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(94, 34);
            this.cmdEdit.TabIndex = 0;
            this.cmdEdit.Text = "Edit";
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
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicines";
            // 
            // frmMedicines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 713);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMedicines";
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.frmMedicines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBackground)).EndInit();
            this.pnlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resChkIsActive)).EndInit();
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
        private DevExpress.XtraGrid.GridControl grdMedicine;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewMedicine;
        private DevExpress.XtraGrid.Columns.GridColumn colMedPK;
        private DevExpress.XtraGrid.Columns.GridColumn colMedName;
        private DevExpress.XtraGrid.Columns.GridColumn colChemName;
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
        private DevExpress.XtraGrid.Columns.GridColumn colMedType;
        private DevExpress.XtraGrid.Columns.GridColumn colSystemName;
        private DevExpress.XtraGrid.Columns.GridColumn colManuName;
        private DevExpress.XtraGrid.Columns.GridColumn colManuCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn grdColTitlePK;
        private DevExpress.XtraGrid.Columns.GridColumn grdColRegDate;
        private DevExpress.XtraGrid.Columns.GridColumn grdColName;
        private DevExpress.XtraGrid.Columns.GridColumn grdColAddress;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit resChkIsActive;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
    }
}