using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Web;

namespace DevasthanamDAL
{
    public class RecruiteeRegistrationDAL
    {
        HttpContext context = HttpContext.Current;
        public DataTable GetCities()
        {
            SqlConnection con = new SqlConnection(Connection.connectionString_Devasthanam);
            //using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                DataTable dtCity = new DataTable();
                SqlCommand cmd = null;
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "City_Get";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtCity);
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
                return dtCity;
            }
        }
        public DataTable GetQualification()
        {
            SqlConnection con = new SqlConnection(Connection.connectionString_Devasthanam);
            //using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                DataTable dtQualification = new DataTable();
                SqlCommand cmd = null;
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Qualification_Get";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtQualification);
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
                return dtQualification;

            }
        }
        public DataTable InsertRegistrationData(UserData data)
        {
            SqlConnection con = new SqlConnection(Connection.connectionString_Devasthanam);
            DataTable RegistrationDataInsert = new DataTable();
            SqlCommand cmd;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RegistrationData_Insert";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@uName", data.name); 
                cmd.Parameters.AddWithValue("@SurName", data.surname);
                cmd.Parameters.AddWithValue("@Phone", data.phone);
                cmd.Parameters.AddWithValue("@Email", data.email);
                cmd.Parameters.AddWithValue("@Gender", data.gender);
                cmd.Parameters.AddWithValue("@DOB", data.dob);
                cmd.Parameters.AddWithValue("@City", data.city);
                cmd.Parameters.AddWithValue("@UAddress", data.address);
                cmd.Parameters.AddWithValue("@Qualification", data.qualification);
                cmd.Parameters.AddWithValue("@UPercentage", data.percentage);
                cmd.Parameters.AddWithValue("@UCertificate", data.upload);
                context.Session["userid"] = data.phone;
                //SqlParameter sqlParameter = cmd.Parameters.AddWithValue("@UCertificate", context.Session["file"].ToString());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(RegistrationDataInsert);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return RegistrationDataInsert;
        }
    }
    public class UserData

    {
        public string name { get; set; }
        public string surname { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string dob { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public string qualification { get; set; }
        public string percentage { get; set; }
        public string upload { get; set; }

    }


}





















//    public DataTable InsertRegistrationData(string name, string surname, string phone, string email,
//    string gender, string dob, string city, string address, string qualification, string percentage,
//    string upload)
//    {
//        SqlConnection conn = new SqlConnection(Connection.connectionString_Devasthanam);
//        DataTable dt = new DataTable();
//        SqlCommand cmd = null;
//        try
//        {
//            if (conn.State == ConnectionState.Closed)
//            {
//                conn.Open();
//            }
//            cmd = conn.CreateCommand();
//            cmd.CommandType = CommandType.StoredProcedure;
//            cmd.CommandText = "InsertRegistrationData";
//            cmd.Parameters.AddWithValue("@uName",name);
//            cmd.Parameters.AddWithValue("@SurName",surname);
//            cmd.Parameters.AddWithValue("@Phone",phone);
//            cmd.Parameters.AddWithValue("@Email", email);
//            cmd.Parameters.AddWithValue("@Gender", gender);
//            cmd.Parameters.AddWithValue("@DOB",dob);
//            cmd.Parameters.AddWithValue("@City",city);
//            cmd.Parameters.AddWithValue("@UAddress",address);
//            cmd.Parameters.AddWithValue("@Qualification", qualification);
//            cmd.Parameters.AddWithValue("@UPercentage", percentage);
//            cmd.Parameters.AddWithValue("@UCertificate", upload);

//            SqlDataAdapter da = new SqlDataAdapter(cmd);
//            da.Fill(dt);
//        }
//        catch (Exception ex)
//        {
//            throw new Exception(ex.Message);
//        }
//        //finally
//        //{
//        //    if (conn.State == ConnectionState.Open)
//        //    {
//        //        conn.Close();
//        //    }

//        //}
//        return dt;

//    }
//}



