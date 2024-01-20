using BAL;
using DAL;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Web.Services;

namespace Devasthanam.views.Test
{
    public partial class OtpModalPopUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["userid"] != null)
                {
                    string userId = Session["userid"].ToString();
                    txtPhoneNumber.Value = $"{userId}";
                }
            }
        }
        [WebMethod]
        public static string OTP_Insert(string phone)
        {
            string Result = "";
            try
            {
                Random rand = new Random();
                int sentOtp = rand.Next(1000, 10000); 
                OtpModalPopUpBAL objOTP = new OtpModalPopUpBAL();
                DataTable dtOTP = objOTP.InsertOtp(phone, sentOtp.ToString());
                if (dtOTP.Rows.Count != 0)
                {
                    Result = JsonConvert.SerializeObject(dtOTP);
                    Result = Result.Replace(@"\", string.Empty);
                }
            }
            catch (Exception ex)
            {
            }
            return Result;
        }
        [WebMethod]
        public static string OTPValidate(string Phone, string SentOtp)
        {
            string Result = "";
            try
            {
                OtpModalPopUpBAL objOTP = new OtpModalPopUpBAL();
                DataSet dsValidate = objOTP.UpdateValidate(Phone, SentOtp);

                if (dsValidate.Tables.Count > 0 && dsValidate.Tables[0].Rows.Count > 0)
                {
                    Result = JsonConvert.SerializeObject(dsValidate.Tables[0]);
                    Result = Result.Replace(@"\", string.Empty);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Result;
        }

    }
}