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
    public partial class Main : Form
    {
        private TaiKhoan loginAccount;

        public TaiKhoan LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }

        public Main(TaiKhoan acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            if (acc.LoaiTaiKhoan != 1)
            {
                this.Kbtn_thaydoiquydinh.Enabled = false;
                this.Kbtn_thaydoiquydinh.Visible = false;
                this.Kbtn_Quanlytaikhoan.Enabled = false;
                this.Kbtn_Quanlytaikhoan.Visible = false;
                this.Height = 500;
            }
            else
            {
                this.Height = 750;
            }
            
            
            Init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        #region method
        private void Init()
        {
            // hàm ẩn các panel

            panel_lapphieuguirut.Visible = false;
            panel_lapbaocao.Visible = false;
            panel_thaydoiquydinh.Visible = false;



        }

        private void hidePanel() //ẩn panel
        {

            if (panel_lapbaocao.Visible)
            {
                panel_lapbaocao.Visible = false;
            }

            if (panel_lapphieuguirut.Visible)
            {
                panel_lapphieuguirut.Visible = false;
            }

            if (panel_thaydoiquydinh.Visible)
            {
                panel_thaydoiquydinh.Visible = false;
            }
          

        }
        private void showPanel(Panel panel) // mở panel
        {
            if (!panel.Visible)
            {
                hidePanel();// khi ấn một nút chức năng sẽ đóng tất cả những panel ngoại trừ panel của chức năng vừa nhấn
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }
        Form currentForm = null;
        private void openChildForm(Form childForm) // mở một form khác 
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Content.Controls.Add(childForm);
            panel_Content.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }
        #endregion


        #region buttonclick
        // sự kiện click





        private void Kbtn_dangxuat_Click(object sender, EventArgs e)
        {
            hidePanel();
            this.Close();
        }


        private void picB_HCMUE_Click(object sender, EventArgs e)
        {
            openChildForm(new Info());
        }


        private void label1_Click(object sender, EventArgs e)
        {
            openChildForm(new Info());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openChildForm(new Info());
        }



        private void btn_lapphieugui_Click(object sender, EventArgs e)
        {
            openChildForm(new LapPhieuGui());
        }

        private void Kbtn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Kbtn_mosotietkiem_Click(object sender, EventArgs e)
        {
            hidePanel();
            openChildForm(new MoSo());
        }

        private void Kbtn_lapphieu_Click(object sender, EventArgs e)
        {
            showPanel(panel_lapphieuguirut);
        }

        private void btn_lapphieurut_Click(object sender, EventArgs e)
        {
            openChildForm(new LapPhieuRut());
        }

        private void Kbtn_tracuuso_Click(object sender, EventArgs e)
        {
            hidePanel();
            openChildForm(new TraCuuSo());
        }

        private void Kbtn_lapbaocao_Click(object sender, EventArgs e)
        {
            showPanel(panel_lapbaocao);
        }

        private void Kbtn_lapbaocaongay_Click(object sender, EventArgs e)
        {
            openChildForm(new LapBaoCaoNgay());
        }

        private void Kbtn_lapbaocaodongmoso_Click(object sender, EventArgs e)
        {
            openChildForm(new LapBaoCaoDongMoHangThang());
        }

        private void Kbtn_thaydoiquydinh_Click(object sender, EventArgs e)
        {
            showPanel(panel_thaydoiquydinh);
        }

        private void Kbtn_thaydoikyhan_Click(object sender, EventArgs e)
        {
            openChildForm(new ThayDoiKyHan());
        }

        private void Kbtn_thaydoithoigianguitoithieu_Click(object sender, EventArgs e)
        {
            openChildForm(new ThayDoiLaiSuat());

        }

        private void Kbtn_Quanlytaikhoan_Click(object sender, EventArgs e)
        {
            hidePanel();
            Quanlytaikhoan f = new Quanlytaikhoan();
            f.loginAccount = loginAccount;
            openChildForm(f);
        }
    }
    #endregion
}
