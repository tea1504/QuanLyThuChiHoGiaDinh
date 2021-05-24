using QuanLyThuChi.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi.Business
{
    public class QuanLyTaiKhoan
    {
        private static QuanLyTaiKhoan instance;

        public static QuanLyTaiKhoan Instance {
            get
            {
                if (instance == null)
                    instance = new QuanLyTaiKhoan();
                return instance;
            }
        }

        public QuanLyTaiKhoan() { }
        public DataTable DataTaiKhoan()
        {
            string query = "select * from TAIKHOAN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public List<TaiKhoan> ListTaiKhoan()
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            DataTable data = DataTaiKhoan();
            foreach(DataRow item in data.Rows)
            {
                list.Add(new TaiKhoan(item));
            }
            return list;
        }
        public int ThemTaiKhoan(TaiKhoan tk)
        {
            int data = 0;
            string query = "insert into TAIKHOAN(TENTAIKHOAN) values ( @a )";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { tk.TenTaiKhoan });
            query = "select max(MATAIKHOAN) from TAIKHOAN";
            data = (int)DataProvider.Instance.ExecuteScalar(query);
            return data;
        }
        public TaiKhoan LayTaiKhoan(int id)
        {
            string query = "select * from TAIKHOAN where MATAIKHOAN = @a";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return new TaiKhoan(data.Rows[0]);
        }
        public int SuaTaiKhoan(TaiKhoan tk)
        {
            string query = "update TAIKHOAN set TENTAIKHOAN = @a where MATAIKHOAN = @b";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tk.TenTaiKhoan, tk.MaTaiKhoan });
            return data;
        }
        public int XoaTaiKhoan(int id)
        {
            int data = 0;
            string query = "delete from TAIKHOAN where MATAIKHOAN = @a";
            data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return data;
        }
    }
}
