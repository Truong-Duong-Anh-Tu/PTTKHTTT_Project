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
            textBox1.PlaceholderText = "Nhập mã số/tên nhân viên cần tìm kiếm...";

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
                // Lấy dữ liệu từ BUS
                DataTable dtNhanVien = NhanVienBUS.GetAllNhanVien();

                // Gán nguồn dữ liệu cho DataGridView
                dataGridView1.DataSource = dtNhanVien;

                // Format DataGridView
                FormatDataGridView();
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
            // Thiết lập thuộc tính hiển thị cho DataGridView
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Định dạng hiển thị cho các cột
            if (dataGridView1.Columns.Count > 0)
            {
                // Định dạng cột Ngày Sinh
                if (dataGridView1.Columns.Contains("Ngày Sinh"))
                    dataGridView1.Columns["Ngày Sinh"].DefaultCellStyle.Format = "dd/MM/yyyy";

                // Định dạng cột Lương
                if (dataGridView1.Columns.Contains("Lương"))
                    dataGridView1.Columns["Lương"].DefaultCellStyle.Format = "N0";
            }
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

        private void A(object sender, EventArgs e)
        {
            // Method từ code gốc
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
            // TODO: Xử lý khi click vào cell trong DataGridView
            // Ví dụ: mở form chi tiết hoặc chỉnh sửa nhân viên
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
