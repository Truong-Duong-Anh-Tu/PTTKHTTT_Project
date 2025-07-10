using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHTTTProject.DAO
{
    internal class ExamTypeDAO
    {
        public static DataTable GetLichThiByKyThi(string maKyThi)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaKyThi", maKyThi)
            };
            return DataProvider.Instance.ExecuteQuerySP("usp_GetLichThiByKyThi", parameters);
        }
        public static int GetTotalExamCount()
        {
            try
            {
                string query = "SELECT COUNT(*) FROM KYTHI";
                object result = DataProvider.Instance.ExecuteScalar(query);
                return result != null ? Convert.ToInt32(result) : 0;
            }
            catch (Exception ex)
            {
                // Log lỗi hoặc xử lý ngoại lệ nếu cần
                Console.WriteLine($"Error in GetTotalExamCount: {ex.Message}");
                throw; // Ném lại ngoại lệ để UI xử lý
            }
        }

        public static DataTable GetAllExams()
        {
            try
            {
                // Thay đổi SELECT * thành SELECT tường minh và đặt bí danh cho cột lệ phí
                string query = "SELECT KT_MaKyThi, KT_TenKyThi, KT_LePhi AS LePhi FROM KYTHI";
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllExams: {ex.Message}");
                throw;
            }
        }

        public static int GetRemainingScheduleCount()
        {
            try
            {
                // Đếm các lịch thi có ngày thi lớn hơn hoặc bằng ngày hiện tại
                // hoặc có trạng thái là "Chưa diễn ra" (tùy vào cách bạn lưu trạng thái)
                string query = @"SELECT COUNT(*) FROM LICHTHI 
                              WHERE LT_NgayThi >= CONVERT(date, GETDATE()) 
                              OR LT_TrangThai = N'Chưa diễn ra'";

                object result = DataProvider.Instance.ExecuteScalar(query);
                return result != null ? Convert.ToInt32(result) : 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetRemainingScheduleCount: {ex.Message}");
                throw;
            }
        }

        public static bool UpdateKyThi(string maKyThi, string tenKyThi, decimal lePhi)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaKyThi", maKyThi),
                    new SqlParameter("@TenKyThi", tenKyThi),
                    new SqlParameter("@LePhi", lePhi)
                };
                DataProvider.Instance.ExecuteNonQuerySP("usp_UpdateKyThi", parameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool AddKyThi(string maKyThi, string tenKyThi, decimal lePhi)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaKyThi", maKyThi),
                    new SqlParameter("@TenKyThi", tenKyThi),
                    new SqlParameter("@LePhi", lePhi)
                };
                DataProvider.Instance.ExecuteNonQuerySP("usp_AddKyThi", parameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool DeleteKyThi(string maKyThi)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaKyThi", maKyThi)
                };
                DataProvider.Instance.ExecuteNonQuerySP("usp_DeleteKyThi", parameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string GetLastKyThiId()
        {
            try
            {
                return DataProvider.Instance.ExecuteScalarSP<string>("usp_GetLastKyThiId");
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
