using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AQMS
{
    public class SQLOperation
    {
        public SQLOperation()
        {

        }

        public SqlConnection SQLConnection()
        {
            string strSQL = System.Configuration.ConfigurationManager.ConnectionStrings["source"].ConnectionString;
            return new SqlConnection(strSQL);
        }


    }
}
