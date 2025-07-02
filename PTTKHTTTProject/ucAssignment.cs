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
    public partial class ucAssignment : UserControl
    {
        public ucAssignment()
        {
            InitializeComponent();
        }

        private void ucAssignment_Load(object sender, EventArgs e)
        {
            dtgvPhanCong.DataSource = GuardExamAssignmentBUS.loadAssignment();

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
        }
    }
}
