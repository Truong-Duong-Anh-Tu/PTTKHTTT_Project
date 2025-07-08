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

        // Đã gộp code từ hàm adminChinhSuaLichNV_Load vào đây
        private void adminChinhSuaLichNV_Load_1(object sender, EventArgs e)
        {
            HienThiDuLieu();
            SetEditable(false); // Bắt đầu ở trạng thái chỉ đọc
            this.dataGridViewDSNVCoiThi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSNVCoiThi_CellClick);
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

                // Hiển thị thời gian bắt đầu và kết thúc
                if (lichPhanCong["Giờ Bắt Đầu"] is TimeSpan gioBatDau)
                {
                    labelHienThiTGBatDau.Text = gioBatDau.ToString(@"hh\:mm");
                }
                if (lichPhanCong["Giờ Kết Thúc"] is TimeSpan gioKetThuc)
                {
                    labelHienThiTGKetThuc.Text = gioKetThuc.ToString(@"hh\:mm");
                }

                textBoxMaNVCoiThi.Text = lichPhanCong["Mã Nhân Viên"]?.ToString() ?? "N/A";
                textBoxTenNVCoiThi.Text = lichPhanCong["Tên Nhân Viên"]?.ToString() ?? "N/A";
            }
        }

        private void SetEditable(bool isEditable)
        {
            textBoxMaNVCoiThi.ReadOnly = !isEditable;
            // Thay đổi màu nền để người dùng biết ô có thể chỉnh sửa
            textBoxMaNVCoiThi.BackColor = isEditable ? SystemColors.Window : SystemColors.Control;
            buttonLuuThongTin.Enabled = isEditable;
            buttonChinhSuaThongTin.Enabled = !isEditable;
        }

        private void buttonChinhSuaThongTin_Click(object? sender, EventArgs e)
        {
            SetEditable(true);
            textBoxMaNVCoiThi.Focus(); // Tự động focus vào ô Mã Nhân Viên
            LoadNhanVienCoiThi();
        }
        private void LoadNhanVienCoiThi()
        {
            try
            {
                // Gọi qua BUS để lấy danh sách nhân viên có chức vụ "Coi thi"
                DataTable dtCoiThi = InfoEmployeeBUS.GetAvailableNhanVien();

                // Gán DataSource cho DataGridView mới
                dataGridViewDSNVCoiThi.DataSource = dtCoiThi;
                dataGridViewDSNVCoiThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách nhân viên coi thi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            // Kiểm tra xem nhân viên mới có tồn tại không
            string tenNVMoi = InfoEmployeeBUS.GetTenNhanVien(maNVMoi);
            if (string.IsNullOrEmpty(tenNVMoi))
            {
                MessageBox.Show("Mã nhân viên mới không tồn tại. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EmployeeScheduleBUS bus = new EmployeeScheduleBUS();
            if (bus.IsPhanCongLimitReached(maLichThi))
            {
                MessageBox.Show("Lịch thi này đã đủ số lượng nhân viên coi thi. Không thể thêm.", "Đã Đạt Giới Hạn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (bus.KiemTraNhanVienDaDuocPhanCong(maLichThi, maNVMoi))
            {
                MessageBox.Show("Nhân viên này đã được phân công cho lịch thi này. Vui lòng chọn nhân viên khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (bus.UpdateEmployeeSchedule(maLichThi, maNVCU, maNVMoi))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Cập nhật lại dữ liệu trên DataRowView để giao diện được đồng bộ
                lichPhanCong.Row["Mã Nhân Viên"] = maNVMoi;
                lichPhanCong.Row["Tên Nhân Viên"] = tenNVMoi;
                HienThiDuLieu(); // Hiển thị lại dữ liệu đã cập nhật
                SetEditable(false); // Chuyển về trạng thái chỉ đọc
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Tìm UserControl cha (adminQuanLyLichNV) và quay lại
            if (this.Parent is Panel parentPanel)
            {
                parentPanel.Controls.Clear();
                adminQuanLyLichNV qlLichNV = new adminQuanLyLichNV();
                qlLichNV.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(qlLichNV);
            }
        }

        // Bổ sung chức năng: Tự động hiển thị tên nhân viên khi nhập mã
        private void textBoxMaNVCoiThi_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxMaNVCoiThi.ReadOnly) // Chỉ thực hiện khi đang ở chế độ chỉnh sửa
            {
                string maNVMoi = textBoxMaNVCoiThi.Text.Trim();
                if (!string.IsNullOrEmpty(maNVMoi))
                {
                    string tenNVMoi = InfoEmployeeBUS.GetTenNhanVien(maNVMoi);
                    textBoxTenNVCoiThi.Text = string.IsNullOrEmpty(tenNVMoi) ? "Không tìm thấy" : tenNVMoi;
                }
                else
                {
                    textBoxTenNVCoiThi.Text = "";
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewDSNVCoiThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewDSNVCoiThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewDSNVCoiThi.Rows[e.RowIndex];
                textBoxMaNVCoiThi.Text = row.Cells["Mã NV"].Value?.ToString();
                textBoxTenNVCoiThi.Text = row.Cells["Tên NV"].Value?.ToString();
            }
        }
    }
}