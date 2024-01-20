using BAL;
using Devasthanam.views.Utilities;
using DevasthanamBAL;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Web.Services;

namespace Devasthanam
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void pageLoad()
        {
            
        }
        [WebMethod] 
        public static string  InsertSignUpData(string phone, string password, string confirmPassword)
        {
            string jsonResult = "";
            try
            {
                SignupBAL objSignUp = new SignupBAL();
                DataTable dtSignup = objSignUp.InsertSignUpData(phone, password, confirmPassword);
                if(dtSignup != null )
                {
                    jsonResult = JsonConvert.SerializeObject(dtSignup);
                    jsonResult.Replace(@"\", string.Empty);
                }
            }
            catch(Exception ex)
            {
                LogExceptions.aspException("InsertSignUpData", "101", ex.Message);
            }
            
            return(jsonResult);
            
           
        }
 

    }
}
 

