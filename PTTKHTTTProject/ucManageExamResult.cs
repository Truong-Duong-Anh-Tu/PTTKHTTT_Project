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
        private BindingSource bs_ResultExam;
        public ucManageExamResult()
        {
            InitializeComponent();
            bs_ResultExam = new BindingSource();
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

                bs_ResultExam.DataSource = ManageResultBUS.loadCandidateAndPoint(examtype);

                dtgvResult.DataSource = bs_ResultExam;
            }
        }

        private void cbxExamName_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCandicateAndPoint(GetCbxExamName());
        }

        private void ucManageExamResult_Load(object sender, EventArgs e)
        {
            dtpExamDate.CustomFormat = " ";
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

        private void dtpExamDate_ValueChanged(object sender, EventArgs e)
        {
            dtpExamDate.CustomFormat = " dddd dd/MM/yyyy";
        }

        private void tbxSearchCandidate_TextChanged(object sender, EventArgs e)
        {
            string filter = tbxSearchCandidate.Text.Trim().ToString();

            if( string.IsNullOrEmpty(filter))
            {
                bs_ResultExam.Filter = string.Empty;
            }
            else
            {
                bs_ResultExam.Filter = $"TS_SoBaoDanh LIKE '%{filter}%'";
            }    
                
        }
    }
}
