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
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(comboBoxTrangThai);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(22, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 499);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search1;
            pictureBox1.Location = new Point(629, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(676, 23);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tìm kiếm mã nhân viên";
            textBox1.Size = new Size(288, 27);
            textBox1.TabIndex = 5;
            // 
            // comboBoxTrangThai
            // 
            comboBoxTrangThai.FormattingEnabled = true;
            comboBoxTrangThai.Location = new Point(372, 20);
            comboBoxTrangThai.Name = "comboBoxTrangThai";
            comboBoxTrangThai.Size = new Size(219, 28);
            comboBoxTrangThai.TabIndex = 3;
            comboBoxTrangThai.Text = "Trạng thái";
            comboBoxTrangThai.SelectedIndexChanged += comboBoxTrangThai_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(941, 418);
            dataGridView1.TabIndex = 1;
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
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // adminQuanLyLichNV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "adminQuanLyLichNV";
            Size = new Size(1021, 573);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox comboBoxTrangThai;
        private PictureBox pictureBox1;
        private TextBox textBox1;
    }
}
