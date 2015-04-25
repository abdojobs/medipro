using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace exaCore
{
    public static class sysLogs
    {
        public static clsSQL SqlDb = new clsSQL();

        public static void logs_login()
        {
            SqlDb.ExecuteQuery("INSERT INTO sys_log(LogInID,WhichFunction,Description,LogDateTime) " +
                               "VALUES(@LogInID,@WhichFunction,@Description,NOW())",
                               new MySqlParameter("@LogInID", AppVariable.CURRENT_USER_PK),
                               new MySqlParameter("@WhichFunction", "Login"),
                               new MySqlParameter("@Description", "Login"));
        }

        public static void logs_logout()
        {
            SqlDb.ExecuteQuery("INSERT INTO sys_log(LogInID,WhichFunction,Description,LogDateTime) " +
                               "VALUES(@LogInID,@WhichFunction,@Description,NOW())",
                               new MySqlParameter("@LogInID", AppVariable.CURRENT_USER_PK),
                               new MySqlParameter("@WhichFunction", "Logout"),
                               new MySqlParameter("@Description", "Logout"));
        }

        public static void logsDetail(int menu_id, string action)
        {
            SqlDb.ExecuteQuery("INSERT INTO sys_log(LogInID,WhichFunction,Description,LogDateTime) " +
                               "VALUES(@LogInID,@WhichFunction,@Description,NOW())",
                               new MySqlParameter("@LogInID", AppVariable.CURRENT_USER_PK),
                               new MySqlParameter("@WhichFunction", menu_id),
                               new MySqlParameter("@Description", action));
        }

    //        Public Sub sysLogs_login()
    //    GenerateLOGPK()
    //    SQLTransection.InsertData("sys_logs (logPK, login_time, userPK)", "'" & LOG_PK & "', NOW(), " & CURRENT_USER_PK)
    //End Sub

    //Public Sub sysLogs_logout()
    //    SQLTransection.UpdateData("sys_logs", "logout_time = NOW()", "logPK = '" & LOG_PK & "' AND userPK = " & CURRENT_USER_PK)
    //    LOG_PK = Nothing
    //End Sub

    //Public Sub sysLogsDetail(ByVal menu_id As Integer, ByVal action As String)
    //    SQLTransection.InsertData("sys_logs_detail (logPK, menuPK, action, time)", "'" & LOG_PK & "', " & menu_id & ", '" & action & "', NOW()")
    //End Sub
    }
}
