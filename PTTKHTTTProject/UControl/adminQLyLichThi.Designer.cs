namespace PTTKHTTTProject.UControl
{
    partial class adminQLyLichThi
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
            labelQuanLylichThi = new Label();
            textBoxTimKiemLichThi = new TextBox();
            pictureBoxSearch = new PictureBox();
            comboBoxTrangThaiLichThi = new ComboBox();
            dataGridViewDSLichThi = new DataGridView();
            buttonThemLichThi = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDSLichThi).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelQuanLylichThi
            // 
            labelQuanLylichThi.AutoSize = true;
            labelQuanLylichThi.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelQuanLylichThi.Location = new Point(27, 19);
            labelQuanLylichThi.Name = "labelQuanLylichThi";
            labelQuanLylichThi.Size = new Size(251, 31);
            labelQuanLylichThi.TabIndex = 0;
            labelQuanLylichThi.Text = "DANH SÁCH LỊCH THI";
            labelQuanLylichThi.Click += labelQuanLylichThi_Click;
            // 
            // textBoxTimKiemLichThi
            // 
            textBoxTimKiemLichThi.Location = new Point(591, 19);
            textBoxTimKiemLichThi.Name = "textBoxTimKiemLichThi";
            textBoxTimKiemLichThi.PlaceholderText = "Tìm lịch thi theo tên kỳ thi";
            textBoxTimKiemLichThi.Size = new Size(320, 27);
            textBoxTimKiemLichThi.TabIndex = 1;
            // 
            // pictureBoxSearch
            // 
            pictureBoxSearch.BackColor = SystemColors.Control;
            pictureBoxSearch.Image = Properties.Resources.search;
            pictureBoxSearch.Location = new Point(917, 19);
            pictureBoxSearch.Name = "pictureBoxSearch";
            pictureBoxSearch.Size = new Size(38, 29);
            pictureBoxSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSearch.TabIndex = 2;
            pictureBoxSearch.TabStop = false;
            // 
            // comboBoxTrangThaiLichThi
            // 
            comboBoxTrangThaiLichThi.FormattingEnabled = true;
            comboBoxTrangThaiLichThi.Location = new Point(381, 19);
            comboBoxTrangThaiLichThi.Name = "comboBoxTrangThaiLichThi";
            comboBoxTrangThaiLichThi.Size = new Size(183, 28);
            comboBoxTrangThaiLichThi.TabIndex = 3;
            comboBoxTrangThaiLichThi.Text = "Trạng thái lịch thi";
            // 
            // dataGridViewDSLichThi
            // 
            dataGridViewDSLichThi.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewDSLichThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDSLichThi.Location = new Point(27, 76);
            dataGridViewDSLichThi.Name = "dataGridViewDSLichThi";
            dataGridViewDSLichThi.RowHeadersWidth = 51;
            dataGridViewDSLichThi.Size = new Size(928, 392);
            dataGridViewDSLichThi.TabIndex = 4;
            // 
            // buttonThemLichThi
            // 
            buttonThemLichThi.BackColor = Color.SkyBlue;
            buttonThemLichThi.Location = new Point(857, 14);
            buttonThemLichThi.Name = "buttonThemLichThi";
            buttonThemLichThi.Size = new Size(155, 42);
            buttonThemLichThi.TabIndex = 5;
            buttonThemLichThi.Text = "Thêm lịch thi";
            buttonThemLichThi.UseVisualStyleBackColor = false;
            buttonThemLichThi.Click += buttonThemLichThi_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(dataGridViewDSLichThi);
            panel1.Controls.Add(labelQuanLylichThi);
            panel1.Controls.Add(pictureBoxSearch);
            panel1.Controls.Add(comboBoxTrangThaiLichThi);
            panel1.Controls.Add(textBoxTimKiemLichThi);
            panel1.Location = new Point(32, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 488);
            panel1.TabIndex = 6;
            // 
            // adminQLyLichThi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(buttonThemLichThi);
            Controls.Add(panel1);
            Name = "adminQLyLichThi";
            Size = new Size(1030, 571);
            Load += adminQLyLichThi_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDSLichThi).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelQuanLylichThi;
        private TextBox textBoxTimKiemLichThi;
        private PictureBox pictureBoxSearch;
        private ComboBox comboBoxTrangThaiLichThi;
        private DataGridView dataGridViewDSLichThi;
        private Button buttonThemLichThi;
        private Panel panel1;
    }
}
