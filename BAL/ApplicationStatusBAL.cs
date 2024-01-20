using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class ApplicationStatusBAL
    {
        //public DataTable GetStatus(string phone)
        //{
        //    ApplicationStatusDAL objDal = new ApplicationStatusDAL();
        //    DataTable dataTable = objDal.GetStatus(phone);

        //    return dataTable;
        //}
        public DataSet GetStatus(string phone)
        {
            ApplicationStatusDAL objDal = new ApplicationStatusDAL();
            return objDal.GetStatus(phone);
        }

    }
}
