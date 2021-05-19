
namespace QuanLyThuChi.Presentation
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaiThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaiChi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThanhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhapThuChi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTKTCThanhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTKTCTheLoai = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTCTuan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTCThang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTCNam = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTCThanhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTienIch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhMuc,
            this.mnuCapNhat,
            this.mnuTimKiem,
            this.mnuBaoCao,
            this.mnuTienIch});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoaiThu,
            this.mnuLoaiChi,
            this.mnuThanhVien,
            this.mnuTaiKhoan});
            this.mnuDanhMuc.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(135, 35);
            this.mnuDanhMuc.Text = "Danh mục";
            // 
            // mnuCapNhat
            // 
            this.mnuCapNhat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhapThuChi});
            this.mnuCapNhat.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuCapNhat.Name = "mnuCapNhat";
            this.mnuCapNhat.Size = new System.Drawing.Size(121, 35);
            this.mnuCapNhat.Text = "Cập nhật";
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTKTCThanhVien,
            this.mnuTKTCTheLoai});
            this.mnuTimKiem.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(126, 35);
            this.mnuTimKiem.Text = "Tìm kiếm";
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTCTuan,
            this.mnuTCThang,
            this.mnuTCNam,
            this.mnuTCThanhVien});
            this.mnuBaoCao.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(110, 35);
            this.mnuBaoCao.Text = "Báo cáo";
            // 
            // mnuLoaiThu
            // 
            this.mnuLoaiThu.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuLoaiThu.Name = "mnuLoaiThu";
            this.mnuLoaiThu.Size = new System.Drawing.Size(183, 34);
            this.mnuLoaiThu.Text = "Loại thu";
            // 
            // mnuLoaiChi
            // 
            this.mnuLoaiChi.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuLoaiChi.Name = "mnuLoaiChi";
            this.mnuLoaiChi.Size = new System.Drawing.Size(183, 34);
            this.mnuLoaiChi.Text = "Loại chi";
            // 
            // mnuThanhVien
            // 
            this.mnuThanhVien.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuThanhVien.Name = "mnuThanhVien";
            this.mnuThanhVien.Size = new System.Drawing.Size(183, 34);
            this.mnuThanhVien.Text = "Thành viên";
            // 
            // mnuTaiKhoan
            // 
            this.mnuTaiKhoan.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTaiKhoan.Name = "mnuTaiKhoan";
            this.mnuTaiKhoan.Size = new System.Drawing.Size(183, 34);
            this.mnuTaiKhoan.Text = "Tài khoản";
            // 
            // mnuNhapThuChi
            // 
            this.mnuNhapThuChi.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuNhapThuChi.Name = "mnuNhapThuChi";
            this.mnuNhapThuChi.Size = new System.Drawing.Size(199, 34);
            this.mnuNhapThuChi.Text = "Nhập thu chi";
            this.mnuNhapThuChi.Click += new System.EventHandler(this.mnuNhapThuChi_Click);
            // 
            // mnuTKTCThanhVien
            // 
            this.mnuTKTCThanhVien.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTKTCThanhVien.Name = "mnuTKTCThanhVien";
            this.mnuTKTCThanhVien.Size = new System.Drawing.Size(301, 34);
            this.mnuTKTCThanhVien.Text = "Thu - Chi của thành viên";
            // 
            // mnuTKTCTheLoai
            // 
            this.mnuTKTCTheLoai.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTKTCTheLoai.Name = "mnuTKTCTheLoai";
            this.mnuTKTCTheLoai.Size = new System.Drawing.Size(301, 34);
            this.mnuTKTCTheLoai.Text = "Thu - Chi của thể loại";
            // 
            // mnuTCTuan
            // 
            this.mnuTCTuan.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTCTuan.Name = "mnuTCTuan";
            this.mnuTCTuan.Size = new System.Drawing.Size(311, 34);
            this.mnuTCTuan.Text = "Thu - Chi theo tuần";
            // 
            // mnuTCThang
            // 
            this.mnuTCThang.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTCThang.Name = "mnuTCThang";
            this.mnuTCThang.Size = new System.Drawing.Size(311, 34);
            this.mnuTCThang.Text = "Thu - Chi theo tháng";
            // 
            // mnuTCNam
            // 
            this.mnuTCNam.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTCNam.Name = "mnuTCNam";
            this.mnuTCNam.Size = new System.Drawing.Size(311, 34);
            this.mnuTCNam.Text = "Thu - Chi theo năm";
            // 
            // mnuTCThanhVien
            // 
            this.mnuTCThanhVien.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTCThanhVien.Name = "mnuTCThanhVien";
            this.mnuTCThanhVien.Size = new System.Drawing.Size(311, 34);
            this.mnuTCThanhVien.Text = "Thu - Chi theo thành viên";
            // 
            // mnuTienIch
            // 
            this.mnuTienIch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThoat});
            this.mnuTienIch.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTienIch.Name = "mnuTienIch";
            this.mnuTienIch.Size = new System.Drawing.Size(110, 35);
            this.mnuTienIch.Text = "Tiện ích";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(180, 34);
            this.mnuThoat.Text = "Thoát";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thu chi hộ gia đình";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuLoaiThu;
        private System.Windows.Forms.ToolStripMenuItem mnuLoaiChi;
        private System.Windows.Forms.ToolStripMenuItem mnuThanhVien;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuCapNhat;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuNhapThuChi;
        private System.Windows.Forms.ToolStripMenuItem mnuTKTCThanhVien;
        private System.Windows.Forms.ToolStripMenuItem mnuTKTCTheLoai;
        private System.Windows.Forms.ToolStripMenuItem mnuTCTuan;
        private System.Windows.Forms.ToolStripMenuItem mnuTCThang;
        private System.Windows.Forms.ToolStripMenuItem mnuTCNam;
        private System.Windows.Forms.ToolStripMenuItem mnuTCThanhVien;
        private System.Windows.Forms.ToolStripMenuItem mnuTienIch;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
    }
}

