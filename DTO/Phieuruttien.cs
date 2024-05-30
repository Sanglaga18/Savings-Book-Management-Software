using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phieuruttien
    {
        public Phieuruttien(int maPhieuRutTien, int maSoTietKiem, int soTienRut, DateTime ngayRut)
        {
            this.Maphieuruttien = maPhieuRutTien;
            this.Masotietkiem = maSoTietKiem;
            this.Sotienrut = soTienRut;
            this.Ngayrut = ngayRut;
        }

        public Phieuruttien(DataRow row)
        {
            this.Maphieuruttien = (int)row["maPhieuRutTien"];
            this.Masotietkiem = (int)row["maSoTietKiem"];
            this.Sotienrut = (int)row["soTienRut"];
            this.Ngayrut = (DateTime)row["ngayRut"];
        }

        private int maphieuruttien;
        public int Maphieuruttien 
        { 
            get { return maphieuruttien; }
            set { maphieuruttien = value; }
        }

        private int masotietkiem;
	    public int Masotietkiem
        {
            get { return masotietkiem; }
            set { masotietkiem = value; }
        }

        private int sotienrut;
        public int Sotienrut
        {
            get { return sotienrut; }
            set { sotienrut = value; }
        }

        private DateTime ngayrut;
	    public DateTime Ngayrut
        {
            get { return ngayrut; }
            set { ngayrut = value; }
        }
    }
}
