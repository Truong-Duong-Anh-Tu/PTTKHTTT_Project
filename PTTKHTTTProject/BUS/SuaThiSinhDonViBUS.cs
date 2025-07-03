using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTKHTTTProject.DAO;

namespace PTTKHTTTProject.BUS
{
    internal class SuaThiSinhDonViBUS
    {
        public static DataTable LoadThongTinThiSinh(string sbd)
        {
            return SuaThiSinhDonViDAO.LoadThongTinThiSinh(sbd);
        }

        public static void CapNhatThiSinh(string sbd, string hoTen, DateTime ngaySinh, string gioiTinh, string email, string sdt, string cccd)
        {
            SuaThiSinhDonViDAO.CapNhatThiSinh(sbd, hoTen, ngaySinh, gioiTinh, email, sdt, cccd);
        }

        public static bool XoaThiSinh(string sbd)
        {
            return SuaThiSinhDonViDAO.XoaThiSinh(sbd);
        }

    }
}
