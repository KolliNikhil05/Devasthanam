using DevasthanamDAL;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SlotBookingsPaymentDAL
    {
        public DataTable BookingPaymentInsert(string aadhar, string bookingdate)
        {
            SqlConnection con = new SqlConnection(Connection.connectionString_Devasthanam);
            DataTable RecruiteePaymentInsert = new DataTable();
            SqlCommand cmd;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SlotBookingPayment_Insert";
                cmd.Parameters.AddWithValue("@Aadhar", aadhar);
                cmd.Parameters.AddWithValue("@BookingDate", bookingdate);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(RecruiteePaymentInsert);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return RecruiteePaymentInsert;
        }
    }
}
