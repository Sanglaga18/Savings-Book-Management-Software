using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class MoSoBUS
    {
        private static MoSoBUS instance;

        public static MoSoBUS Instance
        {
            get { if (instance == null) instance = new MoSoBUS(); return instance; }
            private set { instance = value; }
        }

        private MoSoBUS() { }
        public bool insert(Sotietkiem sotietkiem)
        {
            return MoSoDAO.Instance.insertSoMoi(sotietkiem);
        }
        public DataTable getLoaiTietKiem()
        {
            return MoSoDAO.Instance.getLoaiTietKiem();
        }
    }
}
