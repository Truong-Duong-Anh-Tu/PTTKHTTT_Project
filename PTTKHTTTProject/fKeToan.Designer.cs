namespace PTTKHTTTProject
{
    partial class fKeToan
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
            tlpMenuKeToan = new TableLayoutPanel();
            btnKTThongBao = new Button();
            btnQLPT = new Button();
            btnTTCN = new Button();
            btnQLPGH = new Button();
            tlpLogoName = new TableLayoutPanel();
            ptbLogoHome = new PictureBox();
            lblNameHome = new Label();
            panel1 = new Panel();
            btnKTSignout = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnSignOut = new Button();
            lblName_Role = new Label();
            ptbAvatar = new PictureBox();
            lblOption = new Label();
            ptbMenu = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pnlChildControl = new Panel();
            tlpMenuKeToan.SuspendLayout();
            tlpLogoName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogoHome).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMenu).BeginInit();
            SuspendLayout();
            // 
            // tlpMenuKeToan
            // 
            tlpMenuKeToan.BackColor = SystemColors.Control;
            tlpMenuKeToan.ColumnCount = 1;
            tlpMenuKeToan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMenuKeToan.Controls.Add(btnKTThongBao, 0, 5);
            tlpMenuKeToan.Controls.Add(btnQLPT, 0, 3);
            tlpMenuKeToan.Controls.Add(btnTTCN, 0, 2);
            tlpMenuKeToan.Controls.Add(btnQLPGH, 0, 4);
            tlpMenuKeToan.Controls.Add(tlpLogoName, 0, 0);
            tlpMenuKeToan.Location = new Point(1, 0);
            tlpMenuKeToan.Margin = new Padding(3, 4, 3, 4);
            tlpMenuKeToan.Name = "tlpMenuKeToan";
            tlpMenuKeToan.RowCount = 6;
            tlpMenuKeToan.RowStyles.Add(new RowStyle(SizeType.Percent, 70.103096F));
            tlpMenuKeToan.RowStyles.Add(new RowStyle(SizeType.Percent, 29.8969078F));
            tlpMenuKeToan.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tlpMenuKeToan.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tlpMenuKeToan.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tlpMenuKeToan.RowStyles.Add(new RowStyle(SizeType.Absolute, 348F));
            tlpMenuKeToan.Size = new Size(155, 625);
            tlpMenuKeToan.TabIndex = 5;
            // 
            // btnKTThongBao
            // 
            btnKTThongBao.FlatStyle = FlatStyle.Flat;
            btnKTThongBao.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKTThongBao.Location = new Point(3, 279);
            btnKTThongBao.Name = "btnKTThongBao";
            btnKTThongBao.Size = new Size(149, 55);
            btnKTThongBao.TabIndex = 4;
            btnKTThongBao.Text = "Thông báo";
            btnKTThongBao.UseVisualStyleBackColor = true;
            btnKTThongBao.Click += tlpMenuKeToan_Click_1;
            // 
            // btnQLPT
            // 
            btnQLPT.FlatStyle = FlatStyle.Flat;
            btnQLPT.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQLPT.Location = new Point(3, 157);
            btnQLPT.Name = "btnQLPT";
            btnQLPT.Size = new Size(149, 55);
            btnQLPT.TabIndex = 2;
            btnQLPT.Text = "Quản lý phiếu thu";
            btnQLPT.UseVisualStyleBackColor = true;
            btnQLPT.Click += tlpMenuKeToan_Click_1;
            // 
            // btnTTCN
            // 
            btnTTCN.FlatStyle = FlatStyle.Flat;
            btnTTCN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTTCN.Location = new Point(3, 96);
            btnTTCN.Name = "btnTTCN";
            btnTTCN.Size = new Size(149, 55);
            btnTTCN.TabIndex = 1;
            btnTTCN.Text = "Thông tin cá nhân";
            btnTTCN.UseVisualStyleBackColor = true;
            btnTTCN.Click += tlpMenuKeToan_Click_1;
            // 
            // btnQLPGH
            // 
            btnQLPGH.FlatStyle = FlatStyle.Flat;
            btnQLPGH.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQLPGH.Location = new Point(3, 218);
            btnQLPGH.Name = "btnQLPGH";
            btnQLPGH.Size = new Size(149, 55);
            btnQLPGH.TabIndex = 2;
            btnQLPGH.Text = "Quản lý phiếu gia hạn";
            btnQLPGH.UseVisualStyleBackColor = true;
            btnQLPGH.Click += tlpMenuKeToan_Click_1;
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
            tlpLogoName.Size = new Size(149, 59);
            tlpLogoName.TabIndex = 3;
            // 
            // ptbLogoHome
            // 
            ptbLogoHome.Anchor = AnchorStyles.None;
            ptbLogoHome.Image = Properties.Resources.logo;
            ptbLogoHome.Location = new Point(11, 4);
            ptbLogoHome.Name = "ptbLogoHome";
            ptbLogoHome.Size = new Size(51, 51);
            ptbLogoHome.SizeMode = PictureBoxSizeMode.Zoom;
            ptbLogoHome.TabIndex = 1;
            ptbLogoHome.TabStop = false;
            // 
            // lblNameHome
            // 
            lblNameHome.Anchor = AnchorStyles.None;
            lblNameHome.AutoSize = true;
            lblNameHome.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameHome.Location = new Point(84, 18);
            lblNameHome.Name = "lblNameHome";
            lblNameHome.Size = new Size(54, 23);
            lblNameHome.TabIndex = 1;
            lblNameHome.Text = "ACCI";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnKTSignout);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnSignOut);
            panel1.Controls.Add(lblName_Role);
            panel1.Controls.Add(ptbAvatar);
            panel1.Controls.Add(lblOption);
            panel1.Controls.Add(ptbMenu);
            panel1.Location = new Point(149, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1033, 51);
            panel1.TabIndex = 6;
            // 
            // btnKTSignout
            // 
            btnKTSignout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnKTSignout.BackColor = Color.DeepSkyBlue;
            btnKTSignout.FlatStyle = FlatStyle.Flat;
            btnKTSignout.ForeColor = SystemColors.Control;
            btnKTSignout.Location = new Point(930, 9);
            btnKTSignout.Name = "btnKTSignout";
            btnKTSignout.Size = new Size(87, 33);
            btnKTSignout.TabIndex = 8;
            btnKTSignout.Text = "Đăng xuất";
            btnKTSignout.UseVisualStyleBackColor = false;
            btnKTSignout.Click += btnKTSignout_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(722, 17);
            label1.Name = "label1";
            label1.Size = new Size(117, 17);
            label1.TabIndex = 7;
            label1.Text = "<Name and Role>";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.avatar;
            pictureBox1.Location = new Point(679, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnSignOut
            // 
            btnSignOut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSignOut.BackColor = Color.DeepSkyBlue;
            btnSignOut.Location = new Point(1730, 9);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(87, 33);
            btnSignOut.TabIndex = 6;
            btnSignOut.Text = "Đăng xuất";
            btnSignOut.UseVisualStyleBackColor = false;
            // 
            // lblName_Role
            // 
            lblName_Role.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblName_Role.AutoSize = true;
            lblName_Role.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName_Role.Location = new Point(1522, 17);
            lblName_Role.Name = "lblName_Role";
            lblName_Role.Size = new Size(117, 17);
            lblName_Role.TabIndex = 6;
            lblName_Role.Text = "<Name and Role>";
            // 
            // ptbAvatar
            // 
            ptbAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptbAvatar.Image = Properties.Resources.avatar;
            ptbAvatar.Location = new Point(1479, 7);
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
            lblOption.Location = new Point(53, 17);
            lblOption.Name = "lblOption";
            lblOption.Size = new Size(135, 20);
            lblOption.TabIndex = 6;
            lblOption.Text = "Thông tin cá nhân";
            // 
            // ptbMenu
            // 
            ptbMenu.BackColor = Color.DeepSkyBlue;
            ptbMenu.Image = Properties.Resources.Menu;
            ptbMenu.Location = new Point(11, 12);
            ptbMenu.Name = "ptbMenu";
            ptbMenu.Size = new Size(30, 29);
            ptbMenu.SizeMode = PictureBoxSizeMode.Zoom;
            ptbMenu.TabIndex = 6;
            ptbMenu.TabStop = false;
            // 
            // pnlChildControl
            // 
            pnlChildControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlChildControl.Location = new Point(160, 52);
            pnlChildControl.Name = "pnlChildControl";
            pnlChildControl.Size = new Size(1021, 573);
            pnlChildControl.TabIndex = 7;
            pnlChildControl.Paint += pnlChildControl_Paint;
            // 
            // fKeToan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 628);
            Controls.Add(pnlChildControl);
            Controls.Add(tlpMenuKeToan);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fKeToan";
            Text = "KẾ TOÁN";
            tlpMenuKeToan.ResumeLayout(false);
            tlpLogoName.ResumeLayout(false);
            tlpLogoName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogoHome).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tlpMenuKeToan;
        private Button btnQLPT;
        private TableLayoutPanel tlpLogoName;
        private PictureBox ptbLogoHome;
        private Label lblNameHome;
        private Button btnTTCN;
        private Button btnQLPGH;
        private Panel panel1;
        private Button btnSignOut;
        private Label lblName_Role;
        private PictureBox ptbAvatar;
        private Label lblOption;
        private PictureBox ptbMenu;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnKTThongBao;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel pnlChildControl;
        private Button btnKTSignout;
    }
}