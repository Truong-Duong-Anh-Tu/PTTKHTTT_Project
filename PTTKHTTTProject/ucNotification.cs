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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PTTKHTTTProject
{
    public partial class ucNotification : UserControl
    {
        private string username;
        public ucNotification(string accessUser)
        {
            InitializeComponent();
            username = accessUser;
        }

        private void pnlSelections_Click(object sender, EventArgs e)
        {
            var clicked = sender as Button;
            if (clicked == null) return;

            // 1. Reset tất cả về màu mặc định
            foreach (var btn in pnlSelections.Controls.OfType<Button>())
            {
                btn.BackColor = SystemColors.Control;
                btn.ForeColor = Color.Black;
            }

            // 2. Set màu cho nút được click
            clicked.BackColor = Color.DeepSkyBlue;
            clicked.ForeColor = Color.White;

            if (clicked == btnMailReceived)
            {
                tbxFullMail.Clear();
                lvListMail.Items.Clear();
                lvListMail.View = View.Details;
                lvListMail.FullRowSelect = true; // Có thể chọn cả hàng
                lvListMail.Columns.Clear();
                lvListMail.Columns.Add("Người gửi", 95, HorizontalAlignment.Left);
                lvListMail.Columns.Add("Chủ đề", 197, HorizontalAlignment.Left);

                List<Dictionary<string, string>> listMail = MailBUS.getListMail(username);

                foreach (var mail in listMail)
                {
                    string senderm = mail["TB_MaNhanVienGui"];
                    string subject = mail["TB_ChuDe"];
                    string body = mail["TB_NoiDung"];
                    string time = mail["TB_ThoiGianGui"];

                    var item = new ListViewItem([senderm, subject, body, time]);

                    lvListMail.Items.Add(item);
                }

            }
        }

        private void lvListMail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvListMail.SelectedItems.Count > 0)
            {
                var selected = lvListMail.SelectedItems[0];

                string fullmail = $"Từ: {selected.SubItems[0].Text}\n" +
                    $"Chủ đề: {selected.SubItems[1].Text}\n" +
                    $"Thời gian gửi: {selected.SubItems[3].Text}\n\n\n" +
                    $"{selected.SubItems[2].Text}";

                tbxFullMail.Text = fullmail;
            }
        }

        private void btnAddNoti_Click(object sender, EventArgs e)
        {
            fCreateNotification fcn = new fCreateNotification(username);
            fcn.ShowDialog();
        }
    }
}
