using PTTKHTTTProject.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTKHTTTProject
{
    public partial class fSuaThiSinhDonVi : Form
    {
        private string _sbd;
        public fSuaThiSinhDonVi(string sbd)
        {
            InitializeComponent();
            _sbd = sbd;
        }

        private void fSuaThiSinhDonVi_Load(object sender, EventArgs e)
        {
            GioiTinh.DataSource = new List<string> { "Nam", "Nữ" };
            DataTable dt = SuaThiSinhDonViBUS.LoadThongTinThiSinh(_sbd);

            SBD.Text = dt.Rows[0]["TS_SoBaoDanh"].ToString();
            HoTen.Text = dt.Rows[0]["TS_HoTen"].ToString();
            GioiTinh.SelectedItem = dt.Rows[0]["TS_GioiTinh"].ToString();
            Email.Text = dt.Rows[0]["TS_Email"].ToString();
            SDT.Text = dt.Rows[0]["TS_SDT"].ToString();
            DOB.Value = Convert.ToDateTime(dt.Rows[0]["TS_NgaySinh"]);
            CCCD.Text = dt.Rows[0]["TS_CCCD"].ToString();
        }

        private void XacnhanTSDV_Click(object sender, EventArgs e)
        {
            string hoTen = HoTen.Text.Trim();
            DateTime ngaySinh = DOB.Value.Date;
            string gioiTinh = GioiTinh.SelectedItem.ToString();
            string email = Email.Text.Trim();
            string sdt = SDT.Text.Trim();
            string cccd = CCCD.Text.Trim();

            SuaThiSinhDonViBUS.CapNhatThiSinh(_sbd, hoTen, ngaySinh, gioiTinh, email, sdt, cccd);

            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void XoaThiSinhDV_Click(object sender, EventArgs e)
        {
            string sbd = SBD.Text.Trim();
            var result = MessageBox.Show("Bạn có chắc muốn xóa thí sinh này?",
                                 "Xác nhận xóa",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bool success = SuaThiSinhDonViBUS.XoaThiSinh(sbd);

                if (success)
                {
                    MessageBox.Show("Xóa thành công.");
                    this.DialogResult = DialogResult.OK;
                    this.Close(); // Đóng form sau khi xóa
                }
                else
                {
                    MessageBox.Show("Xóa thất bại. Vui lòng thử lại.");
                }
            }
        }
    }
}
