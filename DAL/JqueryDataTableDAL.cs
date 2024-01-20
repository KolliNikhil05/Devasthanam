using DevasthanamDAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace DAL
{
    public class JqueryDataTableDAL
    {
        public DataTable GetRecruiteeData()
        {
            HttpContext context = HttpContext.Current;
            DataTable dt = new DataTable();
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
                cmd.CommandText = "JDTData_Get";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }
        public void UpdateUserData(string userId, string uName, string SurName, string Phone, string City)
        {
            using (SqlConnection connection = new SqlConnection(Connection.connectionString_Devasthanam))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("JDTData_Update", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@uName", uName);
                    command.Parameters.AddWithValue("@SurName", SurName);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@City", City);

                    command.ExecuteNonQuery();
                }
            }
        }
        public  void DeleteUserData(string userId)
        {
            using (SqlConnection connection = new SqlConnection(Connection.connectionString_Devasthanam))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("JDTData_Delete", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@userId", userId);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
