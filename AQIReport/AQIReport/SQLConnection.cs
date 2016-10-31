using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Cam
{
    class db
    {
        public static SqlConnection Camcon()
        {
            string strSQL = System.Configuration.ConfigurationManager.AppSettings["source"];
            return new SqlConnection(strSQL);
        }
        public static SqlConnection mingCon = Camcon();
    }
}