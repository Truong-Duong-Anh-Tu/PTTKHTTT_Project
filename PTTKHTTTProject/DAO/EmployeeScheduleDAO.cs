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

        // THÊM PHƯƠNG THỨC MỚI
        public static bool UpdateEmployeeSchedule(string maLichThi, string maNVCU, string maNVMoi)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaLichThi", maLichThi),
                new SqlParameter("@MaNhanVienCu", maNVCU),
                new SqlParameter("@MaNhanVienMoi", maNVMoi)
            };
            int result = DataProvider.Instance.ExecuteScalarSP<int>("usp_UpdatePhanCong", parameters);
            return result == 1;
        }

        public static bool DeleteEmployeeSchedule(string maLichThi, string maNhanVien)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaLichThi", maLichThi),
                new SqlParameter("@MaNhanVien", maNhanVien)
            };
            int result = DataProvider.Instance.ExecuteScalarSP<int>("usp_DeletePhanCong", parameters);
            return result == 1;
        }
    }
}
