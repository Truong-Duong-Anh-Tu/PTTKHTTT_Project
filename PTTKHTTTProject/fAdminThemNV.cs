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
                comboBoxLichThi.DataSource = NhanVienDAO.GetAllPhongBan();
                comboBoxLichThi.DisplayMember = "PB_TenPhongBan";
                comboBoxLichThi.ValueMember = "PB_MaPhongBan";
                comboBoxLichThi.SelectedIndex = -1;
                comboBoxLichThi.Text = "Chọn phòng ban";

                // Tải dữ liệu cho ComboBox Chức Vụ (dữ liệu tĩnh)
                string[] chucVuList = { "Tiếp nhận", "Kế toán", "Nhập liệu", "Quản trị hệ thống", "Coi thi" };
                comboBoxKyThi.DataSource = chucVuList;
                comboBoxKyThi.SelectedIndex = -1;
                comboBoxKyThi.Text = "Chọn chức vụ";
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
            if (string.IsNullOrWhiteSpace(textBoxKyThi.Text) ||
                string.IsNullOrWhiteSpace(textBoxNgayThi.Text) ||
                string.IsNullOrWhiteSpace(textBoxPhongThi.Text) ||
                string.IsNullOrWhiteSpace(textBoxTGBatDau.Text) ||
                string.IsNullOrWhiteSpace(textBoxTGKetThuc.Text) ||
                string.IsNullOrWhiteSpace(textBoxMaNVCoiThi.Text) ||
                string.IsNullOrWhiteSpace(textBoxTenNVCoiThi.Text) ||
                comboBoxKyThi.SelectedItem == null ||
                comboBoxLichThi.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParse(textBoxNgayThi.Text, out DateTime ngaySinh))
            {
                MessageBox.Show("Định dạng ngày sinh không hợp lệ. Vui lòng nhập ngày hợp lệ.", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu từ các control với tên đúng từ file Designer
            string hoTen = textBoxKyThi.Text;
            string gioiTinh = textBoxPhongThi.Text;
            string email = textBoxTGBatDau.Text;
            string sdt = textBoxTGKetThuc.Text;
            string cccd = textBoxMaNVCoiThi.Text;
            string diaChi = textBoxTenNVCoiThi.Text;
            string chucVu = comboBoxKyThi.SelectedItem.ToString();
            string maPhongBan = comboBoxLichThi.SelectedValue.ToString();
            int luong = 8000000; // Giá trị tạm thời, bạn nên thêm control để nhập lương

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
    }
}