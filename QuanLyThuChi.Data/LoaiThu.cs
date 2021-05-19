using System;
using System.Collections.Generic;
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
    }
}
