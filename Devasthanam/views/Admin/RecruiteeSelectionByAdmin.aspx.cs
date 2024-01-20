using BAL;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Web;
using System.Web.Services;

namespace Devasthanam.views.Admin
{
    public partial class RecruiteeSelectionByAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static string GetData()
        {
            string jsonResult = "";
            RecruiteeSelectionByAdminBAL objData = new RecruiteeSelectionByAdminBAL();
            DataTable dataSelection = objData.GetRecruiteeData();
            jsonResult = JsonConvert.SerializeObject(dataSelection);
            return jsonResult;
        }
 
        [WebMethod]
        public static string Selection(string phone)

        {
            string Result = "";
            try
            {
                RecruiteeSelectionByAdminBAL objPayment = new RecruiteeSelectionByAdminBAL();
                DataTable dtSelection = objPayment.SelectionRecruitee(phone);
                if (dtSelection.Rows.Count != 0)
                {
                    Result = JsonConvert.SerializeObject(dtSelection);
                    Result.Replace(@"\", string.Empty);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Result;

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
