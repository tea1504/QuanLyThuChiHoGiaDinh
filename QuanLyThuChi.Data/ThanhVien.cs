using System;
using System.Collections.Generic;
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

        public int MaThanhVien { get => maThanhVien; set => maThanhVien = value; }
        public string HoLot { get => hoLot; set => hoLot = value; }
        public string Ten { get => ten; set => ten = value; }
    }
}
