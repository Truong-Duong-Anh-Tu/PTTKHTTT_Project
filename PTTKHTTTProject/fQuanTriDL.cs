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

namespace PTTKHTTTProject
{
    public partial class fQuanTriDL : Form
    {
        private string loggedInUsername;
        public fQuanTriDL(string username)
        {
            InitializeComponent();
            LoadAdminSideBar();
            this.loggedInUsername = username.ToUpper();
        }

        private void LoadAdminSideBar()
        {
            adminSidebar sidebar = new adminSidebar();

            // Lắng nghe các sự kiện:
            sidebar.NotificationButtonClick += Sidebar_NotificationButtonClick;
            sidebar.Dock = DockStyle.Fill;
            panelSidebar.Controls.Clear();
            panelSidebar.Controls.Add(sidebar);
        }

        private void Sidebar_NotificationButtonClick(object? sender, EventArgs e)
        {
            // Code để hiển thị UserControl Thông báo (đã làm ở lần trước)
            ucNotification notificationControl = new ucNotification(this.loggedInUsername);
            notificationControl.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(notificationControl);
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
    }
}
