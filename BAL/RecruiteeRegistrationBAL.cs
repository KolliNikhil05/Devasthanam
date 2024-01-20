using DevasthanamDAL;
using System;
using System.Data;
namespace DevasthanamBAL
{
    public   class RecruiteeRegistrationBAL
    {
        RecruiteeRegistrationDAL objDal = new RecruiteeRegistrationDAL();
        public DataTable GetCities()
        {
            return objDal.GetCities();
        }
        public DataTable GetQualification()
        {
            return objDal.GetQualification();
        }
        public DataTable GetSlots()
        {
            throw new NotImplementedException();
        }
        public DataTable InsertRegistrationData(UserData data)
        {
            return objDal.InsertRegistrationData(data);
        }

    }

}
