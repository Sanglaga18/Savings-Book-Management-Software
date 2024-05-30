using BUS;
using System;
using System.Windows.Forms;


namespace GUI
{
    public partial class TraCuuSo : Form
    {
        public TraCuuSo()
        {
            InitializeComponent();
        }



        private void Kbtn_tim_Click(object sender, EventArgs e)
        {
            if (Ktxt_maso.Text != String.Empty)
            {
                int tmp;
                if (!int.TryParse(Ktxt_maso.Text, out tmp))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(Ktxt_maso, "Mã sổ phải thuộc dạng số (vd: 123,...)");

                }
                else if (TraCuuSoBUS.Instance.timKiemSo(Ktxt_maso.Text).Rows.Count <= 0)
                {
                    errorProvider1.Clear();
                    MessageBox.Show(string.Format("Không tồn tại sổ với mã: {0}", Ktxt_maso.Text), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    errorProvider1.Clear();
                    Kdt_socantracuu.DataSource = TraCuuSoBUS.Instance.timKiemSo(Ktxt_maso.Text);

                }
                Ktxt_maso.Clear();
            }
            else
            {
                errorProvider1.Clear();
                errorProvider1.SetError(Ktxt_maso, "Mã không được để trống");
            }

        }



        private void btn_tatca_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Ktxt_maso.Clear();
            Kdt_socantracuu.DataSource = TraCuuSoBUS.Instance.loadSo();



        }

        private void Kbtn_signin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
