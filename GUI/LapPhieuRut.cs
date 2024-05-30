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
using DTO;
using BUS;
namespace GUI
{
    public partial class LapPhieuRut : Form
    {
        public LapPhieuRut()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            ktxt_mstk.Text = "Mã sổ tiết kiệm";
            ktxt_ten.Text = "Tên khách hàng";
            ktxt_ngayrut.Text = DateTime.Now.ToString("dd/MM/yyyy");
            ktxt_tienrut.Text = "Số tiền rút";
            ktxt_tienrut.Enabled = false;
            lbl_sodu.Text = "Số dư";
        }

        private void Init2()
        {
            ktxt_ten.Text = "Tên khách hàng";
            ktxt_ngayrut.Text = DateTime.Now.ToString("dd/MM/yyyy");
            ktxt_tienrut.Text = "Số tiền rút";
            ktxt_tienrut.Enabled = false;
            lbl_sodu.Text = "Số dư";
        }

        private void ktxt_mstk_Enter(object sender, EventArgs e)
        {
            Init2();
            if (ktxt_mstk.Text == "Mã sổ tiết kiệm")
            {
                ktxt_mstk.Text = "";
            }
        }

        private void ktxt_mstk_Leave(object sender, EventArgs e)
        {
            if (ktxt_mstk.Text.Trim().Length == 0)
            {
                ktxt_mstk.Text = "Mã sổ tiết kiệm";
                ktxt_ten.Text = "Tên khách hàng";
            }
            else
            {
                Sotietkiem sotietkiem = PhieuRutTienBUS.Instance.LaySoBangMaSo(ktxt_mstk.Text.Trim());
                if (sotietkiem != null)
                {
                    ktxt_ten.Text = sotietkiem.Tenkhachhang;
                    lbl_sodu.Text = sotietkiem.Sodu.ToString();
                    Loaitietkiem loaitietkiem = PhieuRutTienBUS.Instance.LayLoaiTietKiemBangMaSo(ktxt_mstk.Text.Trim());
                    if (PhieuRutTienBUS.Instance.KiemTraRutTien(ktxt_mstk.Text.Trim(), DateTime.Now))
                    {
                        if (loaitietkiem.Maloaitietkiem == 1)
                        {
                            ktxt_tienrut.Enabled = true;
                            ktxt_tienrut.Text = "Số tiền rút";
                        }
                        else
                        {
                            ktxt_tienrut.Text = sotietkiem.Sodu.ToString();
                            ktxt_tienrut.Enabled = false;
                        }
                    }
                    else
                    {
                        if (sotietkiem.Ngaydongso != null)
                        {
                            MessageBox.Show("Sổ đã đóng");
                        }
                        else
                        {
                            MessageBox.Show("Chưa tới thời gian rút tiền");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ko tồn tại mã sổ này");
                    ktxt_ten.Text = "Tên khách hàng";
                    ktxt_tienrut.Text = "Số tiền rút";
                    ktxt_tienrut.Enabled = false;
                }
            }
        }
    


        private void ktxt_tienrut_Enter(object sender, EventArgs e)
        {
            if (ktxt_tienrut.Text == "Số tiền rút")
            {
                ktxt_tienrut.Text = "";
            }
        }

        private void ktxt_tienrut_Leave(object sender, EventArgs e)
        {
            if (ktxt_tienrut.Text.Trim().Length == 0)
            {
                ktxt_tienrut.Text = "Số tiền rút";
            }
        }

        private void ktxt_mstk_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ktxt_tienrut_KeyPress(object sender, KeyPressEventArgs e)
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
            if (ktxt_mstk.Text.All(char.IsDigit) && ktxt_tienrut.Text.All(char.IsDigit))
            {
                if (PhieuRutTienBUS.Instance.KiemTraRutTien2(ktxt_mstk.Text.Trim(), DateTime.Now, int.Parse(ktxt_tienrut.Text)))
                {
                    string text = "Tiền rút: " + ktxt_tienrut.Text + "\n" + "Tiền lãi: " + PhieuRutTienBUS.Instance.LaiSuat(ktxt_mstk.Text.Trim()).ToString();
                    PhieuRutTienBUS.Instance.CapNhatSoDu(ktxt_mstk.Text.Trim(), int.Parse(ktxt_tienrut.Text));
                    PhieuRutTienBUS.Instance.ThemPhieuRutTien(ktxt_mstk.Text.Trim(), ktxt_tienrut.Text, DateTime.Now);
                    MessageBox.Show(text, "Rút tiền thành công");
                    Init();
                }
                else
                {
                    MessageBox.Show("Số tiền rút lớm hơn số dư");
                }
            }
            else
            {
                MessageBox.Show("Nhập sai dữ liệu");
            }
        }

        private void Kbtn_signin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
