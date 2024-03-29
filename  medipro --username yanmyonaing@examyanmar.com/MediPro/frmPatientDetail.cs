﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
//using WebCamLib;
using exaCore;
using System.IO;
using System.Drawing.Imaging;
//using Touchless.Vision.Camera;

namespace MediPro
{
    public partial class frmPatientDetail : Form
    {
        clsSQL SqlDb = new clsSQL();
        bool captureStatus = false;
        WebCam webcam;

        public frmPatientDetail()
        {
            InitializeComponent();
            
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            webcam.Stop();

            this.Close();
        }
        
        private void frmPatientDetail_Load(object sender, EventArgs e)
        {
            webcam = new WebCam();
            webcam.ImgControl = imgPatient;

            BindingTitle();

            if (cmdSave.Tag.ToString() == "Add")
                FormClean("Add");

            if (cmdSave.Tag.ToString() == "View")
            {
                cboTitle.SelectedValue = cboTitle.Tag.ToString();

                LoadImage();

                FormClean("View");
            }

            if (cmdSave.Tag.ToString() == "Edit")
            {
                FormClean("Edit");
                cboTitle.SelectedValue = cboTitle.Tag.ToString();

                LoadImage();
            }

            if (cmdSave.Tag.ToString() == "Booked")
            {
                FormClean("Booked");
                txtName.ReadOnly = true;
            }

            DrawBarcode(txtName.Text, dteDOB.Text, txtRegNo.Text, this.imgBarcode);
        }

        private void imgPatient_Click(object sender, EventArgs e)
        {
            if (captureStatus == false)
            {
                webcam.Start();
                captureStatus = true;
            }
            else if (captureStatus == true)
            {
                webcam.Stop();
                captureStatus = false;
            }
        }

        private bool ValidateForm()
        {
            bool value = true;
            if (dteRegDate.Text.Length < 1)
            {
                MessageBox.Show("Please enter Registeration Date.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
            }
            else if (txtName.Text.Length < 1)
            {
                MessageBox.Show("Please enter Patient's Name.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
            }
            else if (cboTitle.Text.Length < 1)
            {
                MessageBox.Show("Please select Title.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
            }
            else if (cboGender.Text.Length < 1)
            {
                MessageBox.Show("Please select Gender.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
            }
            else if (dteDOB.Text.Length < 1)
            {
                MessageBox.Show("Please enter date of birth.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
            }
            else if (txtFatherName.Text.Length < 1)
            {
                MessageBox.Show("Please enter Father's Name.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
            }

            return value;
        }

        private void FormClean(string Status)
        {
            if (Status == "Add")
            {
                dteRegDate.Text = string.Empty;
                dteRegDate.EditValue = DateTime.Now.Date;

                txtRegNo.Text = string.Empty;
                txtName.Text = string.Empty;
                txtNRC.Text = string.Empty;
                txtFatherName.Text = string.Empty;
                dteDOB.Text = string.Empty;
                txtAge.Text = string.Empty;
                txtContactNo.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtAddress.Text = string.Empty;
                cboTitle.SelectedIndex = -1;
                if (imgPatient.Image != null)
                    imgPatient.Image.Dispose();

                cboGender.SelectedIndex = -1;
            }
            else if (Status == "Booked")
            {
                dteRegDate.Text = string.Empty;
                dteRegDate.EditValue = DateTime.Now.Date;

                txtRegNo.Text = string.Empty;
                //txtName.Text = string.Empty;
                txtNRC.Text = string.Empty;
                txtFatherName.Text = string.Empty;
                dteDOB.Text = string.Empty;
                txtAge.Text = string.Empty;
                txtContactNo.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtAddress.Text = string.Empty;
                cboTitle.SelectedIndex = -1;
                if (imgPatient.Image != null)
                    imgPatient.Image.Dispose();

                cboGender.SelectedIndex = -1;
            }
            else if (Status == "Edit")
            {
                //dteRegDate.Properties.ReadOnly = true;
                dteRegDate.Enabled = false;

                if (imgPatient.Image != null)
                    imgPatient.Image.Dispose();
            }
            else if (Status == "View")
            {
                //dteRegDate.Properties.ReadOnly = true;
                dteRegDate.Enabled = false;
                txtRegNo.ReadOnly = true;
                txtName.ReadOnly = true;
                txtNRC.ReadOnly = true;
                txtFatherName.ReadOnly = true;
                //dteDOB.Properties.ReadOnly = true;
                dteDOB.Enabled = false;
                txtAge.ReadOnly = true;
                txtContactNo.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtAddress.ReadOnly = true;
                imgPatient.Enabled = false;
                cboGender.Enabled = false;
                cmdSave.Visible = false;
                cboTitle.Enabled = false;
            }
                
        }

        private void BindingTitle()
        {
            DataSet dsTitle = SqlDb.GetDataSet("SELECT titlePK, TitleName FROM tblTitle WHERE isActive = 1");

            try
            {
                cboTitle.DataSource = dsTitle.Tables[0];
                cboTitle.DisplayMember = "TitleName";
                cboTitle.ValueMember = "titlePK";
                cboTitle.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dteDOB_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == true)
            {
                int PatientCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblPatient WHERE RegNo=@RegNo AND isDelete=0", new MySqlParameter("@RegNo", txtRegNo.Text.Trim()));
                                
                    //Save image from PictureBox into MemoryStream object.
                    MemoryStream ms = new MemoryStream();

                    if (null != imgPatient.Image)
                    {
                        imgPatient.Image.Save(ms, ImageFormat.Jpeg);
                    }

                    //Read from MemoryStream into Byte array.
                    Byte[] bytImgData = new Byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(bytImgData, 0, Convert.ToInt32(ms.Length));
                

                if (PatientCnt > 0)
                {
                    if (txtRegNo.Text.ToString().Length > 0)
                    {
                        int RegNoCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblPatient WHERE RegNo=@RegNo AND isDelete=0", new MySqlParameter("@RegNo", txtRegNo.Text.ToString()));

                        if (RegNoCnt > 0)
                        {
                            SqlDb.ExecuteQuery("UPDATE tblPatient SET name=@Name,NRC=@NRC,titlePK=@TitlePK,FatherName=@FatherName,DOB=@DOB,Gender=@Gender,Photo=@Photo, " +
                                            "Phone=@Phone,email=@Email,Address=@Address,updateDate=NOW() WHERE RegNo=@RegNo",
                                            new MySqlParameter("@RegNo", txtRegNo.Text.Trim()),
                                            new MySqlParameter("@titlePK", cboTitle.SelectedValue),
                                            new MySqlParameter("@name", txtName.Text.Trim()),
                                            new MySqlParameter("@NRC", txtNRC.Text.Trim()),
                                            new MySqlParameter("@Gender", cboGender.Text.Trim()),
                                            new MySqlParameter("@FatherName", txtFatherName.Text.Trim()),
                                            new MySqlParameter("@DOB", dteDOB.DateTime),
                                            new MySqlParameter("@Phone", txtContactNo.Text.Trim()),
                                            new MySqlParameter("@Email", txtEmail.Text.Trim()),
                                            new MySqlParameter("@Address", txtAddress.Text.Trim()),
                                            new MySqlParameter("@Photo", MySqlDbType.VarBinary, bytImgData.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, bytImgData),
                                            new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Update Patient Info");

                            MessageBox.Show("Update is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    DateTime dtToday = DateTime.Parse(dteRegDate.EditValue.ToString());
                    string strToday = dtToday.ToString("yyyy-MM-dd");
                    txtRegNo.Text = SqlDb.ExecuteScalar<string>("Call getRegNo (N'tblPatient','" + strToday + "')");

                    //int CurUserID = SqlDb.ExecuteScalar<int>("getRegNo tblPatient N'");

                    int RegNoCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblPatient WHERE RegNo=@RegNo AND isDelete=0", new MySqlParameter("@RegNo", txtRegNo.Text.Trim()));

                    if (RegNoCnt < 1)
                    {
                        SqlDb.ExecuteQuery("INSERT INTO tblPatient(RegNo,RegDate,name,Photo,NRC,titlePK,FatherName,DOB,Gender,Phone,email,Address,createPK,createDate)" +
                                            "VALUES(@RegNo,@RegDate,@Name,@Photo,@NRC,@TitlePK,@FatherName,@DOB,@Gender,@Phone,@Email,@Address,@CreatePK,NOW())",
                                            new MySqlParameter("@RegDate", dteRegDate.EditValue),
                                            new MySqlParameter("@RegNo", txtRegNo.Text.Trim()),
                                            new MySqlParameter("@name", txtName.Text.Trim()),
                                            new MySqlParameter("@Photo", MySqlDbType.VarBinary, bytImgData.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, bytImgData),
                                            new MySqlParameter("@NRC", txtNRC.Text.Trim()),
                                            new MySqlParameter("@titlePK", cboTitle.SelectedValue),
                                            new MySqlParameter("@FatherName", txtFatherName.Text.Trim()),
                                            new MySqlParameter("@DOB", dteDOB.EditValue),
                                            new MySqlParameter("@Gender", cboGender.Text.Trim()),
                                            new MySqlParameter("@Phone", txtContactNo.Text.Trim()),
                                            new MySqlParameter("@Email", txtEmail.Text.Trim()),
                                            new MySqlParameter("@Address", txtAddress.Text.Trim()),
                                            new MySqlParameter("@CreatePK", AppVariable.CURRENT_USER_PK));

                        sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Register New Patient");

                        if (cmdSave.Tag.ToString() == "Booked")
                        {
                            SqlDb.ExecuteQuery("UPDATE tblBooking SET RegNo=@RegNo,patientName=@PatientName,isNew=1 WHERE PK=@BookingPK",
                                            new MySqlParameter("@RegNo", txtRegNo.Text.Trim()),
                                            new MySqlParameter("@PatientName", txtName.Text.Trim()),
                                            new MySqlParameter("@BookingPK", txtName.Tag.ToString()));
                        }

                        DialogResult dr = MessageBox.Show("Save is successful. Do you want to register new patient?", "MediPro :: Clinic System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (dr == DialogResult.Yes)
                        {

                            FormClean("Add");
                            dteRegDate.Focus();
                        }
                        else
                        {
                            DrawBarcode(txtName.Text, dteDOB.Text, txtRegNo.Text, imgBarcode);
                        }
                        
                    }
                }
            }
        }

        private void LoadImage()
        {
            if (txtRegNo.Text.ToString().Length > 0)
            {
                DataSet dsPatient = SqlDb.GetDataSet("SELECT * FROM tblPatient WHERE RegNo = @RegNo", new MySqlParameter("@RegNo", txtRegNo.Text.Trim()));
                int DataRowCnt = dsPatient.Tables[0].Rows.Count;

                if (DataRowCnt > 0)
                {
                    try
                    {
                        byte[] bytePatientData = new byte[0];
                        bytePatientData = (byte[])(dsPatient.Tables[0].Rows[0]["Photo"]);
                        MemoryStream ms = new MemoryStream(bytePatientData);

                        if (ms.Length > 0)
                        {
                            imgPatient.Image = Image.FromStream(ms);
                        }
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedChar = "0123456789-,()";

            if ((allowedChar.IndexOf(e.KeyChar) == -1) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void lblPatientName_Click(object sender, EventArgs e)
        {

        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            //int nameCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblPatient WHERE Name=@Name AND isDelete=0", new MySqlParameter("@Name", txtName.Text.Trim()));

            //if (nameCnt > 0)
            //{
            //    MessageBox.Show("Patient Name is already exit. Please check your patient name.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    lblPatientName.ForeColor = Color.Red;

            //    //frmPatientSearch PatientSearchForm = new frmPatientSearch();

            //    ////PatientSearchForm.TopMost = true;
            //    //PatientSearchForm.ShowDialog();


            //}
        }

        public static Font barcodeFont = new Font("3 of 9 Barcode", 15);
        public static Font textFont = new Font("Zawgyi-One", 5);
        private void cmdPrint_Click(object sender, EventArgs e)
        {
            dsBarcode ds = new dsBarcode();
            
            for (int i = 0; i < Convert.ToInt32(txtCopies.Text); i++)
            {
                dsBarcode.dtBarcodeRow dr = ds.dtBarcode.NewdtBarcodeRow();
                MemoryStream ms = new MemoryStream();
                imgBarcode.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                dr.Barcode = ms.ToArray();
                dr.DOB = dteDOB.Text;
                dr.Name = txtName.Text;
                dr.RegNo = txtRegNo.Text;
                dr.BarcodeText = "*" + txtRegNo.Text + "*";

                ds.dtBarcode.Rows.Add(dr);
            }

            rptBarcode rpt = new rptBarcode();
            rpt.SetDataSource(ds);

            new frmReportViewer(rpt).Show();
        }

        public void DrawBarcode(string patientName, string dob, string barcode, PictureBox img)
        {
            Image bmp = new Bitmap(imgBarcode.Width, imgBarcode.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(img.BackColor);
            Brush br = new SolidBrush(Color.Black);
            //Name and DOB
            //g.DrawString(patientName + " - " + dob, textFont, br, 0, 0);

            //Real Barcode
            g.DrawString("*"+barcode+"*", barcodeFont, br, 0, 5);

            //Barcode with normal Font
            //g.DrawString(barcode, textFont, br, 0, 28);


            imgBarcode.Image = bmp;

        }

        private void frmPatientDetail_Paint(object sender, PaintEventArgs e)
        {
            DrawBarcode(txtName.Text, dteDOB.Text, txtRegNo.Text, imgBarcode);
        }

        private void dteDOB_Leave(object sender, EventArgs e)
        {
            if (dteDOB.DateTime != null)
            {
                txtAge.Text = Helper.CalAge(dteDOB.DateTime);
            }
            if (txtRegNo.Text.Trim() == "")
            {
                int nameCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblPatient WHERE Name=@Name AND Date(DOB)=Date(@DOB)  AND isDelete=0", new MySqlParameter("@Name", txtName.Text.Trim()), new MySqlParameter("@DOB", dteDOB.DateTime.Date));

                if (nameCnt > 0)
                {
                    MessageBox.Show("Patient with same name and date of birth already exited. Please check your patient info again.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblPatientName.ForeColor = Color.Red;
                }
            }
        }
    }
}
