using DAL;
using DevasthanamDAL;
using System;
using System.Data;

namespace DevasthanamBAL
{
    public class SignupBAL
    {
        SignupDAL objDal = new SignupDAL();
        public DataTable InsertSignUpData(string phone, string password, string confirmPassword)
        {
            try
            {
                return objDal.InsertSignUpData(phone, password, confirmPassword);
            }
            catch(Exception ex)  
            {
                 throw new Exception(ex.Message);
            }

        }
 

    }
}
