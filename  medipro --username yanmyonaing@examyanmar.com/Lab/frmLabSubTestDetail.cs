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

namespace Lab
{
    public partial class frmLabSubTestDetail : Form
    {
        clsSQL SqlDb = new clsSQL();

        public frmLabSubTestDetail()
        {
            InitializeComponent();
            cboLabTest.DataSource = SqlDb.GetDataSet("Select labTestPK,labTestName from tbllabTest").Tables[0];
            cboLabTest.DisplayMember = "labTestName";
            cboLabTest.ValueMember = "labTestPK";
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == true)
            {
                int Cnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblLabSubTest WHERE labSubTestName=@LabSubTestName AND isDelete=0 AND labSubTestPK<>@labSubTestPK", new MySqlParameter("@LabSubTestName", txtCode.Text.Trim()), new MySqlParameter("@labSubTestPK", txtCode.Tag.ToString()));

                if (Cnt > 0)
                {
                    MessageBox.Show("Your Lab Sub Test Name is already exit. Please check your Lab Sub Test Name.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCode.Focus();
                    txtCode.SelectAll();
                }
                else
                {
                    if (txtCode.Tag.ToString().Length > 0)
                    {
                        int LabIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblLabSubTest WHERE labSubTestPK=@labSubTestPK AND isDelete=0", new MySqlParameter("@labSubTestPK", txtCode.Tag.ToString()));

                        if (LabIDCnt > 0)
                        {
                            SqlDb.ExecuteQuery("UPDATE tblLabSubTest SET labTestPK=@labTestPK, labSubTestCode=@labSubTestCode, labSubTestName=@LabSubTestName,labSubTestDescription=@labSubTestDescription,specimen=@specimen,information=@information,reference=@reference,tat=@tat,method=@method,daysSetup=@daysSetup,clinicalUsage=@clinicalUsage,"+
                                                "isActive=@IsActive,updateDate=NOW(),updatePK=@UpdatePK WHERE labSubTestPK=@labSubTestPK",
                                            new MySqlParameter("@labTestPK",cboLabTest.SelectedValue),
                                            new MySqlParameter("@labSubTestPK", int.Parse(txtCode.Tag.ToString())),
                                            new MySqlParameter("@labSubTestCode", txtCode.Text.Trim()),
                                            new MySqlParameter("@labSubTestName", txtName.Text.Trim()),
                                            new MySqlParameter("@labSubTestDescription", txtDescription.Text.Trim()),
                                            new MySqlParameter("@specimen", txtSpecimen.Text.Trim()),
                                            new MySqlParameter("@information", txtInfo.Text.Trim()),
                                            new MySqlParameter("@reference", txtRef.Text.Trim()),
                                            new MySqlParameter("@tat", txtTat.Text.Trim()),
                                            new MySqlParameter("@method", txtMethod.Text.Trim()),
                                            new MySqlParameter("@daysSetup", txtDays.Text.Trim()),
                                            new MySqlParameter("@clinicalUsage", txtUsage.Text.Trim()),
                                            new MySqlParameter("@IsActive", chkIsActive.EditValue),
                                            new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK.ToString()));

                            //SqlDb.ExecuteNonQuery("Delete from tblLabTestDetail where labTestPK=@labTestPK", new MySqlParameter("@labTestPK", txtCode.Tag));

                            //if (isDetailExist())
                            //{
                            //    int pk = SqlDb.ExecuteScalar<int>("getid tblLabTestDetail");
                            //    SqlDb.ExecuteQuery("INSERT INTO tblLabTestDetail(labTestDetailPK,labTestPK, specimen,information,reference,tat,method,daysSetup,clinicalUsage, isActive,updateDate,updatePK,createDate,createPK) " +
                            //                    "VALUES(@labTestDetailPK,@labTestPK,@specimen,@information,@reference,@tat,@method,@daysSetup,@clinicalUsage,@IsActive,NOW(),@updatePK,NOW(),@createPK)",
                            //                    new MySqlParameter("@labTestDetailPK", pk),
                            //                    new MySqlParameter("@labTestPK", int.Parse(txtCode.Tag.ToString())),
                            //                    new MySqlParameter("@specimen", txtSpecimen.Text.Trim()),
                            //                    new MySqlParameter("@information", txtInfo.Text.Trim()),
                            //                    new MySqlParameter("@reference", txtRef.Text.Trim()),
                            //                    new MySqlParameter("@tat", txtTat.Text.Trim()),
                            //                    new MySqlParameter("@method", txtMethod.Text.Trim()),
                            //                    new MySqlParameter("@daysSetup", txtDays.Text.Trim()),
                            //                    new MySqlParameter("@clinicalUsage", txtUsage.Text.Trim()),
                            //                    new MySqlParameter("@IsActive", chkIsActive.EditValue),
                            //                    new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK.ToString()),
                            //                    new MySqlParameter("@createPK", AppVariable.CURRENT_USER_PK));
                            //}

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Update Test Name.");

                            MessageBox.Show("Update is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {

                        int labTestPK = SqlDb.ExecuteScalar<int>("Call getID ('tblLabSubTest')");

                        int LabIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblLabSubTest WHERE labSubTestPK=@labSubTestPK AND isDelete=0", new MySqlParameter("@labSubTestPK", labTestPK));

                        if (LabIDCnt < 1)
                        {
                            SqlDb.ExecuteQuery("INSERT INTO tblLabSubTest(labSubTestPK,labSubTestCode,labSubTestName,labSubTestDescription,specimen,information,reference,tat,method,daysSetup,clinicalUsage,labTestPK, isActive,updateDate,updatePK,createDate,createPK) " +
                                                "VALUES(@labSubTestPK,@labSubTestCode,@LabSubTestName,@labSubTestDescription,@specimen,@information,@reference,@tat,@method,@daysSetup,@clinicalUsage,@labTestPK, @IsActive,NOW(),@updatePK,NOW(),@createPK)",
                                                new MySqlParameter("@labTestPK", cboLabTest.SelectedValue),
                                                new MySqlParameter("@labSubTestPK", labTestPK),
                                                new MySqlParameter("@labSubTestCode",txtCode.Text.Trim()),
                                                new MySqlParameter("@labSubTestName", txtName.Text.Trim()),
                                                new MySqlParameter("@labSubTestDescription", txtDescription.Text.Trim()),
                                                new MySqlParameter("@specimen", txtSpecimen.Text.Trim()),
                                                new MySqlParameter("@information", txtInfo.Text.Trim()),
                                                new MySqlParameter("@reference", txtRef.Text.Trim()),
                                                new MySqlParameter("@tat", txtTat.Text.Trim()),
                                                new MySqlParameter("@method", txtMethod.Text.Trim()),
                                                new MySqlParameter("@daysSetup", txtDays.Text.Trim()),
                                                new MySqlParameter("@clinicalUsage", txtUsage.Text.Trim()),
                                                new MySqlParameter("@IsActive", chkIsActive.EditValue),
                                                new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK.ToString()),
                                                new MySqlParameter("@createPK", AppVariable.CURRENT_USER_PK));

                            //if (isDetailExist())
                            //{
                            //    int pk = SqlDb.ExecuteScalar<int>("getid tblLabTestDetail");
                            //    SqlDb.ExecuteQuery("INSERT INTO tblLabTestDetail(labTestDetailPK,labTestPK, specimen,information,reference,tat,method,daysSetup,clinicalUsage, isActive,updateDate,updatePK,createDate,createPK) " +
                            //                    "VALUES(@labTestDetailPK,@labTestPK,@specimen,@information,@reference,@tat,@method,@daysSetup,@clinicalUsage,@IsActive,NOW(),@updatePK,NOW(),@createPK)",
                            //                    new MySqlParameter("@labTestDetailPK", pk),
                            //                    new MySqlParameter("@labTestPK", labTestPK),
                            //                    new MySqlParameter("@specimen", txtSpecimen.Text.Trim()),
                            //                    new MySqlParameter("@information", txtInfo.Text.Trim()),
                            //                    new MySqlParameter("@reference", txtRef.Text.Trim()),
                            //                    new MySqlParameter("@tat", txtTat.Text.Trim()),
                            //                    new MySqlParameter("@method", txtMethod.Text.Trim()),
                            //                    new MySqlParameter("@daysSetup", txtDays.Text.Trim()),
                            //                    new MySqlParameter("@clinicalUsage", txtUsage.Text.Trim()),
                            //                    new MySqlParameter("@IsActive", chkIsActive.EditValue),
                            //                    new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK.ToString()),
                            //                    new MySqlParameter("@createPK", AppVariable.CURRENT_USER_PK));
                            //}

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Add New Lab Sub Test Name.");

                             DialogResult dr = MessageBox.Show("Save is successful. Do you want to create another record?", "MediPro :: Clinic System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (dr == DialogResult.Yes)
                            {
                                txtCode.Text = string.Empty;
                                txtCode.Tag = string.Empty;
                                txtName.Text = string.Empty;
                                txtDescription.Text = string.Empty;

                                chkIsActive.EditValue = true;

                                txtCode.Focus();
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                    }
                }
            }
        }

        private bool ValidateForm()
        {
            bool value = true;
            if (txtCode.Text.Length < 1)
            {
                MessageBox.Show("Please enter Lab Sub Test name.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                txtCode.Focus();
            }
            return value;
        }

        private bool isDetailExist()
        {
            return (txtDays.Text.Trim() != string.Empty || txtInfo.Text.Trim() != string.Empty || txtMethod.Text.Trim() != string.Empty || txtRef.Text.Trim() != string.Empty || txtSpecimen.Text.Trim() != string.Empty ||
                txtTat.Text.Trim() != string.Empty || txtUsage.Text.Trim() != string.Empty);
        }

        private void frmLabSubTestDetail_Load(object sender, EventArgs e)
        {
            if (txtCode.Tag != null)
            {
                DataTable dt = SqlDb.GetDataSet("Select * from tblLabSubTest where labSubTestPK=@labSubTestPK", new MySqlParameter("@labSubTestPK", txtCode.Tag)).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    txtDays.Text = dr["daysSetup"].ToString();
                    txtInfo.Text = dr["information"].ToString();
                    txtMethod.Text = dr["method"].ToString();
                    txtRef.Text = dr["reference"].ToString();
                    txtSpecimen.Text = dr["specimen"].ToString();
                    txtTat.Text = dr["tat"].ToString();
                    txtUsage.Text = dr["clinicalUsage"].ToString();
                }
            }
        }
    }
}
