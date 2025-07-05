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
            // Tải danh sách phòng trống cho ngày hiện tại khi form được mở
            LoadPhongThiTrongData(dateTimePickerNgayThi.Value);
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

        // Sửa lại phương thức để nhận tham số ngày
        private void LoadPhongThiTrongData(DateTime selectedDate)
        {
            try
            {
                dataGridViewPhongTrong.DataSource = PhongThiBUS.GetAvailablePhongThiByDate(selectedDate);
                dataGridViewPhongTrong.Columns["PT_MaPhongThi"].HeaderText = "Mã Phòng";
                dataGridViewPhongTrong.Columns["PT_HinhThuc"].HeaderText = "Hình Thức";
                dataGridViewPhongTrong.Columns["PT_SLThiSinhToiDa"].Visible = false;
                dataGridViewPhongTrong.Columns["PT_SLThiSinhToiThieu"].Visible = false;
                dataGridViewPhongTrong.Columns["PT_SLNhanVienCoiThi"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu phòng thi: " + ex.Message);
            }
        }

        // Sự kiện khi thay đổi ngày thi
        private void dateTimePickerNgayThi_ValueChanged(object sender, EventArgs e)
        {
            // Tải lại danh sách phòng thi trống mỗi khi ngày thay đổi
            LoadPhongThiTrongData(dateTimePickerNgayThi.Value);
            // Xóa lựa chọn phòng thi cũ để tránh nhầm lẫn
            textBoxHienThiPhongThi.Text = "";
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

            if (!int.TryParse(textBoxSLDangKy.Text, out int slDangKy) || slDangKy < 0)
            {
                MessageBox.Show("Số lượng đăng ký phải là một số nguyên không âm.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenKyThi = textBoxTenKyThi.Text;
            DateTime ngayThi = dateTimePickerNgayThi.Value;
            string maPhongThi = textBoxHienThiPhongThi.Text;
            TimeSpan thoiGianBatDau = dateTimePickerTGBatDau.Value.TimeOfDay;
            TimeSpan thoiGianKetThuc = dateTimePickerTGKetThuc.Value.TimeOfDay;
            if ((ngayThi.Date - DateTime.Today).TotalDays < 30)
            {
                MessageBox.Show("Ngày thi phải được lên lịch trước ít nhất 30 ngày so với ngày hiện tại.", "Lỗi logic", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (thoiGianKetThuc <= thoiGianBatDau)
            {
                MessageBox.Show("Thời gian kết thúc phải sau thời gian bắt đầu.", "Lỗi logic", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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