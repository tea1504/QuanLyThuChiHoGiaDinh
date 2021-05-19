using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi.Data
{
    public class LoaiChi
    {
        private int maLoaiChi;
        private string tenLoaiChi;

        public int MaLoaiChi { get => maLoaiChi; set => maLoaiChi = value; }
        public string TenLoaiChi { get => tenLoaiChi; set => tenLoaiChi = value; }
    }
}
