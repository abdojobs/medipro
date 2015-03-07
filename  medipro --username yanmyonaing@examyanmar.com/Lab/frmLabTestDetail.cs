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

namespace Lab
{
    public partial class frmLabTestDetail : Form
    {
        clsSQL SqlDb = new clsSQL();

        public frmLabTestDetail()
        {
            InitializeComponent();
            cboLab.DataSource = SqlDb.GetDataSet("Select labPK,labName from tblLaboratory where isActive='True'").Tables[0];
            cboLab.ValueMember = "labPK";
            cboLab.DisplayMember = "labName";

            cboBodySystem.DataSource = SqlDb.GetDataSet("Select labCatPK,labCatName from tblLabCat where isActive='True'").Tables[0];
            cboBodySystem.ValueMember = "labCatPK";
            cboBodySystem.DisplayMember = "labCatName";

            cboType.DataSource = SqlDb.GetDataSet("Select labTypePK,labTypeName from tblLabType where isActive='True'").Tables[0];
            cboType.ValueMember = "labTypePK";
            cboType.DisplayMember = "labTypeName";
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == true)
            {
                int Cnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblLabTest WHERE labTestName=@LabTestName AND isDelete=0 AND labTestPK <>@labTestPK", new SqlParameter("@LabTestName", txtCode.Text.Trim()), new SqlParameter("@labTestPK", txtCode.Tag.ToString()));

                if (Cnt > 0 )
                {
                    MessageBox.Show("Your Lab Test Name is already exit. Please check your Lab Test Name.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCode.Focus();
                    txtCode.SelectAll();
                }
                else
                {
                    if (txtCode.Tag.ToString().Length > 0)
                    {
                        int LabIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblLabTest WHERE labTestPK=@labTestPK AND isDelete=0", new SqlParameter("@labTestPK", txtCode.Tag.ToString()));

                        if (LabIDCnt > 0)
                        {
                            SqlDb.ExecuteQuery("UPDATE tblLabTest SET labPK=@labPK,labTypePK=@labTypePK,labCatPK=@labCatPK, labTestCode=@labTestCode, labTestName=@LabTestName,labTestDescription=@labTestDescription,specimen=@specimen,information=@information,reference=@reference,tat=@tat,method=@method,daysSetup=@daysSetup,clinicalUsage=@clinicalUsage," +
                                                "isActive=@IsActive,updateDate=SYSDATETIME(),updatePK=@UpdatePK WHERE labTestPK=@labTestPK",
                                            new SqlParameter("@labPK",cboLab.SelectedValue),
                                            new SqlParameter("@labTypePK",cboType.SelectedValue),
                                            new SqlParameter("@labCatPK",cboBodySystem.SelectedValue),
                                            new SqlParameter("@labTestPK", int.Parse(txtCode.Tag.ToString())),
                                            new SqlParameter("@labTestCode", txtCode.Text.Trim()),
                                            new SqlParameter("@labTestName", txtName.Text.Trim()),
                                            new SqlParameter("@labTestDescription", txtDescription.Text.Trim()),
                                            new SqlParameter("@specimen", txtSpecimen.Text.Trim()),
                                            new SqlParameter("@information", txtInfo.Text.Trim()),
                                            new SqlParameter("@reference", txtRef.Text.Trim()),
                                            new SqlParameter("@tat", txtTat.Text.Trim()),
                                            new SqlParameter("@method", txtMethod.Text.Trim()),
                                            new SqlParameter("@daysSetup", txtDays.Text.Trim()),
                                            new SqlParameter("@clinicalUsage", txtUsage.Text.Trim()),
                                            new SqlParameter("@IsActive", chkIsActive.EditValue),
                                            new SqlParameter("@updatePK", AppVariable.CURRENT_USER_PK.ToString()));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Update Lab Test Name.");

                            MessageBox.Show("Update is successful.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        int labTestPK = SqlDb.ExecuteScalar<int>("getID tblLabTest");

                        int LabIDCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM tblLabTest WHERE labTestPK=@labTestPK AND isDelete=0", new SqlParameter("@labTestPK", labTestPK));

                        if (LabIDCnt < 1)
                        {
                            SqlDb.ExecuteQuery("INSERT INTO tblLabTest(labTestPK,labCatPK,labPK,labTypePK,labTestCode,labTestName,labTestDescription,specimen,information,reference,tat,method,daysSetup,clinicalUsage, isActive,updateDate,updatePK,createDate,createPK) " +
                                                "VALUES(@labTestPK,@labCatPK,@labPK,@labTypePK,@labTestCode,@LabTestName,@labTestDescription,@specimen,@information,@reference,@tat,@method,@daysSetup,@clinicalUsage,@IsActive,SYSDATETIME(),@updatePK,SYSDATETIME(),@createPK)",
                                                new SqlParameter("@labPK", cboLab.SelectedValue),
                                                new SqlParameter("@labTypePK",cboType.SelectedValue),
                                                new SqlParameter("@labCatPK", cboBodySystem.SelectedValue),
                                                new SqlParameter("@labTestPK", labTestPK),
                                                new SqlParameter("@labTestCode",txtCode.Text.Trim()),
                                                new SqlParameter("@labTestName", txtName.Text.Trim()),
                                                new SqlParameter("@labTestDescription", txtDescription.Text.Trim()),
                                                new SqlParameter("@specimen", txtSpecimen.Text.Trim()),
                                                new SqlParameter("@information", txtInfo.Text.Trim()),
                                                new SqlParameter("@reference", txtRef.Text.Trim()),
                                                new SqlParameter("@tat", txtTat.Text.Trim()),
                                                new SqlParameter("@method", txtMethod.Text.Trim()),
                                                new SqlParameter("@daysSetup", txtDays.Text.Trim()),
                                                new SqlParameter("@clinicalUsage", txtUsage.Text.Trim()),
                                                new SqlParameter("@IsActive", chkIsActive.EditValue),
                                                new SqlParameter("@updatePK", AppVariable.CURRENT_USER_PK.ToString()),
                                                new SqlParameter("@createPK", AppVariable.CURRENT_USER_PK));

                            sysLogs.logsDetail(int.Parse(AppVariable.CURRENT_SUB_MENU.ToString()), "Add New Lab Test Name.");

                             DialogResult dr = MessageBox.Show("Save is successful. Do you want to create another record?", "MediPro :: Clinic System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (dr == DialogResult.Yes)
                            {
                                txtCode.Text = string.Empty;
                                txtCode.Tag = string.Empty;
                                txtName.Text = string.Empty;
                                txtDescription.Text = string.Empty;

                                txtSpecimen.Text = string.Empty;
                                txtDays.Text = string.Empty;
                                txtInfo.Text = string.Empty;
                                txtMethod.Text = string.Empty;
                                txtRef.Text = string.Empty;
                                txtTat.Text = string.Empty;
                                txtUsage.Text = string.Empty;

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

        private bool isDetailExist()
        {
            return (txtDays.Text.Trim() != string.Empty || txtInfo.Text.Trim() != string.Empty || txtMethod.Text.Trim() != string.Empty || txtRef.Text.Trim() != string.Empty || txtSpecimen.Text.Trim() != string.Empty ||
                txtTat.Text.Trim() != string.Empty || txtUsage.Text.Trim() != string.Empty);
        }

        private bool ValidateForm()
        {
            bool value = true;
            if (txtCode.Text.Length < 1)
            {
                MessageBox.Show("Please enter Lab Test name.", "MediPro :: Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = false;
                txtCode.Focus();
            }
            return value;
        }

        private void frmLabTestDetail_Load(object sender, EventArgs e)
        {
            if (txtCode.Tag != null)
            {
                DataTable dt = SqlDb.GetDataSet("Select * from tblLabTest where labTestPK=@labTestPK", new SqlParameter("@labTestPK", txtCode.Tag)).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    cboBodySystem.SelectedValue = dr["labCatPK"]=="0"?-1:dr["labCatPK"];
                    cboLab.SelectedValue = dr["labPK"] == "0" ? -1 : dr["labPK"];
                    cboType.SelectedValue = dr["labTypePK"] == "0" ? -1 : dr["labTypePK"];
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
