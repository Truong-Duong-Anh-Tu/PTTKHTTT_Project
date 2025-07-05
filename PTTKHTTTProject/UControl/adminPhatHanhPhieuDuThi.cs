using PTTKHTTTProject.BUS;
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
        public adminPhatHanhPhieuDuThi()
        {
            InitializeComponent();
        }

        private void adminPhatHanhPhieuDuThi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // 1. Tự động tạo phiếu và lưu danh sách mã mới vào biến của lớp
                DataTable dtNewIDs = PhieuDuThiBUS.TuDongLapPhieuDuThi();
                this.newlyCreatedIDs = dtNewIDs.AsEnumerable().Select(row => row.Field<string>("MaPhieu")).ToList();

                // 2. Tải dữ liệu cho cả hai bảng
                DataTable dtPhieuDK = PhieuDangKyBUS.LayDSPhieuDangKy3Tuan();
                dataGridViewDSCho.DataSource = dtPhieuDK;
                dataGridViewDSCho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewDSCho.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridViewLichSuPhatHanh.Font, FontStyle.Bold);

                DataTable dtLichSu = PhieuDuThiBUS.getAllPhieuDuThi();
                // Gán DataSource sẽ tự động kích hoạt sự kiện DataBindingComplete, sau đó việc tô màu sẽ diễn ra
                dataGridViewLichSuPhatHanh.DataSource = dtLichSu;
                dataGridViewLichSuPhatHanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewLichSuPhatHanh.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridViewLichSuPhatHanh.Font, FontStyle.Bold);

                if (newlyCreatedIDs.Any())
                {
                    MessageBox.Show($"Đã tự động tạo thành công {newlyCreatedIDs.Count} phiếu dự thi mới.", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lịch sử phát hành: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện này sẽ được gọi sau khi gán DataSource cho dataGridViewLichSuPhatHanh
        private void dataGridViewLichSuPhatHanh_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Gọi hàm tô màu tại đây để đảm bảo grid đã sẵn sàng
            HighlightNewRows(this.newlyCreatedIDs);
        }

        private void HighlightNewRows(List<string> newIDs)
        {
            // Đặt lại màu nền cho tất cả các dòng về mặc định
            foreach (DataGridViewRow row in dataGridViewLichSuPhatHanh.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }

            if (newIDs == null || !newIDs.Any()) return;

            // Lặp qua DataGridView để tìm và tô màu các dòng mới
            foreach (DataGridViewRow row in dataGridViewLichSuPhatHanh.Rows)
            {
                // Đảm bảo cell và giá trị của nó không null
                if (row.Cells["Mã Phiếu Dự Thi"]?.Value != null)
                {
                    string currentID = row.Cells["Mã Phiếu Dự Thi"].Value.ToString();
                    if (newIDs.Contains(currentID))
                    {
                        // Tô màu xanh nhạt cho dòng mới để dễ nhận biết
                        row.DefaultCellStyle.BackColor = Color.LightCyan;
                    }
                }
            }
        }
    }
}