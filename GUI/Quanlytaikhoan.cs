using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Quanlytaikhoan : Form
    {
        BindingSource taikhoanList = new BindingSource();

        public TaiKhoan loginAccount;

        public Quanlytaikhoan()
        {
            InitializeComponent();
            Load();
        }

        void Load()
        {
            Kdt_danhsachTK.DataSource = taikhoanList;
            LoadAccount();
            AddAccountBinding();
        }

        void AddAccountBinding()
        {
            ktxt_ID.DataBindings.Add(new Binding("Text", Kdt_danhsachTK.DataSource, "ID", true, DataSourceUpdateMode.Never));
            Ktxt_TenTaiKhoan.DataBindings.Add(new Binding("Text", Kdt_danhsachTK.DataSource, "Tentaikhoan", true, DataSourceUpdateMode.Never));
            Ktxt_TenHienThi.DataBindings.Add(new Binding("Text", Kdt_danhsachTK.DataSource, "Tennguoidung", true, DataSourceUpdateMode.Never));
            Ktxt_LoaiTaiKhoan.DataBindings.Add(new Binding("Text", Kdt_danhsachTK.DataSource, "Loaitaikhoan", true, DataSourceUpdateMode.Never));
        }

        void LoadAccount()
        {
            taikhoanList.DataSource = TaiKhoanDAO.Instance.GetListAccount();
        }

        void AddAccount(string Tentaikhoan, string Tennguoidung, int Loaitaikhoan)
        {
            if (TaiKhoanDAO.Instance.InsertAccount(Tentaikhoan, Tennguoidung, Loaitaikhoan))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

            LoadAccount();
        }

        void UpdateAccount(string Tentaikhoan, string Tennguoidung, int Loaitaikhoan, int ID)
        {
            if (TaiKhoanDAO.Instance.UpdateAccount(Tentaikhoan, Tennguoidung, Loaitaikhoan, ID))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }

            LoadAccount();
        }

        void DeleteAccount(int ID)
        {
            if (loginAccount.ID.Equals(ID))
            {
                MessageBox.Show("Vui lòng đừng xóa chính bạn chứ");
                return;
            }

            if (TaiKhoanDAO.Instance.DeleteAccount(ID))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            LoadAccount();
        }

        void ResetPass(int ID)
        {
            if (TaiKhoanDAO.Instance.ResetPassword(ID))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string Tentaikhoan = Ktxt_TenTaiKhoan.Text;
            string Tennguoidung = Ktxt_TenHienThi.Text;
            int Loaitaikhoan = Convert.ToInt32(Ktxt_LoaiTaiKhoan.Text);

            AddAccount(Tentaikhoan, Tennguoidung, Loaitaikhoan);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(ktxt_ID.Text);
            string Tentaikhoan = Ktxt_TenTaiKhoan.Text;
            string Tennguoidung = Ktxt_TenHienThi.Text;
            int Loaitaikhoan = Convert.ToInt32(Ktxt_LoaiTaiKhoan.Text);

            UpdateAccount(Tentaikhoan, Tennguoidung, Loaitaikhoan, ID);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(ktxt_ID.Text);
            DeleteAccount(ID);
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(ktxt_ID.Text);
            ResetPass(ID);
        }

        private void Kbtn_signin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
