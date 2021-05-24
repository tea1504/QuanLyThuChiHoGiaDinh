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
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            ucBaoCaoThu ucThu = new ucBaoCaoThu();
            tabThu.Controls.Add(ucThu);
            ucThu.Dock = DockStyle.Fill;
            ucBaoCaoChi ucChi = new ucBaoCaoChi();
            tabChi.Controls.Add(ucChi);
            ucChi.Dock = DockStyle.Fill;
            ucBaoCaoThuTheoThang ucThuThang = new ucBaoCaoThuTheoThang();
            tabThuTheoThang.Controls.Add(ucThuThang);
            ucThuThang.Dock = DockStyle.Fill;
        }
    }
}
