using DevasthanamDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAL
{
    public class RecruiteeDetailsPDFDAL
    {
        public DataTable GetCity()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection_data"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("getExCity", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    DataTable cityData = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(cityData);
                    }
                    return cityData;
                }
            }
        }
    }
}
