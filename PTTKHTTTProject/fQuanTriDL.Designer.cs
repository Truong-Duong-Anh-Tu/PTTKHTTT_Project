namespace PTTKHTTTProject
{
    partial class fQuanTriDL
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
            panelSidebar = new Panel();
            panelMain = new Panel();
            panelHeader = new Panel();
            Logout = new Button();
            labelUsername = new Label();
            pictureAvatar = new PictureBox();
            labelHeader = new Label();
            pictureBoxmenu = new PictureBox();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxmenu).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.Location = new Point(1, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(200, 638);
            panelSidebar.TabIndex = 0;
            panelSidebar.Paint += panelSidebar_Paint;
            // 
            // panelMain
            // 
            panelMain.Location = new Point(207, 65);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1021, 573);
            panelMain.TabIndex = 1;
            panelMain.Paint += panelMain_Paint;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(Logout);
            panelHeader.Controls.Add(labelUsername);
            panelHeader.Controls.Add(pictureAvatar);
            panelHeader.Controls.Add(labelHeader);
            panelHeader.Controls.Add(pictureBoxmenu);
            panelHeader.Location = new Point(207, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1021, 59);
            panelHeader.TabIndex = 2;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // Logout
            // 
            Logout.BackColor = Color.LightBlue;
            Logout.Location = new Point(905, 14);
            Logout.Name = "Logout";
            Logout.Size = new Size(104, 34);
            Logout.TabIndex = 4;
            Logout.Text = "Đăng xuất";
            Logout.UseVisualStyleBackColor = false;
            Logout.Click += Logout_Click;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelUsername.Location = new Point(766, 21);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(133, 20);
            labelUsername.TabIndex = 3;
            labelUsername.Text = "Quản trị hệ thống";
            labelUsername.Click += labelUsername_Click;
            // 
            // pictureAvatar
            // 
            pictureAvatar.Image = Properties.Resources.avatar;
            pictureAvatar.Location = new Point(714, 12);
            pictureAvatar.Name = "pictureAvatar";
            pictureAvatar.Size = new Size(46, 38);
            pictureAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureAvatar.TabIndex = 2;
            pictureAvatar.TabStop = false;
            pictureAvatar.Click += pictureAvatar_Click;
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Location = new Point(71, 21);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(50, 20);
            labelHeader.TabIndex = 1;
            labelHeader.Text = "label1";
            labelHeader.Click += labelHeader_Click;
            // 
            // pictureBoxmenu
            // 
            pictureBoxmenu.BackColor = Color.SteelBlue;
            pictureBoxmenu.Image = Properties.Resources.Menu;
            pictureBoxmenu.Location = new Point(17, 12);
            pictureBoxmenu.Name = "pictureBoxmenu";
            pictureBoxmenu.Size = new Size(48, 38);
            pictureBoxmenu.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxmenu.TabIndex = 0;
            pictureBoxmenu.TabStop = false;
            pictureBoxmenu.Click += pictureBox1_Click;
            // 
            // fQuanTriDL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 654);
            Controls.Add(panelHeader);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Name = "fQuanTriDL";
            Text = "fQuanTriDL";
            Load += fQuanTriDL_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxmenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Panel panelMain;
        private Panel panelHeader;
        private Label labelHeader;
        private PictureBox pictureBoxmenu;
        private PictureBox pictureAvatar;
        private Label labelUsername;
        private Button Logout;
    }
}