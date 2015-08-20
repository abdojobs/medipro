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

namespace MediPro
{
    public partial class frmLabTestPrice : Form
    {
        public frmLabTestPrice()
        {
            InitializeComponent();
            dgv.DataSource = LabTestPrice.GetAllLabTestPrice();
            //lueLabTest.DataSource = LabTest.GetAllLabTest();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)dgvView.DataSource;
            foreach (DataRow dr in dv.Table.Rows)
            {
                LabTestPrice.Save(dr["labTestPricePK"].ToString(), dr["labTestPK"].ToString(), dr["branchPK"].ToString(), Convert.ToDouble(dr["originalPrice"] == DBNull.Value ? 0 : dr["originalPrice"]), Convert.ToDouble(dr["profitMargin"] == DBNull.Value ? 0 : dr["profitMargin"]), Convert.ToInt32( dr["exchangePK"]==DBNull.Value?0:dr["exchangePK"]), Convert.ToDouble(dr["discount"] == DBNull.Value ? 0 : dr["discount"]), Convert.ToDouble(dr["sellingPrice"] == DBNull.Value ? 0 : dr["sellingPrice"]));
            }
            MessageBox.Show("Saving Successful");
        }

        private void dgvView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == dgvColProfitMargin.Name || e.Column.Name==dgvColOriginalPrice.Name || e.Column.Name==dgvColDiscount.Name)
            {
                double originalPrice =Convert.ToDouble( dgvView.GetDataRow(e.RowHandle)[dgvColOriginalPrice.FieldName]);
                double profitMargin =Convert.ToDouble( dgvView.GetDataRow(e.RowHandle)[dgvColProfitMargin.FieldName]);
                double discountRate =Convert.ToDouble( dgvView.GetDataRow(e.RowHandle)[dgvColDiscount.FieldName]);

                double grossSellingPrice=originalPrice+(originalPrice*profitMargin/100);
                double finalSellingPrice = grossSellingPrice - (grossSellingPrice * discountRate / 100);
                
                dgvView.SetRowCellValue(e.RowHandle, dgvColSellingPrice,finalSellingPrice);
            }
        }
    }

    
}
