using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace exaCore
{
    public class clsSQL
    {        
        static string connString = "";
        public MySqlConnection con;
        private MySqlTransaction rTran;

        public clsSQL()
        {
            connString = ConfigurationManager.ConnectionStrings["CnnpMediPro"].ToString();
            con = new MySqlConnection(connString);
        }

        public clsSQL(string ConnectionString)
        {
            connString = ConnectionString;
            con = new MySqlConnection(connString);
        }

        ~clsSQL()
        {
        }

        public MySqlTransaction myTrans
        {
            set { rTran = value; }
            get { return rTran; }
        }



        public DType ExecuteScalar<DType>(string SqlString, params MySqlParameter[] parameters)
        {
            DType result = default(DType);

            if (!string.IsNullOrEmpty(SqlString))
            {
                using (MySqlCommand command = new MySqlCommand(SqlString, con))
                {
                    if (parameters != null && parameters.Length > 0)
                    {
                        foreach (MySqlParameter parameter in parameters)
                        {

                            command.Parameters.Add(parameter);
                        }
                    }
                    try
                    {
                        if (con.State != ConnectionState.Open)
                            con.Open();
                        result = (DType)Convert.ChangeType(command.ExecuteScalar(), typeof(DType));
                        //result = (DType)command.ExecuteScalar();
                        return result;

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

        public DType ExecuteScalar<DType>(string SqlString, CommandType type, MySqlParameter[] parm)
        {

            DType result = default(DType);

            if (!string.IsNullOrEmpty(SqlString))
            {
                using (MySqlCommand command = new MySqlCommand(SqlString, con))
                {
                    command.CommandType = type;
                    if (parm != null && parm.Length > 0)
                    {
                        foreach (MySqlParameter parameter in parm)
                        {
                            command.Parameters.Add(parameter);
                        }
                    }
                    try
                    {
                        con.Open();
                        result = (DType)Convert.ChangeType(command.ExecuteScalar(), typeof(DType));
                        //object objResult = command.ExecuteScalar();

                        //switch (Type.GetTypeCode(objResult.GetType()))
                        //{ 
                        //    case TypeCode.Int16:
                        //        result = Convert.ToInt32(objResult);
                        //        break;

                        //    case TypeCode.String:
                        //        break;

                        //    case TypeCode.Boolean:
                        //        break;
                        //}
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

        public bool ExecuteQuery(string commandText, CommandType type, params MySqlParameter[] parms)
        {
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = commandText;
            cmd.CommandType = type;           

            bool result = false;

            if (parms != null && parms.Length > 0)
            {
                foreach (MySqlParameter p in parms)
                {
                    cmd.Parameters.Add(p);
                }
            }

            try
            {                
                if (con.State != ConnectionState.Open)
                    con.Open();
                MySqlTransaction sqlTran;
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
        public bool ExecuteQuery(MySqlCommand oSqlCommand)
        {  
            oSqlCommand.Connection = con;
            bool result = false;

            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                MySqlTransaction sqlTran;
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

        public bool ExecuteQuery(string commandText, params MySqlParameter[] parms)
        {
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = commandText;

            bool result = false;

            if (parms != null && parms.Length > 0)
            {
                foreach (MySqlParameter p in parms)
                {
                    cmd.Parameters.Add(p);
                }
            }

            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                MySqlTransaction sqlTran;
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

        public bool ExecuteNonQuery(string commandText, params MySqlParameter[] parms)
        {

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = commandText;

            bool result = false;

            if (parms != null && parms.Length > 0)
            {
                foreach (MySqlParameter p in parms)
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

        public DataSet GetDataSet(string tblname, string commandtext, CommandType type, params MySqlParameter[] parm)
        {
            MySqlCommand cmd = new MySqlCommand(commandtext, con);
            cmd.CommandType = type;
            DataSet result = new DataSet();
            if (parm != null && parm.Length > 0)
            {
                foreach (MySqlParameter p in parm)
                {
                    cmd.Parameters.Add(p);
                }
            }
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
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

        public DataSet GetDataSet(string tblname, string commandtext, params MySqlParameter[] parm)
        {
            MySqlCommand cmd = new MySqlCommand(commandtext, con);
            DataSet result = new DataSet();
            if (parm != null && parm.Length > 0)
            {
                foreach (MySqlParameter p in parm)
                {
                    cmd.Parameters.Add(p);
                }
            }
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
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

        public DataSet GetDataSet(string commandtext, params MySqlParameter[] parm)
        {
            MySqlCommand cmd = new MySqlCommand(commandtext, con);
            DataSet result = new DataSet();
            if (parm != null && parm.Length > 0)
            {
                foreach (MySqlParameter p in parm)
                {
                    cmd.Parameters.Add(p);
                }
            }
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
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
            object cnt = ExecuteScalar<object>("SELECT COUNT(*) cnt FROM "+ TableName + " WHERE "+ FieldName + "='"+Value+"' AND "+PKeyField+"<>"+PKey.ToString());

            if (Convert.ToInt32(cnt) > 0)
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
            object cnt = ExecuteScalar<object>("SELECT COUNT(*) cnt FROM sysMainMenuDefine WHERE mainmenuPK =" + MenuPK + " AND levelPK = " + UserLevelPK + " AND IsView = 1");

            if (Convert.ToInt32( cnt) > 0)
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
            object cnt = 0;
            bool result = false;

            if (Function == "IsView")
            {
                cnt = ExecuteScalar<object>("SELECT COUNT(*) cnt FROM sysLevelDefine WHERE submenuPK =" + SubMenuPK + " AND levelPK = " + UserLevelPK + " AND dataView = 1");
                result = (Convert.ToInt32(cnt) > 0) ? true : false;
            }
            else if (Function == "IsInsert")
            {
                cnt = ExecuteScalar<object>("SELECT COUNT(*) cnt FROM sysLevelDefine WHERE submenuPK =" + SubMenuPK + " AND levelPK = " + UserLevelPK + " AND dataInsert = 1");
                result = (Convert.ToInt32(cnt) > 0) ? true : false;
            }
            else if (Function == "IsEdit")
            {
                cnt = ExecuteScalar<object>("SELECT COUNT(*) cnt FROM sysLevelDefine WHERE submenuPK =" + SubMenuPK + " AND levelPK = " + UserLevelPK + " AND dataEdit = 1");
                result = (Convert.ToInt32(cnt) > 0) ? true : false;
            }
            else if (Function == "IsDelete")
            {
                cnt = ExecuteScalar<object>("SELECT COUNT(*) cnt FROM sysLevelDefine WHERE submenuPK =" + SubMenuPK + " AND levelPK = " + UserLevelPK + " AND dataDelete = 1");
                result = (Convert.ToInt32(cnt) > 0) ? true : false;
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
                catch (MySqlException ex)
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
