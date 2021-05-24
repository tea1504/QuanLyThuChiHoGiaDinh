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
    public partial class ucBaoCaoChi : UserControl
    {
        public ucBaoCaoChi()
        {
            InitializeComponent();
        }

        private void ucBaoCaoChi_Load(object sender, EventArgs e)
        {
            SelectAllChiTableAdapter.Fill(QL_ThuChiDataSet.SelectAllChi);
            reportViewer1.RefreshReport();
        }
    }
}
