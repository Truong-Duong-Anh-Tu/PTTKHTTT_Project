using PTTKHTTTProject.BUS;
using PTTKHTTTProject.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTKHTTTProject.UControl
{
    public partial class adminPhatHanhPhieuDuThi : UserControl
    {
        private List<string> newlyCreatedIDs;
        private bool isShowingDSMoiPhatHanh = false;
        public adminPhatHanhPhieuDuThi()
        {
            InitializeComponent();
            this.textBoxTimKiem.TextChanged += new System.EventHandler(this.textBoxTimKiem_TextChanged);
        }

        private void adminPhatHanhPhieuDuThi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                radioButtonDSCho2Tuan.Checked = true;
                DataTable dtPhieuDK = PhieuDangKyBUS.LayDSPhieuDangKy2Tuan();
                dataGridViewDSCho.DataSource = dtPhieuDK;
                dataGridViewDSCho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewDSCho.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridViewDSCho.Font, FontStyle.Bold);

                DataTable dtLichSu = PhieuDuThiBUS.getAllPhieuDuThi();
                originalDataTable = dtLichSu;
                dataGridViewLichSuPhatHanh.DataSource = dtLichSu;
                dataGridViewLichSuPhatHanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewLichSuPhatHanh.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridViewLichSuPhatHanh.Font, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lịch sử phát hành: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private DataTable originalDataTable;
        private void FilterData()
        {
            if (originalDataTable == null) return;

            string searchTerm = textBoxTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                // Nếu không có từ khóa, hiển thị lại toàn bộ dữ liệu
                dataGridViewLichSuPhatHanh.DataSource = originalDataTable;
            }
            else
            {
                // Nếu có từ khóa, gọi phương thức tìm kiếm và cập nhật DataGridView
                try
                {
                    DataTable filteredData = PhieuDuThiBUS.SearchPhieuDuThi(searchTerm);
                    dataGridViewLichSuPhatHanh.DataSource = filteredData;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void radioButtonDSCho2Tuan_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDSCho2Tuan.Checked)
            {
                DataTable dtPhieuDK = PhieuDangKyBUS.LayDSPhieuDangKy2Tuan();
                dataGridViewDSCho.DataSource = dtPhieuDK;
                dataGridViewDSCho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewDSCho.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridViewDSCho.Font, FontStyle.Bold);
            }
        }
        private void radioButtonDSCho_CheckedChanged(object sender, EventArgs e)
        {
            // Hiển thị danh sách chờ còn lại
            DataTable dtConLai = PhieuDangKyBUS.LayDSPhieuDangKyConLai();
            dataGridViewDSCho.DataSource = dtConLai;
            dataGridViewDSCho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDSCho.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridViewDSCho.Font, FontStyle.Bold);
        }

        private void buttonDSChoMoiPhatHanh_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isShowingDSMoiPhatHanh)
                {
                    // Hiển thị danh sách toàn bộ phiếu dự thi
                    DataTable dtLichSu = PhieuDuThiBUS.getAllPhieuDuThi();
                    dataGridViewLichSuPhatHanh.DataSource = dtLichSu;
                    buttonDSChoMoiPhatHanh.Text = "Hiển thị danh sách mới phát hành (*)";
                    isShowingDSMoiPhatHanh = true;
                }
                else
                {
                    // Hiển thị danh sách mới phát hành
                    DataTable dtLSDuThi2Tuan = PhieuDuThiBUS.getPhieuDuThi2Tuan();
                    dataGridViewLichSuPhatHanh.DataSource = dtLSDuThi2Tuan;
                    buttonDSChoMoiPhatHanh.Text = "Hiển thị toàn bộ phiếu dự thi";
                    isShowingDSMoiPhatHanh = false;
                }
                dataGridViewLichSuPhatHanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewLichSuPhatHanh.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridViewDSCho.Font, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chuyển đổi danh sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPhatHanh_Click(object sender, EventArgs e)
        {
            // Tự động tạo phiếu và lưu danh sách mã mới vào biến của lớp
            DataTable dtNewIDs = PhieuDuThiBUS.TuDongLapPhieuDuThi();
            this.newlyCreatedIDs = dtNewIDs != null
                ? dtNewIDs.AsEnumerable().Select(row => row.Field<string>("MaPhieu")).ToList()
                : new List<string>();

            if (newlyCreatedIDs.Any())
            {
                MessageBox.Show($"Đã tự động tạo thành công {newlyCreatedIDs.Count} phiếu dự thi mới.", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không có phiếu dự thi mới được tạo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }
    }
}