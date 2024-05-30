using System;

namespace DAO
{
    public class LapPhieuGuiDAO
    {
        private static LapPhieuGuiDAO instance;
        public static LapPhieuGuiDAO Instance
        {
            get { if (instance == null) instance = new LapPhieuGuiDAO(); return instance; }
            private set { instance = value; }
        }
        private LapPhieuGuiDAO() { }
        public bool guiThemTien(int maso, int sotien)
        {

            string query = "EXEC UpdateSodu @selected_value , @new_value ";
            if (ktDieuKienGui(maso, sotien))
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { maso, sotien });
                DataProvider.Instance.ExecuteNonQuery(String.Format("insert into PHIEUGUITIEN(Masotietkiem,Sotiengui,Ngaygui) values ({0},{1},'{2}')", maso, sotien, DateTime.Now));
                return true;
            }
            return false;
        }
        //public bool insertPhieuGui(int maso, int sotiengui, DateTime ngaygui)
        //{
        //    string query = String.Format("insert into PHIEUGUITIEN(Masotietkiem,Sotiengui,Ngaygui) values ({0},{1},{2})", maso, sotiengui, ngaygui);
        //    int n = DataProvider.Instance.ExecuteNonQuery(query);
        //    return n > 0;
        //}
        public bool ktDieuKienGui(int maso, int sotien)
        {

            if (DataProvider.Instance.ExecuteQuery(String.Format("select * from SOTIETKIEM,LOAITIETKIEM WHERE SOTIETKIEM.Maloaitietkiem=LOAITIETKIEM.Maloaitietkiem and SOTIETKIEM.Masotietkiem={0} and LOAITIETKIEM.Maloaitietkiem=1 and SOTIETKIEM.Ngaydongso is null and Sodu <2000000000\r\n", maso)).Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public bool ktMaSo(int maso)
        {
            return DataProvider.Instance.ExecuteQuery(String.Format("select Tenkhachhang from SOTIETKIEM where Masotietkiem={0}", maso)).Rows.Count > 0;
        }
        public string getTenKhachHang(int maso)
        {

            object name = DataProvider.Instance.ExecuteScalar(String.Format("select Tenkhachhang from SOTIETKIEM where Masotietkiem={0}", maso));
            string ten = name.ToString();
            return ten;


        }
        public string getSodu(int maso)
        {
            object name = DataProvider.Instance.ExecuteScalar(String.Format("select Sodu from SOTIETKIEM where Masotietkiem={0}", maso));


            string sodu = name.ToString();
            int value = int.Parse(sodu);
            sodu = value.ToString("N0") + " vnđ";
            return sodu;
        }
    }
}
