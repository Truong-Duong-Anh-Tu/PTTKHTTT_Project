using PTTKHTTTProject.UControl;

namespace PTTKHTTTProject
{
    public partial class fAdminThemChinhSuaLichPhanCong : Form
    {
        public fAdminThemChinhSuaLichPhanCong()
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
    }
}