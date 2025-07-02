using PTTKHTTTProject.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTKHTTTProject.BUS
{
    internal class EmployeeScheduleBUS
    {
        private string FormatTimeValue(object timeObject)
        {
            // Nếu đối tượng là null hoặc DBNull, trả về chuỗi rỗng
            if (timeObject == null || timeObject == DBNull.Value)
            {
                return "";
            }

            // Sử dụng TryParse để tránh lỗi crash chương trình
            if (DateTime.TryParse(timeObject.ToString(), out DateTime result))
            {
                // Nếu parse thành công, trả về chuỗi đã định dạng
                return result.ToString("HH:mm");
            }

            // Nếu không thể parse, trả về chuỗi rỗng
            return "";
        }

        public DataTable loadEmployeeSchedule()
        {
            // 1. Lấy DataTable gốc từ DAO
            DataTable originalDt = EmployeeScheduleDAO.getEmployeeSchedule();

            // 2. Tạo một DataTable mới để chứa dữ liệu đã định dạng
            DataTable formattedDt = new DataTable();

            // 3. Định nghĩa các cột trong DataTable mới với tên bạn muốn hiển thị
            formattedDt.Columns.Add("Tên Kỳ Thi", typeof(string));
            formattedDt.Columns.Add("Ngày Thi", typeof(string));
            formattedDt.Columns.Add("Phòng Thi", typeof(string));
            formattedDt.Columns.Add("Giờ Bắt Đầu", typeof(string));
            formattedDt.Columns.Add("Giờ Kết Thúc", typeof(string));
            formattedDt.Columns.Add("Mã Nhân Viên", typeof(string));
            formattedDt.Columns.Add("Tên Nhân Viên", typeof(string));
            formattedDt.Columns.Add("Trạng Thái", typeof(string));

            // 4. Lặp qua từng dòng, định dạng và thêm vào DataTable mới
            foreach (DataRow row in originalDt.Rows)
            {
                formattedDt.Rows.Add(
                    row["KT_TenKyThi"],
                    row["LT_NgayThi"] != DBNull.Value ? ((DateTime)row["LT_NgayThi"]).ToString("dd/MM/yyyy") : "",
                    row["LT_MaPhongThi"],
                    // Gọi hàm hỗ trợ để định dạng giờ bắt đầu
                    FormatTimeValue(row["LT_TGBatDau"]),
                    // Gọi hàm hỗ trợ để định dạng giờ kết thúc
                    FormatTimeValue(row["LT_TGKetThuc"]),
                    row["NV_MaNhanVien"],
                    row["NV_TenNhanVien"],
                    row["PC_TrangThai"]
                );
            }

            // 5. Trả về DataTable mới đã được định dạng
            return formattedDt;
        }
    }
}
