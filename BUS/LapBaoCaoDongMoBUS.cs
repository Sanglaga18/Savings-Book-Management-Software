using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LapBaoCaoDongMoBUS
    {
        private static LapBaoCaoDongMoBUS instance;
        public static LapBaoCaoDongMoBUS Instance
        {
            get { if (instance == null) instance = new LapBaoCaoDongMoBUS(); return instance; }
            private set { instance = value; }
        }
        private LapBaoCaoDongMoBUS() { }
        public DataTable getLoaiTietKiem()
        {
            return LapBaoCaoDongMoDAO.Instance.getLoaiTietKiem();
        }
        public DataTable lapBaoCaoDongMo(string month,string year, string loaitietkiem)
        {
            return LapBaoCaoDongMoDAO.Instance.lapBaoCaoDongMo(month,year,loaitietkiem);
        }
    }
}
