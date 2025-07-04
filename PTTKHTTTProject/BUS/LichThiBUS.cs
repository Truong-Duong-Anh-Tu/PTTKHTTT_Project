using System.Data;
using PTTKHTTTProject.DAO;

namespace PTTKHTTTProject.BUS
{
    public class LichThiBUS
    {
        public DataTable GetAllLichThi()
        {
            return LichThiDAO.GetAllLichThi();
        }

        // PHƯƠNG THỨC MỚI
        public DataTable GetLichThiByPhongThi(string maPhongThi)
        {
            return LichThiDAO.GetLichThiByPhongThi(maPhongThi);
        }
    }
}