using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAO
{
    public class TraCuuSoDAO
    {
        private static TraCuuSoDAO instance;
        public static TraCuuSoDAO Instance
        {
            get { if (instance == null) instance = new TraCuuSoDAO(); return instance; }
            private set { instance = value; }
        }
        private TraCuuSoDAO() { }
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
        public DataTable loadSo()
        {
            DataTable data;
            try
            {
                string query = "select Masotietkiem as N'Mã sổ',Maloaitietkiem as N'Mã loại',Tenkhachhang as N'Khách hàng',Sodu as N'Số dư' from SOTIETKIEM";
                data = DataProvider.Instance.ExecuteQuery(query);
                addSTT(data, 0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
          
            return data;
        }
        public DataTable timKiemSo(string maSo)
        {
            DataTable data;
            try
            {
                string query = "select Masotietkiem as N'Mã sổ',Maloaitietkiem as N'Mã loại',Tenkhachhang as N'Khách hàng',Sodu as N'Số dư' from SOTIETKIEM where Masotietkiem = '" + maSo + "'";
                data = DataProvider.Instance.ExecuteQuery(query);
                addSTT(data, 0);
            }catch(Exception ex)
            {
                throw ex;
            }
        
            return data;
        }
    }
}
