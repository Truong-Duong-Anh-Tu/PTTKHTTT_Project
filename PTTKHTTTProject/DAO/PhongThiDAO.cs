using System.Data;

namespace PTTKHTTTProject.DAO
{
    public class PhongThiDAO
    {
        public static DataTable GetAllPhongThi()
        {
            // Gọi stored procedure để lấy tất cả phòng thi
            return DataProvider.Instance.ExecuteQuerySP("usp_GetAllPhongThi");
        }
    }
}