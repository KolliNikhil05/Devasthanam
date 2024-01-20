using DevasthanamDAL;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class RecruiteePaymentDAL
    {
        public DataTable RecruiteePaymentInsert(PaymentData data)
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
                cmd.CommandText = "RecruiteePayment_Insert";
                cmd.Parameters.AddWithValue("@Phone", data.phone);
               
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
    public class PaymentData

    {
        public string phone { get; set; }
    }
}