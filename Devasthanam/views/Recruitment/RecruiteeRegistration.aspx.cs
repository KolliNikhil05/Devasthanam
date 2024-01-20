using Devasthanam.views.Utilities;
using DevasthanamBAL;
using DevasthanamDAL;
using Newtonsoft.Json;
using System;
using System.Data;
using System.EnterpriseServices;
using System.Net;
using System.Security.Policy;
using System.Web;
using System.Web.Services;
using System.Xml.Linq;


namespace Devasthanam
{
    public partial class RecruiteeRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod(EnableSession = true)]
        public static string CitiesGet()
        {
            string jsonResult = "";
            try
            {
                RecruiteeRegistrationBAL objCities = new RecruiteeRegistrationBAL();
                DataTable dtResult = objCities.GetCities();
                if (dtResult.Rows.Count > 0)
                {
                    jsonResult = JsonConvert.SerializeObject(dtResult);
                    jsonResult.Replace(@"\", string.Empty);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return (jsonResult);

        }

        [WebMethod(EnableSession = true)]
        public static string QualificationGet()
        {
            string jsonResult = "";
            try
            {
                RecruiteeRegistrationBAL objQualification = new RecruiteeRegistrationBAL();
                DataTable dtResults = objQualification.GetQualification();
                if (dtResults.Rows.Count > 0)
                {
                    jsonResult = JsonConvert.SerializeObject(dtResults);
                    jsonResult.Replace(@"\", string.Empty);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return (jsonResult);

        }
        [WebMethod]
        public static string InsertRegistrationData(UserData data)

        {
            string Result = "";
            try
            {
                RecruiteeRegistrationBAL objRegistartion = new RecruiteeRegistrationBAL();
                DataTable dtRegistration = objRegistartion.InsertRegistrationData(data);
                if (dtRegistration.Rows.Count != 0)
                {
                    Result = JsonConvert.SerializeObject(dtRegistration);
                    Result.Replace(@"\", string.Empty);
                }
            }
            catch (Exception ex)
            {
                LogExceptions.RegistrationException("InsertRegistrationData", "101", ex.Message);
            }
            return Result;

        }

        [WebMethod]
        public static void Logout()
        {
            HttpContext context = HttpContext.Current;
            if (context.Session["userid"] != null && context.Session["password"] != null)
            {
                context.Session.Remove("userid");
                context.Session.Remove("password");
                context.Session.Abandon();
            }

        }



    }

}























//public static string InsertRegistrationData(string name, string surname, string phone, string email,
//    string gender, string dob, string city, string address, string qualification, string percentage,
//    string upload)
//{
//    string jsonResult = "";
//    try
//    {
//        RecruiteeRegistrationBAL objbal2 = new RecruiteeRegistrationBAL();


//        DataTable dt = objbal2.InsertRegistrationData(name, surname, phone, email,
//   gender, dob, city, address, qualification, percentage, upload);
//        if (dt.Rows.Count != 0)
//        {
//            jsonResult = JsonConvert.SerializeObject(dt);
//            jsonResult.Replace(@"\", string.Empty);
//        }
//    }
//    catch (Exception ex)
//    {
//        throw new Exception(ex.Message);
//    }

//    return (jsonResult);
//}






