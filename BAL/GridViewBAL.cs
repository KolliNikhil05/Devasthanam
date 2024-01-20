using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class GridViewBAL
    {
        GridViewDAL obj = new GridViewDAL();
        public DataTable GetRecruiteePaymentData(string city)
        {
            return obj.GetRecruiteePaymentData(city);
        }
        public void UpdateUser(string userId, string phone, string uName, string surName, string email, string gender, string dob, string city, string address, string qualification, string percentage, string payment)
        {
            GridViewDAL objUpdate = new GridViewDAL();
            objUpdate.UpdateUser(userId, phone, uName, surName, email, gender, dob, city, address, qualification, percentage, payment);
        }
        public void DeleteRecord(string userId)
        {
            GridViewDAL objDelete = new GridViewDAL();
            objDelete.DeleteRecord(userId);
        }
    }
}
