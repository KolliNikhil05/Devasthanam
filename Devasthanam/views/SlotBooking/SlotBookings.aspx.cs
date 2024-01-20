using BAL;
using DAL;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace Devasthanam.views.SlotBooking
{
    public partial class SlotBookings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [System.Web.Services.WebMethod]
        public static string GetCalendarData(int month, int year )
        {
            DataTable dataCalendar = SlotBookingsBAL.GetCalendarData();
            string json = DataTableToJson(dataCalendar);
            return json;
        }
        private static string DataTableToJson(DataTable dataCalendar)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var rows = new System.Collections.ArrayList();

            foreach (DataRow dr in dataCalendar.Rows)
            {
                var row = new System.Collections.Generic.Dictionary<string, object>();
                foreach (DataColumn col in dataCalendar.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }

            return serializer.Serialize(rows);
        }

        [WebMethod]
        public static string SlotBookingInsert(string bookingdate, string aadhar)

        {
            string Result = "";
            try
            {
                SlotBookingsBAL objSlot = new SlotBookingsBAL();
                DataTable dtSlot = objSlot.SlotDetailsInsert(bookingdate, aadhar);
                if (dtSlot.Rows.Count != 0)
                {
                    Result = JsonConvert.SerializeObject(dtSlot);
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
        public static string SlotBookingGet()
        {
            string Result = "";
            try
            {
                SlotBookingsBAL objSlot = new SlotBookingsBAL();
                DataTable dtSlot = objSlot.GetBookedSlotCountForAllDates();
                if (dtSlot.Rows.Count != 0)
                {
                    Result = JsonConvert.SerializeObject(dtSlot);
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
