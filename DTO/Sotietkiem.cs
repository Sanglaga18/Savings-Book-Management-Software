using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sotietkiem
    {
        public Sotietkiem(int maLoaiTietKiem, string tenKhachHang, string CCCD, string diaChi, DateTime ngayMoSo, int soTienGuiBanDau, int sodu)
        {

            this.Maloaitietkiem = maLoaiTietKiem;
            this.Tenkhachhang = tenKhachHang;
            this.CCCD = CCCD;
            this.Diachi = diaChi;
            this.Ngaymoso = ngayMoSo;
            this.Sotienguibandau = soTienGuiBanDau;
            this.sodu = sodu;

        }

        public Sotietkiem(DataRow row)
        {
            this.Masotietkiem = (int)row["maSoTietKiem"];
            this.Maloaitietkiem = (int)row["maLoaiTietKiem"];
            this.Tenkhachhang = row["tenKhachHang"].ToString();
            this.CCCD = row["CCCD"].ToString();
            this.Diachi = row["diaChi"].ToString();
            this.Ngaymoso = (DateTime)row["ngayMoSo"];
            if (row["ngayDongSo"].ToString() == "") this.Ngaydongso = null;
            else this.Ngaydongso = (DateTime)row["ngayDongSo"];
            this.Sotienguibandau = (int)row["soTienGuiBanDau"];
            this.Sodu = (int)row["Sodu"];
        }

        private int masotietkiem;
        public int Masotietkiem
        {
            get { return masotietkiem; }
            set { masotietkiem = value; }
        }

        private int maloaitietkiem;
        public int Maloaitietkiem
        {
            get { return maloaitietkiem; }
            set { maloaitietkiem = value; }
        }

        private string tenkhachhang;
        public string Tenkhachhang
        {
            get { return tenkhachhang; }
            set { tenkhachhang = value; }
        }

        private string cccd;
        public string CCCD
        {
            get { return cccd; }
            set { cccd = value; }
        }

        private string diachi;
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        private DateTime ngaymoso;
        public DateTime Ngaymoso
        {
            get { return ngaymoso; }
            set { ngaymoso = value; }
        }
        private DateTime? ngaydongso;

        private int sotienguibandau;
        public int Sotienguibandau
        {
            get { return sotienguibandau; }
            set { sotienguibandau = value; }
        }


        public int Sodu { get => sodu; set => sodu = value; }
        public DateTime? Ngaydongso { get => ngaydongso; set => ngaydongso = value; }

        private int sodu;
    }
}
