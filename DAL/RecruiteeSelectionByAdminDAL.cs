using DevasthanamDAL;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;
using System.Web;

namespace DAL
{
    public class RecruiteeSelectionByAdminDAL
    {
        public DataTable GetRecruiteeData()
        {
            HttpContext context = HttpContext.Current;
            DataTable dtSelection = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.connectionString_Devasthanam);
            SqlCommand cmd;
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RegistrationData_Get";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtSelection);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dtSelection;
        }

        public DataTable SelectionRecruitee(string phone)
        {
            SqlConnection con = new SqlConnection(Connection.connectionString_Devasthanam);
            DataTable SelectionInsert = new DataTable();
            SqlCommand cmd;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RecruiteeSelection_Update";
                cmd.Parameters.AddWithValue("@Phone", phone);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(SelectionInsert);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return SelectionInsert;
        }
    }
}

