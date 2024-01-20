using DAL;
using System.Data;

namespace BAL
{
    public class OtpModalPopUpBAL
    {
        OtpModalPopUpDAL objOTP = new OtpModalPopUpDAL();
        public DataTable InsertOtp(string phone, string sentOtp)
        {
            return objOTP.InsertOtp(phone,sentOtp);
        }
        public DataSet UpdateValidate(string Phone, string SentOtp)
        {
            return objOTP.UpdateValidate(Phone, SentOtp);
        }
    }
}
