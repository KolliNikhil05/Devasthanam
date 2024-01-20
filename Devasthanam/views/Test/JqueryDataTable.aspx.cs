using BAL;
using DevasthanamDAL;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Services;

namespace Devasthanam.views.Test
{
    public partial class JqueryDataTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static string GetData()
        {
            string jsonResult = "";
            JqueryDataTableBAL objData = new JqueryDataTableBAL();
            DataTable dataTable = objData.GetRecruiteeData();
            jsonResult = JsonConvert.SerializeObject(dataTable);
            return jsonResult;
        }
        [WebMethod]
        public static void UpdateData(string userId, string uName, string SurName, string Phone, string City)
        {
            JqueryDataTableBAL objUpdate = new JqueryDataTableBAL();
            objUpdate.UpdateUserData(userId, uName, SurName, Phone, City);
        }
        [WebMethod]
        public static void DeleteData(string userId)
        {
            JqueryDataTableBAL objDelete = new JqueryDataTableBAL();
            objDelete.DeleteUserData(userId);
        }
    }
}