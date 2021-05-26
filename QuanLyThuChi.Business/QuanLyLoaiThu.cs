using QuanLyThuChi.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi.Business
{
    public class QuanLyLoaiThu
    {
        public QuanLyLoaiThu() { }
        private static QuanLyLoaiThu instance;

        public static QuanLyLoaiThu Instance
        {
            get
            {
                if (instance == null)
                    instance = new QuanLyLoaiThu();
                return instance;
            }
        }
        public DataTable DataLoaiThu()
        {
            string query = "select * from LOAITHU";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public List<LoaiThu> ListLoaiThu()
        {
            List<LoaiThu> list = new List<LoaiThu>();
            DataTable data = DataLoaiThu();
            foreach(DataRow item in data.Rows)
            {
                list.Add(new LoaiThu(item));
            }
            return list;
        }
        public LoaiThu LayLoaiThu(int id)
        {
            string query = "select * from LOAITHU where MALOAITHU = @a";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return new LoaiThu(data.Rows[0]);
        }
        public int ThemLoaiThu(LoaiThu lt)
        {
            string query = "insert into LOAITHU(TENLOAITHU) values ( @a )";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { lt.TenLoaiThu });
            query = "select max(MALOAITHU) from LOAITHU";
            int data = (int)DataProvider.Instance.ExecuteScalar(query);
            return data;
        }
        public int SuaLoaiThu(LoaiThu lt)
        {
            string query = "update LOAITHU set TENLOAITHU = @a where MALOAITHU = @b";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { lt.TenLoaiThu, lt.MaLoaiThu });
            return data;
        }
        public int XoaLoaiThu(int id)
        {
            int data = 0;
            string query = "delete from LOAITHU where MALOAITHU = @a";
            data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return data;
        }
    }
}
