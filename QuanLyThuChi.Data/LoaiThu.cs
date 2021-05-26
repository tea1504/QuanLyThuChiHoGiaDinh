using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi.Data
{
    public class LoaiThu
    {
        private int maLoaiThu;
        private string tenLoaiThu;

        public int MaLoaiThu { get => maLoaiThu; set => maLoaiThu = value; }
        public string TenLoaiThu { get => tenLoaiThu; set => tenLoaiThu = value; }
        public LoaiThu(DataRow data)
        {
            MaLoaiThu = (int)data["MALOAITHU"];
            TenLoaiThu = data["TENLOAITHU"].ToString();
        }
        public LoaiThu(string ten)
        {
            MaLoaiThu = 0;
            TenLoaiThu = ten;
        }
        public LoaiThu(int ma, string ten)
        {
            MaLoaiThu = ma;
            TenLoaiThu = ten;
        }
    }
}
