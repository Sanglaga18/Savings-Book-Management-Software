using BUS;
using DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class LapBaoCaoDongMoHangThang : Form
    {
        public LapBaoCaoDongMoHangThang()
        {
            InitializeComponent();
        }

        private void Kbtn_xacnhan_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                string month = Kdtp_thangnam.Value.Month.ToString();
                string year = Kdtp_thangnam.Value.Year.ToString();
                string loaitietkiem = Kcb_loaitietkiem.SelectedValue.ToString();
                Kdt_baocaodongmo.DataSource = LapBaoCaoDongMoBUS.Instance.lapBaoCaoDongMo(month, year, loaitietkiem);
            }
       
        }
        private bool IsValidated()
        {
            bool isValid = true;
            // Validate Kcb_loaitietkiem
            if (Kcb_loaitietkiem.SelectedIndex == -1)
            {
                errorProvider1.SetError(Kcb_loaitietkiem, "Vui lòng chọn loại tiết kiệm.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(Kcb_loaitietkiem, "");
            }

            return isValid;

        }

        private void Kbtn_excel_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu DataGridView không có dữ liệu thì không xuất file Excel
            if (Kdt_baocaodongmo.Rows.Count == 0)
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
                for (int i = 0; i < Kdt_baocaodongmo.Columns.Count; i++)
                {
                    excelRange = (Microsoft.Office.Interop.Excel.Range)excelWorksheet.Cells[1, i + 1];
                    excelRange.Value2 = Kdt_baocaodongmo.Columns[i].HeaderText;
                }

                // Lưu dữ liệu từ DataGridView vào Excel
                for (int i = 0; i < Kdt_baocaodongmo.Rows.Count; i++)
                {
                    for (int j = 0; j < Kdt_baocaodongmo.Columns.Count; j++)
                    {
                        excelRange = (Microsoft.Office.Interop.Excel.Range)excelWorksheet.Cells[i + 2, j + 1];
                        excelRange.Value2 = Kdt_baocaodongmo.Rows[i].Cells[j].Value;
                    }
                }

                // Lưu file Excel
                excelWorkbook.SaveAs(saveDialog.FileName);
                excelWorkbook.Close();
                excelApp.Quit();

                MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Kbtn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LapBaoCaoDongMoHangThang_Load(object sender, EventArgs e)
        {
            Kcb_loaitietkiem.DataSource = LapBaoCaoDongMoBUS.Instance.getLoaiTietKiem();
            Kcb_loaitietkiem.DisplayMember = "Tenloaitietkiem";
            Kcb_loaitietkiem.ValueMember = "Maloaitietkiem";
        }
    }
}
