namespace PMQLBH
{
    partial class frmInHoaDonBan
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DanhSachSanPhamHoaDonBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetDuLieuIn = new PMQLBH.DataSetDuLieuIn();
            this.reportViewerHoaDonBan = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachSanPhamHoaDonBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDuLieuIn)).BeginInit();
            this.SuspendLayout();
            // 
            // DanhSachSanPhamHoaDonBanBindingSource
            // 
            this.DanhSachSanPhamHoaDonBanBindingSource.DataMember = "DanhSachSanPhamHoaDonBan";
            this.DanhSachSanPhamHoaDonBanBindingSource.DataSource = this.DataSetDuLieuIn;
            // 
            // DataSetDuLieuIn
            // 
            this.DataSetDuLieuIn.DataSetName = "DataSetDuLieuIn";
            this.DataSetDuLieuIn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerHoaDonBan
            // 
            reportDataSource1.Name = "DanhSachSanPham";
            reportDataSource1.Value = this.DanhSachSanPhamHoaDonBanBindingSource;
            this.reportViewerHoaDonBan.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerHoaDonBan.LocalReport.ReportEmbeddedResource = "PMQLBH.HoaDonBan.rdlc";
            this.reportViewerHoaDonBan.Location = new System.Drawing.Point(0, 0);
            this.reportViewerHoaDonBan.Name = "reportViewerHoaDonBan";
            this.reportViewerHoaDonBan.Size = new System.Drawing.Size(872, 611);
            this.reportViewerHoaDonBan.TabIndex = 0;
            // 
            // frmInHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 611);
            this.Controls.Add(this.reportViewerHoaDonBan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmInHoaDonBan";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In hóa đơn";
            this.Load += new System.EventHandler(this.frmInHoaDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachSanPhamHoaDonBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDuLieuIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerHoaDonBan;
        private System.Windows.Forms.BindingSource DanhSachSanPhamHoaDonBanBindingSource;
        private DataSetDuLieuIn DataSetDuLieuIn;
    }
}