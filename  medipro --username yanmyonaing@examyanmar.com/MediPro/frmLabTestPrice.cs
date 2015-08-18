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
    }

    public class LabTestPrice
    {
        
        public static void Save(string labTestPricePK,string labTestPK,string branchPK,double originalPrice,double profitMargin,
            int exchangePK,double discount,double sellingPrice)
        {
            clsSQL sql = new clsSQL();
            bool isExisted=false;
            isExisted = sql.ExecuteScalar<Int32>("Select Count(*) from tblLabTestPrice where labTestPricePK=@PK", new MySqlParameter("@PK", labTestPricePK)) > 0 ? true : false;
            if (!isExisted)
            {
                //Insert
                labTestPricePK = Guid.NewGuid().ToString();
                sql.ExecuteNonQuery("Insert into tblLabTestPrice(labTestPricePK,labTestPK,branchPK,originalPrice,ProfitMargin,exchangePK,discount,sellingPrice,createPK,createDate,updatePK,updateDate) values("+
                                                              "@labTestPricePK,@labTestPK,@branchPK,@originalPrice,@ProfitMargin,@exchangePK,@discount,@sellingPrice,@createPK,@createDate,@updatePK,@updateDate)",
                                                              new MySqlParameter("labTestPricePK",labTestPK),
                                                              new MySqlParameter("@labTestPK",labTestPK),
                                                              new MySqlParameter("@branchPK",branchPK),
                                                              new MySqlParameter("@originalPrice",originalPrice),
                                                              new MySqlParameter("@ProfitMargin",profitMargin),
                                                              new MySqlParameter("@exchangePK",exchangePK),
                                                              new MySqlParameter("@discount",discount),
                                                              new MySqlParameter("@sellingPrice",sellingPrice),
                                                              new MySqlParameter("@createPK","1"),
                                                              new MySqlParameter("@createDate",DateTime.Now),
                                                              new MySqlParameter("@updatePK","1"),
                                                              new MySqlParameter("@updateDate",DateTime.Now));
            }
            else
            { 
                //Update
                sql.ExecuteNonQuery("Update tblLabTestPrice set labTestPricePK=@labTestPricePK,labTestPK=@labTestPK,branchPK=@branchPK,originalPrice=@originalPrice,ProfitMargin=@ProfitMargin,exchangePK=@exchangePK,discount=@discount,sellingPrice=@sellingPrice,"+
                                     "updatePK=@updatePK,updateDate=@updateDate where labTestPricePK=@labTestPricePK",
                                                              new MySqlParameter("labTestPricePK", labTestPricePK),
                                                              new MySqlParameter("@labTestPK", labTestPK),
                                                              new MySqlParameter("@branchPK", branchPK),
                                                              new MySqlParameter("@originalPrice", originalPrice),
                                                              new MySqlParameter("@ProfitMargin", profitMargin),
                                                              new MySqlParameter("@exchangePK", exchangePK),
                                                              new MySqlParameter("@discount", discount),
                                                              new MySqlParameter("@sellingPrice", sellingPrice),
                                                              new MySqlParameter("@updatePK", "1"),
                                                              new MySqlParameter("@updateDate", DateTime.Now));
            }
        }

        public static DataTable GetAllLabTestPrice()
        { 
            clsSQL sql = new clsSQL();
            return sql.GetDataSet("Select labtest.labTestPK,labTest.labTestCode,labTest.labTestName, tbllabtestprice.* from tblLabTest labtest left join tblLabTestPrice  on labtest.labTestPK=tblLabTestPrice.labTestPK").Tables[0];
        }
    }
}
