using QuanLyThuChi.Data;
using System;
using System.Collections.Generic;
using System.Data;
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
        public List<Thu> ListThuHomNay()
        {
            List<Thu> list = new List<Thu>();
            string query = "select a.* from THU a where DATEDIFF(DD,a.NGAYTHU, GETDATE()) = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Thu temp = new Thu(item);
                temp.LoaiThu = QuanLyLoaiThu.Instance.LayLoaiThu(temp.MaLoaiThu);
                temp.TaiKhoan = QuanLyTaiKhoan.Instance.LayTaiKhoan(temp.MaTaiKhoan);
                temp.ThanhVien = QuanLyThanhVien.Instance.LayThanhVien(temp.MaThanhVien);
                list.Add(temp);
            }
            return list;
        }
        public float TongThu()
        {
            string query = "select sum(SOTIENTHU) from THU";
            float data = (float)((double)DataProvider.Instance.ExecuteScalar(query));
            return data;
        }
        public List<Thu> LayThuTheoThanhVien(int id)
        {
            List<Thu> list = new List<Thu>();
            string query = "select * from THU where MATHANHVIEN = @a";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            foreach(DataRow item in data.Rows)
            {
                Thu t = new Thu(item);
                t.ThanhVien = QuanLyThanhVien.Instance.LayThanhVien(t.MaThanhVien);
                t.LoaiThu = QuanLyLoaiThu.Instance.LayLoaiThu(t.MaLoaiThu);
                t.TaiKhoan = QuanLyTaiKhoan.Instance.LayTaiKhoan(t.MaTaiKhoan);
                list.Add(t);
            }
            return list;
        }
        public List<Thu> LayThuTongHop(int tv_id, int tk_id, int lt_id, DateTime tu, DateTime den, bool chose)
        {
            List<Thu> list = new List<Thu>();
            string query = "select * from THU where 1=1 ";
            List<object> listo = new List<object>();
            if (tv_id != 0)
            {
                query += " and MATHANHVIEN = @a ";
                listo.Add(tv_id);
            }
            if(tk_id != 0)
            {
                query += " and MATAIKHOAN = @b ";
                listo.Add(tk_id);
            }
            if(lt_id != 0)
            {
                query += " and MALOAITHU = @c ";
                listo.Add(lt_id);
            }
            if (chose)
            {
                query += " and NGAYTHU between @d and @e ";
                listo.Add(tu);
                listo.Add(den);
            }
            DataTable data = DataProvider.Instance.ExecuteQuery(query, listo.ToArray());
            foreach(DataRow item in data.Rows)
            {
                Thu t = new Thu(item);
                t.LoaiThu = QuanLyLoaiThu.Instance.LayLoaiThu(t.MaLoaiThu);
                t.ThanhVien = QuanLyThanhVien.Instance.LayThanhVien(t.MaThanhVien);
                t.TaiKhoan = QuanLyTaiKhoan.Instance.LayTaiKhoan(t.MaTaiKhoan);
                list.Add(t);
            }
            return list;
        }
    }
}
