using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi.Data
{
    public class Chi
    {
        private int maThanhVien;
        private int maLoaiChi;
        private int maTaiKhoan;
        private DateTime ngayChi;
        private float soTienChi;
        private string ghiChuChi;

        public int MaThanhVien { get => maThanhVien; set => maThanhVien = value; }
        public int MaLoaiChi { get => maLoaiChi; set => maLoaiChi = value; }
        public int MaTaiKhoan { get => maTaiKhoan; set => maTaiKhoan = value; }
        public DateTime NgayChi { get => ngayChi; set => ngayChi = value; }
        public float SoTienChi { get => soTienChi; set => soTienChi = value; }
        public string GhiChuChi { get => ghiChuChi; set => ghiChuChi = value; }
    }
}
