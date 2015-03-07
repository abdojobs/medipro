using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using exaCore;
using System.Data.SqlClient;
using System.IO;

namespace Lab
{
    public partial class frmStartup : Form
    {
        clsSQL SqlDb = new clsSQL();

        public int CurTabPageIndex = 1;

        public frmStartup()
        {
            InitializeComponent();

            DefineScreen();
        }

        private void DefineScreen()
        {
            int AppScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int AppScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            this.Width = AppScreenWidth;
            this.Height = AppScreenHeight;

            this.WindowState = FormWindowState.Maximized;

            tabControlMain.Width = AppScreenWidth - 16;
            tabControlMain.Height = AppScreenHeight - 65;

            lineShape.X2 = AppScreenWidth - 35;
            lineShapeMR.X2 = AppScreenWidth - 35;

            lineDandP.Width = AppScreenWidth - 300;
            lineLandI.Width = AppScreenWidth - 300;
            lineAccess.Width = AppScreenWidth - 300;
            lineSystem.Width = AppScreenWidth - 300;

            //tabMedicalRecord.Width = AppScreenWidth - 655;
            //tabMedicalRecord.Height = AppScreenHeight - 165;

            tabMedicalRecord.SelectedTabPage = tabPageDetail;
        }

        private void frmStartup_Load(object sender, EventArgs e)
        {
            BindingBooking();
            BindingVisiting();
        }

        private void tabControlMain_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e)
        {
            bool IsView;

            switch (e.Page.Tag.ToString())
            {
                case "1":
                    IsView = SqlDb.IsViewMainMenu(tabPageHome.Tag.ToString(), AppVariable.CURRENT_USER_LEVEL_ID.ToString());
                    if (IsView == false)
                    {
                        MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true;
                    }
                    break;

                case "2":
                    IsView = SqlDb.IsViewMainMenu(tabPageMasterFile.Tag.ToString(), AppVariable.CURRENT_USER_LEVEL_ID.ToString());
                    if (IsView == false)
                    {
                        MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true;
                    }
                    break;

                case "3":
                    IsView = SqlDb.IsViewMainMenu(tabPageMedicalRecord.Tag.ToString(), AppVariable.CURRENT_USER_LEVEL_ID.ToString());
                    if (IsView == false)
                    {
                        MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true;
                    }
                    else
                    {
                        LoadLuePatient();
                    }
                    break;

                case "4":
                    IsView = SqlDb.IsViewMainMenu(tabPageReport.Tag.ToString(), AppVariable.CURRENT_USER_LEVEL_ID.ToString());
                    if (IsView == false)
                    {
                        MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true;
                    }
                    break;

                case "5":
                    IsView = SqlDb.IsViewMainMenu(tabPageAdministrator.Tag.ToString(), AppVariable.CURRENT_USER_LEVEL_ID.ToString());
                    if (IsView == false)
                    {
                        MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true;
                    }
                    break;
            }
        }

        #region MasterPage

        private void cmdUser_Click(object sender, EventArgs e)
        {
            if (SqlDb.IsAllow(cmdUser.Tag.ToString(), AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsView") == true)
            {
                AppVariable.CURRENT_SUB_MENU = cmdUser.Tag.ToString();

                //frmUser UserForm = new frmUser();
                //UserForm.Show();
                ////UserForm.TopMost = true;

                sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU), "Viewing User Info.");
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmdUserLevel_Click(object sender, EventArgs e)
        {
            if (SqlDb.IsAllow(cmdUserLevel.Tag.ToString(), AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsView") == true)
            {
                AppVariable.CURRENT_SUB_MENU = cmdUserLevel.Tag.ToString();

                //frmUserLevel UserLevelForm = new frmUserLevel();
                //UserLevelForm.Show();
                ////UserLevelForm.TopMost = true;

                sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU), "Viewing User Level Info.");
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
                
        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sysLogs.logs_logout();

            AppVariable.CURRENT_LOGIN_ID = string.Empty;
            AppVariable.CURRENT_USER_FULLNAME = string.Empty;
            AppVariable.CURRENT_USER_LEVEL_ID = 0;
            AppVariable.CURRENT_USER_PK = 0;

            Main.ActiveForm.Hide();

            frmLogin LoginForm = new frmLogin();
            LoginForm.Show();
        }

        private void linkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmChangePassword ChangePasswForm = new frmChangePassword();
            ChangePasswForm.Show();
        }
        #endregion MasterPage        

        #region Startup Page

        DataRow drTodayVisit;
        DataRow drBooking;
        int curBookingIndex;
        int curVisitedIndex;       
 
        
        private void grdViewTodayVisitPatients_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (grdViewTodayVisitPatients.RowCount > 0)
            {
                drTodayVisit = grdViewTodayVisitPatients.GetDataRow(grdViewTodayVisitPatients.FocusedRowHandle);
            }
        }

        private void grdViewTodayVisitPatients_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (grdViewTodayVisitPatients.RowCount > 0)
            {
                drTodayVisit = grdViewTodayVisitPatients.GetDataRow(grdViewTodayVisitPatients.FocusedRowHandle);
            }
        }

        private void grdViewBooking_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (grdViewBooking.RowCount > 0)
            {
                drBooking = grdViewBooking.GetDataRow(grdViewBooking.FocusedRowHandle);
                drTodayVisit = grdViewBooking.GetDataRow(grdViewBooking.FocusedRowHandle);
            }
        }

        private void grdViewBooking_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (grdViewBooking.RowCount > 0)
            {
                drBooking = grdViewBooking.GetDataRow(grdViewBooking.FocusedRowHandle);
                drTodayVisit = grdViewBooking.GetDataRow(grdViewBooking.FocusedRowHandle);
            }
        }

        private void BindingBooking()
        {
            DateTime curDate = SqlDb.ExecuteScalar<DateTime>("SELECT GETDATE()");

            DataSet dsBookging = SqlDb.GetDataSet("SELECT PK, patientName, RegNo, (tblTitle.TitleName + ' ' + tblDoctor.doctor) As doctorName, " +
                                                "abdate, tokenNo, abTime, abType, isVisited, isNew, (tblBooking.doctorPK) As doctorPK FROM tblDoctor INNER JOIN tblBooking ON tblDoctor.doctorPK = tblBooking.doctorPK INNER JOIN tblTitle " +
                                                "ON tblDoctor.titlePK = tblTitle.titlePK WHERE tblBooking.isVisited = 0 AND abdate > @abDate",
                                                new SqlParameter("@abDate", curDate.ToString("yyyy-MM-dd")));

            grdBooking.DataSource = dsBookging.Tables[0];
           
            grdViewBooking.FocusedRowHandle = curBookingIndex;
        }

        private void BindingVisiting()
        {
            DateTime curDate = SqlDb.ExecuteScalar<DateTime>("SELECT GETDATE()");

            DataSet dsVisiting = SqlDb.GetDataSet("SELECT PK, patientName, RegNo, (tblTitle.TitleName + ' ' + tblDoctor.doctor) As doctorName, " +
                                                "abdate, tokenNo, abTime, abType, isVisited, isNew, (tblBooking.doctorPK) As doctorPK, visitPK FROM tblDoctor INNER JOIN tblBooking ON tblDoctor.doctorPK = tblBooking.doctorPK INNER JOIN tblTitle " +
                                                "ON tblDoctor.titlePK = tblTitle.titlePK WHERE abdate = @abDate",
                                                new SqlParameter("@abDate", curDate.ToString("yyyy-MM-dd")));

            grdTodayVisitPatients.DataSource = dsVisiting.Tables[0];

            grdViewTodayVisitPatients.FocusedRowHandle = curVisitedIndex;
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            BindingBooking();
            BindingVisiting();
        }

        #endregion Startup Page

        #region Medical Record

        //string curVisitPatientID;

        private void cmdTodayPatients_Click(object sender, EventArgs e)
        {
            //frmVisitPatientsbyDoctor VisitPatientsbyDoctorForm = new frmVisitPatientsbyDoctor();

            //VisitPatientsbyDoctorForm.ShowDialog();

            //curVisitPatientID = VisitPatientsbyDoctorForm.selectVisitPatientPK;

            //if (curVisitPatientID.ToString().Length > 0)
            //{
            //    RegNo = curVisitPatientID;
            //    luePatient.EditValue = RegNo;
            //}
        }

        #region PatientInfo

        DataSet dsPatient;
        string RegNo = string.Empty;

        private void LoadLuePatient()
        {
            dsPatient = SqlDb.GetDataSet("SELECT RegNo, (TitleName + ' ' + Name) As Name, Convert(varchar,DOB,105) as DOB, FatherName, NRC FROM tblPatient INNER JOIN tblTitle ON tblPatient.titlePK = tblTitle.titlePK WHERE tblPatient.isDelete = 0");
            luePatient.Properties.DataSource = dsPatient.Tables[0];
        }

        private void PatientDataLoadWithRegNo()
        {
            DataSet dsCurPatient = SqlDb.GetDataSet("SELECT RegNo, Name, Convert(varchar, DOB,105) As DOBDisplay, DOB, FatherName, NRC, Gender, Photo FROM tblPatient WHERE isDelete = 0 AND RegNo=@RegNo", new SqlParameter("@RegNo", RegNo));

            txtRegNo.Text = dsCurPatient.Tables[0].Rows[0]["RegNo"].ToString();
            txtFatherName.Text = dsCurPatient.Tables[0].Rows[0]["FatherName"].ToString();
            txtDOB.Text = dsCurPatient.Tables[0].Rows[0]["DOBDisplay"].ToString();
            txtSex.Text = dsCurPatient.Tables[0].Rows[0]["Gender"].ToString();
            txtNRC.Text = dsCurPatient.Tables[0].Rows[0]["NRC"].ToString();

            string dtDOB = dsCurPatient.Tables[0].Rows[0]["DOB"].ToString();

            if (dtDOB.Length > 0)
                txtAge.Text = Helper.CalAge(DateTime.Parse(dtDOB));

            LoadImage();
            LoadVisited();
        }

        private void LoadVisited()
        {
            DataSet dsVisit = SqlDb.GetDataSet("SELECT tblVisit.visitPK, tblVisit.RegNo, tblVisit.visitDescription, tblVisit.doctorPK, (tblTitle.TitleName + ' ' + tblDoctor.doctor) As doctor, tblVisit.visitDate " +
                                               "FROM tblDoctor INNER JOIN tblVisit ON tblDoctor.doctorPK = tblVisit.doctorPK INNER JOIN tblTitle ON tblDoctor.titlePK = tblTitle.titlePK " +
                                               "WHERE tblVisit.RegNo = @RegNo", new SqlParameter("@RegNo", RegNo));
            grdVisited.DataSource = dsVisit.Tables[0];
        }

        private void luePatient_EditValueChanged(object sender, EventArgs e)
        {
            RegNo = luePatient.EditValue.ToString();

            PatientDataLoadWithRegNo();
        }

        private void LoadImage()
        {
            if (txtRegNo.Text.ToString().Length > 0)
            {
                DataSet dsPatient = SqlDb.GetDataSet("SELECT * FROM tblPatient WHERE RegNo = @RegNo", new SqlParameter("@RegNo", RegNo));
                int DataRowCnt = dsPatient.Tables[0].Rows.Count;

                if (DataRowCnt > 0)
                {
                    try
                    {
                        Byte[] bytePatientData = new Byte[0];
                        bytePatientData = (Byte[])(dsPatient.Tables[0].Rows[0]["Photo"]);
                        MemoryStream ms = new MemoryStream(bytePatientData);

                        if (ms.Length > 0)
                        {
                            picPatient.Image = Image.FromStream(ms);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        

        #region DetailPage
        #endregion Detail Page
        #endregion PatientInfo

        #region CaseInfo

        private void simpleButton8_Click(object sender, EventArgs e)
        {
           // frmCase CaseForm = new frmCase();
           //CaseForm.ShowDialog();
        }

        #endregion CaseInfo
        
        #region DailyProgress

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            //frmDailyProgress DProgressForm = new frmDailyProgress();
            //DProgressForm.ShowDialog();
        }

        #endregion DailyProgress

        #region HistoryPage

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            //frmHistory HistoryForm = new frmHistory();
            //HistoryForm.ShowDialog();
        }

        #endregion HistoryPage

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            //frmExamination ExaminationForm = new frmExamination();
            //ExaminationForm.ShowDialog();
        }

        private void cmdCategory_Click(object sender, EventArgs e)
        {
            AppVariable.CURRENT_SUB_MENU = "7";
            new frmLabCategory().ShowDialog();
        }

        private void cmdLaboratory_Click(object sender, EventArgs e)
        {
            AppVariable.CURRENT_SUB_MENU = "7";
            new frmLaboratory().ShowDialog();
        }

        private void cmdPackage_Click(object sender, EventArgs e)
        {
            AppVariable.CURRENT_SUB_MENU = "7";
            new frmLabPackage().ShowDialog();
        }

        private void cmdLabTest_Click(object sender, EventArgs e)
        {
            AppVariable.CURRENT_SUB_MENU = "7";
            new frmLabTest().ShowDialog();
        }

        private void cmdSubLabTest_Click(object sender, EventArgs e)
        {
            AppVariable.CURRENT_SUB_MENU = "7";
            new frmLabSubTest().ShowDialog();
        }

        

        

        

        
        
        #region ExaminiationPage

        #endregion

        #endregion Medical Record

    }
}
