using BAL;
using DAL;
using DevasthanamDAL;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Web;
using System.Web.Services;

namespace Devasthanam.views.Recruitment
{
    public partial class RecruiteePayment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static string RecruiteePaymentInsert(PaymentData data)

        {
            string Result = "";
            try
            {
                RecruiteePaymentBAL objPayment = new RecruiteePaymentBAL();
                DataTable dtPayment = objPayment.RecruiteePaymentInsert(data);
                if (dtPayment.Rows.Count != 0)
                {
                    Result = JsonConvert.SerializeObject(dtPayment);
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