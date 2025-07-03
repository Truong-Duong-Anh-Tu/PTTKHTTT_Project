using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using PTTKHTTTProject.BUS;

namespace PTTKHTTTProject
{
    public partial class ucAssignment : UserControl
    {
        private BindingSource bs_Assignment;
        public ucAssignment()
        {
            InitializeComponent();
            bs_Assignment = new BindingSource();
        }

        private void ucAssignment_Load(object sender, EventArgs e)
        {
            bs_Assignment.DataSource = GuardExamAssignmentBUS.loadAssignment();
            dtgvPhanCong.DataSource = bs_Assignment;

            dtgvPhanCong.Columns["PC_MaLichThi"]!.HeaderText = "Lịch thi";
            dtgvPhanCong.Columns["PC_MaLichThi"]!.Width = 90;

            dtgvPhanCong.Columns["KT_TenKyThi"]!.HeaderText = "Tên kỳ thi";
            dtgvPhanCong.Columns["KT_TenKyThi"]!.Width = 250;

            dtgvPhanCong.Columns["PC_MaNhanVien"]!.HeaderText = "Nhân viên";
            //dtgvPhanCong.Columns["PC_MaNhanVien"]!.Width = 20;

            dtgvPhanCong.Columns["LT_MaPhongThi"]!.HeaderText = "Phòng thi";
            //dtgvPhanCong.Columns["LT_MaPhongThi"]!.Width = 20;

            dtgvPhanCong.Columns["LT_NgayThi"]!.HeaderText = "Ngày thi";
            //dtgvPhanCong.Columns["LT_NgayThi"]!.Width = 20;

            dtgvPhanCong.Columns["LT_TGBatDau"]!.HeaderText = "Giờ thi";
            //dtgvPhanCong.Columns["LT_TGBatDau"]!.Width = 20;

            dtgvPhanCong.Columns["PC_TrangThai"]!.HeaderText = "Trang thái";
            //dtgvPhanCong.Columns["PC_TrangThai"]!.Width = 20;

            cbxStatus.SelectedItem = "Tất cả";
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            List<string> filters = new List<string>();

            if (!string.IsNullOrWhiteSpace(tbxSearch.Text))
            {
                string ten = tbxSearch.Text.Replace("'", "''");
                filters.Add($"PC_MaNhanVien LIKE '%{ten}%'");
            }

            if (cbxStatus.SelectedIndex > 0)
            {
                string trangThai = $"{cbxStatus.SelectedItem}";
                filters.Add($"PC_TrangThai = '{trangThai}'");
            }

            string finalFilter = string.Join(" AND ", filters);

            if (bs_Assignment.DataSource != null)
                bs_Assignment.Filter = finalFilter;
        }
    }
}
