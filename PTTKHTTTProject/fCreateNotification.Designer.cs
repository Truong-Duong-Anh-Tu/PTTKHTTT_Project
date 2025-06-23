namespace PTTKHTTTProject
{
    partial class fCreateNotification
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
            lblRecipient = new Label();
            pnlCreateNoti = new Panel();
            btnCancel = new FontAwesome.Sharp.IconButton();
            btnSend = new FontAwesome.Sharp.IconButton();
            btnSelectReceipients = new FontAwesome.Sharp.IconButton();
            tbxRecipients = new TextBox();
            tbxBody = new TextBox();
            tbxSubject = new TextBox();
            lblSubject = new Label();
            lblSoanThongBao = new Label();
            pnlCreateNoti.SuspendLayout();
            SuspendLayout();
            // 
            // lblRecipient
            // 
            lblRecipient.AutoSize = true;
            lblRecipient.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecipient.Location = new Point(22, 44);
            lblRecipient.Name = "lblRecipient";
            lblRecipient.Size = new Size(111, 23);
            lblRecipient.TabIndex = 0;
            lblRecipient.Text = "Người nhận: ";
            // 
            // pnlCreateNoti
            // 
            pnlCreateNoti.Controls.Add(btnCancel);
            pnlCreateNoti.Controls.Add(btnSend);
            pnlCreateNoti.Controls.Add(btnSelectReceipients);
            pnlCreateNoti.Controls.Add(tbxRecipients);
            pnlCreateNoti.Controls.Add(tbxBody);
            pnlCreateNoti.Controls.Add(tbxSubject);
            pnlCreateNoti.Controls.Add(lblSubject);
            pnlCreateNoti.Controls.Add(lblSoanThongBao);
            pnlCreateNoti.Controls.Add(lblRecipient);
            pnlCreateNoti.Location = new Point(12, 12);
            pnlCreateNoti.Name = "pnlCreateNoti";
            pnlCreateNoti.Size = new Size(776, 426);
            pnlCreateNoti.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DeepSkyBlue;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.Control;
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCancel.IconColor = Color.White;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.IconSize = 20;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(608, 386);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(71, 31);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Hủy";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.DeepSkyBlue;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSend.ForeColor = SystemColors.Control;
            btnSend.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            btnSend.IconColor = Color.White;
            btnSend.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSend.IconSize = 20;
            btnSend.ImageAlign = ContentAlignment.MiddleLeft;
            btnSend.Location = new Point(685, 386);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(71, 31);
            btnSend.TabIndex = 8;
            btnSend.Text = "Gửi";
            btnSend.TextAlign = ContentAlignment.MiddleRight;
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // btnSelectReceipients
            // 
            btnSelectReceipients.BackColor = Color.DeepSkyBlue;
            btnSelectReceipients.FlatStyle = FlatStyle.Flat;
            btnSelectReceipients.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectReceipients.ForeColor = SystemColors.Control;
            btnSelectReceipients.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSelectReceipients.IconColor = Color.Black;
            btnSelectReceipients.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSelectReceipients.Location = new Point(685, 41);
            btnSelectReceipients.Name = "btnSelectReceipients";
            btnSelectReceipients.Size = new Size(71, 31);
            btnSelectReceipients.TabIndex = 7;
            btnSelectReceipients.Text = "Chọn";
            btnSelectReceipients.UseVisualStyleBackColor = false;
            btnSelectReceipients.Click += btnSelectReceipients_Click;
            // 
            // tbxRecipients
            // 
            tbxRecipients.BackColor = SystemColors.Window;
            tbxRecipients.BorderStyle = BorderStyle.FixedSingle;
            tbxRecipients.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxRecipients.Location = new Point(140, 42);
            tbxRecipients.Name = "tbxRecipients";
            tbxRecipients.ReadOnly = true;
            tbxRecipients.Size = new Size(539, 30);
            tbxRecipients.TabIndex = 6;
            // 
            // tbxBody
            // 
            tbxBody.BorderStyle = BorderStyle.FixedSingle;
            tbxBody.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxBody.Location = new Point(22, 131);
            tbxBody.Multiline = true;
            tbxBody.Name = "tbxBody";
            tbxBody.Size = new Size(734, 249);
            tbxBody.TabIndex = 5;
            // 
            // tbxSubject
            // 
            tbxSubject.BorderStyle = BorderStyle.FixedSingle;
            tbxSubject.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxSubject.Location = new Point(140, 84);
            tbxSubject.Name = "tbxSubject";
            tbxSubject.Size = new Size(616, 30);
            tbxSubject.TabIndex = 3;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubject.Location = new Point(22, 86);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(74, 23);
            lblSubject.TabIndex = 2;
            lblSubject.Text = "Chủ đề: ";
            // 
            // lblSoanThongBao
            // 
            lblSoanThongBao.AutoSize = true;
            lblSoanThongBao.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoanThongBao.Location = new Point(3, 3);
            lblSoanThongBao.Name = "lblSoanThongBao";
            lblSoanThongBao.Size = new Size(170, 24);
            lblSoanThongBao.TabIndex = 1;
            lblSoanThongBao.Text = "SOẠN THÔNG BÁO";
            // 
            // fCreateNotification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlCreateNoti);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "fCreateNotification";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Soạn thông báo";
            Load += fCreateNotification_Load;
            pnlCreateNoti.ResumeLayout(false);
            pnlCreateNoti.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblRecipient;
        private Panel pnlCreateNoti;
        private Label lblSubject;
        private Label lblSoanThongBao;
        private TextBox tbxSubject;
        private TextBox tbxBody;
        private TextBox tbxRecipients;
        private FontAwesome.Sharp.IconButton btnSelectReceipients;
        private FontAwesome.Sharp.IconButton btnSend;
        private FontAwesome.Sharp.IconButton btnCancel;
    }
}