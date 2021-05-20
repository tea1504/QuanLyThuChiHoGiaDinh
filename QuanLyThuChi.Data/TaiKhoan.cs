using System;
using System.Collections.Generic;
using System.Data;
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
        public TaiKhoan()
        {
            MaTaiKhoan = 0;
            TenTaiKhoan = "";
        }
        public TaiKhoan(int ma, string ten)
        {
            MaTaiKhoan = ma;
            TenTaiKhoan = ten;
        }
        public TaiKhoan(string ten)
        {
            MaTaiKhoan = 0;
            TenTaiKhoan = ten;
        }
        public TaiKhoan(DataRow data)
        {
            MaTaiKhoan = (int)data["MATAIKHOAN"];
            TenTaiKhoan = data["TENTAIKHOAN"].ToString();
        }
        public TaiKhoan(TaiKhoan tk)
        {
            MaTaiKhoan = tk.MaTaiKhoan;
            TenTaiKhoan = tk.TenTaiKhoan;
        }
    }
}
