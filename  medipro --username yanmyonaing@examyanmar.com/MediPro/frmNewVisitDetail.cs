using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using exaCore;

namespace MediPro
{
    public partial class frmNewVisitDetail : Form
    {
        DataSet dsPatient;
        string RegNo = string.Empty;
        clsSQL SqlDb = new clsSQL();
        DataSet dsDoctor;
        DateTime dtVisit;

        public frmNewVisitDetail()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void luePatient_EditValueChanged(object sender, EventArgs e)
        {
            RegNo = luePatient.EditValue.ToString();

            PatientDataLoadWithRegNo();
        }

        private void LoadLuePatient()
        {
            dsPatient = SqlDb.GetDataSet("SELECT RegNo, (TitleName + ' ' + Name) As Name, Convert( varchar,DOB, 105) As DOB, FatherName, NRC FROM tblPatient INNER JOIN tblTitle ON tblPatient.titlePK = tblTitle.titlePK WHERE tblPatient.isDelete = 0");
            luePatient.Properties.DataSource = dsPatient.Tables[0];
        }

        private void PatientDataLoadWithRegNo()
        {
            DataSet dsCurPatient = SqlDb.GetDataSet("SELECT RegNo, Name, Convert(varchar, DOB, 105) As DOBDisplay, DOB, FatherName, NRC, Gender, Photo FROM tblPatient WHERE isDelete = 0 AND RegNo=@RegNo", new MySqlParameter("@RegNo", RegNo));

            txtRegNo.Text = dsCurPatient.Tables[0].Rows[0]["RegNo"].ToString();
            txtFatherName.Text = dsCurPatient.Tables[0].Rows[0]["FatherName"].ToString();
            txtDOB.Text = dsCurPatient.Tables[0].Rows[0]["DOBDisplay"].ToString();
            txtSex.Text = dsCurPatient.Tables[0].Rows[0]["Gender"].ToString();
            txtNRC.Text = dsCurPatient.Tables[0].Rows[0]["NRC"].ToString();

            string dtDOB = dsCurPatient.Tables[0].Rows[0]["DOB"].ToString();

            if (dtDOB.Length > 0)
                txtAge.Text = Helper.CalAge(DateTime.Parse(dtDOB));

            LoadImage();
        }

        void VisitDataLoadWithVisitPK()
        {
            DataSet dsCurVisit = SqlDb.GetDataSet("SELECT Convert(varchar,visitDate, 111) As visitDate, visitDescription, doctorPK, visitWeight, visitFeet, inch, bloodType FROM tblVisit WHERE visitPK=@VisitPK", new MySqlParameter("@VisitPK", dteVisitDate.Tag.ToString()));

            dteVisitDate.EditValue = dsCurVisit.Tables[0].Rows[0]["visitDate"].ToString();
            lueDoctor.EditValue = dsCurVisit.Tables[0].Rows[0]["doctorPK"].ToString();
            cboBloodType.Text = dsCurVisit.Tables[0].Rows[0]["bloodType"].ToString();
            txtWeight.Text = dsCurVisit.Tables[0].Rows[0]["visitWeight"].ToString();
            txtft.Text = dsCurVisit.Tables[0].Rows[0]["visitFeet"].ToString();
            txtin.Text = dsCurVisit.Tables[0].Rows[0]["inch"].ToString();
            txtDescription.Text = dsCurVisit.Tables[0].Rows[0]["visitDescription"].ToString();

            luePatient.Properties.ReadOnly = true;
        }

        private void LoadImage()
        {
            if (txtRegNo.Text.ToString().Length > 0)
            {
                DataSet dsPatient = SqlDb.GetDataSet("SELECT * FROM tblPatient WHERE RegNo = @RegNo", new MySqlParameter("@RegNo", RegNo));
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

        private void LoadLueDoctor()
        {
            dsDoctor = SqlDb.GetDataSet("SELECT doctorPK, (TitleName + ' ' + doctor) AS doctor, position, specialize FROM tblDoctor INNER JOIN tblPosition ON tblDoctor.positionPK = tblPosition.positionPK INNER JOIN tblSpecialize ON tblDoctor.specializePK = tblSpecialize.specializePK INNER JOIN tblTitle ON tblDoctor.titlePK = tblTitle.titlePK WHERE (tblDoctor.isActive = 1)");
            lueDoctor.Properties.DataSource = dsDoctor.Tables[0];
        }        

        private void frmNewVisit_Load(object sender, EventArgs e)
        {
            LoadLueDoctor();
            LoadLuePatient();

            if (dteVisitDate.Tag.ToString() != "Add")
            {
                VisitDataLoadWithVisitPK();
            }
        }        

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedChar = "0123456789";

            if ((allowedChar.IndexOf(e.KeyChar) == -1) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedChar = "0123456789";

            if ((allowedChar.IndexOf(e.KeyChar) == -1) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            if (txtft.Text.Length > 0 && txtWeight.Text.Length > 0)
            {
                int inch = int.Parse(txtft.Text.Trim()) * 12;

                if (txtin.Text.Length > 0)
                    inch = inch + int.Parse(txtin.Text.Trim());

                Helper.BMIResult(txtBMI, lblBMI, int.Parse(txtWeight.Text.Trim()), inch);
            }
        }

        private void txtft_TextChanged(object sender, EventArgs e)
        {
            if (txtft.Text.Length > 0 && txtWeight.Text.Length > 0)
            {
                int inch = int.Parse(txtft.Text.Trim()) * 12;

                if (txtin.Text.Length > 0)
                    inch = inch + int.Parse(txtin.Text.Trim());

                Helper.BMIResult(txtBMI, lblBMI, int.Parse(txtWeight.Text.Trim()), inch);
            }
        }

        private void txtin_TextChanged(object sender, EventArgs e)
        {
            if (txtft.Text.Length > 0 && txtWeight.Text.Length > 0)
            {
                int inch = int.Parse(txtft.Text.Trim()) * 12;

                if (txtin.Text.Length > 0)
                    inch = inch + int.Parse(txtin.Text.Trim());

                Helper.BMIResult(txtBMI, lblBMI, int.Parse(txtWeight.Text.Trim()), inch);
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == true)
            {
                int visitCnt = 0;
                
                if (cmdSave.Tag.ToString().Length > 0)
                {
                    visitCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblVisit WHERE visitPK=@VisitPK",
                                                            new MySqlParameter("@VisitPK", dteVisitDate.Tag.ToString()));
                }

                if (visitCnt < 1)
                {
                    string VisitPK = SqlDb.ExecuteScalar<string>("getVisitNo N'tblVisit','" + dtVisit.ToString("yyyy-MM-dd") + "'");

                    SqlDb.ExecuteQuery("INSERT INTO tblVisit(visitPK,RegNo,visitDate,visitDescription,doctorPK,visitWeight,visitFeet,inch,bmi,bloodType,createPK,createDate) " +
                                                    "VALUES(@VisitPK,@RegNo,@VisitDate,@VisitDescription,@DoctorPK,@VisitWeight,@VisitFeet,@Inch,@BMI,@BloodType,@CreatePK,NOW())",
                                                    new MySqlParameter("@VisitPK", VisitPK),
                                                    new MySqlParameter("@RegNo", txtRegNo.Text.Trim()),
                                                    new MySqlParameter("@VisitDate", dtVisit.ToString("yyyy-MM-dd")),
                                                    new MySqlParameter("@VisitDescription", txtDescription.Text),
                                                    new MySqlParameter("@DoctorPK", lueDoctor.EditValue),
                                                    new MySqlParameter("@VisitWeight", txtWeight.Text),
                                                    new MySqlParameter("@VisitFeet", txtft.Text),
                                                    new MySqlParameter("@Inch", txtin.Text),
                                                    new MySqlParameter("@BMI", txtBMI.Text),
                                                    new MySqlParameter("@BloodType", cboBloodType.Text),
                                                    new MySqlParameter("@CreatePK", AppVariable.CURRENT_USER_PK));

                    SqlDb.ExecuteQuery("UPDATE tblBooking SET doctorPK=@DoctorPK,visitPK=@VisitPK, isVisited=1 WHERE PK=@PK", 
                                        new MySqlParameter("@PK", cmdSave.Tag.ToString()),
                                        new MySqlParameter("@DoctorPK", lueDoctor.EditValue),
                                        new MySqlParameter("@VisitPK", VisitPK));

                    sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Add New Visit.");

                    MessageBox.Show("Save is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SqlDb.ExecuteQuery("UPDATE tblVisit SET RegNo=@RegNo,visitDate=@VisitDate,visitDescription=@VisitDescription,"+
                                        "doctorPK=@DoctorPK,visitWeight=@VisitWeight,visitFeet=@VisitFeet,inch=@Inch,bmi=@BMI,bloodType=@BloodType," +
                                        "updateDate=NOW(),updatePK=@UpdatePK WHERE visitPK=@VisitPK",
                                        new MySqlParameter("@VisitPK", dteVisitDate.Tag.ToString()),
                                        new MySqlParameter("@RegNo", txtRegNo.Text.Trim()),
                                        new MySqlParameter("@VisitDate", dtVisit.ToString("yyyy-MM-dd")),
                                        new MySqlParameter("@VisitDescription", txtDescription.Text),
                                        new MySqlParameter("@DoctorPK", lueDoctor.EditValue),
                                        new MySqlParameter("@VisitWeight", txtWeight.Text),
                                        new MySqlParameter("@VisitFeet", txtft.Text),
                                        new MySqlParameter("@Inch", txtin.Text),
                                        new MySqlParameter("@BMI", txtBMI.Text),
                                        new MySqlParameter("@BloodType", cboBloodType.Text),
                                        new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK));

                    sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Update Visit.");

                    MessageBox.Show("Update is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }                
            }
        }

        void CleanForm()
        {
            cmdSave.Tag = string.Empty;
            dteVisitDate.Tag = string.Empty;
            txtRegNo.Text = string.Empty;
            dteVisitDate.EditValue = string.Empty;
            luePatient.EditValue = string.Empty;
            txtFatherName.Text = string.Empty;
            txtNRC.Text = string.Empty;
            txtDOB.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtBMI.Text = string.Empty;
            txtft.Text = string.Empty;
            txtin.Text = string.Empty;
            txtSex.Text = string.Empty;
            txtWeight.Text = string.Empty;
            lueDoctor.EditValue = string.Empty;
            txtDescription.Text = string.Empty;
       }

        private void txtft_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedChar = "0123456789";

            if ((allowedChar.IndexOf(e.KeyChar) == -1) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtin_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedChar = "0123456789";

            if ((allowedChar.IndexOf(e.KeyChar) == -1) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        bool ValidateForm()
        {
            bool value = true;

            if (luePatient.Text.Length < 1)
            {
                MessageBox.Show("Please enter Patient's Name.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                luePatient.Focus();
            }
            else if (lueDoctor.Text.Length < 1)
            {
                MessageBox.Show("Please enter Doctor's Name.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                lueDoctor.Focus();
            }
            else if (txtWeight.Text.Length < 1)
            {
                MessageBox.Show("Please enter weight.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                txtWeight.Focus();
            }
            else if (txtft.Text.Length < 1)
            {
                MessageBox.Show("Please enter feet of Height.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                txtft.Focus();
            }
            else if (txtin.Text.Length < 1)
            {
                MessageBox.Show("Please enter inch of Height.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                txtin.Focus();
            }
            else if (dteVisitDate.Text.Length < 1)
            {
                MessageBox.Show("Please enter Visit Date.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                dteVisitDate.Focus();
            }

            return value;
        }

        private void dteVisitDate_EditValueChanged(object sender, EventArgs e)
        {
            dtVisit = DateTime.Parse(dteVisitDate.EditValue.ToString());
        }

        private void txtin_Leave(object sender, EventArgs e)
        {
            int visitInch = int.Parse(txtin.Text.ToString());

            if (visitInch > 12)
                MessageBox.Show("Inch value is invalid. " + System.Environment.NewLine +  "Note : (1 feet = 12 inch)", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error); txtin.Focus();
        }
    }
}
