using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; // required for ConfigurationManager

namespace Prj_NFL_Stats.DAL
{
    class UtilityDB
    {
        public static SqlConnection ConnectDB()
        {
            SqlConnection connDB = new SqlConnection();
            connDB.ConnectionString = ConfigurationManager.ConnectionStrings["NFL_Connection"].ConnectionString;
            connDB.Open();
            return connDB;
        }
    }
}
