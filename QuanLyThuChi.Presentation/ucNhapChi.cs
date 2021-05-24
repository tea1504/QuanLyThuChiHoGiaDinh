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
    public partial class ucNhapChi : UserControl
    {
        int width = 350, height = 80;
        Chi thongTin = new Chi();
        public ucNhapChi()
        {
            InitializeComponent();
        }
        private void ucNhapChi_Load(object sender, EventArgs e)
        {
            txtTaiKhoanChi.ReadOnly = true;
            txtTaiKhoanChi.BackColor = Color.White;
            txtTheLoaiChi.ReadOnly = true;
            txtTheLoaiChi.BackColor = Color.White;
            txtThanhVienChi.ReadOnly = true;
            txtThanhVienChi.BackColor = Color.White;
            ochua.AutoScroll = true;
        }
        void showLoaiChi()
        {
            List<LoaiChi> listLoaiChi = QuanLyLoaiChi.Instance.ListLoaiChi();
            foreach (LoaiChi item in listLoaiChi)
            {
                Button btn = new Button()
                {
                    Width = width,
                    Height = height
                };
                btn.Text = item.TenLoaiChi;
                btn.Tag = item;
                btn.Click += btn_Click_LoaiChi;
                ochua.Controls.Add(btn);
            }
        }
        void showThanhVien()
        {
            List<ThanhVien> listThanhVien = QuanLyThanhVien.Instance.ListThanhVien();
            foreach (ThanhVien item in listThanhVien)
            {
                Button btn = new Button()
                {
                    Width = width,
                    Height = height
                };
                btn.Text = item.HoLot + " " + item.Ten;
                btn.Tag = item;
                btn.Click += btn_Click_ThanhVien;
                ochua.Controls.Add(btn);
            }
        }
        void showTaiKhoan()
        {
            List<TaiKhoan> listTaiKhoan = QuanLyTaiKhoan.Instance.ListTaiKhoan();
            foreach (TaiKhoan item in listTaiKhoan)
            {
                Button btn = new Button()
                {
                    Width = width,
                    Height = height
                };
                btn.Text = item.TenTaiKhoan;
                btn.Tag = item;
                btn.Click += btn_Click_TaiKhoan;
                ochua.Controls.Add(btn);
            }
        }
        void btn_Click_ThanhVien(object sender, EventArgs e)
        {
            ThanhVien tv = (ThanhVien)(((Button)sender).Tag);
            txtThanhVienChi.Text = tv.HoLot + " " + tv.Ten;
            thongTin.MaThanhVien = tv.MaThanhVien;
        }

        private void txtTaiKhoanChi_Click(object sender, EventArgs e)
        {
            setup();
            showTaiKhoan();
        }

        void btn_Click_TaiKhoan(object sender, EventArgs e)
        {
            TaiKhoan tk = (TaiKhoan)(((Button)sender).Tag);
            txtTaiKhoanChi.Text = tk.TenTaiKhoan;
            thongTin.MaTaiKhoan = tk.MaTaiKhoan;
        }
        private void btn_Click_LoaiChi(object sender, EventArgs e)
        {
            LoaiChi lc = (LoaiChi)(((Button)sender).Tag);
            txtTheLoaiChi.Text = lc.TenLoaiChi;
            thongTin.MaLoaiChi = lc.MaLoaiChi;
        }
        private void txtThanhVienChi_Click(object sender, EventArgs e)
        {
            setup();
            showThanhVien();
        }
        void setup()
        {
            ochua.Controls.Clear();
        }

        private void btnLuuThu_Click(object sender, EventArgs e)
        {
            if (check())
            {
                thongTin.SoTienChi = Int32.Parse(txtSoTienChi.Text);
                if (txtGhiChuChi.Text.Trim().CompareTo("") != 0)
                    thongTin.GhiChuChi = txtGhiChuChi.Text;
                QuanLyChi.Instance.LuuChi(thongTin);
                txtGhiChuChi.Text = "";
                txtSoTienChi.Text = "";
                txtTaiKhoanChi.Text = "";
                txtThanhVienChi.Text = "";
                txtTheLoaiChi.Text = "";
                dtpNgayChi.Value = DateTime.Now;
            }
        }

        private void txtTheLoaiChi_Click(object sender, EventArgs e)
        {
            setup();
            showLoaiChi();
        }

        private void txtSoTienChi_Click(object sender, EventArgs e)
        {
            setup();
        }

        private void txtGhiChuChi_Click(object sender, EventArgs e)
        {
            setup();
        }

        private void dtpNgayChi_ValueChanged(object sender, EventArgs e)
        {
            thongTin.NgayChi = dtpNgayChi.Value;
        }

        bool check()
        {
            if (txtTaiKhoanChi.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("Bạn phải chọn tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtTheLoaiChi.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("Bạn phải chọn loại chi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtThanhVienChi.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("Bạn phải chọn thành viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtSoTienChi.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("Bạn phải nhập số tiền", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoTienChi.Focus();
                return false;
            }
            return true;
        }
    }
}
