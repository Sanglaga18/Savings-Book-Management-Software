using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using BUS;
namespace GUI
{
    public partial class ThayDoiKyHan : Form
    {
        public ThayDoiKyHan()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            kryptonDataGridView1.DataSource = ThayDoiKyHanBUS.Instance.KyHan();
            kryptonComboBox1.DataSource = ThayDoiKyHanBUS.Instance.MaLoaiTietKiem();
            ktxt_tien.Text = "Tiền Gửi Tối Thiểu";
            ktxt_laisuat.Text = "Lãi suất";
            ktxt_kyhanthem.Text = "Kỳ hạn";
        }

        private void Ktxt_maso_Enter(object sender, EventArgs e)
        {
            if (Ktxt_maso.Text == "Tiền Gửi Tối Thiểu")
            {
                Ktxt_maso.Text = "";
            }
        }

        private void Ktxt_maso_Leave(object sender, EventArgs e)
        {
            if (Ktxt_maso.Text.Trim().Length == 0)
            {
                Ktxt_maso.Text = "Tiền Gửi Tối Thiểu";
            }
        }

        private void Ktxt_maso_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Kbtn_checkin_Click(object sender, EventArgs e)
        {
            if (Ktxt_maso.Text.All(char.IsDigit))
            {
                ThayDoiKyHanBUS.Instance.ThayDoiTienGuiToiThieu(kryptonComboBox1.SelectedValue.ToString(), Ktxt_maso.Text);
                MessageBox.Show("Thay đổi thành công");
                Init();
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu");
            }
        }





      

        private void ktxt_kyhanthem_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ktxt_tien_KeyPress(object sender, KeyPressEventArgs e)
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

 

        private void ktxt_kyhanthem_Leave(object sender, EventArgs e)
        {
            if (ktxt_kyhanthem.Text.Trim().Length == 0)
            {
                ktxt_kyhanthem.Text = "Kỳ hạn";
            }
        }

        private void ktxt_kyhanthem_Enter(object sender, EventArgs e)
        {
            if (ktxt_kyhanthem.Text == "Kỳ hạn")
            {
                ktxt_kyhanthem.Text = "";
            }
        }

        private void ktxt_tien_Leave(object sender, EventArgs e)
        {
            if (ktxt_tien.Text.Trim().Length == 0)
            {
                ktxt_tien.Text = "Tiền Gửi Tối Thiểu";
            }
        }

        private void ktxt_tien_Enter(object sender, EventArgs e)
        {
            if (ktxt_tien.Text == "Tiền Gửi Tối Thiểu")
            {
                ktxt_tien.Text = "";
            }
        }


        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            if (ktxt_laisuat.Text.All(char.IsDigit) && ktxt_kyhanthem.Text.All(char.IsDigit) && ktxt_tien.Text.All(char.IsDigit))
            {
                if (int.Parse(ktxt_tien.Text) > 0 && int.Parse(ktxt_laisuat.Text) > 0)
                {
                    ThayDoiKyHanBUS.Instance.ThemLoaiTietKiem(ktxt_laisuat.Text, ktxt_kyhanthem.Text, ktxt_tien.Text);
                    MessageBox.Show("Thêm thành công");
                    Init();
                }
                else
                {
                    MessageBox.Show("Lãi suất và tiền gửi tối thiểu phải lớn hơn 0");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu");
            }
        }

        private void Ktxt_maso_Enter_1(object sender, EventArgs e)
        {
            if (Ktxt_maso.Text == "Tiền Gửi Tối Thiểu")
            {
                Ktxt_maso.Text = "";
            }
        }

        private void Ktxt_maso_Leave_1(object sender, EventArgs e)
        {
           
                if (Ktxt_maso.Text.Trim().Length == 0)
                {
                    Ktxt_maso.Text = "Tiền Gửi Tối Thiểu";
                }
            

        }

        private void Ktxt_maso_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void ktxt_laisuat_Leave(object sender, EventArgs e)
        {
            if (ktxt_laisuat.Text.Trim().Length == 0)
            {
                ktxt_laisuat.Text = "Lãi suất";
            }
        }

        private void ktxt_laisuat_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ktxt_laisuat_Enter(object sender, EventArgs e)
        {
            if (ktxt_laisuat.Text == "Lãi suất")
            {
                ktxt_laisuat.Text = "";
            }
        }

        private void Kbtn_signin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
