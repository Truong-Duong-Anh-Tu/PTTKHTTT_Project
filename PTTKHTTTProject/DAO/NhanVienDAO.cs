using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace PTTKHTTTProject.DAO
{
    public class NhanVienDAO
    {
        public static DataTable GetAllNhanVien()
        {
            return DataProvider.Instance.ExecuteQuerySP("usp_GetAllNhanVien");
        }

        public static DataTable SearchNhanVien(string searchTerm)
        {
            var parameter = new SqlParameter("@searchTerm", SqlDbType.NVarChar) { Value = searchTerm };
            return DataProvider.Instance.ExecuteQuerySP("usp_SearchNhanVien", parameter);
        }

        public static DataTable GetAllPhongBan()
        {
            return DataProvider.Instance.ExecuteQuerySP("usp_GetAllPhongBan");
        }

 
    }
}