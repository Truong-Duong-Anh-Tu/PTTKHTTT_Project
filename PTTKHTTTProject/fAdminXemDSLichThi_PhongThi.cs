using System;
using System.Data;
using System.Windows.Forms;
using PTTKHTTTProject.BUS;

namespace PTTKHTTTProject
{
    public partial class fAdminXemDSLichThi_PhongThi : Form
    {
        private readonly string maPhongThi;
        private readonly LichThiBUS lichThiBUS;

        public fAdminXemDSLichThi_PhongThi(string maPhongThi)
        {
            InitializeComponent();
            this.maPhongThi = maPhongThi;
            this.lichThiBUS = new LichThiBUS();
            this.Load += new System.EventHandler(this.fAdminXemDSLichThi_PhongThi_Load);
        }

        private void fAdminXemDSLichThi_PhongThi_Load(object sender, EventArgs e)
        {
            labelHienThiPhongThi.Text = this.maPhongThi;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dataGridView1.DataSource = lichThiBUS.GetLichThiByPhongThi(this.maPhongThi);
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
            if (dataGridView1.Columns.Contains("Giờ Bắt Đầu") || dataGridView1.Columns.Contains("Giờ Kết Thúc"))
            {
                dataGridView1.Columns["Giờ Bắt Đầu"].DefaultCellStyle.Format = @"hh\:mm";
                dataGridView1.Columns["Giờ Kết Thúc"].DefaultCellStyle.Format = @"hh\:mm";
            }
        }

        private void pictureBoxThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}