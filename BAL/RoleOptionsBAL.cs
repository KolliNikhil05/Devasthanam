using DAL;
using System.Collections.Generic;
using System.Data;

namespace BAL
{
    public class RoleOptionsBAL
    {
        public RoleOptionsDAL dal = new RoleOptionsDAL();

        public DataTable GetDistricts()
        {
            return dal.GetDistricts();
        }

        public DataTable GetMandals(string districtId)
        {
            return dal.GetMandals(districtId);
        }

        public DataTable GetSkills()
        {
            return dal.GetSkills();
        }

        public DataTable GetRoles(string skillId)
        {
            return dal.GetRoles(skillId);
        }

        public DataTable GetRoleById(string roleId)
        {
            RoleOptionsDAL roleDAL = new RoleOptionsDAL();
            return roleDAL.GetRoleById(roleId);
        }

        public void InsertData(string name, string surName, string district, string mandal, string gender, string skills, string roles, string dob, string upload)
        {

                dal.InsertData(name, surName, district, mandal, gender, skills, roles, dob, upload);
                     
        }

    }
}



















//using DAL;
//using DevasthanamDAL;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BAL
//{
//    public class RoleOptionsBAL
//    {
//        RoleOptionsDAL objDal = new RoleOptionsDAL();

//        public void BindDistrictDropdown()
//        {
//            objDal.BindDistrictDropdown();
//        }
//        RoleOptionsDAL objDal2 = new RoleOptionsDAL();
//        public void ddlDistrict_SelectedIndexChanged()
//        {
//            objDal2.ddlDistrict_SelectedIndexChanged();
//        }

//    }
//}
