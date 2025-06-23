namespace PTTKHTTTProject
{
    partial class fSignIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            btnSignIn = new Button();
            llbForgotPassword = new LinkLabel();
            ptbLogo = new PictureBox();
            lblName = new Label();
            tbxUsername = new TextBox();
            tbxPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(59, 453);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DeepSkyBlue;
            panel2.Location = new Point(59, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(354, 53);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DeepSkyBlue;
            panel3.Location = new Point(59, 401);
            panel3.Name = "panel3";
            panel3.Size = new Size(354, 50);
            panel3.TabIndex = 2;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.DeepSkyBlue;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = SystemColors.Control;
            btnSignIn.Location = new Point(474, 262);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(247, 36);
            btnSignIn.TabIndex = 5;
            btnSignIn.Text = "ĐĂNG NHẬP";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // llbForgotPassword
            // 
            llbForgotPassword.AutoSize = true;
            llbForgotPassword.Location = new Point(474, 301);
            llbForgotPassword.Name = "llbForgotPassword";
            llbForgotPassword.Size = new Size(116, 20);
            llbForgotPassword.TabIndex = 6;
            llbForgotPassword.TabStop = true;
            llbForgotPassword.Text = "Quên mật khẩu?";
            // 
            // ptbLogo
            // 
            ptbLogo.Image = Properties.Resources.logo;
            ptbLogo.Location = new Point(121, 188);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(55, 54);
            ptbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            ptbLogo.TabIndex = 7;
            ptbLogo.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(182, 188);
            lblName.Name = "lblName";
            lblName.Size = new Size(253, 50);
            lblName.TabIndex = 8;
            lblName.Text = "TRUNG TÂM TỔ CHỨC THI\r\nANH NGỮ VÀ TIN HỌC ACCI";
            // 
            // tbxUsername
            // 
            tbxUsername.BorderStyle = BorderStyle.FixedSingle;
            tbxUsername.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxUsername.Location = new Point(474, 160);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.PlaceholderText = "Nhập tên đăng nhập";
            tbxUsername.Size = new Size(247, 31);
            tbxUsername.TabIndex = 9;
            // 
            // tbxPassword
            // 
            tbxPassword.BorderStyle = BorderStyle.FixedSingle;
            tbxPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPassword.Location = new Point(474, 211);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '*';
            tbxPassword.PlaceholderText = "Mật khẩu";
            tbxPassword.Size = new Size(247, 31);
            tbxPassword.TabIndex = 10;
            tbxPassword.UseSystemPasswordChar = true;
            // 
            // fSignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbxPassword);
            Controls.Add(tbxUsername);
            Controls.Add(lblName);
            Controls.Add(ptbLogo);
            Controls.Add(llbForgotPassword);
            Controls.Add(btnSignIn);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fSignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIGN IN";
            Load += fSignIn_Load;
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnSignIn;
        private LinkLabel llbForgotPassword;
        private PictureBox ptbLogo;
        private Label lblName;
        private TextBox tbxUsername;
        private TextBox tbxPassword;
    }
}
