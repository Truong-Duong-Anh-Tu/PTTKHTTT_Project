using PTTKHTTTProject.BUS;
using PTTKHTTTProject.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace PTTKHTTTProject.UControl
{
    public partial class adminThemLichPhanCong : UserControl
    {
        private DataTable dtLichThi = new DataTable();
        private DataTable dtNhanVien = new DataTable();

        public adminThemLichPhanCong()
        {
            InitializeComponent();
        }

        private void adminThemLichPhanCong_Load(object? sender, EventArgs e)
        {
            LoadNhanVien();
            LoadKyThi();
            ClearThongTin();
        }

        private void LoadKyThi()
        {
            comboBoxKyThi.DataSource = ExamTypeBUS.loadExamType();
            comboBoxKyThi.SelectedIndex = -1;
            comboBoxKyThi.Text = "Chọn kỳ thi";
        }

        private void LoadNhanVien()
        {
            dtNhanVien = InfoEmployeeBUS.GetAvailableNhanVien();
            dataGridViewNhanVien.DataSource = dtNhanVien;
            dataGridViewNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ClearThongTin()
        {
            textBoxKyThi.Text = "";
            textBoxNgayThi.Text = "";
            textBoxPhongThi.Text = "";

            // Vô hiệu hóa và làm trống ô chọn giờ
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = " ";

            dateTimePicker2.Enabled = false;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = " ";

            textBoxMaNVCoiThi.Text = "";
            textBoxTenNVCoiThi.Text = "";
            comboBoxLichThi.DataSource = null;
            comboBoxLichThi.Enabled = false;
        }

        private void comboBoxKyThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKyThi.SelectedItem is string selectedKyThi)
            {
                string maKyThi = selectedKyThi.Split(' ')[0];
                dtLichThi = EmployeeScheduleDAO.GetLichThiByKyThi(maKyThi);
                comboBoxLichThi.DataSource = dtLichThi;
                comboBoxLichThi.DisplayMember = "DisplayText";
                comboBoxLichThi.ValueMember = "LT_MaLichThi";
                comboBoxLichThi.SelectedIndex = -1;
                comboBoxLichThi.Text = "Chọn lịch thi";
                comboBoxLichThi.Enabled = true;
            }
        }

        private void comboBoxLichThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLichThi.SelectedItem is DataRowView selectedRow)
            {
                textBoxKyThi.Text = comboBoxKyThi.Text.Split(new[] { " - " }, StringSplitOptions.None)[0].Trim();
                textBoxNgayThi.Text = ((DateTime)selectedRow["LT_NgayThi"]).ToString("dd/MM/yyyy");
                textBoxPhongThi.Text = selectedRow["LT_MaPhongThi"].ToString();

                // Kích hoạt, định dạng và gán giá trị cho ô thời gian bắt đầu
                dateTimePicker1.Enabled = true;
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "HH:mm";
                dateTimePicker1.Value = DateTime.Today + (TimeSpan)selectedRow["LT_TGBatDau"];

                // Kích hoạt, định dạng và gán giá trị cho ô thời gian kết thúc
                dateTimePicker2.Enabled = true;
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "HH:mm";
                dateTimePicker2.Value = DateTime.Today + (TimeSpan)selectedRow["LT_TGKetThuc"];
            }
            else
            {
                // Nếu không có lịch thi nào được chọn, hãy vô hiệu hóa lại
                dateTimePicker1.Enabled = false;
                dateTimePicker1.CustomFormat = " ";
                dateTimePicker2.Enabled = false;
                dateTimePicker2.CustomFormat = " ";
            }
        }

        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewNhanVien.Rows[e.RowIndex];
                textBoxMaNVCoiThi.Text = row.Cells["Mã NV"].Value?.ToString() ?? "";
                textBoxTenNVCoiThi.Text = row.Cells["Tên NV"].Value?.ToString() ?? "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem_Click(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text.Trim().Replace("'", "''");
            dtNhanVien.DefaultView.RowFilter = string.Format("[Mã NV] LIKE '%{0}%' OR [Tên NV] LIKE '%{0}%'", searchTerm);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (comboBoxLichThi.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn một lịch thi.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textBoxMaNVCoiThi.Text))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string? maLichThi = comboBoxLichThi.SelectedValue.ToString();
            string maNhanVien = textBoxMaNVCoiThi.Text;

            if (maLichThi == null) return;

            EmployeeScheduleBUS bus = new EmployeeScheduleBUS();
            if (bus.IsPhanCongLimitReached(maLichThi))
            {
                MessageBox.Show("Lịch thi này đã đủ số lượng nhân viên coi thi. Không thể thêm.", "Đã Đạt Giới Hạn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                bus.AddPhanCong(maLichThi, maNhanVien);
                MessageBox.Show("Thêm phân công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.FindForm()?.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Thêm phân công thất bại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxThoat_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }

    }
}