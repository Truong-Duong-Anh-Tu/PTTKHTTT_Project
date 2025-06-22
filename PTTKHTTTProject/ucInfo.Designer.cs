namespace PTTKHTTTProject
{
    partial class ucInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSalaryRole = new Panel();
            lblDetailSalary = new Label();
            ptbSalary = new PictureBox();
            lblDetailRole = new Label();
            lblWelcome = new Label();
            ptbDRole = new PictureBox();
            pnlHotenRole = new Panel();
            tbxChucVu = new TextBox();
            lblChucVu = new Label();
            tbxHoTen = new TextBox();
            lblHovaTen = new Label();
            ptbDetailAvatar = new PictureBox();
            lblAnhDaiDien = new Label();
            pnlInfoNV = new Panel();
            tbxCCCD = new TextBox();
            tbxSDT = new TextBox();
            tbxEmail = new TextBox();
            lblCCCD = new Label();
            lblSDT = new Label();
            lblEmail = new Label();
            tbxDiaChi = new TextBox();
            tbxGioiTinh = new TextBox();
            tbxNgaySinh = new TextBox();
            tbxMaNV = new TextBox();
            lblDiaChi = new Label();
            lblGioiTinh = new Label();
            label1 = new Label();
            lblMaNV = new Label();
            lblTTCN = new Label();
            pnlSalaryRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbDRole).BeginInit();
            pnlHotenRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbDetailAvatar).BeginInit();
            pnlInfoNV.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSalaryRole
            // 
            pnlSalaryRole.Controls.Add(lblDetailSalary);
            pnlSalaryRole.Controls.Add(ptbSalary);
            pnlSalaryRole.Controls.Add(lblDetailRole);
            pnlSalaryRole.Controls.Add(lblWelcome);
            pnlSalaryRole.Controls.Add(ptbDRole);
            pnlSalaryRole.Location = new Point(3, 3);
            pnlSalaryRole.Name = "pnlSalaryRole";
            pnlSalaryRole.Size = new Size(1015, 147);
            pnlSalaryRole.TabIndex = 0;
            pnlSalaryRole.Paint += pnlSalaryRole_Paint;
            // 
            // lblDetailSalary
            // 
            lblDetailSalary.Anchor = AnchorStyles.None;
            lblDetailSalary.AutoSize = true;
            lblDetailSalary.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetailSalary.Location = new Point(773, 61);
            lblDetailSalary.Name = "lblDetailSalary";
            lblDetailSalary.Size = new Size(85, 21);
            lblDetailSalary.TabIndex = 10;
            lblDetailSalary.Text = "<Salary>";
            // 
            // ptbSalary
            // 
            ptbSalary.Anchor = AnchorStyles.None;
            ptbSalary.Image = Properties.Resources.Rupee;
            ptbSalary.Location = new Point(725, 53);
            ptbSalary.Name = "ptbSalary";
            ptbSalary.Size = new Size(42, 40);
            ptbSalary.SizeMode = PictureBoxSizeMode.Zoom;
            ptbSalary.TabIndex = 9;
            ptbSalary.TabStop = false;
            // 
            // lblDetailRole
            // 
            lblDetailRole.Anchor = AnchorStyles.None;
            lblDetailRole.AutoSize = true;
            lblDetailRole.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetailRole.Location = new Point(227, 61);
            lblDetailRole.Name = "lblDetailRole";
            lblDetailRole.Size = new Size(70, 21);
            lblDetailRole.TabIndex = 8;
            lblDetailRole.Text = "<Role>";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(3, 3);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(132, 23);
            lblWelcome.TabIndex = 7;
            lblWelcome.Text = "<Place holder>";
            // 
            // ptbDRole
            // 
            ptbDRole.Anchor = AnchorStyles.None;
            ptbDRole.Image = Properties.Resources.UserIcon;
            ptbDRole.Location = new Point(179, 53);
            ptbDRole.Name = "ptbDRole";
            ptbDRole.Size = new Size(42, 40);
            ptbDRole.SizeMode = PictureBoxSizeMode.Zoom;
            ptbDRole.TabIndex = 3;
            ptbDRole.TabStop = false;
            // 
            // pnlHotenRole
            // 
            pnlHotenRole.Controls.Add(tbxChucVu);
            pnlHotenRole.Controls.Add(lblChucVu);
            pnlHotenRole.Controls.Add(tbxHoTen);
            pnlHotenRole.Controls.Add(lblHovaTen);
            pnlHotenRole.Controls.Add(ptbDetailAvatar);
            pnlHotenRole.Controls.Add(lblAnhDaiDien);
            pnlHotenRole.Location = new Point(3, 156);
            pnlHotenRole.Name = "pnlHotenRole";
            pnlHotenRole.Size = new Size(348, 414);
            pnlHotenRole.TabIndex = 1;
            pnlHotenRole.Paint += pnlHotenRole_Paint;
            // 
            // tbxChucVu
            // 
            tbxChucVu.Anchor = AnchorStyles.None;
            tbxChucVu.BorderStyle = BorderStyle.None;
            tbxChucVu.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxChucVu.Location = new Point(47, 347);
            tbxChucVu.Name = "tbxChucVu";
            tbxChucVu.ReadOnly = true;
            tbxChucVu.Size = new Size(250, 23);
            tbxChucVu.TabIndex = 18;
            tbxChucVu.TextAlign = HorizontalAlignment.Center;
            // 
            // lblChucVu
            // 
            lblChucVu.Anchor = AnchorStyles.None;
            lblChucVu.AutoSize = true;
            lblChucVu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChucVu.Location = new Point(138, 321);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(74, 23);
            lblChucVu.TabIndex = 14;
            lblChucVu.Text = "Chức vụ";
            // 
            // tbxHoTen
            // 
            tbxHoTen.Anchor = AnchorStyles.None;
            tbxHoTen.BorderStyle = BorderStyle.None;
            tbxHoTen.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxHoTen.Location = new Point(47, 276);
            tbxHoTen.Name = "tbxHoTen";
            tbxHoTen.ReadOnly = true;
            tbxHoTen.Size = new Size(251, 23);
            tbxHoTen.TabIndex = 17;
            tbxHoTen.TextAlign = HorizontalAlignment.Center;
            // 
            // lblHovaTen
            // 
            lblHovaTen.Anchor = AnchorStyles.None;
            lblHovaTen.AutoSize = true;
            lblHovaTen.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHovaTen.Location = new Point(134, 250);
            lblHovaTen.Name = "lblHovaTen";
            lblHovaTen.Size = new Size(87, 23);
            lblHovaTen.TabIndex = 16;
            lblHovaTen.Text = "Họ và tên";
            // 
            // ptbDetailAvatar
            // 
            ptbDetailAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ptbDetailAvatar.Image = Properties.Resources.avatar;
            ptbDetailAvatar.Location = new Point(100, 51);
            ptbDetailAvatar.Name = "ptbDetailAvatar";
            ptbDetailAvatar.Size = new Size(148, 149);
            ptbDetailAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            ptbDetailAvatar.TabIndex = 9;
            ptbDetailAvatar.TabStop = false;
            // 
            // lblAnhDaiDien
            // 
            lblAnhDaiDien.AutoSize = true;
            lblAnhDaiDien.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnhDaiDien.Location = new Point(3, 3);
            lblAnhDaiDien.Name = "lblAnhDaiDien";
            lblAnhDaiDien.Size = new Size(112, 23);
            lblAnhDaiDien.TabIndex = 15;
            lblAnhDaiDien.Text = "Ảnh đại diện";
            // 
            // pnlInfoNV
            // 
            pnlInfoNV.Controls.Add(tbxCCCD);
            pnlInfoNV.Controls.Add(tbxSDT);
            pnlInfoNV.Controls.Add(tbxEmail);
            pnlInfoNV.Controls.Add(lblCCCD);
            pnlInfoNV.Controls.Add(lblSDT);
            pnlInfoNV.Controls.Add(lblEmail);
            pnlInfoNV.Controls.Add(tbxDiaChi);
            pnlInfoNV.Controls.Add(tbxGioiTinh);
            pnlInfoNV.Controls.Add(tbxNgaySinh);
            pnlInfoNV.Controls.Add(tbxMaNV);
            pnlInfoNV.Controls.Add(lblDiaChi);
            pnlInfoNV.Controls.Add(lblGioiTinh);
            pnlInfoNV.Controls.Add(label1);
            pnlInfoNV.Controls.Add(lblMaNV);
            pnlInfoNV.Controls.Add(lblTTCN);
            pnlInfoNV.Location = new Point(357, 156);
            pnlInfoNV.Name = "pnlInfoNV";
            pnlInfoNV.Size = new Size(661, 414);
            pnlInfoNV.TabIndex = 2;
            pnlInfoNV.Paint += pnlInfoNV_Paint;
            // 
            // tbxCCCD
            // 
            tbxCCCD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tbxCCCD.BorderStyle = BorderStyle.None;
            tbxCCCD.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxCCCD.Location = new Point(409, 196);
            tbxCCCD.Name = "tbxCCCD";
            tbxCCCD.ReadOnly = true;
            tbxCCCD.Size = new Size(234, 23);
            tbxCCCD.TabIndex = 33;
            // 
            // tbxSDT
            // 
            tbxSDT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tbxSDT.BorderStyle = BorderStyle.None;
            tbxSDT.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxSDT.Location = new Point(409, 123);
            tbxSDT.Name = "tbxSDT";
            tbxSDT.ReadOnly = true;
            tbxSDT.Size = new Size(234, 23);
            tbxSDT.TabIndex = 32;
            // 
            // tbxEmail
            // 
            tbxEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tbxEmail.BorderStyle = BorderStyle.None;
            tbxEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxEmail.Location = new Point(409, 51);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.ReadOnly = true;
            tbxEmail.Size = new Size(234, 23);
            tbxEmail.TabIndex = 31;
            // 
            // lblCCCD
            // 
            lblCCCD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblCCCD.AutoSize = true;
            lblCCCD.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCCCD.Location = new Point(348, 196);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(64, 23);
            lblCCCD.TabIndex = 30;
            lblCCCD.Text = "CCCD: ";
            // 
            // lblSDT
            // 
            lblSDT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSDT.Location = new Point(348, 123);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(52, 23);
            lblSDT.TabIndex = 29;
            lblSDT.Text = "SDT: ";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(348, 51);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 23);
            lblEmail.TabIndex = 28;
            lblEmail.Text = "Email: ";
            // 
            // tbxDiaChi
            // 
            tbxDiaChi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbxDiaChi.BorderStyle = BorderStyle.None;
            tbxDiaChi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxDiaChi.Location = new Point(110, 265);
            tbxDiaChi.Name = "tbxDiaChi";
            tbxDiaChi.ReadOnly = true;
            tbxDiaChi.Size = new Size(533, 23);
            tbxDiaChi.TabIndex = 27;
            // 
            // tbxGioiTinh
            // 
            tbxGioiTinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbxGioiTinh.BorderStyle = BorderStyle.None;
            tbxGioiTinh.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxGioiTinh.Location = new Point(110, 196);
            tbxGioiTinh.Name = "tbxGioiTinh";
            tbxGioiTinh.ReadOnly = true;
            tbxGioiTinh.Size = new Size(232, 23);
            tbxGioiTinh.TabIndex = 26;
            // 
            // tbxNgaySinh
            // 
            tbxNgaySinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbxNgaySinh.BorderStyle = BorderStyle.None;
            tbxNgaySinh.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxNgaySinh.Location = new Point(110, 121);
            tbxNgaySinh.Name = "tbxNgaySinh";
            tbxNgaySinh.ReadOnly = true;
            tbxNgaySinh.Size = new Size(232, 23);
            tbxNgaySinh.TabIndex = 25;
            // 
            // tbxMaNV
            // 
            tbxMaNV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbxMaNV.BorderStyle = BorderStyle.None;
            tbxMaNV.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxMaNV.Location = new Point(110, 51);
            tbxMaNV.Name = "tbxMaNV";
            tbxMaNV.ReadOnly = true;
            tbxMaNV.Size = new Size(232, 23);
            tbxMaNV.TabIndex = 24;
            // 
            // lblDiaChi
            // 
            lblDiaChi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiaChi.Location = new Point(18, 265);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(75, 23);
            lblDiaChi.TabIndex = 23;
            lblDiaChi.Text = "Địa chỉ: ";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGioiTinh.Location = new Point(17, 196);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(90, 23);
            lblGioiTinh.TabIndex = 22;
            lblGioiTinh.Text = "Giới tính: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 123);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 21;
            label1.Text = "Ngày sinh: ";
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaNV.Location = new Point(17, 51);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(74, 23);
            lblMaNV.TabIndex = 20;
            lblMaNV.Text = "Mã NV: ";
            // 
            // lblTTCN
            // 
            lblTTCN.AutoSize = true;
            lblTTCN.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTTCN.Location = new Point(3, 3);
            lblTTCN.Name = "lblTTCN";
            lblTTCN.Size = new Size(154, 23);
            lblTTCN.TabIndex = 19;
            lblTTCN.Text = "Thông tin cá nhân";
            // 
            // ucInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlInfoNV);
            Controls.Add(pnlHotenRole);
            Controls.Add(pnlSalaryRole);
            Name = "ucInfo";
            Size = new Size(1021, 573);
            Load += ucInfo_Load;
            pnlSalaryRole.ResumeLayout(false);
            pnlSalaryRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbDRole).EndInit();
            pnlHotenRole.ResumeLayout(false);
            pnlHotenRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbDetailAvatar).EndInit();
            pnlInfoNV.ResumeLayout(false);
            pnlInfoNV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSalaryRole;
        private PictureBox ptbDRole;
        private Label lblWelcome;
        private Label lblDetailRole;
        private PictureBox ptbSalary;
        private Label lblDetailSalary;
        private Panel pnlHotenRole;
        private Label lblAnhDaiDien;
        private PictureBox ptbDetailAvatar;
        private Label lblHovaTen;
        private TextBox tbxHoTen;
        private Label lblChucVu;
        private TextBox tbxChucVu;
        private Panel pnlInfoNV;
        private Label lblTTCN;
        private Label lblMaNV;
        private Label label1;
        private Label lblGioiTinh;
        private Label lblDiaChi;
        private TextBox tbxMaNV;
        private TextBox tbxNgaySinh;
        private TextBox tbxGioiTinh;
        private TextBox tbxDiaChi;
        private Label lblEmail;
        private Label lblSDT;
        private Label lblCCCD;
        private TextBox tbxEmail;
        private TextBox tbxSDT;
        private TextBox tbxCCCD;
    }
}
