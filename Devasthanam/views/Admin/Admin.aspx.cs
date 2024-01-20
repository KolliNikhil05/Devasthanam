using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Devasthanam
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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