using DevasthanamDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdminDashboardDAL
    {
        public DataSet CandidateDetails()
        {
            SqlConnection con = new SqlConnection(Connection.connectionString_Devasthanam);
            DataSet Detailsdt = new DataSet();
            SqlCommand cmd;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd = con.CreateCommand();
                cmd.CommandText = "Dashboard_Get";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(Detailsdt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Detailsdt;
        }
    }
}
