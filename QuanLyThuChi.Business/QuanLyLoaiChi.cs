using QuanLyThuChi.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi.Business
{
    public class QuanLyLoaiChi
    {
        public QuanLyLoaiChi() { }
        private static QuanLyLoaiChi instance;
        public static QuanLyLoaiChi Instance
        {
            get
            {
                if (instance == null)
                    instance = new QuanLyLoaiChi();
                return instance;
            }
        }
        public DataTable DataLoaiChi()
        {
            string query = "select * from LOAICHI";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public List<LoaiChi> ListLoaiChi()
        {
            List<LoaiChi> list = new List<LoaiChi>();
            DataTable data = DataLoaiChi();
            foreach(DataRow item in data.Rows)
            {
                list.Add(new LoaiChi(item));
            }
            return list;
        }
        public LoaiChi LayLoaiChi(int id)
        {
            string query = "select * from LOAICHI where MALOAICHI = @a";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return new LoaiChi(data.Rows[0]);
        }
        public int ThemLoaiChi(LoaiChi lc)
        {
            int data = 0;
            string query = "insert into LOAICHI(TENLOAICHI) values ( @a )";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { lc.TenLoaiChi });
            query = "select max(MALOAICHI) from LOAICHI";
            data = (int)DataProvider.Instance.ExecuteScalar(query);
            return data;
        }
        public int SuaLoaiChi(LoaiChi lc)
        {
            string query = "update LOAICHI set TENLOAICHI = @a where MALOAICHI = @b";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { lc.TenLoaiChi, lc.MaLoaiChi });
            return data;
        }
        public int XoaLoaiChi(int id)
        {
            int data = 0;
            string query = "delete from LOAICHI where MALOAICHI = @a";
            data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return data;
        }
    }
}
