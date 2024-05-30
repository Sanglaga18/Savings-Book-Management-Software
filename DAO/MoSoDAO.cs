using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MoSoDAO
       
    {
        private static MoSoDAO instance;
        public static MoSoDAO Instance
        {
            get { if (instance == null) instance = new MoSoDAO(); return instance; }
            private set { instance = value; }
        }
        private MoSoDAO() { }
        public bool insertSoMoi(Sotietkiem sotietkiem)
        {

            string query = "EXEC them_thongtin_sotietkiem @Maloaitietkiem , @Tenkhachhang  , @CMND_CCCD , @Diachi , @Ngaymoso , @Sotienguibandau , @Sodu ";
            
            int n = DataProvider.Instance.ExecuteNonQuery(query, new object[]{sotietkiem.Maloaitietkiem, sotietkiem.Tenkhachhang, sotietkiem.CCCD, sotietkiem.Diachi,sotietkiem.Ngaymoso,sotietkiem.Sotienguibandau,sotietkiem.Sodu });
            return n>0;
        }
        public DataTable getLoaiTietKiem()
        {
            return DataProvider.Instance.ExecuteQuery("select Maloaitietkiem,Tenloaitietkiem, Laisuat from LOAITIETKIEM ");
        }
    }
}
