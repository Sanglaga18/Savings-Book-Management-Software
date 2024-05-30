using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAO
{
    public class PhieuRutTienDAO
    {
        private PhieuRutTienDAO() { }
        private static PhieuRutTienDAO instance;

        public static PhieuRutTienDAO Instance
        {
            get { if (instance == null) instance = new PhieuRutTienDAO(); return instance; }
            private set { instance = value; }
        }

        public Sotietkiem LaySoBangMaSo(string maso)
        {
            object[] para = { maso };
            string query = "Select * from SOTIETKIEM where Masotietkiem = @maso";
            DataTable sotietkiem = DataProvider.Instance.ExecuteQuery(query, para);
            Sotietkiem stk = null;
            if (sotietkiem.Rows.Count > 0)
            {
                stk = new Sotietkiem(sotietkiem.Rows[0]);
            }
            return stk;
        }

        public Loaitietkiem LayLoaiTietKiemBangMaSo(string maso)
        {
            object[] para = { maso };
            string query = "Select LOAITIETKIEM.* from SOTIETKIEM,LOAITIETKIEM where Masotietkiem = @maso AND SOTIETKIEM.Maloaitietkiem = LOAITIETKIEM.Maloaitietkiem";
            DataTable loaitietkiem = DataProvider.Instance.ExecuteQuery(query, para);
            Loaitietkiem ltk = null;
            if (loaitietkiem.Rows.Count > 0)
            {
                int kyhan = loaitietkiem.Rows[0]["Kyhan"].ToString() == "" ? 0 : (int)loaitietkiem.Rows[0]["Kyhan"];
                bool duocguithem = loaitietkiem.Rows[0]["Duocguithem"].ToString() == "1" ? true : false;
                int tienguithemtoithieu = loaitietkiem.Rows[0]["Tienguithemtoithieu"].ToString() == "" ? 0 : (int)loaitietkiem.Rows[0]["Tienguithemtoithieu"];
                ltk = new Loaitietkiem((int)loaitietkiem.Rows[0]["Maloaitietkiem"], loaitietkiem.Rows[0]["Tenloaitietkiem"].ToString(), (float)(double)loaitietkiem.Rows[0]["Laisuat"], kyhan, (int)loaitietkiem.Rows[0]["Songayduocrut"], duocguithem, (int)loaitietkiem.Rows[0]["Sotienguitoithieu"], tienguithemtoithieu);
            }
            return ltk;
        }

        public bool KiemTraRutTien(string maso, DateTime dt)
        {
            Sotietkiem sotietkiem = LaySoBangMaSo(maso);
            if (sotietkiem != null && sotietkiem.Ngaydongso == null)
            {
                Loaitietkiem loaitietkiem = LayLoaiTietKiemBangMaSo(maso);
                TimeSpan ngay = dt - sotietkiem.Ngaymoso;
                if (ngay.Days >= loaitietkiem.Songayduocrut)
                {
                    return true;
                }
            }
            return false;
        }

        public bool KiemTraRutTien2(string maso, DateTime dt, int tienrut)
        {
            Sotietkiem sotietkiem = LaySoBangMaSo(maso);
            if (sotietkiem != null)
            {
                Loaitietkiem loaitietkiem = LayLoaiTietKiemBangMaSo(maso);
                TimeSpan ngay = dt - sotietkiem.Ngaymoso;
                if (ngay.Days >= loaitietkiem.Songayduocrut && tienrut <= sotietkiem.Sodu)
                {
                    return true;
                }
            }
            return false;
        }
        public int CapNhatSoDu(string maso, int tienrut)
        {
            Sotietkiem sotietkiem = LaySoBangMaSo(maso);
            int tien = sotietkiem.Sodu - tienrut;
            DateTime ngaydongso = DateTime.Now;
            object[] para = { tien, maso };
            string query = "UPDATE SOTIETKIEM SET Sodu = @tien where Masotietkiem = @maso";
            if (tien == 0)
            {
                para = new object[] { tien, ngaydongso, maso };
                query = "UPDATE SOTIETKIEM SET Sodu = @tien , Ngaydongso = @ngaydongso where Masotietkiem = @maso";
            }
            return DataProvider.Instance.ExecuteNonQuery(query, para);
        }

        public double LaiSuat(string maso)
        {
            Loaitietkiem loaitietkiem = LayLoaiTietKiemBangMaSo(maso);
            Sotietkiem sotietkiem = LaySoBangMaSo(maso);
            if (loaitietkiem.Maloaitietkiem != 1)
            {
                TimeSpan t = DateTime.Now - sotietkiem.Ngaymoso;
                int ngay = t.Days;
                int daohan = ngay / loaitietkiem.Kyhan;
                return daohan * sotietkiem.Sotienguibandau * loaitietkiem.Laisuat / 100 * loaitietkiem.Kyhan;
            }
            else
            {
                TimeSpan t = DateTime.Now - sotietkiem.Ngaymoso;
                int ngay = t.Days;
                float tienlai = 0;
                if (ngay > 30)
                {
                    tienlai = sotietkiem.Sodu * loaitietkiem.Laisuat / 100 * ngay;
                }
                return tienlai;
            }
        }
        public void ThemPhieuRutTien(string masotietkiem, string sotienrut, DateTime ngayrut)
        {
            string ngay = ngayrut.ToString("yyyy-MM-dd");
            object[] para = { masotietkiem, sotienrut, ngay };
            string query = "insert PHIEURUTTIEN (Masotietkiem,Sotienrut,Ngayrut) values( @masotietkiem , @sotienrut , @ngay )";
            DataProvider.Instance.ExecuteNonQuery(query, para);
        }
    }
}
