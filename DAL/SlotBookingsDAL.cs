using DevasthanamDAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace DAL
{
    public class SlotBookingsDAL
    {

        public static DataTable GetCalendarData()
        {
            using (SqlConnection con = new SqlConnection(Connection.connectionString_Devasthanam))
            {
                using (SqlCommand cmd = new SqlCommand("CombinedSlotData_Get", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtCalendar = new DataTable();
                    da.Fill(dtCalendar);

                    con.Close();
                    return dtCalendar;
                }
            }
        }

        public DataTable SlotDetailsInsert(string bookingdate,string aadhar)
        {
            HttpContext context = HttpContext.Current;
            SqlConnection con = new SqlConnection(Connection.connectionString_Devasthanam);
            DataTable SlotInsert = new DataTable();
            SqlCommand cmd;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SlotBooking_Insert";
                cmd.Parameters.AddWithValue("@BookingDate", bookingdate);
                cmd.Parameters.AddWithValue("@Aadhar", aadhar);
                context.Session["aadhar"] = aadhar;
                context.Session["bookingdate"] = bookingdate;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(SlotInsert);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return SlotInsert;
        }


        public DataTable GetBookedSlotCountForAllDates()
        {
            DataTable bookedSlotCounts = new DataTable();

            using (SqlConnection con = new SqlConnection(Connection.connectionString_Devasthanam))
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    using (SqlCommand cmd = new SqlCommand("GetBookedSlotCountForAllDates", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(bookedSlotCounts);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return bookedSlotCounts;
        }
    }
}
     

