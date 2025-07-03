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

        public static DataTable TimThiSinh(string tuKhoa, string maPhieu)
        {
            return TiepNhanDAO.TimThiSinh(tuKhoa, maPhieu);
        }

        public static void CapNhatThiSinhTuDo(string sbd, string hoTen, DateTime ngaySinh, string gioiTinh, string email, string sdt, string cccd)
        {
            TiepNhanDAO.CapNhatThiSinhTuDo(sbd, hoTen, ngaySinh, gioiTinh, email, sdt, cccd);
        }

        public static void CapNhatPhieuDangKy(string MaPhieu, string TenKH, string LoaiKH, string SDT, string Email, string DiaChi)
        {
            TiepNhanDAO.CapNhatPhieuDangKy(MaPhieu, TenKH, LoaiKH, SDT, Email, DiaChi);
        }

        public static bool XoaPhieuDangKy(string MaPhieu)
        {
            return TiepNhanDAO.XoaPhieuDangKy(MaPhieu);
        }

        public static string? LayTenNhanVien(string email)
        {
            return TiepNhanDAO.LayTenNhanVienTheoEmail(email);
        }

    }
}
