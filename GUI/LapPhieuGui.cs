using BUS;
using DAO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class LapPhieuGui : Form
    {
        public LapPhieuGui()
        {
            InitializeComponent();
            Kdtp_thangnam.Value = DateTime.Today;
        }

        private void Kbtn_signin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Kbtn_checkin_Click(object sender, EventArgs e)
        {
           

            if (isValid())
            {
                if ((LapPhieuGuiBUS.Instance.guiThemTien(int.Parse(Ktxt_maso.Text), int.Parse(Ktxt_sotien.Text))))
                {

                    MessageBox.Show(String.Format("Khách hàng {0} với mã sổ {1} đã gửi tiền thành công\nNgày gửi {2}", Ktxt_tenkhach.Text, Ktxt_maso.Text, Kdtp_thangnam.Value.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Refresh();
                }
                else
                {
                    MessageBox.Show(String.Format(("Mã sổ {0} của khách hàng {1} không thuộc dạng được gửi thêm tiền, vui lòng chọn mã sổ khác hoặc mở thêm sổ mới thuộc dạng được gửi thêm tiền"), Ktxt_maso.Text, Ktxt_tenkhach.Text), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("vui lòng điền đầy đủ thông tin và đúng đinh dạng để có thể gửi tiền");
            }
        }

        private void Ktxt_maso_TextChanged(object sender, EventArgs e)
        {
            int tmp;

            if (int.TryParse(Ktxt_maso.Text, out tmp))
            {
                if (int.Parse(Ktxt_maso.Text) != 0 && int.Parse(Ktxt_maso.Text) > 0 && LapPhieuGuiBUS.Instance.ktMaSo(int.Parse(Ktxt_maso.Text)))
                {
                    errorProvider1.Clear();
                    Ktxt_tenkhach.Text = LapPhieuGuiBUS.Instance.getTenKhachHang(int.Parse(Ktxt_maso.Text));
                    Klbl_sodu.Text = LapPhieuGuiBUS.Instance.getSodu(int.Parse(Ktxt_maso.Text));

                }

                else
                {
                    errorProvider1.SetError(Ktxt_maso, "Mã sổ không tồn tại");
                }


            }
            else if (Ktxt_maso.Text == "")
            {
                Ktxt_tenkhach.Text = "";
            }

        }
        private bool isValid()
        {
            // Kiểm tra Ktxt_maso là số, khác 0
            int maso;
            if (!int.TryParse(Ktxt_maso.Text, out maso) || maso == 0)
            {
                errorProvider1.SetError(Ktxt_maso, "Ktxt_maso phải là số khác 0.");
                Ktxt_maso.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(Ktxt_maso, "");
            }

            // Kiểm tra Ktxt_sotien < 2000000000, khác 0
            int sotien;
            if (!int.TryParse(Ktxt_sotien.Text, out sotien) || sotien <= 100000 || sotien >= 2000000000 )
            {
                errorProvider1.SetError(Ktxt_sotien, "Ktxt_sotien phải là lớn hơn 100,000 và nhỏ hơn 2,000,000,000.");
                Ktxt_sotien.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(Ktxt_sotien, "");
            }

            return true;
        }


    }
}
