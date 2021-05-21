using QuanLyThuChi.Business;
using QuanLyThuChi.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuChi.Presentation
{
    public partial class frmHome : Form
    {
        float tongChi = 0f, tongThu = 0f, tongcong = 0f;
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            List<Chi> listChi = new List<Chi>();
            listChi = QuanLyChi.Instance.ListChiHomNay();
            foreach(Chi item in listChi)
            {
                ListViewItem listViewItem = new ListViewItem(item.LoaiChi.TenLoaiChi);
                listViewItem.SubItems.Add(item.GhiChuChi);
                listViewItem.SubItems.Add(item.TaiKhoan.TenTaiKhoan);
                listViewItem.SubItems.Add(item.ThanhVien.HoLot + " " + item.ThanhVien.Ten);
                listViewItem.SubItems.Add(item.SoTienChi.ToString("#,###.0"));
                lvChi.Items.Add(listViewItem);
            }
            List<Thu> listThu = new List<Thu>();
            listThu = QuanLyThu.Instance.ListThuHomNay();
            foreach(Thu item in listThu)
            {
                ListViewItem listViewItem = new ListViewItem(item.LoaiThu.TenLoaiThu);
                listViewItem.SubItems.Add(item.GhiChuThu);
                listViewItem.SubItems.Add(item.TaiKhoan.TenTaiKhoan);
                listViewItem.SubItems.Add(item.ThanhVien.HoLot + " " + item.ThanhVien.Ten);
                listViewItem.SubItems.Add(item.SoTienThu.ToString("#,###.0"));
                lvThu.Items.Add(listViewItem);
            }
            tongChi = QuanLyChi.Instance.TongChi();
            tongThu = QuanLyThu.Instance.TongThu();
            tongcong = tongThu - tongChi;
            lbChi.Text = tongChi.ToString("#,###.0");
            lbChi.AutoSize = false;
            lbChi.TextAlign = ContentAlignment.MiddleRight;
            lbThu.Text = tongThu.ToString("#,###.0");
            lbCong.Text = tongcong.ToString("#,###.0");
        }
    }
}
