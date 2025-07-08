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
            textBox1.GotFocus += (sender, e) =>
            {
                // Đặt điểm chèn văn bản vào cuối dòng thay vì chọn tất cả
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.SelectionLength = 0;
            };

            // Thêm sự kiện tìm kiếm khi nhấn Enter
            textBox1.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchNhanVien(textBox1.Text);
                    e.SuppressKeyPress = true;
                }
            };

            // Thêm sự kiện tìm kiếm khi thay đổi text (tìm kiếm tức thì)
            textBox1.TextChanged += (sender, e) => SearchNhanVien(textBox1.Text);

            // Nếu có pictureBoxSearch trong form, kết nối nút tìm kiếm
            if (Controls.Find("pictureBoxSearch", true).FirstOrDefault() is PictureBox pictureBoxSearch)
            {
                pictureBoxSearch.Click += (sender, e) =>
                {
                    SearchNhanVien(textBox1.Text);
                };
            }
        }

        private void LoadNhanVienData()
        {
            try
            {
                DataTable dtNhanVien = InfoEmployeeBUS.GetAllNhanVien();
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
                    dataGridView1.DataSource = InfoEmployeeBUS.SearchNhanVien(searchTerm);
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
            if (dataGridView1.Columns.Contains("SuaButton")) dataGridView1.Columns.Remove("SuaButton");
            if (dataGridView1.Columns.Contains("XoaButton")) dataGridView1.Columns.Remove("XoaButton");

            // Thiết lập thuộc tính hiển thị
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (dataGridView1.Columns["Ngày Sinh"] != null)
                dataGridView1.Columns["Ngày Sinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            if (dataGridView1.Columns["Lương"] != null)
                dataGridView1.Columns["Lương"].DefaultCellStyle.Format = "N0";

            // Thêm cột nút "Sửa"
            var editButton = new DataGridViewButtonColumn
            {
                Name = "SuaButton",
                Text = "Sửa",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                HeaderText = ""
            };
            dataGridView1.Columns.Add(editButton);

            // Thêm cột nút "Xóa"
            var deleteButton = new DataGridViewButtonColumn
            {
                Name = "XoaButton",
                Text = "Xóa",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                HeaderText = ""
            };
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Bỏ qua nếu nhấn vào header

            // Lấy thông tin nhân viên từ dòng được chọn một cách an toàn
            string maNV = dataGridView1.Rows[e.RowIndex].Cells["Mã NV"].Value?.ToString() ?? string.Empty;
            string tenNV = dataGridView1.Rows[e.RowIndex].Cells["Họ Tên"].Value?.ToString() ?? string.Empty;

            if (string.IsNullOrEmpty(maNV)) return; // Không làm gì nếu không có mã nhân viên

            // Nếu nhấn nút "Sửa"
            if (e.ColumnIndex == dataGridView1.Columns["SuaButton"]?.Index)
            {
                // Mở form chỉnh sửa (bạn cần tạo form fAdminChinhSuaNV và constructor phù hợp)
                // fAdminChinhSuaNV formChinhSua = new fAdminChinhSuaNV(maNV); 
                fAdminChinhSuaNV formChinhSua = new fAdminChinhSuaNV(maNV);
                formChinhSua.ShowDialog();
                LoadNhanVienData(); // Tải lại dữ liệu sau khi form chỉnh sửa đóng
            }
            // Nếu nhấn nút "Xóa"
            else if (e.ColumnIndex == dataGridView1.Columns["XoaButton"]?.Index)
            {
                var confirmResult = MessageBox.Show($"Bạn có chắc muốn xóa nhân viên '{tenNV}' (Mã: {maNV})?",
                                                     "Xác nhận xóa",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    bool success = InfoEmployeeBUS.DeleteNhanVien(maNV);
                    if (success)
                    {
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadNhanVienData(); // Tải lại dữ liệu
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại! Có thể nhân viên này đang có dữ liệu liên quan.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminQuanLyNV_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Chỉ thực hiện khi đang vẽ header (RowIndex = -1)
            if (e.RowIndex == -1 && dataGridView1.Columns.Contains("SuaButton") && dataGridView1.Columns.Contains("XoaButton"))
            {
                int suaIndex = dataGridView1.Columns["SuaButton"].Index;
                int xoaIndex = dataGridView1.Columns["XoaButton"].Index;

                if (e.ColumnIndex == suaIndex)
                {
                    // Lấy kích thước của hai ô header
                    Rectangle suaRect = e.CellBounds;
                    Rectangle xoaRect = dataGridView1.GetCellDisplayRectangle(xoaIndex, -1, true);
                    Rectangle headerRect = new Rectangle(suaRect.Left, suaRect.Top, suaRect.Width + xoaRect.Width, suaRect.Height);

                    // Vẽ lại nền và viền cho ô header đã gộp
                    e.Graphics.FillRectangle(new SolidBrush(e.CellStyle.BackColor), headerRect);
                    e.Graphics.DrawRectangle(SystemPens.ControlDark, headerRect);

                    // Vẽ chữ "Hành động" vào giữa
                    StringFormat format = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    e.Graphics.DrawString("Hành động", e.CellStyle.Font, new SolidBrush(e.CellStyle.ForeColor), headerRect, format);
                    

                    // Báo hiệu đã vẽ xong, không cần DataGridView vẽ lại
                    e.Handled = true;
                }
                else if (e.ColumnIndex == xoaIndex)
                {
                    // Ẩn header của cột Xóa vì đã được gộp
                    e.Handled = true;
                }
            }
        }
    }
}
