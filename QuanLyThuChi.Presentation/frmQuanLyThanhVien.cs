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
    public partial class frmQuanLyThanhVien : Form
    {
        DataTable dataTable;
        Boolean them = false;
        public frmQuanLyThanhVien()
        {
            InitializeComponent();
        }
        void GanDuLieu()
        {
            if(dataTable.Rows.Count > 0)
            {
                int i = dgvDSThanhVien.CurrentRow.Index;
                txtHoLot.Text = dgvDSThanhVien[1, i].Value.ToString();
                txtTen.Text = dgvDSThanhVien[2, i].Value.ToString();
                dtpNgaySinh.Value = DateTime.Parse(dgvDSThanhVien[3, i].Value.ToString());
            }
            else
            {
                txtHoLot.Clear();
                txtTen.Clear();
            }
        }
        void DieuKhienKhiBinhThuong()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThoat.Enabled = true;
            dgvDSThanhVien.Enabled = true;
            txtHoLot.ReadOnly = true;
            txtTen.ReadOnly = true;
            dtpNgaySinh.Enabled = false;
            btnThem.BackColor = Color.Teal;
            btnSua.BackColor = Color.Teal;
            btnXoa.BackColor = Color.Teal;
            btnThoat.BackColor = Color.White;
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
            btnThoat.Enabled = false;
            dgvDSThanhVien.Enabled = false;
            txtHoLot.ReadOnly = false;
            txtTen.ReadOnly = false;
            dtpNgaySinh.Enabled = true;
            btnThem.BackColor = Color.Gray;
            btnSua.BackColor = Color.Gray;
            btnXoa.BackColor = Color.Gray;
            btnThoat.BackColor = Color.Gray;
            btnLuu.BackColor = Color.Teal;
            btnHuy.BackColor = Color.Teal;
        }
        void DieuKhienKhiThem()
        {
            DieuKhienKhiChinhSua();
            txtHoLot.Clear();
            txtTen.Clear();
            dtpNgaySinh.Value = DateTime.Now;
        }
        void KiemTraDuLieu()
        {
            if (txtHoLot.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("Bạn chưa nhập họ lót", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoLot.Focus();
                return;
            }
            if (txtTen.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus();
                return;
            }
        }
        private void frmQuanLyThanhVien_Load(object sender, EventArgs e)
        {
            dataTable = QuanLyThanhVien.Instance.DataThanhVien();
            dgvDSThanhVien.DataSource = dataTable;
            dgvDSThanhVien.Width = 803;
            dgvDSThanhVien.Columns[0].Width = 150;
            dgvDSThanhVien.Columns[0].HeaderText = "Mã số";
            dgvDSThanhVien.Columns[1].Width = 200;
            dgvDSThanhVien.Columns[1].HeaderText = "Họ lót";
            dgvDSThanhVien.Columns[2].Width = 200;
            dgvDSThanhVien.Columns[2].HeaderText = "Tên";
            dgvDSThanhVien.Columns[3].Width = 200;
            dgvDSThanhVien.Columns[3].HeaderText = "Ngày sinh";
            dgvDSThanhVien.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        private void dgvDSThanhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DieuKhienKhiChinhSua();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            GanDuLieu();
            DieuKhienKhiBinhThuong();
            them = false;
        }

        private void dgvDSThanhVien_Sorted(object sender, EventArgs e)
        {
            GanDuLieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DieuKhienKhiThem();
            them = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            KiemTraDuLieu();
            if (them)
            {
                ThanhVien thanhVienCreate = new ThanhVien(txtHoLot.Text, txtTen.Text, dtpNgaySinh.Value);
                int res = QuanLyThanhVien.Instance.ThemThanhVien(thanhVienCreate);
                MessageBox.Show("Đã thêm thành viên " + thanhVienCreate.HoLot + " " + thanhVienCreate.Ten, 
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataTable.Rows.Add(res, thanhVienCreate.HoLot, thanhVienCreate.Ten, thanhVienCreate.NgaySinh);
            }
            else
            {
                int i = dgvDSThanhVien.CurrentRow.Index;
                ThanhVien thanhVienUpdate = new ThanhVien(Int32.Parse(dgvDSThanhVien[0, i].Value.ToString()), txtHoLot.Text, txtTen.Text, dtpNgaySinh.Value);
                MessageBox.Show("Đã cập nhật thành viên " + thanhVienUpdate.HoLot + " " + thanhVienUpdate.Ten,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataTable.Rows[i][1] = thanhVienUpdate.HoLot;
                dataTable.Rows[i][2] = thanhVienUpdate.Ten;
                dataTable.Rows[i][3] = thanhVienUpdate.NgaySinh;
            }
            them = false;
            DieuKhienKhiBinhThuong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắn chắn muốn xóa thành viên " + txtHoLot.Text + " " + txtTen.Text, 
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                int i = dgvDSThanhVien.CurrentRow.Index;
                int id = Int32.Parse(dgvDSThanhVien[0, i].Value.ToString());
                int result = QuanLyThanhVien.Instance.XoaThanhVien(id);
                if (result != 0)
                {
                    dataTable.Rows.RemoveAt(i);
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
