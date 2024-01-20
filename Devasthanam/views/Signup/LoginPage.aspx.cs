using Devasthanam.views.Utilities;
using DevasthanamBAL;
using DevasthanamDAL;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Web.Services;

namespace Devasthanam
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        [WebMethod]
        public static string GetLogin(LoginDetails LoginValues)
        {
            string jsonresult = " ";
            try
            {
                LoginPageBAL objLoginBal = new LoginPageBAL();
                DataSet dataLogin = objLoginBal.GetLogin(LoginValues);
               
           
                if (dataLogin.Tables.Count > 1)
                {
                    jsonresult = JsonConvert.SerializeObject(dataLogin);
                }
                else
                {
                    jsonresult = JsonConvert.SerializeObject(dataLogin);
                }
            }
            catch (Exception ex)
            {
                LogExceptions.LogException2("GetLogin", "101", ex.Message);                
            }
          return jsonresult;
        }
    }
}
 