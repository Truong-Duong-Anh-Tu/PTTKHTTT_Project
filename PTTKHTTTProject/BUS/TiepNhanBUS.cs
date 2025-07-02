using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTKHTTTProject.DAO;

namespace PTTKHTTTProject.BUS
{
    internal class TiepNhan
    {
        public static DataTable TraCuuPhieuDangKy(string MaPhieu)
        {
            // Gọi từ DAO và xử lý nghiệp vụ nếu cần
            return TiepNhanDAO.TraCuuPhieuDangKy(MaPhieu);
        }

        public static DataTable TraCuuThiSinh(string MaPhieu) 
        {
            return TiepNhanDAO.TraCuuThiSinh(MaPhieu);
        }

        public static DataTable TimThiSinh(string HoTen)
        {
            return TiepNhanDAO.TimThiSinh(HoTen);
        }

    }
}
