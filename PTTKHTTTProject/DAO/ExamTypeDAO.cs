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
    }
}
