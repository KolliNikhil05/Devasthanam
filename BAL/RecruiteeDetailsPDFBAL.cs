using DAL;
using DevasthanamDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class RecruiteeDetailsPDFBAL
    {
        RecruiteeDetailsPDFDAL objDal = new RecruiteeDetailsPDFDAL();
        public DataTable GetCity()
        {
            return objDal.GetCity();
        }
    }
}
