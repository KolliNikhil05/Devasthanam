using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class PaymentDoneCandidateDetailsBAL
    {
        PaymentDoneCandidateDetailsDAL paymented = new PaymentDoneCandidateDetailsDAL();
        public DataTable GetPaymentedCandidates()
        {
            return paymented.GetPaymentedCandidates();
        }
    }
}
