using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Repository
{
    public class StudentRepository
    {
        public DataTable GetStaticDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Mobile_Number", typeof(long));
            dataTable.Columns.Add("Age", typeof(int));
            AddDataRow(dataTable, 1, "Nikhil", 9494379292, 21);
            AddDataRow(dataTable, 2, "Hari", 9666541644, 21);
            return dataTable;
        }
        private void AddDataRow(DataTable dataTable, int id, string name, long number, int Age)
        {
            DataRow row = dataTable.NewRow();
            row["Id"] = id;
            row["Name"] = name;
            row["Mobile_Number"] = number;
            row["Age"] = Age;
            dataTable.Rows.Add(row);
        }
    }
}
