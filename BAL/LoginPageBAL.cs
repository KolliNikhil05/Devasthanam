using DevasthanamDAL;
using System;
using System.Data;

namespace DevasthanamBAL
{
    public class LoginPageBAL
    {
            public DataSet GetLogin(LoginDetails LoginValues)
            {
            try
            {
                LoginPageDAL objLoginDal = new LoginPageDAL();
                return objLoginDal.GetLogin(LoginValues);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
