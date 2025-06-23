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
    public partial class fCreateNotification : Form
    {
        private string username;
        public fCreateNotification(string accessUser)
        {
            InitializeComponent();
            username = accessUser;
        }

        private void fCreateNotification_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectReceipients_Click(object sender, EventArgs e)
        {
            fSelectRecipients fsr = new fSelectRecipients();
            if (fsr.ShowDialog() == DialogResult.OK)
            {
                List<string> recipients = fsr.recipients;
                tbxRecipients.Text = string.Join(", ", recipients.Select(r => r.Split(' ')[0]));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (tbxRecipients.Text.Length <= 0)
            {
                MessageBox.Show("Thông báo của bạn thiếu người nhận.", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (tbxBody.Text.Length <= 0) 
            {
                MessageBox.Show("Thông báo của bạn thiếu nội dung.", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                try
                {
                    List<string> recipients = tbxRecipients.Text
                                                .Split(',')
                                                .Select(s => s.Trim())
                                                .Where(s => !string.IsNullOrEmpty(s))
                                                .ToList();

                    string subject = tbxSubject.Text;
                    string body = tbxBody.Text;

                    foreach (string recipient in recipients)
                    {
                        MailBUS.sendNotification(username, recipient, subject, body);
                    }

                    if (MessageBox.Show("Đã gửi thông báo thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                catch (Exception ex) 
                {
                    if (MessageBox.Show(ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
                    { 
                        this.Close(); 
                    }    
                } 
            } 
                
        }
    }
}
