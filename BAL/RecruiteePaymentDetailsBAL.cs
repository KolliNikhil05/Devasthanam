using DAL;
using System.Data;

namespace BAL
{
    public class RecruiteePaymentDetailsBAL
    {
        RecruiteePaymentDetailsDAL obj = new RecruiteePaymentDetailsDAL();
        public DataTable GetCity()
        {
            return obj.GetCity();
        }
        public DataTable GetRecruiteePaymentData(string city)
        {
            return obj.GetRecruiteePaymentData(city);
        }
        public void UpdateUser(string userId, string phone, string uName, string surName, string email, string gender, string dob, string city, string address, string qualification, string percentage, string payment)
        {
            RecruiteePaymentDetailsDAL objUpdate = new RecruiteePaymentDetailsDAL();
            objUpdate.UpdateUser(userId,phone, uName, surName, email, gender, dob, city, address, qualification, percentage, payment);
        }
        public void DeleteRecord(string userId)
        {
            RecruiteePaymentDetailsDAL objDelete = new RecruiteePaymentDetailsDAL();
            objDelete.DeleteRecord(userId);
        }
        public void InsertUser(string userId, string uName, string surName, string phone, string email, string gender, string dob, string city, string address, string qualification, string percentage, string certificate, string payment)
        {
            RecruiteePaymentDetailsDAL objInsert = new RecruiteePaymentDetailsDAL();
            objInsert.InsertUser(userId, uName, surName, phone, email, gender, dob, city, address, qualification, percentage, certificate, payment);
        }
    }
}
