using BUS;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class ThayDoiLaiSuat : Form
    {
        public ThayDoiLaiSuat()
        {
            InitializeComponent();

        }

        private void Kbtn_signin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Kbtn_thaydoi_Click(object sender, EventArgs e)
        {
            int thang;
            float laisuat;
            int maloaitietkiem = int.Parse(Kcb_loaitietkiem.SelectedValue.ToString());

            if (int.TryParse(ktxt_thoigian.Text, out thang) && float.TryParse(Ktxt_laisuat.Text, out laisuat))
            {
                if (ThayDoiLaiSuatBUS.Instance.updateLaiSuat(maloaitietkiem, thang, laisuat))
                {
                    MessageBox.Show(String.Format("Đã thay đổi thành công lãi suất của mã loại {0} thành {1} %", Kcb_loaitietkiem.SelectedValue.ToString(), laisuat),"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(String.Format(("Vẫn còn có sổ chứa mã tiết kiệm {0} đang còn hoạt động do đó không thể đổi lãi suất được "), Kcb_loaitietkiem.SelectedValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Kdt_thoigiangui.DataSource=ThayDoiLaiSuatBUS.Instance.loadSo();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng cho cả trường (thời gian, lãi suất)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void ThayDoiLaiSuat_Load(object sender, EventArgs e)
        {

            Kdt_thoigiangui.DataSource = ThayDoiLaiSuatBUS.Instance.loadSo();
            Kcb_loaitietkiem.DataSource = Kdt_thoigiangui.DataSource;
            Kcb_loaitietkiem.DisplayMember = "Tenloaitietkiem";
            Kcb_loaitietkiem.ValueMember = "Mã loại tiết kiệm";




        }
      


        private void ktxt_thoigian_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void ktxt_thoigian_Leave(object sender, EventArgs e)
        {
            if (Ktxt_laisuat.Text.Trim().Length == 0)
            {
                Ktxt_laisuat.Text = "Thời gian (tháng)";
            }
        }

        private void ktxt_thoigian_Enter(object sender, EventArgs e)
        {
            if (ktxt_thoigian.Text == "Thời gian (tháng)")
            {
                ktxt_thoigian.Text = "";
            }
        }

        private void Ktxt_laisuat_Leave(object sender, EventArgs e)
        {
            if (Ktxt_laisuat.Text.Trim().Length == 0)
            {
                Ktxt_laisuat.Text = "Lãi suất";
            }
        }

        private void Ktxt_laisuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Ktxt_laisuat_Enter(object sender, EventArgs e)
        {
            if (Ktxt_laisuat.Text == "Lãi suất")
            {
                Ktxt_laisuat.Text = "";
            }
        }
    }
}
