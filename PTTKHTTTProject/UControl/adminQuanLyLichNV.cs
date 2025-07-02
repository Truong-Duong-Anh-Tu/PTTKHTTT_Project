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
        private DataTable originalDataTable; // Để lưu trữ dữ liệu gốc

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
            FilterData();
        }

        private void panelTimKiem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {
            FilterData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FilterData();
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
            originalDataTable = employeeScheduleBUS.loadEmployeeSchedule();
            dataGridView1.DataSource = originalDataTable;

            // Điền dữ liệu cho combobox trạng thái
            comboBoxTrangThai.Items.Add("Tất cả");
            comboBoxTrangThai.Items.Add("Chưa diễn ra");
            comboBoxTrangThai.Items.Add("Hoàn thành");
            comboBoxTrangThai.SelectedIndex = 0; // Mặc định là "Tất cả"
        }

        private void FilterData()
        {
            string trangThai = comboBoxTrangThai.SelectedItem.ToString();
            string timKiem = textBox1.Text;

            DataView dv = new DataView(originalDataTable);
            string filter = "";

            if (trangThai != "Tất cả")
            {
                filter += $"[Trạng Thái] = '{trangThai}'";
            }

            if (!string.IsNullOrEmpty(timKiem))
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    filter += " AND ";
                }
                filter += $"[Mã Nhân Viên] LIKE '%{timKiem}%'";
            }

            dv.RowFilter = filter;
            dataGridView1.DataSource = dv;
        }
    }
}