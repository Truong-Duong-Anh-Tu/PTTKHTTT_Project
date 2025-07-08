using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Data.SqlClient;

namespace PTTKHTTTProject.DAO
{
    internal class PhieuDuThiDAO
    {
        public static DataTable getAllPhieuDuThi()
        {
            // Giả sử DataProvider.Instance.ExecuteQuerySP là phương thức để thực hiện truy vấn
            DataTable dt = DataProvider.Instance.ExecuteQuerySP("usp_GetAllPhieuDuThi");
            return dt;
        }
        public static DataTable getPhieuDuThi2Tuan()
        {
            // Giả sử DataProvider.Instance.ExecuteQuerySP là phương thức để thực hiện truy vấn
            DataTable dt = DataProvider.Instance.ExecuteQuerySP("usp_GetPhieuDuThi2Tuan");
            return dt;
        }
        public static DataTable TuDongLapPhieuDuThi()
        {
            // Gọi stored procedure không cần tham số
            DataTable dt = DataProvider.Instance.ExecuteQuerySP("usp_TuDongLapPhieuDuThi");
            return dt;
        }

        public static DataTable SearchPhieuDuThi(string searchTerm)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SearchTerm", searchTerm)
            };
            return DataProvider.Instance.ExecuteQuerySP("usp_SearchPhieuDuThi", parameters);
        }
    }
}
