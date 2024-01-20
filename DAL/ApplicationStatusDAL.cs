using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace DAL
{
    public class ApplicationStatusDAL
    {
     
        public DataSet GetStatus(string phone)
        {
            HttpContext context = HttpContext.Current;
            DataSet dataStatus = new DataSet();
            string connectionString = ConfigurationManager.ConnectionStrings["connection_data"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ApplicationStatus_Get";
                cmd.Parameters.AddWithValue("@Phone", phone);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataStatus);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return dataStatus;
        }
    }
}

