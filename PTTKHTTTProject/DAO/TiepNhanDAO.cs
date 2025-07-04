using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PTTKHTTTProject.DAO
{
    public class TiepNhanDAO
    {
        public static DataTable TraCuuPhieuDangKy(string MaPhieu)
        {
            return DataProvider.Instance.ExecuteQuerySP(
                "TraCuuPhieuDangKyCoBan",
                new SqlParameter("@MaPhieu", SqlDbType.VarChar, 10) { Value = MaPhieu }
            );
        }

        public static DataTable TraCuuThiSinh(string MaPhieu)
        {
            string query = @"
                   SELECT TS_SoBaoDanh, TS_HoTen, TS_NgaySinh, TS_GioiTinh, TS_Email, TS_SDT, TS_CCCD
                   FROM THISINH
                   WHERE TS_MaPhieuDangKy = @MaPhieu";

            return DataProvider.Instance.ExecuteQuery(
                query,
                new SqlParameter("@MaPhieu", SqlDbType.VarChar, 10) { Value = MaPhieu }
            );
        }

        public static DataTable TimThiSinh(string tuKhoa, string maPhieu)
        {
            string query = @"
                   SELECT TS_SoBaoDanh, TS_HoTen, TS_NgaySinh, TS_GioiTinh, TS_Email, TS_SDT, TS_CCCD
                   FROM THISINH
                   WHERE TS_MaPhieuDangKy = @maPhieu AND 
                         (TS_SoBaoDanh = @tuKhoa OR TS_HoTen LIKE N'%' + @TuKhoa + '%')";

            return DataProvider.Instance.ExecuteQuery(
                query,
                new SqlParameter("@TuKhoa", SqlDbType.NVarChar, 100) { Value = tuKhoa },
                new SqlParameter("@maPhieu", SqlDbType.VarChar, 10) { Value = maPhieu }
            );
        }

        public static void CapNhatThiSinhTuDo(string sbd, string hoTen, DateTime ngaySinh, string gioiTinh, string email, string sdt, string cccd)
        {
            string query = @"
                   UPDATE THISINH
                   SET TS_HoTen = @HoTen,
                       TS_NgaySinh = @NgaySinh,
                       TS_GioiTinh = @GioiTinh,
                       TS_Email = @Email,
                       TS_SDT = @SDT,
                       TS_CCCD = @CCCD
                   WHERE TS_SoBaoDanh = @SBD";

            DataProvider.Instance.ExecuteNonQuery(
                query,
                new SqlParameter("@HoTen", hoTen),
                new SqlParameter("@NgaySinh", ngaySinh),
                new SqlParameter("@GioiTinh", gioiTinh),
                new SqlParameter("@Email", email),
                new SqlParameter("@SDT", sdt),
                new SqlParameter("@CCCD", cccd),
                new SqlParameter("@SBD", sbd)
            );
        }

        public static void CapNhatPhieuDangKy(string MaPhieu, string TenKH, string LoaiKH, string SDT, string Email, string DiaChi)
        {
            DataProvider.Instance.ExecuteNonQuerySP(
                "CapNhatPhieuDangKy",

                new SqlParameter("@MaPhieu", SqlDbType.VarChar, 10) { Value = MaPhieu },
                new SqlParameter("@TenKH", SqlDbType.NVarChar, 50) { Value = TenKH },
                new SqlParameter("@LoaiKH", SqlDbType.NVarChar, 20) { Value = LoaiKH },
                new SqlParameter("@SDT", SqlDbType.Char, 10) { Value = SDT },
                new SqlParameter("@Email", SqlDbType.Char, 100) { Value = Email },
                new SqlParameter("@DiaChi", SqlDbType.NVarChar, 100) { Value = DiaChi }
            );
        }

        public static bool XoaPhieuDangKy(string MaPhieu)
        {
            try
            {
                DataProvider.Instance.ExecuteNonQuerySP(
                    "XoaPhieuDangKy",
                    new SqlParameter("@MaPhieu", SqlDbType.VarChar, 10) { Value = MaPhieu }
                );

                return true; // nếu không có exception thì coi như xóa thành công
            }
            catch (Exception ex)
            {
                // Ghi log nếu cần
                Console.WriteLine("Lỗi khi xóa phiếu: " + ex.Message);
                return false;
            }
        }

        public static string? LayTenNhanVienTheoEmail(string MaNV)
        {
            string query = "SELECT NV_TenNhanVien FROM NHANVIEN WHERE NV_MaNhanVien = @MaNV";

            var result = DataProvider.Instance.ExecuteScalar(query,
                new SqlParameter("@MaNV", SqlDbType.Char, 100) { Value = MaNV });

            return result?.ToString();
        }

        public static DataTable LayDanhSachKyThi()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT KT_MaKyThi, KT_TenKyThi FROM KYTHI");
        }

        public static DataTable LayNgayThiTheoKyThi(string maKyThi)
        {
            string query = "SELECT DISTINCT LT_NgayThi FROM LICHTHI WHERE LT_MaKyThi = @maKyThi";
            return DataProvider.Instance.ExecuteQuery(query, new SqlParameter("@maKyThi", maKyThi));
        }

        public static DataTable LayThoiGianTheoNgayThi(string maKyThi, DateTime ngayThi)
        {
            string query = @"
                   SELECT 
                   LT_MaLichThi,
                   CONVERT(varchar(5), LT_TGBatDau, 108) + ' - ' + CONVERT(varchar(5), LT_TGKetThuc, 108) AS ThoiGianThi
                   FROM LICHTHI
                   WHERE LT_MaKyThi = @maKyThi AND LT_NgayThi = @ngayThi";

            return DataProvider.Instance.ExecuteQuery(query,
                new SqlParameter("@maKyThi", maKyThi),
                new SqlParameter("@ngayThi", ngayThi));
        }


        public static string ThemPhieuDangKy(
            DateTime ngayLap, string diaChi, string maLichThi, string maNV,
            string loaiKH, string emailKH, string sdtKH, string tenKH, DataTable dsThiSinh)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@NgayLap", ngayLap),
        new SqlParameter("@DiaChi", diaChi),
        new SqlParameter("@MaLichThi", maLichThi),
        new SqlParameter("@MaNhanVien", maNV),
        new SqlParameter("@LoaiKhachHang", loaiKH),
        new SqlParameter("@Email", emailKH),
        new SqlParameter("@SDT", sdtKH),
        new SqlParameter("@TenKhachHang", tenKH),
        new SqlParameter("@DanhSachThiSinh", SqlDbType.Structured)
        {
            TypeName = "ThiSinhTableType", Value = dsThiSinh
        }
            };

            DataTable result = DataProvider.Instance.ExecuteQuery("EXEC ThemPhieuDangKyVaThiSinh @NgayLap, @DiaChi, @MaLichThi, @MaNhanVien, @LoaiKhachHang, @Email, @SDT, @TenKhachHang, @DanhSachThiSinh", parameters);

            if (result.Rows.Count > 0)
            {
                return result.Rows[0]["MaPhieuMoi"].ToString();
            }

            return null;
        }

    }
}
