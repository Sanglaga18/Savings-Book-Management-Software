using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class LapBaoCaoNgayBUS
    {
        private static LapBaoCaoNgayBUS instance;
        private LapBaoCaoNgayBUS() { }
        public static LapBaoCaoNgayBUS Instance
        {
            get { if (instance == null) instance = new LapBaoCaoNgayBUS(); return instance; }
            private set { instance = value; }
        }
        public DataTable BaoCaoNgay(DateTime dt)
        {
            return LapBaoCaoNgayDAO.Instance.BaoCaoNgay(dt);
        }
    }
}
