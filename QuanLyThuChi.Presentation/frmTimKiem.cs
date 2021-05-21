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
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            ucTimKiemTCThanhVien uctv = new ucTimKiemTCThanhVien();
            tabThanVien.Controls.Add(uctv);
            uctv.Dock = DockStyle.Fill;
            ucTimKiemTongHop ucth = new ucTimKiemTongHop();
            tabTongHop.Controls.Add(ucth);
            ucth.Dock = DockStyle.Fill;
        }
    }
}
