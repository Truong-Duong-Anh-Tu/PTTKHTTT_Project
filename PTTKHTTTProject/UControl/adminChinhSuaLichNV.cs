using System;
using System.Data;
using System.Windows.Forms;
using PTTKHTTTProject.BUS;

namespace PTTKHTTTProject.UControl
{
    public partial class adminChinhSuaLichNV : UserControl
    {
        // Khai báo biến nullable để tránh cảnh báo CS8618
        private DataRowView? lichPhanCong;

        // Constructor mặc định cho Designer
        public adminChinhSuaLichNV()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.adminChinhSuaLichNV_Load);
        }

        // Constructor để nhận dữ liệu từ trang quản lý
        public adminChinhSuaLichNV(DataRowView row) : this()
        {
            lichPhanCong = row;
        }

        private void adminChinhSuaLichNV_Load(object? sender, EventArgs e)
        {
            HienThiDuLieu();
            SetEditable(false); // Ban đầu ở chế độ chỉ xem
        }

        private void HienThiDuLieu()
        {
            if (lichPhanCong != null)
            {
                // Sử dụng toán tử ?. để truy cập an toàn
                labelHienThiKyThi.Text = lichPhanCong["Tên Kỳ Thi"]?.ToString() ?? "N/A";
                labelHienThiNgayThi.Text = (lichPhanCong["Ngày Thi"] as DateTime?)?.ToString("dd/MM/yyyy") ?? "N/A";
                labelHienThiPhongThi.Text = lichPhanCong["Phòng Thi"]?.ToString() ?? "N/A";
                labelHienThiTGBatDau.Text = lichPhanCong["Giờ Bắt Đầu"]?.ToString() ?? "N/A";
                labelHienThiTGKetThuc.Text = lichPhanCong["Giờ Kết Thúc"]?.ToString() ?? "N/A";
                textBoxMaNVCoiThi.Text = lichPhanCong["Mã Nhân Viên"]?.ToString() ?? "N/A";
                textBoxTenNVCoiThi.Text = lichPhanCong["Tên Nhân Viên"]?.ToString() ?? "N/A";
            }
        }

        private void SetEditable(bool isEditable)
        {
            // Chỉ cho phép chỉnh sửa Mã nhân viên
            textBoxMaNVCoiThi.ReadOnly = !isEditable;

            // Tên nhân viên luôn ở chế độ chỉ đọc
            textBoxTenNVCoiThi.ReadOnly = true;

            // Bật/tắt nút Lưu và Sửa
            buttonLuuThongTin.Enabled = isEditable;
            buttonChinhSuaThongTin.Enabled = !isEditable;
        }


        private void buttonChinhSuaThongTin_Click(object sender, EventArgs e)
        {
            SetEditable(true);
        }

        private void buttonLuuThongTin_Click(object sender, EventArgs e)
        {
            if (lichPhanCong == null)
            {
                MessageBox.Show("Không có dữ liệu để lưu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string maNVMoi = textBoxMaNVCoiThi.Text.Trim();
            if (string.IsNullOrEmpty(maNVMoi))
            {
                MessageBox.Show("Mã nhân viên mới không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra xem Mã Nhân Viên mới có hợp lệ không và lấy tên
            string tenNVMoi = NhanVienBUS.GetTenNhanVien(maNVMoi);
            if (string.IsNullOrEmpty(tenNVMoi))
            {
                MessageBox.Show("Mã nhân viên mới không tồn tại. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy thông tin cũ để cập nhật
            string? maLichThi = lichPhanCong.Row["LT_MaLichThi"]?.ToString();
            string? maNVCU = lichPhanCong.Row["Mã Nhân Viên"]?.ToString();

            if (string.IsNullOrEmpty(maLichThi) || string.IsNullOrEmpty(maNVCU))
            {
                MessageBox.Show("Dữ liệu phân công gốc không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gọi BUS để thực hiện cập nhật
            EmployeeScheduleBUS bus = new EmployeeScheduleBUS();
            bool success = bus.UpdateEmployeeSchedule(maLichThi, maNVCU, maNVMoi);

            if (success)
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật lại giao diện với thông tin mới
                textBoxTenNVCoiThi.Text = tenNVMoi;
                lichPhanCong.Row["Mã Nhân Viên"] = maNVMoi;
                lichPhanCong.Row["Tên Nhân Viên"] = tenNVMoi;

                SetEditable(false); // Quay về chế độ chỉ xem
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Đóng UserControl hiện tại
            if (this.Parent is Panel parentPanel)
            {
                parentPanel.Controls.Remove(this);
            }
            else
            {
                // Nếu không phải là Panel, có thể là Form hoặc UserControl khác
                this.Dispose();
            }
        }

        private void textBoxMaNVCoiThi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}