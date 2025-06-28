using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTTKHTTTProject.BUS;

namespace PTTKHTTTProject.UControl
{
    public partial class adminQuanLyLichNV : UserControl
    {
        private EmployeeScheduleBUS employeeScheduleBUS;
        public adminQuanLyLichNV()
        {
            InitializeComponent();
            employeeScheduleBUS = new EmployeeScheduleBUS();
        }

        private void labelTrangThai_Click(object sender, EventArgs e)
        {

        }

        private void labelTimMaNV_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelTimKiem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {

        }

        private void buttonThemPhanCong_Click(object sender, EventArgs e)
        {
            fAdminThemLichPhanCong fAdminThemLichPhanCong = new fAdminThemLichPhanCong();
            fAdminThemLichPhanCong.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adminQuanLyLichNV_Load(object sender, EventArgs e)
        {
            DataTable dt = employeeScheduleBUS.loadEmployeeSchedule();
            dataGridView1.DataSource = dt;
        }
    }
}
