using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThayDoiLaiSuatDAO
    {
        private static ThayDoiLaiSuatDAO instance;
        public static ThayDoiLaiSuatDAO Instance
        {
            get { if (instance == null) instance = new ThayDoiLaiSuatDAO(); return instance; }
            private set { instance = value; }
        }
        private ThayDoiLaiSuatDAO() { }
        public bool updateLaiSuat(int maloaitietkiem,int thoigian, float laisuat)
        {
            string query = "EXEC UpdateLoaiTietKiemWithoutSoTietKiem @Maloaitietkiem , @Songayduocrut , @Laisuat ;";
            return DataProvider.Instance.ExecuteNonQuery(query,new object[] {maloaitietkiem,thoigian*30,laisuat})>0;
        }
        public DataTable loadSo()
        {
            return DataProvider.Instance.ExecuteQuery("select Maloaitietkiem as 'Mã loại tiết kiệm', Songayduocrut as 'Số ngày được rút', Laisuat as 'Lãi suất' from LOAITIETKIEM");
        }
        
    }
}
