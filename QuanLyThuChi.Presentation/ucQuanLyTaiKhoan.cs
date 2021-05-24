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
    public partial class ucQuanLyTaiKhoan : UserControl
    {
        Boolean them = false;
        DataTable data;
        public ucQuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        void GanDuLieu()
        {
            if (data.Rows.Count > 0)
            {
                int i = dgvDSTaiKhoan.CurrentRow.Index;
                txtTenTaiKhoan.Text = dgvDSTaiKhoan[1, i].Value.ToString();
            }
            else
            {
                txtTenTaiKhoan.Clear();
            }
        }
        void DieuKhienKhiBinhThuong()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            dgvDSTaiKhoan.Enabled = true;
            txtTenTaiKhoan.ReadOnly = true;
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
            dgvDSTaiKhoan.Enabled = false;
            txtTenTaiKhoan.ReadOnly = false;
            btnThem.BackColor = Color.Gray;
            btnSua.BackColor = Color.Gray;
            btnXoa.BackColor = Color.Gray;
            btnLuu.BackColor = Color.Teal;
            btnHuy.BackColor = Color.Teal;
        }
        bool KiemTraDuLieu()
        {
            if (txtTenTaiKhoan.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenTaiKhoan.Focus();
                return false;
            }
            return true;
        }
        void DieuKhienKhiThem()
        {
            DieuKhienKhiChinhSua();
            txtTenTaiKhoan.Clear();
        }
        private void ucQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            data = QuanLyTaiKhoan.Instance.DataTaiKhoan();
            dgvDSTaiKhoan.DataSource = data;
            dgvDSTaiKhoan.Width = 790;
            dgvDSTaiKhoan.Columns[0].Width = 300;
            dgvDSTaiKhoan.Columns[0].HeaderText = "Mã số";
            dgvDSTaiKhoan.Columns[1].Width = 450;
            dgvDSTaiKhoan.Columns[1].HeaderText = "Tài khoản";

            dgvDSTaiKhoan.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
            dgvDSTaiKhoan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDSTaiKhoan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSTaiKhoan.EnableHeadersVisualStyles = false;
            dgvDSTaiKhoan.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvDSTaiKhoan.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver;
            dgvDSTaiKhoan.CellBorderStyle = DataGridViewCellBorderStyle.None;

            dgvDSTaiKhoan.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvDSTaiKhoan.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvDSTaiKhoan.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvDSTaiKhoan.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDSTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSTaiKhoan.AllowUserToResizeColumns = false;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DieuKhienKhiThem();
            them = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DieuKhienKhiBinhThuong();
            GanDuLieu();
            them = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DieuKhienKhiChinhSua();
            them = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                if (them)
                {
                    TaiKhoan tkCreate = new TaiKhoan(txtTenTaiKhoan.Text);
                    int res = QuanLyTaiKhoan.Instance.ThemTaiKhoan(tkCreate);
                    MessageBox.Show("Đã thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data.Rows.Add(res, tkCreate.TenTaiKhoan);
                }
                else
                {
                    int i = dgvDSTaiKhoan.CurrentRow.Index;
                    TaiKhoan tkUpdate = new TaiKhoan(Int32.Parse(dgvDSTaiKhoan[0,i].Value.ToString()), txtTenTaiKhoan.Text);
                    QuanLyTaiKhoan.Instance.SuaTaiKhoan(tkUpdate);
                    MessageBox.Show("Đã cập nhật tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data.Rows[i][1] = tkUpdate.TenTaiKhoan;
                }
                them = false;
                DieuKhienKhiBinhThuong();
                GanDuLieu();
            }
        }

        private void dgvDSTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }

        private void dgvDSTaiKhoan_Sorted(object sender, EventArgs e)
        {
            GanDuLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắn chắn muốn xóa tài khoản " +txtTenTaiKhoan.Text,
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                int i = dgvDSTaiKhoan.CurrentRow.Index;
                int id = Int32.Parse(dgvDSTaiKhoan[0, i].Value.ToString());
                int result = QuanLyTaiKhoan.Instance.XoaTaiKhoan(id);
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
