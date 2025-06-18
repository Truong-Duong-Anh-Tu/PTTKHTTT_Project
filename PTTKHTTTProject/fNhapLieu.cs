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

namespace PTTKHTTTProject
{
    public partial class fNhapLieu : Form
    {
        private Form? activeForm;
        public fNhapLieu()
        {
            InitializeComponent();
            openChildForm(new fInfo());
        }

        private void lblNameHome_Click(object sender, EventArgs e)
        {

        }

        private void tlpMenu_Click_1(object sender, EventArgs e)
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
                openChildForm(new fInfo());
            }

            if (clicked == btnQLKQT)
            {
                openChildForm(new fManageKQT());
            }

            if (clicked == btnThongBao)
            {
                openChildForm(new fNotification());
            }
        }

        private void fHome_Load(object sender, EventArgs e)
        {
            btnTTCN.BackColor = Color.DeepSkyBlue;

            int size = Math.Min(ptbAvatar.Width, ptbAvatar.Height);
            ptbAvatar.Size = new Size(size, size);

            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, size, size);

            ptbAvatar.Region = new Region(gp);

            btnTTCN.FlatAppearance.BorderColor = SystemColors.Control;
            btnQLKQT.FlatAppearance.BorderColor= SystemColors.Control;
            btnThongBao.FlatAppearance.BorderColor= SystemColors.Control;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon dang xuat khong?", "Cancel Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lblDetailRole_Click(object sender, EventArgs e)
        {

        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
