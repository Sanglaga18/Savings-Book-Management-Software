using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
   public class ThayDoiLaiSuatBUS
    {
        private static ThayDoiLaiSuatBUS instance;
        public static ThayDoiLaiSuatBUS Instance
        {
            get { if (instance == null) instance = new ThayDoiLaiSuatBUS(); return instance; }
            private set { instance = value; }
        }
        private ThayDoiLaiSuatBUS() { }
        public bool updateLaiSuat(int maloaitietkiem,int thoigian, float laisuat)
        {
            return ThayDoiLaiSuatDAO.Instance.updateLaiSuat(maloaitietkiem,thoigian, laisuat);
        }
        public DataTable loadSo()
        {
            return ThayDoiLaiSuatDAO.Instance.loadSo();
        }
    }
}
