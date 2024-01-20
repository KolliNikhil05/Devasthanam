using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class RegisteredCandidateDetailsBAL
    {
        RegisteredCandidateDetailsDAL registered = new  RegisteredCandidateDetailsDAL();
        public DataTable GetRegisteredCandidates()
        {
            return registered.GetRegisteredCandidates();
        }
    }
}
