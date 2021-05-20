using System;
using System.Collections.Generic;
using System.Data;
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

        public LoaiChi(DataRow data)
        {
            MaLoaiChi = (int)data["MALOAICHI"];
            TenLoaiChi = data["TENLOAICHI"].ToString();
        }
    }
}
