using PTTKHTTTProject.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHTTTProject.BUS
{
    internal class PhieuDangKyBUS
    {
        public static DataTable LayDSPhieuDangKy2Tuan()
        {
            DataTable dt = PhieuDangKyDAO.LayDSPhieuDangKy2Tuan();
            return dt;
        }
        public static DataTable LayDSPhieuDangKyConLai()
        {
            DataTable dt = PhieuDangKyDAO.LayDSPhieuDangKyConLai();
            return dt;
        }
    }
}
