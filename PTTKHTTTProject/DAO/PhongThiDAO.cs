using System.Data;
using Microsoft.Data.SqlClient;

namespace PTTKHTTTProject.DAO
{
    public class PhongThiDAO
    {
        public static DataTable GetAllPhongThi()
        {
            return DataProvider.Instance.ExecuteQuerySP("usp_GetAllPhongThi");
        }

        // PHƯƠNG THỨC MỚI
        public static bool AddPhongThi(string maPhong, string hinhThuc, int slToiDa, int slToiThieu, int slNhanVien)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@PT_MaPhongThi", maPhong),
                    new SqlParameter("@PT_HinhThuc", hinhThuc),
                    new SqlParameter("@PT_SLThiSinhToiDa", slToiDa),
                    new SqlParameter("@PT_SLThiSinhToiThieu", slToiThieu),
                    new SqlParameter("@PT_SLNhanVienCoiThi", slNhanVien)
                };
                DataProvider.Instance.ExecuteNonQuerySP("usp_AddPhongThi", parameters);
                return true;
            }
            catch (SqlException)
            {
                // Có thể log lỗi ở đây nếu cần
                return false;
            }
        }

        public static string GetLastPhongThiId()
        {
            try
            {
                return DataProvider.Instance.ExecuteScalarSP<string>("usp_GetLastPhongThiId");
            }
            catch (SqlException)
            {
                return null;
            }
        }

        public static bool UpdatePhongThi(string maPhong, string hinhThuc, int slToiDa, int slToiThieu, int slNhanVien)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@PT_MaPhongThi", maPhong),
                    new SqlParameter("@PT_HinhThuc", hinhThuc),
                    new SqlParameter("@PT_SLThiSinhToiDa", slToiDa),
                    new SqlParameter("@PT_SLThiSinhToiThieu", slToiThieu),
                    new SqlParameter("@PT_SLNhanVienCoiThi", slNhanVien)
                };
                DataProvider.Instance.ExecuteNonQuerySP("usp_UpdatePhongThi", parameters);
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        // PHƯƠNG THỨC MỚI: Xóa phòng thi
        public static bool DeletePhongThi(string maPhong)
        {
            try
            {
                // Sửa lỗi: Khai báo một mảng chứa một SqlParameter
                SqlParameter[] parameter = new SqlParameter[]
                {
                    new SqlParameter("@PT_MaPhongThi", maPhong)
                };
                DataProvider.Instance.ExecuteNonQuerySP("usp_DeletePhongThi", parameter);
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}