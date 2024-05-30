using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class ThayDoiKyHanDAO
    {
        private ThayDoiKyHanDAO() { }
        private static ThayDoiKyHanDAO instance;

        public static ThayDoiKyHanDAO Instance
        {
            get { if (instance == null) instance = new ThayDoiKyHanDAO(); return instance; }
            private set { instance = value; }
        }
        public DataTable KyHan()
        {
            return DataProvider.Instance.ExecuteQuery("Select Maloaitietkiem,Kyhan,Sotienguitoithieu from LOAITIETKIEM");
        }
        public List<string> MaLoaiTietKiem()
        {
            DataTable dataTable = KyHan();
            List<string> list = new List<string>();
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(row["Maloaitietkiem"].ToString());
            }
            return list;
        }
        public void ThayDoiTienGuiToiThieu(string maloaitietkiem, string tien)
        {
            object[] para = { tien, maloaitietkiem };
            string query = "UPDATE LOAITIETKIEM Set Sotienguitoithieu = @tien where Maloaitietkiem = @maloaitietkiem";
            DataProvider.Instance.ExecuteNonQuery(query, para);
        }
        public void ThemLoaiTietKiem(string laisuat, string kyhan, string tien)
        {
            if (kyhan != "0")
            {
                double ls = int.Parse(laisuat) * 1.0 / 100;
                int kh = int.Parse(kyhan) * 30;
                string tenloaitietkiem = kyhan + " tháng";
                int songayduocrut = kh + 1;
                object[] para = { tenloaitietkiem, ls, kh, songayduocrut, tien };
                string query = "insert LOAITIETKIEM (Tenloaitietkiem,Laisuat,Kyhan,Songayduocrut,Duocguithem,Sotienguitoithieu,Tienguithemtoithieu) values ( @tenloaitietkiem , @ls , @kh , @songayduocrut , 0 , @tien ,0)";
                DataProvider.Instance.ExecuteNonQuery(query, para);
            }
            else
            {
                double ls = int.Parse(laisuat) * 1.0 / 100;
                object[] para = { ls, tien };
                string query = "insert LOAITIETKIEM (Tenloaitietkiem,Laisuat,Kyhan,Songayduocrut,Duocguithem,Sotienguitoithieu,Tienguithemtoithieu) values (N'Không kỳ hạn', @ls ,0,15,1, @tien ,100000)";
                DataProvider.Instance.ExecuteNonQuery(query, para);
            }
        }
    }
}
