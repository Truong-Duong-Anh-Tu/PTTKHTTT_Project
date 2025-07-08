using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using PTTKHTTTProject.DAO;
namespace PTTKHTTTProject.BUS
{
    internal class PhieuDuThiBUS
    {
        public static DataTable getAllPhieuDuThi()
        {
            return PhieuDuThiDAO.getAllPhieuDuThi();
        }
        public static DataTable getPhieuDuThi2Tuan()
        {
            return PhieuDuThiDAO.getPhieuDuThi2Tuan();
        }
        public static DataTable TuDongLapPhieuDuThi()
        {
            return PhieuDuThiDAO.TuDongLapPhieuDuThi();
        }
        public static DataTable SearchPhieuDuThi(string searchTerm)
        {
            return PhieuDuThiDAO.SearchPhieuDuThi(searchTerm);
        }
    }
}
