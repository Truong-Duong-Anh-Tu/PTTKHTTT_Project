namespace PTTKHTTTProject
{
    partial class ucNotification
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
            btnAddNoti = new FontAwesome.Sharp.IconButton();
            pnlSelections = new Panel();
            btnBinMail = new Button();
            btnMailSended = new Button();
            btnMailReceived = new Button();
            pnlMail = new Panel();
            tbxFullMail = new RichTextBox();
            lvListMail = new ListView();
            pnlSelections.SuspendLayout();
            pnlMail.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddNoti
            // 
            btnAddNoti.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddNoti.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnAddNoti.IconColor = Color.Black;
            btnAddNoti.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddNoti.IconSize = 40;
            btnAddNoti.ImageAlign = ContentAlignment.TopLeft;
            btnAddNoti.Location = new Point(38, 25);
            btnAddNoti.Name = "btnAddNoti";
            btnAddNoti.Size = new Size(259, 49);
            btnAddNoti.TabIndex = 3;
            btnAddNoti.Text = "Soạn thông báo";
            btnAddNoti.UseVisualStyleBackColor = true;
            btnAddNoti.Click += btnAddNoti_Click;
            // 
            // pnlSelections
            // 
            pnlSelections.Controls.Add(btnBinMail);
            pnlSelections.Controls.Add(btnMailSended);
            pnlSelections.Controls.Add(btnMailReceived);
            pnlSelections.Location = new Point(38, 97);
            pnlSelections.Name = "pnlSelections";
            pnlSelections.Size = new Size(166, 473);
            pnlSelections.TabIndex = 4;
            // 
            // btnBinMail
            // 
            btnBinMail.FlatStyle = FlatStyle.Flat;
            btnBinMail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBinMail.Location = new Point(0, 132);
            btnBinMail.Name = "btnBinMail";
            btnBinMail.Size = new Size(166, 58);
            btnBinMail.TabIndex = 3;
            btnBinMail.Text = "Thùng rác";
            btnBinMail.UseVisualStyleBackColor = true;
            btnBinMail.Click += pnlSelections_Click;
            // 
            // btnMailSended
            // 
            btnMailSended.FlatStyle = FlatStyle.Flat;
            btnMailSended.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMailSended.Location = new Point(0, 68);
            btnMailSended.Name = "btnMailSended";
            btnMailSended.Size = new Size(166, 58);
            btnMailSended.TabIndex = 2;
            btnMailSended.Text = "Thư đã gửi";
            btnMailSended.UseVisualStyleBackColor = true;
            btnMailSended.Click += pnlSelections_Click;
            // 
            // btnMailReceived
            // 
            btnMailReceived.FlatStyle = FlatStyle.Flat;
            btnMailReceived.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMailReceived.Location = new Point(0, 3);
            btnMailReceived.Name = "btnMailReceived";
            btnMailReceived.Size = new Size(166, 58);
            btnMailReceived.TabIndex = 1;
            btnMailReceived.Text = "Hộp thư đến";
            btnMailReceived.UseVisualStyleBackColor = true;
            btnMailReceived.Click += pnlSelections_Click;
            // 
            // pnlMail
            // 
            pnlMail.Controls.Add(tbxFullMail);
            pnlMail.Controls.Add(lvListMail);
            pnlMail.Location = new Point(212, 97);
            pnlMail.Name = "pnlMail";
            pnlMail.Size = new Size(806, 473);
            pnlMail.TabIndex = 5;
            // 
            // tbxFullMail
            // 
            tbxFullMail.BackColor = Color.White;
            tbxFullMail.BorderStyle = BorderStyle.FixedSingle;
            tbxFullMail.Location = new Point(312, 5);
            tbxFullMail.Name = "tbxFullMail";
            tbxFullMail.Size = new Size(491, 465);
            tbxFullMail.TabIndex = 1;
            tbxFullMail.Text = "";
            tbxFullMail.TextChanged += tbxFullMail_TextChanged;
            // 
            // lvListMail
            // 
            lvListMail.Location = new Point(3, 5);
            lvListMail.Name = "lvListMail";
            lvListMail.Size = new Size(303, 465);
            lvListMail.TabIndex = 0;
            lvListMail.UseCompatibleStateImageBehavior = false;
            lvListMail.SelectedIndexChanged += lvListMail_SelectedIndexChanged;
            // 
            // ucNotification
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlMail);
            Controls.Add(pnlSelections);
            Controls.Add(btnAddNoti);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ucNotification";
            Size = new Size(1032, 575);
            pnlSelections.ResumeLayout(false);
            pnlMail.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAddNoti;
        private Panel pnlSelections;
        private Button btnBinMail;
        private Button btnMailSended;
        private Button btnMailReceived;
        private Panel pnlMail;
        private RichTextBox tbxFullMail;
        private ListView lvListMail;
    }
}
