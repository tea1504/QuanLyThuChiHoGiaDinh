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
    public partial class ucNhapThu : UserControl
    {
        int width = 350, height = 80;
        Thu thongTin = new Thu();
        public ucNhapThu()
        {
            InitializeComponent();
        }

        private void ucNhapThu_Load(object sender, EventArgs e)
        {
            txtTaiKhoanThu.ReadOnly = true;
            txtTaiKhoanThu.BackColor = Color.White;
            txtTheLoaiThu.ReadOnly = true;
            txtTheLoaiThu.BackColor = Color.White; 
            txtThanhVienThu.ReadOnly = true;
            txtThanhVienThu.BackColor = Color.White;
            ochua.AutoScroll = true;
        }
        void showThanhVien()
        {
            List<ThanhVien> listThanhVien = QuanLyThanhVien.Instance.ListThanhVien();
            foreach(ThanhVien item in listThanhVien)
            {
                Button btn = new Button() { 
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
            foreach(TaiKhoan item in listTaiKhoan)
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
        void showLoaiThu()
        {
            List<LoaiThu> listLoaiThu = QuanLyLoaiThu.Instance.ListLoaiThu();
            foreach (LoaiThu item in listLoaiThu)
            {
                Button btn = new Button()
                {
                    Width = width,
                    Height = height
                };
                btn.Text = item.TenLoaiThu;
                btn.Tag = item;
                btn.Click += btn_Click_LoaiThu;
                ochua.Controls.Add(btn);
            }
        }
        void btn_Click_ThanhVien(object sender, EventArgs e)
        {
            ThanhVien tv = (ThanhVien)(((Button)sender).Tag);
            txtThanhVienThu.Text = tv.HoLot + " " + tv.Ten;
            thongTin.MaThanhVien = tv.MaThanhVien;
        }
        void btn_Click_TaiKhoan(object sender, EventArgs e)
        {
            TaiKhoan tk = (TaiKhoan)(((Button)sender).Tag);
            txtTaiKhoanThu.Text = tk.TenTaiKhoan;
            thongTin.MaTaiKhoan = tk.MaTaiKhoan;
        }
        void btn_Click_LoaiThu(object sender, EventArgs e)
        {
            LoaiThu lt = (LoaiThu)(((Button)sender).Tag);
            txtTheLoaiThu.Text = lt.TenLoaiThu;
            thongTin.MaLoaiThu = lt.MaLoaiThu;
        }
        private void txtThanhVienThu_Click(object sender, EventArgs e)
        {
            setup();
            showThanhVien();
        }

        private void txtTaiKhoanThu_Click(object sender, EventArgs e)
        {
            setup();
            showTaiKhoan();
        }

        private void txtTheLoaiThu_Click(object sender, EventArgs e)
        {
            setup();
            showLoaiThu();
        }
        bool check()
        {
            if (txtTaiKhoanThu.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("Bạn phải chọn tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtTheLoaiThu.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("Bạn phải chọn loại thu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtThanhVienThu.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("Bạn phải chọn thành viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtSoTienThu.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("Bạn phải nhập số tiền", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoTienThu.Focus();
                return false;
            }
            return true;
        }
        private void btnLuuThu_Click(object sender, EventArgs e)
        {
            if (check())
            {
                thongTin.SoTienThu = Int32.Parse(txtSoTienThu.Text);
                if (txtGhiChuThu.Text.Trim().CompareTo("") != 0)
                    thongTin.GhiChuThu = txtGhiChuThu.Text;
                QuanLyThu.Instance.LuuThu(thongTin);
                txtGhiChuThu.Text = "";
                txtSoTienThu.Text = "";
                txtTaiKhoanThu.Text = "";
                txtThanhVienThu.Text = "";
                txtTheLoaiThu.Text = "";
                dtpNgayThu.Value = DateTime.Now;
            }
        }

        private void txtSoTienThu_Click(object sender, EventArgs e)
        {
            setup();
        }

        private void txtGhiChuThu_Click(object sender, EventArgs e)
        {
            setup();
        }

        void setup()
        {
            ochua.Controls.Clear();
        }
    }
}
