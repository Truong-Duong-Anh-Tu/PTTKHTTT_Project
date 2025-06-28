using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHTTTProject.DAO
{
    internal class EmployeeScheduleDAO
    {
        public static DataTable getEmployeeSchedule()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuerySP("usp_GetPhanCong");
            return dt;
        }
    }
}
