namespace PMQLBH
{
    partial class frmXemHoaDonBan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCongCho = new System.Windows.Forms.TextBox();
            this.cobXeCho = new System.Windows.Forms.ComboBox();
            this.txtTongNo = new System.Windows.Forms.TextBox();
            this.lblTongNo = new System.Windows.Forms.Label();
            this.txtNoCu = new System.Windows.Forms.TextBox();
            this.lblNoCu = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtNoMoi = new System.Windows.Forms.TextBox();
            this.lblConNo = new System.Windows.Forms.Label();
            this.txtThanhToan = new System.Windows.Forms.TextBox();
            this.lblThanhToan = new System.Windows.Forms.Label();
            this.txtTongThanhTien = new System.Windows.Forms.TextBox();
            this.lblTongThanhTien = new System.Windows.Forms.Label();
            this.lblDanhSachSanPham = new System.Windows.Forms.Label();
            this.lblNhaPhanPhoi = new System.Windows.Forms.Label();
            this.cobKhachHang = new System.Windows.Forms.ComboBox();
            this.dgdDanhSachSanPham = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHienThiThanhToan = new System.Windows.Forms.Label();
            this.chkCongCho = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDanhSachSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCongCho
            // 
            this.txtCongCho.Enabled = false;
            this.txtCongCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCongCho.Location = new System.Drawing.Point(950, 381);
            this.txtCongCho.Name = "txtCongCho";
            this.txtCongCho.Size = new System.Drawing.Size(222, 26);
            this.txtCongCho.TabIndex = 160;
            this.txtCongCho.TabStop = false;
            this.txtCongCho.Text = "0";
            // 
            // cobXeCho
            // 
            this.cobXeCho.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cobXeCho.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cobXeCho.Enabled = false;
            this.cobXeCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cobXeCho.FormattingEnabled = true;
            this.cobXeCho.Location = new System.Drawing.Point(709, 381);
            this.cobXeCho.Name = "cobXeCho";
            this.cobXeCho.Size = new System.Drawing.Size(235, 28);
            this.cobXeCho.TabIndex = 159;
            this.cobXeCho.TabStop = false;
            // 
            // txtTongNo
            // 
            this.txtTongNo.Enabled = false;
            this.txtTongNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTongNo.Location = new System.Drawing.Point(142, 540);
            this.txtTongNo.Name = "txtTongNo";
            this.txtTongNo.ReadOnly = true;
            this.txtTongNo.Size = new System.Drawing.Size(222, 26);
            this.txtTongNo.TabIndex = 157;
            this.txtTongNo.TabStop = false;
            this.txtTongNo.Text = "0";
            // 
            // lblTongNo
            // 
            this.lblTongNo.AutoSize = true;
            this.lblTongNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTongNo.Location = new System.Drawing.Point(12, 543);
            this.lblTongNo.Name = "lblTongNo";
            this.lblTongNo.Size = new System.Drawing.Size(71, 20);
            this.lblTongNo.TabIndex = 156;
            this.lblTongNo.Text = "Tổng nợ:";
            // 
            // txtNoCu
            // 
            this.txtNoCu.Enabled = false;
            this.txtNoCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNoCu.Location = new System.Drawing.Point(142, 508);
            this.txtNoCu.Name = "txtNoCu";
            this.txtNoCu.ReadOnly = true;
            this.txtNoCu.Size = new System.Drawing.Size(222, 26);
            this.txtNoCu.TabIndex = 155;
            this.txtNoCu.TabStop = false;
            this.txtNoCu.Text = "0";
            // 
            // lblNoCu
            // 
            this.lblNoCu.AutoSize = true;
            this.lblNoCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNoCu.Location = new System.Drawing.Point(12, 511);
            this.lblNoCu.Name = "lblNoCu";
            this.lblNoCu.Size = new System.Drawing.Size(54, 20);
            this.lblNoCu.TabIndex = 154;
            this.lblNoCu.Text = "Nợ cũ:";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGhiChu.Location = new System.Drawing.Point(532, 440);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(68, 20);
            this.lblGhiChu.TabIndex = 151;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Enabled = false;
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGhiChu.Location = new System.Drawing.Point(606, 437);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(566, 117);
            this.txtGhiChu.TabIndex = 150;
            this.txtGhiChu.TabStop = false;
            // 
            // txtNoMoi
            // 
            this.txtNoMoi.Enabled = false;
            this.txtNoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNoMoi.Location = new System.Drawing.Point(142, 476);
            this.txtNoMoi.Name = "txtNoMoi";
            this.txtNoMoi.ReadOnly = true;
            this.txtNoMoi.Size = new System.Drawing.Size(222, 26);
            this.txtNoMoi.TabIndex = 149;
            this.txtNoMoi.TabStop = false;
            this.txtNoMoi.Text = "0";
            // 
            // lblConNo
            // 
            this.lblConNo.AutoSize = true;
            this.lblConNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblConNo.Location = new System.Drawing.Point(12, 479);
            this.lblConNo.Name = "lblConNo";
            this.lblConNo.Size = new System.Drawing.Size(62, 20);
            this.lblConNo.TabIndex = 148;
            this.lblConNo.Text = "Nợ mới:";
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.Enabled = false;
            this.txtThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtThanhToan.Location = new System.Drawing.Point(142, 444);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.ReadOnly = true;
            this.txtThanhToan.Size = new System.Drawing.Size(222, 26);
            this.txtThanhToan.TabIndex = 147;
            this.txtThanhToan.TabStop = false;
            this.txtThanhToan.Text = "0";
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.AutoSize = true;
            this.lblThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblThanhToan.Location = new System.Drawing.Point(12, 447);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.Size = new System.Drawing.Size(94, 20);
            this.lblThanhToan.TabIndex = 146;
            this.lblThanhToan.Text = "Thanh toán:";
            // 
            // txtTongThanhTien
            // 
            this.txtTongThanhTien.Enabled = false;
            this.txtTongThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTongThanhTien.Location = new System.Drawing.Point(142, 412);
            this.txtTongThanhTien.Name = "txtTongThanhTien";
            this.txtTongThanhTien.ReadOnly = true;
            this.txtTongThanhTien.Size = new System.Drawing.Size(222, 26);
            this.txtTongThanhTien.TabIndex = 145;
            this.txtTongThanhTien.TabStop = false;
            // 
            // lblTongThanhTien
            // 
            this.lblTongThanhTien.AutoSize = true;
            this.lblTongThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTongThanhTien.Location = new System.Drawing.Point(12, 415);
            this.lblTongThanhTien.Name = "lblTongThanhTien";
            this.lblTongThanhTien.Size = new System.Drawing.Size(124, 20);
            this.lblTongThanhTien.TabIndex = 144;
            this.lblTongThanhTien.Text = "Tổng thành tiền:";
            // 
            // lblDanhSachSanPham
            // 
            this.lblDanhSachSanPham.AutoSize = true;
            this.lblDanhSachSanPham.Font = new System.Drawing.Font("Arial", 16F);
            this.lblDanhSachSanPham.Location = new System.Drawing.Point(459, 15);
            this.lblDanhSachSanPham.Name = "lblDanhSachSanPham";
            this.lblDanhSachSanPham.Size = new System.Drawing.Size(266, 25);
            this.lblDanhSachSanPham.TabIndex = 126;
            this.lblDanhSachSanPham.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // lblNhaPhanPhoi
            // 
            this.lblNhaPhanPhoi.AutoSize = true;
            this.lblNhaPhanPhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNhaPhanPhoi.Location = new System.Drawing.Point(13, 381);
            this.lblNhaPhanPhoi.Name = "lblNhaPhanPhoi";
            this.lblNhaPhanPhoi.Size = new System.Drawing.Size(98, 20);
            this.lblNhaPhanPhoi.TabIndex = 125;
            this.lblNhaPhanPhoi.Text = "Khách hàng:";
            // 
            // cobKhachHang
            // 
            this.cobKhachHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cobKhachHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cobKhachHang.Enabled = false;
            this.cobKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cobKhachHang.FormattingEnabled = true;
            this.cobKhachHang.Location = new System.Drawing.Point(142, 378);
            this.cobKhachHang.Name = "cobKhachHang";
            this.cobKhachHang.Size = new System.Drawing.Size(222, 28);
            this.cobKhachHang.TabIndex = 123;
            this.cobKhachHang.TabStop = false;
            // 
            // dgdDanhSachSanPham
            // 
            this.dgdDanhSachSanPham.AllowUserToAddRows = false;
            this.dgdDanhSachSanPham.AllowUserToDeleteRows = false;
            this.dgdDanhSachSanPham.AllowUserToResizeColumns = false;
            this.dgdDanhSachSanPham.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgdDanhSachSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgdDanhSachSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgdDanhSachSanPham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdDanhSachSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgdDanhSachSanPham.ColumnHeadersHeight = 40;
            this.dgdDanhSachSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgdDanhSachSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colSanPham,
            this.colSoLuong,
            this.colGia,
            this.colDonViTinh,
            this.colThanhTien});
            this.dgdDanhSachSanPham.EnableHeadersVisualStyles = false;
            this.dgdDanhSachSanPham.Location = new System.Drawing.Point(17, 43);
            this.dgdDanhSachSanPham.MultiSelect = false;
            this.dgdDanhSachSanPham.Name = "dgdDanhSachSanPham";
            this.dgdDanhSachSanPham.ReadOnly = true;
            this.dgdDanhSachSanPham.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgdDanhSachSanPham.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgdDanhSachSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdDanhSachSanPham.Size = new System.Drawing.Size(1156, 329);
            this.dgdDanhSachSanPham.TabIndex = 124;
            this.dgdDanhSachSanPham.TabStop = false;
            this.dgdDanhSachSanPham.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgdDanhSachSanPham_RowsAdded);
            this.dgdDanhSachSanPham.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgdDanhSachSanPham_RowsRemoved);
            this.dgdDanhSachSanPham.Sorted += new System.EventHandler(this.dgdDanhSachSanPham_Sorted);
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Width = 72;
            // 
            // colSanPham
            // 
            this.colSanPham.HeaderText = "Sản phẩm";
            this.colSanPham.Name = "colSanPham";
            this.colSanPham.ReadOnly = true;
            this.colSanPham.Width = 120;
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            this.colSoLuong.Width = 114;
            // 
            // colGia
            // 
            this.colGia.HeaderText = "Giá";
            this.colGia.Name = "colGia";
            this.colGia.ReadOnly = true;
            this.colGia.Width = 64;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.HeaderText = "Đơn vị tính";
            this.colDonViTinh.Name = "colDonViTinh";
            this.colDonViTinh.ReadOnly = true;
            this.colDonViTinh.Width = 125;
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            this.colThanhTien.Width = 122;
            // 
            // lblHienThiThanhToan
            // 
            this.lblHienThiThanhToan.AutoSize = true;
            this.lblHienThiThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblHienThiThanhToan.Location = new System.Drawing.Point(370, 444);
            this.lblHienThiThanhToan.Name = "lblHienThiThanhToan";
            this.lblHienThiThanhToan.Size = new System.Drawing.Size(0, 24);
            this.lblHienThiThanhToan.TabIndex = 152;
            // 
            // chkCongCho
            // 
            this.chkCongCho.AutoSize = true;
            this.chkCongCho.Enabled = false;
            this.chkCongCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkCongCho.Location = new System.Drawing.Point(607, 383);
            this.chkCongCho.Name = "chkCongCho";
            this.chkCongCho.Size = new System.Drawing.Size(100, 24);
            this.chkCongCho.TabIndex = 158;
            this.chkCongCho.TabStop = false;
            this.chkCongCho.Text = "Công chở:";
            this.chkCongCho.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnOK.Image = global::PMQLBH.Properties.Resources.Check_icon2;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(507, 560);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(170, 42);
            this.btnOK.TabIndex = 162;
            this.btnOK.TabStop = false;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmXemHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtCongCho);
            this.Controls.Add(this.cobXeCho);
            this.Controls.Add(this.chkCongCho);
            this.Controls.Add(this.txtTongNo);
            this.Controls.Add(this.lblTongNo);
            this.Controls.Add(this.txtNoCu);
            this.Controls.Add(this.lblNoCu);
            this.Controls.Add(this.lblHienThiThanhToan);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtNoMoi);
            this.Controls.Add(this.lblConNo);
            this.Controls.Add(this.txtThanhToan);
            this.Controls.Add(this.lblThanhToan);
            this.Controls.Add(this.txtTongThanhTien);
            this.Controls.Add(this.lblTongThanhTien);
            this.Controls.Add(this.lblDanhSachSanPham);
            this.Controls.Add(this.lblNhaPhanPhoi);
            this.Controls.Add(this.cobKhachHang);
            this.Controls.Add(this.dgdDanhSachSanPham);
            this.MaximizeBox = false;
            this.Name = "frmXemHoaDonBan";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem hóa đơn bán";
            this.Load += new System.EventHandler(this.frmXemHoaDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdDanhSachSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCongCho;
        private System.Windows.Forms.ComboBox cobXeCho;
        private System.Windows.Forms.TextBox txtTongNo;
        private System.Windows.Forms.Label lblTongNo;
        private System.Windows.Forms.TextBox txtNoCu;
        private System.Windows.Forms.Label lblNoCu;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtNoMoi;
        private System.Windows.Forms.Label lblConNo;
        private System.Windows.Forms.TextBox txtThanhToan;
        private System.Windows.Forms.Label lblThanhToan;
        private System.Windows.Forms.TextBox txtTongThanhTien;
        private System.Windows.Forms.Label lblTongThanhTien;
        private System.Windows.Forms.Label lblDanhSachSanPham;
        private System.Windows.Forms.Label lblNhaPhanPhoi;
        private System.Windows.Forms.ComboBox cobKhachHang;
        private System.Windows.Forms.DataGridView dgdDanhSachSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.Label lblHienThiThanhToan;
        private System.Windows.Forms.CheckBox chkCongCho;
        private System.Windows.Forms.Button btnOK;
    }
}