using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTKHTTTProject
{
    public partial class fInfo : Form
    {
        public fInfo()
        {
            InitializeComponent();
        }

        private void pnlSalaryRole_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.DeepSkyBlue;
            ButtonBorderStyle style = ButtonBorderStyle.Solid;
            ControlPaint.DrawBorder(e.Graphics, this.pnlSalaryRole.ClientRectangle,
                borderColor, 2, style,
                borderColor, 2, style,
                borderColor, 2, style,
                borderColor, 2, style);
        }

        private void pnlHotenRole_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.DeepSkyBlue;
            ButtonBorderStyle style = ButtonBorderStyle.Solid;
            ControlPaint.DrawBorder(e.Graphics, this.pnlHotenRole.ClientRectangle,
                borderColor, 2, style,
                borderColor, 2, style,
                borderColor, 2, style,
                borderColor, 2, style);
        }

        private void pnlInfoNV_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.DeepSkyBlue;
            ButtonBorderStyle style = ButtonBorderStyle.Solid;
            ControlPaint.DrawBorder(e.Graphics, this.pnlInfoNV.ClientRectangle,
                borderColor, 2, style,
                borderColor, 2, style,
                borderColor, 2, style,
                borderColor, 2, style);
        }
    }
}
