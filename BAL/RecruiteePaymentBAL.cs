using DAL;
using DevasthanamDAL;
using System;
using System.Data;

namespace BAL
{
    public class RecruiteePaymentBAL
    {
        RecruiteePaymentDAL objDal = new RecruiteePaymentDAL();
        public DataTable RecruiteePaymentInsert(PaymentData data)
        {
            return objDal.RecruiteePaymentInsert(data);
        }
        
    }
}
