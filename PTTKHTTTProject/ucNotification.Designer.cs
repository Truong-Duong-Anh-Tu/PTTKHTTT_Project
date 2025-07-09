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
            btnMailSent = new Button();
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
            btnAddNoti.ImageAlign = ContentAlignment.BottomLeft;
            btnAddNoti.Location = new Point(36, 25);
            btnAddNoti.Name = "btnAddNoti";
            btnAddNoti.Size = new Size(259, 53);
            btnAddNoti.TabIndex = 3;
            btnAddNoti.Text = "Soạn thông báo";
            btnAddNoti.UseVisualStyleBackColor = true;
            btnAddNoti.Click += btnAddNoti_Click;
            // 
            // pnlSelections
            // 
            pnlSelections.Controls.Add(btnMailSent);
            pnlSelections.Controls.Add(btnMailReceived);
            pnlSelections.Location = new Point(38, 97);
            pnlSelections.Name = "pnlSelections";
            pnlSelections.Size = new Size(166, 473);
            pnlSelections.TabIndex = 4;
            // 
            // btnMailSent
            // 
            btnMailSent.FlatStyle = FlatStyle.Flat;
            btnMailSent.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMailSent.Location = new Point(0, 68);
            btnMailSent.Name = "btnMailSent";
            btnMailSent.Size = new Size(166, 58);
            btnMailSent.TabIndex = 2;
            btnMailSent.Text = "Thư đã gửi";
            btnMailSent.UseVisualStyleBackColor = true;
            btnMailSent.Click += pnlSelections_Click;
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
            pnlMail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMail.Controls.Add(tbxFullMail);
            pnlMail.Controls.Add(lvListMail);
            pnlMail.Location = new Point(212, 97);
            pnlMail.Name = "pnlMail";
            pnlMail.Size = new Size(806, 473);
            pnlMail.TabIndex = 5;
            // 
            // tbxFullMail
            // 
            tbxFullMail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxFullMail.BackColor = Color.White;
            tbxFullMail.BorderStyle = BorderStyle.None;
            tbxFullMail.Location = new Point(312, 3);
            tbxFullMail.Name = "tbxFullMail";
            tbxFullMail.Size = new Size(491, 467);
            tbxFullMail.TabIndex = 1;
            tbxFullMail.Text = "";
            tbxFullMail.TextChanged += tbxFullMail_TextChanged;
            // 
            // lvListMail
            // 
            lvListMail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lvListMail.BorderStyle = BorderStyle.None;
            lvListMail.Location = new Point(3, 3);
            lvListMail.Name = "lvListMail";
            lvListMail.Size = new Size(303, 467);
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
        private Button btnMailSent;
        private Button btnMailReceived;
        private Panel pnlMail;
        private RichTextBox tbxFullMail;
        private ListView lvListMail;
    }
}
