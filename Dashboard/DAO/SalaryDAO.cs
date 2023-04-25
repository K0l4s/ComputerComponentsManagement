using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.DAO
{
    public class SalaryDAO
    {
        private static SalaryDAO instance;

        public static SalaryDAO Instance
        {
            get { if (instance == null) instance = new SalaryDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable LoadTable(DateTime dayStart, DateTime dayEnd)
        {
            string query = "SELECT * FROM dbo.FUNC_TOTAL_SALARY ( @dayStart , @dayEnd )";
            object[] parameters = new object[] { dayStart, dayEnd };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, parameters);
            return dt;
        }

        public DataTable SearchTable(int? employeeID, DateTime? dayStart, DateTime? dayEnd)
        {
            DataTable dt = null;

            string query = "SELECT * FROM dbo.FUNC_SEARCH_TOTAL_SALARY ( @employeeID , @dayStart , @dayEnd )";
            object[] parameters = new object[] { employeeID, dayStart, dayEnd };
            dt = DataProvider.Instance.ExecuteQuery(query, parameters);
            return dt;
        }

    }
}
