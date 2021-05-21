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
    public partial class ucTimKiemTCThanhVien : UserControl
    {
        DataTable dataThanhVien = new DataTable(), temp;
        float tongTien = 0f;
        List<Thu> listThu;
        List<Chi> listChi;
        public ucTimKiemTCThanhVien()
        {
            InitializeComponent();
        }
        bool check()
        {
            if (cboThanhVien.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("Bạn phải chọn thành viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (check())
            {
                tongTien = 0f;
                listKq.Items.Clear();
                if (rdoThu.Checked)
                {
                    listThu = QuanLyThu.Instance.LayThuTheoThanhVien(Int32.Parse(cboThanhVien.SelectedValue.ToString()));
                    foreach (Thu item in listThu)
                    {
                        ListViewItem listViewItem = new ListViewItem(item.NgayThu.ToString("dd/MM/yyyy"));
                        listViewItem.SubItems.Add(item.LoaiThu.TenLoaiThu);
                        listViewItem.SubItems.Add(item.GhiChuThu);
                        listViewItem.SubItems.Add(item.TaiKhoan.TenTaiKhoan);
                        listViewItem.SubItems.Add(item.SoTienThu.ToString("#,###.0"));
                        listKq.Items.Add(listViewItem);
                        tongTien += item.SoTienThu;
                    }
                    lbTong.ForeColor = Color.Teal;
                }
                else
                {
                    listChi = QuanLyChi.Instance.LayChiTheoThanhVien(Int32.Parse(cboThanhVien.SelectedValue.ToString()));
                    foreach(Chi item in listChi)
                    {
                        ListViewItem listViewItem = new ListViewItem(item.NgayChi.ToString("dd/MM/yyyy"));
                        listViewItem.SubItems.Add(item.LoaiChi.TenLoaiChi);
                        listViewItem.SubItems.Add(item.GhiChuChi);
                        listViewItem.SubItems.Add(item.TaiKhoan.TenTaiKhoan);
                        listViewItem.SubItems.Add(item.SoTienChi.ToString("#,###.0"));
                        listKq.Items.Add(listViewItem);
                        tongTien += item.SoTienChi;
                    }
                    lbTong.ForeColor = Color.Brown;
                }
                lbTong.Text = tongTien.ToString("#,##0.0");
            }
        }

        private void ucTimKiemTCThanhVien_Load(object sender, EventArgs e)
        {
            temp = QuanLyThanhVien.Instance.DataThanhVien();
            dataThanhVien.Columns.Add("MATHANHVIEN");
            dataThanhVien.Columns.Add("HOTEN");
            foreach (DataRow item in temp.Rows)
            {
                dataThanhVien.Rows.Add(item["MATHANHVIEN"].ToString(), item["HOLOT"].ToString() + " " + item["TEN"].ToString());
            }
            cboThanhVien.DataSource = dataThanhVien;
            cboThanhVien.DisplayMember = "HOTEN";
            cboThanhVien.ValueMember = "MATHANHVIEN";
            rdoThu.Checked = true;
        }
    }
}
