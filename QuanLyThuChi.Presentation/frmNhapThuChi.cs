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
    public partial class frmNhapThuChi : Form
    {
        public frmNhapThuChi()
        {
            InitializeComponent();
        }

        private void frmNhapThuChi_Load(object sender, EventArgs e)
        {
            ucNhapChi ucchi = new ucNhapChi();
            ucNhapThu ucthu = new ucNhapThu();
            tabThu.Controls.Add(ucthu);
            ucthu.Dock = DockStyle.Fill;
            tabChi.Controls.Add(ucchi);
            ucchi.Dock = DockStyle.Fill;
        }
    }
}
