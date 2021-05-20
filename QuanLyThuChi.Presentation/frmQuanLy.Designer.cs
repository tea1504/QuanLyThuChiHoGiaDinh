
namespace QuanLyThuChi.Presentation
{
    partial class frmQuanLy
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
            this.tabQuanLy = new System.Windows.Forms.TabControl();
            this.tabThanhVien = new System.Windows.Forms.TabPage();
            this.tabTaiKhoan = new System.Windows.Forms.TabPage();
            this.tabLoaiThu = new System.Windows.Forms.TabPage();
            this.tabLoaiChi = new System.Windows.Forms.TabPage();
            this.tabQuanLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabQuanLy
            // 
            this.tabQuanLy.Controls.Add(this.tabThanhVien);
            this.tabQuanLy.Controls.Add(this.tabTaiKhoan);
            this.tabQuanLy.Controls.Add(this.tabLoaiThu);
            this.tabQuanLy.Controls.Add(this.tabLoaiChi);
            this.tabQuanLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabQuanLy.Location = new System.Drawing.Point(0, 0);
            this.tabQuanLy.Margin = new System.Windows.Forms.Padding(7);
            this.tabQuanLy.Name = "tabQuanLy";
            this.tabQuanLy.SelectedIndex = 0;
            this.tabQuanLy.ShowToolTips = true;
            this.tabQuanLy.Size = new System.Drawing.Size(1537, 822);
            this.tabQuanLy.TabIndex = 0;
            // 
            // tabThanhVien
            // 
            this.tabThanhVien.Location = new System.Drawing.Point(4, 40);
            this.tabThanhVien.Margin = new System.Windows.Forms.Padding(7);
            this.tabThanhVien.Name = "tabThanhVien";
            this.tabThanhVien.Padding = new System.Windows.Forms.Padding(7);
            this.tabThanhVien.Size = new System.Drawing.Size(1529, 778);
            this.tabThanhVien.TabIndex = 0;
            this.tabThanhVien.Text = "Thành viên";
            this.tabThanhVien.ToolTipText = "Quản lý thành viên";
            this.tabThanhVien.UseVisualStyleBackColor = true;
            // 
            // tabTaiKhoan
            // 
            this.tabTaiKhoan.Location = new System.Drawing.Point(4, 40);
            this.tabTaiKhoan.Margin = new System.Windows.Forms.Padding(7);
            this.tabTaiKhoan.Name = "tabTaiKhoan";
            this.tabTaiKhoan.Padding = new System.Windows.Forms.Padding(7);
            this.tabTaiKhoan.Size = new System.Drawing.Size(1529, 778);
            this.tabTaiKhoan.TabIndex = 1;
            this.tabTaiKhoan.Text = "Tài khoản";
            this.tabTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // tabLoaiThu
            // 
            this.tabLoaiThu.Location = new System.Drawing.Point(4, 40);
            this.tabLoaiThu.Name = "tabLoaiThu";
            this.tabLoaiThu.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoaiThu.Size = new System.Drawing.Size(1529, 778);
            this.tabLoaiThu.TabIndex = 2;
            this.tabLoaiThu.Text = "Loại thu";
            this.tabLoaiThu.UseVisualStyleBackColor = true;
            // 
            // tabLoaiChi
            // 
            this.tabLoaiChi.Location = new System.Drawing.Point(4, 40);
            this.tabLoaiChi.Name = "tabLoaiChi";
            this.tabLoaiChi.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoaiChi.Size = new System.Drawing.Size(1529, 778);
            this.tabLoaiChi.TabIndex = 3;
            this.tabLoaiChi.Text = "Loại chi";
            this.tabLoaiChi.UseVisualStyleBackColor = true;
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 822);
            this.Controls.Add(this.tabQuanLy);
            this.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmQuanLy";
            this.Text = "Quản lý";
            this.Load += new System.EventHandler(this.frmQuanLy_Load);
            this.tabQuanLy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabQuanLy;
        private System.Windows.Forms.TabPage tabThanhVien;
        private System.Windows.Forms.TabPage tabTaiKhoan;
        private System.Windows.Forms.TabPage tabLoaiThu;
        private System.Windows.Forms.TabPage tabLoaiChi;
    }
}