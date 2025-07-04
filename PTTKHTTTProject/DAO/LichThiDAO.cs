using System.Data;
using Microsoft.Data.SqlClient;

namespace PTTKHTTTProject.DAO
{
    public class LichThiDAO
    {
        public static DataTable GetAllLichThi()
        {
            return DataProvider.Instance.ExecuteQuerySP("usp_GetLichThi");
        }

        // PHƯƠNG THỨC MỚI
        public static DataTable GetLichThiByPhongThi(string maPhongThi)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaPhongThi", maPhongThi)
            };
            return DataProvider.Instance.ExecuteQuerySP("usp_GetLichThiByPhongThi", parameters);
        }
    }
}