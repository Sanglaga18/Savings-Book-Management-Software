using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        public TaiKhoan(int id, string tenTaiKhoan, string tenNguoiDung, int loaiTaiKhoan, string matKhau = null)
        {
            this.ID = id;
            this.TenTaiKhoan = tenTaiKhoan;
            this.MatKhau = matKhau;
            this.TenNguoiDung = tenNguoiDung;
            this.LoaiTaiKhoan = loaiTaiKhoan;
        }

        public TaiKhoan(DataRow row)
        {
            this.ID = (int)row["id"];
            this.TenTaiKhoan = row["tenTaiKhoan"].ToString();
            this.MatKhau = row["matKhau"].ToString();
            this.TenNguoiDung = row["tenNguoiDung"].ToString();
            this.LoaiTaiKhoan = (int)row["loaiTaiKhoan"];
        }

        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string tenTaiKhoan;

        public string TenTaiKhoan
        {
            get { return tenTaiKhoan; }
            set { tenTaiKhoan = value; }
        }

        private string matKhau;

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        private string tenNguoiDung;

        public string TenNguoiDung
        {
            get { return tenNguoiDung; }
            set { tenNguoiDung = value; }
        }

        private int loaiTaiKhoan;

        public int LoaiTaiKhoan
        {
            get { return loaiTaiKhoan; }
            set { loaiTaiKhoan = value; }
        }

    }
}
