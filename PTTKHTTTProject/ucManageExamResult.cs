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
using System.Xaml;
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

        public void loadCandicateAndPoint()
        {
            if (cbxExamName.SelectedIndex != -1)
            {
                string examtype = $"{cbxExamName.SelectedItem}";

                bs_ResultExam.DataSource = ManageResultBUS.loadCandidateAndPoint(examtype);

                dtgvResult.DataSource = bs_ResultExam;
            }
        }

        private void cbxExamName_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCandicateAndPoint();
            loadExamDate();
        }

        private void loadExamDate()
        {
            if (cbxExamName.SelectedIndex != -1)
            {

                string examtype = $"{cbxExamName.SelectedItem}";
                List<string> listexamdate = ExamDateBUS.loadExamDate(examtype);

                if (listexamdate.Count > 0)
                {
                    cbxExamDate.DataSource = listexamdate;
                }
                else
                {
                    cbxExamDate.DataSource = null;
                }
            }
        }

        private void ucManageExamResult_Load(object sender, EventArgs e)
        {
            dtgvResult.AutoGenerateColumns = false;
            dtgvResult.Columns.Clear();

            dtgvResult.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colFullname",
                DataPropertyName = "TS_HoTen",
                HeaderText = "Họ và tên",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 200
            });

            dtgvResult.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colSBD",
                DataPropertyName = "TS_SoBaoDanh",
                HeaderText = "Số báo danh"
            });

            dtgvResult.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colCCCD",
                DataPropertyName = "TS_CCCD",
                HeaderText = "CCCD"
            });

            dtgvResult.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colBirthday",
                DataPropertyName = "TS_NgaySinh",
                HeaderText = "Ngày sinh",
            });
            dtgvResult.Columns["colBirthday"]!.DefaultCellStyle.Format = "dd/MM/yyyy";

            dtgvResult.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colGender",
                DataPropertyName = "TS_GioiTinh",
                HeaderText = "Giới tính"
            });

            dtgvResult.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colScore",
                DataPropertyName = "BT_DiemSo",
                HeaderText = "Điểm số"
            });

            var btnCol = new DataGridViewButtonColumn
            {
                Name = "btnAction",
                HeaderText = "Hành động",
                UseColumnTextForButtonValue = true,
            };
            btnCol.DefaultCellStyle.Padding = new Padding(35, 0, 35, 0);
            dtgvResult.Columns.Add(btnCol);

            dtgvResult.RowTemplate.MinimumHeight = 40;

            cbxExamName.DataSource = ExamTypeBUS.loadExamType();
        }

        private void dtgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dtgvResult.Columns["btnAction"]!.Index)
                return;

            var row = dtgvResult.Rows[e.RowIndex];

            string name = row.Cells["colFullname"].Value?.ToString() ?? "";
            string sbd = row.Cells["colSBD"].Value?.ToString() ?? "";
            string examtype = cbxExamName.SelectedItem?.ToString() ?? string.Empty;
            string examdate = cbxExamDate.SelectedItem?.ToString() ?? string.Empty;

            fUpdateResult fur = new fUpdateResult(examtype, examdate, sbd, name);
            fur.ShowDialog();
        }

        private void tbxSearchCandidate_TextChanged(object sender, EventArgs e)
        {
            string filter = tbxSearchCandidate.Text.Trim().ToString();

            if (string.IsNullOrEmpty(filter))
            {
                bs_ResultExam.Filter = string.Empty;
            }
            else
            {
                bs_ResultExam.Filter = $"TS_SoBaoDanh LIKE '%{filter}%'";
            }
        }

        private void dtgvResult_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                e.PaintBackground(e.CellBounds, true);
                using (var pen = new Pen(Color.LightGray))
                {
                    // Vẽ đường ở đáy header cell
                    e.Graphics!.DrawLine(pen,
                        e.CellBounds.Left,
                        e.CellBounds.Bottom - 1,
                        e.CellBounds.Right,
                        e.CellBounds.Bottom - 1);
                }
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }

            if (e.ColumnIndex != dtgvResult.Columns["btnAction"]!.Index || e.RowIndex < 0)
            {
                return;
            }
            e.Paint(e.CellBounds, DataGridViewPaintParts.All);
            var icon = Properties.Resources.Edit; // icon từ resource
            int iconW = 16, iconH = 16;
            int x = e.CellBounds.X + (e.CellBounds.Width - iconW) / 2;
            int y = e.CellBounds.Y + (e.CellBounds.Height - iconH) / 2;
            e.Graphics!.DrawImage(icon, x, y, iconW, iconH);
            e.Handled = true;
        }

        private void cbxExamDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string examdatetime = $"{cbxExamDate.SelectedItem}".Split(' ')[0];

            if (string.IsNullOrEmpty(examdatetime))
            {
                bs_ResultExam.Filter = string.Empty;
            }
            else
            {
                bs_ResultExam.Filter = $"BT_MaLichThi = '{examdatetime}'";
            }
        }
    }
}
