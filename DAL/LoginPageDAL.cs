using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace DevasthanamDAL
{
    public class LoginPageDAL
    {
        public DataSet GetLogin(LoginDetails LoginValues)
        {
            HttpContext context = HttpContext.Current;
            DataSet dt = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(Connection.connectionString_Devasthanam);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "LoginData_Get";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userId", LoginValues.phone);
                cmd.Parameters.AddWithValue("@Password", LoginValues.password);
                context.Session["userid"] = LoginValues.phone;
                context.Session["password"] = LoginValues.password;
                SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter(cmd);
                objSqlDataAdapter.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());

            }
            return dt;
        }
    }
    public class LoginDetails
    {
        public string phone { get; set; }
        public string password { get; set; }
    }

}


















    //public DataSet GetLogin(LoginData parameter)
    //{
    //    HttpContext context = HttpContext.Current;
    //    DataSet dt = new DataSet();
    //    try
    //    {
    //        SqlConnection con = new SqlConnection(Connection.connectionString_Devasthanam);
    //        con.Open();
    //        SqlCommand cmd = con.CreateCommand();
    //        cmd.CommandText = "LoginData_Get";
    //        cmd.CommandType = CommandType.StoredProcedure;
    //        cmd.Parameters.AddWithValue("@userId", parameter.phone);
    //        cmd.Parameters.AddWithValue("@Password", parameter.password);
    //        context.Session["userid"] = parameter.phone;
    //        context.Session["password"] = parameter.password;
    //        SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter(cmd);
    //        objSqlDataAdapter.Fill(dt);
    //        con.Close();
    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine(ex.Message);

    //    }
    //    return dt;
    //}

    //public class LoginData
    //{
    //    public string phone { get; set; }
    //    public string password { get; set; }
    //}





//public DataTable GetLogin(LoginData data)
//{
//    SqlConnection con = new SqlConnection(Connection.connectionString_Devasthanam);
//    DataTable datatable = new DataTable();
//    SqlCommand cmd;
//    try
//    {
//        if (con.State == ConnectionState.Closed)
//        {
//            con.Open();
//        }
//        cmd = con.CreateCommand();
//        cmd.CommandType = CommandType.StoredProcedure;
//        cmd.CommandText = "LoginData_Get ";
//        cmd.CommandType = CommandType.StoredProcedure;
//        cmd.Parameters.AddWithValue("@userId", data.userId);
//        cmd.Parameters.AddWithValue("@Password", data.password);
//        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
//        adapter.Fill(datatable);

//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//    return datatable;
//}









//public DataTable GetLoginData()
//{
//    SqlConnection conn = new SqlConnection(Connection.connectionString_Devasthanam);
//    DataTable dt = new DataTable();
//    SqlCommand cmd = null;
//    try
//    {
//        if (conn.State == ConnectionState.Closed)
//        {
//            conn.Open();
//        }
//        cmd = conn.CreateCommand();
//        cmd.CommandType = CommandType.StoredProcedure;
//        cmd.CommandText = "LoginData_Get";
//        SqlDataAdapter da = new SqlDataAdapter(cmd);
//        da.Fill(dt);
//    }
//    catch (Exception e)
//    {
//        throw new Exception(e.Message);
//    }
//    finally
//    {
//        if (conn.State == ConnectionState.Open)
//        {
//            conn.Close();
//        }

//    }
//    return dt;
//}


