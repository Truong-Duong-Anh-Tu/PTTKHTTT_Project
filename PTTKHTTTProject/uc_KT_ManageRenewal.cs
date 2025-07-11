using PTTKHTTTProject.BUS;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PTTKHTTTProject
{
    public partial class uc_KT_ManageRenewal : UserControl
    {
        private string username;
        public uc_KT_ManageRenewal(string accessUser)
        {
            InitializeComponent();
            username = accessUser;
        }

        private DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn
        {
            Name = "btnAction",
            HeaderText = "Hành động",
            Text = "Tạo phiếu",
            UseColumnTextForButtonValue = true
        };

        //Checkbox chuyen khoan xac dinh phieu gia han dung phuong thuc chuyen khoan hoac tien mat
        private DataGridViewCheckBoxColumn cbxCol = new DataGridViewCheckBoxColumn
        {
            Name = "cbxPaymentMethod",
            HeaderText = "Chuyển khoản",
            TrueValue = "Chuyển khoản",
            FalseValue = "Tiền mặt"
        };

        //Checkbox xac dinh phieu gia han da duoc thanh toan
        private DataGridViewCheckBoxColumn cbxPaidCol = new DataGridViewCheckBoxColumn
        {
            Name = "cbxPaid",
            HeaderText = "Đã thanh toán",
            TrueValue = "True",
            FalseValue = "False"
        };

        private void NotCreatedRenewalsConfig()
        {
            dtgvResult.Columns.Add(btnCol);

            //dtgvResult.CellContentClick += (s, ev) =>
            //{
            //    var selectedRenewalID = dtgvResult.Rows[ev.RowIndex].Cells["MaPhieu"].Value.ToString();
            //    if (ev.ColumnIndex == dtgvResult.Columns["btnAction"].Index && ev.RowIndex >= 0)
            //    {
            //        fKT_CreateRenewal_Preview previewForm = new fKT_CreateRenewal_Preview(selectedRenewalID);
            //        previewForm.ShowDialog();
            //    }
            //};

            dtgvResult.CellContentClick += (s, ev) =>
            {
                if (ev.RowIndex >= 0)
                {
                    //Ma phieu dang ky
                    var selectedRenewalID = dtgvResult.Rows[ev.RowIndex].Cells["MaPhieu"].Value.ToString();

                    // Handle button click for creating renewal based on request
                    if (dtgvResult.Columns.Contains("btnAction") && ev.ColumnIndex == dtgvResult.Columns["btnAction"].Index)
                    {
                        fKT_CreateRenewal_Preview previewForm = new fKT_CreateRenewal_Preview(selectedRenewalID, username);
                        previewForm.ShowDialog();
                    }
                    // Handle checkbox click for payment method
                    else if (dtgvResult.Columns.Contains("cbxPaymentMethod") && ev.ColumnIndex == dtgvResult.Columns["cbxPaymentMethod"].Index)
                    {
                        var currentValue = dtgvResult.Rows[ev.RowIndex].Cells["cbxPaymentMethod"].Value;
                        string currentValueString;
                        if (currentValue == null)
                        {
                            currentValueString = "Tiền mặt";
                        }
                        else if (currentValue.ToString() == "True")
                        {
                            currentValueString = "Tiền mặt";
                        }
                        else
                        {
                            currentValueString = "Chuyển khoản";
                        }
                        ManageRenewalBUS.updateCreatedRenewalMethod(selectedRenewalID, currentValueString);
                    }
                    else if (dtgvResult.Columns.Contains("cbxPaid") && ev.ColumnIndex == dtgvResult.Columns["cbxPaid"].Index)
                    {
                        var currentValue = dtgvResult.Rows[ev.RowIndex].Cells["cbxPaid"].Value;
                        string currentValueString;
                        if (currentValue == null)
                        {
                            currentValueString = "Chưa thanh toán";
                        }
                        else if (currentValue.ToString() == "True")
                        {
                            currentValueString = "Chưa thanh toán";
                        }
                        else
                        {
                            currentValueString = "Đã thanh toán";
                        }
                        ManageRenewalBUS.updateCreatedRenewalPaid(selectedRenewalID, currentValueString);
                    }
                }
            };
        }

        private void uc_KT_ManageRenewal_Load(object sender, EventArgs e)
        {
            dtgvResult.DataSource = ManageRenewalBUS.loadRenewal("");
            NotCreatedRenewalsConfig();
            txbCount.Text = dtgvResult.Rows.Count.ToString();
        }

        private void removeColumnButton()
        {
            if (dtgvResult.Columns.Contains("btnAction"))
            {
                dtgvResult.Columns.Remove("btnAction");
            }

            if (dtgvResult.Columns.Contains("cbxPaid"))
            {
                dtgvResult.Columns.Remove("cbxPaid");
            }
            if (dtgvResult.Columns.Contains("cbxPaymentMethod"))
            {
                dtgvResult.Columns.Remove("cbxPaymentMethod");
            }
        }

        private void checkboxConfig()
        {
            dtgvResult.Columns.Add(cbxCol);
            foreach (DataGridViewRow row in dtgvResult.Rows)
            {
                if (row.Cells["HinhThuc"].Value != null && row.Cells["HinhThuc"].Value.ToString() == "Chuyển khoản")
                {
                    row.Cells["cbxPaymentMethod"].Value = true;
                }
                else
                {
                    row.Cells["cbxPaymentMethod"].Value = false;
                }
            }

            dtgvResult.Columns.Add(cbxPaidCol);
            foreach (DataGridViewRow row in dtgvResult.Rows)
            {
                if (row.Cells["TrangThai"].Value != null && row.Cells["TrangThai"].Value.ToString() == "Đã thanh toán")
                {
                    row.Cells["cbxPaid"].Value = true;
                }
                else
                {
                    row.Cells["cbxPaid"].Value = false;
                }
            }
        }

        private void btnSearchRenewal_Click(object sender, EventArgs e)
        {
            removeColumnButton();
            if (rbxPendingRenewal.Checked)
            {
                if (txbInput.Text != string.Empty)
                {
                    string filter = txbInput.Text.Trim().ToLower();
                    dtgvResult.DataSource = ManageRenewalBUS.loadRenewal(filter);
                }
                else
                {
                    dtgvResult.DataSource = ManageRenewalBUS.loadRenewal("");
                }
                dtgvResult.Columns.Add(btnCol);
            }
            else
            {
                if (txbInput.Text != string.Empty)
                {
                    string filter = txbInput.Text.Trim().ToLower();
                    dtgvResult.DataSource = ManageRenewalBUS.loadCreatedRenewal(filter);
                }
                else
                {
                    dtgvResult.DataSource = ManageRenewalBUS.loadCreatedRenewal("");
                }
                checkboxConfig();
            }
            txbCount.Text = dtgvResult.Rows.Count.ToString();
        }

        private void rbxPendingRenewal_CheckedChanged(object sender, EventArgs e)
        {
            removeColumnButton();
            if (rbxPendingRenewal.Checked)
            {
                // Load receipt data for not created paychecks
                if (txbInput.Text != string.Empty)
                {
                    string filter = txbInput.Text.Trim().ToLower();
                    dtgvResult.DataSource = ManageRenewalBUS.loadRenewal(filter);
                }
                else
                {
                    dtgvResult.DataSource = ManageRenewalBUS.loadRenewal("");
                }
                dtgvResult.Columns.Add(btnCol);
                lblCount.Text = "Số yêu cầu chờ duyệt:";
                lblSearchRenewal.Text = "Danh sách chờ tạo phiếu gia hạn";
            }
            else
            {
                if (txbInput.Text != string.Empty)
                {
                    string filter = txbInput.Text.Trim().ToLower();
                    dtgvResult.DataSource = ManageRenewalBUS.loadCreatedRenewal(filter);
                }
                else
                {
                    dtgvResult.DataSource = ManageRenewalBUS.loadCreatedRenewal("");
                }
                lblCount.Text = "Số phiếu thu đã tạo:";
                lblSearchRenewal.Text = "Danh sách phiếu gia hạn đã tạo";
                checkboxConfig();
            }
            txbCount.Text = dtgvResult.Rows.Count.ToString();
        }
    }
}
