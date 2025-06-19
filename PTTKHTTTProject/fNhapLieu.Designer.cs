namespace PTTKHTTTProject
{
    partial class fNhapLieu
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
            btnThongBao = new Button();
            btnTTCN = new Button();
            ptbLogoHome = new PictureBox();
            tlpLogoName = new TableLayoutPanel();
            lblNameHome = new Label();
            tlpMenu = new TableLayoutPanel();
            btnQLKQT = new Button();
            panel1 = new Panel();
            btnSignOut = new Button();
            lblName_Role = new Label();
            ptbAvatar = new PictureBox();
            lblOption = new Label();
            ptbMenu = new PictureBox();
            pnlChildForm = new Panel();
            ((System.ComponentModel.ISupportInitialize)ptbLogoHome).BeginInit();
            tlpLogoName.SuspendLayout();
            tlpMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMenu).BeginInit();
            SuspendLayout();
            // 
            // btnThongBao
            // 
            btnThongBao.FlatStyle = FlatStyle.Flat;
            btnThongBao.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThongBao.Location = new Point(3, 217);
            btnThongBao.Name = "btnThongBao";
            btnThongBao.Size = new Size(150, 55);
            btnThongBao.TabIndex = 2;
            btnThongBao.Text = "Thông báo";
            btnThongBao.UseVisualStyleBackColor = true;
            btnThongBao.Click += tlpMenu_Click_1;
            // 
            // btnTTCN
            // 
            btnTTCN.FlatStyle = FlatStyle.Flat;
            btnTTCN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTTCN.Location = new Point(3, 95);
            btnTTCN.Name = "btnTTCN";
            btnTTCN.Size = new Size(150, 55);
            btnTTCN.TabIndex = 1;
            btnTTCN.Text = "Thông tin cá nhân";
            btnTTCN.UseVisualStyleBackColor = true;
            btnTTCN.Click += tlpMenu_Click_1;
            // 
            // ptbLogoHome
            // 
            ptbLogoHome.Anchor = AnchorStyles.None;
            ptbLogoHome.Image = Properties.Resources.logo;
            ptbLogoHome.Location = new Point(12, 4);
            ptbLogoHome.Name = "ptbLogoHome";
            ptbLogoHome.Size = new Size(51, 51);
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
            tlpMenu.BackColor = SystemColors.Control;
            tlpMenu.ColumnCount = 1;
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMenu.Controls.Add(btnQLKQT, 0, 3);
            tlpMenu.Controls.Add(tlpLogoName, 0, 0);
            tlpMenu.Controls.Add(btnTTCN, 0, 2);
            tlpMenu.Controls.Add(btnThongBao, 0, 4);
            tlpMenu.Location = new Point(1, 0);
            tlpMenu.Name = "tlpMenu";
            tlpMenu.RowCount = 6;
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 70.103096F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 29.8969078F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 272F));
            tlpMenu.Size = new Size(156, 548);
            tlpMenu.TabIndex = 4;
            // 
            // btnQLKQT
            // 
            btnQLKQT.FlatStyle = FlatStyle.Flat;
            btnQLKQT.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQLKQT.Location = new Point(3, 156);
            btnQLKQT.Name = "btnQLKQT";
            btnQLKQT.Size = new Size(150, 55);
            btnQLKQT.TabIndex = 2;
            btnQLKQT.Text = "Quản lý kết quả thi";
            btnQLKQT.UseVisualStyleBackColor = true;
            btnQLKQT.Click += tlpMenu_Click_1;
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
            panel1.Size = new Size(910, 51);
            panel1.TabIndex = 5;
            // 
            // btnSignOut
            // 
            btnSignOut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSignOut.BackColor = Color.DeepSkyBlue;
            btnSignOut.Location = new Point(808, 9);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(87, 33);
            btnSignOut.TabIndex = 6;
            btnSignOut.Text = "Đăng xuất";
            btnSignOut.UseVisualStyleBackColor = false;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // lblName_Role
            // 
            lblName_Role.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblName_Role.AutoSize = true;
            lblName_Role.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName_Role.Location = new Point(600, 17);
            lblName_Role.Name = "lblName_Role";
            lblName_Role.Size = new Size(117, 17);
            lblName_Role.TabIndex = 6;
            lblName_Role.Text = "<Name and Role>";
            // 
            // ptbAvatar
            // 
            ptbAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptbAvatar.Image = Properties.Resources.avatar;
            ptbAvatar.Location = new Point(557, 7);
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
            lblOption.Size = new Size(135, 20);
            lblOption.TabIndex = 6;
            lblOption.Text = "Thông tin cá nhân";
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
            pnlChildForm.Location = new Point(160, 52);
            pnlChildForm.Name = "pnlChildForm";
            pnlChildForm.Size = new Size(900, 504);
            pnlChildForm.TabIndex = 6;
            // 
            // fNhapLieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 554);
            Controls.Add(pnlChildForm);
            Controls.Add(tlpMenu);
            Controls.Add(panel1);
            Name = "fNhapLieu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NHẬP LIỆU";
            Load += fHome_Load;
            ((System.ComponentModel.ISupportInitialize)ptbLogoHome).EndInit();
            tlpLogoName.ResumeLayout(false);
            tlpLogoName.PerformLayout();
            tlpMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox ptbLogoHome;
        private Button btnTTCN;
        private Button btnThongBao;
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
        private Button btnQLKQT;
    }
}