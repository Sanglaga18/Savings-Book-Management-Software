using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
            private set { instance = value; }
        }

        private TaiKhoanDAO() { }

        public bool Login(string userName, string passWord)
        {

            string query = "AccountLogin @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });

            return result.Rows.Count > 0;
        }

        public TaiKhoan GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from TAIKHOAN where Tentaikhoan = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new TaiKhoan(item);
            }

            return null;
        }

        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName , @displayName , @password , @newPassword", new object[] { userName, displayName, pass, newPass });

            return result > 0;

        }

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT ID, Tentaikhoan, Tennguoidung, Loaitaikhoan FROM Taikhoan");
        }

        public bool InsertAccount(string Tentaikhoan, string Tennguoidung, int Loaitaikhoan)
        {
            string query = string.Format("INSERT TAIKHOAN  (Tentaikhoan, Tennguoidung, Loaitaikhoan) VALUES  ( N'{0}', N'{1}', {2})", Tentaikhoan, Tennguoidung, Loaitaikhoan);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(string Tentaikhoan, string Tennguoidung, int Loaitaikhoan, int ID)
        {
            string query = string.Format("UPDATE TAIKHOAN SET Tentaikhoan = N'{0}', Tennguoidung = N'{1}', Loaitaikhoan = {2} WHERE ID = {3}", Tentaikhoan, Tennguoidung, Loaitaikhoan, ID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(int ID)
        {
            string query = string.Format("Delete TAIKHOAN where ID = {0}", ID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool ResetPassword(int ID)
        {
            string query = string.Format("update TAIKHOAN set Matkhau = N'123' where ID = {0}", ID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}