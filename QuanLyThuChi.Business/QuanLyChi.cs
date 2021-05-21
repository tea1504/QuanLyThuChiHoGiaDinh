using QuanLyThuChi.Data;
using System;
using System.Collections.Generic;
using System.Data;
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
        public List<Chi> ListChiHomNay()
        {
            List<Chi> list = new List<Chi>();
            string query = "select a.* from CHI a where DATEDIFF(DD,a.NGAYCHI, GETDATE()) = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Chi temp = new Chi(item);
                temp.LoaiChi = QuanLyLoaiChi.Instance.LayLoaiChi(temp.MaLoaiChi);
                temp.TaiKhoan = QuanLyTaiKhoan.Instance.LayTaiKhoan(temp.MaTaiKhoan);
                temp.ThanhVien = QuanLyThanhVien.Instance.LayThanhVien(temp.MaThanhVien);
                list.Add(temp);
            }
            return list;
        }
        public float TongChi()
        {
            string query = "select sum(SOTIENCHI) from CHI";
            float data = (float)((double)DataProvider.Instance.ExecuteScalar(query));
            return data;
        }
        public List<Chi> LayChiTheoThanhVien(int id)
        {
            List<Chi> list = new List<Chi>();
            string query = "select * from Chi where MATHANHVIEN = @a";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                Chi t = new Chi(item);
                t.ThanhVien = QuanLyThanhVien.Instance.LayThanhVien(t.MaThanhVien);
                t.LoaiChi = QuanLyLoaiChi.Instance.LayLoaiChi(t.MaLoaiChi);
                t.TaiKhoan = QuanLyTaiKhoan.Instance.LayTaiKhoan(t.MaTaiKhoan);
                list.Add(t);
            }
            return list;
        }
        public List<Chi> LayChiTongHop(int tv_id, int tk_id, int lc_id, DateTime tu, DateTime den, bool chose)
        {
            List<Chi> list = new List<Chi>();
            string query = "select * from CHI where 1=1 ";
            List<object> listo = new List<object>();
            if (tv_id != 0)
            {
                query += " and MATHANHVIEN = @a ";
                listo.Add(tv_id);
            }
            if (tk_id != 0)
            {
                query += " and MATAIKHOAN = @b ";
                listo.Add(tk_id);
            }
            if (lc_id != 0)
            {
                query += " and MALOAICHI = @c ";
                listo.Add(lc_id);
            }
            if (chose)
            {
                query += " and NGAYCHI between @d and @e ";
                listo.Add(tu);
                listo.Add(den);
            }
            DataTable data = DataProvider.Instance.ExecuteQuery(query, listo.ToArray());
            foreach (DataRow item in data.Rows)
            {
                Chi c = new Chi(item);
                c.LoaiChi = QuanLyLoaiChi.Instance.LayLoaiChi(c.MaLoaiChi);
                c.ThanhVien = QuanLyThanhVien.Instance.LayThanhVien(c.MaThanhVien);
                c.TaiKhoan = QuanLyTaiKhoan.Instance.LayTaiKhoan(c.MaTaiKhoan);
                list.Add(c);
            }
            return list;
        }
    }
}
