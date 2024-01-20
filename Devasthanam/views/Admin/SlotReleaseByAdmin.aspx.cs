using BAL;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Web;
using System.Web.Services;

namespace Devasthanam.views.Admin
{
    public partial class SlotReleaseByAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static string SlotRelease()
        {
            string jsonResult = "";
            try
            {
                SlotReleaseByAdminBAL objSlot = new SlotReleaseByAdminBAL();
                DataTable dtRelease = objSlot.SlotRelease();
                if (dtRelease != null)
                {
                    jsonResult = JsonConvert.SerializeObject(dtRelease);
                    jsonResult.Replace(@"\", string.Empty);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }

            return (jsonResult);


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