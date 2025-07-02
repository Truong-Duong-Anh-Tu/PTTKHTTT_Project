namespace PTTKHTTTProject.UControl
{
    partial class adminQuanLyNV
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
            buttonThemNV = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonThemNV
            // 
            buttonThemNV.BackColor = Color.SkyBlue;
            buttonThemNV.Location = new Point(1363, 18);
            buttonThemNV.Name = "buttonThemNV";
            buttonThemNV.Size = new Size(258, 46);
            buttonThemNV.TabIndex = 0;
            buttonThemNV.Text = "Thêm NV";
            buttonThemNV.UseVisualStyleBackColor = false;
            buttonThemNV.Click += buttonThemNV_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(67, 179);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1534, 688);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(41, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(1583, 802);
            panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1112, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(426, 39);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 30);
            label1.Name = "label1";
            label1.Size = new Size(401, 45);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH NHÂN VIÊN";
            label1.Click += label1_Click;
            // 
            // adminQuanLyNV
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(buttonThemNV);
            Controls.Add(panel1);
            Name = "adminQuanLyNV";
            Size = new Size(1659, 917);
            Click += A;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonThemNV;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
    }
}
