using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace PTTKHTTTProject.DAO
{
    internal class PhieuDuThiDAO
    {
        public static DataTable getAllhieuDuThi()
        {
            // Giả sử DataProvider.Instance.ExecuteQuerySP là phương thức để thực hiện truy vấn
            DataTable dt = DataProvider.Instance.ExecuteQuerySP("usp_GetAllPhieuDuThi");
            return dt;
        }
        public static DataTable TuDongLapPhieuDuThi()
        {
            // Gọi stored procedure không cần tham số
            DataTable dt = DataProvider.Instance.ExecuteQuerySP("usp_TuDongLapPhieuDuThi");
            return dt;
        }

    }
}
