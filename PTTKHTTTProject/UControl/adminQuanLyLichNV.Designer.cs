namespace PTTKHTTTProject.UControl
{
    partial class adminQuanLyLichNV
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
            buttonThemPhanCong = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            comboBoxTrangThai = new ComboBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonThemPhanCong
            // 
            buttonThemPhanCong.BackColor = Color.SkyBlue;
            buttonThemPhanCong.Location = new Point(1268, 24);
            buttonThemPhanCong.Margin = new Padding(5, 5, 5, 5);
            buttonThemPhanCong.Name = "buttonThemPhanCong";
            buttonThemPhanCong.Size = new Size(361, 64);
            buttonThemPhanCong.TabIndex = 0;
            buttonThemPhanCong.Text = "Thêm phân công";
            buttonThemPhanCong.UseVisualStyleBackColor = false;
            buttonThemPhanCong.Click += buttonThemPhanCong_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(comboBoxTrangThai);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(36, 98);
            panel1.Margin = new Padding(5, 5, 5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1592, 798);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search1;
            pictureBox1.Location = new Point(1022, 27);
            pictureBox1.Margin = new Padding(5, 5, 5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBoxSearch_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1098, 37);
            textBox1.Margin = new Padding(5, 5, 5, 5);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tìm kiếm mã nhân viên";
            textBox1.Size = new Size(466, 39);
            textBox1.TabIndex = 5;
            // 
            // comboBoxTrangThai
            // 
            comboBoxTrangThai.FormattingEnabled = true;
            comboBoxTrangThai.Location = new Point(604, 32);
            comboBoxTrangThai.Margin = new Padding(5, 5, 5, 5);
            comboBoxTrangThai.Name = "comboBoxTrangThai";
            comboBoxTrangThai.Size = new Size(353, 40);
            comboBoxTrangThai.TabIndex = 3;
            comboBoxTrangThai.Text = "Trạng thái";
            comboBoxTrangThai.SelectedIndexChanged += comboBoxTrangThai_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 104);
            dataGridView1.Margin = new Padding(5, 5, 5, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1529, 669);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(37, 27);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(335, 50);
            label1.TabIndex = 0;
            label1.Text = "LỊCH PHÂN CÔNG";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // adminQuanLyLichNV
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(panel1);
            Controls.Add(buttonThemPhanCong);
            Margin = new Padding(5, 5, 5, 5);
            Name = "adminQuanLyLichNV";
            Size = new Size(1659, 917);
            Load += adminQuanLyLichNV_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonThemPhanCong;
        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox comboBoxTrangThai;
        private PictureBox pictureBox1;
        private TextBox textBox1;
    }
}
