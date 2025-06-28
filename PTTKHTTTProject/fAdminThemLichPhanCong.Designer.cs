namespace PTTKHTTTProject
{
    partial class fAdminThemLichPhanCong
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
            panelThemLichPhanCong = new Panel();
            SuspendLayout();
            // 
            // panelThemLichPhanCong
            // 
            panelThemLichPhanCong.Location = new Point(12, 12);
            panelThemLichPhanCong.Name = "panelThemLichPhanCong";
            panelThemLichPhanCong.Size = new Size(1001, 528);
            panelThemLichPhanCong.TabIndex = 0;
            panelThemLichPhanCong.Paint += panelThemLichPhanCong_Paint;
            // 
            // fAdminThemLichPhanCong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 558);
            Controls.Add(panelThemLichPhanCong);
            Name = "fAdminThemLichPhanCong";
            Text = "fAdminThemLichPhanCong";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelThemLichPhanCong;
    }
}