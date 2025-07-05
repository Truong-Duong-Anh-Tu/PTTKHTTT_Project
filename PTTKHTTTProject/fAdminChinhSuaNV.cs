using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using PTTKHTTTProject.BUS; // Đảm bảo đã có using BUS

namespace PTTKHTTTProject
{
    public partial class fAdminChinhSuaNV : Form
    {
        private readonly string maNhanVien; // Biến để lưu mã nhân viên
        private Dictionary<string, string> chucVuToTenPB = new Dictionary<string, string>();
        private Dictionary<string, string> tenPBToMaPB = new Dictionary<string, string>();
        // Constructor mới để nhận mã nhân viên
        public fAdminChinhSuaNV(string maNV)
        {
            InitializeComponent();
            this.maNhanVien = maNV; // Lưu lại mã nhân viên được truyền vào
        }

        // Sự kiện Load của form
        private void fAdminChinhSuaNV_Load(object sender, EventArgs e)
        {
            InitializeMappings();
            // Chỉ tải dữ liệu nếu có mã nhân viên
            if (!string.IsNullOrEmpty(this.maNhanVien))
            {
                LoadNhanVienData();
            }
            SetFieldsReadOnly(true);
            this.ActiveControl = buttonChinhSuaThongTin;
            comboBoxHienThiChucVu.SelectedIndexChanged += comboBoxHienThiChucVu_SelectedIndexChanged_1;
        }
        private void InitializeMappings()
        {
            chucVuToTenPB.Add("Coi thi", "Phòng Giám thị");
            chucVuToTenPB.Add("Kế toán", "Phòng Kế toán");
            chucVuToTenPB.Add("Nhập liệu", "Phòng Nhập liệu");
            chucVuToTenPB.Add("Tiếp nhận", "Phòng Tiếp nhận");
            chucVuToTenPB.Add("Quản trị hệ thống", "Phòng Quản trị hệ thống");

            try
            {
                DataTable dtPhongBan = PhongBanBUS.GetAllPhongBan();
                foreach (DataRow row in dtPhongBan.Rows)
                {
                    // Lưu quan hệ Tên Phòng Ban -> Mã Phòng Ban
                    tenPBToMaPB[row["PB_TenPhongBan"].ToString()] = row["PB_MaPhongBan"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nghiêm trọng khi tải dữ liệu phòng ban: " + ex.Message);
                return;
            }

            // 3. Đổ danh sách Chức Vụ vào ComboBox
            comboBoxHienThiChucVu.Items.Clear();
            foreach (var chucVu in chucVuToTenPB.Keys)
            {
                comboBoxHienThiChucVu.Items.Add(chucVu);
            }
        }
        /// <summary>
        /// Phương thức để bật/tắt chế độ chỉ đọc cho các trường thông tin.
        /// </summary>
        /// <param name="isReadOnly">True nếu muốn đóng băng, False nếu muốn cho phép chỉnh sửa.</param>
        private void SetFieldsReadOnly(bool isReadOnly)
        {
            // Phòng ban luôn là ReadOnly
            textBoxHienThiPhongBan.ReadOnly = true;

            // Các trường khác
            textBoxHienThiHoTen.ReadOnly = isReadOnly;
            comboBoxHienThiChucVu.Enabled = !isReadOnly; // Cho phép chọn chức vụ
            dateTimePickerNgaySinh.Enabled = !isReadOnly;
            comboBoxGioiTinh.Enabled = !isReadOnly;
            textBoxHienThiEmail.ReadOnly = isReadOnly;
            textBoxHienThiSDT.ReadOnly = isReadOnly;
            textBoxHienThiCCCD.ReadOnly = isReadOnly;
            textBoxHienThiDiaChi.ReadOnly = isReadOnly;
            numericUpDownLuong.Enabled = !isReadOnly;

            buttonLuuThongTin.Enabled = !isReadOnly;
            buttonChinhSuaThongTin.Enabled = isReadOnly;
        }

        // Phương thức để tải và hiển thị thông tin nhân viên
        private void LoadNhanVienData()
        {
            try
            {
                Dictionary<string, string> info = InfoEmployeeBUS.getInfoOfUser(this.maNhanVien);

                textBoxHienThiHoTen.Text = info["Hoten"];
                textBoxHienThiEmail.Text = info["Email"];
                textBoxHienThiSDT.Text = info["SDT"];
                textBoxHienThiCCCD.Text = info["CCCD"];
                textBoxHienThiDiaChi.Text = info["DChi"];
                dateTimePickerNgaySinh.Value = DateTime.Parse(info["NSinh"]);
                comboBoxGioiTinh.Text = info["GTinh"];
                numericUpDownLuong.Value = decimal.Parse(info["Luong"]);
                comboBoxHienThiChucVu.SelectedItem = info["ChucVu"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin nhân viên: " + ex.Message);
            }
        }

        private void pictureBoxThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChinhSuaThongTin_Click_1(object sender, EventArgs e)
        {
            // Cho phép chỉnh sửa các trường
            SetFieldsReadOnly(false);
            comboBoxHienThiChucVu.Focus();
        }

        private void tableLayoutPanelThongTinNV_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxHienThiEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxHienThiChucVu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxHienThiChucVu.SelectedItem != null)
            {
                string selectedChucVu = comboBoxHienThiChucVu.SelectedItem.ToString();
                // Tự động cập nhật Tên Phòng Ban tương ứng
                if (chucVuToTenPB.ContainsKey(selectedChucVu))
                {
                    textBoxHienThiPhongBan.Text = chucVuToTenPB[selectedChucVu];
                }
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhone(string phone)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{10}$");
        }

        private bool IsValidCCCD(string cccd)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(cccd, @"^\d{12}$");
        }
        private void buttonLuuThongTin_Click(object sender, EventArgs e)
        {
            string maNV = maNhanVien;
            string tenNV = textBoxHienThiHoTen.Text.Trim();
            DateTime ngaySinh = dateTimePickerNgaySinh.Value;
            string gioiTinh = comboBoxGioiTinh.Text.Trim();
            string email = textBoxHienThiEmail.Text.Trim();
            string sdt = textBoxHienThiSDT.Text.Trim();
            string cccd = textBoxHienThiCCCD.Text.Trim();
            string diaChi = textBoxHienThiDiaChi.Text.Trim();
            string chucVu = comboBoxHienThiChucVu.SelectedItem?.ToString() ?? "";
            int luong = (int)numericUpDownLuong.Value;
            string tenPhongBan = textBoxHienThiPhongBan.Text.Trim();
            string maPhongBan = PhongBanBUS.GetMaPhongBanByTen(tenPhongBan);


            // Validate dữ liệu
            if (string.IsNullOrWhiteSpace(tenNV) || string.IsNullOrWhiteSpace(gioiTinh) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(sdt) ||
                string.IsNullOrWhiteSpace(cccd) || string.IsNullOrWhiteSpace(diaChi) ||
                string.IsNullOrWhiteSpace(chucVu) || string.IsNullOrWhiteSpace(maPhongBan) || luong <= 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin hợp lệ.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra định dạng email
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ. Vui lòng nhập đúng định dạng email.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra số điện thoại 10 số
            if (!IsValidPhone(sdt))
            {
                MessageBox.Show("Số điện thoại phải gồm đúng 10 chữ số.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra CCCD 12 số
            if (!IsValidCCCD(cccd))
            {
                MessageBox.Show("CCCD phải gồm đúng 12 chữ số.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                bool success = InfoEmployeeBUS.UpdateNhanVien(maNV, tenNV, ngaySinh, gioiTinh, email, sdt, cccd, diaChi, chucVu, luong, maPhongBan);

                if (success)
                {
                    MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật nhân viên thất bại. Vui lòng kiểm tra ngày sinh của nhân viên (nhân viên phải trên 18 tuổi)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đóng chế độ chỉnh sửa
                SetFieldsReadOnly(true);
            }
        }
    }
}