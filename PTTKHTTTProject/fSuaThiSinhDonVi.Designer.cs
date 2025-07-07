namespace PTTKHTTTProject
{
    partial class fSuaThiSinhDonVi
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
            panel1 = new Panel();
            Xacnhan_TSDV = new Button();
            XoaThiSinhDV = new Button();
            GioiTinh = new ComboBox();
            DOB = new DateTimePicker();
            CCCD = new TextBox();
            SDT = new TextBox();
            Email = new TextBox();
            HoTen = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            SBD = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Xacnhan_TSDV);
            panel1.Controls.Add(XoaThiSinhDV);
            panel1.Controls.Add(GioiTinh);
            panel1.Controls.Add(DOB);
            panel1.Controls.Add(CCCD);
            panel1.Controls.Add(SDT);
            panel1.Controls.Add(Email);
            panel1.Controls.Add(HoTen);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(SBD);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 321);
            panel1.TabIndex = 0;
            // 
            // Xacnhan_TSDV
            // 
            Xacnhan_TSDV.Location = new Point(692, 262);
            Xacnhan_TSDV.Name = "Xacnhan_TSDV";
            Xacnhan_TSDV.Size = new Size(128, 34);
            Xacnhan_TSDV.TabIndex = 16;
            Xacnhan_TSDV.Text = "Lưu thay đổi";
            Xacnhan_TSDV.UseVisualStyleBackColor = true;
            Xacnhan_TSDV.Click += XacnhanTSDV_Click;
            // 
            // XoaThiSinhDV
            // 
            XoaThiSinhDV.Location = new Point(536, 262);
            XoaThiSinhDV.Name = "XoaThiSinhDV";
            XoaThiSinhDV.Size = new Size(127, 34);
            XoaThiSinhDV.TabIndex = 15;
            XoaThiSinhDV.Text = "Xóa thí sinh";
            XoaThiSinhDV.UseVisualStyleBackColor = true;
            XoaThiSinhDV.Click += XoaThiSinhDV_Click;
            // 
            // GioiTinh
            // 
            GioiTinh.FormattingEnabled = true;
            GioiTinh.Location = new Point(158, 174);
            GioiTinh.Name = "GioiTinh";
            GioiTinh.Size = new Size(182, 33);
            GioiTinh.TabIndex = 14;
            // 
            // DOB
            // 
            DOB.CustomFormat = "dd/MM/yyyy";
            DOB.Format = DateTimePickerFormat.Custom;
            DOB.Location = new Point(551, 124);
            DOB.Name = "DOB";
            DOB.Size = new Size(232, 31);
            DOB.TabIndex = 13;
            // 
            // CCCD
            // 
            CCCD.Location = new Point(512, 172);
            CCCD.Name = "CCCD";
            CCCD.Size = new Size(271, 31);
            CCCD.TabIndex = 12;
            // 
            // SDT
            // 
            SDT.Location = new Point(580, 71);
            SDT.Name = "SDT";
            SDT.Size = new Size(203, 31);
            SDT.TabIndex = 11;
            // 
            // Email
            // 
            Email.Location = new Point(117, 229);
            Email.Name = "Email";
            Email.Size = new Size(223, 31);
            Email.TabIndex = 10;
            // 
            // HoTen
            // 
            HoTen.Location = new Point(151, 124);
            HoTen.Name = "HoTen";
            HoTen.Size = new Size(189, 31);
            HoTen.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(442, 175);
            label9.Name = "label9";
            label9.Size = new Size(64, 28);
            label9.TabIndex = 8;
            label9.Text = "CCCD:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(442, 124);
            label8.Name = "label8";
            label8.Size = new Size(103, 28);
            label8.TabIndex = 7;
            label8.Text = "Ngày sinh:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(442, 71);
            label7.Name = "label7";
            label7.Size = new Size(132, 28);
            label7.TabIndex = 6;
            label7.Text = "Số điện thoại:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(45, 226);
            label6.Name = "label6";
            label6.Size = new Size(63, 28);
            label6.TabIndex = 5;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(45, 175);
            label5.Name = "label5";
            label5.Size = new Size(91, 28);
            label5.TabIndex = 4;
            label5.Text = "Giới tính:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(45, 124);
            label4.Name = "label4";
            label4.Size = new Size(100, 28);
            label4.TabIndex = 3;
            label4.Text = "Họ và tên:";
            // 
            // SBD
            // 
            SBD.AutoSize = true;
            SBD.Location = new Point(178, 74);
            SBD.Name = "SBD";
            SBD.Size = new Size(59, 25);
            SBD.TabIndex = 2;
            SBD.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(45, 71);
            label2.Name = "label2";
            label2.Size = new Size(127, 28);
            label2.TabIndex = 1;
            label2.Text = "Số báo danh:";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(850, 32);
            label1.TabIndex = 0;
            label1.Text = "Chỉnh sửa thông tin thí sinh";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // fSuaThiSinhDonVi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 321);
            Controls.Add(panel1);
            Name = "fSuaThiSinhDonVi";
            Text = "fSuaThiSinhDonVi";
            Load += fSuaThiSinhDonVi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label SBD;
        private ComboBox GioiTinh;
        private DateTimePicker DOB;
        private TextBox CCCD;
        private TextBox SDT;
        private TextBox Email;
        private TextBox HoTen;
        private Button Xacnhan_TSDV;
        private Button XoaThiSinhDV;
    }
}