using System.Data;
using PTTKHTTTProject.DAO;

namespace PTTKHTTTProject.BUS
{
    public class LichThiBUS
    {
        /// <summary>
        /// Lấy danh sách lịch thi từ tầng DAO.
        /// </summary>
        /// <returns>DataTable chứa danh sách lịch thi.</returns>
        public DataTable GetAllLichThi()
        {
            return LichThiDAO.GetAllLichThi();
        }
    }
}