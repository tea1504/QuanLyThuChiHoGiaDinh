
namespace QuanLyThuChi.Presentation
{
    partial class frmBaoCao
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
            this.tabBaoCao = new System.Windows.Forms.TabControl();
            this.tabThu = new System.Windows.Forms.TabPage();
            this.tabChi = new System.Windows.Forms.TabPage();
            this.tabThuTheoThang = new System.Windows.Forms.TabPage();
            this.tabChiTheoThang = new System.Windows.Forms.TabPage();
            this.tabBaoCao.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabBaoCao
            // 
            this.tabBaoCao.Controls.Add(this.tabThu);
            this.tabBaoCao.Controls.Add(this.tabChi);
            this.tabBaoCao.Controls.Add(this.tabThuTheoThang);
            this.tabBaoCao.Controls.Add(this.tabChiTheoThang);
            this.tabBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBaoCao.Location = new System.Drawing.Point(0, 0);
            this.tabBaoCao.Name = "tabBaoCao";
            this.tabBaoCao.SelectedIndex = 0;
            this.tabBaoCao.Size = new System.Drawing.Size(1537, 822);
            this.tabBaoCao.TabIndex = 0;
            // 
            // tabThu
            // 
            this.tabThu.Location = new System.Drawing.Point(4, 40);
            this.tabThu.Name = "tabThu";
            this.tabThu.Padding = new System.Windows.Forms.Padding(3);
            this.tabThu.Size = new System.Drawing.Size(1529, 778);
            this.tabThu.TabIndex = 0;
            this.tabThu.Text = "Thu";
            this.tabThu.ToolTipText = "Báo cáo thu chi theo năm";
            this.tabThu.UseVisualStyleBackColor = true;
            // 
            // tabChi
            // 
            this.tabChi.Location = new System.Drawing.Point(4, 40);
            this.tabChi.Name = "tabChi";
            this.tabChi.Padding = new System.Windows.Forms.Padding(3);
            this.tabChi.Size = new System.Drawing.Size(1529, 778);
            this.tabChi.TabIndex = 1;
            this.tabChi.Text = "Chi";
            this.tabChi.ToolTipText = "Thu - Chi theo tháng";
            this.tabChi.UseVisualStyleBackColor = true;
            // 
            // tabThuTheoThang
            // 
            this.tabThuTheoThang.Location = new System.Drawing.Point(4, 40);
            this.tabThuTheoThang.Name = "tabThuTheoThang";
            this.tabThuTheoThang.Padding = new System.Windows.Forms.Padding(3);
            this.tabThuTheoThang.Size = new System.Drawing.Size(1529, 778);
            this.tabThuTheoThang.TabIndex = 2;
            this.tabThuTheoThang.Text = "Thu theo tháng";
            this.tabThuTheoThang.UseVisualStyleBackColor = true;
            // 
            // tabChiTheoThang
            // 
            this.tabChiTheoThang.Location = new System.Drawing.Point(4, 40);
            this.tabChiTheoThang.Name = "tabChiTheoThang";
            this.tabChiTheoThang.Padding = new System.Windows.Forms.Padding(3);
            this.tabChiTheoThang.Size = new System.Drawing.Size(1529, 778);
            this.tabChiTheoThang.TabIndex = 3;
            this.tabChiTheoThang.Text = "Chi theo tháng";
            this.tabChiTheoThang.UseVisualStyleBackColor = true;
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 822);
            this.Controls.Add(this.tabBaoCao);
            this.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmBaoCao";
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            this.tabBaoCao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabBaoCao;
        private System.Windows.Forms.TabPage tabThu;
        private System.Windows.Forms.TabPage tabChi;
        private System.Windows.Forms.TabPage tabThuTheoThang;
        private System.Windows.Forms.TabPage tabChiTheoThang;
    }
}