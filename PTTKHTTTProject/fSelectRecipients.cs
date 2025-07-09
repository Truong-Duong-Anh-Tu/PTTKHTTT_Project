using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTTKHTTTProject.BUS;

namespace PTTKHTTTProject
{
    public partial class fSelectRecipients : Form
    {
        private List<string> employees = new List<string>();
        private List<string> departments = new List<string>();
        public List<string> recipients = new List<string>();

        public fSelectRecipients()
        {
            InitializeComponent();
            employees = InfoEmployeeBUS.getAllRecipientEmployee();
            departments = DepartmentBUS.getAllRecipientDepartment();
        }

        private void rbtxNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtxNhanVien.Checked == true)
            {
                clbRecipients.Items.Clear();
                clbRecipients.Items.AddRange([.. employees]);
                clbRecipients.ClearSelected();
            }
        }

        private void rbtnPhongBan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPhongBan.Checked == true)
            {
                clbRecipients.Items.Clear();
                clbRecipients.Items.AddRange([.. departments]);
                clbRecipients.ClearSelected();
            }
        }

        private void tbxSearchRecipient_TextChanged(object sender, EventArgs e)
        {
            string filter = tbxSearchRecipient.Text.Trim().ToUpper();

            List<string> source;

            if (rbtxNhanVien.Checked)
            {
                source = employees;
            }
            else if (rbtnPhongBan.Checked)
            {
                source = departments;
            }
            else
            {
                source = [];
            }

            var filtered = string.IsNullOrEmpty(filter)
                ? source
                : source.Where(x => x.ToUpper().Contains(filter))
                        .ToList();

            UpdateCheckedListBox(filtered);
        }

        private void UpdateCheckedListBox(List<string> filtered)
        {
            // Lưu trạng thái đã check
            var checkedItems = clbRecipients.CheckedItems.Cast<string>().ToList();

            clbRecipients.BeginUpdate();
            clbRecipients.Items.Clear();
            clbRecipients.Items.AddRange(filtered.ToArray());

            // Khôi phục trạng thái check cho các item còn tồn tại
            foreach (var item in checkedItems)
            {
                int idx = clbRecipients.Items.IndexOf(item);
                if (idx >= 0)
                    clbRecipients.SetItemChecked(idx, true);
            }

            clbRecipients.EndUpdate();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            recipients = clbRecipients.CheckedItems.Cast<string>().ToList();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
