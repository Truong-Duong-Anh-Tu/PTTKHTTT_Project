namespace PTTKHTTTProject
{
    partial class fNotification
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
            pnlSelections = new Panel();
            btnBinMail = new Button();
            btnmailSended = new Button();
            btnMailReceived = new Button();
            btnAddNoti = new FontAwesome.Sharp.IconButton();
            pnlMail = new Panel();
            tbxFullMail = new RichTextBox();
            lvListMail = new ListView();
            pnlSelections.SuspendLayout();
            pnlMail.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSelections
            // 
            pnlSelections.Controls.Add(btnBinMail);
            pnlSelections.Controls.Add(btnmailSended);
            pnlSelections.Controls.Add(btnMailReceived);
            pnlSelections.Location = new Point(12, 72);
            pnlSelections.Name = "pnlSelections";
            pnlSelections.Size = new Size(141, 422);
            pnlSelections.TabIndex = 0;
            // 
            // btnBinMail
            // 
            btnBinMail.Location = new Point(0, 115);
            btnBinMail.Name = "btnBinMail";
            btnBinMail.Size = new Size(140, 50);
            btnBinMail.TabIndex = 3;
            btnBinMail.Text = "Thùng rác";
            btnBinMail.UseVisualStyleBackColor = true;
            btnBinMail.Click += pnlSelections_Click;
            // 
            // btnmailSended
            // 
            btnmailSended.Location = new Point(0, 59);
            btnmailSended.Name = "btnmailSended";
            btnmailSended.Size = new Size(140, 50);
            btnmailSended.TabIndex = 2;
            btnmailSended.Text = "Thư đã gửi";
            btnmailSended.UseVisualStyleBackColor = true;
            btnmailSended.Click += pnlSelections_Click;
            // 
            // btnMailReceived
            // 
            btnMailReceived.Location = new Point(0, 3);
            btnMailReceived.Name = "btnMailReceived";
            btnMailReceived.Size = new Size(140, 50);
            btnMailReceived.TabIndex = 1;
            btnMailReceived.Text = "Hộp thư đến";
            btnMailReceived.UseVisualStyleBackColor = true;
            btnMailReceived.Click += pnlSelections_Click;
            // 
            // btnAddNoti
            // 
            btnAddNoti.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnAddNoti.IconColor = Color.Black;
            btnAddNoti.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddNoti.IconSize = 30;
            btnAddNoti.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddNoti.Location = new Point(12, 29);
            btnAddNoti.Name = "btnAddNoti";
            btnAddNoti.Size = new Size(197, 37);
            btnAddNoti.TabIndex = 2;
            btnAddNoti.Text = "Soạn thông báo";
            btnAddNoti.UseVisualStyleBackColor = true;
            // 
            // pnlMail
            // 
            pnlMail.Controls.Add(tbxFullMail);
            pnlMail.Controls.Add(lvListMail);
            pnlMail.Location = new Point(158, 72);
            pnlMail.Name = "pnlMail";
            pnlMail.Size = new Size(730, 422);
            pnlMail.TabIndex = 3;
            pnlMail.Paint += pnlMail_Paint;
            // 
            // tbxFullMail
            // 
            tbxFullMail.BorderStyle = BorderStyle.FixedSingle;
            tbxFullMail.Location = new Point(249, 4);
            tbxFullMail.Name = "tbxFullMail";
            tbxFullMail.Size = new Size(476, 413);
            tbxFullMail.TabIndex = 1;
            tbxFullMail.Text = "";
            // 
            // lvListMail
            // 
            lvListMail.Location = new Point(3, 4);
            lvListMail.Name = "lvListMail";
            lvListMail.Size = new Size(240, 413);
            lvListMail.TabIndex = 0;
            lvListMail.UseCompatibleStateImageBehavior = false;
            lvListMail.SelectedIndexChanged += lvListMail_SelectedIndexChanged;
            // 
            // fNotification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 506);
            Controls.Add(pnlMail);
            Controls.Add(btnAddNoti);
            Controls.Add(pnlSelections);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fNotification";
            Text = "fThongBao";
            Load += fNotification_Load;
            pnlSelections.ResumeLayout(false);
            pnlMail.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSelections;
        private Button btnMailReceived;
        private Button btnBinMail;
        private Button btnmailSended;
        private FontAwesome.Sharp.IconButton btnAddNoti;
        private Panel pnlMail;
        private ListView lvListMail;
        private RichTextBox tbxFullMail;
    }
}