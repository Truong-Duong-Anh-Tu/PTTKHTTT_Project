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
    public partial class ucInfo : UserControl
    {
        private string username;
        public ucInfo(string accessUser)
        {
            InitializeComponent();
            username = accessUser;
        }

        private void ucInfo_Load(object sender, EventArgs e)
        {
            var bus = new InfoEmployeeBUS(username);
            Dictionary<string, string> info = bus.getInfoOfUser();

            tbxHoTen.Text = info["Hoten"];
            tbxChucVu.Text = info["ChucVu"];
            tbxMaNV.Text = info["MaNV"];
            tbxNgaySinh.Text = info["NSinh"];
            tbxGioiTinh.Text = info["GTinh"];
            tbxDiaChi.Text = info["DChi"];
            tbxEmail.Text = info["Email"];
            tbxSDT.Text = info["SDT"];
            tbxCCCD.Text = info["CCCD"];

            lblDetailRole.Text = info["ChucVu"];
            lblDetailSalary.Text = info["Luong"];

            lblWelcome.Text = $"Chào mừng {info["Hoten"].Trim().Split(' ').Last()}";
        }

        private void pnlSalaryRole_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.DeepSkyBlue;
            ButtonBorderStyle style = ButtonBorderStyle.Solid;
            ControlPaint.DrawBorder(e.Graphics, this.pnlSalaryRole.ClientRectangle,
                borderColor, 2, style,
                borderColor, 2, style,
                borderColor, 2, style,
                borderColor, 2, style);
        }

        private void pnlHotenRole_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.DeepSkyBlue;
            ButtonBorderStyle style = ButtonBorderStyle.Solid;
            ControlPaint.DrawBorder(e.Graphics, this.pnlHotenRole.ClientRectangle,
                borderColor, 2, style,
                borderColor, 2, style,
                borderColor, 2, style,
                borderColor, 2, style);
        }

        private void pnlInfoNV_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.DeepSkyBlue;
            ButtonBorderStyle style = ButtonBorderStyle.Solid;
            ControlPaint.DrawBorder(e.Graphics, this.pnlInfoNV.ClientRectangle,
                borderColor, 2, style,
                borderColor, 2, style,
                borderColor, 2, style,
                borderColor, 2, style);
        }

        private void pnlSalaryRole_Resize(object sender, EventArgs e)
        {
            this.pnlSalaryRole.Invalidate();
        }

        private void pnlHotenRole_Resize(object sender, EventArgs e)
        {
            this.pnlHotenRole.Invalidate();
        }

        private void pnlInfoNV_Resize(object sender, EventArgs e)
        {
            this.pnlInfoNV.Invalidate();
        }
    }
}
