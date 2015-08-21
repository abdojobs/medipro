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
    public partial class frmItemPrice : Form
    {
        public frmItemPrice()
        {
            InitializeComponent();
            dgv.DataSource = ItemPrice.GetAllItemPrices();
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
                ItemPrice.Save(dr["priceSettingPK"].ToString(), dr["itemPK"].ToString(),"", Convert.ToDouble(dr["originalPrice"] == DBNull.Value ? 0 : dr["originalPrice"]), Convert.ToDouble(dr["discount"] == DBNull.Value ? 0 : dr["discount"]), Convert.ToDouble(dr["sellingPrice"] == DBNull.Value ? 0 : dr["sellingPrice"]),DateTime.Now,true);
            }
            MessageBox.Show("Saving Successful");
        }

        private void dgvView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if ( e.Column.Name==dgvColOriginalPrice.Name || e.Column.Name==dgvColDiscount.Name)
            {
                double originalPrice = Convert.ToDouble(dgvView.GetDataRow(e.RowHandle)[dgvColOriginalPrice.FieldName] == DBNull.Value ? 0 : dgvView.GetDataRow(e.RowHandle)[dgvColOriginalPrice.FieldName]);
                double discountRate = Convert.ToDouble(dgvView.GetDataRow(e.RowHandle)[dgvColDiscount.FieldName] == DBNull.Value ? 0 : dgvView.GetDataRow(e.RowHandle)[dgvColDiscount.FieldName]);

                double SellingPrice = originalPrice - (originalPrice * discountRate / 100);

                dgvView.SetRowCellValue(e.RowHandle, dgvColSellingPrice, SellingPrice);
            }
        }
    }

    
}
