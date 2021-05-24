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
    public partial class frmQuanLy : Form
    {
        public frmQuanLy()
        {
            InitializeComponent();
        }
        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            ucQuanLyThanhVien qltv = new ucQuanLyThanhVien();
            tabThanhVien.Controls.Add(qltv);
            qltv.Dock = DockStyle.Fill;
            ucQuanLyTaiKhoan qltk = new ucQuanLyTaiKhoan();
            tabTaiKhoan.Controls.Add(qltk);
            qltk.Dock = DockStyle.Fill;
        }
    }
}
