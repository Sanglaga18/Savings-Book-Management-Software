using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuRutTienBUS
    {
        private PhieuRutTienBUS() { }
        private static PhieuRutTienBUS instance;
        public static PhieuRutTienBUS Instance
        {
            get { if (instance == null) instance = new PhieuRutTienBUS(); return instance; }
            private set { instance = value; }
        }
        public Sotietkiem LaySoBangMaSo(string maso)
        {
            return PhieuRutTienDAO.Instance.LaySoBangMaSo(maso);
        }
        public Loaitietkiem LayLoaiTietKiemBangMaSo(string maso)
        {
            return PhieuRutTienDAO.Instance.LayLoaiTietKiemBangMaSo(maso);
        }
        public bool KiemTraRutTien(string maso, DateTime dt)
        {
            return PhieuRutTienDAO.Instance.KiemTraRutTien(maso, dt);
        }
        public bool KiemTraRutTien2(string maso, DateTime dt, int tienrut)
        {
            return PhieuRutTienDAO.Instance.KiemTraRutTien2(maso, dt, tienrut);
        }
        public int CapNhatSoDu(string maso, int tienrut)
        {
            return PhieuRutTienDAO.Instance.CapNhatSoDu(maso, tienrut);
        }
        public double LaiSuat(string maso)
        {
            return PhieuRutTienDAO.Instance.LaiSuat(maso);
        }
        public void ThemPhieuRutTien(string masotietkiem, string sotienrut, DateTime ngayrut)
        {
            PhieuRutTienDAO.Instance.ThemPhieuRutTien(masotietkiem, sotienrut, ngayrut);
        }
    }
}
