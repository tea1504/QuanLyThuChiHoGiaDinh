using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi.Data
{
    public class Thu
    {
        private int maThu;
        private int maThanhVien;
        private int maLoaiThu;
        private int maTaiKhoan;
        private DateTime ngayThu;
        private float soTienThu;
        private string ghiChuThu;
        private TaiKhoan taiKhoan;
        private LoaiThu loaiThu;
        private ThanhVien thanhVien;

        public int MaThanhVien { get => maThanhVien; set => maThanhVien = value; }
        public int MaLoaiThu { get => maLoaiThu; set => maLoaiThu = value; }
        public int MaTaiKhoan { get => maTaiKhoan; set => maTaiKhoan = value; }
        public DateTime NgayThu { get => ngayThu; set => ngayThu = value; }
        public float SoTienThu { get => soTienThu; set => soTienThu = value; }
        public string GhiChuThu { get => ghiChuThu; set => ghiChuThu = value; }
        public int MaThu { get => maThu; set => maThu = value; }
        public TaiKhoan TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public LoaiThu LoaiThu { get => loaiThu; set => loaiThu = value; }
        public ThanhVien ThanhVien { get => thanhVien; set => thanhVien = value; }

        public Thu()
        {
            MaLoaiThu = 0;
            MaTaiKhoan = 0;
            MaLoaiThu = 0;
            MaThanhVien = 0;
            NgayThu = DateTime.Now;
            SoTienThu = 0f;
            GhiChuThu = null;
        }

        public Thu(int ma, int taiKhoan, int loaiThu, int thanhVien, DateTime ngay, float tien, string ghiChu)
        {
            MaThu = ma;
            MaTaiKhoan = taiKhoan;
            MaThanhVien = thanhVien;
            MaLoaiThu = loaiThu;
            NgayThu = ngay;
            SoTienThu = tien;
            GhiChuThu = ghiChu;
        }

        public Thu(int taiKhoan, int loaiThu, int thanhVien, DateTime ngay, float tien, string ghiChu)
        {
            MaThu = 0;
            MaTaiKhoan = taiKhoan;
            MaThanhVien = thanhVien;
            MaLoaiThu = loaiThu;
            NgayThu = ngay;
            SoTienThu = tien;
            GhiChuThu = ghiChu;
        }

        public Thu(Thu t)
        {
            MaThu = t.MaThu;
            MaTaiKhoan = t.MaTaiKhoan;
            MaThanhVien = t.MaThanhVien;
            MaLoaiThu = t.MaLoaiThu;
            NgayThu = t.NgayThu;
            SoTienThu = t.SoTienThu;
            GhiChuThu = t.GhiChuThu;
        }
        public Thu(DataRow data)
        {
            MaThu = (int)data["MATHU"];
            MaTaiKhoan = (int)data["MATAIKHOAN"];
            MaThanhVien = (int)data["MATHANHVIEN"];
            MaLoaiThu = (int)data["MALOAITHU"];
            NgayThu = DateTime.Parse(data["NGAYTHU"].ToString());
            SoTienThu = (float)(Double.Parse(data["SOTIENTHU"].ToString()));
            GhiChuThu = data["GHICHUTHU"].ToString();
        }
        public override string ToString()
        {
            return "Thông tin thu: \tMTV: " + MaThanhVien 
                + "\tMLT: " + MaLoaiThu 
                + "\tMTK: " + MaTaiKhoan
                + "\tNgay: " + NgayThu
                + "\tTien: " + SoTienThu
                + "\tGhiChu: " + GhiChuThu;
        }
    }
}
