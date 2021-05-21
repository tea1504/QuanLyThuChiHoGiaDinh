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
    public partial class ucTimKiemTongHop : UserControl
    {
        DataSet data = new DataSet();
        DataTable temp;
        List<Thu> listThu;
        List<Chi> listChi;
        float tongTien;
        public ucTimKiemTongHop()
        {
            InitializeComponent();
        }

        private void ucTimKiemTongHop_Load(object sender, EventArgs e)
        {
            dtpTu.MaxDate = DateTime.Now;
            dtpDen.MaxDate = DateTime.Now;
            dtpDen.MinDate = dtpTu.Value;
            rdoThu.Checked = true;
            data.Tables.Add("ThanhVien");
            data.Tables["ThanhVien"].Columns.Add("ma");
            data.Tables["ThanhVien"].Columns.Add("ten");
            data.Tables["ThanhVien"].Rows.Add("0", "Chọn tất cả");
            data.Tables.Add("TaiKhoan");
            data.Tables["TaiKhoan"].Columns.Add("ma");
            data.Tables["TaiKhoan"].Columns.Add("ten");
            data.Tables["TaiKhoan"].Rows.Add("0", "Chọn tất cả");
            data.Tables.Add("TheLoai");
            data.Tables["TheLoai"].Columns.Add("ma");
            data.Tables["TheLoai"].Columns.Add("ten");
            SetupThanVien();
            SetupTaiKhoan();
            SetupLoaiThu();
        }

        void SetupThanVien()
        {
            temp = QuanLyThanhVien.Instance.DataThanhVien();
            foreach (DataRow item in temp.Rows)
            {
                data.Tables["ThanhVien"].Rows.Add(item["MATHANHVIEN"].ToString(), item["HOLOT"] + " " + item["TEN"]);
            }
            cboThanhVien.DataSource = data.Tables["ThanhVien"];
            cboThanhVien.DisplayMember = "ten";
            cboThanhVien.ValueMember = "ma";
        }
        void SetupTaiKhoan()
        {
            temp = QuanLyTaiKhoan.Instance.DataTaiKhoan();
            foreach(DataRow item in temp.Rows)
            {
                data.Tables["TaiKhoan"].Rows.Add(item["MATAIKHOAN"].ToString(), item["TENTAIKHOAN"].ToString());
            }
            cboTaiKhoan.DataSource = data.Tables["TaiKhoan"];
            cboTaiKhoan.DisplayMember = "ten";
            cboTaiKhoan.ValueMember = "ma";
        }
        void SetupLoaiChi()
        {
            temp = QuanLyLoaiChi.Instance.DataLoaiChi();
            data.Tables["TheLoai"].Rows.Clear();
            data.Tables["TheLoai"].Rows.Add("0", "Chọn tất cả");
            foreach (DataRow item in temp.Rows)
            {
                data.Tables["TheLoai"].Rows.Add(item["MALOAICHI"].ToString(), item["TENLOAICHI"].ToString());
            }
            cboTheLoai.DataSource = data.Tables["TheLoai"];
            cboTheLoai.DisplayMember = "ten";
            cboTheLoai.ValueMember = "ma";
        }
        void SetupLoaiThu()
        {
            temp = QuanLyLoaiThu.Instance.DataLoaiThu();
            data.Tables["TheLoai"].Rows.Clear();
            data.Tables["TheLoai"].Rows.Add("0", "Chọn tất cả");
            foreach (DataRow item in temp.Rows)
            {
                data.Tables["TheLoai"].Rows.Add(item["MALOAITHU"].ToString(), item["TENLOAITHU"].ToString());
            }
            cboTheLoai.DataSource = data.Tables["TheLoai"];
            cboTheLoai.DisplayMember = "ten";
            cboTheLoai.ValueMember = "ma";
        }
        private void dtpTu_ValueChanged(object sender, EventArgs e)
        {
            dtpDen.MinDate = dtpTu.Value;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tongTien = 0f;
            listKq.Items.Clear();
            if (rdoThu.Checked)
            {
                lbTong.ForeColor = Color.Teal;
                listThu = QuanLyThu.Instance.LayThuTongHop(Int32.Parse(cboThanhVien.SelectedValue.ToString()),
                    Int32.Parse(cboTaiKhoan.SelectedValue.ToString()),
                    Int32.Parse(cboTheLoai.SelectedValue.ToString()),
                    dtpTu.Value, dtpDen.Value, chkChonTheoNgay.Checked);
                foreach (Thu item in listThu)
                {
                    ListViewItem listViewItem = new ListViewItem(item.NgayThu.ToString("dd/MM/yyyy"));
                    listViewItem.SubItems.Add(item.LoaiThu.TenLoaiThu);
                    listViewItem.SubItems.Add(item.GhiChuThu);
                    listViewItem.SubItems.Add(item.TaiKhoan.TenTaiKhoan);
                    listViewItem.SubItems.Add(item.SoTienThu.ToString("#,###.0"));
                    listViewItem.SubItems.Add(item.ThanhVien.HoLot + " " + item.ThanhVien.Ten);
                    listKq.Items.Add(listViewItem);
                    tongTien += item.SoTienThu;
                }
            }
            else
            {
                lbTong.ForeColor = Color.Brown;
                listChi = QuanLyChi.Instance.LayChiTongHop(Int32.Parse(cboThanhVien.SelectedValue.ToString()),
                    Int32.Parse(cboTaiKhoan.SelectedValue.ToString()),
                    Int32.Parse(cboTheLoai.SelectedValue.ToString()),
                    dtpTu.Value, dtpDen.Value, chkChonTheoNgay.Checked);
                foreach (Chi item in listChi)
                {
                    ListViewItem listViewItem = new ListViewItem(item.NgayChi.ToString("dd/MM/yyyy"));
                    listViewItem.SubItems.Add(item.LoaiChi.TenLoaiChi);
                    listViewItem.SubItems.Add(item.GhiChuChi);
                    listViewItem.SubItems.Add(item.TaiKhoan.TenTaiKhoan);
                    listViewItem.SubItems.Add(item.SoTienChi.ToString("#,###.0"));
                    listViewItem.SubItems.Add(item.ThanhVien.HoLot + " " + item.ThanhVien.Ten);
                    listKq.Items.Add(listViewItem);
                    tongTien += item.SoTienChi;
                }
            }
            lbTong.Text = tongTien.ToString("#,##0.0");
        }

        private void rdoThu_Click(object sender, EventArgs e)
        {
            SetupLoaiThu();
        }

        private void rdoChi_Click(object sender, EventArgs e)
        {
            SetupLoaiChi();
        }
    }
}
