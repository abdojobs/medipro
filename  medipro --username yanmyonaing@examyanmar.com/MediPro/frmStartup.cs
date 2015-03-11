using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using exaCore;

namespace MediPro
{
    public partial class frmStartup : Form
    {
        clsSQL SqlDb = new clsSQL();
        string strSelectedVisit = string.Empty;

        public int CurTabPageIndex = 1;

        public frmStartup()
        {
            InitializeComponent();
            resLueLabTest.DataSource = SqlDb.GetDataSet("select * from tblLabTest").Tables[0];
            grdLab.DataSource = SqlDb.GetDataSet("select * from tblLabTestRequest").Tables[0];
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
            //lineLandI.Width = AppScreenWidth - 300;
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

        private void cmdTitleSetup_Click(object sender, EventArgs e)
        {
            if (SqlDb.IsAllow(cmdTitleSetup.Tag.ToString(), AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsView") == true)
            {
                AppVariable.CURRENT_SUB_MENU = cmdTitleSetup.Tag.ToString();

                frmTitleSetup TitleSetupForm = new frmTitleSetup();
                TitleSetupForm.ShowDialog();
                //TitleSetupForm.TopMost = true;

                sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU), "Viewing");
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmdUser_Click(object sender, EventArgs e)
        {
            if (SqlDb.IsAllow(cmdUser.Tag.ToString(), AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsView") == true)
            {
                AppVariable.CURRENT_SUB_MENU = cmdUser.Tag.ToString();

                frmUser UserForm = new frmUser();
                UserForm.Show();
                //UserForm.TopMost = true;

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

                frmUserLevel UserLevelForm = new frmUserLevel();
                UserLevelForm.Show();
                //UserLevelForm.TopMost = true;

                sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU), "Viewing User Level Info.");
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void cmdPatients_Click(object sender, EventArgs e)
        {
            if (SqlDb.IsAllow(cmdPatients.Tag.ToString(), AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsView") == true)
            {
                AppVariable.CURRENT_SUB_MENU = cmdPatients.Tag.ToString();

                frmPatients PatientForm = new frmPatients();
                PatientForm.ShowDialog();
                //PatientForm.TopMost = true;

                sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU), "Viewing Patients Info");
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmdDoctors_Click(object sender, EventArgs e)
        {
            if (SqlDb.IsAllow(cmdDoctors.Tag.ToString(), AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsView") == true)
            {
                AppVariable.CURRENT_SUB_MENU = cmdDoctors.Tag.ToString();

                frmDoctor DoctorForm = new frmDoctor();
                DoctorForm.ShowDialog();
                //DoctorForm.TopMost = true;

                sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU), "Viewing Doctor Info");
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmdSpecializeSetup_Click(object sender, EventArgs e)
        {
            if (SqlDb.IsAllow(cmdSpecializeSetup.Tag.ToString(), AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsView") == true)
            {
                AppVariable.CURRENT_SUB_MENU = cmdTitleSetup.Tag.ToString();

                frmSpecialize SpecilizeSetupForm = new frmSpecialize();
                                
                SpecilizeSetupForm.ShowDialog();
                //SpecilizeSetupForm.TopMost = true;

                sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU), "Viewing");
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmdCameraSetup_Click(object sender, EventArgs e)
        {
            if (SqlDb.IsAllow(cmdCameraSetup.Tag.ToString(), AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsView") == true)
            {
                AppVariable.CURRENT_SUB_MENU = cmdCameraSetup.Tag.ToString();

                frmCameraSetup CamersSetupForm = new frmCameraSetup();

                CamersSetupForm.ShowDialog();
                //CamersSetupForm.TopMost = true;

                sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU), "Viewing");
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmdPosition_Click(object sender, EventArgs e)
        {
            if (SqlDb.IsAllow(cmdPosition.Tag.ToString(), AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsView") == true)
            {
                AppVariable.CURRENT_SUB_MENU = cmdPosition.Tag.ToString();

                frmPositions PositionSetupForm = new frmPositions();

                PositionSetupForm.ShowDialog();
                //PositionSetupForm.TopMost = true;

                sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU), "Viewing");
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

        //private void cmdLabSetup_Click(object sender, EventArgs e)
        //{
        //    if (SqlDb.IsAllow(cmdLabSetup.Tag.ToString(), AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsView") == true)
        //    {
        //        AppVariable.CURRENT_SUB_MENU = cmdLabSetup.Tag.ToString();

        //        frmLaboratory LabSetupForm = new frmLaboratory();

        //        LabSetupForm.ShowDialog();
        //        //LabSetupForm.TopMost = true;

        //        sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU), "Viewing");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

        private void linkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmChangePassword ChangePasswForm = new frmChangePassword();
            ChangePasswForm.Show();
        }

        private void cmdDiagnosis_Click(object sender, EventArgs e)
        {
            if (SqlDb.IsAllow(cmdDiagnosis.Tag.ToString(), AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsView") == true)
            {
                AppVariable.CURRENT_SUB_MENU = cmdDiagnosis.Tag.ToString();

                frmDiagnosis DiagnosisSetupForm = new frmDiagnosis();

                DiagnosisSetupForm.ShowDialog();
                //DiagnosisSetupForm.TopMost = true;

                sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU), "Viewing");
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmdFrequency_Click(object sender, EventArgs e)
        {
            if (SqlDb.IsAllow(cmdFrequency.Tag.ToString(), AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsView") == true)
            {
                AppVariable.CURRENT_SUB_MENU = cmdFrequency.Tag.ToString();

                frmFrequency FrequencySetupForm = new frmFrequency();

                FrequencySetupForm.ShowDialog();
                //FrequencySetupForm.TopMost = true;

                sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU), "Viewing");
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmdClinicTime_Click(object sender, EventArgs e)
        {
            if (SqlDb.IsAllow(cmdClinicTime.Tag.ToString(), AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsView") == true)
            {
                AppVariable.CURRENT_SUB_MENU = cmdClinicTime.Tag.ToString();

                frmClinicTimeByDoctor ClinicTimeForm = new frmClinicTimeByDoctor();

                ClinicTimeForm.Show();
                //FrequencySetupForm.TopMost = true;

                sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU), "Viewing");
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion MasterPage        

        #region Startup Page

        DataRow drTodayVisit;
        DataRow drBooking;
        int curBookingIndex;
        int curVisitedIndex;       
 
        private void cmdNewVisit_Click(object sender, EventArgs e)
        {
            curVisitedIndex = grdViewTodayVisitPatients.GetDataSourceRowIndex(grdViewTodayVisitPatients.FocusedRowHandle);

            if (SqlDb.IsAllow(cmdNewVisit.Tag.ToString(), AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsView") == true)
            {
                if (grdViewTodayVisitPatients.RowCount > 0)
                {
                    if (drTodayVisit.ItemArray[9].ToString() == "True")
                    {
                        AppVariable.CURRENT_SUB_MENU = cmdNewVisit.Tag.ToString();

                        frmNewVisitDetail NewVisitForm = new frmNewVisitDetail();
                        NewVisitForm.cmdSave.Tag = drTodayVisit.ItemArray[0].ToString();
                        NewVisitForm.luePatient.EditValue = drTodayVisit.ItemArray[2].ToString();
                        NewVisitForm.lueDoctor.EditValue = drTodayVisit.ItemArray[10].ToString();
                        NewVisitForm.dteVisitDate.Tag = (drTodayVisit.ItemArray[11].ToString() == string.Empty) ? "Add" : drTodayVisit.ItemArray[11].ToString();
                        NewVisitForm.ShowDialog();

                        sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU), "Viewing");

                        BindingVisiting();

                        if (grdViewTodayVisitPatients.RowCount > 0)
                        {
                            drTodayVisit = grdViewTodayVisitPatients.GetDataRow(grdViewTodayVisitPatients.FocusedRowHandle);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sorry, your patient was not registered.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void grdViewTodayVisitPatients_DoubleClick(object sender, EventArgs e)
        {
            curVisitedIndex = grdViewTodayVisitPatients.GetDataSourceRowIndex(grdViewTodayVisitPatients.FocusedRowHandle);

            if (SqlDb.IsAllow(cmdNewVisit.Tag.ToString(), AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsEdit") == true)
            {
                if (grdViewTodayVisitPatients.RowCount > 0)
                {
                    if (drTodayVisit.ItemArray[9].ToString() == "True")
                    {
                        AppVariable.CURRENT_SUB_MENU = cmdNewVisit.Tag.ToString();

                        frmNewVisitDetail NewVisitForm = new frmNewVisitDetail();
                        NewVisitForm.cmdSave.Tag = drTodayVisit.ItemArray[0].ToString();
                        NewVisitForm.luePatient.EditValue = drTodayVisit.ItemArray[2].ToString();
                        NewVisitForm.lueDoctor.EditValue = drTodayVisit.ItemArray[10].ToString();
                        NewVisitForm.dteVisitDate.Tag = (drTodayVisit.ItemArray[11].ToString() == string.Empty) ? "Add" : drTodayVisit.ItemArray[11].ToString();
                        NewVisitForm.ShowDialog();

                        sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU), "Viewing");

                        BindingVisiting();

                        if (grdViewTodayVisitPatients.RowCount > 0)
                        {
                            drTodayVisit = grdViewTodayVisitPatients.GetDataRow(grdViewTodayVisitPatients.FocusedRowHandle);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sorry, your patient was not registered.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmdBooking_Click(object sender, EventArgs e)
        {
            curBookingIndex = grdViewBooking.RowCount;

            if (SqlDb.IsAllow(cmdBooking.Tag.ToString(), AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsView") == true)
            {
                AppVariable.CURRENT_SUB_MENU = cmdBooking.Tag.ToString();
                
                frmBooking BookingForm = new frmBooking();

                //BookingForm.cmdSave.Tag = "New";
                BookingForm.ShowDialog();
                sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU), "Viewing");

                BindingBooking();

                if (grdViewBooking.RowCount > 0)
                {
                    drBooking = grdViewBooking.GetDataRow(grdViewBooking.FocusedRowHandle);
                }
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmdPatientRegister_Click(object sender, EventArgs e)
        {
            curVisitedIndex = grdViewTodayVisitPatients.GetDataSourceRowIndex(grdViewTodayVisitPatients.FocusedRowHandle);

            if (SqlDb.IsAllow(cmdPatients.Tag.ToString(), AppVariable.CURRENT_USER_LEVEL_ID.ToString(), "IsInsert") == true)
            {
                AppVariable.CURRENT_SUB_MENU = cmdPatients.Tag.ToString();

                frmPatientDetail PatientDetailForm = new frmPatientDetail();

                if (drTodayVisit.ItemArray[9].ToString() == "False")
                {
                    if (grdViewTodayVisitPatients.RowCount > 0)
                    {
                        PatientDetailForm.cmdSave.Tag = "Booked";
                        PatientDetailForm.txtName.Text = drTodayVisit.ItemArray[1].ToString();
                        PatientDetailForm.txtName.Tag = drTodayVisit.ItemArray[0].ToString();
                    }
                }
                else
                {
                    PatientDetailForm.cmdSave.Tag = "Add";
                }

                PatientDetailForm.ShowDialog();

                BindingVisiting();

                if (grdViewTodayVisitPatients.RowCount > 0)
                {
                    drTodayVisit = grdViewTodayVisitPatients.GetDataRow(grdViewTodayVisitPatients.FocusedRowHandle);
                }
            }
            else
            {
                MessageBox.Show("Sorry, Administrator is not allow this action?", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

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

        string curVisitPatientID;

        private void cmdTodayPatients_Click(object sender, EventArgs e)
        {
            frmVisitPatientsbyDoctor VisitPatientsbyDoctorForm = new frmVisitPatientsbyDoctor();

            VisitPatientsbyDoctorForm.ShowDialog();

            curVisitPatientID = VisitPatientsbyDoctorForm.selectVisitPatientPK;

            if (curVisitPatientID.ToString().Length > 0)
            {
                RegNo = curVisitPatientID;
                luePatient.EditValue = RegNo;
            }
        }

        #region PatientInfo

        DataSet dsPatient;
        string RegNo = string.Empty;
        string strSelectedVisitPK = string.Empty;

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
            DataSet dsVisit = SqlDb.GetDataSet("SELECT tblVisit.visitPK, tblVisit.RegNo, tblVisit.visitDescription, tblVisit.doctorPK, (tblTitle.TitleName + ' ' + tblDoctor.doctor) As doctor, Convert(varchar, tblVisit.visitDate,105) As visitDate " +
                                               "FROM tblDoctor INNER JOIN tblVisit ON tblDoctor.doctorPK = tblVisit.doctorPK INNER JOIN tblTitle ON tblDoctor.titlePK = tblTitle.titlePK " +
                                               "WHERE tblVisit.RegNo = @RegNo", new SqlParameter("@RegNo", RegNo));
            lueVisit.Properties.DataSource = dsVisit.Tables[0];
        }

        private void lueVisit_EditValueChanged(object sender, EventArgs e)
        {
            strSelectedVisitPK = lueVisit.EditValue.ToString();

            LoadVisitDetail(strSelectedVisitPK);
        }

        private void LoadVisitDetail(string visitPK)
        {
            DataSet dsCurVisit = SqlDb.GetDataSet("SELECT tblVisit.visitDescription, tblVisit.doctorPK, (tblTitle.TitleName + ' ' + tblDoctor.doctor) As doctor, tblVisit.visitDate " +
                                               "FROM tblDoctor INNER JOIN tblVisit ON tblDoctor.doctorPK = tblVisit.doctorPK INNER JOIN tblTitle ON tblDoctor.titlePK = tblTitle.titlePK " +
                                               "WHERE tblVisit.RegNo = @RegNo AND tblVisit.visitPK = @VisitPK", new SqlParameter("@RegNo", RegNo), new SqlParameter("@VisitPK", visitPK));

            txtVisitDesc.Text = dsCurVisit.Tables[0].Rows[0]["visitDescription"].ToString();
            txtVisitDoctor.Text = dsCurVisit.Tables[0].Rows[0]["doctor"].ToString();
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

        
        #region Medical History

        public bool ValidateMedical()
        {
            return true;
        }
        private void cmdSaveMedical_Click(object sender, EventArgs e)
        {
            tabPageHistory.Tag = 6;
            if (ValidateMedical() == true)
            {
                if (tabPageHistory.Tag !=null)
                {
                    int medHistoryCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblHistory WHERE historyPK=@historyPK", new SqlParameter("@historyPK", tabPageHistory.Tag.ToString()));

                    if (medHistoryCnt > 0)
                    {
                        string smoking="";
                        smoking=rdoHabits_Smoking_No.Checked?"No":smoking;
                        smoking=rdoHabits_Smoking_Yes.Checked?"Yes":smoking;
                        smoking=rdoHabits_Smoking_ExSmoker.Checked?"Ex-Smoker":smoking;

                        string maritalStaus="";
                        maritalStaus=rdoObsterics_Married_Single.Checked?"Single":maritalStaus;
                        maritalStaus=rdoObsterics_Married_Married.Checked?"Married":maritalStaus;

                        SqlDb.ExecuteQuery("UPDATE [tblHistory] SET [visitPK] = @visitPK, [medicalHistory] = @medicalHistory, [surgicalHistory] = @surgicalHistory, [allergies] = @allergies, [medications] = @medications, [exercise] = @exercise, [typeOfExcercise] = @typeOfExcercise, [frequencyPerWeek] = @frequencyPerWeek, [smoking] = @smoking, [numberOfSticksPerDay] = @numberOfSticksPerDay, [sinceAge] = @sinceAge, [alcohol] = @alcohol, [avgDrinksPerWk] = @avgDrinksPerWk, [father] = @father, [mother] = @mother, [brother] = @brother, [sister] = @sister, [others] = @others, [occupational_travel_his] = @occupational_travel_his, [maritalStatus] = @maritalStatus, [children] = @children, [miscarriage_abortion] = @miscarriage_abortion, [contraception] = @contraception, [lmp] = @lmp, [lastPap] = @lastPap, [gynaecologicalHis_Other] = @gynaecologicalHis_Other, [otherMedHistory] = @otherMedHistory, [updatePK] = @updatePK, [updateDate] = @updateDate WHERE [historyPK] = @historyPK",
                                        new SqlParameter("@historyPK", int.Parse(tabPageHistory.Tag.ToString())),
                                        new SqlParameter("@visitPK", "V20140925CBL01001"),
                                        new SqlParameter("@medicalHistory",txtPastHistory_MedicalHistory.Text.Trim()),
                                        new SqlParameter("@surgicalHistory",txtPastHistory_SurgicalHistory.Text.Trim()),
                                        new SqlParameter("@allergies",txtPastHistory_Allergies.Text.Trim()),
                                        new SqlParameter("@medications",txtMedications.Text.Trim()),
                                        new SqlParameter("@exercise", rdoHabits_Excercise_Yes.Checked),
                                        new SqlParameter("@typeOfExcercise",txtHabits_TypeofExcercise.Text.Trim()),
                                        new SqlParameter("@frequencyPerWeek",txtHabits_Frequency.Text.Trim()),
                                        new SqlParameter("@smoking",smoking),
                                        new SqlParameter("@numberOfSticksPerDay",txtHabits_No_Sticks.Text.Trim()),
                                        new SqlParameter("@sinceAge",txtHabits_SmokingYear.Text.Trim()),
                                        new SqlParameter("@alcohol",rdoHabits_Alcohol_Yes.Checked),
                                        new SqlParameter("@avgDrinksPerWk",txtHabits_AvgDrinks.Text.Trim()),
                                        new SqlParameter("@father",txtFamilyFather.Text.Trim()),
                                        new SqlParameter("@mother",txtFamilyMother.Text.Trim()),
                                        new SqlParameter("@brother",txtFamilyBrother.Text.Trim()),
                                        new SqlParameter("@sister",txtFamilySister.Text.Trim()),
                                        new SqlParameter("@others",txtFamilyOthers.Text.Trim()),
                                        new SqlParameter("@occupational_travel_his",txtOccupational.Text.Trim()),
                                        new SqlParameter("@maritalStatus", maritalStaus),
                                        new SqlParameter("@children",txtObsterics_Children.Text.Trim()),
                                        new SqlParameter("@miscarriage_abortion",txtObstericMiscarriage.Text.Trim()),
                                        new SqlParameter("@contraception",txtObsterics_Contraception.Text.Trim()),
                                        new SqlParameter("@lmp",txtGynaeco_LMP.Text.Trim()),
                                        new SqlParameter("@lastPap",txtGynaeco_LastPap.Text.Trim()),
                                        new SqlParameter("@gynaecologicalHis_Other",txtGynaeco_Other.Text.Trim()),
                                        new SqlParameter("@otherMedHistory",txtOtherMedicalHistory.Text.Trim()),
                                        new SqlParameter("@updatePK", AppVariable.CURRENT_USER_PK.ToString()),
                                        new SqlParameter("@updateDate",DateTime.Now)
                                        );

                        //sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Update Medical History.");

                        MessageBox.Show("Saving Medical History is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    int medHistoryID = SqlDb.ExecuteScalar<int>("getID tblHistory");

                    int medHistoryIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblHistory WHERE historyPK=@historyPK", new SqlParameter("@historyPK", medHistoryID));

                    if (medHistoryIDCnt < 1)
                    {
                        string smoking = "";
                        smoking = rdoHabits_Smoking_No.Checked ? "No" : smoking;
                        smoking = rdoHabits_Smoking_Yes.Checked ? "Yes" : smoking;
                        smoking = rdoHabits_Smoking_ExSmoker.Checked ? "Ex-Smoker" : smoking;

                        string maritalStaus = "";
                        maritalStaus = rdoObsterics_Married_Single.Checked ? "Single" : maritalStaus;
                        maritalStaus = rdoObsterics_Married_Married.Checked ? "Married" : maritalStaus;

                        SqlDb.ExecuteQuery("INSERT INTO [tblHistory] ([historyPK], [visitPK], [medicalHistory], [surgicalHistory], [allergies], [medications], [exercise], [typeOfExcercise], [frequencyPerWeek], [smoking], [numberOfSticksPerDay], [sinceAge], [alcohol], [avgDrinksPerWk], [father], [mother], [brother], [sister], [others], [occupational_travel_his], [maritalStatus], [children], [miscarriage_abortion], [contraception], [lmp], [lastPap], [gynaecologicalHis_Other], [otherMedHistory], [updatePK], [updateDate], [createPK], [createDate]) VALUES (@historyPK, @visitPK, @medicalHistory, @surgicalHistory, @allergies, @medications, @exercise, @typeOfExcercise, @frequencyPerWeek, @smoking, @numberOfSticksPerDay, @sinceAge, @alcohol, @avgDrinksPerWk, @father, @mother, @brother, @sister, @others, @occupational_travel_his, @maritalStatus, @children, @miscarriage_abortion, @contraception, @lmp, @lastPap, @gynaecologicalHis_Other, @otherMedHistory, @updatePK, @updateDate, @createPK, @createDate)",
                                        new SqlParameter("@historyPK", medHistoryID),
                                        new SqlParameter("@visitPK", "V20140925CBL01001"),
                                        new SqlParameter("@medicalHistory", txtPastHistory_MedicalHistory.Text.Trim()),
                                        new SqlParameter("@surgicalHistory", txtPastHistory_SurgicalHistory.Text.Trim()),
                                        new SqlParameter("@allergies", txtPastHistory_Allergies.Text.Trim()),
                                        new SqlParameter("@medications", txtMedications.Text.Trim()),
                                        new SqlParameter("@exercise", rdoHabits_Excercise_Yes.Checked),
                                        new SqlParameter("@typeOfExcercise", txtHabits_TypeofExcercise.Text.Trim()),
                                        new SqlParameter("@frequencyPerWeek", txtHabits_Frequency.Text.Trim()),
                                        new SqlParameter("@smoking", smoking),
                                        new SqlParameter("@numberOfSticksPerDay", txtHabits_No_Sticks.Text.Trim()),
                                        new SqlParameter("@sinceAge", txtHabits_SmokingYear.Text.Trim()),
                                        new SqlParameter("@alcohol", rdoHabits_Alcohol_Yes.Checked),
                                        new SqlParameter("@avgDrinksPerWk", txtHabits_AvgDrinks.Text.Trim()),
                                        new SqlParameter("@father", txtFamilyFather.Text.Trim()),
                                        new SqlParameter("@mother", txtFamilyMother.Text.Trim()),
                                        new SqlParameter("@brother", txtFamilyBrother.Text.Trim()),
                                        new SqlParameter("@sister", txtFamilySister.Text.Trim()),
                                        new SqlParameter("@others", txtFamilyOthers.Text.Trim()),
                                        new SqlParameter("@occupational_travel_his", txtOccupational.Text.Trim()),
                                        new SqlParameter("@maritalStatus", maritalStaus),
                                        new SqlParameter("@children", txtObsterics_Children.Text.Trim()),
                                        new SqlParameter("@miscarriage_abortion", txtObstericMiscarriage.Text.Trim()),
                                        new SqlParameter("@contraception", txtObsterics_Contraception.Text.Trim()),
                                        new SqlParameter("@lmp", txtGynaeco_LMP.Text.Trim()),
                                        new SqlParameter("@lastPap", txtGynaeco_LastPap.Text.Trim()),
                                        new SqlParameter("@gynaecologicalHis_Other", txtGynaeco_Other.Text.Trim()),
                                        new SqlParameter("@otherMedHistory", txtOtherMedicalHistory.Text.Trim()),
                                        new SqlParameter("@createPK",AppVariable.CURRENT_USER_PK.ToString()),
                                        new SqlParameter("@createDate",DateTime.Now),
                                        new SqlParameter("@updatePK", AppVariable.CURRENT_USER_PK.ToString()),
                                        new SqlParameter("@updateDate", DateTime.Now)
                                        );

                        //sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Add New Medical History .");
                        MessageBox.Show("Saving Medical History is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                    }
                }
            }
        }
        #endregion

        private void tabMedicalRecord_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page.Name == tabPageHistory.Name)
            {
                //LoadMedicalHistory(strSelectedVisitPK);
            }
        }

        public void LoadMedicalHistory(string visitPK)
        { 
            DataSet ds = SqlDb.GetDataSet("Select * from tblHistory where visitPK=@visitPK",
            new SqlParameter("@visitPK", visitPK));
            if(ds.Tables[0].Rows.Count>0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                txtPastHistory_MedicalHistory.Text=dr["medicalHistory"].ToString();
                txtPastHistory_SurgicalHistory.Text=dr["surgicalHistory"].ToString(); 
                txtPastHistory_Allergies.Text= dr["allergies"].ToString(); 
                txtMedications.Text=    dr["medications"].ToString(); 
                rdoHabits_Excercise_Yes.Checked=Convert.ToBoolean(dr["exercise"].ToString());
                txtHabits_TypeofExcercise.Text=    dr["typeOfExcercise"].ToString(); 
                txtHabits_Frequency.Text=    dr["frequencyPerWeek"].ToString();
                if (dr["Smoking"].ToString() != "")
                {
                    if (dr["Smoking"].ToString() == "Yes")
                    {
                        rdoHabits_Smoking_Yes.Checked = true;
                    }
                    if (dr["Smoking"].ToString() == "No")
                    {
                        rdoHabits_Smoking_No.Checked = true;
                    }

                    if (dr["Smoking"].ToString() == "Ex-Smoker")
                    {
                        rdoHabits_Smoking_ExSmoker.Checked = true;
                    }
                }
                
                txtHabits_No_Sticks.Text=    dr["numberOfSticksPerDay"].ToString(); 
                txtHabits_SmokingYear.Text=    dr["sinceAge"].ToString();
                rdoHabits_Alcohol_Yes.Checked=Convert.ToBoolean(    dr["alcohol"].ToString());
                txtHabits_AvgDrinks.Text=   dr["avgDrinksPerWk"].ToString(); 
                txtFamilyFather.Text=   dr["father"].ToString(); 
                txtFamilyBrother.Text=   dr["brother"].ToString(); 
                txtFamilySister.Text=    dr["sister"].ToString(); 
                txtFamilyOthers.Text=    dr["others"].ToString(); 
                txtOccupational.Text=   dr["occupational_travel_his"].ToString(); 
                if(dr["maritalStatus"].ToString()!="")
                {
                     if(dr["maritalStatus"].ToString()=="Single")
                     {
                        rdoObsterics_Married_Single.Checked=true;
                     }
                    if(dr["maritalStatus"].ToString()=="Married")
                     {
                        rdoObsterics_Married_Married.Checked=true;
                     }
                }
                txtObsterics_Children.Text=   dr["children"].ToString(); 
                txtObstericMiscarriage.Text=   dr["miscarriage_abortion"].ToString(); 
                txtObsterics_Contraception.Text=  dr["contraception"].ToString(); 
                txtGynaeco_LMP.Text= dr["lmp"].ToString(); 
                txtGynaeco_LastPap.Text=    dr["lastPap"].ToString(); 
                txtGynaeco_Other.Text=    dr["gynaecologicalHis_Other"].ToString(); 
                txtOtherMedicalHistory.Text=    dr["otherMedHistory"].ToString();                         
            }
        }

        //private void grdViewVisited_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        //{
        //    if (grdViewVisited.RowCount > 0)
        //    {
        //        DataRow drVisit = grdViewVisited.GetDataRow(grdViewVisited.FocusedRowHandle);
        //        strSelectedVisit = drVisit.ItemArray[0].ToString();

        //        LoadMedicalHistory(strSelectedVisit);
        //    }
        //    else
        //    {
        //        strSelectedVisit = string.Empty;
        //    }
        //}

        private void rdoHabits_Excercise_CheckedChanged(object sender, EventArgs e)
        {
            txtHabits_TypeofExcercise.Enabled = rdoHabits_Excercise_Yes.Checked;
            txtHabits_Frequency.Enabled = rdoHabits_Excercise_Yes.Checked;
        }

        private void rdoHabits_Smoking_No_CheckedChanged(object sender, EventArgs e)
        {
            txtHabits_No_Sticks.Enabled = !rdoHabits_Smoking_No.Checked;
            txtHabits_SmokingYear.Enabled = !rdoHabits_Smoking_No.Checked;
        }

        private void rdoHabits_Alcohol_No_CheckedChanged(object sender, EventArgs e)
        {
            txtHabits_AvgDrinks.Enabled = !rdoHabits_Alcohol_No.Checked;
        }
        
        
        #region ExaminiationPage

        #endregion

        #endregion Medical Record

        #region Physical Examination


        private void initPhysicalExamination()
        {
            txtPhySkin.Text = "";

            txtPhyVision.Text = "";
            txtPhyVisualAcuity.Text = "";
            optPhyGlassesNo.Checked = true;
            optPhyGlassesYes.Checked = false;
            txtPhyEyeRemarks.Text = "";

            txtPhyEAC.Text = "";
            txtPhyTM.Text = "";
            txtPhyHearing.Text = "";
            txtPhyEarsRemarks.Text = "";

            txtPhyNose.Text = "";

            txtPhyGum.Text = "";
            txtPhyTongue.Text = "";
            txtPhyTonsils.Text = "";
            txtPhyTeeth.Text = "";
            txtPhyThroatRemarks.Text = "";

            txtPhyThyroid.Text = "";
            txtPhyCervicalLN.Text = "";
            txtPhyAxillary.Text = "";
            txtPhyNeckOthers.Text = "";
            txtPhyNeckRemarks.Text = "";

            optPhyBreastNormal.Checked = true;
            optPhyBreastLump.Checked = false;
            txtPhyBreastRemarks.Text = "";

            txtPhyAirWay.Text = "";
            txtPhyBreathSound.Text = "";
            txtPhyRespiratoryOthers.Text = "";
            txtPhyRespiratoryRemarks.Text = "";

            txtPhyRate.Text = "";
            txtPhyRhythm.Text = "";
            txtPhyHeartSounds.Text = "";
            txtPhyAddedSounds.Text = "";
            txtPhyCardiovacularRemarks.Text = "";

            txtPhyGeneral.Text = "";
            txtPhyLiver.Text = "";
            txtPhySpleen.Text = "";
            txtPhyKidney.Text = "";
            txtPhyHerniaOrifices.Text = "";
            txtPhyAbdomenOthers.Text = "";
            txtPhyAbdomenRemarks.Text = "";

            optPhyPapYes.Checked = false;
            optPhyPapNo.Checked = true;
            txtPhyExternalGen.Text = "";

            txtPhyMusculoskeletal.Text = "";

            txtPhyGCS.Text = "";
            txtPhyPupils.Text = "";
            txtPhyFocalNeuro.Text = "";
            txtPhyCN.Text = "";

            txtPhyComment.Text = "";


        }

        private void loadPhysicalExamination()
        {
            initPhysicalExamination();

            if (strSelectedVisitPK != string.Empty)
            {
                DataSet dsPhyExam = SqlDb.GetDataSet("SELECT * FROM tblExamination WHERE visitPK='" + strSelectedVisitPK + "'");
                if (dsPhyExam.Tables.Count > 0)
                {
                    if (dsPhyExam.Tables[0].Rows.Count > 0)
                    {
                        txtPhySkin.Text = dsPhyExam.Tables[0].Rows[0]["skin"].ToString();

                        txtPhyVision.Text = dsPhyExam.Tables[0].Rows[0]["vision"].ToString();
                        txtPhyVisualAcuity.Text = dsPhyExam.Tables[0].Rows[0]["visualAcuity"].ToString();

                        bool bolGlasses = bool.Parse(dsPhyExam.Tables[0].Rows[0]["glasses"].ToString());
                        optPhyGlassesNo.Checked = !bolGlasses;
                        optPhyGlassesYes.Checked = bolGlasses;

                        txtPhyEyeRemarks.Text = dsPhyExam.Tables[0].Rows[0]["eyeRemarks"].ToString();

                        txtPhyEAC.Text = dsPhyExam.Tables[0].Rows[0]["eac"].ToString();
                        txtPhyTM.Text = dsPhyExam.Tables[0].Rows[0]["tm"].ToString();
                        txtPhyHearing.Text = dsPhyExam.Tables[0].Rows[0]["hearing"].ToString();
                        txtPhyEarsRemarks.Text = dsPhyExam.Tables[0].Rows[0]["earRemarks"].ToString();

                        txtPhyNose.Text = dsPhyExam.Tables[0].Rows[0]["nose"].ToString();

                        txtPhyGum.Text = dsPhyExam.Tables[0].Rows[0]["gum"].ToString();
                        txtPhyTongue.Text = dsPhyExam.Tables[0].Rows[0]["tongue"].ToString();
                        txtPhyTonsils.Text = dsPhyExam.Tables[0].Rows[0]["tonsils"].ToString();
                        txtPhyTeeth.Text = dsPhyExam.Tables[0].Rows[0]["teeth"].ToString();
                        txtPhyThroatRemarks.Text = dsPhyExam.Tables[0].Rows[0]["throatRemarks"].ToString();

                        txtPhyThyroid.Text = dsPhyExam.Tables[0].Rows[0]["thyroid"].ToString();
                        txtPhyCervicalLN.Text = dsPhyExam.Tables[0].Rows[0]["cervicalln"].ToString();
                        txtPhyNeckOthers.Text = dsPhyExam.Tables[0].Rows[0]["neckOthers"].ToString();
                        txtPhyAxillary.Text = dsPhyExam.Tables[0].Rows[0]["axillary"].ToString();
                        txtPhyNeckRemarks.Text = dsPhyExam.Tables[0].Rows[0]["neckRemarks"].ToString();

                        bool bolBreast = bool.Parse(dsPhyExam.Tables[0].Rows[0]["breastNormal_Lump"].ToString());
                        optPhyBreastNormal.Checked = bolBreast;
                        optPhyBreastLump.Checked = !bolBreast;
                        txtPhyBreastRemarks.Text = dsPhyExam.Tables[0].Rows[0]["breastRemarks"].ToString();

                        txtPhyAirWay.Text = dsPhyExam.Tables[0].Rows[0]["airway"].ToString();
                        txtPhyBreathSound.Text = dsPhyExam.Tables[0].Rows[0]["breathSound"].ToString();
                        txtPhyRespiratoryOthers.Text = dsPhyExam.Tables[0].Rows[0]["respiratoryOthers"].ToString();
                        txtPhyRespiratoryRemarks.Text = dsPhyExam.Tables[0].Rows[0]["respiratoryRemarks"].ToString();

                        txtPhyRate.Text = dsPhyExam.Tables[0].Rows[0]["rate"].ToString();
                        txtPhyRhythm.Text = dsPhyExam.Tables[0].Rows[0]["rhythm"].ToString();
                        txtPhyHeartSounds.Text = dsPhyExam.Tables[0].Rows[0]["heartSound"].ToString();
                        txtPhyAddedSounds.Text = dsPhyExam.Tables[0].Rows[0]["addedSound"].ToString();
                        txtPhyCardiovacularRemarks.Text = dsPhyExam.Tables[0].Rows[0]["caridovascularRemarks"].ToString();

                        txtPhyGeneral.Text = dsPhyExam.Tables[0].Rows[0]["abdomenGeneral"].ToString();
                        txtPhyLiver.Text = dsPhyExam.Tables[0].Rows[0]["liver"].ToString();
                        txtPhySpleen.Text = dsPhyExam.Tables[0].Rows[0]["spleen"].ToString();
                        txtPhyKidney.Text = dsPhyExam.Tables[0].Rows[0]["kidney"].ToString();
                        txtPhyHerniaOrifices.Text = dsPhyExam.Tables[0].Rows[0]["herniaOrifices"].ToString();
                        txtPhyAbdomenOthers.Text = dsPhyExam.Tables[0].Rows[0]["abdomenOther"].ToString();
                        txtPhyAbdomenRemarks.Text = dsPhyExam.Tables[0].Rows[0]["abdomenRemarks"].ToString();

                        bool bolPap = bool.Parse(dsPhyExam.Tables[0].Rows[0]["externalGenitaliaPap"].ToString());
                        optPhyPapYes.Checked = bolPap;
                        optPhyPapNo.Checked = !bolPap;
                        txtPhyExternalGen.Text = dsPhyExam.Tables[0].Rows[0]["externalGenitaliaRemarks"].ToString();

                        txtPhyMusculoskeletal.Text = dsPhyExam.Tables[0].Rows[0]["musculoskeletalRemarks"].ToString();

                        txtPhyGCS.Text = dsPhyExam.Tables[0].Rows[0]["gcs"].ToString();
                        txtPhyPupils.Text = dsPhyExam.Tables[0].Rows[0]["pupils"].ToString();
                        txtPhyFocalNeuro.Text = dsPhyExam.Tables[0].Rows[0]["focalNeuroDeficits"].ToString();
                        txtPhyCN.Text = dsPhyExam.Tables[0].Rows[0]["cn"].ToString();

                        txtPhyComment.Text = dsPhyExam.Tables[0].Rows[0]["examComment"].ToString();

                    }
                }
            }

        }

        private void savePhysicalExamination()
        {
            if (strSelectedVisitPK != string.Empty)
            {
                int examCount = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblExamination WHERE visitPK='" + strSelectedVisitPK + "'");

                if (examCount > 0)
                {
                    SqlDb.ExecuteQuery("UPDATE tblExamination " +
                                        "SET [skin] = @skin,  " +
                                         "[vision] = @vision,  " +
                                         "[visualAcuity] = @visualAcuity,  " +
                                         "[glasses] = @glasses,  " +
                                         "[eac] = @eac,  " +
                                         "[tm] = @tm,  " +
                                         "[hearing] = @hearing,  " +
                                         "[nose] = @nose,  " +
                                         "[gum] = @gum,  " +
                                         "[tongue] = @tongue,  " +
                                         "[tonsils] = @tonsils,  " +
                                         "[teeth] = @teeth,  " +
                                         "[thyroid] = @thyroid,  " +
                                         "[cervicalln] = @cervicalln,  " +
                                         "[neckOthers] = @neckOthers,  " +
                                         "[axillary] = @axillary,  " +
                                         "[breastNormal_Lump] = @breastNormal_Lump,  " +
                                         "[airway] = @airway,  " +
                                         "[breathSound] = @breathSound,  " +
                                         "[respiratoryOthers] = @respiratoryOthers,  " +
                                         "[rate] = @rate,  " +
                                         "[rhythm] = @rhythm,  " +
                                         "[heartSound] = @heartSound,  " +
                                         "[addedSound] = @addedSound,  " +
                                         "[abdomenGeneral] = @abdomenGeneral,  " +
                                         "[liver] = @liver,  " +
                                         "[spleen] = @spleen,  " +
                                         "[kidney] = @kidney,  " +
                                         "[herniaOrifices] = @herniaOrifices,  " +
                                         "[abdomenOther] = @abdomenOther,  " +
                                         "[externalGenitaliaPap] = @externalGenitaliaPap,  " +
                                         "[gcs] = @gcs, " +
                                         "[pupils] = @pupils,  " +
                                         "[focalNeuroDeficits]=@focalNeuroDeficits, " +
                                         "[cn] = @cn, " +
                                         "[eyeRemarks] = @eyeRemarks,  " +
                                         "[earRemarks] = @earRemarks,  " +
                                         "[throatRemarks] = @throatRemarks,  " +
                                         "[neckRemarks] = @neckRemarks,  " +
                                         "[breastRemarks] = @breastRemarks,  " +
                                         "[respiratoryRemarks] = @respiratoryRemarks,  " +
                                         "[abdomenRemarks] = @abdomenRemarks,  " +
                                         "[caridovascularRemarks] = @caridovascularRemarks,  " +
                                         "[externalGenitaliaRemarks] = @externalGenitaliaRemarks,  " +
                                         "[musculoskeletalRemarks] = @musculoskeletalRemarks,  " +
                                         "[examComment] = @examComment,  " +
                                         "[updatePK] = @updatePK ,[updateDate] = SYSDATETIME() WHERE visitPK = @visitPK ",
                                        new SqlParameter(" @skin", txtPhySkin.Text.Trim()),
                                        new SqlParameter("@vision", txtPhyVision.Text),
                                        new SqlParameter("@visualAcuity", txtPhyVisualAcuity.Text),
                                        new SqlParameter("@glasses", optPhyGlassesYes.Checked),
                                        new SqlParameter("@eac", txtPhyEAC.Text),
                                        new SqlParameter("@tm", txtPhyTM.Text),
                                        new SqlParameter("@hearing", txtPhyHearing.Text),
                                        new SqlParameter("@nose", txtPhyNose.Text),
                                        new SqlParameter("@gum", txtPhyGum.Text),
                                        new SqlParameter("@tongue", txtPhyTongue.Text),
                                        new SqlParameter("@tonsils", txtPhyTonsils.Text),
                                        new SqlParameter("@teeth", txtPhyTeeth.Text),
                                        new SqlParameter("@thyroid", txtPhyThyroid.Text),
                                        new SqlParameter("@cervicalln", txtPhyCervicalLN.Text),
                                        new SqlParameter("@neckOthers", txtPhyNeckOthers.Text),
                                        new SqlParameter("@axillary", txtPhyAxillary.Text),
                                        new SqlParameter("@breastNormal_Lump", optPhyBreastNormal.Checked),
                                        new SqlParameter("@airway", txtPhyAirWay.Text),
                                        new SqlParameter("@breathSound", txtPhyBreathSound.Text),
                                        new SqlParameter("@respiratoryOthers", txtPhyRespiratoryOthers.Text),
                                        new SqlParameter("@rate", txtPhyRate.Text),
                                        new SqlParameter("@rhythm", txtPhyRhythm.Text),
                                        new SqlParameter("@heartSound", txtPhyHeartSounds.Text),
                                        new SqlParameter("@addedSound", txtPhyAddedSounds.Text),
                                        new SqlParameter("@abdomenGeneral", txtPhyGeneral.Text),
                                        new SqlParameter("@liver", txtPhyLiver.Text),
                                        new SqlParameter("@spleen", txtPhySpleen.Text),
                                        new SqlParameter("@kidney", txtPhyKidney.Text),
                                        new SqlParameter("@herniaOrifices", txtPhyHerniaOrifices.Text),
                                        new SqlParameter("@abdomenOther", txtPhyAbdomenOthers.Text),
                                        new SqlParameter("@externalGenitaliaPap", optPhyPapYes.Checked),
                                        new SqlParameter("@gcs", txtPhyGCS.Text),
                                        new SqlParameter("@pupils", txtPhyPupils.Text),
                                        new SqlParameter("@focalNeuroDeficits", txtPhyFocalNeuro.Text),
                                        new SqlParameter("@cn", txtPhyCN.Text),


                                        new SqlParameter("@eyeRemarks", txtPhyEyeRemarks.Text),
                                        new SqlParameter("@earRemarks", txtPhyEarsRemarks.Text),

                                        new SqlParameter("@throatRemarks", txtPhyThroatRemarks.Text),
                                        new SqlParameter("@neckRemarks", txtPhyNeckRemarks.Text),
                                        new SqlParameter("@breastRemarks", txtPhyBreastRemarks.Text),
                                        new SqlParameter("@respiratoryRemarks", txtPhyRespiratoryRemarks.Text),
                                        new SqlParameter("@abdomenRemarks", txtPhyAbdomenRemarks.Text),
                                        new SqlParameter("@caridovascularRemarks", txtPhyCardiovacularRemarks.Text),
                                        new SqlParameter("@externalGenitaliaRemarks", txtPhyExternalGen.Text),
                                        new SqlParameter("@musculoskeletalRemarks", txtPhyMusculoskeletal.Text),

                                        new SqlParameter("@examComment", txtPhyComment.Text),
                                        new SqlParameter("@updatePK", AppVariable.CURRENT_USER_PK),
                                        new SqlParameter("@visitPK", strSelectedVisitPK));

                    MessageBox.Show("Update is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int PosiID = SqlDb.ExecuteScalar<int>("getID tblPosition");

                    int PosiIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblPosition WHERE positionPK=@PositionPK AND isDelete=0", new SqlParameter("@PositionPK", PosiID));

                    if (PosiIDCnt < 1)
                    {
                        SqlDb.ExecuteQuery("INSERT INTO [tblExamination]" +
                                             " ,[skin]" +
                                             " ,[vision]" +
                                             " ,[visualAcuity]" +
                                             " ,[glasses]" +
                                             " ,[eac]" +
                                             " ,[tm]" +
                                             " ,[hearing]" +
                                             " ,[nose]" +
                                             " ,[gum]" +
                                             " ,[tongue]" +
                                             " ,[tonsils]" +
                                             " ,[teeth]" +
                                             " ,[thyroid]" +
                                             " ,[cervicalln]" +
                                             " ,[neckOthers]" +
                                             " ,[axillary]" +
                                             " ,[breastNormal_Lump]" +
                                             " ,[airway]" +
                                             " ,[breathSound]" +
                                             " ,[respiratoryOthers]" +
                                             " ,[rate]" +
                                             " ,[rhythm]" +
                                             " ,[heartSound]" +
                                             " ,[addedSound]" +
                                             " ,[abdomenGeneral]" +
                                             " ,[liver]" +
                                             " ,[spleen]" +
                                             " ,[kidney]" +
                                             " ,[herniaOrifices]" +
                                             " ,[abdomenOther]" +
                                             " ,[externalGenitaliaPap]" +
                                             " ,[gcs]"+
                                             " ,[pupils]" +
                                             " ,[focalNeuroDeficits]"+
                                             " ,[cn]" +
                                             " ,[eyeRemarks]" +
                                             " ,[earRemarks]" +
                                             " ,[throatRemarks]" +
                                             " ,[neckRemarks]" +
                                             " ,[breastRemarks]" +
                                             " ,[respiratoryRemarks]" +
                                             " ,[abdomenRemarks]" +
                                             " ,[caridovascularRemarks]" +
                                             " ,[externalGenitaliaRemarks]" +
                                             " ,[musculoskeletalRemarks]" +
                                             " ,[examComment]" +
                                             " ,[createPK]" +
                                             " ,[createDate]" +
                                             " ,[updatePK]" +
                                             " ,[updateDate]" +
                                             " ,[visitPK])" +
                                             " VALUES" +
                                             " (@skin" +
                                             " ,@vision" +
                                             " ,@visualAcuity" +
                                             " ,@glasses" +
                                             " ,@eac" +
                                             " ,@tm" +
                                             " ,@hearing" +
                                             " ,@nose" +
                                             " ,@gum" +
                                             " ,@tongue" +
                                             " ,@tonsils" +
                                             " ,@teeth" +
                                             " ,@thyroid" +
                                             " ,@cervicalln" +
                                             " ,@neckOthers" +
                                             " ,@axillary" +
                                             " ,@breastNormal_Lump" +
                                             " ,@airway" +
                                             " ,@breathSound" +
                                             " ,@respiratoryOthers" +
                                             " ,@rate" +
                                             " ,@rhythm" +
                                             " ,@heartSound" +
                                             " ,@addedSound" +
                                             " ,@abdomenGeneral" +
                                             " ,@liver" +
                                             " ,@spleen" +
                                             " ,@kidney" +
                                             " ,@herniaOrifices" +
                                             " ,@abdomenOther" +
                                             " ,@externalGenitaliaPap" +
                                             " ,@gcs"+
                                             " ,@pupils" +
                                             " ,@focalNeuroDeficits" +
                                             " ,@cn" +
                                             " ,@eyeRemarks" +
                                             " ,@earRemarks" +
                                             " ,@throatRemarks" +
                                             " ,@neckRemarks" +
                                             " ,@breastRemarks" +
                                             " ,@respiratoryRemarks" +
                                             " ,@abdomenRemarks" +
                                             " ,@caridovascularRemarks" +
                                             " ,@externalGenitaliaRemarks" +
                                             " ,@musculoskeletalRemarks" +
                                             " ,@examComment" +
                                             " ,@createPK" +
                                             " ,SYSDATETIME()" +
                                             " ,@updatePK" +
                                             " ,SYSDATETIME()" +
                                             " ,@visitPK)",
                                        new SqlParameter(" @skin", txtPhySkin.Text.Trim()),
                                        new SqlParameter("@vision", txtPhyVision.Text),
                                        new SqlParameter("@visualAcuity", txtPhyVisualAcuity.Text),
                                        new SqlParameter("@glasses", optPhyGlassesYes.Checked),
                                        new SqlParameter("@eac", txtPhyEAC.Text),
                                        new SqlParameter("@tm", txtPhyTM.Text),
                                        new SqlParameter("@hearing", txtPhyHearing.Text),
                                        new SqlParameter("@nose", txtPhyNose.Text),
                                        new SqlParameter("@gum", txtPhyGum.Text),
                                        new SqlParameter("@tongue", txtPhyTongue.Text),
                                        new SqlParameter("@tonsils", txtPhyTonsils.Text),
                                        new SqlParameter("@teeth", txtPhyTeeth.Text),
                                        new SqlParameter("@thyroid", txtPhyThyroid.Text),
                                        new SqlParameter("@cervicalln", txtPhyCervicalLN.Text),
                                        new SqlParameter("@neckOthers", txtPhyNeckOthers.Text),
                                        new SqlParameter("@axillary", txtPhyAxillary.Text),
                                        new SqlParameter("@breastNormal_Lump", optPhyBreastNormal.Checked),
                                        new SqlParameter("@airway", txtPhyAirWay.Text),
                                        new SqlParameter("@breathSound", txtPhyBreathSound.Text),
                                        new SqlParameter("@respiratoryOthers", txtPhyRespiratoryOthers.Text),
                                        new SqlParameter("@rate", txtPhyRate.Text),
                                        new SqlParameter("@rhythm", txtPhyRhythm.Text),
                                        new SqlParameter("@heartSound", txtPhyHeartSounds.Text),
                                        new SqlParameter("@addedSound", txtPhyAddedSounds.Text),
                                        new SqlParameter("@abdomenGeneral", txtPhyGeneral.Text),
                                        new SqlParameter("@liver", txtPhyLiver.Text),
                                        new SqlParameter("@spleen", txtPhySpleen.Text),
                                        new SqlParameter("@kidney", txtPhyKidney.Text),
                                        new SqlParameter("@herniaOrifices", txtPhyHerniaOrifices.Text),
                                        new SqlParameter("@abdomenOther", txtPhyAbdomenOthers.Text),
                                        new SqlParameter("@externalGenitaliaPap", optPhyPapYes.Checked),
                                        new SqlParameter("@gcs", txtPhyGCS.Text),
                                        new SqlParameter("@pupils", txtPhyPupils.Text),
                                        new SqlParameter("@focalNeuroDeficits", txtPhyFocalNeuro.Text),
                                        new SqlParameter("@cn", txtPhyCN.Text),


                                        new SqlParameter("@eyeRemarks", txtPhyEyeRemarks.Text),
                                        new SqlParameter("@earRemarks", txtPhyEarsRemarks.Text),

                                        new SqlParameter("@throatRemarks", txtPhyThroatRemarks.Text),
                                        new SqlParameter("@neckRemarks", txtPhyNeckRemarks.Text),
                                        new SqlParameter("@breastRemarks", txtPhyBreastRemarks.Text),
                                        new SqlParameter("@respiratoryRemarks", txtPhyRespiratoryRemarks.Text),
                                        new SqlParameter("@abdomenRemarks", txtPhyAbdomenRemarks.Text),
                                        new SqlParameter("@caridovascularRemarks", txtPhyCardiovacularRemarks.Text),
                                        new SqlParameter("@externalGenitaliaRemarks", txtPhyExternalGen.Text),
                                        new SqlParameter("@musculoskeletalRemarks", txtPhyMusculoskeletal.Text),

                                        new SqlParameter("@examComment", txtPhyComment.Text),
                                        new SqlParameter("@createPK", AppVariable.CURRENT_USER_PK),
                                        new SqlParameter("@updatePK", AppVariable.CURRENT_USER_PK),
                                        new SqlParameter("@visitPK", strSelectedVisitPK));
                    }
                }
            }

        }
        #endregion

        private void backstageViewControl1_Click(object sender, EventArgs e)
        {

        }

        private void bsvButAddSummary_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

        }

        private void backstageViewTabItem2_SelectedChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

        }

        private void backstageViewClientControl1_Load(object sender, EventArgs e)
        {

        }


        

    }
}
