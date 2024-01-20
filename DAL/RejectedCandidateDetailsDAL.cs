using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RejectedCandidateDetailsDAL
    {
        public DataTable GetRejectedCandidates()
        {
            DataTable dataRegistered = new DataTable();

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection_data"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("RejectedCandidateDetails_Get", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dataRegistered);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return dataRegistered;
        }
    }
}
