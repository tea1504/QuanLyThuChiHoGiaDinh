using QuanLyThuChi.Business;
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
    public partial class ucBaoCaoThu : UserControl
    {
        public ucBaoCaoThu()
        {
            InitializeComponent();
        }

        private void ucBaoCaoThu_Load(object sender, EventArgs e)
        {
            SelectAllThuTableAdapter.Fill(QL_ThuChiDataSet.SelectAllThu);
            rpThu.RefreshReport();
        }
    }
}
