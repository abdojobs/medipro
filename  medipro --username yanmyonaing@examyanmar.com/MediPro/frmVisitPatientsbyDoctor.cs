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
using System.Drawing.Imaging;
using Touchless.Vision.Camera;

namespace MediPro
{
    public partial class frmVisitPatientsbyDoctor : Form
    {
        clsSQL SqlDb = new clsSQL();

        private string _selectVisitPatient;
        string regNo= string.Empty;
        DataRow drPatient;

        public frmVisitPatientsbyDoctor()
        {
            InitializeComponent();
        }

        public string selectVisitPatientPK
        {
            get { return _selectVisitPatient; }
            set { _selectVisitPatient = value; }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            _selectVisitPatient = string.Empty;
            this.Close();
        }

        private void frmVisitPatientsbyDoctor_Load(object sender, EventArgs e)
        {
            BindingVisiting();
        }

        private void BindingVisiting()
        {
            DateTime curDate = SqlDb.ExecuteScalar<DateTime>("SELECT GETDATE()");

            int curDoctorPK = SqlDb.ExecuteScalar<int>("SELECT doctorPK FROM tblDoctor WHERE userPK = @UserPK",
                                                        new MySqlParameter("@UserPK", AppVariable.CURRENT_USER_PK));

            DataSet dsVisiting = SqlDb.GetDataSet("SELECT PK, patientName, RegNo, (tblTitle.TitleName + ' ' + tblDoctor.doctor) As doctorName, " +
                                                "abdate, tokenNo, abTime, abType, isVisited, isNew, (tblBooking.doctorPK) As doctorPK, visitPK FROM tblDoctor INNER JOIN tblBooking ON tblDoctor.doctorPK = tblBooking.doctorPK INNER JOIN tblTitle " +
                                                "ON tblDoctor.titlePK = tblTitle.titlePK WHERE abdate = @abDate AND tblBooking.doctorPK=@DoctorPK",
                                                new MySqlParameter("@abDate", curDate.ToString("yyyy-MM-dd")),
                                                new MySqlParameter("@DoctorPK", curDoctorPK));

            grdTodayVisitPatients.DataSource = dsVisiting.Tables[0];
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            //if (grdViewTodayVisitPatients.RowCount > 0)
                _selectVisitPatient = regNo;

            this.Close();
        }

        private void LoadImage()
        {
            if (regNo.Length > 0)
            {
                DataSet dsPatient = SqlDb.GetDataSet("SELECT * FROM tblPatient WHERE RegNo = @RegNo", new MySqlParameter("@RegNo", regNo));
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
                            imgPatient.Image = Image.FromStream(ms);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void grdViewTodayVisitPatients_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (grdViewTodayVisitPatients.RowCount > 0)
            {
                drPatient = grdViewTodayVisitPatients.GetDataRow(grdViewTodayVisitPatients.FocusedRowHandle);
            }
        }

        private void grdViewTodayVisitPatients_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (grdViewTodayVisitPatients.RowCount > 0)
            {
                regNo = drPatient.ItemArray[2].ToString();
                LoadImage();
            }
            else
            {
                regNo = string.Empty;
            }            
        }
    }
}
