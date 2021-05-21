
namespace QuanLyThuChi.Presentation
{
    partial class frmNhapThuChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapThuChi));
            this.tabThuChi = new System.Windows.Forms.TabControl();
            this.tabThu = new System.Windows.Forms.TabPage();
            this.tabChi = new System.Windows.Forms.TabPage();
            this.tabThuChi.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabThuChi
            // 
            this.tabThuChi.Controls.Add(this.tabThu);
            this.tabThuChi.Controls.Add(this.tabChi);
            this.tabThuChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabThuChi.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabThuChi.Location = new System.Drawing.Point(0, 0);
            this.tabThuChi.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabThuChi.Name = "tabThuChi";
            this.tabThuChi.SelectedIndex = 0;
            this.tabThuChi.ShowToolTips = true;
            this.tabThuChi.Size = new System.Drawing.Size(1537, 822);
            this.tabThuChi.TabIndex = 0;
            // 
            // tabThu
            // 
            this.tabThu.Location = new System.Drawing.Point(4, 40);
            this.tabThu.Name = "tabThu";
            this.tabThu.Padding = new System.Windows.Forms.Padding(3);
            this.tabThu.Size = new System.Drawing.Size(1529, 778);
            this.tabThu.TabIndex = 2;
            this.tabThu.Text = "Thu";
            this.tabThu.ToolTipText = "Nhập thu";
            this.tabThu.UseVisualStyleBackColor = true;
            // 
            // tabChi
            // 
            this.tabChi.Location = new System.Drawing.Point(4, 40);
            this.tabChi.Name = "tabChi";
            this.tabChi.Padding = new System.Windows.Forms.Padding(3);
            this.tabChi.Size = new System.Drawing.Size(1529, 778);
            this.tabChi.TabIndex = 3;
            this.tabChi.Text = "Chi";
            this.tabChi.ToolTipText = "Nhập chi";
            this.tabChi.UseVisualStyleBackColor = true;
            // 
            // frmNhapThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 822);
            this.Controls.Add(this.tabThuChi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmNhapThuChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Thu - Chi";
            this.Load += new System.EventHandler(this.frmNhapThuChi_Load);
            this.tabThuChi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabThuChi;
        private System.Windows.Forms.TabPage tabThu;
        private System.Windows.Forms.TabPage tabChi;
    }
}