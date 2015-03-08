using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Registrator;
using System.Collections;
using DevExpress.Utils;
using System.ComponentModel.Design;
using System.ComponentModel;
using exaCore;
using System.Data.SqlClient;

namespace MediPro
{
    public partial class frmBooking : Form
    {
        clsSQL SqlDb = new clsSQL();
        DataSet dsDoctor;
        DataSet dsPatient;
        string doctorPK = string.Empty;
        bool widenStatus;
        DateTime dtBoooking;
        int lastTokenNo = 0;
        string lastCTime;
        
        public frmBooking()
        {
            InitializeComponent();

            this.Height = 346;
            grpClinicTime.Visible = false;          
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == true)
            {
                int patientCnt;
                if (radioNewPatient.Checked == true)
                {
                    patientCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblBooking WHERE patientName=@PatientName AND doctorPK=@DoctorPK AND abdate=@ABDate",
                                                            new SqlParameter("@PatientName", txtPatientName.Text),
                                                            new SqlParameter("@DoctorPK", doctorPK),
                                                            new SqlParameter("@ABDate", dtBoooking.Date.ToString("yyyy-MM-dd")));
                }
                else
                {
                    patientCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblBooking WHERE patientName=@PatientName AND doctorPK=@DoctorPK AND abdate=@ABDate",
                                                            new SqlParameter("@PatientName", luePatient.Text),
                                                            new SqlParameter("@DoctorPK", doctorPK),
                                                            new SqlParameter("@ABDate", dtBoooking.Date.ToString("yyyy-MM-dd")));
                }

                if (patientCnt > 0)
                {
                    DialogResult = MessageBox.Show("Please check your booking list. This patient's name was booked. Are you sure?", "MediPro :: Clinic System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (DialogResult == DialogResult.Yes)
                    {
                        Save();
                    }
                }
                else
                {
                    Save();
                }
            }
        }

        void Save()
        {            
            calcTokenNoAndBookingTime();           

            string BookingID = SqlDb.ExecuteScalar<string>("getBookingPK N'tblBooking','" + dtBoooking.ToString("yyyy-MM-dd") + "'");

            int bookingCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblBooking WHERE bookingPK = @BookingPK",
                                                    new SqlParameter("@BookingPK", BookingID));

            if (bookingCnt < 1)
            {
                SqlDb.ExecuteQuery("UPDATE tblBooking SET isLast = 0 WHERE doctorPK = @DoctorPK AND isLast = 1 AND abdate = @abDate",
                                    new SqlParameter("@DoctorPK", doctorPK),
                                    new SqlParameter("@abDate", dtBoooking.Date.ToString("yyyy-MM-dd")));

                SqlDb.ExecuteQuery("INSERT INTO tblBooking(PK,patientName,RegNo,abdate,doctorPK,tokenNo,abTime,abType,isNew,isLast) " +
                                    "VALUES(@PK,@PatientName,@RegNo,@ABDate,@DoctorPK,@TokenNo,@ABTime,@ABType,@IsNew,@IsLast)",
                                    new SqlParameter("@PK", BookingID),
                                    new SqlParameter("@PatientName", (radioNewPatient.Checked == true) ? txtPatientName.Text.Trim() : luePatient.Text.ToString()),
                                    new SqlParameter("@RegNo", (radioNewPatient.Checked == true) ? string.Empty : txtRegNo.Text.ToString()),
                                    new SqlParameter("@ABDate", dtBoooking.Date.ToString("yyyy-MM-dd")),
                                    new SqlParameter("@DoctorPK", doctorPK),
                                    new SqlParameter("@TokenNo", lblTokenNo.Text),
                                    new SqlParameter("@ABTime", lblLastBookingTime.Text),
                                    new SqlParameter("@ABType", "Booking"),
                                    new SqlParameter("@IsNew", (radioNewPatient.Checked == true) ? 0 : 1),
                                    new SqlParameter("@IsLast", 1));

                MessageBox.Show("Booking is Successfull." + System.Environment.NewLine + "Token No. is : " + lblTokenNo.Text + System.Environment.NewLine + "Time is : " + lblLastBookingTime.Text, "MediPro::Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
           
        }

        bool ValidateForm()
        {
            bool value = true;
            if (luePatient.Text.Length < 1 && radioRegPatient.Checked == true)
            {
                MessageBox.Show("Please enter Patient's Name.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                luePatient.Focus();
            }
            else if (txtPatientName.Text.Length < 1 && radioNewPatient.Checked == true)
            {
                MessageBox.Show("Please enter Patient's Name.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                txtPatientName.Focus();
            }
            else if (lueDoctor.Text.Length < 1)
            {
                MessageBox.Show("Please enter Doctor's Name.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                lueDoctor.Focus();
            }
            else if (cboOption.Text.Length < 1)
            {
                MessageBox.Show("Please select Option.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                cboOption.Focus();
            }
            else if (dteBookingDate.Text.Length < 1)
            {
                MessageBox.Show("Please select Option.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                dteBookingDate.Focus();
            }
            return value;
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioNewPatient_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNewPatient.Checked == true)
            {
                luePatient.Visible = false;
                txtPatientName.Visible = true;
                txtRegNo.Text = string.Empty;
                luePatient.EditValue = string.Empty;

                lblRegNo.Visible = false;
                txtRegNo.Visible = false;

                luePatient.Focus();
                luePatient.TabIndex = 2;
            }
        }

        private void radioRegPatient_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRegPatient.Checked == true)
            {
                txtPatientName.Visible = false;
                luePatient.Visible = true;
                lblRegNo.Visible = true;
                txtRegNo.Visible = true;

                txtPatientName.TabIndex = 2;
                txtPatientName.Focus();
            }
        }

        private void frmBooking_Load(object sender, EventArgs e)
        {
            LoadLueDoctor();
            LoadLuePatient();

            //if (cmdSave.Tag.ToString() == "Edit")
            //{
            //    LoadBookingInfo();
            //}
        }        

        private void LoadLuePatient()
        {
            dsPatient = SqlDb.GetDataSet("SELECT RegNo, (TitleName + ' ' + Name) As Name, Convert(varchar, DOB, 105) As DOB, FatherName, NRC FROM tblPatient INNER JOIN tblTitle ON tblPatient.titlePK = tblTitle.titlePK WHERE tblPatient.isDelete = 0");
            luePatient.Properties.DataSource = dsPatient.Tables[0];
        }

        private void LoadLueDoctor()
        {
            dsDoctor = SqlDb.GetDataSet("SELECT doctorPK, (TitleName + ' ' + doctor) AS doctor, position, specialize FROM tblDoctor INNER JOIN tblPosition ON tblDoctor.positionPK = tblPosition.positionPK INNER JOIN tblSpecialize ON tblDoctor.specializePK = tblSpecialize.specializePK INNER JOIN tblTitle ON tblDoctor.titlePK = tblTitle.titlePK WHERE (tblDoctor.isActive = 1)");
            lueDoctor.Properties.DataSource = dsDoctor.Tables[0];
        }

        private void CTDBinding()
        {
            if (doctorPK.Length > 0)
            {
                grpClinicTime.Enabled = true;

                DataSet dsCTD = SqlDb.GetDataSet("SELECT ctdPK, doctorPK, (clinicDay + ' (' + ctdOption + ')') AS clinicDay, toTime, fromTime FROM tblClinicTimeByDoctor " +
                                        "WHERE isDelete = 0 AND doctorPK = @DoctorPK",
                                        new SqlParameter("@DoctorPK", doctorPK));

                grdCTbyDoctor.DataSource = dsCTD.Tables[0];
            }
        }

        void takeTokenNoAndBookingTime()
        {
                if (lueDoctor.Text.ToString().Length > 0 && dteBookingDate.Text.ToString().Length > 0)
                {
                    int cntLast = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblBooking WHERE doctorPK = @DoctorPK AND isLast = 1 AND abdate = @abDate",
                                                        new SqlParameter("@DoctorPK", doctorPK),
                                                        new SqlParameter("@abDate", dtBoooking.Date.ToString("yyyy-MM-dd")));

                    if (cntLast > 0)
                    {
                        DataSet dsLastData = SqlDb.GetDataSet("SELECT tokenNo, abTime FROM tblBooking WHERE doctorPK = @DoctorPK AND isLast = 1 AND abdate = @abDate",
                                                            new SqlParameter("@DoctorPK", doctorPK),
                                                            new SqlParameter("@abDate", dtBoooking.Date.ToString("yyyy-MM-dd")));

                        lblTokenNo.Text = dsLastData.Tables[0].Rows[0]["tokenNo"].ToString();
                        lastTokenNo = int.Parse(dsLastData.Tables[0].Rows[0]["tokenNo"].ToString());

                        lblLastBookingTime.Text = dsLastData.Tables[0].Rows[0]["abTime"].ToString();
                        lastCTime = dsLastData.Tables[0].Rows[0]["abTime"].ToString();
                    }
                    else
                    {
                        lblTokenNo.Text = "1";
                        lastTokenNo = 0;

                        string ClinicTime = SqlDb.ExecuteScalar<string>("SELECT fromTime FROM tblClinicTimeByDoctor WHERE doctorPK=@DoctorPK AND clinicDay=@ClinicDay AND ctdOption=@CTDOption AND isDelete=0",
                                                                        new SqlParameter("@DoctorPK", doctorPK),
                                                                        new SqlParameter("@ClinicDay", dtBoooking.DayOfWeek.ToString()),
                                                                        new SqlParameter("CTDOption", cboOption.Text.ToString()));

                        lblLastBookingTime.Text = ClinicTime;
                        lastCTime = string.Empty;
                    }
                }
        }

        void calcTokenNoAndBookingTime()
        {
            takeTokenNoAndBookingTime();

            int TokenNo = lastTokenNo + 1;

            lblTokenNo.Text = TokenNo.ToString();

            if (lastCTime.Length > 0)
            {
                string lastClinicTime = lastCTime;

                char[] delimiters = new char[] { ':', ' ' };
                string[] clinicTime = lastClinicTime.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                int Hour = int.Parse(clinicTime[0].ToString());
                int Min = int.Parse(clinicTime[1].ToString());
                string m = clinicTime[2].ToString();

                int addMin = SqlDb.ExecuteScalar<int>("SELECT takeTime FROM tblDoctor WHERE doctorPK=@DoctorPK AND isActive = 1 AND isDelete = 0",
                                                    new SqlParameter("@DoctorPK", doctorPK));

                Min = Min + addMin;

                if (Min > 60)
                {
                    Min = Min - 60;

                    Hour = Hour + 1;

                    if (Hour > 12 && m == "AM")
                    {
                        m = "PM";
                        Hour = Hour - 12;
                    }

                    if (Hour > 12 && m == "PM")
                    {
                        m = "AM";
                        Hour = Hour - 12;
                    }
                }

                lastCTime = Hour + ":" + Min + " " + m;
            }
            else
            {
                lastCTime = lblLastBookingTime.Text.ToString();
            }

            lblLastBookingTime.Text = lastCTime;
        }

        private void luePatient_EditValueChanged(object sender, EventArgs e)
        {
            txtRegNo.Text = luePatient.EditValue.ToString();
        }

        private void lueDoctor_EditValueChanged(object sender, EventArgs e)
        {
            doctorPK = lueDoctor.EditValue.ToString();

            grpClinicTime.Text = "Clinic Time by " + lueDoctor.Text;
            CTDBinding();

            if (cboOption.Text.Length > 0 && doctorPK.ToString().Length > 0 && dteBookingDate.Text.Length > 0)
            {
                int ctdCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblClinicTimeByDoctor WHERE doctorPK=@DoctorPK AND clinicDay=@ClinicDay AND ctdOption=@CTDOption AND isDelete=0",
                                                    new SqlParameter("@DoctorPK", doctorPK),
                                                    new SqlParameter("@ClinicDay", dtBoooking.DayOfWeek.ToString()),
                                                    new SqlParameter("@CTDOption", cboOption.Text));

                if (ctdCnt < 1)
                {
                    MessageBox.Show(lueDoctor.Text + " is not sit " + cboOption.Text + ".", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    lueDoctor.Focus();

                    lblLastBookingTime.Text = string.Empty;
                    lblTokenNo.Text = string.Empty;
                }
                else
                {
                    takeTokenNoAndBookingTime();
                }
            }
        }

        private void dteBookingDate_EditValueChanged(object sender, EventArgs e)
        {
            dtBoooking = Convert.ToDateTime(dteBookingDate.EditValue.ToString());
            
            if (cboOption.Text.Length > 0 && doctorPK.ToString().Length > 0 && dteBookingDate.Text.Length > 0)
            {
                int ctdCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblClinicTimeByDoctor WHERE doctorPK=@DoctorPK AND clinicDay=@ClinicDay AND ctdOption=@CTDOption AND isDelete=0",
                                                    new SqlParameter("@DoctorPK", doctorPK),
                                                    new SqlParameter("@ClinicDay", dtBoooking.DayOfWeek.ToString()),
                                                    new SqlParameter("@CTDOption", cboOption.Text));

                if (ctdCnt < 1)
                {
                    MessageBox.Show(lueDoctor.Text + " is not sit " + cboOption.Text + ".", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dteBookingDate.Focus();

                    lblLastBookingTime.Text = string.Empty;
                    lblTokenNo.Text = string.Empty;
                }
                else
                {
                    takeTokenNoAndBookingTime();
                }
            }
        }

        private void cmdClinicTime_Click(object sender, EventArgs e)
        {
            if (doctorPK.Length > 0)
            {
                if (this.Height == 346)
                {
                    grpClinicTime.Visible = true;                    
                    widenStatus = true;
                    myTimer.Start();
                }

                if (this.Height == 503)
                {
                    grpClinicTime.Visible = false;
                    widenStatus = false;
                    myTimer.Start();
                }
            }
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            if (widenStatus == true)
            {
                this.Height += 1;

                if (this.Height > 502)
                    myTimer.Stop();
            }
            else if (widenStatus == false)
            {
                this.Height -= 1;

                if (this.Height < 347)
                    myTimer.Stop();
            }
        }

        private void cboOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOption.Text.Length > 0 && doctorPK.ToString().Length > 0 && dteBookingDate.Text.Length > 0)
            {
                int ctdCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblClinicTimeByDoctor WHERE doctorPK=@DoctorPK AND clinicDay=@ClinicDay AND ctdOption=@CTDOption AND isDelete=0",
                                                    new SqlParameter("@DoctorPK", doctorPK),
                                                    new SqlParameter("@ClinicDay", dtBoooking.DayOfWeek.ToString()),
                                                    new SqlParameter("@CTDOption", cboOption.Text));

                if (ctdCnt < 1)
                {
                    MessageBox.Show("This doctor is not sit " + cboOption.Text + ".", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cboOption.Focus();

                    lblLastBookingTime.Text = string.Empty;
                    lblTokenNo.Text = string.Empty;
                }
                else
                {
                    takeTokenNoAndBookingTime();
                }
            }
        }
    }
}
