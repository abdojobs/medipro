using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using exaCore;

namespace MediPro
{
    public partial class frmDoctor : Form
    {
        clsSQL SqlDb = new clsSQL();
        DataRow drDoctor;
        int curIndex;

        public frmDoctor()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            curIndex = grdViewDoctor.RowCount;

            if (SqlDb.IsAllow(AppVariable.CURRENT_SUB_MENU, AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsInsert") == true)
            {
                frmDoctorDetail DoctorDetailForm = new frmDoctorDetail();

                DoctorDetailForm.txtName.Text = string.Empty;
                DoctorDetailForm.txtName.Tag = string.Empty;

                DoctorDetailForm.cmdSave.Tag = "Add";
                DoctorDetailForm.ShowDialog();

                BindingDoctor();

                getCurDataRow();
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            int y = (Screen.PrimaryScreen.WorkingArea.Height - pnlBackground.Height) / 2;
            int x = (Screen.PrimaryScreen.WorkingArea.Width - pnlBackground.Width) / 2;

            pnlBackground.Location = new Point(x, y);

            BindingDoctor();

            getCurDataRow();
        }

        private void BindingDoctor()
        {
            DataSet dsDoctor = SqlDb.GetDataSet("SELECT tblDoctor.doctorPK, (tblTitle.TitleName + ' ' + tblDoctor.doctor) AS doctorName, tblSpecialize.specialize, tblPosition.position, tblDoctor.gender, tblDoctor.samaNo, " +
                                            "tblDoctor.address, tblDoctor.homePhone, tblDoctor.mobilePhone, tblDoctor.email, tblDoctor.isActive, tblDoctor.doctor, tblDoctor.titlePK, tblDoctor.specializePK, tblDoctor.positionPK " +
                                            "FROM tblDoctor JOIN tblPosition ON tblDoctor.positionPK = tblPosition.positionPK JOIN tblSpecialize ON tblDoctor.specializePK = tblSpecialize.specializePK " +
                                            "JOIN tblTitle ON tblDoctor.titlePK = tblTitle.titlePK WHERE tblPosition.isDelete = 0");
            grdDoctor.DataSource = dsDoctor.Tables[0];

            grdViewDoctor.FocusedRowHandle = curIndex;
        }

        private void grdViewDoctor_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            getCurDataRow();
        }

        private void grdViewDoctor_DoubleClick(object sender, EventArgs e)
        {
            Edit();
        }

        private void grdViewDoctor_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            getCurDataRow();
        }

        private void getCurDataRow()
        {
            if (grdViewDoctor.RowCount > 0)
            {
                drDoctor = grdViewDoctor.GetDataRow(grdViewDoctor.FocusedRowHandle);
            }
        }

        private void Edit()
        {
            if (SqlDb.IsAllow(AppVariable.CURRENT_SUB_MENU, AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsEdit") == true)
            {
                curIndex = grdViewDoctor.GetDataSourceRowIndex(grdViewDoctor.FocusedRowHandle);

                frmDoctorDetail DoctorDetailForm = new frmDoctorDetail();

                DoctorDetailForm.cmdSave.Tag = "Edit";

                DoctorDetailForm.txtName.Tag = drDoctor.ItemArray[0].ToString();
                DoctorDetailForm.txtName.Text = drDoctor.ItemArray[11].ToString();
                DoctorDetailForm.cboTitle.Tag = drDoctor.ItemArray[12].ToString();
                DoctorDetailForm.cboGender.Text = drDoctor.ItemArray[4].ToString();
                DoctorDetailForm.cboSpecialize.Tag = drDoctor.ItemArray[13].ToString();
                DoctorDetailForm.cboPosition.Tag = drDoctor.ItemArray[14].ToString();
                DoctorDetailForm.txtSAMA.Text = drDoctor.ItemArray[5].ToString();
                DoctorDetailForm.txtHomePhone.Text = drDoctor.ItemArray[7].ToString();
                DoctorDetailForm.txtMobilePhone.Text = drDoctor.ItemArray[8].ToString();
                DoctorDetailForm.chkIsActive.EditValue = bool.Parse(drDoctor.ItemArray[10].ToString());
                DoctorDetailForm.txtEmail.Text = drDoctor.ItemArray[9].ToString();
                DoctorDetailForm.txtAddress.Text = drDoctor.ItemArray[6].ToString();

                DoctorDetailForm.ShowDialog();

                sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Edit Doctor Info.");

                BindingDoctor();

                getCurDataRow();
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
