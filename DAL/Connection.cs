using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevasthanamDAL
{
    public class Connection
    {
        public static string connectionString_Devasthanam = ConfigurationManager.ConnectionStrings["connection_data"].ToString();
            //using (SqlConnection con = new SqlConnection(connectionString))
             //SqlConnection conn = new SqlConnection(connectionString);
    }
}


