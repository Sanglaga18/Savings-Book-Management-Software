using DAO;
using System;

namespace BUS
{
    public class LapPhieuGuiBUS
    {
        private static LapPhieuGuiBUS instance;
        public static LapPhieuGuiBUS Instance
        {
            get { if (instance == null) instance = new LapPhieuGuiBUS(); return instance; }
            private set { instance = value; }
        }
        private LapPhieuGuiBUS() { }
        public bool guiThemTien(int maso, int sotien)
        {
            if (LapPhieuGuiDAO.Instance.guiThemTien(maso, sotien))
            {
                
                return true;
            }
            return false;
        }
    
        public string getTenKhachHang(int maso)
        {
            return LapPhieuGuiDAO.Instance.getTenKhachHang(maso);
        }
        public string getSodu(int maso)
        {
            return LapPhieuGuiDAO.Instance.getSodu(maso);
        }
        public bool ktMaSo(int maso)
        {
            return LapPhieuGuiDAO.Instance.ktMaSo(maso);
        }
    }
}
