namespace PTTKHTTTProject
{
    partial class adminSidebar
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
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            btn_QuanLyLichNhanVien = new Button();
            btnTongQuan = new Button();
            btnThongbao = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logonew;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 87.8787842F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.121212F));
            tableLayoutPanel1.Size = new Size(194, 97);
            tableLayoutPanel1.TabIndex = 2;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(119, 36);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 2;
            label1.Text = "ACCI";
            label1.Click += label1_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(button7, 0, 7);
            tableLayoutPanel2.Controls.Add(button6, 0, 6);
            tableLayoutPanel2.Controls.Add(button5, 0, 5);
            tableLayoutPanel2.Controls.Add(button4, 0, 4);
            tableLayoutPanel2.Controls.Add(button3, 0, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(btn_QuanLyLichNhanVien, 0, 2);
            tableLayoutPanel2.Controls.Add(btnTongQuan, 0, 1);
            tableLayoutPanel2.Controls.Add(btnThongbao, 0, 8);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(3, 3, 0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 9;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 103F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.Size = new Size(200, 508);
            tableLayoutPanel2.TabIndex = 3;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Fill;
            button7.ForeColor = SystemColors.HotTrack;
            button7.Location = new Point(0, 413);
            button7.Margin = new Padding(0, 3, 3, 3);
            button7.Name = "button7";
            button7.Size = new Size(197, 45);
            button7.TabIndex = 9;
            button7.Text = "Phát hành phiếu dự thi";
            button7.UseVisualStyleBackColor = true;
            button7.Click += btnTongQuan_Click_1;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.ForeColor = SystemColors.HotTrack;
            button6.Location = new Point(0, 363);
            button6.Margin = new Padding(0, 3, 3, 3);
            button6.Name = "button6";
            button6.Size = new Size(197, 44);
            button6.TabIndex = 8;
            button6.Text = "Quản lý phòng thi";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btnTongQuan_Click_1;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.ForeColor = SystemColors.HotTrack;
            button5.Location = new Point(0, 313);
            button5.Margin = new Padding(0, 3, 3, 3);
            button5.Name = "button5";
            button5.Size = new Size(197, 44);
            button5.TabIndex = 7;
            button5.Text = "Quản lý kỳ thi";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnTongQuan_Click_1;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.ForeColor = SystemColors.HotTrack;
            button4.Location = new Point(0, 266);
            button4.Margin = new Padding(0, 3, 3, 3);
            button4.Name = "button4";
            button4.Size = new Size(197, 41);
            button4.TabIndex = 6;
            button4.Text = "Quản lý lịch thi";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnTongQuan_Click_1;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.ForeColor = SystemColors.HotTrack;
            button3.Location = new Point(0, 211);
            button3.Margin = new Padding(0, 3, 3, 3);
            button3.Name = "button3";
            button3.Size = new Size(197, 49);
            button3.TabIndex = 5;
            button3.Text = "Quản lý nhân viên";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnTongQuan_Click_1;
            // 
            // btn_QuanLyLichNhanVien
            // 
            btn_QuanLyLichNhanVien.Dock = DockStyle.Fill;
            btn_QuanLyLichNhanVien.ForeColor = SystemColors.HotTrack;
            btn_QuanLyLichNhanVien.Location = new Point(0, 156);
            btn_QuanLyLichNhanVien.Margin = new Padding(0, 3, 3, 3);
            btn_QuanLyLichNhanVien.Name = "btn_QuanLyLichNhanVien";
            btn_QuanLyLichNhanVien.Size = new Size(197, 49);
            btn_QuanLyLichNhanVien.TabIndex = 4;
            btn_QuanLyLichNhanVien.Text = "Quản lý lịch nhân viên";
            btn_QuanLyLichNhanVien.UseVisualStyleBackColor = true;
            btn_QuanLyLichNhanVien.Click += btnTongQuan_Click_1;
            // 
            // btnTongQuan
            // 
            btnTongQuan.Dock = DockStyle.Fill;
            btnTongQuan.FlatAppearance.BorderColor = SystemColors.Control;
            btnTongQuan.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            btnTongQuan.ForeColor = SystemColors.HotTrack;
            btnTongQuan.Location = new Point(3, 106);
            btnTongQuan.Name = "btnTongQuan";
            btnTongQuan.Size = new Size(194, 44);
            btnTongQuan.TabIndex = 3;
            btnTongQuan.Text = "Tổng quan";
            btnTongQuan.UseVisualStyleBackColor = true;
            btnTongQuan.Click += btnTongQuan_Click_1;
            // 
            // btnThongbao
            // 
            btnThongbao.ForeColor = SystemColors.Highlight;
            btnThongbao.Location = new Point(3, 464);
            btnThongbao.Name = "btnThongbao";
            btnThongbao.Size = new Size(194, 44);
            btnThongbao.TabIndex = 10;
            btnThongbao.Text = "Thông báo";
            btnThongbao.UseVisualStyleBackColor = true;
            btnThongbao.Click += btnTongQuan_Click_1;
            // 
            // adminSidebar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(tableLayoutPanel2);
            Name = "adminSidebar";
            Size = new Size(200, 602);
            Load += adminSidebar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_QuanLyLichNhanVien;
        private Button btnTongQuan;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button7;
        private Button button6;
        private Button btnThongbao;
        private Label label1;
    }
}
