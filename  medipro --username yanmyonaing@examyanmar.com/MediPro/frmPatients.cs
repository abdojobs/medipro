using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using exaCore;

namespace MediPro
{
    public partial class frmPatients : Form
    {
        clsSQL SqlDb = new clsSQL();

        public DataRow drPatient;

        public int curIndex;
        
        public frmPatients()
        {
            InitializeComponent();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            curIndex = grdViewPatient.RowCount;

            if (SqlDb.IsAllow(AppVariable.CURRENT_SUB_MENU, AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsInsert") == true)
            {
                curIndex = grdViewPatient.RowCount;

                frmPatientDetail PatientDetailForm = new frmPatientDetail();

                PatientDetailForm.cmdSave.Tag = "Add";
                PatientDetailForm.ShowDialog();

                BindingPatient();

                if (grdViewPatient.RowCount > 0)
                {
                    drPatient = grdViewPatient.GetDataRow(grdViewPatient.FocusedRowHandle);
                }
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPatients_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            int y = (Screen.PrimaryScreen.WorkingArea.Height - pnlBackground.Height) / 2;
            int x = (Screen.PrimaryScreen.WorkingArea.Width - pnlBackground.Width) / 2;

            pnlBackground.Location = new Point(x, y);

            BindingPatient();
        }

        private void BindingPatient()
        {
            DataSet dsPatients = SqlDb.GetDataSet("SELECT tblPatient.RegNo, Concat(tblTitle.TitleName , ' ' , tblPatient.Name) AS FullName, tblPatient.NRC, tblPatient.Gender, " +
                                                    "tblPatient.FatherName, tblPatient.DOB, tblPatient.Phone, tblPatient.Address, tblPatient.email, tblPatient.RegDate, tblPatient.Name, tblPatient.titlePK, tblPatient.isDelete " +
                                                    "FROM tblPatient INNER JOIN tblTitle ON tblPatient.titlePK = tblTitle.titlePK WHERE (tblPatient.isDelete = 0)");

            grdPatient.DataSource = dsPatients.Tables[0];

            grdViewPatient.FocusedRowHandle = curIndex;
        }

        private void grdViewPatient_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (grdViewPatient.RowCount > 0)
            {
                drPatient = grdViewPatient.GetDataRow(grdViewPatient.FocusedRowHandle);
            }
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            //if (SqlDb.IsAllow(AppVariable.CURRENT_SUB_MENU, AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsEdit") == true)
            //{
            //    frmPatientDetail PatientDetailForm = new frmPatientDetail();

            //    PatientDetailForm.cmdSave.Tag = "Edit";

            //    PatientDetailForm.dteRegDate.Properties.ReadOnly = true;
            //    DateTime regDate = DateTime.Parse(drPatient.ItemArray[9].ToString());
            //    PatientDetailForm.dteRegDate.EditValue = regDate.ToShortDateString();

            //    PatientDetailForm.txtRegNo.Text = drPatient.ItemArray[0].ToString();
            //    PatientDetailForm.txtName.Text = drPatient.ItemArray[10].ToString();
            //    PatientDetailForm.cboTitle.Tag = drPatient.ItemArray[11].ToString();
            //    PatientDetailForm.txtFatherName.Text = drPatient.ItemArray[4].ToString();
            //    PatientDetailForm.txtNRC.Text = drPatient.ItemArray[2].ToString();
            //    PatientDetailForm.txtContactNo.Text = drPatient.ItemArray[7].ToString();
            //    //PatientDetailForm.txtAge.Text = Helper.CalAge(DateTime.Parse(drPatient.ItemArray[5].ToString()));

            //    DateTime dobDate = DateTime.Parse(drPatient.ItemArray[5].ToString());
            //    PatientDetailForm.dteDOB.EditValue = dobDate.ToShortDateString();                

            //    PatientDetailForm.cboGender.Text = drPatient.ItemArray[3].ToString();
            //    PatientDetailForm.txtEmail.Text = drPatient.ItemArray[8].ToString();
            //    PatientDetailForm.txtAddress.Text = drPatient.ItemArray[7].ToString();
                     
            //    PatientDetailForm.ShowDialog();

            //    sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Edit Patient Info.");

            //    BindingPatient();

            //    if (grdViewPatient.RowCount > 0)
            //    {
            //        drPatient = grdViewPatient.GetDataRow(grdViewPatient.FocusedRowHandle);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void cmdViewDetail_Click(object sender, EventArgs e)
        {
            if (SqlDb.IsAllow(AppVariable.CURRENT_SUB_MENU, AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsView") == true)
            {
                curIndex = grdViewPatient.GetDataSourceRowIndex(grdViewPatient.FocusedRowHandle);

                frmPatientDetail PatientDetailForm = new frmPatientDetail();

                PatientDetailForm.cmdSave.Tag = "View";

                PatientDetailForm.dteRegDate.Properties.ReadOnly = true;
                DateTime regDate = DateTime.Parse(drPatient.ItemArray[9].ToString());
                PatientDetailForm.dteRegDate.EditValue = regDate.ToShortDateString();

                PatientDetailForm.txtRegNo.Text = drPatient.ItemArray[0].ToString();
                PatientDetailForm.txtName.Text = drPatient.ItemArray[10].ToString();
                PatientDetailForm.cboTitle.Tag = drPatient.ItemArray[11].ToString();
                PatientDetailForm.txtFatherName.Text = drPatient.ItemArray[4].ToString();
                PatientDetailForm.txtNRC.Text = drPatient.ItemArray[2].ToString();
                PatientDetailForm.txtContactNo.Text = drPatient.ItemArray[7].ToString();
                //PatientDetailForm.txtAge.Text = Helper.CalAge(DateTime.Parse(drPatient.ItemArray[5].ToString()));

                DateTime dobDate = DateTime.Parse(drPatient.ItemArray[5].ToString());
                PatientDetailForm.dteDOB.EditValue = dobDate.ToShortDateString();

                PatientDetailForm.cboGender.Text = drPatient.ItemArray[3].ToString();
                PatientDetailForm.txtEmail.Text = drPatient.ItemArray[8].ToString();
                PatientDetailForm.txtAddress.Text = drPatient.ItemArray[7].ToString();

                PatientDetailForm.ShowDialog();

                sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Detail View Patient Info.");
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void grdViewPatient_DoubleClick(object sender, EventArgs e)
        {
            if (SqlDb.IsAllow(AppVariable.CURRENT_SUB_MENU, AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsEdit") == true)
            {
                curIndex = grdViewPatient.GetDataSourceRowIndex(grdViewPatient.FocusedRowHandle);

                frmPatientDetail PatientDetailForm = new frmPatientDetail();

                PatientDetailForm.cmdSave.Tag = "Edit";

                PatientDetailForm.dteRegDate.Properties.ReadOnly = true;
                DateTime regDate = DateTime.Parse(drPatient.ItemArray[9].ToString());
                PatientDetailForm.dteRegDate.EditValue = regDate.ToShortDateString();

                PatientDetailForm.txtRegNo.Text = drPatient.ItemArray[0].ToString();
                PatientDetailForm.txtName.Text = drPatient.ItemArray[10].ToString();
                PatientDetailForm.cboTitle.Tag = drPatient.ItemArray[11].ToString();
                PatientDetailForm.txtFatherName.Text = drPatient.ItemArray[4].ToString();
                PatientDetailForm.txtNRC.Text = drPatient.ItemArray[2].ToString();
                PatientDetailForm.txtContactNo.Text = drPatient.ItemArray[7].ToString();
                //PatientDetailForm.txtAge.Text = Helper.CalAge(DateTime.Parse(drPatient.ItemArray[5].ToString()));

                DateTime dobDate = DateTime.Parse(drPatient.ItemArray[5].ToString());
                PatientDetailForm.dteDOB.EditValue = dobDate.ToShortDateString();

                PatientDetailForm.cboGender.Text = drPatient.ItemArray[3].ToString();
                PatientDetailForm.txtEmail.Text = drPatient.ItemArray[8].ToString();
                PatientDetailForm.txtAddress.Text = drPatient.ItemArray[7].ToString();

                PatientDetailForm.ShowDialog();

                sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Edit Patient Info.");

                BindingPatient();

                if (grdViewPatient.RowCount > 0)
                {
                    drPatient = grdViewPatient.GetDataRow(grdViewPatient.FocusedRowHandle);
                }
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void grdViewPatient_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (grdViewPatient.RowCount > 0)
            {
                drPatient = grdViewPatient.GetDataRow(grdViewPatient.FocusedRowHandle);
            }
        }
    }
}
