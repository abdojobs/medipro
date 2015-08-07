using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using exaCore;
using MySql.Data.MySqlClient;
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
            

            lineDandP.Width = AppScreenWidth - 300;
            lineLandI.Width = AppScreenWidth - 300;
            lineAccess.Width = AppScreenWidth - 300;
            lineSystem.Width = AppScreenWidth - 300;

            //tabMedicalRecord.Width = AppScreenWidth - 655;
            //tabMedicalRecord.Height = AppScreenHeight - 165;            
        }

        private void frmStartup_Load(object sender, EventArgs e)
        {
            BindingBooking();
            BindingVisiting();
            BindingLabTechReq();
        }

        private void tabControlMain_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e)
        {
            bool IsView;
            e.Page.Tag = 3;
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
            if (grdViewLabTestReq.RowCount > 0)
            {
                drTodayVisit = grdViewLabTestReq.GetDataRow(grdViewLabTestReq.FocusedRowHandle);
            }
        }

        private void grdViewTodayVisitPatients_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (grdViewLabTestReq.RowCount > 0)
            {
                drTodayVisit = grdViewLabTestReq.GetDataRow(grdViewLabTestReq.FocusedRowHandle);
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
                                                new MySqlParameter("@abDate", curDate.ToString("yyyy-MM-dd")));

            grdBooking.DataSource = dsBookging.Tables[0];
           
            grdViewBooking.FocusedRowHandle = curBookingIndex;
        }

        private void BindingVisiting()
        {
            DateTime curDate = SqlDb.ExecuteScalar<DateTime>("SELECT GETDATE()");

            DataSet dsVisiting = SqlDb.GetDataSet("SELECT PK, patientName, RegNo, (tblTitle.TitleName + ' ' + tblDoctor.doctor) As doctorName, " +
                                                "abdate, tokenNo, abTime, abType, isVisited, isNew, (tblBooking.doctorPK) As doctorPK, visitPK FROM tblDoctor INNER JOIN tblBooking ON tblDoctor.doctorPK = tblBooking.doctorPK INNER JOIN tblTitle " +
                                                "ON tblDoctor.titlePK = tblTitle.titlePK WHERE abdate = @abDate",
                                                new MySqlParameter("@abDate", curDate.ToString("yyyy-MM-dd")));

            grdLabTestReq.DataSource = dsVisiting.Tables[0];

            grdViewLabTestReq.FocusedRowHandle = curVisitedIndex;
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            BindingBooking();
            BindingVisiting();
        }

        #endregion Startup Page

        

        private void cmdPatients_Click(object sender, EventArgs e)
        {
            AppVariable.CURRENT_SUB_MENU = "7";
            new frmPatients().ShowDialog();
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
            new frmLabTestList().ShowDialog();
        }

        private void cmdSubLabTest_Click(object sender, EventArgs e)
        {
            AppVariable.CURRENT_SUB_MENU = "7";
            new frmLabSubTest().ShowDialog();
        }

        private void cmdDoctors_Click(object sender, EventArgs e)
        {
            //AppVariable.CURRENT_SUB_MENU = "7";
            //new frmDoctor().ShowDialog();
        }


        //################## Lab Tech Request 

#region LabTechRequest

        DataRow drLabTechReq;
        int curLabTechReqIndex;


        private void GetLabTechReqRow()
        {
            if (grdViewLabTestReq.RowCount > 0)
            {
                drLabTechReq = grdViewLabTestReq.GetDataRow(grdViewLabTestReq.FocusedRowHandle);
            }
        }

        private void BindingLabTechReq()
        {
            //DataSet dsLabTechReq = SqlDb.GetDataSet("select req.labtechnicianrequestPK, req.labInvoiceNo, req.labTestPK,req.sampleID, req.hasSample, " +
            //                                        "req.hasResult, req.resultDateTime, lab.labTestCode,lab.labTestName, lab.companyPK,p.RegNo, p.Name, " +
            //                                        "p.FatherName, p.DOB,doc.doctorPK, doc.doctor from tbllabtechnicianrequest as req  " +
            //                                        "join tbllabtest as lab on lab.labTestPK = req.labTestPK " +
            //                                        "join tbllabinvoice as inv on inv.labInvoiceNo = req.labInvoiceNo " +
            //                                        "join tblpatient as p on  p.RegNo = inv.patientPK " +
            //                                        "join tbldoctor as doc on doc.doctorPK = inv.doctorPK " +
            //                                        "where req.hasResultIssued = 0 and req.branchPK = " + AppVariable.CURRENT_BRANCH_PK.ToString() + 
            //                                        " order by req.labtechnicianrequestPK desc");
            DataSet dsLabTechReq = SqlDb.GetDataSet("select h.labrequestheaderPK,d.doctor,h.patientName,h.patientAge,h.patientPhone from tbllabrequestheader as h inner join tbldoctor as d on d.doctorPK=h.doctorPK");
            grdLabTestReq.DataSource = dsLabTechReq.Tables[0];

            grdViewLabTestReq.FocusedRowHandle = curLabTechReqIndex;
        }

        private void grdViewLabTechReq_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GetLabTechReqRow();
        }



        private void grdViewLabTechReq_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            GetLabTechReqRow();
        }


        private void btnLabSample_Click(object sender, EventArgs e)
        {
            curLabTechReqIndex = grdViewLabTestReq.RowCount;

            frmLabTechReqSample fLabTechReqSample = new frmLabTechReqSample();
            frmLabTechReqSample.intLabTechReqPK = int.Parse(drLabTechReq.ItemArray[0].ToString());

            fLabTechReqSample.ShowDialog();

            BindingLabTechReq();
        }

#endregion

        private void grdLabTestReq_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr= grdViewLabTestReq.GetFocusedDataRow();
            string labReqHeaderPK = dr["labrequestheaderPK"].ToString();
            new frmLabInvoice(labReqHeaderPK).Show();
        }

        private void cmdAgent_Click(object sender, EventArgs e)
        {
            AppVariable.CURRENT_SUB_MENU = "7";
            new frmLabAgents().ShowDialog();
        }

        private void cmdReferFee_Click(object sender, EventArgs e)
        {
            AppVariable.CURRENT_SUB_MENU = "7";
            new frmLabReferFee().ShowDialog();
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

       

    }
}
