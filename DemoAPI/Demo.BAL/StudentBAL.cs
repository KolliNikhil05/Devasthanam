using Demo.Business.Contracts;
using Demo.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BAL
{
    public class StudentBAL : StudentInterface
    {
        StudentRepository repositary = new StudentRepository();

        public DataTable GetMyDataList()
        {
            DataTable dataTable = repositary.GetStaticDataTable();  
            return dataTable;
        }

    }
}
