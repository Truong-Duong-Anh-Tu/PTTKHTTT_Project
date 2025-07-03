using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTTKHTTTProject.UControl;

namespace PTTKHTTTProject
{
    public partial class fAdminThemChinhSuaLichPhanCong : Form
    {
        public fAdminThemChinhSuaLichPhanCong()
        {
            InitializeComponent();
        }

        private void panelThemLichPhanCong_Paint(object sender, PaintEventArgs e)
        {
            adminThemLichPhanCong adminThemThongTinLichPhanCong = new adminThemLichPhanCong();
            adminThemThongTinLichPhanCong.Dock = DockStyle.Fill;
            panelThemLichPhanCong.Controls.Add(adminThemThongTinLichPhanCong);
            adminThemThongTinLichPhanCong.BringToFront();
        }
    }
}
