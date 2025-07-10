using System;
using System.Data;
using System.Windows.Forms;
using PTTKHTTTProject.BUS;
using PTTKHTTTProject.DAO; // Thêm namespace này để dùng DataProvider

namespace PTTKHTTTProject
{
    public partial class fAdminThemNV : Form
    {
        private readonly Dictionary<string, string> chucVuToPhongBan = new()
        {
            { "Coi thi", "Phòng Giám thị" },
            { "Tiếp nhận", "Phòng Tiếp nhận" },
            { "Kế toán", "Phòng Kế toán" },
            { "Nhập liệu", "Phòng Nhập liệu" },
            { "Quản trị hệ thống", "Phòng Quản trị hệ thống" }
        };
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
                // Tải dữ liệu cho ComboBox Chức Vụ (dữ liệu tĩnh)
                string[] chucVuList = { "Tiếp nhận", "Kế toán", "Nhập liệu", "Quản trị hệ thống", "Coi thi" };
                comboBoxChucVu.DataSource = chucVuList;
                comboBoxChucVu.SelectedIndex = -1;
                comboBoxChucVu.Text = "Chọn chức vụ";
                string[] gioiTinhList = { "Nam", "Nữ" };
                comboBoxGioiTinh.DataSource = gioiTinhList;
                comboBoxGioiTinh.SelectedIndex = -1;
                comboBoxGioiTinh.Text = "Chọn giới tính";
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
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxSDT.Text) ||
                string.IsNullOrWhiteSpace(textBoxCCCD.Text) ||
                string.IsNullOrWhiteSpace(textBoxDiaChi.Text) ||
                comboBoxChucVu.SelectedItem == null ||
                comboBoxGioiTinh.SelectedItem == null ||
                string.IsNullOrWhiteSpace(textBoxPhongBan.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Lấy ngày từ DateTimePicker
            DateTime ngaySinh = dateTimePickerNgaySinh.Value;

            // Lấy dữ liệu từ các control với tên đúng từ file Designer
            string hoTen = textBoxHoTen.Text;
            string gioiTinh = comboBoxGioiTinh.SelectedItem?.ToString() ?? string.Empty;
            string email = textBoxEmail.Text;
            string sdt = textBoxSDT.Text;
            string cccd = textBoxCCCD.Text;
            string diaChi = textBoxDiaChi.Text;
            string chucVu = comboBoxChucVu.SelectedItem?.ToString() ?? string.Empty;
            string tenPhongBan = textBoxPhongBan.Text;
            string maPhongBan = DepartmentBUS.GetMaPhongBanByTen(tenPhongBan);
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
            // Kiểm tra định dạng email
            if (!InfoEmployeeBUS.IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ. Vui lòng nhập đúng định dạng email.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra số điện thoại 10 số
            if (!InfoEmployeeBUS.IsValidPhone(sdt))
            {
                MessageBox.Show("Số điện thoại phải gồm đúng 10 chữ số.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra CCCD 12 số
            if (!InfoEmployeeBUS.IsValidCCCD(cccd))
            {
                MessageBox.Show("CCCD phải gồm đúng 12 chữ số.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Gọi BUS để thực hiện thêm nhân viên
                bool success = InfoEmployeeBUS.AddNhanVien(maNV, hoTen, ngaySinh, gioiTinh, email, sdt, cccd, diaChi, chucVu, luong, maPhongBan);

                if (success)
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else // Thêm khối else để xử lý thất bại
                {
                    MessageBox.Show("Thêm nhân viên thất bại. Vui lòng kiểm tra lại thông tin (nhân viên phải đủ 18 tuổi).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pictureBoxThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Các sự kiện khác (để trống nếu không sử dụng)
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void fAdminThemNV_Load(object sender, EventArgs e) { }

        private void dateTimePickerNgaySinh_ValueChanged(object sender, EventArgs e) { }

        private void comboBoxChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxChucVu.SelectedItem is string chucVu && chucVuToPhongBan.TryGetValue(chucVu, out var phongBan))
            {
                textBoxPhongBan.Text = phongBan;
            }
            else
            {
                textBoxPhongBan.Text = "";
            }
        }
    }
}