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
    public partial class frmLabInvoice : Form
    {
        clsSQL SqlDb = new clsSQL();
        public frmLabInvoice()
        {
            InitializeComponent();
            lueDoctor.Properties.DataSource = SqlDb.GetDataSet("SELECT doctorPK, CONCAT(TitleName , ' ' , doctor) AS doctor, position, specialize FROM tblDoctor INNER JOIN tblPosition ON tblDoctor.positionPK = tblPosition.positionPK INNER JOIN tblSpecialize ON tblDoctor.specializePK = tblSpecialize.specializePK INNER JOIN tblTitle ON tblDoctor.titlePK = tblTitle.titlePK WHERE (tblDoctor.isActive = 1)").Tables[0];
            luePatient.Properties.DataSource = SqlDb.GetDataSet("SELECT RegNo, CONCAT(TitleName , ' ',  Name) As Name, DOB, FatherName, NRC FROM tblPatient INNER JOIN tblTitle ON tblPatient.titlePK = tblTitle.titlePK WHERE tblPatient.isDelete = 0").Tables[0];
            lueDonor.Properties.DataSource = SqlDb.GetDataSet("SELECT RegNo, CONCAT(TitleName , ' ',  Name) As Name, DOB, FatherName, NRC FROM tblPatient INNER JOIN tblTitle ON tblPatient.titlePK = tblTitle.titlePK WHERE tblPatient.isDelete = 0").Tables[0];
            lueLabTest.DataSource = SqlDb.GetDataSet("Select * from tblLabTest").Tables[0];
            grdItems.DataSource = SqlDb.GetDataSet("select * from tbllabInvoiceDetail as detail inner join tblLabTest labTest on labTest.labTestPK=detail.labTestPK inner join tbllabtestprice as labTestPrice on labTest.labTestPK=labTestPrice.labTestPK where detail.labInvoiceNo is null").Tables[0];
        }

        public frmLabInvoice(string labrequestheaderPK)
        {
            InitializeComponent();
            lueDoctor.Properties.DataSource = SqlDb.GetDataSet("SELECT doctorPK, CONCAT(TitleName , ' ' , doctor) AS doctor, position, specialize FROM tblDoctor INNER JOIN tblPosition ON tblDoctor.positionPK = tblPosition.positionPK INNER JOIN tblSpecialize ON tblDoctor.specializePK = tblSpecialize.specializePK INNER JOIN tblTitle ON tblDoctor.titlePK = tblTitle.titlePK WHERE (tblDoctor.isActive = 1)").Tables[0];
            luePatient.Properties.DataSource = SqlDb.GetDataSet("SELECT RegNo, CONCAT(TitleName , ' ',  Name) As Name, DOB, FatherName, NRC FROM tblPatient INNER JOIN tblTitle ON tblPatient.titlePK = tblTitle.titlePK WHERE tblPatient.isDelete = 0").Tables[0];
            lueDonor.Properties.DataSource = SqlDb.GetDataSet("SELECT RegNo, CONCAT(TitleName , ' ',  Name) As Name, DOB, FatherName, NRC FROM tblPatient INNER JOIN tblTitle ON tblPatient.titlePK = tblTitle.titlePK WHERE tblPatient.isDelete = 0").Tables[0];
            lueLabTest.DataSource = SqlDb.GetDataSet("Select * from tblLabTest").Tables[0];
            DataTable dt = SqlDb.GetDataSet("select * from tbllabinvoicedetail as detail inner join tblLabTest labTest on labTest.labTestPK=detail.labTestPK inner join tbllabtestprice as labTestPrice on labTest.labTestPK=labTestPrice.labTestPK").Tables[0];
            dt.Columns.Add("isDonor", typeof(bool));
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["donorPK"] != DBNull.Value)
                {
                    dr["isDonor"] = true;
                }
            }
            grdItems.DataSource = dt;
            //grdItems.DataSource = 
            RefreshAmounts();
        }

        private void lblPatientName_Click(object sender, EventArgs e)
        {
            new frmPatientDetail().Show();
        }

        public void RefreshAmounts()
        {
            try
            {
                totalAmount = 0;
                deposit = Convert.ToDecimal(txtDeposit.Text);
                discount = Convert.ToDecimal(txtDiscount.Text);
                paidAmount = Convert.ToDecimal(txtPaidAmount.Text);
                changeAmount = Convert.ToDecimal(txtChange.Text);


                foreach (DataRow dr in ((DataView)grdViewItems.DataSource).Table.Rows)
                {
                    decimal price = Convert.ToInt32(dr["price"]);
                    totalAmount += price;
                }
                netAmount = totalAmount - (discount + deposit);
                changeAmount = paidAmount - netAmount;


                txtTotalAmount.Text = totalAmount.ToString();
                txtNetAmount.Text = netAmount.ToString();
                txtChange.Text = changeAmount.ToString();
            }
            catch (Exception ex)
            { 
                
            }


        }

        private void grdViewItems_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name==grdColLabTestName.Name && e.Value != null)
            {
                DataSet ds = SqlDb.GetDataSet("Select * from tblLabTest inner join tbllabtestprice on tblLabTest.labtestPK=tbllabtestprice.labTestPK where tbllabtest.labtestPK='"+e.Value.ToString()+"'");
                DataTable dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    grdViewItems.SetRowCellValue(e.RowHandle, grdColLabTestCode, dr["labTestCode"]);
                    grdViewItems.SetRowCellValue(e.RowHandle, grdColLabTestDesc, dr["labTestDescription"]);
                    grdViewItems.SetRowCellValue(e.RowHandle, grdColPrice, dr["Price"]);

                    RefreshAmounts();

                }
            }
        }
        string invoiceNo = "";
        string doctorPK = "";
        DateTime invoiceDate;
        string branchPK = "";
        string patientPK = "";
        decimal totalAmount = 0;
        decimal deposit = 0;
        decimal discount = 0;
        decimal paidAmount = 0;
        decimal changeAmount = 0;
        decimal netAmount = 0;




        private void cmdSave_Click(object sender, EventArgs e)
        {
            invoiceNo = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Millisecond.ToString();
            doctorPK = lueDoctor.EditValue.ToString();
            invoiceDate = DateTime.Now;
            branchPK = AppVariable.CURRENT_BRANCH_PK.ToString();
            patientPK = luePatient.EditValue.ToString();
            totalAmount = Convert.ToDecimal(txtTotalAmount.Text);
            deposit = Convert.ToDecimal(txtDeposit.Text);
            discount = Convert.ToDecimal(txtDiscount.Text);
            paidAmount = Convert.ToDecimal(txtPaidAmount.Text);
            changeAmount = Convert.ToDecimal(txtChange.Text);
            netAmount = Convert.ToDecimal(txtNetAmount.Text);

            SaveInvoiceHeader();


            foreach(DataRow dr in ((DataView) grdViewItems.DataSource).Table.Rows)
            {
                string labTestPK = dr["labTestPK"].ToString();
                decimal price = Convert.ToInt32( dr["price"]);

                SaveInvoiceDetail(invoiceNo, labTestPK, price);
            }
            MessageBox.Show("Saving Successful");
            this.Close();
            new frmLabInvoice().Show();

        }

        public void SaveInvoiceHeader()
        {
            try
            {
                MySqlCommand sqlcmd = new MySqlCommand();
                sqlcmd.CommandText = "INSERT INTO `medipro`.`tbllabinvoice`(`labInvoiceNo`,`doctorPK`,`invoiceDate`,`branchPK`,`patientPK`,`totalAmount`,`deposit`,`discount`,`paidAmount`,`changeAmount`,`netAmount`,`createPK`,`createDate`,`updatePK`,`updateDate`)VALUES(@labInvoiceNo,@doctorPK,@invoiceDate,@branchPK,@patientPK,@totalAmount,@deposit,@discount,@paidAmount,@changeAmount,@netAmount,@createPK,@createDate,@updatePK,@updateDate);";
                sqlcmd.Parameters.AddWithValue("@labInvoiceNo", invoiceNo);
                sqlcmd.Parameters.AddWithValue("@doctorPK", doctorPK);
                sqlcmd.Parameters.AddWithValue("@invoiceDate", invoiceDate);
                sqlcmd.Parameters.AddWithValue("@branchPK", branchPK);
                sqlcmd.Parameters.AddWithValue("@patientPK", patientPK);
                sqlcmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                sqlcmd.Parameters.AddWithValue("@deposit", deposit);
                sqlcmd.Parameters.AddWithValue("@discount", discount);
                sqlcmd.Parameters.AddWithValue("@paidAmount", paidAmount);
                sqlcmd.Parameters.AddWithValue("@changeAmount", changeAmount);
                sqlcmd.Parameters.AddWithValue("@netAmount", netAmount);
                sqlcmd.Parameters.AddWithValue("@createPK", AppVariable.CURRENT_USER_PK);
                sqlcmd.Parameters.AddWithValue("@createDate", DateTime.Now);
                sqlcmd.Parameters.AddWithValue("@updatePK", AppVariable.CURRENT_USER_PK);
                sqlcmd.Parameters.AddWithValue("@updateDate", DateTime.Now);

                SqlDb.ExecuteQuery(sqlcmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void SaveInvoiceDetail(string labInvoiceNo, string labTestPK, decimal price)
        {
            try
            {
                MySqlCommand sqlcmd = new MySqlCommand();
                sqlcmd.CommandText = "INSERT INTO `medipro`.`tbllabinvoicedetail`(`labInvoiceNo`,`labTestPK`,`price`)VALUES(@labInvoiceNo,@labTestPK,@price);";
                sqlcmd.Parameters.AddWithValue("@labInvoiceNo", labInvoiceNo);
                sqlcmd.Parameters.AddWithValue("@labTestPK", labTestPK);
                sqlcmd.Parameters.AddWithValue("@price", price);
                

                SqlDb.ExecuteQuery(sqlcmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AmountTextBoxes_Validated(object sender, EventArgs e)
        {
            RefreshAmounts();
        }

        private void grdViewItems_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            RefreshAmounts();
        }

        private void controls_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void grdItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                MessageBox.Show("I got it");
                txtDiscount.Focus();
                txtDiscount.SelectAll();
            }
        }

        private void grdViewItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                MessageBox.Show("I got it");
                txtDiscount.Focus();
                txtDiscount.SelectAll();
            }
        }

        private void grdViewItems_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                MessageBox.Show("I got it");
                txtDiscount.Focus();
                txtDiscount.SelectAll();
            }
        }

    }
}
