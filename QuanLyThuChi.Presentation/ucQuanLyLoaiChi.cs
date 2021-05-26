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
    public partial class ucQuanLyLoaiChi : UserControl
    {
        bool them;
        DataTable data = new DataTable();
        public ucQuanLyLoaiChi()
        {
            InitializeComponent();
        }
        void GanDuLieu()
        {
            if (data.Rows.Count > 0)
            {
                int i = dgvDSLoaiChi.CurrentRow.Index;
                txtTenLoaiChi.Text = dgvDSLoaiChi[1, i].Value.ToString();
            }
            else
            {
                txtTenLoaiChi.Clear();
            }
        }
        void DieuKhienKhiBinhThuong()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            dgvDSLoaiChi.Enabled = true;
            txtTenLoaiChi.ReadOnly = true;
            btnThem.BackColor = Color.Teal;
            btnSua.BackColor = Color.Teal;
            btnXoa.BackColor = Color.Teal;
            btnLuu.BackColor = Color.Gray;
            btnHuy.BackColor = Color.Gray;
        }
        void DieuKhienKhiChinhSua()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            dgvDSLoaiChi.Enabled = false;
            txtTenLoaiChi.ReadOnly = false;
            btnThem.BackColor = Color.Gray;
            btnSua.BackColor = Color.Gray;
            btnXoa.BackColor = Color.Gray;
            btnLuu.BackColor = Color.Teal;
            btnHuy.BackColor = Color.Teal;
        }
        bool KiemTraDuLieu()
        {
            if (txtTenLoaiChi.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên loại thu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenLoaiChi.Focus();
                return false;
            }
            return true;
        }
        void DieuKhienKhiThem()
        {
            DieuKhienKhiChinhSua();
            txtTenLoaiChi.Clear();
        }
        private void ucQuanLyLoaiChi_Load(object sender, EventArgs e)
        {
            data = QuanLyLoaiChi.Instance.DataLoaiChi();
            dgvDSLoaiChi.DataSource = data;
            dgvDSLoaiChi.Width = 790;
            dgvDSLoaiChi.Columns[0].Width = 300;
            dgvDSLoaiChi.Columns[0].HeaderText = "Mã số";
            dgvDSLoaiChi.Columns[1].Width = 450;
            dgvDSLoaiChi.Columns[1].HeaderText = "Tài khoản";

            dgvDSLoaiChi.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
            dgvDSLoaiChi.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDSLoaiChi.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSLoaiChi.EnableHeadersVisualStyles = false;
            dgvDSLoaiChi.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvDSLoaiChi.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver;
            dgvDSLoaiChi.CellBorderStyle = DataGridViewCellBorderStyle.None;

            dgvDSLoaiChi.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvDSLoaiChi.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvDSLoaiChi.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvDSLoaiChi.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDSLoaiChi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSLoaiChi.AllowUserToResizeColumns = false;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        private void dgvDSLoaiChi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }

        private void dgvDSLoaiChi_Sorted(object sender, EventArgs e)
        {
            GanDuLieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DieuKhienKhiThem();
            them = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DieuKhienKhiChinhSua();
            them = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DieuKhienKhiBinhThuong();
            GanDuLieu();
            them = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                if (them)
                {
                    LoaiChi create = new LoaiChi(txtTenLoaiChi.Text);
                    int res = QuanLyLoaiChi.Instance.ThemLoaiChi(create);
                    MessageBox.Show("Đã thêm loại chi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data.Rows.Add(res, create.TenLoaiChi);
                }
                else
                {
                    int i = dgvDSLoaiChi.CurrentRow.Index;
                    LoaiChi update = new LoaiChi(Int32.Parse(dgvDSLoaiChi[0, i].Value.ToString()), txtTenLoaiChi.Text);
                    QuanLyLoaiChi.Instance.SuaLoaiChi(update);
                    MessageBox.Show("Sửa loại chi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data.Rows[i][1] = update.TenLoaiChi;
                }
                GanDuLieu();
                DieuKhienKhiBinhThuong();
                them = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắn chắn muốn xóa loại chi " + txtTenLoaiChi.Text,
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                int i = dgvDSLoaiChi.CurrentRow.Index;
                int id = Int32.Parse(dgvDSLoaiChi[0, i].Value.ToString());
                int result = QuanLyLoaiChi.Instance.XoaLoaiChi(id);
                if (result != 0)
                {
                    data.Rows.RemoveAt(i);
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GanDuLieu();
                }
            }
        }
    }
}
