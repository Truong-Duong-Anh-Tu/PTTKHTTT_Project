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
    public partial class adminSidebar : UserControl
    {
        public event EventHandler? NotificationButtonClick;
        public event EventHandler<string>? SidebarButtonClicked; 
        public adminSidebar()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTongQuan_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra xem đối tượng gửi sự kiện có phải là một Button không
            if (sender is Button clickedButton)
            {
                SidebarButtonClicked?.Invoke(this, clickedButton.Text);
                if (clickedButton.Name == "btnThongbao")
                {
                    NotificationButtonClick?.Invoke(this, EventArgs.Empty);
                }
            }
            // Nếu sender không phải là Button (ví dụ: người dùng lỡ nối sự kiện của control khác vào đây)
            // thì code sẽ không làm gì cả và không bị lỗi.
        }

        private void adminSidebar_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
