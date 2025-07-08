using System;
using System.Collections.Generic;
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

        private void adminQuanLyLichNV_Load(object? sender, EventArgs e)
        {
            employeeScheduleBUS.UpdateAllExamStatus();
            LoadData();
            SetupDataGridViewColumns();
            PopulateComboBox();

            // Thêm dòng này để đăng ký sự kiện
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);

            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            if (dataGridView1.Columns.Contains("LT_MaLichThi"))
            {
                dataGridView1.Columns["LT_MaLichThi"].HeaderText = "Mã Lịch Thi";
            }
            if (dataGridView1.Columns.Contains("Sua")) dataGridView1.Columns.Remove("Sua");
            if (dataGridView1.Columns.Contains("Xoa")) dataGridView1.Columns.Remove("Xoa");

            DataGridViewButtonColumn btnSua = new DataGridViewButtonColumn { Name = "Sua", HeaderText = "", Text = "Sửa", UseColumnTextForButtonValue = true, AutoSizeMode = DataGridViewAutoSizeColumnMode.None, Width = 75, DefaultCellStyle = new DataGridViewCellStyle { BackColor = SystemColors.Control } };
            dataGridView1.Columns.Add(btnSua);
            DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn { Name = "Xoa", HeaderText = "", Text = "Xóa", UseColumnTextForButtonValue = true, AutoSizeMode = DataGridViewAutoSizeColumnMode.None, Width = 75, DefaultCellStyle = new DataGridViewCellStyle { BackColor = SystemColors.Control } };
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

        private void dataGridView1_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && dataGridView1.Columns.Contains("Sua") && dataGridView1.Columns.Contains("Xoa"))
            {
                int suaIndex = dataGridView1.Columns["Sua"].Index;
                int xoaIndex = dataGridView1.Columns["Xoa"].Index;
                if (e.ColumnIndex == suaIndex)
                {
                    Rectangle rect1 = dataGridView1.GetCellDisplayRectangle(suaIndex, -1, true);
                    Rectangle rect2 = dataGridView1.GetCellDisplayRectangle(xoaIndex, -1, true);
                    rect1.Width += rect2.Width - 1;
                    rect1.Height -= 1;
                    e.Graphics.FillRectangle(new SolidBrush(e.CellStyle.BackColor), rect1);
                    e.Graphics.DrawRectangle(SystemPens.ControlDark, rect1);
                    StringFormat format = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    e.Graphics.DrawString("Hành động", e.CellStyle.Font, new SolidBrush(e.CellStyle.ForeColor), rect1, format);
                    e.Handled = true;
                }
                else if (e.ColumnIndex == xoaIndex)
                {
                    e.Handled = true;
                }
            }
        }

        private void dataGridView1_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Sua" && dataGridView1.Rows[e.RowIndex].DataBoundItem is DataRowView selectedRow)
            {
                adminChinhSuaLichNV chinhSuaControl = new adminChinhSuaLichNV(selectedRow);
                chinhSuaControl.Dock = DockStyle.Fill;
                if (this.Parent is Panel parentPanel)
                {
                    parentPanel.Controls.Clear();
                    parentPanel.Controls.Add(chinhSuaControl);
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Xoa")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa lịch phân công này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dataGridView1.Rows[e.RowIndex].DataBoundItem is DataRowView row)
                    {
                        string? maLichThi = row["LT_MaLichThi"]?.ToString();
                        string? maNhanVien = row["Mã Nhân Viên"]?.ToString();

                        if (!string.IsNullOrEmpty(maLichThi) && !string.IsNullOrEmpty(maNhanVien))
                        {
                            bool success = employeeScheduleBUS.DeleteEmployeeSchedule(maLichThi, maNhanVien);
                            if (success)
                            {
                                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Xóa thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void FilterData()
        {
            if (originalDataTable == null) return;
            var filters = new List<string>();

            if (comboBoxTrangThai.SelectedItem != null && comboBoxTrangThai.SelectedItem.ToString() != "Tất cả")
            {
                filters.Add(string.Format("[Trạng Thái] = '{0}'", comboBoxTrangThai.SelectedItem));
            }

            string timKiem = textBox1.Text.Trim().Replace("'", "''");
            if (!string.IsNullOrEmpty(timKiem))
            {
                filters.Add(string.Format("([Mã Nhân Viên] LIKE '%{0}%' OR [Tên Nhân Viên] LIKE '%{0}%')", timKiem));
            }

            originalDataTable.DefaultView.RowFilter = string.Join(" AND ", filters);
        }

        private void comboBoxTrangThai_SelectedIndexChanged(object? sender, EventArgs e)
        {
            FilterData();
        }

        private void textBox1_TextChanged(object? sender, EventArgs e)
        {
            FilterData();
        }

        private void pictureBoxSearch_Click(object? sender, EventArgs e)
        {
            FilterData();
        }

        private void buttonThemPhanCong_Click(object? sender, EventArgs e)
        {
            fAdminThemLichPhanCong f = new fAdminThemLichPhanCong();
            f.ShowDialog();
            LoadData();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem đây có phải là cột "Giờ Bắt Đầu" hoặc "Giờ Kết Thúc" không
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Giờ Bắt Đầu" || colName == "Giờ Kết Thúc")
            {
                // Nếu giá trị là một TimeSpan, định dạng lại nó thành "HH:mm"
                if (e.Value is TimeSpan ts)
                {
                    e.Value = ts.ToString(@"hh\:mm");
                    e.FormattingApplied = true;
                }
            }
        }
    }
}