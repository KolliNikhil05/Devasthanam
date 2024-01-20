using DAL;
using System.Data;

namespace BAL
{
    public class SlotBookingsBAL
    {
        public static DataTable GetCalendarData()
        {
            return SlotBookingsDAL.GetCalendarData();
        }
        SlotBookingsDAL objSlot = new SlotBookingsDAL();
        public DataTable SlotDetailsInsert(string bookingdate, string aadhar)
        {
            return objSlot.SlotDetailsInsert(bookingdate, aadhar);
        }

        public DataTable GetBookedSlotCountForAllDates()
        {
            return objSlot.GetBookedSlotCountForAllDates();
        }
    }
}
