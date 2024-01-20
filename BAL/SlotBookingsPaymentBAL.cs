using DAL;
using System.Data;

namespace BAL
{
    public class SlotBookingsPaymentBAL
    {
        SlotBookingsPaymentDAL objBooking = new SlotBookingsPaymentDAL();
        public DataTable BookingPaymentInsert(string aadhar, string bookingdate)
        {
            return objBooking.BookingPaymentInsert(aadhar, bookingdate);
        }
    }
}
