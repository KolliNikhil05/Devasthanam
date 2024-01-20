using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class QualifiedCandidateDetailsBAL
    {
        QualifiedCandidateDetailsDAL qualified = new QualifiedCandidateDetailsDAL();
        public DataTable GetQualifiedCandidates()
        {
            return qualified.GetQualifiedCandidates();
        }
    }
}
