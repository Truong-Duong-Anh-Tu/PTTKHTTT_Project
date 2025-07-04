using System;
using System.Data;
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

            // --- BẮT ĐẦU PHẦN THÊM MỚI ---
            // Khởi tạo và bắt đầu Timer
            timerRefresh.Interval = 30000; // Cập nhật sau mỗi 30 giây
            timerRefresh.Start();
            // --- KẾT THÚC PHẦN THÊM MỚI ---
        }

        private void adminQlyLichThi_Load(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Lưu lại bộ lọc hiện tại (nếu có)
                string currentFilter = originalDataTable.DefaultView.RowFilter;

                originalDataTable = ExamDateBUS.GetAllLichThi();
                dataGridViewDSLichThi.DataSource = originalDataTable;

                // Áp dụng lại bộ lọc sau khi tải dữ liệu mới
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

        // --- BẮT ĐẦU PHẦN THÊM MỚI ---
        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            LoadData(); // Tải lại dữ liệu để cập nhật trạng thái
        }
        // --- KẾT THÚC PHẦN THÊM MỚI ---

        private void SetupDataGridView()
        {
            // Xóa các button cũ để tránh trùng lặp
            if (dataGridViewDSLichThi.Columns.Contains("EditButton"))
                dataGridViewDSLichThi.Columns.Remove("EditButton");

            dataGridViewDSLichThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dataGridViewDSLichThi.Columns.Contains("Ngày Thi"))
            {
                dataGridViewDSLichThi.Columns["Ngày Thi"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            if (dataGridViewDSLichThi.Columns.Contains("Số Lượng Đã Đăng Ký"))
            {
                dataGridViewDSLichThi.Columns["Số Lượng Đã Đăng Ký"].HeaderText = "SL Đã Đăng Ký";
            }

            // Thêm cột nút Sửa
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.Name = "EditButton";
            editButton.HeaderText = "Hành Động";
            editButton.Text = "Sửa";
            editButton.UseColumnTextForButtonValue = true;
            editButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDSLichThi.Columns.Add(editButton);
        }

        private void dataGridView1_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;

            if (sender is DataGridView dgv)
            {
                string colName = dgv.Columns[e.ColumnIndex].Name;
                if (colName == "Giờ Bắt Đầu" || colName == "Giờ Kết Thúc")
                {
                    if (e.Value == null || e.Value == DBNull.Value)
                    {
                        e.Value = "";
                        e.FormattingApplied = true;
                    }
                    else if (e.Value is TimeSpan ts)
                    {
                        e.Value = ts.ToString(@"hh\:mm");
                        e.FormattingApplied = true;
                    }
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

            // Kiểm tra nếu click vào cột nút "Sửa"
            if (dataGridViewDSLichThi.Columns[e.ColumnIndex].Name == "EditButton")
            {
                DataRowView selectedRow = (DataRowView)dataGridViewDSLichThi.Rows[e.RowIndex].DataBoundItem;

                fAdminChinhSuaLichThi editForm = new fAdminChinhSuaLichThi(selectedRow);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadData(); // Tải lại dữ liệu sau khi sửa thành công
                }
            }
        }
    }
}