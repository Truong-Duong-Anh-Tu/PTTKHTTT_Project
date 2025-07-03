using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using PTTKHTTTProject.BUS;

namespace PTTKHTTTProject.UControl
{
    public partial class adminQuanLyLichNV : UserControl
    {
        private EmployeeScheduleBUS employeeScheduleBUS;
        private DataTable originalDataTable;

        public adminQuanLyLichNV()
        {
            InitializeComponent();
            employeeScheduleBUS = new EmployeeScheduleBUS();
            originalDataTable = new DataTable();
        }

        private void adminQuanLyLichNV_Load(object sender, EventArgs e)
        {
            LoadData();
            SetupDataGridViewColumns();
            PopulateComboBox();
            // Gán sự kiện vẽ lại ô
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
        }

        private void LoadData()
        {
            originalDataTable = employeeScheduleBUS.loadEmployeeSchedule();
            dataGridView1.DataSource = originalDataTable;
        }

        private void SetupDataGridViewColumns()
        {
            if (dataGridView1.Columns.Contains("Ngày Thi"))
            {
                dataGridView1.Columns["Ngày Thi"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dataGridView1.Columns.Contains("Sua")) dataGridView1.Columns.Remove("Sua");
            if (dataGridView1.Columns.Contains("Xoa")) dataGridView1.Columns.Remove("Xoa");

            DataGridViewButtonColumn btnSua = new DataGridViewButtonColumn
            {
                Name = "Sua",
                HeaderText = "",
                Text = "Sửa",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 75
            };
            dataGridView1.Columns.Add(btnSua);

            DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn
            {
                Name = "Xoa",
                HeaderText = "",
                Text = "Xóa",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 75
            };
            dataGridView1.Columns.Add(btnXoa);
        }

        private void PopulateComboBox()
        {
            if (comboBoxTrangThai.Items.Count == 0)
            {
                comboBoxTrangThai.Items.Add("Tất cả");
                comboBoxTrangThai.Items.Add("Chưa diễn ra");
                comboBoxTrangThai.Items.Add("Hoàn thành");
                comboBoxTrangThai.SelectedIndex = 0;
            }
        }

        // PHƯƠNG THỨC VẼ LẠI TIÊU ĐỀ ĐÃ SỬA LỖI
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && dataGridView1.Columns.Contains("Sua") && dataGridView1.Columns.Contains("Xoa"))
            {
                int suaIndex = dataGridView1.Columns["Sua"].Index;
                int xoaIndex = dataGridView1.Columns["Xoa"].Index;

                if (e.ColumnIndex == suaIndex)
                {
                    Rectangle rect1 = dataGridView1.GetCellDisplayRectangle(suaIndex, -1, true);
                    Rectangle rect2 = dataGridView1.GetCellDisplayRectangle(xoaIndex, -1, true);

                    rect1.Width += rect2.Width - 1; // Gộp chiều rộng
                    rect1.Height -= 1; // Giảm chiều cao để đường viền không bị đè

                    e.Graphics.FillRectangle(new SolidBrush(e.CellStyle.BackColor), rect1);
                    e.Graphics.DrawRectangle(SystemPens.ControlDark, rect1);

                    StringFormat format = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    e.Graphics.DrawString("Hành động", e.CellStyle.Font, new SolidBrush(e.CellStyle.ForeColor), rect1, format);

                    e.Handled = true;
                }
                // Ngăn không cho cột thứ hai ("Xóa") tự vẽ tiêu đề của nó
                else if (e.ColumnIndex == xoaIndex)
                {
                    e.Handled = true;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Sua")
            {
                DataRowView selectedRow = (DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                adminChinhSuaLichNV chinhSuaControl = new adminChinhSuaLichNV(selectedRow);
                chinhSuaControl.Dock = DockStyle.Fill;
                Panel? parentPanel = this.Parent as Panel;
                if (parentPanel != null)
                {
                    parentPanel.Controls.Clear();
                    parentPanel.Controls.Add(chinhSuaControl);
                }
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Xoa")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa lịch phân công này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Lấy thông tin từ dòng được chọn
                    DataRowView row = (DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                    string? maLichThi = row["LT_MaLichThi"]?.ToString();
                    string? maNhanVien = row["Mã Nhân Viên"]?.ToString();

                    // Kiểm tra dữ liệu hợp lệ trước khi xóa
                    if (!string.IsNullOrEmpty(maLichThi) && !string.IsNullOrEmpty(maNhanVien))
                    {
                        bool success = employeeScheduleBUS.DeleteEmployeeSchedule(maLichThi, maNhanVien);

                        if (success)
                        {
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Tải lại dữ liệu để cập nhật bảng
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể xác định lịch phân công để xóa.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FilterData()
        {
            if (comboBoxTrangThai.SelectedItem == null || originalDataTable == null) return;
            string trangThai = comboBoxTrangThai.SelectedItem.ToString() ?? "";
            string timKiem = textBox1.Text.Trim();
            DataView dv = new DataView(originalDataTable);
            string filter = "1=1";
            if (trangThai != "Tất cả")
            {
                filter += $" AND [Trạng Thái] = '{trangThai}'";
            }
            if (!string.IsNullOrEmpty(timKiem))
            {
                filter += $" AND ([Mã Nhân Viên] LIKE '%{timKiem}%' OR [Tên Nhân Viên] LIKE '%{timKiem}%')";
            }
            dv.RowFilter = filter;
            dataGridView1.DataSource = dv;
        }

        private void comboBoxTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void buttonThemPhanCong_Click(object sender, EventArgs e)
        {
            fAdminThemChinhSuaLichPhanCong fAdminThemLichPhanCong = new fAdminThemChinhSuaLichPhanCong();
            fAdminThemLichPhanCong.ShowDialog();
            LoadData();
        }
    }
}