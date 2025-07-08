using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHTTTProject.DAO
{
    internal class DepartmentDAO
    {
        public static string getDepartmentName(string department)
        {
            var pDepartment = new SqlParameter("@department", SqlDbType.VarChar, 10)
            { Value = department.Trim() };

            object result = DataProvider.Instance.ExecuteScalar("SELECT PB_TenPhongBan FROM PHONGBAN WHERE PB_MaPhongBan = @department", pDepartment);

            string? departmentName = result != null && result != DBNull.Value ? result.ToString() : string.Empty;

            return $"{departmentName}";
        }

        public static DataTable GetAllPhongBan()
        {
            return DataProvider.Instance.ExecuteQuerySP("usp_GetAllPhongBan");
        }
    }
}
