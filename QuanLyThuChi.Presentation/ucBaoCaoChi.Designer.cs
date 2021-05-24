
namespace QuanLyThuChi.Presentation
{
    partial class ucBaoCaoChi
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
            this.QL_ThuChiDataSet = new QuanLyThuChi.Presentation.QL_ThuChiDataSet();
            this.SelectAllChiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SelectAllChiTableAdapter = new QuanLyThuChi.Presentation.QL_ThuChiDataSetTableAdapters.SelectAllChiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QL_ThuChiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectAllChiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SelectAllChiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuChi.Presentation.Chi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1529, 778);
            this.reportViewer1.TabIndex = 0;
            // 
            // QL_ThuChiDataSet
            // 
            this.QL_ThuChiDataSet.DataSetName = "QL_ThuChiDataSet";
            this.QL_ThuChiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SelectAllChiBindingSource
            // 
            this.SelectAllChiBindingSource.DataMember = "SelectAllChi";
            this.SelectAllChiBindingSource.DataSource = this.QL_ThuChiDataSet;
            // 
            // SelectAllChiTableAdapter
            // 
            this.SelectAllChiTableAdapter.ClearBeforeFill = true;
            // 
            // ucBaoCaoChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "ucBaoCaoChi";
            this.Size = new System.Drawing.Size(1529, 778);
            this.Load += new System.EventHandler(this.ucBaoCaoChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QL_ThuChiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectAllChiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SelectAllChiBindingSource;
        private QL_ThuChiDataSet QL_ThuChiDataSet;
        private QL_ThuChiDataSetTableAdapters.SelectAllChiTableAdapter SelectAllChiTableAdapter;
    }
}
