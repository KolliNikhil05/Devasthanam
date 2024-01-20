using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class JqueryDataTableBAL
    {
        public DataTable GetRecruiteeData()
        {
            JqueryDataTableDAL objData = new JqueryDataTableDAL();
            DataTable dataTable = objData.GetRecruiteeData();

            return dataTable;
        }
        public void UpdateUserData(string userId, string uName, string SurName, string Phone, string City)
        {
            JqueryDataTableDAL objUpdate = new JqueryDataTableDAL();
            objUpdate.UpdateUserData(userId, uName, SurName, Phone, City);
        }
        public void DeleteUserData(string userId)
        {
            JqueryDataTableDAL objDelete = new JqueryDataTableDAL();
            objDelete.DeleteUserData(userId);
        }



    }
}
