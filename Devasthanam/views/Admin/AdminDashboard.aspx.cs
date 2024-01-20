using BAL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Devasthanam.views.Admin
{
    public partial class AdminDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        [WebMethod]
        public static string CandidateDetails()
        {
            string JsonResult = "";
            AdminDashboardBAL detailsobj = new AdminDashboardBAL();
            DataSet dataDetails = detailsobj.CandidateDetails();
            JsonResult = JsonConvert.SerializeObject(dataDetails);
            return JsonResult;

        }

        [WebMethod]
        public static void Logout()
        {
            HttpContext context = HttpContext.Current;
            if (context.Session["userid"] != null && context.Session["password"] != null)
            {
                context.Session.Remove("userid");
                context.Session.Remove("password");
                context.Session.Abandon();
            }

        }
    }
}