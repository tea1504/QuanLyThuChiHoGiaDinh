using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi.Data
{
    public class Chi
    {
        private int maChi;
        private int maThanhVien;
        private int maLoaiChi;
        private int maTaiKhoan;
        private DateTime ngayChi;
        private float soTienChi;
        private string ghiChuChi;

        private ThanhVien thanhVien;
        private LoaiChi loaiChi;
        private TaiKhoan taiKhoan;

        public int MaThanhVien { get => maThanhVien; set => maThanhVien = value; }
        public int MaLoaiChi { get => maLoaiChi; set => maLoaiChi = value; }
        public int MaTaiKhoan { get => maTaiKhoan; set => maTaiKhoan = value; }
        public DateTime NgayChi { get => ngayChi; set => ngayChi = value; }
        public float SoTienChi { get => soTienChi; set => soTienChi = value; }
        public string GhiChuChi { get => ghiChuChi; set => ghiChuChi = value; }
        public int MaChi { get => maChi; set => maChi = value; }
        public ThanhVien ThanhVien { get => thanhVien; set => thanhVien = value; }
        public LoaiChi LoaiChi { get => loaiChi; set => loaiChi = value; }
        public TaiKhoan TaiKhoan { get => taiKhoan; set => taiKhoan = value; }

        public Chi()
        {
            MaChi = 0;
            MaThanhVien = 0;
            MaLoaiChi = 0;
            MaTaiKhoan = 0;
            NgayChi = DateTime.Now;
            SoTienChi = 0f;
            GhiChuChi = null;
        }
        public Chi(DataRow data)
        {
            MaChi = (int)data["MACHI"];
            MaThanhVien = (int)data["MATHANHVIEN"];
            MaLoaiChi = (int)data["MALOAICHI"];
            MaTaiKhoan = (int)data["MATAIKHOAN"];
            NgayChi = DateTime.Parse(data["NGAYCHI"].ToString());
            SoTienChi = (float)Double.Parse(data["SOTIENCHI"].ToString());
            GhiChuChi = data["GHICHUCHI"].ToString();
        }
    }
}
