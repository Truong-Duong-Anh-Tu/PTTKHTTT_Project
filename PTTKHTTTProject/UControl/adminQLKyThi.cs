using System;
using System.Data;
using System.Windows.Forms;
using PTTKHTTTProject.BUS;

namespace PTTKHTTTProject.UControl
{
    public partial class adminQLKyThi : UserControl
    {
        private DataTable originalDataTable;
        public adminQLKyThi()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                originalDataTable = ExamTypeBUS.GetAllExams();
                dataGridViewDSKythi.DataSource = originalDataTable;
                SetupDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu kỳ thi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridView()
        {
            // Tự động điều chỉnh độ rộng của các cột để lấp đầy DataGridView.
            dataGridViewDSKythi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (originalDataTable == null) return;

            string keyword = textBoxTimKiem.Text.Trim().Replace("'", "''");

            originalDataTable.DefaultView.RowFilter = string.IsNullOrEmpty(keyword)
                ? string.Empty
                : $"[KT_MaKyThi] LIKE '%{keyword}%' OR [KT_TenKyThi] LIKE '%{keyword}%'";
        }

        private void dataGridViewDSKythi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewDSKythi.Rows[e.RowIndex];
                textBoxMaKyThi.Text = row.Cells["KT_MaKyThi"].Value.ToString();
                textBoxTenKyThi.Text = row.Cells["KT_TenKyThi"].Value.ToString();
                textBoxLePhi.Text = row.Cells["LePhi"].Value.ToString();
            }
        }
    }
}