using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LapBaoCaoDongMoDAO
    {
        private static LapBaoCaoDongMoDAO instance;
        public static LapBaoCaoDongMoDAO Instance
        {
            get { if (instance == null) instance = new LapBaoCaoDongMoDAO(); return instance; }
            private set { instance = value; }
        }
        private LapBaoCaoDongMoDAO() { }
        public DataTable lapBaoCaoDongMo(string month,string year, string loaitietkiem)
        {

            string query = "EXEC GetSOTIETKIEMByMonthYearAndMaloaitietkiem @thang , @nam , @maloaitietkiem ";
            DataTable data= DataProvider.Instance.ExecuteQuery(query, new object[] {month,year,loaitietkiem});
            addSTT(data, 0);
            return data;
        }
        public DataTable getLoaiTietKiem()
        {
            return DataProvider.Instance.ExecuteQuery("select Maloaitietkiem,Tenloaitietkiem from LOAITIETKIEM ");
        }
        private void addSTT(DataTable data, int index)
        {
            // tạo một cột tên "STT" kiểu int và set vị trí của nó tại index
            data.Columns.Add("STT", typeof(int)).SetOrdinal(index);

            // đánh số cho từng dòng của "STT"
            for (int i = 0; i < data.Rows.Count; i++)
            {
                data.Rows[i]["STT"] = i + 1;
            }

        }
    }
}
