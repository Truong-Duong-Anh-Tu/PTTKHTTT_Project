using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using PTTKHTTTProject.BUS;
using PTTKHTTTProject.UControl;

namespace PTTKHTTTProject
{
    public partial class fKeToan : Form
    {
        private UserControl activeControl;
        private string username;

        public fKeToan(string userAccount)
        {
            InitializeComponent();
            username = userAccount.ToUpper();
            activeControl = new UserControl();
            CustomUC.openChildControl(pnlChildControl, activeControl, new ucInfo(username));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tlpMenuKeToan_Click_1(object sender, EventArgs e)
        {
            var click = sender as Button;
            if (click == null) return;

            // Reset all buttons to default color
            foreach (var btn in tlpMenuKeToan.Controls.OfType<Button>())
            {
                btn.BackColor = SystemColors.Control;
                btn.ForeColor = Color.Black;
            }
            // Set color for the clicked button
            click.BackColor = Color.DeepSkyBlue;
            click.ForeColor = Color.White;
            if (click == btnTTCN)
            {
                lblOption.Text = "Thông tin cá nhân";
                CustomUC.openChildControl(pnlChildControl, activeControl, new ucInfo(username));
            }
            if (click == btnQLPT)
            {
                lblOption.Text = "Quản lý phiếu thu";
                CustomUC.openChildControl(pnlChildControl, activeControl, new uc_KT_ManageReceipt());
            }
            if (click == btnQLPGH)
            {
                lblOption.Text = "Quản lý phiếu gia hạn";
                CustomUC.openChildControl(pnlChildControl, activeControl, new uc_KT_ManageRenewal());
            }
            if (click == btnThongBao)
            {
                lblOption.Text = "Thông báo";
                CustomUC.openChildControl(pnlChildControl, activeControl, new ucNotification(username));
            }
        }

        private void fHome_Load(object sender, EventArgs e)
        {
            btnTTCN.BackColor = Color.DeepSkyBlue;
            btnTTCN.ForeColor = Color.White;

            int size = Math.Min(ptbAvatar.Width, ptbAvatar.Height);
            ptbAvatar.Size = new Size(size, size);

            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, size, size);

            ptbAvatar.Region = new Region(gp);

            btnTTCN.FlatAppearance.BorderColor = SystemColors.Control;
            btnQLPT.FlatAppearance.BorderColor = SystemColors.Control;
            btnQLPGH.FlatAppearance.BorderColor = SystemColors.Control;
            btnThongBao.FlatAppearance.BorderColor = SystemColors.Control;

            Dictionary<string, string> info = InfoEmployeeBUS.getInfoOfUser(username);

            string name = string.IsNullOrWhiteSpace(info["Hoten"]) ? "" : info["Hoten"].Trim().Split(' ').Last();
            lblName_Role.Text = $"{name} - Nhân viên kế toán";
        }

        private void btnKTSignout_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Cancel Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
