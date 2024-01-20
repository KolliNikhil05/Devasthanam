using DevasthanamDAL;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SlotReleaseByAdminDAL
    {
        public DataTable SlotRelease()
        {
            SqlConnection conn = new SqlConnection(Connection.connectionString_Devasthanam);
            DataTable dtRelease = new DataTable();
            SqlCommand cmd = null;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SlotRelease_Insert";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtRelease);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return dtRelease;
        }
    }
    //public class SlotReleaseByAdminDAL
    //{
    //    public DataTable SlotRelease()
    //    {
    //        SqlConnection conn = new SqlConnection(Connection.connectionString_Devasthanam);
    //        DataTable dtRelease = new DataTable();
    //        SqlCommand cmd = null;
    //        try
    //        {
    //            if (conn.State == ConnectionState.Closed)
    //            {
    //                conn.Open();
    //            }
    //            cmd = conn.CreateCommand();
    //            cmd.CommandType = CommandType.StoredProcedure;
    //            cmd.CommandText = "SlotRelease_Insert";
    //            cmd.Parameters.AddWithValue("@Month",null );
    //            cmd.Parameters.AddWithValue("@Year", null);
    //            cmd.Parameters.AddWithValue("@IsReleased", null);
    //            cmd.Parameters.AddWithValue("@TicketCount",null );
    //            cmd.Parameters.AddWithValue("@DayLimit",null );
    //            cmd.Parameters.AddWithValue("@CreatedBy",null );
    //            cmd.Parameters.AddWithValue("@CreatedTime",null );
    //            SqlDataAdapter da = new SqlDataAdapter(cmd);
    //            da.Fill(dtRelease);
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception(ex.Message);
    //        }
    //        finally
    //        {
    //            if (conn.State == ConnectionState.Open)
    //            {
    //                conn.Close();
    //            }
    //        }
    //        return dtRelease;
    //    }
    //}
}
