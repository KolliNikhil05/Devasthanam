using DevasthanamDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class AdminDashboardBAL
    {
        public DataSet CandidateDetails()
        {
            AdminDashboardDAL detailsobj = new AdminDashboardDAL();
            DataSet dataDetails = detailsobj.CandidateDetails();
            return dataDetails;
        }
    }
}
