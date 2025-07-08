using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace PTTKHTTTProject.DAO
{
    public class NhanVienDAO
    {
        public static DataTable GetAllNhanVien()
        {
            return DataProvider.Instance.ExecuteQuerySP("usp_GetAllNhanVien");
        }

        public static DataTable SearchNhanVien(string searchTerm)
        {
            var parameter = new SqlParameter("@searchTerm", SqlDbType.NVarChar) { Value = searchTerm };
            return DataProvider.Instance.ExecuteQuerySP("usp_SearchNhanVien", parameter);
        }

        public static DataTable GetAllPhongBan()
        {
            return DataProvider.Instance.ExecuteQuerySP("usp_GetAllPhongBan");
        }

        public static bool AddNhanVien(string maNV, string tenNV, DateTime ngaySinh, string gioiTinh, string email, string sdt, string cccd, string diaChi, string chucVu, int luong, string maPhongBan)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaNhanVien", maNV),
                    new SqlParameter("@TenNhanVien", tenNV),
                    new SqlParameter("@NgaySinh", ngaySinh),
                    new SqlParameter("@GioiTinh", gioiTinh),
                    new SqlParameter("@Email", email),
                    new SqlParameter("@SDT", sdt),
                    new SqlParameter("@CCCD", cccd),
                    new SqlParameter("@DiaChi", diaChi),
                    new SqlParameter("@ChucVu", chucVu),
                    new SqlParameter("@Luong", luong),
                    new SqlParameter("@MaPhongBan", maPhongBan)
                };

                // Gọi stored procedure usp_AddNhanVien
                DataProvider.Instance.ExecuteNonQuerySP("usp_AddNhanVien", parameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public static bool DeleteNhanVien(string maNV)
        {
            try
            {
                var parameter = new SqlParameter("@MaNhanVien", SqlDbType.VarChar, 10) { Value = maNV };
                // Sử dụng ExecuteScalarSP<int> để nhận về giá trị 1 hoặc 0 từ SP
                int result = DataProvider.Instance.ExecuteScalarSP<int>("usp_DeleteNhanVien", parameter);
                return result == 1;
            }
            catch (Exception)
            {
                // Nếu có lỗi xảy ra, trả về false
                return false;
            }
        }

        public static DataTable getInfoEmployee(string username)
        {
            var pUser = new SqlParameter("@username", SqlDbType.VarChar, 10)
            { Value = username.Trim() };

            DataTable dt = DataProvider.Instance.ExecuteQuerySP("usp_GetInfomationOfUser", pUser);

            return dt;
        }

        public static DataTable GetRecipients()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT NV_MaNhanVien, NV_TenNhanVien, NV_ChucVu FROM NHANVIEN");

            return dt;
        }
    }
}