namespace MediPro
{
    partial class frmUserRoleDetail
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
            this.gridRole = new DevExpress.XtraGrid.GridControl();
            this.grdViewRole = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPolicyPK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPolicy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsAllow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.resChkIsAllow = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.resLookup = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.resLookupFromUnit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.resLookup2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.resTxtFromValue = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.resLookupToUnit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.resSpinFromValue = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.resSpinToValue = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.chkIsActive = new DevExpress.XtraEditors.CheckEdit();
            this.cmdExit = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSave = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.pnl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resChkIsAllow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resLookup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resLookupFromUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resLookup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resTxtFromValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resLookupToUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resSpinFromValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resSpinToValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl1)).BeginInit();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.gridRole);
            this.panelControl1.Controls.Add(this.chkIsActive);
            this.panelControl1.Controls.Add(this.cmdExit);
            this.panelControl1.Controls.Add(this.cmdSave);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.txtRoleName);
            this.panelControl1.Controls.Add(this.pnl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.LookAndFeel.UseWindowsXPTheme = true;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(633, 560);
            this.panelControl1.TabIndex = 3;
            // 
            // gridRole
            // 
            this.gridRole.Location = new System.Drawing.Point(26, 153);
            this.gridRole.MainView = this.grdViewRole;
            this.gridRole.Name = "gridRole";
            this.gridRole.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.resLookup,
            this.resLookupFromUnit,
            this.resLookup2,
            this.resTxtFromValue,
            this.repositoryItemLookUpEdit1,
            this.resLookupToUnit,
            this.resSpinFromValue,
            this.resSpinToValue,
            this.repositoryItemTextEdit1,
            this.resChkIsAllow});
            this.gridRole.Size = new System.Drawing.Size(580, 338);
            this.gridRole.TabIndex = 13;
            this.gridRole.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewRole});
            // 
            // grdViewRole
            // 
            this.grdViewRole.Appearance.EvenRow.BackColor = System.Drawing.Color.OldLace;
            this.grdViewRole.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdViewRole.Appearance.FocusedRow.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewRole.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdViewRole.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grdViewRole.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdViewRole.Appearance.SelectedRow.BackColor = System.Drawing.Color.SkyBlue;
            this.grdViewRole.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grdViewRole.ColumnPanelRowHeight = 30;
            this.grdViewRole.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPolicyPK,
            this.colPolicy,
            this.colIsAllow});
            this.grdViewRole.GridControl = this.gridRole;
            this.grdViewRole.Name = "grdViewRole";
            this.grdViewRole.OptionsView.EnableAppearanceEvenRow = true;
            this.grdViewRole.OptionsView.ShowDetailButtons = false;
            this.grdViewRole.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grdViewRole.OptionsView.ShowGroupPanel = false;
            this.grdViewRole.OptionsView.ShowIndicator = false;
            this.grdViewRole.RowHeight = 25;
            this.grdViewRole.ViewCaptionHeight = 30;
            this.grdViewRole.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colPolicyPK
            // 
            this.colPolicyPK.Caption = "PolicyPK";
            this.colPolicyPK.FieldName = "policyPK";
            this.colPolicyPK.Name = "colPolicyPK";
            this.colPolicyPK.OptionsColumn.AllowEdit = false;
            this.colPolicyPK.OptionsColumn.AllowFocus = false;
            this.colPolicyPK.OptionsFilter.AllowFilter = false;
            this.colPolicyPK.Width = 20;
            // 
            // colPolicy
            // 
            this.colPolicy.Caption = "Policy";
            this.colPolicy.FieldName = "policyText";
            this.colPolicy.Name = "colPolicy";
            this.colPolicy.OptionsColumn.AllowEdit = false;
            this.colPolicy.OptionsColumn.AllowFocus = false;
            this.colPolicy.OptionsFilter.AllowFilter = false;
            this.colPolicy.Visible = true;
            this.colPolicy.VisibleIndex = 0;
            this.colPolicy.Width = 350;
            // 
            // colIsAllow
            // 
            this.colIsAllow.AppearanceCell.Options.UseTextOptions = true;
            this.colIsAllow.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsAllow.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colIsAllow.Caption = "Is Allow";
            this.colIsAllow.ColumnEdit = this.resChkIsAllow;
            this.colIsAllow.FieldName = "isAllowed";
            this.colIsAllow.MaxWidth = 60;
            this.colIsAllow.Name = "colIsAllow";
            this.colIsAllow.OptionsColumn.AllowMove = false;
            this.colIsAllow.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsAllow.OptionsFilter.AllowAutoFilter = false;
            this.colIsAllow.OptionsFilter.AllowFilter = false;
            this.colIsAllow.Visible = true;
            this.colIsAllow.VisibleIndex = 1;
            this.colIsAllow.Width = 50;
            // 
            // resChkIsAllow
            // 
            this.resChkIsAllow.AutoHeight = false;
            this.resChkIsAllow.Name = "resChkIsAllow";
            // 
            // resLookup
            // 
            this.resLookup.AutoHeight = false;
            this.resLookup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.resLookup.DisplayMember = "titlePK";
            this.resLookup.Name = "resLookup";
            this.resLookup.ValueMember = "titlePK";
            this.resLookup.View = this.gridView2;
            this.resLookup.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // resLookupFromUnit
            // 
            this.resLookupFromUnit.AutoHeight = false;
            this.resLookupFromUnit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.resLookupFromUnit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("medUnitName", "Unit")});
            this.resLookupFromUnit.DisplayMember = "medUnitName";
            this.resLookupFromUnit.Name = "resLookupFromUnit";
            this.resLookupFromUnit.NullText = "";
            this.resLookupFromUnit.ValueMember = "medUnitPK";
            // 
            // resLookup2
            // 
            this.resLookup2.AutoHeight = false;
            this.resLookup2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.resLookup2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("titleName", "titleName")});
            this.resLookup2.DisplayMember = "TitleName";
            this.resLookup2.Name = "resLookup2";
            this.resLookup2.ValueMember = "TitlePK";
            // 
            // resTxtFromValue
            // 
            this.resTxtFromValue.AutoHeight = false;
            this.resTxtFromValue.Name = "resTxtFromValue";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // resLookupToUnit
            // 
            this.resLookupToUnit.AutoHeight = false;
            this.resLookupToUnit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.resLookupToUnit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("medUnitName", "Unit")});
            this.resLookupToUnit.DisplayMember = "medUnitName";
            this.resLookupToUnit.Name = "resLookupToUnit";
            this.resLookupToUnit.NullText = "";
            this.resLookupToUnit.ValueMember = "medUnitPK";
            // 
            // resSpinFromValue
            // 
            this.resSpinFromValue.AutoHeight = false;
            this.resSpinFromValue.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.resSpinFromValue.Name = "resSpinFromValue";
            this.resSpinFromValue.NullText = "1";
            // 
            // resSpinToValue
            // 
            this.resSpinToValue.AutoHeight = false;
            this.resSpinToValue.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.resSpinToValue.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.resSpinToValue.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.resSpinToValue.Name = "resSpinToValue";
            this.resSpinToValue.NullText = "1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemTextEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemTextEdit1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.NullText = "=";
            // 
            // chkIsActive
            // 
            this.chkIsActive.EditValue = true;
            this.chkIsActive.Location = new System.Drawing.Point(139, 119);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkIsActive.Properties.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.chkIsActive.Properties.Appearance.Options.UseFont = true;
            this.chkIsActive.Properties.Appearance.Options.UseForeColor = true;
            this.chkIsActive.Properties.Caption = " Is Active";
            this.chkIsActive.Properties.DisplayValueChecked = "true";
            this.chkIsActive.Properties.DisplayValueUnchecked = "false";
            this.chkIsActive.Properties.LookAndFeel.SkinName = "VS2010";
            this.chkIsActive.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.chkIsActive.Size = new System.Drawing.Size(75, 19);
            this.chkIsActive.TabIndex = 1;
            // 
            // cmdExit
            // 
            this.cmdExit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Appearance.ForeColor = System.Drawing.Color.Red;
            this.cmdExit.Appearance.Options.UseFont = true;
            this.cmdExit.Appearance.Options.UseForeColor = true;
            this.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdExit.Location = new System.Drawing.Point(531, 515);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 26);
            this.cmdExit.TabIndex = 3;
            this.cmdExit.Text = "Close";
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cmdSave.Appearance.Options.UseFont = true;
            this.cmdSave.Appearance.Options.UseForeColor = true;
            this.cmdSave.Location = new System.Drawing.Point(445, 515);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 26);
            this.cmdSave.TabIndex = 2;
            this.cmdSave.Text = "Save";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(125, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 14);
            this.label1.TabIndex = 12;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(27, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "Role Name";
            // 
            // txtRoleName
            // 
            this.txtRoleName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoleName.Location = new System.Drawing.Point(141, 93);
            this.txtRoleName.MaxLength = 200;
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(258, 20);
            this.txtRoleName.TabIndex = 0;
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
            this.pnl1.Size = new System.Drawing.Size(632, 46);
            this.pnl1.TabIndex = 10;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(10, 19);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(130, 18);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "User Role Detail";
            // 
            // frmUserRoleDetail
            // 
            this.AcceptButton = this.cmdSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.cmdExit;
            this.ClientSize = new System.Drawing.Size(637, 564);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmUserRoleDetail";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnosis Detail";
            this.Load += new System.EventHandler(this.frmUserRoleDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resChkIsAllow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resLookup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resLookupFromUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resLookup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resTxtFromValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resLookupToUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resSpinFromValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resSpinToValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl1)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.CheckEdit chkIsActive;
        private DevExpress.XtraEditors.SimpleButton cmdExit;
        public DevExpress.XtraEditors.SimpleButton cmdSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtRoleName;
        private DevExpress.XtraEditors.PanelControl pnl1;
        private System.Windows.Forms.Label lbl1;
        private DevExpress.XtraGrid.GridControl gridRole;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewRole;
        private DevExpress.XtraGrid.Columns.GridColumn colPolicyPK;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit resLookupFromUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colPolicy;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit resLookup2;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit resLookup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit resTxtFromValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit resLookupToUnit;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit resSpinFromValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit resSpinToValue;
        private DevExpress.XtraGrid.Columns.GridColumn colIsAllow;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit resChkIsAllow;
    }
}