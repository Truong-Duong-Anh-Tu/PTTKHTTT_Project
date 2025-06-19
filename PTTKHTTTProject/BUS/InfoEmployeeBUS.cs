using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTKHTTTProject.DAO;

namespace PTTKHTTTProject.BUS
{
    internal class InfoEmployeeBUS
    {
        public static Dictionary<string, string> getInfoOfUser(string username)
        {
            Dictionary<string, string> info = new Dictionary<string, string>();

            DataTable dt = InfoEmployeeDAO.getInfoEmployee(username.Trim());
            var row = dt.Rows[0];

            info["MaNV"] = row["NV_MaNhanVien"].ToString() ?? "Unknown";
            info["Hoten"] = row["NV_TenNhanVien"].ToString() ?? "Unknown";
            info["NSinh"] = Convert.ToDateTime(row["NV_NgaySinh"]).ToString("dd/MM/yyyy") ?? "Unknown";
            info["GTinh"] = row["NV_GioiTinh"].ToString() ?? "Unknown";
            info["Email"] = row["NV_Email"].ToString() ?? "Unknown";
            info["SDT"] = row["NV_SDT"].ToString() ?? "Unknown";
            info["CCCD"] = row["NV_CCCD"].ToString() ?? "Unknown";
            info["DChi"] = row["NV_DiaChi"].ToString() ?? "Unknown";
            info["ChucVu"] = row["NV_ChucVu"].ToString() ?? "Unknown";
            info["Luong"] = row["NV_Luong"].ToString() ?? "Unknown";
            info["MaPB"] = row["NV_MaPhongBan"].ToString() ?? "Unknown";

            return info;
        }
    }
}
