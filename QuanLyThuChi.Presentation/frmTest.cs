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
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();

        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            string query = "select * from LOAICHI where MALOAICHI = @MaLoaiChi";
            DataProvider dataProvider = new DataProvider();
            dgvTest.DataSource = dataProvider.ExecuteQuery(query, new object[] { "1" });
        }

    }
}
