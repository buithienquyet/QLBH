﻿namespace PMQLBH
{
    partial class frmSuaHoaDonNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaHoaDonNhap));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThanhToanToanBo = new System.Windows.Forms.Button();
            this.lblHienThiThanhToan = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtConNo = new System.Windows.Forms.TextBox();
            this.lblConNo = new System.Windows.Forms.Label();
            this.txtThanhToan = new System.Windows.Forms.TextBox();
            this.lblThanhToan = new System.Windows.Forms.Label();
            this.txtTongThanhTien = new System.Windows.Forms.TextBox();
            this.lblTongThanhTien = new System.Windows.Forms.Label();
            this.lblMaSanPham = new System.Windows.Forms.Label();
            this.cobMaSanPham = new System.Windows.Forms.ComboBox();
            this.lblHienThiGia = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuuHoaDonNhap = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThemSanPham = new System.Windows.Forms.Button();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblSoLuongKM = new System.Windows.Forms.Label();
            this.numupSoLuongKM = new System.Windows.Forms.NumericUpDown();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.numudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblSanPham = new System.Windows.Forms.Label();
            this.cobSanPham = new System.Windows.Forms.ComboBox();
            this.lblDanhSachSanPham = new System.Windows.Forms.Label();
            this.lblNhaPhanPhoi = new System.Windows.Forms.Label();
            this.cobNhaPhanPhoi = new System.Windows.Forms.ComboBox();
            this.dgdDanhSachSanPham = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numupSoLuongKM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDanhSachSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThanhToanToanBo
            // 
            this.btnThanhToanToanBo.Location = new System.Drawing.Point(369, 461);
            this.btnThanhToanToanBo.Name = "btnThanhToanToanBo";
            this.btnThanhToanToanBo.Size = new System.Drawing.Size(118, 26);
            this.btnThanhToanToanBo.TabIndex = 71;
            this.btnThanhToanToanBo.Text = "Thanh toán toàn bộ";
            this.btnThanhToanToanBo.UseVisualStyleBackColor = true;
            this.btnThanhToanToanBo.Click += new System.EventHandler(this.btnThanhToanToanBo_Click);
            // 
            // lblHienThiThanhToan
            // 
            this.lblHienThiThanhToan.AutoSize = true;
            this.lblHienThiThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblHienThiThanhToan.Location = new System.Drawing.Point(369, 493);
            this.lblHienThiThanhToan.Name = "lblHienThiThanhToan";
            this.lblHienThiThanhToan.Size = new System.Drawing.Size(0, 24);
            this.lblHienThiThanhToan.TabIndex = 70;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGhiChu.Location = new System.Drawing.Point(531, 464);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(68, 20);
            this.lblGhiChu.TabIndex = 69;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGhiChu.Location = new System.Drawing.Point(605, 461);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(567, 90);
            this.txtGhiChu.TabIndex = 68;
            this.txtGhiChu.TabStop = false;
            // 
            // txtConNo
            // 
            this.txtConNo.Enabled = false;
            this.txtConNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtConNo.Location = new System.Drawing.Point(141, 525);
            this.txtConNo.Name = "txtConNo";
            this.txtConNo.ReadOnly = true;
            this.txtConNo.Size = new System.Drawing.Size(222, 26);
            this.txtConNo.TabIndex = 67;
            this.txtConNo.TabStop = false;
            // 
            // lblConNo
            // 
            this.lblConNo.AutoSize = true;
            this.lblConNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblConNo.Location = new System.Drawing.Point(11, 528);
            this.lblConNo.Name = "lblConNo";
            this.lblConNo.Size = new System.Drawing.Size(64, 20);
            this.lblConNo.TabIndex = 66;
            this.lblConNo.Text = "Còn nợ:";
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtThanhToan.Location = new System.Drawing.Point(141, 493);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.Size = new System.Drawing.Size(222, 26);
            this.txtThanhToan.TabIndex = 65;
            this.txtThanhToan.TabStop = false;
            this.txtThanhToan.Text = "0";
            this.txtThanhToan.TextChanged += new System.EventHandler(this.txtThanhToan_TextChanged);
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.AutoSize = true;
            this.lblThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblThanhToan.Location = new System.Drawing.Point(11, 496);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.Size = new System.Drawing.Size(94, 20);
            this.lblThanhToan.TabIndex = 64;
            this.lblThanhToan.Text = "Thanh toán:";
            // 
            // txtTongThanhTien
            // 
            this.txtTongThanhTien.Enabled = false;
            this.txtTongThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTongThanhTien.Location = new System.Drawing.Point(141, 461);
            this.txtTongThanhTien.Name = "txtTongThanhTien";
            this.txtTongThanhTien.ReadOnly = true;
            this.txtTongThanhTien.Size = new System.Drawing.Size(222, 26);
            this.txtTongThanhTien.TabIndex = 63;
            this.txtTongThanhTien.TabStop = false;
            this.txtTongThanhTien.TextChanged += new System.EventHandler(this.txtTongThanhTien_TextChanged);
            // 
            // lblTongThanhTien
            // 
            this.lblTongThanhTien.AutoSize = true;
            this.lblTongThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTongThanhTien.Location = new System.Drawing.Point(11, 464);
            this.lblTongThanhTien.Name = "lblTongThanhTien";
            this.lblTongThanhTien.Size = new System.Drawing.Size(124, 20);
            this.lblTongThanhTien.TabIndex = 62;
            this.lblTongThanhTien.Text = "Tổng thành tiền:";
            // 
            // lblMaSanPham
            // 
            this.lblMaSanPham.AutoSize = true;
            this.lblMaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMaSanPham.Location = new System.Drawing.Point(291, 37);
            this.lblMaSanPham.Name = "lblMaSanPham";
            this.lblMaSanPham.Size = new System.Drawing.Size(109, 20);
            this.lblMaSanPham.TabIndex = 61;
            this.lblMaSanPham.Text = "Mã sản phẩm:";
            // 
            // cobMaSanPham
            // 
            this.cobMaSanPham.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cobMaSanPham.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cobMaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cobMaSanPham.FormattingEnabled = true;
            this.cobMaSanPham.Location = new System.Drawing.Point(295, 60);
            this.cobMaSanPham.Name = "cobMaSanPham";
            this.cobMaSanPham.Size = new System.Drawing.Size(196, 28);
            this.cobMaSanPham.TabIndex = 60;
            this.cobMaSanPham.TabStop = false;
            this.cobMaSanPham.TextChanged += new System.EventHandler(this.cobMaSanPham_TextChanged);
            // 
            // lblHienThiGia
            // 
            this.lblHienThiGia.AutoSize = true;
            this.lblHienThiGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblHienThiGia.Location = new System.Drawing.Point(725, 91);
            this.lblHienThiGia.Name = "lblHienThiGia";
            this.lblHienThiGia.Size = new System.Drawing.Size(0, 24);
            this.lblHienThiGia.TabIndex = 59;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(595, 557);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(170, 42);
            this.btnHuy.TabIndex = 58;
            this.btnHuy.TabStop = false;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuuHoaDonNhap
            // 
            this.btnLuuHoaDonNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLuuHoaDonNhap.Image = global::PMQLBH.Properties.Resources.Actions_document_save_icon;
            this.btnLuuHoaDonNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuHoaDonNhap.Location = new System.Drawing.Point(419, 557);
            this.btnLuuHoaDonNhap.Name = "btnLuuHoaDonNhap";
            this.btnLuuHoaDonNhap.Size = new System.Drawing.Size(170, 42);
            this.btnLuuHoaDonNhap.TabIndex = 57;
            this.btnLuuHoaDonNhap.TabStop = false;
            this.btnLuuHoaDonNhap.Text = "Lưu thay đổi";
            this.btnLuuHoaDonNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuHoaDonNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuHoaDonNhap.UseVisualStyleBackColor = true;
            this.btnLuuHoaDonNhap.Click += new System.EventHandler(this.btnLuuHoaDonNhap_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoa.Location = new System.Drawing.Point(251, 93);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 25);
            this.btnXoa.TabIndex = 56;
            this.btnXoa.TabStop = false;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLuu.Location = new System.Drawing.Point(133, 93);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 25);
            this.btnLuu.TabIndex = 55;
            this.btnLuu.TabStop = false;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThemSanPham.Location = new System.Drawing.Point(15, 93);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(112, 25);
            this.btnThemSanPham.TabIndex = 54;
            this.btnThemSanPham.Text = "Thêm";
            this.btnThemSanPham.UseVisualStyleBackColor = true;
            this.btnThemSanPham.Click += new System.EventHandler(this.btnThemSanPham_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtThanhTien.Location = new System.Drawing.Point(1003, 60);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(169, 26);
            this.txtThanhTien.TabIndex = 53;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblThanhTien.Location = new System.Drawing.Point(997, 37);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(88, 20);
            this.lblThanhTien.TabIndex = 52;
            this.lblThanhTien.Text = "Thành tiền:";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGia.Location = new System.Drawing.Point(729, 60);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(162, 26);
            this.txtGia.TabIndex = 51;
            this.txtGia.TextChanged += new System.EventHandler(this.txtGia_TextChanged);
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGia.Location = new System.Drawing.Point(723, 37);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(38, 20);
            this.lblGia.TabIndex = 50;
            this.lblGia.Text = "Giá:";
            // 
            // lblSoLuongKM
            // 
            this.lblSoLuongKM.AutoSize = true;
            this.lblSoLuongKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSoLuongKM.Location = new System.Drawing.Point(607, 37);
            this.lblSoLuongKM.Name = "lblSoLuongKM";
            this.lblSoLuongKM.Size = new System.Drawing.Size(103, 20);
            this.lblSoLuongKM.TabIndex = 49;
            this.lblSoLuongKM.Text = "Số lượng KM:";
            // 
            // numupSoLuongKM
            // 
            this.numupSoLuongKM.DecimalPlaces = 1;
            this.numupSoLuongKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numupSoLuongKM.Location = new System.Drawing.Point(613, 61);
            this.numupSoLuongKM.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numupSoLuongKM.Name = "numupSoLuongKM";
            this.numupSoLuongKM.Size = new System.Drawing.Size(110, 26);
            this.numupSoLuongKM.TabIndex = 48;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Enabled = false;
            this.txtDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDonViTinh.Location = new System.Drawing.Point(897, 60);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.ReadOnly = true;
            this.txtDonViTinh.Size = new System.Drawing.Size(100, 26);
            this.txtDonViTinh.TabIndex = 47;
            // 
            // lblDonViTinh
            // 
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDonViTinh.Location = new System.Drawing.Point(891, 37);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Size = new System.Drawing.Size(87, 20);
            this.lblDonViTinh.TabIndex = 46;
            this.lblDonViTinh.Text = "Đơn vị tính:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSoLuong.Location = new System.Drawing.Point(493, 37);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(76, 20);
            this.lblSoLuong.TabIndex = 45;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // numudSoLuong
            // 
            this.numudSoLuong.DecimalPlaces = 1;
            this.numudSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numudSoLuong.Location = new System.Drawing.Point(497, 61);
            this.numudSoLuong.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numudSoLuong.Name = "numudSoLuong";
            this.numudSoLuong.Size = new System.Drawing.Size(110, 26);
            this.numudSoLuong.TabIndex = 44;
            this.numudSoLuong.ValueChanged += new System.EventHandler(this.numudSoLuong_ValueChanged);
            // 
            // lblSanPham
            // 
            this.lblSanPham.AutoSize = true;
            this.lblSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSanPham.Location = new System.Drawing.Point(11, 37);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(86, 20);
            this.lblSanPham.TabIndex = 43;
            this.lblSanPham.Text = "Sản phẩm:";
            // 
            // cobSanPham
            // 
            this.cobSanPham.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cobSanPham.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cobSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cobSanPham.FormattingEnabled = true;
            this.cobSanPham.Location = new System.Drawing.Point(15, 60);
            this.cobSanPham.Name = "cobSanPham";
            this.cobSanPham.Size = new System.Drawing.Size(274, 28);
            this.cobSanPham.TabIndex = 42;
            this.cobSanPham.TextChanged += new System.EventHandler(this.cobSanPham_TextChanged);
            // 
            // lblDanhSachSanPham
            // 
            this.lblDanhSachSanPham.AutoSize = true;
            this.lblDanhSachSanPham.Font = new System.Drawing.Font("Arial", 16F);
            this.lblDanhSachSanPham.Location = new System.Drawing.Point(459, 12);
            this.lblDanhSachSanPham.Name = "lblDanhSachSanPham";
            this.lblDanhSachSanPham.Size = new System.Drawing.Size(266, 25);
            this.lblDanhSachSanPham.TabIndex = 41;
            this.lblDanhSachSanPham.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // lblNhaPhanPhoi
            // 
            this.lblNhaPhanPhoi.AutoSize = true;
            this.lblNhaPhanPhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNhaPhanPhoi.Location = new System.Drawing.Point(12, 9);
            this.lblNhaPhanPhoi.Name = "lblNhaPhanPhoi";
            this.lblNhaPhanPhoi.Size = new System.Drawing.Size(116, 20);
            this.lblNhaPhanPhoi.TabIndex = 40;
            this.lblNhaPhanPhoi.Text = "Nhà phân phối:";
            // 
            // cobNhaPhanPhoi
            // 
            this.cobNhaPhanPhoi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cobNhaPhanPhoi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cobNhaPhanPhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cobNhaPhanPhoi.FormattingEnabled = true;
            this.cobNhaPhanPhoi.Location = new System.Drawing.Point(134, 6);
            this.cobNhaPhanPhoi.Name = "cobNhaPhanPhoi";
            this.cobNhaPhanPhoi.Size = new System.Drawing.Size(235, 28);
            this.cobNhaPhanPhoi.TabIndex = 38;
            this.cobNhaPhanPhoi.TabStop = false;
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
            this.colSoLuongKM,
            this.colGia,
            this.colDonViTinh,
            this.colThanhTien});
            this.dgdDanhSachSanPham.EnableHeadersVisualStyles = false;
            this.dgdDanhSachSanPham.Location = new System.Drawing.Point(15, 124);
            this.dgdDanhSachSanPham.MultiSelect = false;
            this.dgdDanhSachSanPham.Name = "dgdDanhSachSanPham";
            this.dgdDanhSachSanPham.ReadOnly = true;
            this.dgdDanhSachSanPham.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgdDanhSachSanPham.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgdDanhSachSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdDanhSachSanPham.Size = new System.Drawing.Size(1156, 330);
            this.dgdDanhSachSanPham.TabIndex = 72;
            this.dgdDanhSachSanPham.TabStop = false;
            this.dgdDanhSachSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdDanhSachSanPham_CellClick);
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
            // colSoLuongKM
            // 
            this.colSoLuongKM.HeaderText = "Số lượng KM";
            this.colSoLuongKM.Name = "colSoLuongKM";
            this.colSoLuongKM.ReadOnly = true;
            this.colSoLuongKM.Width = 147;
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
            // frmSuaHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.dgdDanhSachSanPham);
            this.Controls.Add(this.btnThanhToanToanBo);
            this.Controls.Add(this.lblHienThiThanhToan);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtConNo);
            this.Controls.Add(this.lblConNo);
            this.Controls.Add(this.txtThanhToan);
            this.Controls.Add(this.lblThanhToan);
            this.Controls.Add(this.txtTongThanhTien);
            this.Controls.Add(this.lblTongThanhTien);
            this.Controls.Add(this.lblMaSanPham);
            this.Controls.Add(this.cobMaSanPham);
            this.Controls.Add(this.lblHienThiGia);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuuHoaDonNhap);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThemSanPham);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblSoLuongKM);
            this.Controls.Add(this.numupSoLuongKM);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.lblDonViTinh);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.numudSoLuong);
            this.Controls.Add(this.lblSanPham);
            this.Controls.Add(this.cobSanPham);
            this.Controls.Add(this.lblDanhSachSanPham);
            this.Controls.Add(this.lblNhaPhanPhoi);
            this.Controls.Add(this.cobNhaPhanPhoi);
            this.MaximizeBox = false;
            this.Name = "frmSuaHoaDonNhap";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa hóa đơn nhập";
            this.Load += new System.EventHandler(this.frmSuaHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numupSoLuongKM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDanhSachSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThanhToanToanBo;
        private System.Windows.Forms.Label lblHienThiThanhToan;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtConNo;
        private System.Windows.Forms.Label lblConNo;
        private System.Windows.Forms.TextBox txtThanhToan;
        private System.Windows.Forms.Label lblThanhToan;
        private System.Windows.Forms.TextBox txtTongThanhTien;
        private System.Windows.Forms.Label lblTongThanhTien;
        private System.Windows.Forms.Label lblMaSanPham;
        private System.Windows.Forms.ComboBox cobMaSanPham;
        private System.Windows.Forms.Label lblHienThiGia;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuuHoaDonNhap;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThemSanPham;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblSoLuongKM;
        private System.Windows.Forms.NumericUpDown numupSoLuongKM;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.Label lblDonViTinh;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numudSoLuong;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.ComboBox cobSanPham;
        private System.Windows.Forms.Label lblDanhSachSanPham;
        private System.Windows.Forms.Label lblNhaPhanPhoi;
        private System.Windows.Forms.ComboBox cobNhaPhanPhoi;
        private System.Windows.Forms.DataGridView dgdDanhSachSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
    }
}