using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediPro.Class;
using System.Data;
using System.Data.SqlClient;

namespace MediPro.Class
{
    public static class sysLogs
    {
        public static Class.clsSQL SqlDb = new Class.clsSQL();

        public static void logs_login()
        {
            SqlDb.ExecuteQuery("INSERT INTO sys_log(LogInID,WhichFunction,Description,LogDateTime) " +
                               "VALUES(@LogInID,@WhichFunction,@Description,SYSDATETIME())",
                               new SqlParameter("@LogInID", AppVariable.CURRENT_USER_PK),
                               new SqlParameter("@WhichFunction", "Login"),
                               new SqlParameter("@Description", "Login"));
        }

        public static void logs_logout()
        {
            SqlDb.ExecuteQuery("INSERT INTO sys_log(LogInID,WhichFunction,Description,LogDateTime) " +
                               "VALUES(@LogInID,@WhichFunction,@Description,SYSDATETIME())",
                               new SqlParameter("@LogInID", AppVariable.CURRENT_USER_PK),
                               new SqlParameter("@WhichFunction", "Logout"),
                               new SqlParameter("@Description", "Logout"));
        }

        public static void logsDetail(int menu_id, string action)
        {
            SqlDb.ExecuteQuery("INSERT INTO sys_log(LogInID,WhichFunction,Description,LogDateTime) " +
                               "VALUES(@LogInID,@WhichFunction,@Description,SYSDATETIME())",
                               new SqlParameter("@LogInID", AppVariable.CURRENT_USER_PK),
                               new SqlParameter("@WhichFunction", menu_id),
                               new SqlParameter("@Description", action));
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
