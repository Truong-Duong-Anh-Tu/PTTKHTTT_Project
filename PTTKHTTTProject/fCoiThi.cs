using PTTKHTTTProject.BUS;
using PTTKHTTTProject.UControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PTTKHTTTProject
{
    public partial class fCoiThi : Form
    {
        //private Form? activeForm;
        private UserControl activeControl;
        private string username;
        public fCoiThi(string accessUser)
        {
            InitializeComponent();
            username = accessUser.ToUpper();
            //openChildForm(new fInfo(username));
            activeControl = new UserControl();
            CustomUC.openChildControl(pnlChildControl, activeControl, new ucInfo(username));
        }

        private void fCoiThi_Load(object sender, EventArgs e)
        {
            btnTTCN.BackColor = Color.DeepSkyBlue;
            btnTTCN.ForeColor = Color.White;

            int size = Math.Min(ptbAvatar.Width, ptbAvatar.Height);
            ptbAvatar.Size = new Size(size, size);

            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, size, size);

            ptbAvatar.Region = new Region(gp);

            btnTTCN.FlatAppearance.BorderColor = SystemColors.Control;
            btnTCLPC.FlatAppearance.BorderColor = SystemColors.Control;
            btnThongBao.FlatAppearance.BorderColor = SystemColors.Control;

            Dictionary<string, string> info = NhanVienBUS.getInfoOfUser(username);

            string name = string.IsNullOrWhiteSpace(info["Hoten"]) ? "" : info["Hoten"].Trim().Split(' ').Last();
            lblName_Role.Text = $"{name} - Nhân viên coi thi";
        }

        private void tlpMenu_Click(object sender, EventArgs e)
        {
            var clicked = sender as Button;
            if (clicked == null) return;

            // 1. Reset tất cả về màu mặc định
            foreach (var btn in tlpMenu.Controls.OfType<Button>())
            {
                btn.BackColor = SystemColors.Control;
                btn.ForeColor = Color.Black;
            }

            // 2. Set màu cho nút được click
            clicked.BackColor = Color.DeepSkyBlue;
            clicked.ForeColor = Color.White;

            if (clicked == btnTTCN)
            {
                lblOption.Text = "Thông tin cá nhân";
                //openChildForm(new fInfo(username));
                CustomUC.openChildControl(pnlChildControl, activeControl, new ucInfo(username));
            }

            if (clicked == btnTCLPC)
            {
                lblOption.Text = "Tra cứu lịch phân công gác thi";
                //openChildForm(new fManageKQT());
                CustomUC.openChildControl(pnlChildControl, activeControl, new ucAssignment());
            }

            if (clicked == btnThongBao)
            {
                lblOption.Text = "Thông báo";
                //openChildForm(new fNotification(username));
                CustomUC.openChildControl(pnlChildControl, activeControl, new ucNotification(username));
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Cancel Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
