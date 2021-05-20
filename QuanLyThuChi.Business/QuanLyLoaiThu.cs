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
    }
}
