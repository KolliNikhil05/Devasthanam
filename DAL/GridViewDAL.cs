﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevasthanamDAL;

namespace DAL
{
    public class GridViewDAL
    {
        public DataTable GetRecruiteePaymentData(string city)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection_data"].ConnectionString;
            DataTable RecruiteeData = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("registrations_Get", connection))
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

                using (SqlCommand cmd = new SqlCommand("registrations_Update", connection))
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

                using (SqlCommand cmd = new SqlCommand("registrations_delete", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@userId", userId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
