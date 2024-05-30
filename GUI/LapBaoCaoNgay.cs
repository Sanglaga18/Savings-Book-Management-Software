using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class LapBaoCaoNgay : Form
    {
        public LapBaoCaoNgay()
        {
            InitializeComponent();
            Kdtp_start.Value = DateTime.Now;
            kryptonDataGridView1.DataSource = LapBaoCaoNgayBUS.Instance.BaoCaoNgay(Kdtp_start.Value);
        }

        private void Kbtn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Kbtn_excel_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu DataGridView không có dữ liệu thì không xuất file Excel
            if (kryptonDataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mở dialog để chọn vị trí lưu file Excel
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel Workbook|*.xlsx";
            saveDialog.Title = "Chọn vị trí lưu file Excel";
            saveDialog.ShowDialog();

            // Nếu người dùng chọn vị trí lưu file Excel
            if (saveDialog.FileName != "")
            {
                // Tạo đối tượng Excel
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook excelWorkbook = excelApp.Workbooks.Add();
                Microsoft.Office.Interop.Excel._Worksheet excelWorksheet = excelWorkbook.Sheets[1];
                Microsoft.Office.Interop.Excel.Range excelRange;

                // Lưu tiêu đề cột vào Excel
                for (int i = 0; i < kryptonDataGridView1.Columns.Count; i++)
                {
                    excelRange = (Microsoft.Office.Interop.Excel.Range)excelWorksheet.Cells[1, i + 1];
                    excelRange.Value2 = kryptonDataGridView1.Columns[i].HeaderText;
                }

                // Lưu dữ liệu từ DataGridView vào Excel
                for (int i = 0; i < kryptonDataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < kryptonDataGridView1.Columns.Count; j++)
                    {
                        excelRange = (Microsoft.Office.Interop.Excel.Range)excelWorksheet.Cells[i + 2, j + 1];
                        excelRange.Value2 = kryptonDataGridView1.Rows[i].Cells[j].Value;
                    }
                }

                // Lưu file Excel
                excelWorkbook.SaveAs(saveDialog.FileName);
                excelWorkbook.Close();
                excelApp.Quit();

                MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Kdtp_start_ValueChanged(object sender, EventArgs e)
        {
            kryptonDataGridView1.DataSource = LapBaoCaoNgayBUS.Instance.BaoCaoNgay(Kdtp_start.Value);
        }
    }
}
