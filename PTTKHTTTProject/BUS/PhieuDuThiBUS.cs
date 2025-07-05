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
            return PhieuDuThiDAO.getAllhieuDuThi();
        }
        public static DataTable TuDongLapPhieuDuThi()
        {
            return PhieuDuThiDAO.TuDongLapPhieuDuThi();
        }
    }
}
