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
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.Location = new Point(1, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(200, 625);
            panelSidebar.TabIndex = 0;
            panelSidebar.Paint += panelSidebar_Paint;
            // 
            // panelMain
            // 
            panelMain.Location = new Point(207, 52);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1021, 573);
            panelMain.TabIndex = 1;
            panelMain.Paint += panelMain_Paint;
            // 
            // fQuanTriDL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 655);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Name = "fQuanTriDL";
            Text = "fQuanTriDL";
            Load += fQuanTriDL_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Panel panelMain;
    }
}