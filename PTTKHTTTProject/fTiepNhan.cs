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
    public partial class fTiepNhan : Form
    {
        public fTiepNhan()
        {
            InitializeComponent();
        }

        private void HideAllPanels()
        {
            panelPDK.Visible = false;
            panelXLCC.Visible = false;
            panelGiaHan.Visible = false;
            panelPDKAdd.Visible = false;
            panelPDKUpdate.Visible = false;
            panelKHDonVi.Visible = false;
            panelKHTuDo.Visible = false;
            panelTSDVEdit.Visible = false;
            panelTSTDEdit.Visible = false;
            panelTSTDAdd.Visible = false;
            panelTSDVAdd.Visible = false;
        }

        private void btnQLPDK_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelPDK.Visible = true;
            panelPDK.BringToFront();
        }

        private void btnXLCC_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelXLCC.Visible = true;
            panelXLCC.BringToFront();
        }

        private void btnCapNhatGiaHan_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelGiaHan.Visible = true;
            panelGiaHan.BringToFront();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPDK_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelPDKAdd.Visible = true;
            panelPDKAdd.BringToFront();
        }

        private void btnUpdatePDK_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelPDKUpdate.Visible = true;
            panelPDKUpdate.BringToFront();
        }

        private void PDKView_Search_Click(object sender, EventArgs e)
        {
            string MaPhieu = PDKView_SearchBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(MaPhieu))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu.");
                return;
            }

            try
            {
                DataTable dt = TiepNhan.TraCuuPhieuDangKy(MaPhieu);
                DataTable dt_ts = TiepNhan.TraCuuThiSinh(MaPhieu);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin.");
                    PDKView_AD.Text = "";
                    PDKView_DiaChi.Text = "";
                    PDKView_ED.Text = "";
                    PDKView_EmailKH.Text = "";
                    PDKView_LoaiKH.Text = "";
                    PDKView_KH.Text = "";
                    PDKView_KyThi.Text = "";
                    PDKView_NV.Text = "";
                    PDKView_SDTKH.Text = "";
                    PDKView_TTTT.Text = "";
                    return;
                }

                PDKView_AD.Text = dt.Rows[0]["PDKDT_ThoiGianLap"].ToString();
                PDKView_DiaChi.Text = dt.Rows[0]["PDKDT_DiaChiChuyenPhat"].ToString();
                PDKView_ED.Text = dt.Rows[0]["LT_NgayThi"].ToString();
                PDKView_EmailKH.Text = dt.Rows[0]["KH_Email"].ToString();
                PDKView_KH.Text = dt.Rows[0]["TenKhachHang"].ToString();
                PDKView_KyThi.Text = dt.Rows[0]["KT_TenKyThi"].ToString();
                PDKView_NV.Text = dt.Rows[0]["NhanVienTaoPhieu"].ToString();
                PDKView_SDTKH.Text = dt.Rows[0]["KH_SDT"].ToString();
                PDKView_TTTT.Text = dt.Rows[0]["PDKDT_TrangThaiThanhToan"].ToString();
                PDKView_LoaiKH.Text = dt.Rows[0]["KH_LoaiKhachHang"].ToString();
                label8.BringToFront();

                if (PDKView_LoaiKH.Text == "Tự do")
                {
                    panelKHDonVi.Visible = false;
                    panelKHTuDo.Visible = true;
                    panelKHTuDo.BringToFront();
                    PDKView_SDBTD.Text = dt_ts.Rows[0]["TS_SoBaoDanh"].ToString();
                    PDKView_SDTTD.Text = dt_ts.Rows[0]["TS_SDT"].ToString();
                    PDKView_SexTD.Text = dt_ts.Rows[0]["TS_GioiTinh"].ToString();
                    PDKView_EmailTD.Text = dt_ts.Rows[0]["TS_Email"].ToString();
                    PDKView_NameTD.Text = dt_ts.Rows[0]["TS_HoTen"].ToString();
                    PDKView_DOBTD.Text = dt_ts.Rows[0]["TS_NgaySinh"].ToString();
                    PDKView_CCCDTD.Text = dt_ts.Rows[0]["TS_CCCD"].ToString();
                }
                else if (PDKView_LoaiKH.Text == "Đơn vị")
                {
                    panelKHDonVi.Visible = true;
                    panelKHTuDo.Visible = false;
                    panelKHDonVi.BringToFront();
                    PDKView_dgvDV.DataSource = dt_ts;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void PDKView_btnSearchDV_Click(object sender, EventArgs e)
        {
            string HoTen = PDKView_SearchBoxDV.Text.Trim();
            if (string.IsNullOrWhiteSpace(HoTen))
            {
                MessageBox.Show("Vui lòng nhập họ và tên thí sinh.");
                return;
            }

            try 
            {
                DataTable dt = TiepNhan.TimThiSinh(HoTen);
                PDKView_dgvDV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
