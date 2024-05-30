using BUS;
using ComponentFactory.Krypton.Toolkit;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class MoSo : Form
    {
        public MoSo()
        {
            InitializeComponent();




        }

        #region Event Handlers

        private void Kbtn_checkin_Click(object sender, EventArgs e)
        {
           
            if (IsValidated())
            {
                errorProvider1.Clear();
               
                Sotietkiem sotietkiem = new Sotietkiem(int.Parse(Kcb_loaitietkiem.SelectedValue.ToString()), Ktxt_tenkhachhang.Text, Ktxt_cccd.Text, Ktxt_diachi.Text, DateTime.Now, int.Parse(Ktxt_sotiengui.Text), int.Parse(Ktxt_sotiengui.Text));
                bool result = MoSoBUS.Instance.insert(sotietkiem);
                if (result == true)
                {
                    MessageBox.Show("Successful!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Ktxt_cccd.Clear();
                    Ktxt_diachi.Clear();
                    Ktxt_sotiengui.Clear();
                    Ktxt_tenkhachhang.Clear();
                    Klbl_loai.Text = "";
                    Klbl_tien.Text = "";
                    Klbl_so.Text="";
                    Kcb_loaitietkiem.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Fail!\r\nChoose new EmployeeID,Please!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void Ktxt_sotiengui_TextChanged(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox
            string sotiengui_str = Ktxt_sotiengui.Text;
            if (int.TryParse(Ktxt_sotiengui.Text, out int value))
            {
                // Định dạng giá trị tiền tệ và gán vào Label
                Klbl_tien.Text = value.ToString("N0")+ "VNĐ";
            }
            if (Ktxt_sotiengui.Text=="")
            {
                Klbl_tien.Text = "VNĐ";
            }
           
        }
    
        private void Ktxt_cccd_TextChanged(object sender, EventArgs e)
        {
            // Lấy số lượng ký tự trong TextBox
            int length = Ktxt_cccd.Text.Length;

            // Hiển thị số lượng ký tự trong Label
            Klbl_so.Text = length.ToString();
        }



        #endregion

        #region Hàm kiểm tra lỗi

        private bool IsValidated()
        {
            bool isValid = true; 
            //
            if(Ktxt_tenkhachhang.Text == "")
            {
                errorProvider1.SetError(Ktxt_tenkhachhang, "Vui lòng nhập tên khách hàng");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(Ktxt_tenkhachhang, "");
            }
           
            // Validate Ktxt_cccd
            if (string.IsNullOrEmpty(Ktxt_cccd.Text) || !long.TryParse(Ktxt_cccd.Text, out long cccd))
            {
                errorProvider1.SetError(Ktxt_cccd, "CCCD/CMND phải là số và không được để trống.");
                isValid = false;
            }
            else if (Ktxt_cccd.Text.Length != 9 && Ktxt_cccd.Text.Length != 12)
            {
                errorProvider1.SetError(Ktxt_cccd, "CCCD/CMND phải có 9 hoặc 12 chữ số.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(Ktxt_cccd, "");
            }
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
            // Validate Ktxt_sotiengui
            if (string.IsNullOrEmpty(Ktxt_sotiengui.Text) || !int.TryParse(Ktxt_sotiengui.Text, out int sotiengui))
            {
                errorProvider1.SetError(Ktxt_sotiengui, "Số tiền gửi phải là số đúng định dạng (vd 100000) và dưới 2 tỷ đồng thời không được để trống.");
                isValid = false;
            }
            else if (sotiengui < 100000)
            {
                errorProvider1.SetError(Ktxt_sotiengui, "Số tiền gửi tối thiểu là 100000.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(Ktxt_sotiengui, "");
            }
            //
            if (Ktxt_diachi.Text == "")
            {
                errorProvider1.SetError(Ktxt_diachi, "Vui lòng nhập địa chỉ khách hàng");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(Ktxt_diachi, "");
            }
            return isValid;

        }









        #endregion

        private void Kbtn_signin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   
        private void MoSo_Load(object sender, EventArgs e)
        {
            Kcb_loaitietkiem.DataSource = MoSoBUS.Instance.getLoaiTietKiem();
            Kcb_loaitietkiem.DisplayMember = "Tenloaitietkiem";
            Kcb_loaitietkiem.ValueMember = "Maloaitietkiem";
        }
    }
}