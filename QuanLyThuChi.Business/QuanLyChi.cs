using QuanLyThuChi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi.Business
{
    public class QuanLyChi
    {
        public QuanLyChi() { }
        private static QuanLyChi instance;

        public static QuanLyChi Instance { 
            get 
            {
                if (instance == null)
                    instance = new QuanLyChi();
                return instance;
            }
        }
        public int LuuChi(Chi c)
        {
            string query = "insert into CHI (MATHANHVIEN, MALOAICHI, MATAIKHOAN, SOTIENCHI, NGAYCHI, GHICHUCHI) " +
                "values ( @a , @b , @c , @d , @e , @f )";
            int data;
            if (c.GhiChuChi == null)
            {
                data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { c.MaThanhVien, c.MaLoaiChi, c.MaTaiKhoan,
            c.SoTienChi, c.NgayChi, DBNull.Value});
            }
            else
            {
                data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { c.MaThanhVien, c.MaLoaiChi, c.MaTaiKhoan,
            c.SoTienChi, c.NgayChi, c.GhiChuChi});
            }
            return data;
        }
    }
}
