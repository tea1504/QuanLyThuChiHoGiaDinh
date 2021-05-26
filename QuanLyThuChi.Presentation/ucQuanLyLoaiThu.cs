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
    public partial class ucQuanLyLoaiThu : UserControl
    {
        bool them = false;
        DataTable data = new DataTable();
        public ucQuanLyLoaiThu()
        {
            InitializeComponent();
        }
        void GanDuLieu()
        {
            if (data.Rows.Count > 0)
            {
                int i = dgvDSLoaiThu.CurrentRow.Index;
                txtTenLoaiThu.Text = dgvDSLoaiThu[1, i].Value.ToString();
            }
            else
            {
                txtTenLoaiThu.Clear();
            }
        }
        void DieuKhienKhiBinhThuong()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            dgvDSLoaiThu.Enabled = true;
            txtTenLoaiThu.ReadOnly = true;
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
            dgvDSLoaiThu.Enabled = false;
            txtTenLoaiThu.ReadOnly = false;
            btnThem.BackColor = Color.Gray;
            btnSua.BackColor = Color.Gray;
            btnXoa.BackColor = Color.Gray;
            btnLuu.BackColor = Color.Teal;
            btnHuy.BackColor = Color.Teal;
        }
        bool KiemTraDuLieu()
        {
            if (txtTenLoaiThu.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên loại thu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenLoaiThu.Focus();
                return false;
            }
            return true;
        }
        void DieuKhienKhiThem()
        {
            DieuKhienKhiChinhSua();
            txtTenLoaiThu.Clear();
        }
        private void ucQuanLyLoaiThu_Load(object sender, EventArgs e)
        {
            data = QuanLyLoaiThu.Instance.DataLoaiThu();
            dgvDSLoaiThu.DataSource = data;
            dgvDSLoaiThu.Width = 790;
            dgvDSLoaiThu.Columns[0].Width = 300;
            dgvDSLoaiThu.Columns[0].HeaderText = "Mã số";
            dgvDSLoaiThu.Columns[1].Width = 450;
            dgvDSLoaiThu.Columns[1].HeaderText = "Tài khoản";

            dgvDSLoaiThu.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
            dgvDSLoaiThu.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDSLoaiThu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSLoaiThu.EnableHeadersVisualStyles = false;
            dgvDSLoaiThu.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvDSLoaiThu.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver;
            dgvDSLoaiThu.CellBorderStyle = DataGridViewCellBorderStyle.None;

            dgvDSLoaiThu.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvDSLoaiThu.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvDSLoaiThu.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvDSLoaiThu.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDSLoaiThu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSLoaiThu.AllowUserToResizeColumns = false;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        private void dgvDSLoaiThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }

        private void dgvDSLoaiThu_Sorted(object sender, EventArgs e)
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
                    LoaiThu create = new LoaiThu(txtTenLoaiThu.Text);
                    int res = QuanLyLoaiThu.Instance.ThemLoaiThu(create);
                    MessageBox.Show("Đã thêm loại thu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data.Rows.Add(res, create.TenLoaiThu);
                }
                else
                {
                    int i = dgvDSLoaiThu.CurrentRow.Index;
                    LoaiThu update = new LoaiThu(Int32.Parse(dgvDSLoaiThu[0,i].Value.ToString()), txtTenLoaiThu.Text);
                    QuanLyLoaiThu.Instance.SuaLoaiThu(update);
                    MessageBox.Show("Sửa loại thu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data.Rows[i][1] = update.TenLoaiThu;
                }
                them = false;
                DieuKhienKhiBinhThuong();
                GanDuLieu();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắn chắn muốn xóa loại thu " + txtTenLoaiThu.Text,
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                int i = dgvDSLoaiThu.CurrentRow.Index;
                int id = Int32.Parse(dgvDSLoaiThu[0, i].Value.ToString());
                int result = QuanLyLoaiThu.Instance.XoaLoaiThu(id);
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
