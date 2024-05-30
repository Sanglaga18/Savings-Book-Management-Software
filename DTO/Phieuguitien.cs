using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phieuguitien
    {
        public Phieuguitien(int maPhieuGuiTien, int maSoTietKiem, int soTienGui, DateTime ngayGui)
        {
            this.Maphieuguitien = maPhieuGuiTien;
            this.Masotietkiem = maSoTietKiem;
            this.Sotiengui = soTienGui;
            this.Ngaygui = ngayGui;
        }

        public Phieuguitien(DataRow row)
        {
            this.Maphieuguitien = (int)row["maPhieuGuiTien"];
            this.Masotietkiem = (int)row["maSoTietKiem"];
            this.Sotiengui = (int)row["soTienGui"];
            this.Ngaygui = (DateTime)row["ngayGui"];
        }

        private int maphieuguitien;
        public int Maphieuguitien
        {
            get { return maphieuguitien; }
            set { maphieuguitien = value; }
        }

        private int masotietkiem;
        public int Masotietkiem
        {
            get { return masotietkiem; }
            set { masotietkiem = value; }
        }

        private int sotiengui;
        public int Sotiengui
        {
            get { return sotiengui; }
            set { sotiengui = value; }
        }

        private DateTime ngaygui;
        public DateTime Ngaygui
        {
            get { return ngaygui; }
            set { ngaygui = value; }
        }
    }
}
