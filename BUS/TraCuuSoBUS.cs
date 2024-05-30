using DAO;
using System.Data;

namespace BUS
{
    public class TraCuuSoBUS
    {
        private static TraCuuSoBUS instance;

        public static TraCuuSoBUS Instance
        {
            get { if (instance == null) instance = new TraCuuSoBUS(); return instance; }
            private set { instance = value; }
        }

        public DataTable loadSo()
        {
            return TraCuuSoDAO.Instance.loadSo();

        }
        public DataTable timKiemSo(string maSo)
        {
            return TraCuuSoDAO.Instance.timKiemSo(maSo);
        }



    }
}
