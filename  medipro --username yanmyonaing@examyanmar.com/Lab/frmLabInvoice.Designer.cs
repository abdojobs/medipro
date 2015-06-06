namespace Lab
{
    partial class frmLabInvoice
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
            this.panelMain = new DevExpress.XtraEditors.PanelControl();
            this.cmdExit = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSave = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSavePrint = new DevExpress.XtraEditors.SimpleButton();
            this.panelSummary = new DevExpress.XtraEditors.PanelControl();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.txtNetAmount = new System.Windows.Forms.TextBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grdItems = new DevExpress.XtraGrid.GridControl();
            this.grdViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColLabTestPK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColLabTestName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueLabTest = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.grdColLabTestCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColLabTestDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColDonor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkDonor = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelTop = new DevExpress.XtraEditors.PanelControl();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lueDoctor = new DevExpress.XtraEditors.LookUpEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lueDonor = new DevExpress.XtraEditors.LookUpEdit();
            this.label20 = new System.Windows.Forms.Label();
            this.luePatient = new DevExpress.XtraEditors.LookUpEdit();
            this.label19 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSummary)).BeginInit();
            this.panelSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLabTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDonor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueDoctor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDonor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luePatient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMain.Appearance.Options.UseBackColor = true;
            this.panelMain.Controls.Add(this.cmdExit);
            this.panelMain.Controls.Add(this.cmdSave);
            this.panelMain.Controls.Add(this.cmdSavePrint);
            this.panelMain.Controls.Add(this.panelSummary);
            this.panelMain.Controls.Add(this.grdItems);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Controls.Add(this.panelControl2);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelMain.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(694, 666);
            this.panelMain.TabIndex = 0;
            // 
            // cmdExit
            // 
            this.cmdExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmdExit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Appearance.ForeColor = System.Drawing.Color.Red;
            this.cmdExit.Appearance.Options.UseFont = true;
            this.cmdExit.Appearance.Options.UseForeColor = true;
            this.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdExit.Location = new System.Drawing.Point(607, 634);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 26);
            this.cmdExit.TabIndex = 6;
            this.cmdExit.TabStop = false;
            this.cmdExit.Text = "Close";
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmdSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cmdSave.Appearance.Options.UseFont = true;
            this.cmdSave.Appearance.Options.UseForeColor = true;
            this.cmdSave.Location = new System.Drawing.Point(439, 634);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(77, 26);
            this.cmdSave.TabIndex = 4;
            this.cmdSave.Text = "Save";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdSavePrint
            // 
            this.cmdSavePrint.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmdSavePrint.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSavePrint.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cmdSavePrint.Appearance.Options.UseFont = true;
            this.cmdSavePrint.Appearance.Options.UseForeColor = true;
            this.cmdSavePrint.Location = new System.Drawing.Point(522, 634);
            this.cmdSavePrint.Name = "cmdSavePrint";
            this.cmdSavePrint.Size = new System.Drawing.Size(77, 26);
            this.cmdSavePrint.TabIndex = 5;
            this.cmdSavePrint.Text = "Save && Print";
            // 
            // panelSummary
            // 
            this.panelSummary.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panelSummary.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSummary.Appearance.Options.UseBackColor = true;
            this.panelSummary.Controls.Add(this.txtChange);
            this.panelSummary.Controls.Add(this.txtPaidAmount);
            this.panelSummary.Controls.Add(this.txtNetAmount);
            this.panelSummary.Controls.Add(this.txtDeposit);
            this.panelSummary.Controls.Add(this.label16);
            this.panelSummary.Controls.Add(this.txtDiscount);
            this.panelSummary.Controls.Add(this.txtTotalAmount);
            this.panelSummary.Controls.Add(this.label14);
            this.panelSummary.Controls.Add(this.label12);
            this.panelSummary.Controls.Add(this.label15);
            this.panelSummary.Controls.Add(this.label13);
            this.panelSummary.Controls.Add(this.label10);
            this.panelSummary.Controls.Add(this.label11);
            this.panelSummary.Controls.Add(this.label18);
            this.panelSummary.Controls.Add(this.label9);
            this.panelSummary.Controls.Add(this.label17);
            this.panelSummary.Controls.Add(this.label8);
            this.panelSummary.Controls.Add(this.label7);
            this.panelSummary.Location = new System.Drawing.Point(380, 446);
            this.panelSummary.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelSummary.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(305, 181);
            this.panelSummary.TabIndex = 3;
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(129, 138);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(167, 20);
            this.txtChange.TabIndex = 5;
            this.txtChange.Text = "0";
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtChange.KeyDown += new System.Windows.Forms.KeyEventHandler(this.controls_KeyDown);
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Location = new System.Drawing.Point(129, 112);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(167, 20);
            this.txtPaidAmount.TabIndex = 4;
            this.txtPaidAmount.Text = "0";
            this.txtPaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPaidAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.controls_KeyDown);
            this.txtPaidAmount.Validated += new System.EventHandler(this.AmountTextBoxes_Validated);
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.Location = new System.Drawing.Point(130, 86);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.Size = new System.Drawing.Size(167, 20);
            this.txtNetAmount.TabIndex = 3;
            this.txtNetAmount.Text = "0";
            this.txtNetAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNetAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.controls_KeyDown);
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(130, 60);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(167, 20);
            this.txtDeposit.TabIndex = 2;
            this.txtDeposit.Text = "0";
            this.txtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDeposit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.controls_KeyDown);
            this.txtDeposit.Validated += new System.EventHandler(this.AmountTextBoxes_Validated);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Navy;
            this.label16.Location = new System.Drawing.Point(113, 141);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(10, 14);
            this.label16.TabIndex = 30;
            this.label16.Text = ":";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(129, 34);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(167, 20);
            this.txtDiscount.TabIndex = 1;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.controls_KeyDown);
            this.txtDiscount.Validated += new System.EventHandler(this.AmountTextBoxes_Validated);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(129, 8);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(167, 20);
            this.txtTotalAmount.TabIndex = 0;
            this.txtTotalAmount.Text = "0";
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.controls_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(113, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 14);
            this.label14.TabIndex = 29;
            this.label14.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(113, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 14);
            this.label12.TabIndex = 28;
            this.label12.Text = ":";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(12, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 14);
            this.label15.TabIndex = 25;
            this.label15.Text = "Change";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(12, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 14);
            this.label13.TabIndex = 24;
            this.label13.Text = "Paid Amount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(114, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 14);
            this.label10.TabIndex = 27;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(12, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 14);
            this.label11.TabIndex = 23;
            this.label11.Text = "Net Amount";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Navy;
            this.label18.Location = new System.Drawing.Point(113, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(10, 14);
            this.label18.TabIndex = 26;
            this.label18.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(12, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 14);
            this.label9.TabIndex = 22;
            this.label9.Text = "Deposit";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Navy;
            this.label17.Location = new System.Drawing.Point(12, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 14);
            this.label17.TabIndex = 21;
            this.label17.Text = "Discount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(114, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 14);
            this.label8.TabIndex = 31;
            this.label8.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(12, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 14);
            this.label7.TabIndex = 20;
            this.label7.Text = "Total Amount";
            // 
            // grdItems
            // 
            this.grdItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grdItems.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdItems.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdItems.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdItems.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdItems.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdItems.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.grdItems.Location = new System.Drawing.Point(15, 186);
            this.grdItems.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdItems.MainView = this.grdViewItems;
            this.grdItems.Name = "grdItems";
            this.grdItems.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2,
            this.lueLabTest,
            this.chkDonor});
            this.grdItems.Size = new System.Drawing.Size(670, 254);
            this.grdItems.TabIndex = 2;
            this.grdItems.UseEmbeddedNavigator = true;
            this.grdItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewItems});
            this.grdItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdItems_KeyDown);
            // 
            // grdViewItems
            // 
            this.grdViewItems.Appearance.EvenRow.BackColor = System.Drawing.Color.OldLace;
            this.grdViewItems.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdViewItems.Appearance.FocusedRow.BackColor = System.Drawing.Color.Cornsilk;
            this.grdViewItems.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdViewItems.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdViewItems.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdViewItems.Appearance.SelectedRow.BackColor = System.Drawing.Color.Cornsilk;
            this.grdViewItems.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grdViewItems.ColumnPanelRowHeight = 30;
            this.grdViewItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColLabTestPK,
            this.grdColLabTestName,
            this.grdColLabTestCode,
            this.grdColLabTestDesc,
            this.grdColPrice,
            this.grdColDonor});
            this.grdViewItems.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdViewItems.GridControl = this.grdItems;
            this.grdViewItems.Name = "grdViewItems";
            this.grdViewItems.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.grdViewItems.OptionsBehavior.FocusLeaveOnTab = true;
            this.grdViewItems.OptionsView.EnableAppearanceEvenRow = true;
            this.grdViewItems.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grdViewItems.OptionsView.ShowDetailButtons = false;
            this.grdViewItems.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grdViewItems.OptionsView.ShowGroupPanel = false;
            this.grdViewItems.OptionsView.ShowIndicator = false;
            this.grdViewItems.RowHeight = 25;
            this.grdViewItems.ViewCaptionHeight = 30;
            this.grdViewItems.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdViewItems_CellValueChanged);
            this.grdViewItems.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.grdViewItems_RowUpdated);
            this.grdViewItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdViewItems_KeyDown);
            this.grdViewItems.KeyUp += new System.Windows.Forms.KeyEventHandler(this.grdViewItems_KeyUp);
            // 
            // grdColLabTestPK
            // 
            this.grdColLabTestPK.Caption = "Lab Test PK";
            this.grdColLabTestPK.Name = "grdColLabTestPK";
            // 
            // grdColLabTestName
            // 
            this.grdColLabTestName.Caption = "Name";
            this.grdColLabTestName.ColumnEdit = this.lueLabTest;
            this.grdColLabTestName.FieldName = "labTestPK";
            this.grdColLabTestName.Name = "grdColLabTestName";
            this.grdColLabTestName.Visible = true;
            this.grdColLabTestName.VisibleIndex = 0;
            this.grdColLabTestName.Width = 200;
            // 
            // lueLabTest
            // 
            this.lueLabTest.AutoHeight = false;
            this.lueLabTest.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueLabTest.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("labTestPK", "labTestPK", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("labTestName", "Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("labTestCode", "Code"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("labTestDescription", "Description"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("price", "price")});
            this.lueLabTest.DisplayMember = "labTestName";
            this.lueLabTest.Name = "lueLabTest";
            this.lueLabTest.NullText = "";
            this.lueLabTest.ValueMember = "labTestPK";
            // 
            // grdColLabTestCode
            // 
            this.grdColLabTestCode.Caption = "Code";
            this.grdColLabTestCode.FieldName = "labTestCode";
            this.grdColLabTestCode.Name = "grdColLabTestCode";
            this.grdColLabTestCode.OptionsColumn.AllowEdit = false;
            this.grdColLabTestCode.OptionsColumn.AllowFocus = false;
            this.grdColLabTestCode.Visible = true;
            this.grdColLabTestCode.VisibleIndex = 1;
            this.grdColLabTestCode.Width = 50;
            // 
            // grdColLabTestDesc
            // 
            this.grdColLabTestDesc.Caption = "Description";
            this.grdColLabTestDesc.FieldName = "labTestDescription";
            this.grdColLabTestDesc.Name = "grdColLabTestDesc";
            this.grdColLabTestDesc.OptionsColumn.AllowEdit = false;
            this.grdColLabTestDesc.OptionsColumn.AllowFocus = false;
            this.grdColLabTestDesc.Visible = true;
            this.grdColLabTestDesc.VisibleIndex = 2;
            this.grdColLabTestDesc.Width = 200;
            // 
            // grdColPrice
            // 
            this.grdColPrice.Caption = "Price";
            this.grdColPrice.FieldName = "price";
            this.grdColPrice.Name = "grdColPrice";
            this.grdColPrice.Visible = true;
            this.grdColPrice.VisibleIndex = 3;
            this.grdColPrice.Width = 200;
            // 
            // grdColDonor
            // 
            this.grdColDonor.Caption = "Donor";
            this.grdColDonor.ColumnEdit = this.chkDonor;
            this.grdColDonor.FieldName = "isDonor";
            this.grdColDonor.Name = "grdColDonor";
            this.grdColDonor.Visible = true;
            this.grdColDonor.VisibleIndex = 4;
            // 
            // chkDonor
            // 
            this.chkDonor.AutoHeight = false;
            this.chkDonor.Name = "chkDonor";
            this.chkDonor.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkDonor.NullText = "0";
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
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.panelTop.Appearance.Options.UseBackColor = true;
            this.panelTop.Controls.Add(this.dtpDate);
            this.panelTop.Controls.Add(this.lueDoctor);
            this.panelTop.Controls.Add(this.label6);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.label23);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.label22);
            this.panelTop.Controls.Add(this.lueDonor);
            this.panelTop.Controls.Add(this.label20);
            this.panelTop.Controls.Add(this.luePatient);
            this.panelTop.Controls.Add(this.label19);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.lblPatientName);
            this.panelTop.Location = new System.Drawing.Point(15, 60);
            this.panelTop.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelTop.LookAndFeel.UseWindowsXPTheme = true;
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(670, 123);
            this.panelTop.TabIndex = 1;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(464, 13);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(169, 20);
            this.dtpDate.TabIndex = 17;
            this.dtpDate.TabStop = false;
            // 
            // lueDoctor
            // 
            this.lueDoctor.Location = new System.Drawing.Point(127, 92);
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
            this.lueDoctor.Size = new System.Drawing.Size(219, 20);
            this.lueDoctor.TabIndex = 1;
            this.lueDoctor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.controls_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(447, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 14);
            this.label6.TabIndex = 16;
            this.label6.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(111, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 14);
            this.label2.TabIndex = 16;
            this.label2.Text = ":";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Navy;
            this.label23.Location = new System.Drawing.Point(111, 95);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(10, 14);
            this.label23.TabIndex = 16;
            this.label23.Text = ":";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(127, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 14);
            this.label4.TabIndex = 15;
            this.label4.Text = "Invoice No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(410, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 14);
            this.label5.TabIndex = 15;
            this.label5.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "Invoice No";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Navy;
            this.label22.Location = new System.Drawing.Point(10, 95);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 14);
            this.label22.TabIndex = 15;
            this.label22.Text = "Doctor";
            // 
            // lueDonor
            // 
            this.lueDonor.Location = new System.Drawing.Point(127, 66);
            this.lueDonor.Name = "lueDonor";
            this.lueDonor.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lueDonor.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lueDonor.Properties.AutoSearchColumnIndex = 1;
            this.lueDonor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDonor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RegNo", 120, "Reg No."),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 150, "Patient\'s Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FatherName", 150, "Father\'s Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DOB", 100, "DOB"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NRC", 150, "NRC / Passport")});
            this.lueDonor.Properties.DisplayMember = "Name";
            this.lueDonor.Properties.DropDownRows = 10;
            this.lueDonor.Properties.LookAndFeel.SkinName = "Metropolis";
            this.lueDonor.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lueDonor.Properties.NullText = "";
            this.lueDonor.Properties.PopupWidth = 650;
            this.lueDonor.Properties.ValueMember = "RegNo";
            this.lueDonor.Size = new System.Drawing.Size(219, 20);
            this.lueDonor.TabIndex = 0;
            this.lueDonor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.controls_KeyDown);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Navy;
            this.label20.Location = new System.Drawing.Point(111, 69);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(10, 14);
            this.label20.TabIndex = 12;
            this.label20.Text = ":";
            // 
            // luePatient
            // 
            this.luePatient.Location = new System.Drawing.Point(127, 40);
            this.luePatient.Name = "luePatient";
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
            this.luePatient.Size = new System.Drawing.Size(219, 20);
            this.luePatient.TabIndex = 0;
            this.luePatient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.controls_KeyDown);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label19.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Navy;
            this.label19.Location = new System.Drawing.Point(10, 69);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 14);
            this.label19.TabIndex = 11;
            this.label19.Text = "Donor";
            this.label19.Click += new System.EventHandler(this.lblPatientName_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(111, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = ":";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.BackColor = System.Drawing.Color.Transparent;
            this.lblPatientName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPatientName.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.ForeColor = System.Drawing.Color.Navy;
            this.lblPatientName.Location = new System.Drawing.Point(10, 43);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(89, 14);
            this.lblPatientName.TabIndex = 11;
            this.lblPatientName.Text = "Patient\'s Name";
            this.lblPatientName.Click += new System.EventHandler(this.lblPatientName_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.Silver;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.lbl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(3, 3);
            this.panelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl2.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(688, 45);
            this.panelControl2.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(9, 15);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(151, 18);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "Laboratory Invoice";
            // 
            // frmLabInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(694, 666);
            this.Controls.Add(this.panelMain);
            this.Name = "frmLabInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratory Invoice";
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).EndInit();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelSummary)).EndInit();
            this.panelSummary.ResumeLayout(false);
            this.panelSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLabTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDonor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueDoctor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDonor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luePatient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelMain;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label lbl1;
        private DevExpress.XtraEditors.PanelControl panelTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPatientName;
        private DevExpress.XtraEditors.LookUpEdit luePatient;
        public DevExpress.XtraEditors.LookUpEdit lueDoctor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private DevExpress.XtraEditors.PanelControl panelSummary;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraGrid.GridControl grdItems;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewItems;
        private DevExpress.XtraGrid.Columns.GridColumn grdColLabTestPK;
        private DevExpress.XtraGrid.Columns.GridColumn grdColLabTestName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueLabTest;
        private DevExpress.XtraGrid.Columns.GridColumn grdColLabTestCode;
        private DevExpress.XtraGrid.Columns.GridColumn grdColLabTestDesc;
        private DevExpress.XtraGrid.Columns.GridColumn grdColPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.SimpleButton cmdExit;
        public DevExpress.XtraEditors.SimpleButton cmdSave;
        public DevExpress.XtraEditors.SimpleButton cmdSavePrint;
        private DevExpress.XtraEditors.LookUpEdit lueDonor;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private DevExpress.XtraGrid.Columns.GridColumn grdColDonor;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkDonor;
    }
}