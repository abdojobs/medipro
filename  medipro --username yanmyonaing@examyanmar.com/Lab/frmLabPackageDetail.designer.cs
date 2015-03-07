namespace Lab
{
    partial class frmLabPackageDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cboLab = new System.Windows.Forms.ComboBox();
            this.cmdRemoveAll = new DevExpress.XtraEditors.SimpleButton();
            this.cmdRemove = new DevExpress.XtraEditors.SimpleButton();
            this.cmdAdd = new DevExpress.XtraEditors.SimpleButton();
            this.dgvPicked = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgvColLabPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColLabTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkIsActive = new DevExpress.XtraEditors.CheckEdit();
            this.cmdExit = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSave = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pnl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPicked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl1)).BeginInit();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.cboLab);
            this.panelControl1.Controls.Add(this.cmdRemoveAll);
            this.panelControl1.Controls.Add(this.cmdRemove);
            this.panelControl1.Controls.Add(this.cmdAdd);
            this.panelControl1.Controls.Add(this.dgvPicked);
            this.panelControl1.Controls.Add(this.dgv);
            this.panelControl1.Controls.Add(this.chkIsActive);
            this.panelControl1.Controls.Add(this.cmdExit);
            this.panelControl1.Controls.Add(this.cmdSave);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.txtName);
            this.panelControl1.Controls.Add(this.pnl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 2);
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.LookAndFeel.UseWindowsXPTheme = true;
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(867, 567);
            this.panelControl1.TabIndex = 3;
            // 
            // cboLab
            // 
            this.cboLab.FormattingEnabled = true;
            this.cboLab.Location = new System.Drawing.Point(179, 139);
            this.cboLab.Name = "cboLab";
            this.cboLab.Size = new System.Drawing.Size(654, 24);
            this.cboLab.TabIndex = 1;
            // 
            // cmdRemoveAll
            // 
            this.cmdRemoveAll.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRemoveAll.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cmdRemoveAll.Appearance.Options.UseFont = true;
            this.cmdRemoveAll.Appearance.Options.UseForeColor = true;
            this.cmdRemoveAll.Location = new System.Drawing.Point(401, 401);
            this.cmdRemoveAll.Margin = new System.Windows.Forms.Padding(4);
            this.cmdRemoveAll.Name = "cmdRemoveAll";
            this.cmdRemoveAll.Size = new System.Drawing.Size(45, 24);
            this.cmdRemoveAll.TabIndex = 5;
            this.cmdRemoveAll.Text = "<<";
            this.cmdRemoveAll.Click += new System.EventHandler(this.cmdRemoveAll_Click);
            // 
            // cmdRemove
            // 
            this.cmdRemove.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRemove.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cmdRemove.Appearance.Options.UseFont = true;
            this.cmdRemove.Appearance.Options.UseForeColor = true;
            this.cmdRemove.Location = new System.Drawing.Point(401, 369);
            this.cmdRemove.Margin = new System.Windows.Forms.Padding(4);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(45, 24);
            this.cmdRemove.TabIndex = 4;
            this.cmdRemove.Text = "<";
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdd.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cmdAdd.Appearance.Options.UseFont = true;
            this.cmdAdd.Appearance.Options.UseForeColor = true;
            this.cmdAdd.Location = new System.Drawing.Point(401, 337);
            this.cmdAdd.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(45, 24);
            this.cmdAdd.TabIndex = 3;
            this.cmdAdd.Text = ">";
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // dgvPicked
            // 
            this.dgvPicked.AllowUserToAddRows = false;
            this.dgvPicked.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPicked.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPicked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPicked.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvPicked.Location = new System.Drawing.Point(463, 248);
            this.dgvPicked.Name = "dgvPicked";
            this.dgvPicked.ReadOnly = true;
            this.dgvPicked.RowHeadersVisible = false;
            this.dgvPicked.RowTemplate.Height = 24;
            this.dgvPicked.Size = new System.Drawing.Size(370, 242);
            this.dgvPicked.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "PK";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Lab Test";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColLabPK,
            this.dgvColLabTest});
            this.dgv.Location = new System.Drawing.Point(27, 248);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(355, 242);
            this.dgv.TabIndex = 2;
            // 
            // dgvColLabPK
            // 
            this.dgvColLabPK.HeaderText = "PK";
            this.dgvColLabPK.Name = "dgvColLabPK";
            this.dgvColLabPK.ReadOnly = true;
            this.dgvColLabPK.Visible = false;
            // 
            // dgvColLabTest
            // 
            this.dgvColLabTest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvColLabTest.HeaderText = "Lab Test";
            this.dgvColLabTest.Name = "dgvColLabTest";
            this.dgvColLabTest.ReadOnly = true;
            // 
            // chkIsActive
            // 
            this.chkIsActive.EditValue = true;
            this.chkIsActive.Location = new System.Drawing.Point(461, 518);
            this.chkIsActive.Margin = new System.Windows.Forms.Padding(4);
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
            this.chkIsActive.Size = new System.Drawing.Size(100, 22);
            this.chkIsActive.TabIndex = 7;
            // 
            // cmdExit
            // 
            this.cmdExit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Appearance.ForeColor = System.Drawing.Color.Red;
            this.cmdExit.Appearance.Options.UseFont = true;
            this.cmdExit.Appearance.Options.UseForeColor = true;
            this.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdExit.Location = new System.Drawing.Point(733, 508);
            this.cmdExit.Margin = new System.Windows.Forms.Padding(4);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(100, 32);
            this.cmdExit.TabIndex = 9;
            this.cmdExit.Text = "Close";
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cmdSave.Appearance.Options.UseFont = true;
            this.cmdSave.Appearance.Options.UseForeColor = true;
            this.cmdSave.Location = new System.Drawing.Point(625, 508);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(100, 32);
            this.cmdSave.TabIndex = 8;
            this.cmdSave.Text = "Save";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(152, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(153, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(460, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Picked Lab Tests :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(24, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Laboratory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(25, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Package Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(179, 107);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(655, 23);
            this.txtName.TabIndex = 0;
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
            this.pnl1.Size = new System.Drawing.Size(866, 57);
            this.pnl1.TabIndex = 10;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(13, 18);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(190, 23);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Lab Package Detail";
            // 
            // frmLabPackageDetail
            // 
            this.AcceptButton = this.cmdSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.cmdExit;
            this.ClientSize = new System.Drawing.Size(873, 571);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLabPackageDetail";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratory Detail";
            this.Load += new System.EventHandler(this.frmLabPackageDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPicked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
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
        public System.Windows.Forms.TextBox txtName;
        private DevExpress.XtraEditors.PanelControl pnl1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColLabPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColLabTest;
        public DevExpress.XtraEditors.SimpleButton cmdRemove;
        public DevExpress.XtraEditors.SimpleButton cmdAdd;
        private System.Windows.Forms.DataGridView dgvPicked;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label3;
        public DevExpress.XtraEditors.SimpleButton cmdRemoveAll;
        private System.Windows.Forms.ComboBox cboLab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}