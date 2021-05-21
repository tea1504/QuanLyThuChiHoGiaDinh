
namespace QuanLyThuChi.Presentation
{
    partial class frmTimKiem
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
            this.tabTimKiem = new System.Windows.Forms.TabControl();
            this.tabThanVien = new System.Windows.Forms.TabPage();
            this.tabTaiKhoan = new System.Windows.Forms.TabPage();
            this.tabTongHop = new System.Windows.Forms.TabPage();
            this.tabTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTimKiem
            // 
            this.tabTimKiem.Controls.Add(this.tabTongHop);
            this.tabTimKiem.Controls.Add(this.tabThanVien);
            this.tabTimKiem.Controls.Add(this.tabTaiKhoan);
            this.tabTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTimKiem.Location = new System.Drawing.Point(0, 0);
            this.tabTimKiem.Name = "tabTimKiem";
            this.tabTimKiem.SelectedIndex = 0;
            this.tabTimKiem.ShowToolTips = true;
            this.tabTimKiem.Size = new System.Drawing.Size(1537, 822);
            this.tabTimKiem.TabIndex = 0;
            // 
            // tabThanVien
            // 
            this.tabThanVien.Location = new System.Drawing.Point(4, 40);
            this.tabThanVien.Name = "tabThanVien";
            this.tabThanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabThanVien.Size = new System.Drawing.Size(1529, 778);
            this.tabThanVien.TabIndex = 0;
            this.tabThanVien.Text = "Thành viên";
            this.tabThanVien.ToolTipText = "Tìm kiếm Thu - Chi theo thành viên";
            this.tabThanVien.UseVisualStyleBackColor = true;
            // 
            // tabTaiKhoan
            // 
            this.tabTaiKhoan.Location = new System.Drawing.Point(4, 40);
            this.tabTaiKhoan.Name = "tabTaiKhoan";
            this.tabTaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tabTaiKhoan.Size = new System.Drawing.Size(1529, 778);
            this.tabTaiKhoan.TabIndex = 1;
            this.tabTaiKhoan.Text = "Tài khoản";
            this.tabTaiKhoan.ToolTipText = "Tìm kiếm Thu - Chi theo tài khoản";
            this.tabTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // tabTongHop
            // 
            this.tabTongHop.Location = new System.Drawing.Point(4, 40);
            this.tabTongHop.Name = "tabTongHop";
            this.tabTongHop.Size = new System.Drawing.Size(1529, 778);
            this.tabTongHop.TabIndex = 2;
            this.tabTongHop.Text = "Tổng hợp";
            this.tabTongHop.ToolTipText = "Tìm kiếm Thu - Chi theo nhiều trường";
            this.tabTongHop.UseVisualStyleBackColor = true;
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 822);
            this.Controls.Add(this.tabTimKiem);
            this.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmTimKiem";
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            this.tabTimKiem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTimKiem;
        private System.Windows.Forms.TabPage tabThanVien;
        private System.Windows.Forms.TabPage tabTaiKhoan;
        private System.Windows.Forms.TabPage tabTongHop;
    }
}