using PTTKHTTTProject.BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace PTTKHTTTProject
{
    public partial class fAdminThemLichThi : Form
    {
        private string selectedMaKyThi = "";

        public fAdminThemLichThi()
        {
            InitializeComponent();
        }

        private void fAdminThemLichThi_Load(object sender, EventArgs e)
        {
            LoadKyThiData();
            LoadPhongThiTrongData();
            // Đặt các control DateTimePicker chỉ hiển thị giờ
            dateTimePickerTGBatDau.Format = DateTimePickerFormat.Custom;
            dateTimePickerTGBatDau.CustomFormat = "HH:mm";
            dateTimePickerTGBatDau.ShowUpDown = true;

            dateTimePickerTGKetThuc.Format = DateTimePickerFormat.Custom;
            dateTimePickerTGKetThuc.CustomFormat = "HH:mm";
            dateTimePickerTGKetThuc.ShowUpDown = true;
        }

        private void LoadKyThiData()
        {
            try
            {
                dataGridViewKyThi.DataSource = ExamTypeBUS.GetAllExams();
                dataGridViewKyThi.Columns["KT_MaKyThi"].HeaderText = "Mã Kỳ Thi";
                dataGridViewKyThi.Columns["KT_TenKyThi"].HeaderText = "Tên Kỳ Thi";
                dataGridViewKyThi.Columns["LePhi"].HeaderText = "Lệ Phí";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu kỳ thi: " + ex.Message);
            }
        }

        private void LoadPhongThiTrongData()
        {
            try
            {
                dataGridViewPhongTrong.DataSource = PhongThiBUS.GetAllPhongThi();
                dataGridViewPhongTrong.Columns["PT_MaPhongThi"].HeaderText = "Mã Phòng";
                dataGridViewPhongTrong.Columns["PT_HinhThuc"].HeaderText = "Hình Thức";
                // Ẩn các cột không cần thiết
                dataGridViewPhongTrong.Columns["PT_SLThiSinhToiDa"].Visible = false;
                dataGridViewPhongTrong.Columns["PT_SLThiSinhToiThieu"].Visible = false;
                dataGridViewPhongTrong.Columns["PT_SLNhanVienCoiThi"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu phòng thi: " + ex.Message);
            }
        }

        private void dataGridViewKyThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewKyThi.Rows[e.RowIndex];
                selectedMaKyThi = row.Cells["KT_MaKyThi"].Value.ToString();
                textBoxTenKyThi.Text = row.Cells["KT_TenKyThi"].Value.ToString();
            }
        }

        private void dataGridViewPhongTrong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewPhongTrong.Rows[e.RowIndex];
                textBoxHienThiPhongThi.Text = row.Cells["PT_MaPhongThi"].Value.ToString();
            }
        }

        private void buttonLuuThongTin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedMaKyThi) || string.IsNullOrWhiteSpace(textBoxHienThiPhongThi.Text))
            {
                MessageBox.Show("Vui lòng chọn kỳ thi và phòng thi.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- BẮT ĐẦU PHẦN THÊM MỚI ---
            if (!int.TryParse(textBoxSLDangKy.Text, out int slDangKy) || slDangKy < 0)
            {
                MessageBox.Show("Số lượng đăng ký phải là một số nguyên không âm.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // --- KẾT THÚC PHẦN THÊM MỚI ---

            string tenKyThi = textBoxTenKyThi.Text;
            DateTime ngayThi = dateTimePickerNgayThi.Value;
            string maPhongThi = textBoxHienThiPhongThi.Text;
            TimeSpan thoiGianBatDau = dateTimePickerTGBatDau.Value.TimeOfDay;
            TimeSpan thoiGianKetThuc = dateTimePickerTGKetThuc.Value.TimeOfDay;

            if (thoiGianKetThuc <= thoiGianBatDau)
            {
                MessageBox.Show("Thời gian kết thúc phải sau thời gian bắt đầu.", "Lỗi logic", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cập nhật lời gọi hàm để bao gồm số lượng đăng ký
            bool result = ExamDateBUS.AddLichThi(selectedMaKyThi, tenKyThi, ngayThi, maPhongThi, thoiGianBatDau, thoiGianKetThuc, slDangKy);

            if (result)
            {
                MessageBox.Show("Thêm lịch thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm lịch thi thất bại. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}