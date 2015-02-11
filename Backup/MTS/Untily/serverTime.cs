using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MTS
{
    //抽象类,不许实例化
    public abstract class serverTime
    {
        

        private static DateTime getDateTime()
        {
            string connString=SqlHelper.ConnString;
            string cmdText = @"select getdate()";
            DateTime dateTime1 = (DateTime)SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText);
            return dateTime1;
        }

        public static DateTime sDateTime//系统时间
        {
            get
            { return getDateTime(); }
        }
    }
}
