using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace exaCore
{
    public class LabTest
    {
        public static DataTable GetAllLabTest()
        { 
            clsSQL sql = new clsSQL();
            return sql.GetDataSet("select * from tblLabTest").Tables[0];
        }

    }
}
