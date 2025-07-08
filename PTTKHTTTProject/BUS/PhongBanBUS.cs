using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using PTTKHTTTProject.DAO;
namespace PTTKHTTTProject.BUS
{
    internal class PhongBanBUS
    {
        public static DataTable GetAllPhongBan()
        {
            return PhongBanDAO.GetAllPhongBan();
        }
        public static string GetMaPhongBanByTen(string tenPhongBan)
        {
            if (string.IsNullOrWhiteSpace(tenPhongBan))
                return string.Empty;
            DataTable dt = PhongBanDAO.GetPhongBanByTenPhongBan(tenPhongBan);
            if (dt.Rows.Count > 0)
                return dt.Rows[0]["PB_MaPhongBan"].ToString() ?? string.Empty;
            return string.Empty;
        }

    }
}
