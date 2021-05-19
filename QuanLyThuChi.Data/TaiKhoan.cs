using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi.Data
{
    public class TaiKhoan
    {
        private int maTaiKhoan;
        private string tenTaiKhoan;
        public int MaTaiKhoan { get => maTaiKhoan; set => maTaiKhoan = value; }
        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
    }
}
