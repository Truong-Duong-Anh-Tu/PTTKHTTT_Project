using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHTTTProject.UControl
{
    internal class CustomUC
    {
        private static void openChildForm(Panel currentPanel, Form activeForm, Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            currentPanel.Controls.Add(childForm);
            currentPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public static void openChildControl(Panel currentPanel, UserControl activeControl, UserControl childControl)
        {
            if (activeControl != null)
                currentPanel.Controls.Remove(activeControl);

            activeControl = childControl;
            childControl.Dock = DockStyle.Fill;
            currentPanel.Controls.Add(childControl);
            childControl.BringToFront();
        }
    }
}
