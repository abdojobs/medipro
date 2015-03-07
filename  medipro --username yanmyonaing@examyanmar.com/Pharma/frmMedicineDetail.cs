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
using System.IO;
using System.Drawing.Imaging;
using Touchless.Vision.Camera;

namespace Pharma
{
    public partial class frmMedicineDetail : Form
    {
        clsSQL SqlDb = new clsSQL();
        bool captureStatus = false;
        public static int intMedPK = 0;
        WebCam webcam;
        private DataTable dtGridSource;

        public frmMedicineDetail()
        {
            InitializeComponent();

            DataSet dsChem = SqlDb.GetDataSet("SELECT chemNamePK, chemName FROM tblChemName WHERE isDelete = 0");
            cboChemPK.ValueMember = "chemNamePK";
            cboChemPK.DisplayMember = "chemName";
            cboChemPK.DataSource = dsChem.Tables[0];

            DataSet dsMedType = SqlDb.GetDataSet("SELECT medTypePK, medTypeName FROM tblMedType WHERE isDelete = 0");
            cboMedTypePK.ValueMember = "medTypePK";
            cboMedTypePK.DisplayMember = "medTypeName";
            cboMedTypePK.DataSource = dsMedType.Tables[0];

            DataSet dsSystem = SqlDb.GetDataSet("SELECT systemPK, systemName FROM tblBodySystem WHERE isDelete = 0");
            cboSystemPK.ValueMember = "systemPK";
            cboSystemPK.DisplayMember = "systemName";
            cboSystemPK.DataSource = dsSystem.Tables[0];

            DataSet dsManufacturer = SqlDb.GetDataSet("SELECT manuPK, manuName, manuCountry FROM tblManufacturer WHERE isDelete = 0");
            cboManuPK.ValueMember = "manuPK";
            cboManuPK.DisplayMember = "manuName";
            cboManuPK.DataSource = dsManufacturer.Tables[0];

            DataSet dsPackListTemp = SqlDb.GetDataSet("SELECT packListPK, packListName FROM tblPackListTemp WHERE isDelete = 0");
            cboPackListTemp.ValueMember = "packListPK";
            cboPackListTemp.DisplayMember = "packListName";
            cboPackListTemp.DataSource = dsPackListTemp.Tables[0];

            dtGridSource = SqlDb.GetDataSet("SELECT fromUnitPK, fromValue, toUnitPK, 1 toValue FROM  tblPackList WHERE medPK=" + intMedPK.ToString()).Tables[0];
            DataSet dsUnitFrom = SqlDb.GetDataSet("SELECT medUnitPK, medUnitName FROM  tblMedUnit  WHERE isDelete=0 ORDER BY medUnitName");
            DataSet dsUnitTo = SqlDb.GetDataSet("SELECT medUnitPK, medUnitName FROM  tblMedUnit  WHERE isDelete=0  ORDER BY medUnitName");


            gridPackList.DataSource = dtGridSource;
            resLookupFromUnit.DataSource = dsUnitFrom.Tables[0];
            resLookupToUnit.DataSource = dsUnitTo.Tables[0];

        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            webcam.Stop();

            this.Close();
        }
        
        private void frmMedicineDetail_Load(object sender, EventArgs e)
        {
            webcam = new WebCam();
            webcam.ImgControl = imgImage;
            LoadData();
        }

        private void imgMedicine_Click(object sender, EventArgs e)
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
            
            if (txtMedName.Text.Length < 1)
            {
                MessageBox.Show("Please enter the brand name.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
            }
            return value;
        }

        private void FormClean()
        {
            txtMedName.Text = string.Empty;
            txtIndicationEng.Text = string.Empty;
            txtIndicationMyan.Text = string.Empty;
            txtDosageEng.Text = string.Empty;
            txtDosageMyan.Text = string.Empty;
            if (imgImage.Image != null)
                imgImage.Image.Dispose();
                
        }


        private void cmdSave_Click(object sender, EventArgs e)
        {
            bool IsValid = false;
            string strErrMsg = "";            

            if (txtMedName.Text.Length > 0)
            {
                int DupCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblMedicine WHERE isDelete=0 AND medName='" + txtMedName.Text + "' AND medPK<>" + intMedPK.ToString());

                if (DupCnt > 0)
                {
                    IsValid = false;
                    strErrMsg += "Brand name is already exist.\n\r";
                }
                else
                {
                    IsValid = true;
                }
            }
            else
            {
                IsValid = false;
                strErrMsg += "Brand name must be filled.\n\r";
            }

            if (IsValid)
            {
                MemoryStream ms = new MemoryStream();

                if (null != imgImage.Image)
                {
                    imgImage.Image.Save(ms, ImageFormat.Jpeg);
                }

                //Read from MemoryStream into Byte array.
                Byte[] bytImgData = new Byte[ms.Length];
                ms.Position = 0;
                ms.Read(bytImgData, 0, Convert.ToInt32(ms.Length));

                if (intMedPK == 0)
                {
                    intMedPK = SqlDb.ExecuteScalar<int>("getID 'tblMedicine'");

                    SqlDb.ExecuteQuery("INSERT INTO tblMedicine(medPK,medName,medTypePK,chemNamePK,systemPK " +
                                       ",manuPK,indicationEng,indicationMyan,dosageEng,dosageMyan,isActive " +
                                       ",updatePK,updateDate,createPK,createDate,[image]) " +
                                       "VALUES(@medPK,@medName,@medTypePK,@chemNamePK,@systemPK " +
                                       ",@manuPK,@indicationEng,@indicationMyan,@dosageEng,@dosageMyan,@isActive " +
                                       ",@updatePK,SYSDATETIME(),@createPK,SYSDATETIME(),@image)",
                                                new SqlParameter("@medPK", intMedPK),
                                                new SqlParameter("@medName", txtMedName.Text.Trim()),
                                                new SqlParameter("@medTypePK", cboMedTypePK.SelectedValue),
                                                new SqlParameter("@chemNamePK", cboChemPK.SelectedValue),
                                                new SqlParameter("@systemPK", cboSystemPK.SelectedValue),
                                                new SqlParameter("@manuPK", cboManuPK.SelectedValue),
                                                new SqlParameter("@indicationEng", txtIndicationEng.Text.Trim()),
                                                new SqlParameter("@indicationMyan", txtIndicationMyan.Text.Trim()),
                                                new SqlParameter("@dosageEng", txtDosageEng.Text.Trim()),
                                                new SqlParameter("@dosageMyan", txtDosageMyan.Text.Trim()),
                                                new SqlParameter("@isActive", chkIsActive.EditValue),
                                                new SqlParameter("@updatePK", AppVariable.CURRENT_USER_PK),
                                                new SqlParameter("@createPK", AppVariable.CURRENT_USER_PK),
                                                new SqlParameter("@image", SqlDbType.VarBinary, bytImgData.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, bytImgData));


                    



                    DialogResult dr = MessageBox.Show("The medicine has been saved successfully. Do you want to create other medicine?", "MediPro :: Clinic System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        FormClean();

                        txtMedName.Focus();
                    }



                }
                else
                {

                    SqlDb.ExecuteQuery("UPDATE tblMedicine SET medName=@medName, medTypePK=@medTypePK, chemNamePK=@chemNamePK, systemPK=@systemPK " +
                                       ",manuPK=@manuPK, indicationEng=@indicationEng, indicationMyan=@indicationMyan, dosageEng=@dosageEng " +
                                       ",dosageMyan=@dosageMyan, isActive=@isActive, updatePK=@updatePK,updateDate=SYSDATETIME(),[image]=@image " ,
                                                new SqlParameter("@medPK", intMedPK),
                                                new SqlParameter("@medName", txtMedName.Text.Trim()),
                                                new SqlParameter("@medTypePK", cboMedTypePK.SelectedValue),
                                                new SqlParameter("@chemNamePK", cboChemPK.SelectedValue),
                                                new SqlParameter("@systemPK", cboSystemPK.SelectedValue),
                                                new SqlParameter("@manuPK", cboManuPK.SelectedValue),
                                                new SqlParameter("@indicationEng", txtIndicationEng.Text.Trim()),
                                                new SqlParameter("@indicationMyan", txtIndicationMyan.Text.Trim()),
                                                new SqlParameter("@dosageEng", txtDosageEng.Text.Trim()),
                                                new SqlParameter("@dosageMyan", txtDosageMyan.Text.Trim()),
                                                new SqlParameter("@isActive", chkIsActive.EditValue),
                                                new SqlParameter("@updatePK", AppVariable.CURRENT_USER_PK),
                                                new SqlParameter("@image", SqlDbType.VarBinary, bytImgData.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, bytImgData));


                    MessageBox.Show("The medicine has been saved successfully.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                SqlDb.ExecuteQuery("DELETE FROM tblPackList WHERE packlistPK=" + intMedPK.ToString());

                foreach (DataRow drSave in dtGridSource.Rows)
                {
                    if (drSave.RowState != DataRowState.Deleted)
                    {
                        int intFromUnit = int.Parse(drSave["fromUnitPK"].ToString());
                        int intToUnit = int.Parse(drSave["toUnitPK"].ToString());
                        if ((intFromUnit > 0) && (intToUnit > 0))
                        {
                            SqlDb.ExecuteQuery("INSERT INTO tblPackList(medPK, toUnitPK, fromUnitPK, fromValue)" +
                                            " VALUES(" + intMedPK.ToString() + "," + drSave["toUnitPK"].ToString() + "," + drSave["fromUnitPK"].ToString() + "," +
                                            drSave["fromValue"].ToString() + ")");
                        }
                    }


                }




            }
            else
            {
                MessageBox.Show(strErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            if (intMedPK > 0)
            {
                DataSet dsMedicine = SqlDb.GetDataSet("SELECT * FROM tblMedicine WHERE medPK = @medPK", new SqlParameter("@medPK", intMedPK));
                int DataRowCnt = dsMedicine.Tables[0].Rows.Count;

                if (DataRowCnt > 0)
                {
                    try
                    {
                        txtMedName.Text = dsMedicine.Tables[0].Rows[0]["medName"].ToString();
                        cboChemPK.SelectedValue = dsMedicine.Tables[0].Rows[0]["chemNamePK"];
                        cboSystemPK.SelectedValue = dsMedicine.Tables[0].Rows[0]["systemPK"];
                        cboMedTypePK.SelectedValue = dsMedicine.Tables[0].Rows[0]["medTypePK"];
                        cboManuPK.SelectedValue = dsMedicine.Tables[0].Rows[0]["manuPK"];

                        txtIndicationEng.Text = dsMedicine.Tables[0].Rows[0]["indicationEng"].ToString();
                        txtIndicationMyan.Text = dsMedicine.Tables[0].Rows[0]["indicationEng"].ToString();

                        txtDosageEng.Text = dsMedicine.Tables[0].Rows[0]["dosageEng"].ToString();
                        txtDosageMyan.Text = dsMedicine.Tables[0].Rows[0]["dosageMyan"].ToString();

                        chkIsActive.Checked = bool.Parse(dsMedicine.Tables[0].Rows[0]["isActive"].ToString());

                        
                        Byte[] byteMedicineData = new Byte[0];
                        byteMedicineData = (Byte[])(dsMedicine.Tables[0].Rows[0]["image"]);
                        MemoryStream ms = new MemoryStream(byteMedicineData);

                        if (ms.Length > 0)
                        {
                            imgImage.Image = Image.FromStream(ms);
                        }


                        dtGridSource = SqlDb.GetDataSet("SELECT fromUnitPK, fromValue, toUnitPK, 1 toValue FROM  tblPackList WHERE medPK=" + intMedPK.ToString()).Tables[0];


                        gridPackList.DataSource = dtGridSource;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnAddPackListTemp_Click(object sender, EventArgs e)
        {
            DataTable dtTemp = SqlDb.GetDataSet("SELECT fromUnitPK, fromValue, toUnitPK, 1 toValue FROM  tblPackListTempDetail WHERE packListPK=" + cboPackListTemp.SelectedValue.ToString()).Tables[0];

            dtGridSource.Merge(dtTemp);

            gridPackList.DataSource = dtGridSource;
        }

        private void btnDeletUnit_Click(object sender, EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
            DataView dvSource = (DataView)gridView1.DataSource;
            DataTable dtSource = dvSource.Table;
            dtGridSource = dtSource;
        }       
    }
}
