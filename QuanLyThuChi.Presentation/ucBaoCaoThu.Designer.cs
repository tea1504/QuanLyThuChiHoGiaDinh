
namespace QuanLyThuChi.Presentation
{
    partial class ucBaoCaoThu
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
            this.rpThu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QL_ThuChiDataSet = new QuanLyThuChi.Presentation.QL_ThuChiDataSet();
            this.SelectAllThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SelectAllThuTableAdapter = new QuanLyThuChi.Presentation.QL_ThuChiDataSetTableAdapters.SelectAllThuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QL_ThuChiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectAllThuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpThu
            // 
            this.rpThu.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SelectAllThuBindingSource;
            this.rpThu.LocalReport.DataSources.Add(reportDataSource1);
            this.rpThu.LocalReport.ReportEmbeddedResource = "QuanLyThuChi.Presentation.Thu.rdlc";
            this.rpThu.Location = new System.Drawing.Point(0, 0);
            this.rpThu.Name = "rpThu";
            this.rpThu.ServerReport.BearerToken = null;
            this.rpThu.Size = new System.Drawing.Size(1529, 778);
            this.rpThu.TabIndex = 0;
            // 
            // QL_ThuChiDataSet
            // 
            this.QL_ThuChiDataSet.DataSetName = "QL_ThuChiDataSet";
            this.QL_ThuChiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SelectAllThuBindingSource
            // 
            this.SelectAllThuBindingSource.DataMember = "SelectAllThu";
            this.SelectAllThuBindingSource.DataSource = this.QL_ThuChiDataSet;
            // 
            // SelectAllThuTableAdapter
            // 
            this.SelectAllThuTableAdapter.ClearBeforeFill = true;
            // 
            // ucBaoCaoThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rpThu);
            this.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "ucBaoCaoThu";
            this.Size = new System.Drawing.Size(1529, 778);
            this.Load += new System.EventHandler(this.ucBaoCaoThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QL_ThuChiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectAllThuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpThu;
        private System.Windows.Forms.BindingSource SelectAllThuBindingSource;
        private QL_ThuChiDataSet QL_ThuChiDataSet;
        private QL_ThuChiDataSetTableAdapters.SelectAllThuTableAdapter SelectAllThuTableAdapter;
    }
}
