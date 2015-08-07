namespace Lab
{
    partial class frmLabReferFee
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.panelMain = new System.Windows.Forms.Panel();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grdView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColPK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColLabTestCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueLabTest = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.grdColLabTestName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColLabTestDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColReferPercentage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColReferValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositorychkIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelH = new System.Windows.Forms.Panel();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.lueRefer = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeader = new DevExpress.XtraEditors.PanelControl();
            this.lbl1 = new System.Windows.Forms.Label();
            this.chkSameForAll = new System.Windows.Forms.CheckBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLabTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorychkIsActive)).BeginInit();
            this.panelH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueRefer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.grd);
            this.panelMain.Controls.Add(this.panelH);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(753, 547);
            this.panelMain.TabIndex = 0;
            // 
            // grd
            // 
            this.grd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grd.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grd.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grd.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grd.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grd.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grd.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            gridLevelNode1.RelationName = "Level1";
            this.grd.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grd.Location = new System.Drawing.Point(12, 160);
            this.grd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grd.MainView = this.grdView;
            this.grd.Name = "grd";
            this.grd.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositorychkIsActive,
            this.lueLabTest});
            this.grd.Size = new System.Drawing.Size(729, 375);
            this.grd.TabIndex = 3;
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
            this.grdColLabTestCode,
            this.grdColLabTestName,
            this.grdColLabTestDesc,
            this.grdColReferPercentage,
            this.grdColReferValue});
            this.grdView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdView.GridControl = this.grd;
            this.grdView.Name = "grdView";
            this.grdView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.grdView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.grdView.OptionsView.EnableAppearanceEvenRow = true;
            this.grdView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grdView.OptionsView.ShowDetailButtons = false;
            this.grdView.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grdView.OptionsView.ShowGroupPanel = false;
            this.grdView.OptionsView.ShowIndicator = false;
            this.grdView.RowHeight = 25;
            this.grdView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.grdColLabTestDesc, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.grdView.ViewCaptionHeight = 30;
            // 
            // grdColPK
            // 
            this.grdColPK.Caption = "labPK";
            this.grdColPK.FieldName = "testPK";
            this.grdColPK.Name = "grdColPK";
            this.grdColPK.OptionsColumn.AllowMove = false;
            this.grdColPK.OptionsColumn.AllowShowHide = false;
            this.grdColPK.OptionsColumn.AllowSize = false;
            this.grdColPK.OptionsColumn.ReadOnly = true;
            // 
            // grdColLabTestCode
            // 
            this.grdColLabTestCode.Caption = "Code";
            this.grdColLabTestCode.ColumnEdit = this.lueLabTest;
            this.grdColLabTestCode.FieldName = "labTestCode";
            this.grdColLabTestCode.Name = "grdColLabTestCode";
            this.grdColLabTestCode.Visible = true;
            this.grdColLabTestCode.VisibleIndex = 0;
            this.grdColLabTestCode.Width = 88;
            // 
            // lueLabTest
            // 
            this.lueLabTest.AutoHeight = false;
            this.lueLabTest.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueLabTest.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("labTestCode", "Code"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("labTestDescription", "Description")});
            this.lueLabTest.DisplayMember = "labTestCode";
            this.lueLabTest.Name = "lueLabTest";
            this.lueLabTest.NullText = "";
            this.lueLabTest.ValueMember = "labTestPK";
            // 
            // grdColLabTestName
            // 
            this.grdColLabTestName.Caption = "Name";
            this.grdColLabTestName.FieldName = "labTestName";
            this.grdColLabTestName.Name = "grdColLabTestName";
            this.grdColLabTestName.OptionsColumn.AllowEdit = false;
            this.grdColLabTestName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.grdColLabTestName.OptionsColumn.AllowMove = false;
            this.grdColLabTestName.OptionsColumn.AllowShowHide = false;
            this.grdColLabTestName.OptionsColumn.AllowSize = false;
            this.grdColLabTestName.OptionsColumn.ReadOnly = true;
            this.grdColLabTestName.Visible = true;
            this.grdColLabTestName.VisibleIndex = 1;
            this.grdColLabTestName.Width = 266;
            // 
            // grdColLabTestDesc
            // 
            this.grdColLabTestDesc.Caption = "Description";
            this.grdColLabTestDesc.FieldName = "labTestDescription";
            this.grdColLabTestDesc.Name = "grdColLabTestDesc";
            this.grdColLabTestDesc.OptionsColumn.AllowEdit = false;
            this.grdColLabTestDesc.Visible = true;
            this.grdColLabTestDesc.VisibleIndex = 2;
            this.grdColLabTestDesc.Width = 200;
            // 
            // grdColReferPercentage
            // 
            this.grdColReferPercentage.Caption = "Refer %";
            this.grdColReferPercentage.DisplayFormat.FormatString = "%";
            this.grdColReferPercentage.FieldName = "referPercent";
            this.grdColReferPercentage.Name = "grdColReferPercentage";
            this.grdColReferPercentage.Visible = true;
            this.grdColReferPercentage.VisibleIndex = 3;
            // 
            // grdColReferValue
            // 
            this.grdColReferValue.Caption = "Refer Value";
            this.grdColReferValue.FieldName = "referValue";
            this.grdColReferValue.Name = "grdColReferValue";
            this.grdColReferValue.Visible = true;
            this.grdColReferValue.VisibleIndex = 4;
            this.grdColReferValue.Width = 79;
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
            // panelH
            // 
            this.panelH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.panelH.Controls.Add(this.chkSameForAll);
            this.panelH.Controls.Add(this.lookUpEdit1);
            this.panelH.Controls.Add(this.label2);
            this.panelH.Controls.Add(this.lueRefer);
            this.panelH.Controls.Add(this.label1);
            this.panelH.Location = new System.Drawing.Point(12, 54);
            this.panelH.Name = "panelH";
            this.panelH.Size = new System.Drawing.Size(729, 100);
            this.panelH.TabIndex = 2;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(96, 37);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lookUpEdit1.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lookUpEdit1.Properties.AutoSearchColumnIndex = 1;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RegNo", 120, "Reg No."),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 150, "Patient\'s Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FatherName", 150, "Father\'s Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DOB", 100, "DOB"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NRC", 150, "NRC / Passport")});
            this.lookUpEdit1.Properties.DisplayMember = "Name";
            this.lookUpEdit1.Properties.DropDownRows = 10;
            this.lookUpEdit1.Properties.LookAndFeel.SkinName = "Metropolis";
            this.lookUpEdit1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Properties.PopupWidth = 650;
            this.lookUpEdit1.Properties.ValueMember = "RegNo";
            this.lookUpEdit1.Size = new System.Drawing.Size(219, 20);
            this.lookUpEdit1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 14);
            this.label2.TabIndex = 16;
            this.label2.Text = "Branch :";
            // 
            // lueRefer
            // 
            this.lueRefer.Location = new System.Drawing.Point(96, 11);
            this.lueRefer.Name = "lueRefer";
            this.lueRefer.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lueRefer.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lueRefer.Properties.AutoSearchColumnIndex = 1;
            this.lueRefer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueRefer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RegNo", 120, "Reg No."),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 150, "Patient\'s Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FatherName", 150, "Father\'s Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DOB", 100, "DOB"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NRC", 150, "NRC / Passport")});
            this.lueRefer.Properties.DisplayMember = "Name";
            this.lueRefer.Properties.DropDownRows = 10;
            this.lueRefer.Properties.LookAndFeel.SkinName = "Metropolis";
            this.lueRefer.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lueRefer.Properties.NullText = "";
            this.lueRefer.Properties.PopupWidth = 650;
            this.lueRefer.Properties.ValueMember = "RegNo";
            this.lueRefer.Size = new System.Drawing.Size(219, 20);
            this.lueRefer.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "Refer Name :";
            // 
            // panelHeader
            // 
            this.panelHeader.Appearance.BackColor = System.Drawing.Color.Silver;
            this.panelHeader.Appearance.Options.UseBackColor = true;
            this.panelHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelHeader.Controls.Add(this.lbl1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelHeader.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(753, 45);
            this.panelHeader.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(9, 13);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(89, 18);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "Refer Fees";
            // 
            // chkSameForAll
            // 
            this.chkSameForAll.AutoSize = true;
            this.chkSameForAll.Location = new System.Drawing.Point(644, 80);
            this.chkSameForAll.Name = "chkSameForAll";
            this.chkSameForAll.Size = new System.Drawing.Size(81, 17);
            this.chkSameForAll.TabIndex = 18;
            this.chkSameForAll.Text = "Same for all";
            this.chkSameForAll.UseVisualStyleBackColor = true;
            this.chkSameForAll.Click += new System.EventHandler(this.chkSameForAll_Click);
            // 
            // frmLabReferFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 547);
            this.Controls.Add(this.panelMain);
            this.Name = "frmLabReferFee";
            this.Text = "Labotory Refer Fee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLabTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorychkIsActive)).EndInit();
            this.panelH.ResumeLayout(false);
            this.panelH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueRefer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelH;
        private DevExpress.XtraEditors.PanelControl panelHeader;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit lueRefer;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grdView;
        private DevExpress.XtraGrid.Columns.GridColumn grdColPK;
        private DevExpress.XtraGrid.Columns.GridColumn grdColLabTestCode;
        private DevExpress.XtraGrid.Columns.GridColumn grdColLabTestName;
        private DevExpress.XtraGrid.Columns.GridColumn grdColLabTestDesc;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositorychkIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn grdColReferPercentage;
        private DevExpress.XtraGrid.Columns.GridColumn grdColReferValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueLabTest;
        private System.Windows.Forms.CheckBox chkSameForAll;


    }
}