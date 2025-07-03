using System;
using System.Windows.Forms;
using PTTKHTTTProject.UControl;

namespace PTTKHTTTProject
{
    public partial class fQuanTriDL : Form
    {
        private string loggedInUsername;

        public fQuanTriDL(string username)
        {
            InitializeComponent();
            this.loggedInUsername = username.ToUpper();
            LoadAdminSideBar();
            ShowTongQuan();
        }

        private void LoadAdminSideBar()
        {
            adminSidebar sidebar = new adminSidebar();
            sidebar.SidebarButtonClicked += Sidebar_SidebarButtonClicked;
            sidebar.Dock = DockStyle.Fill;
            panelSidebar.Controls.Clear();
            panelSidebar.Controls.Add(sidebar);
        }

        private void ShowTongQuan()
        {
            labelHeader.Text = "Tổng quan";
            panelMain.Controls.Clear();
            adminTongQuan tongQuanControl = new adminTongQuan();
            tongQuanControl.Dock = DockStyle.Fill;
            panelMain.Controls.Add(tongQuanControl);
        }

        private void Sidebar_SidebarButtonClicked(object? sender, string buttonText)
        {
            labelHeader.Text = buttonText;
            panelMain.Controls.Clear();

            UserControl? content = null;

            switch (buttonText)
            {
                case "Tổng quan":
                    content = new adminTongQuan();
                    break;
                case "Quản lý lịch nhân viên":
                    content = new adminQuanLyLichNV();
                    break;
                case "Quản lý nhân viên":
                    content = new adminQuanLyNV();
                    break;
                case "Quản lý lịch thi":
                    // Khởi tạo class, không phải biến
                    content = new adminQlyLichThi();
                    break;
                case "Thông báo":
                    content = new ucNotification(this.loggedInUsername);
                    break;
            }

            if (content != null)
            {
                content.Dock = DockStyle.Fill;
                panelMain.Controls.Add(content);
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Các sự kiện trống
        private void panelSidebar_Paint(object sender, PaintEventArgs e) { }
        private void panelMain_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void labelHeader_Click(object sender, EventArgs e) { }
        private void pictureAvatar_Click(object sender, EventArgs e) { }
        private void labelUsername_Click(object sender, EventArgs e) { }
        private void fQuanTriDL_Load(object sender, EventArgs e) { }
    }
}