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
using MySql.Data.MySqlClient;


namespace Lab
{
    public partial class frmLabTechReqSample : Form
    {
        clsSQL SqlDb = new clsSQL();
        public static int intLabTechReqPK = 0;
        private DataTable dtGridSource;

        public frmLabTechReqSample()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {




            bool IsValid = false;
            string strErrMsg = "";

            //if (txtSampleID.Text.Length > 0)
            //{
            //    int DupCnt = SqlDb.ExecuteScalar<int>("SELECT COUNT(*) FROM sysRoles WHERE isDelete=0 AND roleName='" + txtRoleName.Text + "' AND rolePK<>" + intLabTechReqPK.ToString());

            //    if (DupCnt > 0)
            //    {
            //        IsValid = false;
            //        strErrMsg += "Role name is already exist.\n\r";
            //    }
            //    else
            //    {
            //        IsValid = true;
            //    }
            //}
            //else
            //{
            //    IsValid = false;
            //    strErrMsg += "Role name must be filled.\n\r";
            //}

            
            
            IsValid = true;



            if (IsValid)
            {
                if (intLabTechReqPK == 0)
                {
                    
                    SqlDb.ExecuteQuery("update tbllabtechnicianrequest set " +
                                       "hasSample = @hasSample , sampleID = @sampleID, " +
                                       "sampleDateTime = @sampleDateTime , updatePK = @updatePK, updateDate = now() " +
                                       "where labtechnicianrequestPK = @labtechnicianrequestPK",
                                            new MySqlParameter("@hasSample", chkHasSample.EditValue),
                                            new MySqlParameter("@sampleID", txtSampleID.Text.Trim()),
                                            new MySqlParameter("@sampleDateTime", dteSampleDate.DateTime.ToString("yyyy-MM-dd")),
                                            new MySqlParameter("@updatePK", AppVariable.CURRENT_USER_PK),
                                            new MySqlParameter("@labtechnicianrequestPK", intLabTechReqPK));
                    
                }

               
            }
            else
            {
                MessageBox.Show(strErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void frmLabTechReqSample_Load(object sender, EventArgs e)
        {
            dteSampleDate.EditValue = DateTime.Now;
            if (intLabTechReqPK>0)
            {
                DataRow drReq = SqlDb.GetDataSet("select req.labtechnicianrequestPK, req.labInvoiceNo, req.labTestPK,req.sampleID, req.hasSample, " +
                                "req.hasResult, req.resultDateTime, lab.labTestCode,lab.labTestName, lab.companyPK,p.RegNo, p.Name, " +
                                "p.FatherName, p.DOB from tbllabtechnicianrequest as req  " +
                                "join tbllabtest as lab on lab.labTestPK = req.labTestPK " +
                                "join tbllabinvoice as inv on inv.labInvoiceNo = req.labInvoiceNo " +
                                "join tblpatient as p on  p.RegNo = inv.patientPK " +
                                "where req.labtechnicianrequestPK = " + intLabTechReqPK.ToString()).Tables[0].Rows[0];

                lblRegNo.Text = drReq["RegNo"].ToString();
                lblPatient.Text = drReq["Name"].ToString();
                lblLabTestCode.Text = drReq["labTestCode"].ToString();
                lblLabTestName.Text = drReq["labTestName"].ToString();

                int intHasSameple = int.Parse(drReq["hasSample"].ToString());
                if (intHasSameple == 0)
                {
                    chkHasSample.Checked = false;
                }
                else
                {
                    chkHasSample.Checked = true;
                }
            } 
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
        }

        private void chkHasSample_CheckedChanged(object sender, EventArgs e)
        {
            txtSampleID.Enabled = chkHasSample.Checked;
            dteSampleDate.Enabled = chkHasSample.Checked;
        }
    }
}
