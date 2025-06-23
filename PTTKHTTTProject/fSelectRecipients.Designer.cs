namespace PTTKHTTTProject
{
    partial class fSelectRecipients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSelectRecipients = new Panel();
            rbtnPhongBan = new RadioButton();
            rbtxNhanVien = new RadioButton();
            btnConfirm = new Button();
            lblChonNguoiNhan = new Label();
            clbRecipients = new CheckedListBox();
            tbxSearchRecipient = new TextBox();
            btnCancel = new Button();
            pnlSelectRecipients.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSelectRecipients
            // 
            pnlSelectRecipients.Controls.Add(btnCancel);
            pnlSelectRecipients.Controls.Add(rbtnPhongBan);
            pnlSelectRecipients.Controls.Add(rbtxNhanVien);
            pnlSelectRecipients.Controls.Add(btnConfirm);
            pnlSelectRecipients.Controls.Add(lblChonNguoiNhan);
            pnlSelectRecipients.Controls.Add(clbRecipients);
            pnlSelectRecipients.Controls.Add(tbxSearchRecipient);
            pnlSelectRecipients.Location = new Point(2, 2);
            pnlSelectRecipients.Name = "pnlSelectRecipients";
            pnlSelectRecipients.Size = new Size(372, 385);
            pnlSelectRecipients.TabIndex = 0;
            // 
            // rbtnPhongBan
            // 
            rbtnPhongBan.AutoSize = true;
            rbtnPhongBan.CheckAlign = ContentAlignment.MiddleRight;
            rbtnPhongBan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtnPhongBan.Location = new Point(257, 59);
            rbtnPhongBan.Name = "rbtnPhongBan";
            rbtnPhongBan.Size = new Size(105, 24);
            rbtnPhongBan.TabIndex = 7;
            rbtnPhongBan.Text = "Phòng ban";
            rbtnPhongBan.UseVisualStyleBackColor = true;
            rbtnPhongBan.CheckedChanged += rbtnPhongBan_CheckedChanged;
            // 
            // rbtxNhanVien
            // 
            rbtxNhanVien.AutoSize = true;
            rbtxNhanVien.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtxNhanVien.Location = new Point(10, 59);
            rbtxNhanVien.Name = "rbtxNhanVien";
            rbtxNhanVien.Size = new Size(101, 24);
            rbtxNhanVien.TabIndex = 6;
            rbtxNhanVien.Text = "Nhân viên";
            rbtxNhanVien.UseVisualStyleBackColor = true;
            rbtxNhanVien.CheckedChanged += rbtxNhanVien_CheckedChanged;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(264, 341);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(98, 33);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // lblChonNguoiNhan
            // 
            lblChonNguoiNhan.AutoSize = true;
            lblChonNguoiNhan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChonNguoiNhan.Location = new Point(3, 3);
            lblChonNguoiNhan.Name = "lblChonNguoiNhan";
            lblChonNguoiNhan.Size = new Size(154, 20);
            lblChonNguoiNhan.TabIndex = 4;
            lblChonNguoiNhan.Text = "CHỌN NGƯỜI NHẬN";
            // 
            // clbRecipients
            // 
            clbRecipients.FormattingEnabled = true;
            clbRecipients.Location = new Point(10, 89);
            clbRecipients.Name = "clbRecipients";
            clbRecipients.Size = new Size(352, 246);
            clbRecipients.TabIndex = 1;
            // 
            // tbxSearchRecipient
            // 
            tbxSearchRecipient.Location = new Point(10, 26);
            tbxSearchRecipient.Name = "tbxSearchRecipient";
            tbxSearchRecipient.PlaceholderText = "Tìm kiếm nhân viên, phòng ban";
            tbxSearchRecipient.Size = new Size(352, 27);
            tbxSearchRecipient.TabIndex = 0;
            tbxSearchRecipient.TextChanged += tbxSearchRecipient_TextChanged;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(10, 341);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(98, 33);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Thoát";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // fSelectRecipients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 388);
            Controls.Add(pnlSelectRecipients);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fSelectRecipients";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chọn người nhận";
            pnlSelectRecipients.ResumeLayout(false);
            pnlSelectRecipients.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSelectRecipients;
        private TextBox tbxSearchRecipient;
        private CheckedListBox clbRecipients;
        private Label lblChonNguoiNhan;
        private Button btnConfirm;
        private RadioButton rbtnPhongBan;
        private RadioButton rbtxNhanVien;
        private Button btnCancel;
    }
}