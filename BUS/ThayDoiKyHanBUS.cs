using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BUS
{
    public class ThayDoiKyHanBUS
    {
        private ThayDoiKyHanBUS() { }
        private static ThayDoiKyHanBUS instance;
        public static ThayDoiKyHanBUS Instance
        {
            get { if (instance == null) instance = new ThayDoiKyHanBUS(); return instance; }
            private set { instance = value; }
        }
        public DataTable KyHan()
        {
            return ThayDoiKyHanDAO.Instance.KyHan();
        }
        public List<string> MaLoaiTietKiem()
        {
            return ThayDoiKyHanDAO.Instance.MaLoaiTietKiem();
        }
        public void ThayDoiTienGuiToiThieu(string maloaitietkiem, string tien)
        {
            ThayDoiKyHanDAO.Instance.ThayDoiTienGuiToiThieu(maloaitietkiem, tien);
        }
        public void ThemLoaiTietKiem(string laisuat, string kyhan, string tien)
        {
            ThayDoiKyHanDAO.Instance.ThemLoaiTietKiem(laisuat, kyhan, tien);
        }
    }
}
