using System;
using System.Data;
using System.Windows.Forms;
using PTTKHTTTProject.BUS;

namespace PTTKHTTTProject.UControl
{
    public partial class adminQLPhongThi : UserControl
    {
        public adminQLPhongThi()
        {
            InitializeComponent();
            LoadPhongThiData();
        }

        private void LoadPhongThiData()
        {
            try
            {
                dataGridView1.DataSource = PhongThiBUS.GetAllPhongThi();
                SetupDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu phòng thi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                    // Sử dụng tên cột chính xác từ câu lệnh INSERT của bạn
                    textBoxMaPhongThi.Text = row.Cells["PT_MaPhongThi"].Value.ToString();
                    comboBoxHinhThuc.Text = row.Cells["PT_HinhThuc"].Value.ToString();
                    textBoxMaxThiSinh.Text = row.Cells["PT_SLThiSinhToiDa"].Value.ToString();
                    textBoxMinThiSinh.Text = row.Cells["PT_SLThiSinhToiThieu"].Value.ToString();
                    textBoxSLNVCT.Text = row.Cells["PT_SLNhanVienCoiThi"].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc dữ liệu từ dòng đã chọn. Vui lòng kiểm tra lại tên các cột.\n\nChi tiết lỗi: " + ex.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonXemLichThi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMaPhongThi.Text))
            {
                MessageBox.Show("Vui lòng chọn một phòng thi từ danh sách.", "Chưa chọn phòng thi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selectedMaPhongThi = textBoxMaPhongThi.Text;
            fAdminXemDSLichThi_PhongThi f = new fAdminXemDSLichThi_PhongThi(selectedMaPhongThi);
            f.ShowDialog();
        }
    }
}