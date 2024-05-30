using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Loaitietkiem
    {
        public Loaitietkiem(int maLoaiTietKiem, string tenLoaiTietKiem, float laiSuat, int kyHan, int soNgayDuocRut, bool duocGuithem, int tienGuiThemThoiThieu, int soTienGuiToiThieu = 100000)
        {
            this.Maloaitietkiem = maLoaiTietKiem;
            this.Tenloaitietkiem = tenLoaiTietKiem;
            this.Laisuat = laiSuat;
            this. Kyhan = kyHan;
            this.Songayduocrut = soNgayDuocRut;
            this.Duocguithem = duocGuithem;
            this.Tenguithemtoithieu = tienGuiThemThoiThieu;
            this.Sotienguitoithieu = soTienGuiToiThieu;
        }

        public Loaitietkiem(DataRow row)
        {
            this.Maloaitietkiem = (int)row["maLoaiTietKiem"];
            this.Tenloaitietkiem = row["tenLoaiTietKiem"].ToString();
            this.Laisuat = (float)row["laiSuat"];
            this.Kyhan = (int)row["kyHan"];
            this.Songayduocrut = (int)row["soNgayDuocRut"];
            this.Duocguithem = (bool)row["duocGuithem"];
            this.Tenguithemtoithieu = (int)row["tienGuiThemThoiThieu"];
            this.Sotienguitoithieu = (int)row["soTienGuiToiThieu"];
        }

        private int maloaitietkiem;

        public int Maloaitietkiem
        {
            get { return maloaitietkiem; }
            set { maloaitietkiem = value; }
        }

        private string tenloaitietkiem;

        public string Tenloaitietkiem
        {
            get { return tenloaitietkiem; }
            set { tenloaitietkiem = value; }
        }

        private float laisuat;
        
        public float Laisuat
        {
            get { return laisuat; }
            set { laisuat = value; }
        }

        private int kyhan;

        public int Kyhan
        {
            get { return kyhan; }
            set { kyhan = value; }
        }

        private int songayduocrut;

        public int Songayduocrut
        {
            get { return songayduocrut; }
            set { songayduocrut = value; }
        }

        private bool duocguithem;

        public bool Duocguithem
        {
            get { return duocguithem; }
            set { duocguithem = value; }
        }

        private int sotienguitoithieu;

        public int Sotienguitoithieu
        {
            get { return sotienguitoithieu; }
            set { sotienguitoithieu = value; }
        }

        private int tienguithemtoithieu;

        public int Tenguithemtoithieu
        {
            get { return tienguithemtoithieu; }
            set { tienguithemtoithieu = value; }
        }

    }
}
