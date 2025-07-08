using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTTKHTTTProject.DTO;

namespace PTTKHTTTProject
{
    public partial class fThemThiSinhDonVi : Form
    {
        public ThiSinhDonViDTO ThiSinhMoi { get; private set; }

        public fThemThiSinhDonVi()
        {
            InitializeComponent();
        }

        private void fThemThiSinhDonVi_Load(object sender, EventArgs e)
        {
            GioiTinh.DataSource = new List<string> { "Nam", "Nữ" };
        }

        private void XacNhan_Click(object sender, EventArgs e)
        {
            ThiSinhMoi = new ThiSinhDonViDTO
            {
                HoTen = TenTS.Text,
                NgaySinh = NgaySinh.Value,
                GioiTinh = GioiTinh.SelectedItem?.ToString() ?? "Nam",  // Mặc định nếu null
                Email = Email.Text,
                SDT = SDT.Text,
                CCCD = CCCD.Text
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
