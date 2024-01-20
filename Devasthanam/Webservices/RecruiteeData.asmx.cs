using DevasthanamDAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Services;

namespace Devasthanam.Webservices
{
    /// <summary>
    /// Summary description for RecruiteeData
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RecruiteeData : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Nikhil World";
        }
        [WebMethod]
        public DataTable GetRecruiteeData()
        {
            //HttpContext context = HttpContext.Current;
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Connection.connectionString_Devasthanam);
            SqlCommand cmd;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "JDTData_Get";

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dt.TableName = "RecruiteeData";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return dt;
        }
    }
}
