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
    }
}
