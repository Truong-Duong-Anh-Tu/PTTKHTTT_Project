using PTTKHTTTProject.BUS;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace PTTKHTTTProject
{
    public partial class fAdminChinhSuaLichThi : Form
    {
        private readonly DataRowView _selectedSchedule;

        public fAdminChinhSuaLichThi(DataRowView selectedRow)
        {
            InitializeComponent();
            _selectedSchedule = selectedRow;
        }

        private void fAdminChinhSuaLichThi_Load(object sender, EventArgs e)
        {
            if (_selectedSchedule != null)
            {
                // Nạp thông tin Kỳ thi (chỉ đọc)
                // Lấy mã kỳ thi từ mã lịch thi. Giả định rằng KTxx nằm trong LTxx....
                // Cách này không an toàn, tốt hơn là nên có cột MaKyThi trong Stored Procedure
                string maKyThi = "KT" + _selectedSchedule.Row["Mã Lịch Thi"].ToString().Substring(2, 2);
                labelHienThiMaKT.Text = maKyThi;
                labelHienThiTenKyThi.Text = _selectedSchedule.Row["Tên Kỳ Thi"]?.ToString() ?? "N/A";

                // Nạp thông tin Lịch thi để chỉnh sửa
                labelHienThiMaLT.Text = _selectedSchedule.Row["Mã Lịch Thi"]?.ToString() ?? "N/A";
                labelHienThiPhongThi.Text = _selectedSchedule.Row["Phòng Thi"]?.ToString() ?? "N/A";

                // Nạp dữ liệu vào các controls cho phép chỉnh sửa
                dateTimePickerNgayThi.Value = Convert.ToDateTime(_selectedSchedule.Row["Ngày Thi"]);
                comboBoxTrangThai.SelectedItem = _selectedSchedule.Row["Trạng Thái"]?.ToString() ?? "Chưa thi";
                numericUpDownSLDangKy.Value = Convert.ToDecimal(_selectedSchedule.Row["Số Lượng Đã Đăng Ký"]);

                // Chuyển đổi TimeSpan sang DateTime để hiển thị
                if (_selectedSchedule.Row["Giờ Bắt Đầu"] is TimeSpan tgBatDau)
                {
                    dateTimePickerTGBatDau.Value = DateTime.Today + tgBatDau;
                }
                if (_selectedSchedule.Row["Giờ Kết Thúc"] is TimeSpan tgKetThuc)
                {
                    dateTimePickerTGKetThuc.Value = DateTime.Today + tgKetThuc;
                }
            }
        }

        private void buttonLuuThongTin_Click(object sender, EventArgs e)
        {
            // Lấy thông tin đã chỉnh sửa từ các control
            string maLichThi = labelHienThiMaLT.Text;
            DateTime ngayThi = dateTimePickerNgayThi.Value;
            int slDangKy = (int)numericUpDownSLDangKy.Value;
            TimeSpan tgBatDau = dateTimePickerTGBatDau.Value.TimeOfDay;
            TimeSpan tgKetThuc = dateTimePickerTGKetThuc.Value.TimeOfDay;

            if ((ngayThi.Date - DateTime.Today).TotalDays < 30)
            {
                MessageBox.Show("Ngày thi phải được lên lịch trước ít nhất 30 ngày so với ngày hiện tại.", "Lỗi logic", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tgKetThuc <= tgBatDau)
            {
                MessageBox.Show("Thời gian kết thúc phải sau thời gian bắt đầu.", "Lỗi logic", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi BUS để cập nhật (không còn tham số trạng thái)
            bool result = ExamDateBUS.UpdateLichThi(maLichThi, ngayThi, slDangKy, tgBatDau, tgKetThuc);

            if (result)
            {
                MessageBox.Show("Cập nhật lịch thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật lịch thi thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}