namespace MediPro
{
    partial class frmPatientDiagnosis
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
            this.dteRegDate = new DevExpress.XtraEditors.DateEdit();
            this.cmdExit = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSave = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbl1 = new System.Windows.Forms.Label();
            this.cboTitle = new System.Windows.Forms.ComboBox();
            this.grdDailyProgress = new DevExpress.XtraGrid.GridControl();
            this.grdViewDailyProgress = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColProgressDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteRegDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteRegDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl1)).BeginInit();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDailyProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewDailyProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.grdDailyProgress);
            this.panelControl1.Controls.Add(this.cboTitle);
            this.panelControl1.Controls.Add(this.dteRegDate);
            this.panelControl1.Controls.Add(this.cmdExit);
            this.panelControl1.Controls.Add(this.cmdSave);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.pnl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.LookAndFeel.UseWindowsXPTheme = true;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(409, 419);
            this.panelControl1.TabIndex = 3;
            // 
            // dteRegDate
            // 
            this.dteRegDate.EditValue = null;
            this.dteRegDate.Location = new System.Drawing.Point(166, 89);
            this.dteRegDate.Name = "dteRegDate";
            this.dteRegDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteRegDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dteRegDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteRegDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteRegDate.Properties.ReadOnly = true;
            this.dteRegDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteRegDate.Size = new System.Drawing.Size(200, 20);
            this.dteRegDate.TabIndex = 13;
            // 
            // cmdExit
            // 
            this.cmdExit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Appearance.ForeColor = System.Drawing.Color.Red;
            this.cmdExit.Appearance.Options.UseFont = true;
            this.cmdExit.Appearance.Options.UseForeColor = true;
            this.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdExit.Location = new System.Drawing.Point(291, 374);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 26);
            this.cmdExit.TabIndex = 4;
            this.cmdExit.Text = "Close";
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cmdSave.Appearance.Options.UseFont = true;
            this.cmdSave.Appearance.Options.UseForeColor = true;
            this.cmdSave.Location = new System.Drawing.Point(210, 374);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 26);
            this.cmdSave.TabIndex = 3;
            this.cmdSave.Text = "Save";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(148, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(148, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 14);
            this.label1.TabIndex = 12;
            this.label1.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(38, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "Progress Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(38, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "Diagnosis";
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
            this.pnl1.Size = new System.Drawing.Size(407, 46);
            this.pnl1.TabIndex = 10;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(10, 19);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(118, 18);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Daily Progress";
            // 
            // cboTitle
            // 
            this.cboTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTitle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cboTitle.FormattingEnabled = true;
            this.cboTitle.Location = new System.Drawing.Point(166, 122);
            this.cboTitle.Name = "cboTitle";
            this.cboTitle.Size = new System.Drawing.Size(200, 21);
            this.cboTitle.TabIndex = 14;
            // 
            // grdDailyProgress
            // 
            this.grdDailyProgress.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdDailyProgress.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdDailyProgress.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdDailyProgress.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdDailyProgress.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdDailyProgress.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.grdDailyProgress.Location = new System.Drawing.Point(41, 159);
            this.grdDailyProgress.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdDailyProgress.MainView = this.grdViewDailyProgress;
            this.grdDailyProgress.Name = "grdDailyProgress";
            this.grdDailyProgress.Size = new System.Drawing.Size(325, 204);
            this.grdDailyProgress.TabIndex = 15;
            this.grdDailyProgress.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewDailyProgress});
            // 
            // grdViewDailyProgress
            // 
            this.grdViewDailyProgress.Appearance.EvenRow.BackColor = System.Drawing.Color.OldLace;
            this.grdViewDailyProgress.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdViewDailyProgress.Appearance.FocusedRow.BackColor = System.Drawing.Color.Cornsilk;
            this.grdViewDailyProgress.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdViewDailyProgress.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdViewDailyProgress.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdViewDailyProgress.Appearance.SelectedRow.BackColor = System.Drawing.Color.Cornsilk;
            this.grdViewDailyProgress.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grdViewDailyProgress.ColumnPanelRowHeight = 30;
            this.grdViewDailyProgress.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColID,
            this.grdColProgressDate});
            this.grdViewDailyProgress.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdViewDailyProgress.GridControl = this.grdDailyProgress;
            this.grdViewDailyProgress.Name = "grdViewDailyProgress";
            this.grdViewDailyProgress.OptionsView.EnableAppearanceEvenRow = true;
            this.grdViewDailyProgress.OptionsView.ShowDetailButtons = false;
            this.grdViewDailyProgress.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grdViewDailyProgress.OptionsView.ShowGroupPanel = false;
            this.grdViewDailyProgress.OptionsView.ShowIndicator = false;
            this.grdViewDailyProgress.RowHeight = 25;
            this.grdViewDailyProgress.ViewCaptionHeight = 30;
            // 
            // grdColID
            // 
            this.grdColID.Caption = "CaseID";
            this.grdColID.Name = "grdColID";
            this.grdColID.OptionsColumn.AllowEdit = false;
            this.grdColID.OptionsColumn.AllowMove = false;
            this.grdColID.OptionsColumn.AllowShowHide = false;
            this.grdColID.OptionsColumn.AllowSize = false;
            this.grdColID.OptionsColumn.ReadOnly = true;
            // 
            // grdColProgressDate
            // 
            this.grdColProgressDate.AppearanceHeader.Options.UseTextOptions = true;
            this.grdColProgressDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdColProgressDate.Caption = "Diagnosis";
            this.grdColProgressDate.Name = "grdColProgressDate";
            this.grdColProgressDate.Visible = true;
            this.grdColProgressDate.VisibleIndex = 0;
            this.grdColProgressDate.Width = 171;
            // 
            // frmPatientDiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(413, 423);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPatientDiagnosis";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnosis";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteRegDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteRegDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl1)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDailyProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewDailyProgress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.DateEdit dteRegDate;
        private DevExpress.XtraEditors.SimpleButton cmdExit;
        public DevExpress.XtraEditors.SimpleButton cmdSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.PanelControl pnl1;
        private System.Windows.Forms.Label lbl1;
        public System.Windows.Forms.ComboBox cboTitle;
        private DevExpress.XtraGrid.GridControl grdDailyProgress;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewDailyProgress;
        private DevExpress.XtraGrid.Columns.GridColumn grdColID;
        private DevExpress.XtraGrid.Columns.GridColumn grdColProgressDate;
    }
}