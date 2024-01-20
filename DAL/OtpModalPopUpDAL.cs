using DevasthanamDAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;

namespace DAL
{
    public class OtpModalPopUpDAL
    {
        public DataTable InsertOtp(string phone, string sentOtp)
        {
            SqlConnection con = new SqlConnection(Connection.connectionString_Devasthanam);
            DataTable otpDataInsert = new DataTable();
            SqlCommand cmd;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "OTP_Insert";
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@SentOtp", sentOtp);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(otpDataInsert);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            return otpDataInsert;
        }

        public DataSet UpdateValidate(string Phone, string SentOtp)
        {
            SqlConnection con = new SqlConnection(Connection.connectionString_Devasthanam);
            DataSet updateOTP = new DataSet();
            SqlCommand cmd;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ValidateOTP";
                cmd.Parameters.AddWithValue("@Phone", Phone);
                cmd.Parameters.AddWithValue("@SentOtp", SentOtp);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(updateOTP);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return updateOTP;
        }


    }
}
