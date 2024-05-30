using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LapBaoCaoNgayDAO
    {
        private static LapBaoCaoNgayDAO instance;
        private LapBaoCaoNgayDAO() { }
        public static LapBaoCaoNgayDAO Instance
        {
            get { if (instance == null) instance = new LapBaoCaoNgayDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable BaoCaoNgay(DateTime dt)
        {
            string ngay = dt.ToString("yyyy-MM-dd");
            string query = "select ROW_NUMBER() OVER (ORDER BY Tenloaitietkiem) AS 'stt',*,(TongThu-TongChi)as'ChenhLech' from (select LOAITIETKIEM.Tenloaitietkiem,isnull(tongchi,0)as'TongChi', isnull (tongthu,0) as 'TongThu' from(LOAITIETKiem left join (Select Tenloaitietkiem,sum(PHIEURUTTIEN.Sotienrut) as 'TongChi' from LOAITIETKIEM,SOTIETKIEM,PHIEURUTTIEN where LOAITIETKIEM.Maloaitietkiem = SOTIETKIEM.Maloaitietkiem and SOTIETKIEM.Masotietkiem = PHIEURUTTIEN.Masotietkiem and PHIEURUTTIEN.Ngayrut = '" + ngay + "' group by Tenloaitietkiem) as BangAo on LOAITIETKIEM.Tenloaitietkiem = BangAo.Tenloaitietkiem) left join (Select Tenloaitietkiem,sum(PHIEUGUITIEN.Sotiengui) as 'TongThu' from LOAITIETKIEM,SOTIETKIEM,PHIEUGUITIEN where LOAITIETKIEM.Maloaitietkiem = SOTIETKIEM.Maloaitietkiem and SOTIETKIEM.Masotietkiem = PHIEUGUITIEN.Masotietkiem and PHIEUGUITIEN.Ngaygui = '" + ngay + "' group by Tenloaitietkiem) as BangAo2 on LOAITIETKIEM.Tenloaitietkiem = BangAo2.Tenloaitietkiem) as BangAo";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
