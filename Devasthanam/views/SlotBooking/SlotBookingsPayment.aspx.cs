using BAL;
using DAL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Devasthanam.views.SlotBooking
{
    public partial class SlotBookingsPayment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["aadhar"] != null && Session["bookingdate"] !=null)

                {
                    txtDate.Value = Session["bookingdate"].ToString();
                    txtAadhar.Value = Session["aadhar"].ToString();

                }
            }
        }
        [WebMethod]
        public static string SlotBookingPaymentInsert(string aadhar, string bookingdate)

        {
            string Result = "";
            try
            {
                SlotBookingsPaymentBAL objPayment = new SlotBookingsPaymentBAL();
                DataTable dtPayment = objPayment.BookingPaymentInsert(aadhar, bookingdate);
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
            if (context.Session["userid"] != null && context.Session["password"] != null && context.Session["aadhar"] != null && context.Session["bookingdate"] != null)
            {
                context.Session.Remove("userid");
                context.Session.Remove("password");
                context.Session.Remove("aadhar");
                context.Session.Remove("bookingdate");
                context.Session.Abandon();
            }

        }
    }
}