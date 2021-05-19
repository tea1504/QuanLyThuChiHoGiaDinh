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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuNhapThuChi_Click(object sender, EventArgs e)
        {
            frmNhapThuChi frmTC = new frmNhapThuChi();
            frmTC.ShowDialog();
        }

        private void mnuThanhVien_Click(object sender, EventArgs e)
        {
            frmQuanLyThanhVien frmQLTV = new frmQuanLyThanhVien();
            frmQLTV.ShowDialog();
        }
    }
}
