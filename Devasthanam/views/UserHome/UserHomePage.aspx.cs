using System;
using System.Web;
using System.Web.Profile;
using System.Web.Services;

namespace Devasthanam
{
    public partial class UserHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["userid"] != null)
                {
                    string userId = Session["userid"].ToString();
                    user.InnerText = $"User ID: {userId}";
                }
            }
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