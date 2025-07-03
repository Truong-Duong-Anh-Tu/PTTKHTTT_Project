using System;
using System.Data;
using System.Windows.Forms;
using PTTKHTTTProject.BUS;

namespace PTTKHTTTProject.UControl
{
    public partial class adminChinhSuaLichNV : UserControl
    {
        private readonly DataRowView? lichPhanCong;

        public adminChinhSuaLichNV()
        {
            InitializeComponent();
        }

        public adminChinhSuaLichNV(DataRowView row) : this()
        {
            lichPhanCong = row;
        }

        private void adminChinhSuaLichNV_Load(object? sender, EventArgs e)
        {
            HienThiDuLieu();
            SetEditable(false);
        }

        private void HienThiDuLieu()
        {
            if (lichPhanCong != null)
            {
                labelHienThiKyThi.Text = lichPhanCong["Tên Kỳ Thi"]?.ToString() ?? "N/A";
                if (lichPhanCong["Ngày Thi"] is DateTime ngayThi)
                {
                    labelHienThiNgayThi.Text = ngayThi.ToString("dd/MM/yyyy");
                }
                labelHienThiPhongThi.Text = lichPhanCong["Phòng Thi"]?.ToString() ?? "N/A";
                labelHienThiTGBatDau.Text = lichPhanCong["Giờ Bắt Đầu"]?.ToString() ?? "N/A";
                labelHienThiTGKetThuc.Text = lichPhanCong["Giờ Kết Thúc"]?.ToString() ?? "N/A";
                textBoxMaNVCoiThi.Text = lichPhanCong["Mã Nhân Viên"]?.ToString() ?? "N/A";
                textBoxTenNVCoiThi.Text = lichPhanCong["Tên Nhân Viên"]?.ToString() ?? "N/A";
            }
        }

        private void SetEditable(bool isEditable)
        {
            textBoxMaNVCoiThi.ReadOnly = !isEditable;
            buttonLuuThongTin.Enabled = isEditable;
            buttonChinhSuaThongTin.Enabled = !isEditable;
        }

        private void buttonChinhSuaThongTin_Click(object? sender, EventArgs e)
        {
            SetEditable(true);
        }

        private void buttonLuuThongTin_Click(object? sender, EventArgs e)
        {
            if (lichPhanCong == null) return;
            string? maLichThi = lichPhanCong.Row["LT_MaLichThi"]?.ToString();
            string? maNVCU = lichPhanCong.Row["Mã Nhân Viên"]?.ToString();
            string maNVMoi = textBoxMaNVCoiThi.Text.Trim();

            if (string.IsNullOrEmpty(maLichThi) || string.IsNullOrEmpty(maNVCU))
            {
                MessageBox.Show("Dữ liệu gốc không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tenNVMoi = NhanVienBUS.GetTenNhanVien(maNVMoi);
            if (string.IsNullOrEmpty(tenNVMoi))
            {
                MessageBox.Show("Mã nhân viên mới không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EmployeeScheduleBUS bus = new EmployeeScheduleBUS();
            if (bus.UpdateEmployeeSchedule(maLichThi, maNVCU, maNVMoi))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lichPhanCong.Row["Mã Nhân Viên"] = maNVMoi;
                lichPhanCong.Row["Tên Nhân Viên"] = tenNVMoi;
                HienThiDuLieu();
                SetEditable(false);
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