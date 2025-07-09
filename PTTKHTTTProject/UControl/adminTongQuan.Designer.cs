namespace PTTKHTTTProject.UControl
{
    partial class adminTongQuan
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
            panel1 = new Panel();
            panel4 = new Panel();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            panel3 = new Panel();
            labelNumberOfExamination = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            panel2 = new Panel();
            labelNumberOfSchedule = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(10, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 189);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.BackColor = Color.LightBlue;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(683, 78);
            panel4.Name = "panel4";
            panel4.Size = new Size(294, 91);
            panel4.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(95, 50);
            label4.Name = "label4";
            label4.Size = new Size(167, 28);
            label4.TabIndex = 2;
            label4.Text = "Quản trị hệ thống";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.UserIcon;
            pictureBox4.Location = new Point(12, 15);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(66, 60);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(129, 12);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 0;
            label5.Text = "Vai trò";
            label5.Click += label5_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.BackColor = Color.LightBlue;
            panel3.Controls.Add(labelNumberOfExamination);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(350, 78);
            panel3.Name = "panel3";
            panel3.Size = new Size(294, 91);
            panel3.TabIndex = 3;
            // 
            // labelNumberOfExamination
            // 
            labelNumberOfExamination.AutoSize = true;
            labelNumberOfExamination.Font = new Font("Segoe UI", 14F);
            labelNumberOfExamination.Location = new Point(146, 46);
            labelNumberOfExamination.Name = "labelNumberOfExamination";
            labelNumberOfExamination.Size = new Size(70, 32);
            labelNumberOfExamination.TabIndex = 2;
            labelNumberOfExamination.Text = "NULL";
            labelNumberOfExamination.Click += labelNumberOfExamination_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.test;
            pictureBox3.Location = new Point(13, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(66, 63);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(85, 12);
            label3.Name = "label3";
            label3.Size = new Size(206, 25);
            label3.TabIndex = 0;
            label3.Text = "Tổng số kỳ thi đang có";
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.LightBlue;
            panel2.Controls.Add(labelNumberOfSchedule);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(14, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(294, 91);
            panel2.TabIndex = 1;
            // 
            // labelNumberOfSchedule
            // 
            labelNumberOfSchedule.AutoSize = true;
            labelNumberOfSchedule.Font = new Font("Segoe UI", 14F);
            labelNumberOfSchedule.Location = new Point(127, 43);
            labelNumberOfSchedule.Name = "labelNumberOfSchedule";
            labelNumberOfSchedule.Size = new Size(70, 32);
            labelNumberOfSchedule.TabIndex = 2;
            labelNumberOfSchedule.Text = "NULL";
            labelNumberOfSchedule.Click += labelNumberOfSchedule_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.calendar1;
            pictureBox2.Location = new Point(3, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(77, 12);
            label2.Name = "label2";
            label2.Size = new Size(212, 25);
            label2.TabIndex = 0;
            label2.Text = "Tổng số lịch thi hiện tại";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(340, 21);
            label1.Name = "label1";
            label1.Size = new Size(344, 32);
            label1.TabIndex = 0;
            label1.Text = "CHÀO MỪNG QUẢN TRỊ";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.poster;
            pictureBox1.Location = new Point(303, 212);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(364, 344);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // adminTongQuan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "adminTongQuan";
            Size = new Size(1021, 573);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label2;
        private Label labelNumberOfSchedule;
        private Panel panel3;
        private Label labelNumberOfExamination;
        private PictureBox pictureBox3;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private PictureBox pictureBox4;
        private Label label5;
    }
}
