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
using PTTKHTTTProject.UControl;

namespace PTTKHTTTProject
{
    public partial class uc_KT_ManageReceipt : UserControl
    {
        private string username;
        public uc_KT_ManageReceipt(string accessUser)
        {
            InitializeComponent();
            username = accessUser;
        }

        //Hanh dong tao phieu thu ap dung voi phieu dang ky ma chua duoc tao phieu thu
        private DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn
        {
            Name = "btnAction",
            HeaderText = "Hành động",
            Text = "Tạo phiếu thu",
            UseColumnTextForButtonValue = true
        };

        //Checkbox chuyen khoan xac dinh phieu thu dung phuong thuc chuyen khoan hoac tien mat
        private DataGridViewCheckBoxColumn cbxCol = new DataGridViewCheckBoxColumn
        {
            Name = "cbxPaymentMethod",
            HeaderText = "Chuyển khoản",
            TrueValue = "Chuyển khoản",
            FalseValue = "Tiền mặt"
        };
        
        //Checkbox xac dinh phieu thu da duoc thanh toan
        private DataGridViewCheckBoxColumn cbxPaidCol = new DataGridViewCheckBoxColumn
        {
            Name = "cbxPaid",
            HeaderText = "Đã thanh toán",
            TrueValue = "True",
            FalseValue = "False"
        };

        private void NotPaycheckTableConfig()
        {
            dtgvResult.Columns.Add(btnCol);

            dtgvResult.CellContentClick += (s, ev) =>
            {
                if (ev.RowIndex >= 0)
                {
                    //Ma phieu dang ky
                    var selectedPaycheckID = dtgvResult.Rows[ev.RowIndex].Cells["MaPhieuTT"].Value.ToString();

                    // Handle button click for creating receipt
                    if (dtgvResult.Columns.Contains("btnAction") && ev.ColumnIndex == dtgvResult.Columns["btnAction"].Index)
                    {
                        fKT_CreateReceipt_Preview previewForm = new fKT_CreateReceipt_Preview(selectedPaycheckID, username);
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
                        ManageReceiptBUS.updatePaycheckMethod(selectedPaycheckID, currentValueString);
                    }
                    else if (dtgvResult.Columns.Contains("cbxPaid") && ev.ColumnIndex == dtgvResult.Columns["cbxPaid"].Index)
                    {
                        //Nếu trạng thái là "Thanh toán gia hạn" thì không cho phép thay đổi trạng thái thanh toán
                        if (dtgvResult.Rows[ev.RowIndex].Cells["TrangThai"].Value.ToString() == "Thanh toán gia hạn")
                        {
                            dtgvResult.Rows[ev.RowIndex].Cells["cbxPaid"].ReadOnly = true;
                            return;
                        }

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
                        ManageReceiptBUS.updatePaycheckPaid(selectedPaycheckID, currentValueString);
                    }
                }
            };
        }

        private void uc_KT_ManageReceipt_Load(object sender, EventArgs e)
        {
            //dtgvResult = new DataGridView();
            dtgvResult.DataSource = ManageReceiptBUS.loadReceipt("");
            NotPaycheckTableConfig();
            txbCount.Text = dtgvResult.Rows.Count.ToString();
        }

        private void dtgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvResult.ClearSelection();
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
                else if(row.Cells["TrangThai"].Value != null && row.Cells["TrangThai"].Value.ToString() == "Chưa thanh toán")
                {
                    row.Cells["cbxPaid"].Value = false;
                }
                else
                {
                    row.Cells["cbxPaid"].ReadOnly = true;
                }
            }
        }

        private void btnSearchReceipt_Click(object sender, EventArgs e)
        {
            removeColumnButton();
            if (rbxNotCreatedPaycheck.Checked)
            {
                if (txbInput.Text != string.Empty)
                {
                    string filter = txbInput.Text.Trim().ToLower();
                    dtgvResult.DataSource = ManageReceiptBUS.loadReceipt(filter);
                }
                else
                {
                    dtgvResult.DataSource = ManageReceiptBUS.loadReceipt("");
                }
                dtgvResult.Columns.Add(btnCol);
            }
            else
            {
                if (txbInput.Text != string.Empty)
                {
                    string filter = txbInput.Text.Trim().ToLower();
                    dtgvResult.DataSource = ManageReceiptBUS.loadPaycheck(filter);
                }
                else
                {
                    dtgvResult.DataSource = ManageReceiptBUS.loadPaycheck("");
                }
                //dtgvResult.DataSource = ManageReceiptBUS.loadPaycheck();
                checkboxConfig();
            }
            txbCount.Text = dtgvResult.Rows.Count.ToString();
        }

        private void rbxNotCreatedPaycheck_CheckedChanged(object sender, EventArgs e)
        {
            removeColumnButton();
            if (rbxNotCreatedPaycheck.Checked)
            {
                // Load receipt data for not created paychecks
                if (txbInput.Text != string.Empty)
                {
                    string filter = txbInput.Text.Trim().ToLower();
                    dtgvResult.DataSource = ManageReceiptBUS.loadReceipt(filter);
                }
                else
                {
                    dtgvResult.DataSource = ManageReceiptBUS.loadReceipt("");
                }
                dtgvResult.Columns.Add(btnCol);
                lblCount.Text = "Số yêu cầu chờ duyệt:";
                lblSearchReceipt.Text = "Danh sách các khoản chờ thanh toán";
            }
            else
            {
                if (txbInput.Text != string.Empty)
                {
                    string filter = txbInput.Text.Trim().ToLower();
                    dtgvResult.DataSource = ManageReceiptBUS.loadPaycheck(filter);
                }
                else
                {
                    dtgvResult.DataSource = ManageReceiptBUS.loadPaycheck("");
                }
                lblCount.Text = "Số phiếu thu đã tạo:";
                lblSearchReceipt.Text = "Danh sách các phiếu thu đã tạo";
                checkboxConfig();
            }
            txbCount.Text = dtgvResult.Rows.Count.ToString();
        }
    }
}
