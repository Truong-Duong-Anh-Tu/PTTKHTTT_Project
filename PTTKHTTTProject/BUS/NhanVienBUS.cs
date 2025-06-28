using System.Data;
using PTTKHTTTProject.DAO;

namespace PTTKHTTTProject.BUS
{
    public class NhanVienBUS
    {
        public static DataTable GetAllNhanVien()
        {
            return NhanVienDAO.GetAllNhanVien();
        }
        
        public static DataTable SearchNhanVien(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return GetAllNhanVien();
            
            return NhanVienDAO.SearchNhanVien(searchTerm);
        }
        public static bool AddNhanVien(string maNV, string tenNV, DateTime ngaySinh, string gioiTinh, string email, string sdt, string cccd, string diaChi, string chucVu, int luong, string maPhongBan)
        {
            // (Tùy chọn) Thêm các bước kiểm tra logic nghiệp vụ ở đây trước khi gọi DAO
            return NhanVienDAO.AddNhanVien(maNV, tenNV, ngaySinh, gioiTinh, email, sdt, cccd, diaChi, chucVu, luong, maPhongBan);
        }
    }
}