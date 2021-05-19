using QuanLyThuChi.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi.Business
{
    public class QuanLyThanhVien
    {
        private static QuanLyThanhVien instance;

        public static QuanLyThanhVien Instance {
            get { if (instance == null) instance = new QuanLyThanhVien(); return instance; }
            private set { instance = value; }
        }
        public QuanLyThanhVien() { }
        public DataTable DataThanhVien()
        {
            DataTable data;
            string query = "select MATHANHVIEN, HOLOT, TEN, NGAYSINH from THANHVIEN";
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public int ThemThanhVien(ThanhVien thanhVien)
        {
            string query = "insert into THANHVIEN ( HOLOT , TEN , NGAYSINH) values ( @a , @b , @c )";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { thanhVien.HoLot, thanhVien.Ten, thanhVien.NgaySinh });
            query = "select max(MATHANHVIEN) from THANHVIEN";
            int data = (int)DataProvider.Instance.ExecuteScalar(query);
            return data;
        }
        public int SuaThanhVien(ThanhVien thanhVien)
        {
            string query = "update THANHVIEN set HOLOT = @a , TEN = @b , NGAYSINH = @c where MATHANHVIEN = @d";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { thanhVien.HoLot, thanhVien.Ten, thanhVien.NgaySinh, thanhVien.MaThanhVien });
            return thanhVien.MaThanhVien;
        }
        public int XoaThanhVien(int id)
        {
            string query = "delete from THANHVIEN where MATHANHVIEN = @a";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
        }
    }
}
