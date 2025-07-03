using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTTKHTTTProject.BUS;

namespace PTTKHTTTProject.UControl
{
    public partial class adminQuanLyNV : UserControl
    {
        public adminQuanLyNV()
        {
            InitializeComponent();
            LoadNhanVienData();
            SetupSearchFunction();
        }

        private void SetupSearchFunction()
        {
            // Sử dụng textBox1 đã có sẵn trong form thay vì tạo mới
            textBox1.PlaceholderText = "Tìm mã số/tên nhân viên";

            // Ngăn việc chọn tất cả văn bản khi nhấp vào
            textBox1.GotFocus += (sender, e) => {
                // Đặt điểm chèn văn bản vào cuối dòng thay vì chọn tất cả
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.SelectionLength = 0;
            };

            // Thêm sự kiện tìm kiếm khi nhấn Enter
            textBox1.KeyDown += (sender, e) => {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchNhanVien(textBox1.Text);
                    e.SuppressKeyPress = true;
                }
            };

            // Thêm sự kiện tìm kiếm khi thay đổi text (tìm kiếm tức thì)
            textBox1.TextChanged += (sender, e) => {
                SearchNhanVien(textBox1.Text);
            };

            // Nếu có pictureBoxSearch trong form, kết nối nút tìm kiếm
            if (Controls.Find("pictureBoxSearch", true).FirstOrDefault() is PictureBox pictureBoxSearch)
            {
                pictureBoxSearch.Click += (sender, e) => {
                    SearchNhanVien(textBox1.Text);
                };
            }
        }

        private void LoadNhanVienData()
        {
            try
            {
                DataTable dtNhanVien = NhanVienBUS.GetAllNhanVien();
                dataGridView1.DataSource = dtNhanVien;
                FormatDataGridView(); // Gọi hàm format sau khi gán DataSource
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu nhân viên: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SearchNhanVien(string searchTerm)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    // Nếu không có từ khóa tìm kiếm, hiển thị tất cả
                    LoadNhanVienData();
                }
                else
                {
                    // Khi có từ khóa, gọi phương thức tìm kiếm
                    dataGridView1.DataSource = NhanVienBUS.SearchNhanVien(searchTerm);
                    FormatDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDataGridView()
        {
            // Xóa cột nút xóa cũ nếu tồn tại để tránh trùng lặp
            if (dataGridView1.Columns.Contains("DeleteButton"))
            {
                dataGridView1.Columns.Remove("DeleteButton");
            }

            // Thiết lập thuộc tính hiển thị
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (dataGridView1.Columns.Count > 0)
            {
                if (dataGridView1.Columns.Contains("Ngày Sinh"))
                    dataGridView1.Columns["Ngày Sinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
                if (dataGridView1.Columns.Contains("Lương"))
                    dataGridView1.Columns["Lương"].DefaultCellStyle.Format = "N0";
            }

            // Thêm cột nút Xóa
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "DeleteButton";
            deleteButton.HeaderText = "Hành động";
            deleteButton.Text = "Xóa";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Điều chỉnh độ rộng
            dataGridView1.Columns.Add(deleteButton);
        }

        private void buttonThemNV_Click(object sender, EventArgs e)
        {
            // Tạo instance của form thêm nhân viên
            fAdminThemNV formThemNV = new fAdminThemNV();

            // Hiển thị form dưới dạng dialog
            DialogResult result = formThemNV.ShowDialog();

            // Nếu người dùng đóng form bằng nút "OK" hoặc đã thêm nhân viên thành công
            if (result == DialogResult.OK)
            {
                // Cập nhật lại dữ liệu nhân viên để hiển thị nhân viên mới
                LoadNhanVienData();

                // Thông báo thành công
                MessageBox.Show("Thêm nhân viên mới thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Method từ code gốc
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Method từ code gốc
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có phải cột nút "Xóa" được nhấn hay không
            if (e.ColumnIndex == dataGridView1.Columns["DeleteButton"].Index && e.RowIndex >= 0)
            {
                // Lấy mã và tên nhân viên từ hàng được chọn
                string maNV = dataGridView1.Rows[e.RowIndex].Cells["Mã NV"].Value.ToString();
                string tenNV = dataGridView1.Rows[e.RowIndex].Cells["Họ Tên"].Value.ToString();

                // Hiển thị hộp thoại xác nhận
                DialogResult confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên '{tenNV}' (Mã: {maNV}) không?",
                                               "Xác nhận xóa",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    // Gọi BUS để thực hiện xóa
                    bool success = NhanVienBUS.DeleteNhanVien(maNV);

                    if (success)
                    {
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadNhanVienData(); // Tải lại dữ liệu để cập nhật danh sách
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại! Nhân viên có thể đang được tham chiếu ở nơi khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
