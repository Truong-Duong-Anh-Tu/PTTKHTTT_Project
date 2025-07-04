using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHTTTProject.DAO
{
    internal class InfoEmployeeDAO
    {
        public static DataTable getInfoEmployee(string username)
        {
            var pUser = new SqlParameter("@username", SqlDbType.VarChar, 10)
            { Value = username.Trim() };

            DataTable dt = DataProvider.Instance.ExecuteQuerySP("usp_GetInfomationOfUser", pUser);
            return dt;
        }
        public static DataTable GetAllNhanVien()
        {
            return DataProvider.Instance.ExecuteQuerySP("usp_GetAllNhanVien");
        }

        public static DataTable SearchNhanVien(string searchTerm)
        {
            var parameter = new SqlParameter("@searchTerm", SqlDbType.NVarChar) { Value = searchTerm };
            return DataProvider.Instance.ExecuteQuerySP("usp_SearchNhanVien", parameter);
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

        public static bool UpdateNhanVien(
            string maNV, string tenNV, DateTime ngaySinh, string gioiTinh, string email,
            string sdt, string cccd, string diaChi, string chucVu, int luong, string maPhongBan)
        {
            var parameters = new List<SqlParameter>
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

            // Thêm parameter để nhận giá trị RETURN
            var returnParam = new SqlParameter("@ReturnVal", System.Data.SqlDbType.Int)
            {
                Direction = System.Data.ParameterDirection.ReturnValue
            };
            parameters.Add(returnParam);

            DataProvider.Instance.ExecuteNonQuerySP("usp_UpdateNhanVien", parameters.ToArray());

            int result = (int)returnParam.Value;
            return result == 1;
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

        public static string GetTenNhanVien(string maNV)
        {
            try
            {
                var parameter = new SqlParameter("@MaNhanVien", SqlDbType.VarChar, 10) { Value = maNV };
                string? tenNV = DataProvider.Instance.ExecuteScalarSP<string>("usp_GetTenNhanVien", parameter);
                return tenNV ?? string.Empty;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
