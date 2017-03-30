namespace PMQLBH
{
    partial class frmSuaHoaDonBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaHoaDonBan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.lblCongCho = new System.Windows.Forms.Label();
            this.txtCongCho = new System.Windows.Forms.TextBox();
            this.cobXeCho = new System.Windows.Forms.ComboBox();
            this.chkCongCho = new System.Windows.Forms.CheckBox();
            this.txtTongNo = new System.Windows.Forms.TextBox();
            this.lblTongNo = new System.Windows.Forms.Label();
            this.txtNoCu = new System.Windows.Forms.TextBox();
            this.lblNoCu = new System.Windows.Forms.Label();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThanhToanToanBo = new System.Windows.Forms.Button();
            this.lblHienThiThanhToan = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtNoMoi = new System.Windows.Forms.TextBox();
            this.lblConNo = new System.Windows.Forms.Label();
            this.txtThanhToan = new System.Windows.Forms.TextBox();
            this.lblThanhToan = new System.Windows.Forms.Label();
            this.txtTongThanhTien = new System.Windows.Forms.TextBox();
            this.lblTongThanhTien = new System.Windows.Forms.Label();
            this.lblMaSanPham = new System.Windows.Forms.Label();
            this.cobMaSanPham = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuuThayDoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThemSanPham = new System.Windows.Forms.Button();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.numudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblSanPham = new System.Windows.Forms.Label();
            this.cobSanPham = new System.Windows.Forms.ComboBox();
            this.lblDanhSachSanPham = new System.Windows.Forms.Label();
            this.lblNhaPhanPhoi = new System.Windows.Forms.Label();
            this.cobKhachHang = new System.Windows.Forms.ComboBox();
            this.dgdDanhSachSanPham = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDanhSachSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Image = global::PMQLBH.Properties.Resources.Refresh_icon;
            this.btnTaiLai.Location = new System.Drawing.Point(1132, 12);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(40, 40);
            this.btnTaiLai.TabIndex = 122;
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // lblCongCho
            // 
            this.lblCongCho.AutoSize = true;
            this.lblCongCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblCongCho.Location = new System.Drawing.Point(945, 438);
            this.lblCongCho.Name = "lblCongCho";
            this.lblCongCho.Size = new System.Drawing.Size(20, 24);
            this.lblCongCho.TabIndex = 120;
            this.lblCongCho.Text = "0";
            // 
            // txtCongCho
            // 
            this.txtCongCho.Enabled = false;
            this.txtCongCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCongCho.Location = new System.Drawing.Point(949, 409);
            this.txtCongCho.Name = "txtCongCho";
            this.txtCongCho.Size = new System.Drawing.Size(222, 26);
            this.txtCongCho.TabIndex = 119;
            this.txtCongCho.TabStop = false;
            this.txtCongCho.Text = "0";
            this.txtCongCho.TextChanged += new System.EventHandler(this.txtCongCho_TextChanged);
            // 
            // cobXeCho
            // 
            this.cobXeCho.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cobXeCho.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cobXeCho.Enabled = false;
            this.cobXeCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cobXeCho.FormattingEnabled = true;
            this.cobXeCho.Location = new System.Drawing.Point(708, 409);
            this.cobXeCho.Name = "cobXeCho";
            this.cobXeCho.Size = new System.Drawing.Size(235, 28);
            this.cobXeCho.TabIndex = 118;
            this.cobXeCho.TabStop = false;
            // 
            // chkCongCho
            // 
            this.chkCongCho.AutoSize = true;
            this.chkCongCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkCongCho.Location = new System.Drawing.Point(606, 411);
            this.chkCongCho.Name = "chkCongCho";
            this.chkCongCho.Size = new System.Drawing.Size(100, 24);
            this.chkCongCho.TabIndex = 117;
            this.chkCongCho.TabStop = false;
            this.chkCongCho.Text = "Công chở:";
            this.chkCongCho.UseVisualStyleBackColor = true;
            this.chkCongCho.CheckedChanged += new System.EventHandler(this.chkCongCho_CheckedChanged);
            // 
            // txtTongNo
            // 
            this.txtTongNo.Enabled = false;
            this.txtTongNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTongNo.Location = new System.Drawing.Point(141, 537);
            this.txtTongNo.Name = "txtTongNo";
            this.txtTongNo.ReadOnly = true;
            this.txtTongNo.Size = new System.Drawing.Size(222, 26);
            this.txtTongNo.TabIndex = 116;
            this.txtTongNo.TabStop = false;
            this.txtTongNo.Text = "0";
            // 
            // lblTongNo
            // 
            this.lblTongNo.AutoSize = true;
            this.lblTongNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTongNo.Location = new System.Drawing.Point(11, 540);
            this.lblTongNo.Name = "lblTongNo";
            this.lblTongNo.Size = new System.Drawing.Size(71, 20);
            this.lblTongNo.TabIndex = 115;
            this.lblTongNo.Text = "Tổng nợ:";
            // 
            // txtNoCu
            // 
            this.txtNoCu.Enabled = false;
            this.txtNoCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNoCu.Location = new System.Drawing.Point(141, 505);
            this.txtNoCu.Name = "txtNoCu";
            this.txtNoCu.ReadOnly = true;
            this.txtNoCu.Size = new System.Drawing.Size(222, 26);
            this.txtNoCu.TabIndex = 114;
            this.txtNoCu.TabStop = false;
            this.txtNoCu.Text = "0";
            this.txtNoCu.TextChanged += new System.EventHandler(this.txtNoCu_TextChanged);
            // 
            // lblNoCu
            // 
            this.lblNoCu.AutoSize = true;
            this.lblNoCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNoCu.Location = new System.Drawing.Point(11, 508);
            this.lblNoCu.Name = "lblNoCu";
            this.lblNoCu.Size = new System.Drawing.Size(54, 20);
            this.lblNoCu.TabIndex = 113;
            this.lblNoCu.Text = "Nợ cũ:";
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            this.colThanhTien.Width = 122;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.HeaderText = "Đơn vị tính";
            this.colDonViTinh.Name = "colDonViTinh";
            this.colDonViTinh.ReadOnly = true;
            this.colDonViTinh.Width = 125;
            // 
            // colGia
            // 
            this.colGia.HeaderText = "Giá";
            this.colGia.Name = "colGia";
            this.colGia.ReadOnly = true;
            this.colGia.Width = 64;
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            this.colSoLuong.Width = 114;
            // 
            // colSanPham
            // 
            this.colSanPham.HeaderText = "Sản phẩm";
            this.colSanPham.Name = "colSanPham";
            this.colSanPham.ReadOnly = true;
            this.colSanPham.Width = 120;
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Width = 72;
            // 
            // btnThanhToanToanBo
            // 
            this.btnThanhToanToanBo.Location = new System.Drawing.Point(369, 409);
            this.btnThanhToanToanBo.Name = "btnThanhToanToanBo";
            this.btnThanhToanToanBo.Size = new System.Drawing.Size(118, 26);
            this.btnThanhToanToanBo.TabIndex = 112;
            this.btnThanhToanToanBo.TabStop = false;
            this.btnThanhToanToanBo.Text = "Thanh toán toàn bộ";
            this.btnThanhToanToanBo.UseVisualStyleBackColor = true;
            this.btnThanhToanToanBo.Click += new System.EventHandler(this.btnThanhToanToanBo_Click);
            // 
            // lblHienThiThanhToan
            // 
            this.lblHienThiThanhToan.AutoSize = true;
            this.lblHienThiThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblHienThiThanhToan.Location = new System.Drawing.Point(369, 441);
            this.lblHienThiThanhToan.Name = "lblHienThiThanhToan";
            this.lblHienThiThanhToan.Size = new System.Drawing.Size(0, 24);
            this.lblHienThiThanhToan.TabIndex = 111;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGhiChu.Location = new System.Drawing.Point(531, 468);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(68, 20);
            this.lblGhiChu.TabIndex = 110;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGhiChu.Location = new System.Drawing.Point(605, 465);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(566, 86);
            this.txtGhiChu.TabIndex = 109;
            this.txtGhiChu.TabStop = false;
            // 
            // txtNoMoi
            // 
            this.txtNoMoi.Enabled = false;
            this.txtNoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNoMoi.Location = new System.Drawing.Point(141, 473);
            this.txtNoMoi.Name = "txtNoMoi";
            this.txtNoMoi.ReadOnly = true;
            this.txtNoMoi.Size = new System.Drawing.Size(222, 26);
            this.txtNoMoi.TabIndex = 108;
            this.txtNoMoi.TabStop = false;
            this.txtNoMoi.Text = "0";
            this.txtNoMoi.TextChanged += new System.EventHandler(this.txtNoMoi_TextChanged);
            // 
            // lblConNo
            // 
            this.lblConNo.AutoSize = true;
            this.lblConNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblConNo.Location = new System.Drawing.Point(11, 476);
            this.lblConNo.Name = "lblConNo";
            this.lblConNo.Size = new System.Drawing.Size(62, 20);
            this.lblConNo.TabIndex = 107;
            this.lblConNo.Text = "Nợ mới:";
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtThanhToan.Location = new System.Drawing.Point(141, 441);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.Size = new System.Drawing.Size(222, 26);
            this.txtThanhToan.TabIndex = 106;
            this.txtThanhToan.TabStop = false;
            this.txtThanhToan.Text = "0";
            this.txtThanhToan.TextChanged += new System.EventHandler(this.txtThanhToan_TextChanged);
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.AutoSize = true;
            this.lblThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblThanhToan.Location = new System.Drawing.Point(11, 444);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.Size = new System.Drawing.Size(94, 20);
            this.lblThanhToan.TabIndex = 105;
            this.lblThanhToan.Text = "Thanh toán:";
            // 
            // txtTongThanhTien
            // 
            this.txtTongThanhTien.Enabled = false;
            this.txtTongThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTongThanhTien.Location = new System.Drawing.Point(141, 409);
            this.txtTongThanhTien.Name = "txtTongThanhTien";
            this.txtTongThanhTien.ReadOnly = true;
            this.txtTongThanhTien.Size = new System.Drawing.Size(222, 26);
            this.txtTongThanhTien.TabIndex = 104;
            this.txtTongThanhTien.TabStop = false;
            this.txtTongThanhTien.TextChanged += new System.EventHandler(this.txtTongThanhTien_TextChanged);
            // 
            // lblTongThanhTien
            // 
            this.lblTongThanhTien.AutoSize = true;
            this.lblTongThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTongThanhTien.Location = new System.Drawing.Point(11, 412);
            this.lblTongThanhTien.Name = "lblTongThanhTien";
            this.lblTongThanhTien.Size = new System.Drawing.Size(124, 20);
            this.lblTongThanhTien.TabIndex = 103;
            this.lblTongThanhTien.Text = "Tổng thành tiền:";
            // 
            // lblMaSanPham
            // 
            this.lblMaSanPham.AutoSize = true;
            this.lblMaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMaSanPham.Location = new System.Drawing.Point(291, 37);
            this.lblMaSanPham.Name = "lblMaSanPham";
            this.lblMaSanPham.Size = new System.Drawing.Size(109, 20);
            this.lblMaSanPham.TabIndex = 102;
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
            this.cobMaSanPham.TabIndex = 101;
            this.cobMaSanPham.TabStop = false;
            this.cobMaSanPham.TextChanged += new System.EventHandler(this.cobMaSanPham_TextChanged);
            this.cobMaSanPham.Leave += new System.EventHandler(this.cobMaSanPham_Leave);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(595, 557);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(170, 42);
            this.btnHuy.TabIndex = 100;
            this.btnHuy.TabStop = false;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuuThayDoi
            // 
            this.btnLuuThayDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLuuThayDoi.Image = global::PMQLBH.Properties.Resources.Actions_document_save_icon;
            this.btnLuuThayDoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuThayDoi.Location = new System.Drawing.Point(419, 557);
            this.btnLuuThayDoi.Name = "btnLuuThayDoi";
            this.btnLuuThayDoi.Size = new System.Drawing.Size(170, 42);
            this.btnLuuThayDoi.TabIndex = 99;
            this.btnLuuThayDoi.TabStop = false;
            this.btnLuuThayDoi.Text = "Lưu thay đổi";
            this.btnLuuThayDoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuThayDoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuThayDoi.UseVisualStyleBackColor = true;
            this.btnLuuThayDoi.Click += new System.EventHandler(this.btnLuuThayDoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoa.Location = new System.Drawing.Point(251, 93);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 25);
            this.btnXoa.TabIndex = 98;
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
            this.btnLuu.TabIndex = 97;
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
            this.btnThemSanPham.TabIndex = 96;
            this.btnThemSanPham.Text = "Thêm";
            this.btnThemSanPham.UseVisualStyleBackColor = true;
            this.btnThemSanPham.Click += new System.EventHandler(this.btnThemSanPham_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtThanhTien.Location = new System.Drawing.Point(887, 60);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(168, 26);
            this.txtThanhTien.TabIndex = 95;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblThanhTien.Location = new System.Drawing.Point(881, 37);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(88, 20);
            this.lblThanhTien.TabIndex = 94;
            this.lblThanhTien.Text = "Thành tiền:";
            // 
            // txtGia
            // 
            this.txtGia.Enabled = false;
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGia.Location = new System.Drawing.Point(613, 60);
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(162, 26);
            this.txtGia.TabIndex = 93;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGia.Location = new System.Drawing.Point(607, 37);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(38, 20);
            this.lblGia.TabIndex = 92;
            this.lblGia.Text = "Giá:";
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Enabled = false;
            this.txtDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDonViTinh.Location = new System.Drawing.Point(781, 60);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.ReadOnly = true;
            this.txtDonViTinh.Size = new System.Drawing.Size(100, 26);
            this.txtDonViTinh.TabIndex = 91;
            // 
            // lblDonViTinh
            // 
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDonViTinh.Location = new System.Drawing.Point(775, 37);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Size = new System.Drawing.Size(87, 20);
            this.lblDonViTinh.TabIndex = 90;
            this.lblDonViTinh.Text = "Đơn vị tính:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSoLuong.Location = new System.Drawing.Point(493, 37);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(76, 20);
            this.lblSoLuong.TabIndex = 89;
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
            this.numudSoLuong.TabIndex = 88;
            this.numudSoLuong.ValueChanged += new System.EventHandler(this.numudSoLuong_ValueChanged);
            // 
            // lblSanPham
            // 
            this.lblSanPham.AutoSize = true;
            this.lblSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSanPham.Location = new System.Drawing.Point(11, 37);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(86, 20);
            this.lblSanPham.TabIndex = 87;
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
            this.cobSanPham.TabIndex = 86;
            this.cobSanPham.TextChanged += new System.EventHandler(this.cobSanPham_TextChanged);
            this.cobSanPham.Leave += new System.EventHandler(this.cobSanPham_Leave);
            // 
            // lblDanhSachSanPham
            // 
            this.lblDanhSachSanPham.AutoSize = true;
            this.lblDanhSachSanPham.Font = new System.Drawing.Font("Arial", 16F);
            this.lblDanhSachSanPham.Location = new System.Drawing.Point(459, 12);
            this.lblDanhSachSanPham.Name = "lblDanhSachSanPham";
            this.lblDanhSachSanPham.Size = new System.Drawing.Size(266, 25);
            this.lblDanhSachSanPham.TabIndex = 85;
            this.lblDanhSachSanPham.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // lblNhaPhanPhoi
            // 
            this.lblNhaPhanPhoi.AutoSize = true;
            this.lblNhaPhanPhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNhaPhanPhoi.Location = new System.Drawing.Point(12, 9);
            this.lblNhaPhanPhoi.Name = "lblNhaPhanPhoi";
            this.lblNhaPhanPhoi.Size = new System.Drawing.Size(98, 20);
            this.lblNhaPhanPhoi.TabIndex = 84;
            this.lblNhaPhanPhoi.Text = "Khách hàng:";
            // 
            // cobKhachHang
            // 
            this.cobKhachHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cobKhachHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cobKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cobKhachHang.FormattingEnabled = true;
            this.cobKhachHang.Location = new System.Drawing.Point(134, 6);
            this.cobKhachHang.Name = "cobKhachHang";
            this.cobKhachHang.Size = new System.Drawing.Size(235, 28);
            this.cobKhachHang.TabIndex = 82;
            this.cobKhachHang.TabStop = false;
            this.cobKhachHang.TextChanged += new System.EventHandler(this.cobKhachHang_TextChanged);
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
            this.dgdDanhSachSanPham.Location = new System.Drawing.Point(15, 125);
            this.dgdDanhSachSanPham.MultiSelect = false;
            this.dgdDanhSachSanPham.Name = "dgdDanhSachSanPham";
            this.dgdDanhSachSanPham.ReadOnly = true;
            this.dgdDanhSachSanPham.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgdDanhSachSanPham.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgdDanhSachSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdDanhSachSanPham.Size = new System.Drawing.Size(1156, 278);
            this.dgdDanhSachSanPham.TabIndex = 83;
            this.dgdDanhSachSanPham.TabStop = false;
            this.dgdDanhSachSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdDanhSachSanPham_CellClick);
            this.dgdDanhSachSanPham.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgdDanhSachSanPham_RowsAdded);
            this.dgdDanhSachSanPham.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgdDanhSachSanPham_RowsRemoved);
            this.dgdDanhSachSanPham.Sorted += new System.EventHandler(this.dgdDanhSachSanPham_Sorted);
            this.dgdDanhSachSanPham.Enter += new System.EventHandler(this.dgdDanhSachSanPham_Enter);
            // 
            // frmSuaHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.lblCongCho);
            this.Controls.Add(this.txtCongCho);
            this.Controls.Add(this.cobXeCho);
            this.Controls.Add(this.chkCongCho);
            this.Controls.Add(this.txtTongNo);
            this.Controls.Add(this.lblTongNo);
            this.Controls.Add(this.txtNoCu);
            this.Controls.Add(this.lblNoCu);
            this.Controls.Add(this.btnThanhToanToanBo);
            this.Controls.Add(this.lblHienThiThanhToan);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtNoMoi);
            this.Controls.Add(this.lblConNo);
            this.Controls.Add(this.txtThanhToan);
            this.Controls.Add(this.lblThanhToan);
            this.Controls.Add(this.txtTongThanhTien);
            this.Controls.Add(this.lblTongThanhTien);
            this.Controls.Add(this.lblMaSanPham);
            this.Controls.Add(this.cobMaSanPham);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuuThayDoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThemSanPham);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.lblDonViTinh);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.numudSoLuong);
            this.Controls.Add(this.lblSanPham);
            this.Controls.Add(this.cobSanPham);
            this.Controls.Add(this.lblDanhSachSanPham);
            this.Controls.Add(this.lblNhaPhanPhoi);
            this.Controls.Add(this.cobKhachHang);
            this.Controls.Add(this.dgdDanhSachSanPham);
            this.MaximizeBox = false;
            this.Name = "frmSuaHoaDonBan";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa hóa đơn bán";
            this.Load += new System.EventHandler(this.frmSuaHoaDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDanhSachSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Label lblCongCho;
        private System.Windows.Forms.TextBox txtCongCho;
        private System.Windows.Forms.ComboBox cobXeCho;
        private System.Windows.Forms.CheckBox chkCongCho;
        private System.Windows.Forms.TextBox txtTongNo;
        private System.Windows.Forms.Label lblTongNo;
        private System.Windows.Forms.TextBox txtNoCu;
        private System.Windows.Forms.Label lblNoCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.Button btnThanhToanToanBo;
        private System.Windows.Forms.Label lblHienThiThanhToan;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtNoMoi;
        private System.Windows.Forms.Label lblConNo;
        private System.Windows.Forms.TextBox txtThanhToan;
        private System.Windows.Forms.Label lblThanhToan;
        private System.Windows.Forms.TextBox txtTongThanhTien;
        private System.Windows.Forms.Label lblTongThanhTien;
        private System.Windows.Forms.Label lblMaSanPham;
        private System.Windows.Forms.ComboBox cobMaSanPham;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuuThayDoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThemSanPham;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.Label lblDonViTinh;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numudSoLuong;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.ComboBox cobSanPham;
        private System.Windows.Forms.Label lblDanhSachSanPham;
        private System.Windows.Forms.Label lblNhaPhanPhoi;
        private System.Windows.Forms.ComboBox cobKhachHang;
        private System.Windows.Forms.DataGridView dgdDanhSachSanPham;
    }
}