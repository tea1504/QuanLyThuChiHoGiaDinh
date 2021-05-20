using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi.Data
{
    public class ThanhVien
    {
        private int maThanhVien;
        private string hoLot;
        private string ten;
        private DateTime ngaySinh;

        public int MaThanhVien { get => maThanhVien; set => maThanhVien = value; }
        public string HoLot { get => hoLot; set => hoLot = value; }
        public string Ten { get => ten; set => ten = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }

        public ThanhVien()
        {
            MaThanhVien = 0;
            HoLot = "";
            Ten = "";
            NgaySinh = DateTime.Now;
        }
        public ThanhVien(int ma, string ho, string ten, DateTime date)
        {
            MaThanhVien = ma;
            HoLot = ho;
            Ten = ten;
            NgaySinh = date;
        }
        public ThanhVien(string ho, string ten, DateTime date)
        {
            MaThanhVien = 0;
            HoLot = ho;
            Ten = ten;
            NgaySinh = date;
        }
        public ThanhVien(DataRow data)
        {
            MaThanhVien = (int)data["MATHANHVIEN"];
            HoLot = data["HOLOT"].ToString();
            Ten = data["TEN"].ToString();
            NgaySinh = DateTime.Parse(data["NGAYSINH"].ToString());
        }
        public ThanhVien(ThanhVien tv)
        {
            MaThanhVien = tv.MaThanhVien;
            HoLot = tv.HoLot;
            Ten = tv.Ten;
            NgaySinh = tv.NgaySinh;
        }
    }
}
