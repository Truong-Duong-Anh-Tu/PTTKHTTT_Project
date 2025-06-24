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
            textBoxSearchPGH = new TextBox();
            tblPGH = new DataGridView();
            btnSearchPGH = new Button();
            tlpMenuKeToan = new TableLayoutPanel();
            btnThongBao = new Button();
            btnQLPT = new Button();
            btnTTCN = new Button();
            btnQLPGH = new Button();
            tlpLogoName = new TableLayoutPanel();
            ptbLogoHome = new PictureBox();
            lblNameHome = new Label();
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnSignOut = new Button();
            lblName_Role = new Label();
            ptbAvatar = new PictureBox();
            lblOption = new Label();
            ptbMenu = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)tblPGH).BeginInit();
            tlpMenuKeToan.SuspendLayout();
            tlpLogoName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogoHome).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMenu).BeginInit();
            SuspendLayout();
            // 
            // textBoxSearchPGH
            // 
            textBoxSearchPGH.Location = new Point(147, 71);
            textBoxSearchPGH.Name = "textBoxSearchPGH";
            textBoxSearchPGH.PlaceholderText = "Nhập Tên hoặc Mã thí sinh...";
            textBoxSearchPGH.Size = new Size(591, 23);
            textBoxSearchPGH.TabIndex = 3;
            // 
            // tblPGH
            // 
            tblPGH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblPGH.Location = new Point(147, 100);
            tblPGH.Name = "tblPGH";
            tblPGH.Size = new Size(691, 360);
            tblPGH.TabIndex = 2;
            // 
            // btnSearchPGH
            // 
            btnSearchPGH.Location = new Point(763, 70);
            btnSearchPGH.Name = "btnSearchPGH";
            btnSearchPGH.Size = new Size(75, 23);
            btnSearchPGH.TabIndex = 0;
            btnSearchPGH.Text = "Tìm";
            btnSearchPGH.UseVisualStyleBackColor = true;
            btnSearchPGH.Click += button1_Click;
            // 
            // tlpMenuKeToan
            // 
            tlpMenuKeToan.BackColor = SystemColors.Control;
            tlpMenuKeToan.ColumnCount = 1;
            tlpMenuKeToan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMenuKeToan.Controls.Add(btnThongBao, 0, 5);
            tlpMenuKeToan.Controls.Add(btnQLPT, 0, 3);
            tlpMenuKeToan.Controls.Add(btnTTCN, 0, 2);
            tlpMenuKeToan.Controls.Add(btnQLPGH, 0, 4);
            tlpMenuKeToan.Controls.Add(tlpLogoName, 0, 0);
            tlpMenuKeToan.Location = new Point(0, 0);
            tlpMenuKeToan.Name = "tlpMenuKeToan";
            tlpMenuKeToan.RowCount = 6;
            tlpMenuKeToan.RowStyles.Add(new RowStyle(SizeType.Percent, 70.103096F));
            tlpMenuKeToan.RowStyles.Add(new RowStyle(SizeType.Percent, 29.8969078F));
            tlpMenuKeToan.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tlpMenuKeToan.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tlpMenuKeToan.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tlpMenuKeToan.RowStyles.Add(new RowStyle(SizeType.Absolute, 261F));
            tlpMenuKeToan.Size = new Size(136, 469);
            tlpMenuKeToan.TabIndex = 5;
            // 
            // btnThongBao
            // 
            btnThongBao.FlatStyle = FlatStyle.Flat;
            btnThongBao.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThongBao.Location = new Point(3, 209);
            btnThongBao.Margin = new Padding(3, 2, 3, 2);
            btnThongBao.Name = "btnThongBao";
            btnThongBao.Size = new Size(130, 41);
            btnThongBao.TabIndex = 4;
            btnThongBao.Text = "Thông báo";
            btnThongBao.UseVisualStyleBackColor = true;
            // 
            // btnQLPT
            // 
            btnQLPT.FlatStyle = FlatStyle.Flat;
            btnQLPT.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQLPT.Location = new Point(3, 117);
            btnQLPT.Margin = new Padding(3, 2, 3, 2);
            btnQLPT.Name = "btnQLPT";
            btnQLPT.Size = new Size(130, 41);
            btnQLPT.TabIndex = 2;
            btnQLPT.Text = "Quản lý phiếu thu";
            btnQLPT.UseVisualStyleBackColor = true;
            // 
            // btnTTCN
            // 
            btnTTCN.FlatStyle = FlatStyle.Flat;
            btnTTCN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTTCN.Location = new Point(3, 71);
            btnTTCN.Margin = new Padding(3, 2, 3, 2);
            btnTTCN.Name = "btnTTCN";
            btnTTCN.Size = new Size(130, 41);
            btnTTCN.TabIndex = 1;
            btnTTCN.Text = "Thông tin cá nhân";
            btnTTCN.UseVisualStyleBackColor = true;
            // 
            // btnQLPGH
            // 
            btnQLPGH.FlatStyle = FlatStyle.Flat;
            btnQLPGH.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQLPGH.Location = new Point(3, 163);
            btnQLPGH.Margin = new Padding(3, 2, 3, 2);
            btnQLPGH.Name = "btnQLPGH";
            btnQLPGH.Size = new Size(130, 41);
            btnQLPGH.TabIndex = 2;
            btnQLPGH.Text = "Quản lý phiếu gia hạn";
            btnQLPGH.UseVisualStyleBackColor = true;
            // 
            // tlpLogoName
            // 
            tlpLogoName.ColumnCount = 2;
            tlpLogoName.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLogoName.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLogoName.Controls.Add(ptbLogoHome, 0, 0);
            tlpLogoName.Controls.Add(lblNameHome, 1, 0);
            tlpLogoName.Location = new Point(3, 2);
            tlpLogoName.Margin = new Padding(3, 2, 3, 2);
            tlpLogoName.Name = "tlpLogoName";
            tlpLogoName.RowCount = 1;
            tlpLogoName.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpLogoName.Size = new Size(130, 44);
            tlpLogoName.TabIndex = 3;
            // 
            // ptbLogoHome
            // 
            ptbLogoHome.Anchor = AnchorStyles.None;
            ptbLogoHome.Image = Properties.Resources.logo;
            ptbLogoHome.Location = new Point(10, 3);
            ptbLogoHome.Margin = new Padding(3, 2, 3, 2);
            ptbLogoHome.Name = "ptbLogoHome";
            ptbLogoHome.Size = new Size(45, 38);
            ptbLogoHome.SizeMode = PictureBoxSizeMode.Zoom;
            ptbLogoHome.TabIndex = 1;
            ptbLogoHome.TabStop = false;
            // 
            // lblNameHome
            // 
            lblNameHome.Anchor = AnchorStyles.None;
            lblNameHome.AutoSize = true;
            lblNameHome.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameHome.Location = new Point(74, 12);
            lblNameHome.Name = "lblNameHome";
            lblNameHome.Size = new Size(46, 19);
            lblNameHome.TabIndex = 1;
            lblNameHome.Text = "ACCI";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnSignOut);
            panel1.Controls.Add(lblName_Role);
            panel1.Controls.Add(ptbAvatar);
            panel1.Controls.Add(lblOption);
            panel1.Controls.Add(ptbMenu);
            panel1.Location = new Point(130, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 39);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.DeepSkyBlue;
            button1.Location = new Point(814, 7);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(76, 25);
            button1.TabIndex = 7;
            button1.Text = "Đăng xuất";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(632, 13);
            label1.Name = "label1";
            label1.Size = new Size(99, 14);
            label1.TabIndex = 7;
            label1.Text = "<Name and Role>";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.avatar;
            pictureBox1.Location = new Point(594, 5);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnSignOut
            // 
            btnSignOut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSignOut.BackColor = Color.DeepSkyBlue;
            btnSignOut.Location = new Point(1514, 7);
            btnSignOut.Margin = new Padding(3, 2, 3, 2);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(76, 25);
            btnSignOut.TabIndex = 6;
            btnSignOut.Text = "Đăng xuất";
            btnSignOut.UseVisualStyleBackColor = false;
            // 
            // lblName_Role
            // 
            lblName_Role.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblName_Role.AutoSize = true;
            lblName_Role.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName_Role.Location = new Point(1332, 13);
            lblName_Role.Name = "lblName_Role";
            lblName_Role.Size = new Size(99, 14);
            lblName_Role.TabIndex = 6;
            lblName_Role.Text = "<Name and Role>";
            // 
            // ptbAvatar
            // 
            ptbAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptbAvatar.Image = Properties.Resources.avatar;
            ptbAvatar.Location = new Point(1294, 5);
            ptbAvatar.Margin = new Padding(3, 2, 3, 2);
            ptbAvatar.Name = "ptbAvatar";
            ptbAvatar.Size = new Size(32, 28);
            ptbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            ptbAvatar.TabIndex = 6;
            ptbAvatar.TabStop = false;
            // 
            // lblOption
            // 
            lblOption.AutoSize = true;
            lblOption.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOption.Location = new Point(46, 13);
            lblOption.Name = "lblOption";
            lblOption.Size = new Size(105, 15);
            lblOption.TabIndex = 6;
            lblOption.Text = "Thông tin cá nhân";
            // 
            // ptbMenu
            // 
            ptbMenu.BackColor = Color.DeepSkyBlue;
            ptbMenu.Image = Properties.Resources.Menu;
            ptbMenu.Location = new Point(10, 9);
            ptbMenu.Margin = new Padding(3, 2, 3, 2);
            ptbMenu.Name = "ptbMenu";
            ptbMenu.Size = new Size(26, 22);
            ptbMenu.SizeMode = PictureBoxSizeMode.Zoom;
            ptbMenu.TabIndex = 6;
            ptbMenu.TabStop = false;
            // 
            // fKeToan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 471);
            Controls.Add(tlpMenuKeToan);
            Controls.Add(panel1);
            Controls.Add(btnSearchPGH);
            Controls.Add(tblPGH);
            Controls.Add(textBoxSearchPGH);
            Name = "fKeToan";
            Text = "fKeToan";
            ((System.ComponentModel.ISupportInitialize)tblPGH).EndInit();
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
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSearchPGH;
        private DataGridView tblPGH;
        private Button btnSearchPGH;
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
        private Button button1;
        private Button btnThongBao;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}