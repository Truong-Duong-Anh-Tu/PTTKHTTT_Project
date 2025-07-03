using System;
using System.Data;
using System.Windows.Forms;
using PTTKHTTTProject.BUS;

namespace PTTKHTTTProject.UControl
{
    public partial class adminQlyLichThi : UserControl
    {
        private readonly LichThiBUS lichThiBUS;
        private DataTable originalDataTable;

        public adminQlyLichThi()
        {
            InitializeComponent();
            lichThiBUS = new LichThiBUS();
            originalDataTable = new DataTable();
            // Gán sự kiện CellFormatting
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
        }

        private void adminQlyLichThi_Load(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                originalDataTable = lichThiBUS.GetAllLichThi();
                dataGridView1.DataSource = originalDataTable;
                SetupDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu lịch thi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dataGridView1.Columns.Contains("Ngày Thi"))
            {
                dataGridView1.Columns["Ngày Thi"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        // SỬA LẠI CHỮ KÝ CỦA PHƯƠNG THỨC NÀY
        private void dataGridView1_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;

            // Thêm kiểm tra null cho DataGridView
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
            // Thêm kiểm tra null cho DataTable
            if (originalDataTable == null) return;

            string keyword = txtTimKiem.Text.Trim().Replace("'", "''");

            originalDataTable.DefaultView.RowFilter = string.IsNullOrEmpty(keyword)
                ? string.Empty
                : string.Format("[Mã Lịch Thi] LIKE '%{0}%' OR [Tên Kỳ Thi] LIKE '%{0}%' OR [Phòng Thi] LIKE '%{0}%'", keyword);
        }

        private void btnThem_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Thêm Lịch thi chưa được cài đặt.", "Thông báo");
        }
    }
}