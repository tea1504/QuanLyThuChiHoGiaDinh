using QuanLyThuChi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi.Business
{
    public class QuanLyThu
    {
        public QuanLyThu() { }
        private static QuanLyThu instance;

        public static QuanLyThu Instance { get
            {
                if (instance == null)
                    instance = new QuanLyThu();
                return instance;
            }
        }
        public int LuuThu(Thu t)
        {
            string query = "insert into THU (MATHANHVIEN, MALOAITHU, MATAIKHOAN, SOTIENTHU, NGAYTHU, GHICHUTHU) " +
                "values ( @a , @b , @c , @d , @e , @f )";
            int data;
            if (t.GhiChuThu == null)
            {
                data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { t.MaThanhVien, t.MaLoaiThu, t.MaTaiKhoan,
            t.SoTienThu, t.NgayThu, DBNull.Value});
            }
            else
            {
                data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { t.MaThanhVien, t.MaLoaiThu, t.MaTaiKhoan,
            t.SoTienThu, t.NgayThu, t.GhiChuThu});
            }
            return data;
        }
    }
}
