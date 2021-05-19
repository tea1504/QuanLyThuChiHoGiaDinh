using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi.Data
{
    public class Thu
    {
        private int maThanhVien;
        private int maLoaiThu;
        private int maTaiKhoan;
        private DateTime ngayThu;
        private float soTienThu;
        private string ghiChuThu;

        public int MaThanhVien { get => maThanhVien; set => maThanhVien = value; }
        public int MaLoaiThu { get => maLoaiThu; set => maLoaiThu = value; }
        public int MaTaiKhoan { get => maTaiKhoan; set => maTaiKhoan = value; }
        public DateTime NgayThu { get => ngayThu; set => ngayThu = value; }
        public float SoTienThu { get => soTienThu; set => soTienThu = value; }
        public string GhiChuThu { get => ghiChuThu; set => ghiChuThu = value; }
    }
}
