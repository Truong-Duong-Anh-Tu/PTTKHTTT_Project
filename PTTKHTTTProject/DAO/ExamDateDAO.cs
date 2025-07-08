using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHTTTProject.DAO
{
    internal class ExamDateDAO
    {
        public static DataTable getExamDate(string examtype)
        {
            var pExamtype = new SqlParameter("@examtest", SqlDbType.VarChar, 10)
            { Value = examtype.Trim() };

            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT LT_MaLichThi, LT_NgayThi, LT_TGBatDau FROM LICHTHI WHERE LT_MaKyThi = @examtest", pExamtype);

            return dt;
        }

        public static DataTable GetAllLichThi()
        {
            return DataProvider.Instance.ExecuteQuerySP("usp_GetLichThi");
        }

        public static DataTable GetLichThiByPhongThi(string maPhongThi)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaPhongThi", maPhongThi)
            };
            return DataProvider.Instance.ExecuteQuerySP("usp_GetLichThiByPhongThi", parameters);
        }

        public static string GetLastLichThiId()
        {
            return DataProvider.Instance.ExecuteScalarSP<string>("usp_GetLastLichThiId");
        }

        public static void AddLichThi(string maLichThi, string maKyThi, int slDangKy, string trangThai, string tenKyThi, DateTime ngayThi, string maPhongThi, TimeSpan tgBatDau, TimeSpan tgKetThuc)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaLichThi", maLichThi),
                new SqlParameter("@MaKyThi", maKyThi),
                new SqlParameter("@SLDangKy", slDangKy),
                new SqlParameter("@TrangThai", trangThai),
                new SqlParameter("@TenKyThi", tenKyThi),
                new SqlParameter("@NgayThi", ngayThi),
                new SqlParameter("@MaPhongThi", maPhongThi),
                new SqlParameter("@TGBatDau", tgBatDau),
                new SqlParameter("@TGKetThuc", tgKetThuc)
            };
            DataProvider.Instance.ExecuteNonQuerySP("usp_AddLichThi", parameters);
        }

        public static bool UpdateLichThi(string maLichThi, DateTime ngayThi, int slDangKy, TimeSpan tgBatDau, TimeSpan tgKetThuc)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaLichThi", maLichThi),
                new SqlParameter("@NgayThi", ngayThi),
                new SqlParameter("@SLDangKy", slDangKy),
                new SqlParameter("@TGBatDau", tgBatDau),
                new SqlParameter("@TGKetThuc", tgKetThuc)
            };
            return DataProvider.Instance.ExecuteScalarSP<int>("usp_UpdateLichThi", parameters) == 1;
        }

        // Thêm vào cuối file DAO/ExamDateDAO.cs
        public static bool DeleteLichThi(string maLichThi)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaLichThi", maLichThi)
            };
            // Do stored procedure có RAISERROR, chúng ta cần bắt lỗi
            try
            {
                return DataProvider.Instance.ExecuteScalarSP<int>("usp_DeleteLichThi", parameters) == 1;
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}
