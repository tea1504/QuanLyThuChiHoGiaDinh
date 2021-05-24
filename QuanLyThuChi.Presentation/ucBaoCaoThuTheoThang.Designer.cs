
namespace QuanLyThuChi.Presentation
{
    partial class ucBaoCaoThuTheoThang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.QL_ThuChiDataSet = new QuanLyThuChi.Presentation.QL_ThuChiDataSet();
            this.SelectThuThangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SelectThuThangTableAdapter = new QuanLyThuChi.Presentation.QL_ThuChiDataSetTableAdapters.SelectThuThangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QL_ThuChiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectThuThangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SelectThuThangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuChi.Presentation.BaoCaoThuTheoThang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 119);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1529, 659);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(639, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Năm";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(1197, 43);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(152, 48);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cboNam
            // 
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Location = new System.Drawing.Point(168, 49);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(410, 39);
            this.cboNam.TabIndex = 4;
            this.cboNam.SelectedIndexChanged += new System.EventHandler(this.cboNam_SelectedIndexChanged);
            // 
            // cboThang
            // 
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(723, 49);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(400, 39);
            this.cboThang.TabIndex = 5;
            // 
            // QL_ThuChiDataSet
            // 
            this.QL_ThuChiDataSet.DataSetName = "QL_ThuChiDataSet";
            this.QL_ThuChiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SelectThuThangBindingSource
            // 
            this.SelectThuThangBindingSource.DataMember = "SelectThuThang";
            this.SelectThuThangBindingSource.DataSource = this.QL_ThuChiDataSet;
            // 
            // SelectThuThangTableAdapter
            // 
            this.SelectThuThangTableAdapter.ClearBeforeFill = true;
            // 
            // ucBaoCaoThuTheoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboThang);
            this.Controls.Add(this.cboNam);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "ucBaoCaoThuTheoThang";
            this.Size = new System.Drawing.Size(1529, 778);
            ((System.ComponentModel.ISupportInitialize)(this.QL_ThuChiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectThuThangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.BindingSource SelectThuThangBindingSource;
        private QL_ThuChiDataSet QL_ThuChiDataSet;
        private QL_ThuChiDataSetTableAdapters.SelectThuThangTableAdapter SelectThuThangTableAdapter;
    }
}
