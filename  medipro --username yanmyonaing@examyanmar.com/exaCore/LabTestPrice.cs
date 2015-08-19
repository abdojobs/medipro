using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql;
using MySql.Data.MySqlClient;

namespace exaCore
{
    public class LabTestPrice
    {

        public static void Save(string labTestPricePK, string labTestPK, string branchPK, double originalPrice, double profitMargin,
            int exchangePK, double discount, double sellingPrice)
        {
            clsSQL sql = new clsSQL();
            bool isExisted = false;
            isExisted = sql.ExecuteScalar<Int32>("Select Count(*) from tblLabTestPrice where labTestPricePK=@PK", new MySqlParameter("@PK", labTestPricePK)) > 0 ? true : false;
            if (!isExisted)
            {
                //Insert
                labTestPricePK = Guid.NewGuid().ToString();
                sql.ExecuteNonQuery("Insert into tblLabTestPrice(labTestPricePK,labTestPK,branchPK,originalPrice,ProfitMargin,exchangePK,discount,sellingPrice,createPK,createDate,updatePK,updateDate) values(" +
                                                              "@labTestPricePK,@labTestPK,@branchPK,@originalPrice,@ProfitMargin,@exchangePK,@discount,@sellingPrice,@createPK,@createDate,@updatePK,@updateDate)",
                                                              new MySqlParameter("labTestPricePK", labTestPK),
                                                              new MySqlParameter("@labTestPK", labTestPK),
                                                              new MySqlParameter("@branchPK", branchPK),
                                                              new MySqlParameter("@originalPrice", originalPrice),
                                                              new MySqlParameter("@ProfitMargin", profitMargin),
                                                              new MySqlParameter("@exchangePK", exchangePK),
                                                              new MySqlParameter("@discount", discount),
                                                              new MySqlParameter("@sellingPrice", sellingPrice),
                                                              new MySqlParameter("@createPK", "1"),
                                                              new MySqlParameter("@createDate", DateTime.Now),
                                                              new MySqlParameter("@updatePK", "1"),
                                                              new MySqlParameter("@updateDate", DateTime.Now));
            }
            else
            {
                //Update
                sql.ExecuteNonQuery("Update tblLabTestPrice set labTestPricePK=@labTestPricePK,labTestPK=@labTestPK,branchPK=@branchPK,originalPrice=@originalPrice,ProfitMargin=@ProfitMargin,exchangePK=@exchangePK,discount=@discount,sellingPrice=@sellingPrice," +
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
