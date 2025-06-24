using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTTKHTTTProject.BUS;

namespace PTTKHTTTProject
{
    public partial class ucManageExamResult : UserControl
    {
        public ucManageExamResult()
        {
            InitializeComponent();
        }

        public ComboBox GetCbxExamName()
        {
            return cbxExamName;
        }


        public void loadCandicateAndPoint(ComboBox cbxExamName)
        {
            if (cbxExamName.SelectedIndex != -1)
            {
                string examtype = $"{cbxExamName.SelectedItem}";

                Debug.WriteLine(examtype);

                dtgvResult.DataSource = ManageResultBUS.loadCandidateAndPoint(examtype);
            }
        }

        private void cbxExamName_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCandicateAndPoint(GetCbxExamName());
        }

        private void ucManageExamResult_Load(object sender, EventArgs e)
        {
            cbxExamName.DataSource = ManageResultBUS.loadExamType();
            var btnCol = new DataGridViewButtonColumn
            {
                Name = "btnAction",
                HeaderText = "Hành động",
                Text = "Xem chi tiết",
                UseColumnTextForButtonValue = true
            };
            dtgvResult.Columns.Add(btnCol);
        }

        private void dtgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvResult.ClearSelection();
        }
    }
}
