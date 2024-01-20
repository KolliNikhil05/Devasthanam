using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class RejectedCandidateDetailsBAL
    {
        RejectedCandidateDetailsDAL rejected = new RejectedCandidateDetailsDAL();
        public DataTable GetRejectedCandidates()
        {
            return rejected.GetRejectedCandidates();
        }
    }
}
