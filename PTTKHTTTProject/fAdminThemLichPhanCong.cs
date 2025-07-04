using PTTKHTTTProject.UControl;

namespace PTTKHTTTProject
{
    public partial class fAdminThemLichPhanCong : Form
    {
        public fAdminThemLichPhanCong()
        {
            InitializeComponent();
            this.Load += FAdminThemChinhSuaLichPhanCong_Load;
        }

        private void FAdminThemChinhSuaLichPhanCong_Load(object? sender, EventArgs e)
        {
            // Thêm UserControl vào panel khi form được tải
            adminThemLichPhanCong themLichPhanCongControl = new adminThemLichPhanCong();
            themLichPhanCongControl.Dock = DockStyle.Fill;
            panelThemLichPhanCong.Controls.Add(themLichPhanCongControl);
        }

        private void panelThemLichPhanCong_Paint(object sender, PaintEventArgs e)
        {
            // Không cần làm gì ở đây
        }

        private void fAdminThemLichPhanCong_Load(object sender, EventArgs e)
        {

        }
    }
}