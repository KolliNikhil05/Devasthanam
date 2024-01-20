using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Web;

namespace DevasthanamDAL
{
    public class SignupDAL
    {
        
        public DataTable InsertSignUpData(string phone, string password, string confirmPassword)
        {
            SqlConnection conn = new SqlConnection(Connection.connectionString_Devasthanam);
            DataTable dtSignup = new DataTable();
            SqlCommand cmd = null;
            try 
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                    cmd=conn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SignupData_Insert";
                    cmd.Parameters.AddWithValue("@userId", phone);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@cPassword", confirmPassword);
                   
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtSignup);                
            }
            catch(Exception ex)  
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }     
            }
            return dtSignup;
        }


    }
}
