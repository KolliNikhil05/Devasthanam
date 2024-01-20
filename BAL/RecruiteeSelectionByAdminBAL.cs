using DAL;
using System.Data;

namespace BAL
{
    public class RecruiteeSelectionByAdminBAL
    {
        public DataTable GetRecruiteeData()
        {
            RecruiteeSelectionByAdminDAL objDal = new RecruiteeSelectionByAdminDAL();
            DataTable dataTable = objDal.GetRecruiteeData();
           
            return dataTable;
        }
        //public void SelectionRecruitee(string phone)
        //{
        //    RecruiteeSelectionByAdminDAL objUpdate = new RecruiteeSelectionByAdminDAL();
        //    objUpdate.SelectionRecruitee(phone);
        //}
        public DataTable SelectionRecruitee(string phone)

        {
            RecruiteeSelectionByAdminDAL objselect = new RecruiteeSelectionByAdminDAL();
            return objselect.SelectionRecruitee(phone);
        }
    }
}
