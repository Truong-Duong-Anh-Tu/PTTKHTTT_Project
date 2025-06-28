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
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panelTimKiem = new Panel();
            comboBoxTrangThai = new ComboBox();
            labelTrangThai = new Label();
            labelTimMaNV = new Label();
            pictureBoxSearch = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.Location = new Point(780, 15);
            button1.Name = "button1";
            button1.Size = new Size(222, 40);
            button1.TabIndex = 0;
            button1.Text = "Thêm phân công";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(labelTrangThai);
            panel1.Controls.Add(comboBoxTrangThai);
            panel1.Controls.Add(panelTimKiem);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(22, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 499);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(23, 17);
            label1.Name = "label1";
            label1.Size = new Size(207, 31);
            label1.TabIndex = 0;
            label1.Text = "LỊCH PHÂN CÔNG";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(941, 428);
            dataGridView1.TabIndex = 1;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // panelTimKiem
            // 
            panelTimKiem.BorderStyle = BorderStyle.FixedSingle;
            panelTimKiem.Controls.Add(pictureBoxSearch);
            panelTimKiem.Controls.Add(labelTimMaNV);
            panelTimKiem.Location = new Point(656, 9);
            panelTimKiem.Name = "panelTimKiem";
            panelTimKiem.Size = new Size(297, 32);
            panelTimKiem.TabIndex = 2;
            panelTimKiem.Paint += panelTimKiem_Paint;
            // 
            // comboBoxTrangThai
            // 
            comboBoxTrangThai.FormattingEnabled = true;
            comboBoxTrangThai.Location = new Point(396, 9);
            comboBoxTrangThai.Name = "comboBoxTrangThai";
            comboBoxTrangThai.Size = new Size(219, 28);
            comboBoxTrangThai.TabIndex = 3;
            comboBoxTrangThai.SelectedIndexChanged += comboBoxTrangThai_SelectedIndexChanged;
            // 
            // labelTrangThai
            // 
            labelTrangThai.AutoSize = true;
            labelTrangThai.Location = new Point(438, 12);
            labelTrangThai.Name = "labelTrangThai";
            labelTrangThai.Size = new Size(75, 20);
            labelTrangThai.TabIndex = 4;
            labelTrangThai.Text = "Trạng thái";
            labelTrangThai.Click += labelTrangThai_Click;
            // 
            // labelTimMaNV
            // 
            labelTimMaNV.AutoSize = true;
            labelTimMaNV.Location = new Point(69, 2);
            labelTimMaNV.Name = "labelTimMaNV";
            labelTimMaNV.Size = new Size(162, 20);
            labelTimMaNV.TabIndex = 0;
            labelTimMaNV.Text = "Tìm kiếm mã nhân viên";
            labelTimMaNV.Click += labelTimMaNV_Click;
            // 
            // pictureBoxSearch
            // 
            pictureBoxSearch.Image = Properties.Resources.search;
            pictureBoxSearch.Location = new Point(11, -1);
            pictureBoxSearch.Name = "pictureBoxSearch";
            pictureBoxSearch.Size = new Size(40, 30);
            pictureBoxSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSearch.TabIndex = 1;
            pictureBoxSearch.TabStop = false;
            pictureBoxSearch.Click += pictureBoxSearch_Click;
            // 
            // adminQuanLyLichNV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "adminQuanLyLichNV";
            Size = new Size(1021, 573);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelTimKiem.ResumeLayout(false);
            panelTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panelTimKiem;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label labelTrangThai;
        private ComboBox comboBoxTrangThai;
        private Label labelTimMaNV;
        private PictureBox pictureBoxSearch;
    }
}
