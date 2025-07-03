using System;
using System.Data;
using System.Windows.Forms;
using PTTKHTTTProject.BUS;
using PTTKHTTTProject.DAO; // Thêm namespace này để dùng DataProvider

namespace PTTKHTTTProject
{
    public partial class fAdminThemNV : Form
    {
        public fAdminThemNV()
        {
            InitializeComponent();
            LoadComboBoxData(); // Tải dữ liệu cho ComboBox khi form khởi tạo
        }

        // Tải dữ liệu cho các ComboBox
        private void LoadComboBoxData()
        {
            try
            {
                // Tải dữ liệu cho ComboBox Phòng Ban từ CSDL
                comboBoxPhongBan.DataSource = NhanVienDAO.GetAllPhongBan();
                comboBoxPhongBan.DisplayMember = "PB_TenPhongBan";
                comboBoxPhongBan.ValueMember = "PB_MaPhongBan";
                comboBoxPhongBan.SelectedIndex = -1;
                comboBoxPhongBan.Text = "Chọn phòng ban";

                // Tải dữ liệu cho ComboBox Chức Vụ (dữ liệu tĩnh)
                string[] chucVuList = { "Tiếp nhận", "Kế toán", "Nhập liệu", "Quản trị hệ thống", "Coi thi" };
                comboBoxChucVu.DataSource = chucVuList;
                comboBoxChucVu.SelectedIndex = -1;
                comboBoxChucVu.Text = "Chọn chức vụ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện click nút "Lưu thông tin"
        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin nhập
            if (string.IsNullOrWhiteSpace(textBoxHoTen.Text) ||
                string.IsNullOrWhiteSpace(textBoxGioiTinh.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxSDT.Text) ||
                string.IsNullOrWhiteSpace(textBoxCCCD.Text) ||
                string.IsNullOrWhiteSpace(textBoxDiaChi.Text) ||
                comboBoxChucVu.SelectedItem == null ||
                comboBoxPhongBan.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Lấy ngày từ DateTimePicker
            DateTime ngaySinh = dateTimePickerNgaySinh.Value;

            // Lấy dữ liệu từ các control với tên đúng từ file Designer
            string hoTen = textBoxHoTen.Text;
            string gioiTinh = textBoxGioiTinh.Text;
            string email = textBoxEmail.Text;
            string sdt = textBoxSDT.Text;
            string cccd = textBoxCCCD.Text;
            string diaChi = textBoxDiaChi.Text;
            string chucVu = comboBoxChucVu.SelectedItem?.ToString() ?? string.Empty;
            string maPhongBan = comboBoxPhongBan.SelectedValue?.ToString() ?? string.Empty;
            int luong = (int)numericUpDownLuong.Value;
            if (luong <= 0)
            {
                MessageBox.Show("Lương phải lớn hơn 0.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Tự động tạo Mã Nhân Viên mới
            string maNV;
            try
            {
                string lastId = DataProvider.Instance.ExecuteScalarSP<string>("usp_GetLastEmployeeId");
                int newIdNumber = 1;
                if (!string.IsNullOrEmpty(lastId) && lastId.Length > 2)
                {
                    newIdNumber = int.Parse(lastId.Substring(2)) + 1;
                }
                maNV = "NV" + newIdNumber.ToString("D3");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tạo mã nhân viên mới: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Gọi BUS để thực hiện thêm nhân viên
            bool success = NhanVienBUS.AddNhanVien(maNV, hoTen, ngaySinh, gioiTinh, email, sdt, cccd, diaChi, chucVu, luong, maPhongBan);

            if (success)
            {
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại. Mã nhân viên có thể đã tồn tại hoặc có lỗi xảy ra.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Các sự kiện khác (để trống nếu không sử dụng)
        private void label1_Click(object sender, EventArgs e) { }
        private void comboBoxKyThi_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void comboBoxLichThi_SelectedIndexChanged(object sender, EventArgs e) { }

        private void fAdminThemNV_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePickerNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}