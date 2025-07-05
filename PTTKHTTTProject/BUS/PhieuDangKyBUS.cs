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
        public static DataTable LayDSPhieuDangKy3Tuan()
        {
            DataTable dt = PhieuDangKyDAO.LayDSPhieuDangKy3Tuan();
            return dt;
        }
    }
}
