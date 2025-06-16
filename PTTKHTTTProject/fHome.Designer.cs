namespace PTTKHTTTProject
{
    partial class fHome
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
            btnQLPDK = new Button();
            btnTTCN = new Button();
            ptbLogoHome = new PictureBox();
            tlpLogoName = new TableLayoutPanel();
            lblNameHome = new Label();
            tlpMenu = new TableLayoutPanel();
            panel1 = new Panel();
            btnSignOut = new Button();
            lblName_Role = new Label();
            ptbAvatar = new PictureBox();
            lblOption = new Label();
            ptbMenu = new PictureBox();
            pnlChildForm = new Panel();
            panel3 = new Panel();
            tbxCCCD = new TextBox();
            tbxSDT = new TextBox();
            tbxEmail = new TextBox();
            lblCCCD = new Label();
            lblSDT = new Label();
            lblEmail = new Label();
            lblDiaChi = new Label();
            lblGioiTinh = new Label();
            label1 = new Label();
            lblMaNV = new Label();
            lblTTCN = new Label();
            tbxMaNV = new TextBox();
            tbxNgaySinh = new TextBox();
            tbxGioiTInh = new TextBox();
            tbxDiaChi = new TextBox();
            panel2 = new Panel();
            tbxChucVu = new TextBox();
            tbxHoTen = new TextBox();
            lblChucVu = new Label();
            lblHovaTen = new Label();
            lblAnhDaiDien = new Label();
            ptbDetailAvatar = new PictureBox();
            pnlSalaryRole = new Panel();
            ptbSalary = new PictureBox();
            ptbDRole = new PictureBox();
            lblDetailSalary = new Label();
            lblDetailRole = new Label();
            ((System.ComponentModel.ISupportInitialize)ptbLogoHome).BeginInit();
            tlpLogoName.SuspendLayout();
            tlpMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMenu).BeginInit();
            pnlChildForm.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbDetailAvatar).BeginInit();
            pnlSalaryRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbDRole).BeginInit();
            SuspendLayout();
            // 
            // btnQLPDK
            // 
            btnQLPDK.Location = new Point(3, 164);
            btnQLPDK.Name = "btnQLPDK";
            btnQLPDK.Size = new Size(150, 53);
            btnQLPDK.TabIndex = 2;
            btnQLPDK.Text = "Quan ly phieu dang ky";
            btnQLPDK.UseVisualStyleBackColor = true;
            btnQLPDK.Click += tlpMenu_Click_1;
            // 
            // btnTTCN
            // 
            btnTTCN.Location = new Point(3, 100);
            btnTTCN.Name = "btnTTCN";
            btnTTCN.Size = new Size(150, 53);
            btnTTCN.TabIndex = 1;
            btnTTCN.Text = "Thong tin ca nhan";
            btnTTCN.UseVisualStyleBackColor = true;
            btnTTCN.Click += tlpMenu_Click_1;
            // 
            // ptbLogoHome
            // 
            ptbLogoHome.Anchor = AnchorStyles.None;
            ptbLogoHome.Image = Properties.Resources.logo;
            ptbLogoHome.Location = new Point(14, 6);
            ptbLogoHome.Name = "ptbLogoHome";
            ptbLogoHome.Size = new Size(47, 47);
            ptbLogoHome.SizeMode = PictureBoxSizeMode.Zoom;
            ptbLogoHome.TabIndex = 1;
            ptbLogoHome.TabStop = false;
            // 
            // tlpLogoName
            // 
            tlpLogoName.ColumnCount = 2;
            tlpLogoName.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLogoName.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLogoName.Controls.Add(ptbLogoHome, 0, 0);
            tlpLogoName.Controls.Add(lblNameHome, 1, 0);
            tlpLogoName.Location = new Point(3, 3);
            tlpLogoName.Name = "tlpLogoName";
            tlpLogoName.RowCount = 1;
            tlpLogoName.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpLogoName.Size = new Size(150, 59);
            tlpLogoName.TabIndex = 3;
            // 
            // lblNameHome
            // 
            lblNameHome.Anchor = AnchorStyles.None;
            lblNameHome.AutoSize = true;
            lblNameHome.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameHome.Location = new Point(85, 18);
            lblNameHome.Name = "lblNameHome";
            lblNameHome.Size = new Size(54, 23);
            lblNameHome.TabIndex = 1;
            lblNameHome.Text = "ACCI";
            lblNameHome.Click += lblNameHome_Click;
            // 
            // tlpMenu
            // 
            tlpMenu.ColumnCount = 1;
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMenu.Controls.Add(tlpLogoName, 0, 0);
            tlpMenu.Controls.Add(btnQLPDK, 0, 3);
            tlpMenu.Controls.Add(btnTTCN, 0, 2);
            tlpMenu.Location = new Point(1, 0);
            tlpMenu.Name = "tlpMenu";
            tlpMenu.RowCount = 6;
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 70.103096F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 29.8969078F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 168F));
            tlpMenu.Size = new Size(156, 451);
            tlpMenu.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnSignOut);
            panel1.Controls.Add(lblName_Role);
            panel1.Controls.Add(ptbAvatar);
            panel1.Controls.Add(lblOption);
            panel1.Controls.Add(ptbMenu);
            panel1.Location = new Point(149, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 51);
            panel1.TabIndex = 5;
            // 
            // btnSignOut
            // 
            btnSignOut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSignOut.BackColor = Color.DeepSkyBlue;
            btnSignOut.Location = new Point(548, 11);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(87, 33);
            btnSignOut.TabIndex = 6;
            btnSignOut.Text = "Dang xuat";
            btnSignOut.UseVisualStyleBackColor = false;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // lblName_Role
            // 
            lblName_Role.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblName_Role.AutoSize = true;
            lblName_Role.Location = new Point(402, 17);
            lblName_Role.Name = "lblName_Role";
            lblName_Role.Size = new Size(132, 20);
            lblName_Role.TabIndex = 6;
            lblName_Role.Text = "<Name and Role>";
            // 
            // ptbAvatar
            // 
            ptbAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptbAvatar.Image = Properties.Resources.avatar;
            ptbAvatar.Location = new Point(359, 7);
            ptbAvatar.Name = "ptbAvatar";
            ptbAvatar.Size = new Size(37, 37);
            ptbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            ptbAvatar.TabIndex = 6;
            ptbAvatar.TabStop = false;
            // 
            // lblOption
            // 
            lblOption.AutoSize = true;
            lblOption.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOption.Location = new Point(52, 17);
            lblOption.Name = "lblOption";
            lblOption.Size = new Size(131, 20);
            lblOption.TabIndex = 6;
            lblOption.Text = "<Ten chuc nang>";
            // 
            // ptbMenu
            // 
            ptbMenu.BackColor = Color.DeepSkyBlue;
            ptbMenu.Image = Properties.Resources.Menu;
            ptbMenu.Location = new Point(12, 12);
            ptbMenu.Name = "ptbMenu";
            ptbMenu.Size = new Size(30, 30);
            ptbMenu.SizeMode = PictureBoxSizeMode.Zoom;
            ptbMenu.TabIndex = 6;
            ptbMenu.TabStop = false;
            // 
            // pnlChildForm
            // 
            pnlChildForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlChildForm.Controls.Add(panel3);
            pnlChildForm.Controls.Add(panel2);
            pnlChildForm.Controls.Add(pnlSalaryRole);
            pnlChildForm.Location = new Point(160, 52);
            pnlChildForm.Name = "pnlChildForm";
            pnlChildForm.Size = new Size(640, 400);
            pnlChildForm.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(tbxCCCD);
            panel3.Controls.Add(tbxSDT);
            panel3.Controls.Add(tbxEmail);
            panel3.Controls.Add(lblCCCD);
            panel3.Controls.Add(lblSDT);
            panel3.Controls.Add(lblEmail);
            panel3.Controls.Add(lblDiaChi);
            panel3.Controls.Add(lblGioiTinh);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(lblMaNV);
            panel3.Controls.Add(lblTTCN);
            panel3.Controls.Add(tbxMaNV);
            panel3.Controls.Add(tbxNgaySinh);
            panel3.Controls.Add(tbxGioiTInh);
            panel3.Controls.Add(tbxDiaChi);
            panel3.Location = new Point(282, 116);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 276);
            panel3.TabIndex = 2;
            // 
            // tbxCCCD
            // 
            tbxCCCD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tbxCCCD.BorderStyle = BorderStyle.None;
            tbxCCCD.Location = new Point(240, 118);
            tbxCCCD.Name = "tbxCCCD";
            tbxCCCD.Size = new Size(102, 20);
            tbxCCCD.TabIndex = 25;
            // 
            // tbxSDT
            // 
            tbxSDT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tbxSDT.BorderStyle = BorderStyle.None;
            tbxSDT.Location = new Point(239, 76);
            tbxSDT.Name = "tbxSDT";
            tbxSDT.Size = new Size(103, 20);
            tbxSDT.TabIndex = 24;
            // 
            // tbxEmail
            // 
            tbxEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tbxEmail.BorderStyle = BorderStyle.None;
            tbxEmail.Location = new Point(239, 39);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(103, 20);
            tbxEmail.TabIndex = 23;
            // 
            // lblCCCD
            // 
            lblCCCD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblCCCD.AutoSize = true;
            lblCCCD.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCCCD.Location = new Point(177, 118);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(55, 20);
            lblCCCD.TabIndex = 18;
            lblCCCD.Text = "CCCD: ";
            // 
            // lblSDT
            // 
            lblSDT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSDT.Location = new Point(177, 76);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(42, 20);
            lblSDT.TabIndex = 17;
            lblSDT.Text = "SDT: ";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(177, 39);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 20);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "Email: ";
            // 
            // lblDiaChi
            // 
            lblDiaChi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiaChi.Location = new Point(18, 160);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(64, 20);
            lblDiaChi.TabIndex = 15;
            lblDiaChi.Text = "Dia chi: ";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGioiTinh.Location = new Point(18, 118);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(75, 20);
            lblGioiTinh.TabIndex = 14;
            lblGioiTinh.Text = "Gioi tinh: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 76);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 13;
            label1.Text = "Ngay sinh: ";
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaNV.Location = new Point(18, 39);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(64, 20);
            lblMaNV.TabIndex = 12;
            lblMaNV.Text = "Ma NV: ";
            // 
            // lblTTCN
            // 
            lblTTCN.AutoSize = true;
            lblTTCN.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTTCN.Location = new Point(4, 3);
            lblTTCN.Name = "lblTTCN";
            lblTTCN.Size = new Size(133, 20);
            lblTTCN.TabIndex = 11;
            lblTTCN.Text = "Thong tin ca nhan";
            // 
            // tbxMaNV
            // 
            tbxMaNV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbxMaNV.BorderStyle = BorderStyle.None;
            tbxMaNV.Location = new Point(106, 39);
            tbxMaNV.Name = "tbxMaNV";
            tbxMaNV.Size = new Size(152, 20);
            tbxMaNV.TabIndex = 20;
            // 
            // tbxNgaySinh
            // 
            tbxNgaySinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbxNgaySinh.BorderStyle = BorderStyle.None;
            tbxNgaySinh.Location = new Point(106, 76);
            tbxNgaySinh.Name = "tbxNgaySinh";
            tbxNgaySinh.Size = new Size(152, 20);
            tbxNgaySinh.TabIndex = 19;
            // 
            // tbxGioiTInh
            // 
            tbxGioiTInh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbxGioiTInh.BorderStyle = BorderStyle.None;
            tbxGioiTInh.Location = new Point(106, 118);
            tbxGioiTInh.Name = "tbxGioiTInh";
            tbxGioiTInh.Size = new Size(152, 20);
            tbxGioiTInh.TabIndex = 21;
            // 
            // tbxDiaChi
            // 
            tbxDiaChi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbxDiaChi.BorderStyle = BorderStyle.None;
            tbxDiaChi.Location = new Point(106, 160);
            tbxDiaChi.Name = "tbxDiaChi";
            tbxDiaChi.Size = new Size(152, 20);
            tbxDiaChi.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(tbxChucVu);
            panel2.Controls.Add(tbxHoTen);
            panel2.Controls.Add(lblChucVu);
            panel2.Controls.Add(lblHovaTen);
            panel2.Controls.Add(lblAnhDaiDien);
            panel2.Controls.Add(ptbDetailAvatar);
            panel2.Location = new Point(17, 116);
            panel2.Name = "panel2";
            panel2.Size = new Size(259, 276);
            panel2.TabIndex = 1;
            // 
            // tbxChucVu
            // 
            tbxChucVu.Anchor = AnchorStyles.None;
            tbxChucVu.BorderStyle = BorderStyle.None;
            tbxChucVu.Location = new Point(25, 244);
            tbxChucVu.Name = "tbxChucVu";
            tbxChucVu.Size = new Size(213, 20);
            tbxChucVu.TabIndex = 12;
            // 
            // tbxHoTen
            // 
            tbxHoTen.Anchor = AnchorStyles.None;
            tbxHoTen.BorderStyle = BorderStyle.None;
            tbxHoTen.Location = new Point(25, 198);
            tbxHoTen.Name = "tbxHoTen";
            tbxHoTen.Size = new Size(213, 20);
            tbxHoTen.TabIndex = 11;
            // 
            // lblChucVu
            // 
            lblChucVu.Anchor = AnchorStyles.None;
            lblChucVu.AutoSize = true;
            lblChucVu.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChucVu.Location = new Point(99, 221);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(64, 20);
            lblChucVu.TabIndex = 10;
            lblChucVu.Text = "Chuc vu";
            // 
            // lblHovaTen
            // 
            lblHovaTen.Anchor = AnchorStyles.None;
            lblHovaTen.AutoSize = true;
            lblHovaTen.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHovaTen.Location = new Point(91, 176);
            lblHovaTen.Name = "lblHovaTen";
            lblHovaTen.Size = new Size(75, 20);
            lblHovaTen.TabIndex = 9;
            lblHovaTen.Text = "Ho va ten";
            // 
            // lblAnhDaiDien
            // 
            lblAnhDaiDien.AutoSize = true;
            lblAnhDaiDien.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnhDaiDien.Location = new Point(3, 3);
            lblAnhDaiDien.Name = "lblAnhDaiDien";
            lblAnhDaiDien.Size = new Size(96, 20);
            lblAnhDaiDien.TabIndex = 8;
            lblAnhDaiDien.Text = "Anh dai dien";
            // 
            // ptbDetailAvatar
            // 
            ptbDetailAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ptbDetailAvatar.Image = Properties.Resources.avatar;
            ptbDetailAvatar.Location = new Point(66, 39);
            ptbDetailAvatar.Name = "ptbDetailAvatar";
            ptbDetailAvatar.Size = new Size(128, 137);
            ptbDetailAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            ptbDetailAvatar.TabIndex = 7;
            ptbDetailAvatar.TabStop = false;
            // 
            // pnlSalaryRole
            // 
            pnlSalaryRole.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSalaryRole.BorderStyle = BorderStyle.Fixed3D;
            pnlSalaryRole.Controls.Add(ptbSalary);
            pnlSalaryRole.Controls.Add(ptbDRole);
            pnlSalaryRole.Controls.Add(lblDetailSalary);
            pnlSalaryRole.Controls.Add(lblDetailRole);
            pnlSalaryRole.Location = new Point(17, 14);
            pnlSalaryRole.Name = "pnlSalaryRole";
            pnlSalaryRole.Size = new Size(609, 96);
            pnlSalaryRole.TabIndex = 0;
            // 
            // ptbSalary
            // 
            ptbSalary.Anchor = AnchorStyles.None;
            ptbSalary.Image = Properties.Resources.Rupee;
            ptbSalary.Location = new Point(415, 27);
            ptbSalary.Name = "ptbSalary";
            ptbSalary.Size = new Size(42, 40);
            ptbSalary.SizeMode = PictureBoxSizeMode.Zoom;
            ptbSalary.TabIndex = 2;
            ptbSalary.TabStop = false;
            // 
            // ptbDRole
            // 
            ptbDRole.Anchor = AnchorStyles.None;
            ptbDRole.Image = Properties.Resources.UserIcon;
            ptbDRole.Location = new Point(34, 27);
            ptbDRole.Name = "ptbDRole";
            ptbDRole.Size = new Size(42, 40);
            ptbDRole.SizeMode = PictureBoxSizeMode.Zoom;
            ptbDRole.TabIndex = 1;
            ptbDRole.TabStop = false;
            // 
            // lblDetailSalary
            // 
            lblDetailSalary.Anchor = AnchorStyles.None;
            lblDetailSalary.AutoSize = true;
            lblDetailSalary.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetailSalary.Location = new Point(463, 27);
            lblDetailSalary.Name = "lblDetailSalary";
            lblDetailSalary.Size = new Size(87, 25);
            lblDetailSalary.TabIndex = 1;
            lblDetailSalary.Text = "<Salary>";
            // 
            // lblDetailRole
            // 
            lblDetailRole.Anchor = AnchorStyles.None;
            lblDetailRole.AutoSize = true;
            lblDetailRole.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetailRole.Location = new Point(82, 27);
            lblDetailRole.Name = "lblDetailRole";
            lblDetailRole.Size = new Size(75, 25);
            lblDetailRole.TabIndex = 0;
            lblDetailRole.Text = "<Role>";
            lblDetailRole.Click += lblDetailRole_Click;
            // 
            // fHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlChildForm);
            Controls.Add(tlpMenu);
            Controls.Add(panel1);
            Name = "fHome";
            Text = "fHome";
            WindowState = FormWindowState.Maximized;
            Load += fHome_Load;
            ((System.ComponentModel.ISupportInitialize)ptbLogoHome).EndInit();
            tlpLogoName.ResumeLayout(false);
            tlpLogoName.PerformLayout();
            tlpMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbMenu).EndInit();
            pnlChildForm.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbDetailAvatar).EndInit();
            pnlSalaryRole.ResumeLayout(false);
            pnlSalaryRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbDRole).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox ptbLogoHome;
        private Button btnTTCN;
        private Button btnQLPDK;
        private TableLayoutPanel tlpLogoName;
        private Label lblNameHome;
        private TableLayoutPanel tlpMenu;
        private Panel panel1;
        private PictureBox ptbMenu;
        private Label lblOption;
        private PictureBox ptbAvatar;
        private Label lblName_Role;
        private Button btnSignOut;
        private Panel pnlChildForm;
        private Panel pnlSalaryRole;
        private Label lblDetailSalary;
        private Label lblDetailRole;
        private PictureBox ptbDRole;
        private PictureBox ptbSalary;
        private Panel panel2;
        private PictureBox ptbDetailAvatar;
        private Label lblAnhDaiDien;
        private Panel panel3;
        private Label lblTTCN;
        private Label lblChucVu;
        private Label lblHovaTen;
        private Label lblMaNV;
        private Label lblCCCD;
        private Label lblSDT;
        private Label lblEmail;
        private Label lblDiaChi;
        private Label lblGioiTinh;
        private Label label1;
        private TextBox tbxChucVu;
        private TextBox tbxHoTen;
        private TextBox tbxCCCD;
        private TextBox tbxSDT;
        private TextBox tbxEmail;
        private TextBox tbxDiaChi;
        private TextBox tbxGioiTInh;
        private TextBox tbxMaNV;
        private TextBox tbxNgaySinh;
    }
}