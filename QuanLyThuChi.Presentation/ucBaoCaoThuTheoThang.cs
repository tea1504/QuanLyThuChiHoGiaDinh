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
    public partial class ucBaoCaoThuTheoThang : UserControl
    {
        private List<string> year, month;
        DataSet data = new DataSet();

        private void cboNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboNam.SelectedValue.ToString().Length <= 4){
                data.Tables["Thang"].Rows.Clear();
                month = QuanLyThu.Instance.getMonth(((ComboBox)sender).SelectedValue.ToString());
                foreach (string item in month)
                {
                    data.Tables["Thang"].Rows.Add(item);
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string nam = cboNam.Text, thang = cboThang.Text;
            SelectThuThangTableAdapter.Fill(QL_ThuChiDataSet.SelectThuThang, ref nam, ref thang);
            reportViewer1.RefreshReport();
        }

        public ucBaoCaoThuTheoThang()
        {
            InitializeComponent();
            year = QuanLyThu.Instance.getYear();
            data.Tables.Add("Nam");
            data.Tables["Nam"].Columns.Add("Nam");
            foreach(string item in year)
            {
                data.Tables["Nam"].Rows.Add(item);
            }
            cboNam.DataSource = data.Tables["Nam"];
            cboNam.DisplayMember = "Nam";
            cboNam.ValueMember = "Nam";
            cboNam.SelectedIndex = 0;

            month = QuanLyThu.Instance.getMonth(cboNam.SelectedValue.ToString());
            data.Tables.Add("Thang");
            data.Tables["Thang"].Columns.Add("Thang");
            foreach (string item in month)
            {
                data.Tables["Thang"].Rows.Add(item);
            }
            cboThang.DataSource = data.Tables["Thang"];
            cboThang.DisplayMember = "Thang";
            cboThang.ValueMember = "Thang";
        }
    }
}
