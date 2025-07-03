using System.Data;
using PTTKHTTTProject.DAO;

namespace PTTKHTTTProject.DAO
{
    public class LichThiDAO
    {
        /// <summary>
        /// Gọi Stored Procedure usp_GetLichThi để lấy toàn bộ danh sách lịch thi.
        /// </summary>
        /// <returns>Một DataTable chứa danh sách lịch thi.</returns>
        public static DataTable GetAllLichThi()
        {
            return DataProvider.Instance.ExecuteQuerySP("usp_GetLichThi");
        }
    }
}