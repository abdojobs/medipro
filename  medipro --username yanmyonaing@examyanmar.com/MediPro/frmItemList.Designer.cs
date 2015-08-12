namespace MediPro
{
    partial class frmItemList
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
            this.panelBG = new System.Windows.Forms.Panel();
            this.panelHeader = new DevExpress.XtraEditors.PanelControl();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelFooter = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.cmdExit = new DevExpress.XtraEditors.SimpleButton();
            this.cmdViewDetail = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNew = new DevExpress.XtraEditors.SimpleButton();
            this.cmdEdit = new DevExpress.XtraEditors.SimpleButton();
            this.dgv = new DevExpress.XtraGrid.GridControl();
            this.dgvView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositorychkIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.dgvColPK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvColName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvColType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvColCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelFooter)).BeginInit();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorychkIsActive)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBG
            // 
            this.panelBG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.panelBG.Controls.Add(this.dgv);
            this.panelBG.Controls.Add(this.panelFooter);
            this.panelBG.Controls.Add(this.panelHeader);
            this.panelBG.Location = new System.Drawing.Point(12, 12);
            this.panelBG.Name = "panelBG";
            this.panelBG.Size = new System.Drawing.Size(980, 639);
            this.panelBG.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.panelHeader.Appearance.Options.UseBackColor = true;
            this.panelHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelHeader.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(980, 55);
            this.panelHeader.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(15, 17);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(56, 19);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Items";
            // 
            // panelFooter
            // 
            this.panelFooter.Appearance.BackColor = System.Drawing.Color.OldLace;
            this.panelFooter.Appearance.Options.UseBackColor = true;
            this.panelFooter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelFooter.Controls.Add(this.panelControl3);
            this.panelFooter.Controls.Add(this.cmdExit);
            this.panelFooter.Controls.Add(this.cmdViewDetail);
            this.panelFooter.Controls.Add(this.cmdNew);
            this.panelFooter.Controls.Add(this.cmdEdit);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 575);
            this.panelFooter.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelFooter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelFooter.Margin = new System.Windows.Forms.Padding(0);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(980, 64);
            this.panelFooter.TabIndex = 2;
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
            this.cmdExit.Location = new System.Drawing.Point(868, 16);
            this.cmdExit.LookAndFeel.SkinName = "Seven Classic";
            this.cmdExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(94, 34);
            this.cmdExit.TabIndex = 0;
            this.cmdExit.Text = "Exit";
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
            this.cmdNew.Location = new System.Drawing.Point(658, 16);
            this.cmdNew.LookAndFeel.SkinName = "Seven Classic";
            this.cmdNew.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(94, 34);
            this.cmdNew.TabIndex = 0;
            this.cmdNew.Text = "New";
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
            this.cmdEdit.Location = new System.Drawing.Point(764, 16);
            this.cmdEdit.LookAndFeel.SkinName = "Seven Classic";
            this.cmdEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(94, 34);
            this.cmdEdit.TabIndex = 0;
            this.cmdEdit.Text = "Edit";
            this.cmdEdit.Visible = false;
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.dgv.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.dgv.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.dgv.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.dgv.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.dgv.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dgv.Location = new System.Drawing.Point(15, 69);
            this.dgv.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dgv.MainView = this.dgvView;
            this.dgv.Name = "dgv";
            this.dgv.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositorychkIsActive});
            this.dgv.Size = new System.Drawing.Size(947, 493);
            this.dgv.TabIndex = 3;
            this.dgv.UseEmbeddedNavigator = true;
            this.dgv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvView});
            // 
            // dgvView
            // 
            this.dgvView.Appearance.Empty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvView.Appearance.Empty.Options.UseBackColor = true;
            this.dgvView.Appearance.EvenRow.BackColor = System.Drawing.Color.OldLace;
            this.dgvView.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgvView.Appearance.FocusedCell.BackColor = System.Drawing.Color.SkyBlue;
            this.dgvView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.dgvView.Appearance.FocusedRow.BackColor = System.Drawing.Color.SkyBlue;
            this.dgvView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgvView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvView.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.SkyBlue;
            this.dgvView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgvView.Appearance.SelectedRow.BackColor = System.Drawing.Color.SkyBlue;
            this.dgvView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgvView.ColumnPanelRowHeight = 30;
            this.dgvView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.dgvColPK,
            this.dgvColCode,
            this.dgvColName,
            this.dgvColType});
            this.dgvView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.dgvView.GridControl = this.dgv;
            this.dgvView.Name = "dgvView";
            this.dgvView.OptionsView.EnableAppearanceEvenRow = true;
            this.dgvView.OptionsView.ShowDetailButtons = false;
            this.dgvView.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.dgvView.OptionsView.ShowGroupPanel = false;
            this.dgvView.OptionsView.ShowIndicator = false;
            this.dgvView.RowHeight = 25;
            this.dgvView.ViewCaptionHeight = 30;
            // 
            // repositorychkIsActive
            // 
            this.repositorychkIsActive.AutoHeight = false;
            this.repositorychkIsActive.LookAndFeel.SkinName = "VS2010";
            this.repositorychkIsActive.LookAndFeel.UseDefaultLookAndFeel = false;
            this.repositorychkIsActive.Name = "repositorychkIsActive";
            // 
            // dgvColPK
            // 
            this.dgvColPK.Caption = "PK";
            this.dgvColPK.Name = "dgvColPK";
            this.dgvColPK.Visible = true;
            this.dgvColPK.VisibleIndex = 0;
            // 
            // dgvColName
            // 
            this.dgvColName.Caption = "Name";
            this.dgvColName.Name = "dgvColName";
            this.dgvColName.Visible = true;
            this.dgvColName.VisibleIndex = 1;
            // 
            // dgvColType
            // 
            this.dgvColType.Caption = "Type";
            this.dgvColType.Name = "dgvColType";
            this.dgvColType.Visible = true;
            this.dgvColType.VisibleIndex = 2;
            // 
            // dgvColCode
            // 
            this.dgvColCode.Caption = "Code";
            this.dgvColCode.Name = "dgvColCode";
            this.dgvColCode.Visible = true;
            this.dgvColCode.VisibleIndex = 3;
            // 
            // frmItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 663);
            this.Controls.Add(this.panelBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmItemList";
            this.panelBG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelFooter)).EndInit();
            this.panelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorychkIsActive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBG;
        private DevExpress.XtraEditors.PanelControl panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private DevExpress.XtraEditors.PanelControl panelFooter;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.SimpleButton cmdExit;
        private DevExpress.XtraEditors.SimpleButton cmdViewDetail;
        private DevExpress.XtraEditors.SimpleButton cmdNew;
        private DevExpress.XtraEditors.SimpleButton cmdEdit;
        private DevExpress.XtraGrid.GridControl dgv;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvView;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositorychkIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn dgvColPK;
        private DevExpress.XtraGrid.Columns.GridColumn dgvColCode;
        private DevExpress.XtraGrid.Columns.GridColumn dgvColName;
        private DevExpress.XtraGrid.Columns.GridColumn dgvColType;
    }
}