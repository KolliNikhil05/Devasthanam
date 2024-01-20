using DevasthanamDAL;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class RecruiteePaymentDetailsDAL
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
                    DataTable dt = new DataTable();          
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                    return dt;
                }
            }
        }
        public DataTable GetRecruiteePaymentData(string city)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection_data"].ConnectionString;
            DataTable RecruiteeData = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("RecruiteePaymentData_Get", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@City", city);
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(RecruiteeData);
                    }
                }
            }
            return RecruiteeData;
        }
        public void UpdateUser(string userId, string phone, string uName, string surName, string email, string gender, string dob, string city, string address, string qualification, string percentage, string payment)
        {
            using (SqlConnection connection = new SqlConnection(Connection.connectionString_Devasthanam))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("UpdateRegistration_Data", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@uName", uName);
                    cmd.Parameters.AddWithValue("@surName", surName);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@qualification", qualification);
                    cmd.Parameters.AddWithValue("@percentage", percentage);
                    cmd.Parameters.AddWithValue("@payment", payment);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleteRecord(string userId)
        {
            using (SqlConnection connection = new SqlConnection(Connection.connectionString_Devasthanam))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("DeleteRegistration_Data", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@userId", userId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void InsertUser(string userId, string uName, string surName, string phone, string email, string gender, string dob, string city, string address, string qualification, string percentage, string certificate, string payment)
        {
            using (SqlConnection connection = new SqlConnection(Connection.connectionString_Devasthanam))
            {
                using (SqlCommand command = new SqlCommand("InsertRegistration", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@uName", uName);
                    command.Parameters.AddWithValue("@surName", surName);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@dob", dob);
                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@qualification", qualification);
                    command.Parameters.AddWithValue("@percentage", percentage);
                    command.Parameters.AddWithValue("@UCertificate", certificate);
                    command.Parameters.AddWithValue("@payment", payment);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
