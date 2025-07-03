namespace PTTKHTTTProject
{
    partial class fAdminXemDSLichThi_PhongThi
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
            labelPhongThi = new Label();
            labelHienThiPhongThi = new Label();
            dataGridView1 = new DataGridView();
            pictureBoxThoat = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxThoat).BeginInit();
            SuspendLayout();
            // 
            // labelPhongThi
            // 
            labelPhongThi.AutoSize = true;
            labelPhongThi.Font = new Font("Segoe UI", 12F);
            labelPhongThi.Location = new Point(196, 31);
            labelPhongThi.Name = "labelPhongThi";
            labelPhongThi.Size = new Size(290, 28);
            labelPhongThi.TabIndex = 0;
            labelPhongThi.Text = "Danh sách lịch thi của phòng thi";
            // 
            // labelHienThiPhongThi
            // 
            labelHienThiPhongThi.AutoSize = true;
            labelHienThiPhongThi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelHienThiPhongThi.ForeColor = Color.IndianRed;
            labelHienThiPhongThi.Location = new Point(492, 31);
            labelHienThiPhongThi.Name = "labelHienThiPhongThi";
            labelHienThiPhongThi.Size = new Size(60, 28);
            labelHienThiPhongThi.TabIndex = 1;
            labelHienThiPhongThi.Text = "P101";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(710, 266);
            dataGridView1.TabIndex = 2;
            // 
            // pictureBoxThoat
            // 
            pictureBoxThoat.Image = Properties.Resources.exit;
            pictureBoxThoat.Location = new Point(52, 31);
            pictureBoxThoat.Name = "pictureBoxThoat";
            pictureBoxThoat.Size = new Size(65, 32);
            pictureBoxThoat.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxThoat.TabIndex = 3;
            pictureBoxThoat.TabStop = false;
            pictureBoxThoat.Click += pictureBoxThoat_Click;
            // 
            // fAdminXemDSLichThi_PhongThi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(786, 377);
            Controls.Add(pictureBoxThoat);
            Controls.Add(dataGridView1);
            Controls.Add(labelHienThiPhongThi);
            Controls.Add(labelPhongThi);
            Name = "fAdminXemDSLichThi_PhongThi";
            Text = "fAdminXemDSLichThi_PhongThi";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxThoat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPhongThi;
        private Label labelHienThiPhongThi;
        private DataGridView dataGridView1;
        private PictureBox pictureBoxThoat;
    }
}