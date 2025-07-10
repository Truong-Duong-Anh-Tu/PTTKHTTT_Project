using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using PTTKHTTTProject.DAO;

namespace PTTKHTTTProject.BUS
{
    internal class InfoEmployeeBUS
    {
        private string _username;

        public InfoEmployeeBUS(string username)
        {
            _username = username.Trim();
        }

        public Dictionary<string, string> getInfoOfUser()
        {
            Dictionary<string, string> info = new Dictionary<string, string>();

            DataTable dt = InfoEmployeeDAO.getInfoEmployee(_username);
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
        public static DataTable GetAllNhanVien()
        {
            return InfoEmployeeDAO.GetAllNhanVien();
        }

        public static DataTable SearchNhanVien(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return GetAllNhanVien();

            return InfoEmployeeDAO.SearchNhanVien(searchTerm);
        }
        public static bool AddNhanVien(string maNV, string tenNV, DateTime ngaySinh, string gioiTinh, string email, string sdt, string cccd, string diaChi, string chucVu, int luong, string maPhongBan)
        {
            // (Tùy chọn) Thêm các bước kiểm tra logic nghiệp vụ ở đây trước khi gọi DAO
            return InfoEmployeeDAO.AddNhanVien(maNV, tenNV, ngaySinh, gioiTinh, email, sdt, cccd, diaChi, chucVu, luong, maPhongBan);
        }

        public static bool DeleteNhanVien(string maNV)
        {
            return InfoEmployeeDAO.DeleteNhanVien(maNV);
        }

        public static string GetTenNhanVien(string maNV)
        {
            if (string.IsNullOrWhiteSpace(maNV))
                return string.Empty;
            return InfoEmployeeDAO.GetTenNhanVien(maNV);
        }

        public static bool UpdateNhanVien(
            string maNV, string tenNV, DateTime ngaySinh, string gioiTinh, string email,
            string sdt, string cccd, string diaChi, string chucVu, int luong, string maPhongBan)
        {
            return InfoEmployeeDAO.UpdateNhanVien(maNV, tenNV, ngaySinh, gioiTinh, email, sdt, cccd, diaChi, chucVu, luong, maPhongBan);
        }

        public static DataTable GetAvailableNhanVien()
        {
            return InfoEmployeeDAO.GetAvailableNhanVien();
        }

        public static List<string> getAllRecipientEmployee()
        {
            List<string> recipients = new List<string>();

            DataTable dt1 = InfoEmployeeDAO.GetRecipients();

            foreach (DataRow dr in dt1.Rows)
            {
                string temp = $"{dr["NV_MaNhanVien"].ToString()} - {dr["NV_TenNhanVien"].ToString()} - {dr["NV_ChucVu"].ToString()}";
                recipients.Add(temp);
            }
            return recipients;
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidPhone(string phone)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{10}$");
        }

        public static bool IsValidCCCD(string cccd)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(cccd, @"^\d{12}$");
        }
    }
}
