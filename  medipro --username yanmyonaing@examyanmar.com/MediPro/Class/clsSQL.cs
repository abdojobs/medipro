using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MediPro.Class;

namespace MediPro.Class
{
    public class clsSQL
    {
        static string connString = "";
        public SqlConnection con;
        private SqlTransaction rTran;

        public clsSQL()
        {
            connString = ConfigurationManager.ConnectionStrings["CnnpMediPro"].ToString();            
            con = new SqlConnection(connString);
        }

        public clsSQL(string ConnectionString)
        {
            connString = ConnectionString;
            con = new SqlConnection(connString);
        }

        ~clsSQL()
        {
        }

        public SqlTransaction myTrans
        {
            set { rTran = value; }
            get { return rTran; }
        }

        public DType ExecuteScalar<DType>(string SqlString, params SqlParameter[] parameters)
        {

            DType result = default(DType);

            if (!string.IsNullOrEmpty(SqlString))
            {
                using (SqlCommand command = new SqlCommand(SqlString, con))
                {
                    if (parameters != null && parameters.Length > 0)
                    {
                        foreach (SqlParameter parameter in parameters)
                        {

                            command.Parameters.Add(parameter);
                        }
                    }
                    try
                    {
                        if (con.State != ConnectionState.Open)
                            con.Open();
                        result = (DType)command.ExecuteScalar();
                        //return result;
                    }
                    catch (Exception exp)
                    {
                        return result;
                        throw exp;                        
                    }
                    finally
                    {
                        this.Close();                        
                    }
                }
            }
            return result;
        }

        public DType ExecuteScalar<DType>(string SqlString, CommandType type, SqlParameter[] parm)
        {

            DType result = default(DType);

            if (!string.IsNullOrEmpty(SqlString))
            {
                using (SqlCommand command = new SqlCommand(SqlString, con))
                {
                    command.CommandType = type;
                    if (parm != null && parm.Length > 0)
                    {
                        foreach (SqlParameter parameter in parm)
                        {
                            command.Parameters.Add(parameter);
                        }
                    }
                    try
                    {
                        con.Open();
                        result = (DType)command.ExecuteScalar();
                        //return result;
                    }
                    catch (Exception exp)
                    {
                        throw exp;
                        //return result;
                    }
                    finally
                    {
                        this.Close();
                    }
                }
            }
            return result;
        }

        public bool ExecuteQuery(string commandText, CommandType type, params SqlParameter[] parms)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = commandText;
            cmd.CommandType = type;           

            bool result = false;

            if (parms != null && parms.Length > 0)
            {
                foreach (SqlParameter p in parms)
                {
                    cmd.Parameters.Add(p);
                }
            }

            try
            {                
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlTransaction sqlTran;
                sqlTran = con.BeginTransaction();
                cmd.Transaction = sqlTran;
                try
                {
                    cmd.ExecuteNonQuery();
                    sqlTran.Commit();
                    result = true;
                }
                catch (Exception ex)
                {
                    sqlTran.Rollback();
                    result = false;
                    throw ex;
                }
            }
            catch (Exception exp)
            {
                result = false;
                throw exp;
            }
            finally
            {                
                cmd.Parameters.Clear();
                cmd.Dispose();
                this.Close();
            }
            return result;

        }
        public bool ExecuteQuery(SqlCommand oSqlCommand)
        {  
            oSqlCommand.Connection = con;
            bool result = false;

            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                SqlTransaction sqlTran;
                sqlTran = con.BeginTransaction();
                oSqlCommand.Transaction = sqlTran;
                try
                {
                    oSqlCommand.ExecuteNonQuery();
                    sqlTran.Commit();
                    result = true;
                }
                catch (Exception ex)
                {
                    sqlTran.Rollback();
                    result = false;
                    throw ex;
                }
            }
            catch (Exception exp)
            {
                result = false;
                throw exp;
            }
            finally
            {
                oSqlCommand.Dispose();
                this.Close();
            }
            return result;
        }

        public bool ExecuteQuery(string commandText, params SqlParameter[] parms)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = commandText;

            bool result = false;

            if (parms != null && parms.Length > 0)
            {
                foreach (SqlParameter p in parms)
                {
                    cmd.Parameters.Add(p);
                }
            }

            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                SqlTransaction sqlTran;
                sqlTran = con.BeginTransaction();
                cmd.Transaction = sqlTran;
                try
                {
                    cmd.ExecuteNonQuery();
                    sqlTran.Commit();
                    result = true;
                }
                catch (Exception ex)
                {
                    sqlTran.Rollback();
                    result = false;
                    throw ex;
                }                
            }
            catch (Exception exp)
            {
                result = false;
                throw exp;
            }
            finally
            {
                cmd.Parameters.Clear();
                cmd.Dispose();
                this.Close();
            }
            return result;
        }

        public bool ExecuteNonQuery(string commandText, params SqlParameter[] parms)
        {

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = commandText;

            bool result = false;

            if (parms != null && parms.Length > 0)
            {
                foreach (SqlParameter p in parms)
                {
                    cmd.Parameters.Add(p);
                }
            }

            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                    result = true;
                }
                catch (Exception ex)
                {
                    result = false;
                    throw ex;
                }
            }
            catch (Exception exp)
            {
                result = false;
                throw exp;
            }
            finally
            {
                cmd.Parameters.Clear();
                cmd.Dispose();
                this.Close();
            }
            return result;
        }

        public DataSet GetDataSet(string tblname, string commandtext, CommandType type, params SqlParameter[] parm)
        {
            SqlCommand cmd = new SqlCommand(commandtext, con);
            cmd.CommandType = type;
            DataSet result = new DataSet();
            if (parm != null && parm.Length > 0)
            {
                foreach (SqlParameter p in parm)
                {
                    cmd.Parameters.Add(p);
                }
            }
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(result, tblname);                
            }
            catch (Exception exp)
            {
                throw exp;
            }

            finally
            {
                cmd.Parameters.Clear();
                cmd.Dispose();
                this.Close();
            }
            return result;
        }

        public DataSet GetDataSet(string tblname, string commandtext, params SqlParameter[] parm)
        {
            SqlCommand cmd = new SqlCommand(commandtext, con);
            DataSet result = new DataSet();
            if (parm != null && parm.Length > 0)
            {
                foreach (SqlParameter p in parm)
                {
                    cmd.Parameters.Add(p);
                }
            }
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(result, tblname);
            }
            catch (Exception exp)
            {
                throw exp;
            }

            finally
            {
                cmd.Parameters.Clear();
                cmd.Dispose();
                this.Close();
            }
            return result;
        }

        public DataSet GetDataSet(string commandtext, params SqlParameter[] parm)
        {
            SqlCommand cmd = new SqlCommand(commandtext, con);
            DataSet result = new DataSet();
            if (parm != null && parm.Length > 0)
            {
                foreach (SqlParameter p in parm)
                {
                    cmd.Parameters.Add(p);
                }
            }
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(result);
            }
            catch (Exception exp)
            {
                throw exp;
            }
            finally
            {
                cmd.Parameters.Clear();
                cmd.Dispose();
                this.Close();
            }
            return result;
        }

        public void Close()
        {
            if (this.con.State != ConnectionState.Closed)
                this.con.Close();
        }

        public void Logging(int LogInID, string WhichFunction, string Description)
        {
            ExecuteQuery("DELETE FROM sysLog WHERE DATEDIFF(Day,LogDateTime,GETDATE())>365");
            ExecuteQuery("INSERT INTO sysLog(LogInID,WhichFunction,Description,LogDateTime) VALUES("+LogInID.ToString()+",'"+WhichFunction+"','"+Description+"',GETDATE())");
        }

        public bool IsDuplicatedString(string TableName, string FieldName, string Value, string PKeyField, int PKey)
        {
            int cnt = ExecuteScalar<int>("SELECT COUNT(*) cnt FROM "+ TableName + " WHERE "+ FieldName + "='"+Value+"' AND "+PKeyField+"<>"+PKey.ToString());

            if (cnt > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsViewMainMenu(string MenuPK, string UserLevelPK)
        {
            int cnt = ExecuteScalar<int>("SELECT COUNT(*) cnt FROM sysMainMenuDefine WHERE mainmenuPK =" + MenuPK + " AND levelPK = " + UserLevelPK + " AND IsView = 1");

            if (cnt > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsAllow(string SubMenuPK, string UserLevelPK, string Function)
        {
            int cnt = 0;
            bool result = false;

            if (Function == "IsView")
            {
                cnt = ExecuteScalar<int>("SELECT COUNT(*) cnt FROM sysLevelDefine WHERE submenuPK =" + SubMenuPK + " AND levelPK = " + UserLevelPK + " AND dataView = 1");
                result = (cnt > 0) ? true : false;
            }
            else if (Function == "IsInsert")
            {
                cnt = ExecuteScalar<int>("SELECT COUNT(*) cnt FROM sysLevelDefine WHERE submenuPK =" + SubMenuPK + " AND levelPK = " + UserLevelPK + " AND dataInsert = 1");
                result = (cnt > 0) ? true : false;
            }
            else if (Function == "IsEdit")
            {
                cnt = ExecuteScalar<int>("SELECT COUNT(*) cnt FROM sysLevelDefine WHERE submenuPK =" + SubMenuPK + " AND levelPK = " + UserLevelPK + " AND dataEdit = 1");
                result = (cnt > 0) ? true : false;
            }
            else if (Function == "IsDelete")
            {
                cnt = ExecuteScalar<int>("SELECT COUNT(*) cnt FROM sysLevelDefine WHERE submenuPK =" + SubMenuPK + " AND levelPK = " + UserLevelPK + " AND dataDelete = 1");
                result = (cnt > 0) ? true : false;
            }

            return result;
        }

        public bool TestConnection()
        {
            bool result = false;
            if (!string.IsNullOrEmpty(connString))
            {
                try
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                        result = true;
                    }
                    else
                    {
                        con.Close();
                        con.Open();
                        result = true;
                    }
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    this.Close();
                }
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
