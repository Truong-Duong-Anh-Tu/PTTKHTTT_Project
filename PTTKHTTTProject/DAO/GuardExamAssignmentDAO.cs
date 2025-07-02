using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHTTTProject.DAO
{
    internal class GuardExamAssignmentDAO
    {
        public static DataTable getAssignment()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuerySP("usp_XemLichPhanCong");

            return dt;
        }
    }
}
