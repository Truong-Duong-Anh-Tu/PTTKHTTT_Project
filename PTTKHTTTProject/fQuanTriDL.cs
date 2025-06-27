using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTTKHTTTProject.BUS;

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

            // Lắng nghe các sự kiện:
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
            // Cập nhật text cho labelHeader
            labelHeader.Text = buttonText;

            // Xóa control cũ trong panelMain
            panelMain.Controls.Clear();

            // Bạn có thể thêm logic để hiển thị các UserControl khác nhau tại đây
            // Ví dụ:
            if (buttonText == "Thông báo")
            {
                ucNotification notificationControl = new ucNotification(this.loggedInUsername);
                notificationControl.Dock = DockStyle.Fill;
                panelMain.Controls.Add(notificationControl);
            }
            else if (buttonText == "Tổng quan")
            {
                ShowTongQuan();
            }
            else if (buttonText == "Quản lý lịch thi")
            {

            }
            else if (buttonText == "Quản lý kỳ thi")
            {

            }
            else if (buttonText == "Quản lý lịch nhân viên")
            {

            }
            else if(buttonText == "Quản lý nhân viên")
            {

            }
            else if (buttonText == "Phát hành phiếu dự thi")
            {

            }
            else if (buttonText == "Quản lý phòng thi")
            {

            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Cancel Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fQuanTriDL_Load(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelHeader_Click(object sender, EventArgs e)
        {

        }

        private void pictureAvatar_Click(object sender, EventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
