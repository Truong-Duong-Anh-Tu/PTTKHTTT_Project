using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using PTTKHTTTProject.BUS;

namespace PTTKHTTTProject.UControl
{
    public partial class adminQlyLichThi : UserControl
    {
        private readonly ExamDateBUS lichThiBUS;
        private DataTable originalDataTable;

        public adminQlyLichThi()
        {
            InitializeComponent();
            lichThiBUS = new ExamDateBUS();
            originalDataTable = new DataTable();
            this.dataGridViewDSLichThi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.timerRefresh.Interval = 30000;
            this.timerRefresh.Start();
        }

        private void adminQlyLichThi_Load(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string currentFilter = originalDataTable.DefaultView.RowFilter;
                originalDataTable = ExamDateBUS.GetAllLichThi();
                dataGridViewDSLichThi.DataSource = originalDataTable;
                if (!string.IsNullOrEmpty(currentFilter))
                {
                    originalDataTable.DefaultView.RowFilter = currentFilter;
                }
                SetupDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu lịch thi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SetupDataGridView()
        {
            if (dataGridViewDSLichThi.Columns.Contains("Sua"))
                dataGridViewDSLichThi.Columns.Remove("Sua");
            if (dataGridViewDSLichThi.Columns.Contains("Xoa"))
                dataGridViewDSLichThi.Columns.Remove("Xoa");

            dataGridViewDSLichThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dataGridViewDSLichThi.Columns.Contains("Ngày Thi"))
            {
                dataGridViewDSLichThi.Columns["Ngày Thi"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            if (dataGridViewDSLichThi.Columns.Contains("Số Lượng Đã Đăng Ký"))
            {
                dataGridViewDSLichThi.Columns["Số Lượng Đã Đăng Ký"].HeaderText = "SL Đã Đăng Ký";
            }

            DataGridViewButtonColumn btnSua = new DataGridViewButtonColumn
            {
                Name = "Sua",
                HeaderText = "",
                Text = "Sửa",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                DefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.White }
            };
            dataGridViewDSLichThi.Columns.Add(btnSua);

            DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn
            {
                Name = "Xoa",
                HeaderText = "",
                Text = "Xóa",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                DefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.White }
            };
            dataGridViewDSLichThi.Columns.Add(btnXoa);
        }

        private void dataGridView1_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;

            if (sender is DataGridView dgv)
            {
                string colName = dgv.Columns[e.ColumnIndex].Name;
                if (colName == "Giờ Bắt Đầu" || colName == "Giờ Kết Thúc")
                {
                    if (e.Value is TimeSpan ts)
                    {
                        e.Value = ts.ToString(@"hh\:mm");
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void dataGridViewDSLichThi_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && dataGridViewDSLichThi.Columns.Contains("Sua") && dataGridViewDSLichThi.Columns.Contains("Xoa"))
            {
                int suaIndex = dataGridViewDSLichThi.Columns["Sua"].Index;
                int xoaIndex = dataGridViewDSLichThi.Columns["Xoa"].Index;

                if (e.ColumnIndex == suaIndex)
                {
                    Rectangle rect1 = dataGridViewDSLichThi.GetCellDisplayRectangle(suaIndex, -1, true);
                    Rectangle rect2 = dataGridViewDSLichThi.GetCellDisplayRectangle(xoaIndex, -1, true);

                    rect1.Width += rect2.Width - 1;
                    rect1.Height -= 1;

                    // --- BẮT ĐẦU PHẦN CHỈNH SỬA ---
                    // Thay đổi màu nền ở đây để khớp với header mặc định
                    e.Graphics.FillRectangle(new SolidBrush(dataGridViewDSLichThi.ColumnHeadersDefaultCellStyle.BackColor), rect1);
                    // --- KẾT THÚC PHẦN CHỈNH SỬA ---

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

        private void btnTimKiem_Click(object? sender, EventArgs e)
        {
            if (originalDataTable == null) return;
            string keyword = txtTimKiem.Text.Trim().Replace("'", "''");
            originalDataTable.DefaultView.RowFilter = string.IsNullOrEmpty(keyword)
                ? string.Empty
                : string.Format("[Mã Lịch Thi] LIKE '%{0}%' OR [Tên Kỳ Thi] LIKE '%{0}%' OR [Phòng Thi] LIKE '%{0}%'", keyword);
        }

        private void btnThem_Click(object? sender, EventArgs e)
        {
            fAdminThemLichThi f = new fAdminThemLichThi();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void dataGridViewDSLichThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataRowView selectedRow = (DataRowView)dataGridViewDSLichThi.Rows[e.RowIndex].DataBoundItem;
            string maLichThi = selectedRow["Mã Lịch Thi"].ToString();

            if (dataGridViewDSLichThi.Columns[e.ColumnIndex].Name == "Sua")
            {
                fAdminChinhSuaLichThi editForm = new fAdminChinhSuaLichThi(selectedRow);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
            else if (dataGridViewDSLichThi.Columns[e.ColumnIndex].Name == "Xoa")
            {
                if (MessageBox.Show($"Bạn có chắc chắn muốn xóa lịch thi [{maLichThi}] không? Hành động này không thể hoàn tác.", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    bool result = ExamDateBUS.DeleteLichThi(maLichThi);
                    if (result)
                    {
                        MessageBox.Show("Xóa lịch thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa lịch thi thất bại. Vui lòng đảm bảo lịch thi không có thí sinh đăng ký hoặc được phân công coi thi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}