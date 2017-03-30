namespace PMQLBH
{
    partial class frmBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.lblDanhSachSanPham = new System.Windows.Forms.Label();
            this.lblNhaPhanPhoi = new System.Windows.Forms.Label();
            this.cobKhachHang = new System.Windows.Forms.ComboBox();
            this.dgdDanhSachSanPham = new System.Windows.Forms.DataGridView();
            this.txtNoCu = new System.Windows.Forms.TextBox();
            this.lblNoCu = new System.Windows.Forms.Label();
            this.txtTongNo = new System.Windows.Forms.TextBox();
            this.lblTongNo = new System.Windows.Forms.Label();
            this.chkCongCho = new System.Windows.Forms.CheckBox();
            this.cobXeCho = new System.Windows.Forms.ComboBox();
            this.txtCongCho = new System.Windows.Forms.TextBox();
            this.lblCongCho = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkBocVac = new System.Windows.Forms.CheckBox();
            this.lblBocVac = new System.Windows.Forms.Label();
            this.txtBocVac = new System.Windows.Forms.TextBox();
            this.txtTongThanhTienCongChoBocVac = new System.Windows.Forms.TextBox();
            this.lblTongThanhTienCongChoBocVac = new System.Windows.Forms.Label();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDanhSachSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThanhToanToanBo
            // 
            this.btnThanhToanToanBo.Location = new System.Drawing.Point(323, 410);
            this.btnThanhToanToanBo.Name = "btnThanhToanToanBo";
            this.btnThanhToanToanBo.Size = new System.Drawing.Size(118, 26);
            this.btnThanhToanToanBo.TabIndex = 71;
            this.btnThanhToanToanBo.TabStop = false;
            this.btnThanhToanToanBo.Text = "Thanh toán toàn bộ";
            this.btnThanhToanToanBo.UseVisualStyleBackColor = true;
            this.btnThanhToanToanBo.Click += new System.EventHandler(this.btnThanhToanToanBo_Click);
            // 
            // lblHienThiThanhToan
            // 
            this.lblHienThiThanhToan.AutoSize = true;
            this.lblHienThiThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblHienThiThanhToan.Location = new System.Drawing.Point(323, 442);
            this.lblHienThiThanhToan.Name = "lblHienThiThanhToan";
            this.lblHienThiThanhToan.Size = new System.Drawing.Size(0, 24);
            this.lblHienThiThanhToan.TabIndex = 70;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGhiChu.Location = new System.Drawing.Point(495, 478);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(68, 20);
            this.lblGhiChu.TabIndex = 69;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGhiChu.Location = new System.Drawing.Point(605, 475);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(566, 76);
            this.txtGhiChu.TabIndex = 68;
            this.txtGhiChu.TabStop = false;
            // 
            // txtNoMoi
            // 
            this.txtNoMoi.BackColor = System.Drawing.Color.White;
            this.txtNoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNoMoi.Location = new System.Drawing.Point(141, 504);
            this.txtNoMoi.Name = "txtNoMoi";
            this.txtNoMoi.ReadOnly = true;
            this.txtNoMoi.Size = new System.Drawing.Size(175, 26);
            this.txtNoMoi.TabIndex = 67;
            this.txtNoMoi.TabStop = false;
            this.txtNoMoi.Text = "0";
            this.txtNoMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNoMoi.TextChanged += new System.EventHandler(this.txtNoMoi_TextChanged);
            // 
            // lblConNo
            // 
            this.lblConNo.AutoSize = true;
            this.lblConNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblConNo.Location = new System.Drawing.Point(11, 507);
            this.lblConNo.Name = "lblConNo";
            this.lblConNo.Size = new System.Drawing.Size(62, 20);
            this.lblConNo.TabIndex = 66;
            this.lblConNo.Text = "Nợ mới:";
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.BackColor = System.Drawing.Color.White;
            this.txtThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtThanhToan.Location = new System.Drawing.Point(141, 472);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.Size = new System.Drawing.Size(175, 26);
            this.txtThanhToan.TabIndex = 65;
            this.txtThanhToan.TabStop = false;
            this.txtThanhToan.Text = "0";
            this.txtThanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtThanhToan.TextChanged += new System.EventHandler(this.txtThanhToan_TextChanged);
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.AutoSize = true;
            this.lblThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblThanhToan.Location = new System.Drawing.Point(11, 475);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.Size = new System.Drawing.Size(94, 20);
            this.lblThanhToan.TabIndex = 64;
            this.lblThanhToan.Text = "Thanh toán:";
            // 
            // txtTongThanhTien
            // 
            this.txtTongThanhTien.BackColor = System.Drawing.Color.White;
            this.txtTongThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTongThanhTien.Location = new System.Drawing.Point(141, 409);
            this.txtTongThanhTien.Name = "txtTongThanhTien";
            this.txtTongThanhTien.ReadOnly = true;
            this.txtTongThanhTien.Size = new System.Drawing.Size(175, 26);
            this.txtTongThanhTien.TabIndex = 63;
            this.txtTongThanhTien.TabStop = false;
            this.txtTongThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTongThanhTien.TextChanged += new System.EventHandler(this.txtTongThanhTien_TextChanged);
            // 
            // lblTongThanhTien
            // 
            this.lblTongThanhTien.AutoSize = true;
            this.lblTongThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTongThanhTien.Location = new System.Drawing.Point(11, 412);
            this.lblTongThanhTien.Name = "lblTongThanhTien";
            this.lblTongThanhTien.Size = new System.Drawing.Size(88, 20);
            this.lblTongThanhTien.TabIndex = 62;
            this.lblTongThanhTien.Text = "Thành tiền:";
            this.lblTongThanhTien.Click += new System.EventHandler(this.lblTongThanhTien_Click);
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
            // btnNhapHang
            // 
            this.btnNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNhapHang.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapHang.Image")));
            this.btnNhapHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapHang.Location = new System.Drawing.Point(419, 557);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(170, 42);
            this.btnNhapHang.TabIndex = 57;
            this.btnNhapHang.TabStop = false;
            this.btnNhapHang.Text = "Bán hàng";
            this.btnNhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
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
            this.lblNhaPhanPhoi.Size = new System.Drawing.Size(98, 20);
            this.lblNhaPhanPhoi.TabIndex = 40;
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
            this.cobKhachHang.TabIndex = 38;
            this.cobKhachHang.TabStop = false;
            this.cobKhachHang.TextUpdate += new System.EventHandler(this.cobKhachHang_TextUpdate);
            this.cobKhachHang.TextChanged += new System.EventHandler(this.cobKhachHang_TextChanged);
            this.cobKhachHang.Enter += new System.EventHandler(this.cobKhachHang_Enter);
            this.cobKhachHang.Leave += new System.EventHandler(this.cobKhachHang_Leave);
            // 
            // dgdDanhSachSanPham
            // 
            this.dgdDanhSachSanPham.AllowUserToResizeColumns = false;
            this.dgdDanhSachSanPham.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgdDanhSachSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgdDanhSachSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgdDanhSachSanPham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
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
            this.colDonViTinh,
            this.colSoLuong,
            this.colGia,
            this.colThanhTien});
            this.dgdDanhSachSanPham.EnableHeadersVisualStyles = false;
            this.dgdDanhSachSanPham.Location = new System.Drawing.Point(15, 40);
            this.dgdDanhSachSanPham.MultiSelect = false;
            this.dgdDanhSachSanPham.Name = "dgdDanhSachSanPham";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdDanhSachSanPham.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgdDanhSachSanPham.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgdDanhSachSanPham.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgdDanhSachSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgdDanhSachSanPham.Size = new System.Drawing.Size(1156, 363);
            this.dgdDanhSachSanPham.TabIndex = 39;
            this.dgdDanhSachSanPham.TabStop = false;
            this.dgdDanhSachSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdDanhSachSanPham_CellClick);
            this.dgdDanhSachSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdDanhSachSanPham_CellContentClick);
            this.dgdDanhSachSanPham.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdDanhSachSanPham_CellEndEdit);
            this.dgdDanhSachSanPham.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgdDanhSachSanPham_EditingControlShowing);
            this.dgdDanhSachSanPham.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgdDanhSachSanPham_RowsAdded);
            this.dgdDanhSachSanPham.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgdDanhSachSanPham_RowsRemoved);
            this.dgdDanhSachSanPham.Sorted += new System.EventHandler(this.dgdDanhSachSanPham_Sorted);
            // 
            // txtNoCu
            // 
            this.txtNoCu.BackColor = System.Drawing.Color.White;
            this.txtNoCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNoCu.Location = new System.Drawing.Point(141, 536);
            this.txtNoCu.Name = "txtNoCu";
            this.txtNoCu.ReadOnly = true;
            this.txtNoCu.Size = new System.Drawing.Size(175, 26);
            this.txtNoCu.TabIndex = 73;
            this.txtNoCu.TabStop = false;
            this.txtNoCu.Text = "0";
            this.txtNoCu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNoCu.TextChanged += new System.EventHandler(this.txtNoCu_TextChanged);
            // 
            // lblNoCu
            // 
            this.lblNoCu.AutoSize = true;
            this.lblNoCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNoCu.Location = new System.Drawing.Point(11, 539);
            this.lblNoCu.Name = "lblNoCu";
            this.lblNoCu.Size = new System.Drawing.Size(54, 20);
            this.lblNoCu.TabIndex = 72;
            this.lblNoCu.Text = "Nợ cũ:";
            // 
            // txtTongNo
            // 
            this.txtTongNo.BackColor = System.Drawing.Color.White;
            this.txtTongNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTongNo.Location = new System.Drawing.Point(141, 568);
            this.txtTongNo.Name = "txtTongNo";
            this.txtTongNo.ReadOnly = true;
            this.txtTongNo.Size = new System.Drawing.Size(175, 26);
            this.txtTongNo.TabIndex = 75;
            this.txtTongNo.TabStop = false;
            this.txtTongNo.Text = "0";
            this.txtTongNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTongNo
            // 
            this.lblTongNo.AutoSize = true;
            this.lblTongNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTongNo.Location = new System.Drawing.Point(11, 571);
            this.lblTongNo.Name = "lblTongNo";
            this.lblTongNo.Size = new System.Drawing.Size(71, 20);
            this.lblTongNo.TabIndex = 74;
            this.lblTongNo.Text = "Tổng nợ:";
            // 
            // chkCongCho
            // 
            this.chkCongCho.AutoSize = true;
            this.chkCongCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkCongCho.Location = new System.Drawing.Point(499, 411);
            this.chkCongCho.Name = "chkCongCho";
            this.chkCongCho.Size = new System.Drawing.Size(100, 24);
            this.chkCongCho.TabIndex = 76;
            this.chkCongCho.TabStop = false;
            this.chkCongCho.Text = "Công chở:";
            this.chkCongCho.UseVisualStyleBackColor = true;
            this.chkCongCho.CheckedChanged += new System.EventHandler(this.chkCongCho_CheckedChanged);
            // 
            // cobXeCho
            // 
            this.cobXeCho.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cobXeCho.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cobXeCho.Enabled = false;
            this.cobXeCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cobXeCho.FormattingEnabled = true;
            this.cobXeCho.Location = new System.Drawing.Point(605, 409);
            this.cobXeCho.Name = "cobXeCho";
            this.cobXeCho.Size = new System.Drawing.Size(201, 28);
            this.cobXeCho.TabIndex = 77;
            this.cobXeCho.TabStop = false;
            this.cobXeCho.TextChanged += new System.EventHandler(this.cobXeCho_TextChanged);
            this.cobXeCho.Enter += new System.EventHandler(this.cobXeCho_Enter);
            this.cobXeCho.Leave += new System.EventHandler(this.cobXeCho_Leave);
            // 
            // txtCongCho
            // 
            this.txtCongCho.Enabled = false;
            this.txtCongCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCongCho.Location = new System.Drawing.Point(812, 409);
            this.txtCongCho.Name = "txtCongCho";
            this.txtCongCho.Size = new System.Drawing.Size(175, 26);
            this.txtCongCho.TabIndex = 78;
            this.txtCongCho.TabStop = false;
            this.txtCongCho.Text = "0";
            this.txtCongCho.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCongCho.TextChanged += new System.EventHandler(this.txtCongCho_TextChanged);
            // 
            // lblCongCho
            // 
            this.lblCongCho.AutoSize = true;
            this.lblCongCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblCongCho.Location = new System.Drawing.Point(993, 409);
            this.lblCongCho.Name = "lblCongCho";
            this.lblCongCho.Size = new System.Drawing.Size(20, 24);
            this.lblCongCho.TabIndex = 79;
            this.lblCongCho.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(592, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 80;
            // 
            // chkBocVac
            // 
            this.chkBocVac.AutoSize = true;
            this.chkBocVac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkBocVac.Location = new System.Drawing.Point(499, 445);
            this.chkBocVac.Name = "chkBocVac";
            this.chkBocVac.Size = new System.Drawing.Size(88, 24);
            this.chkBocVac.TabIndex = 81;
            this.chkBocVac.TabStop = false;
            this.chkBocVac.Text = "Bốc vác:";
            this.chkBocVac.UseVisualStyleBackColor = true;
            this.chkBocVac.CheckedChanged += new System.EventHandler(this.chkBocVac_CheckedChanged);
            // 
            // lblBocVac
            // 
            this.lblBocVac.AutoSize = true;
            this.lblBocVac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblBocVac.Location = new System.Drawing.Point(786, 443);
            this.lblBocVac.Name = "lblBocVac";
            this.lblBocVac.Size = new System.Drawing.Size(20, 24);
            this.lblBocVac.TabIndex = 83;
            this.lblBocVac.Text = "0";
            // 
            // txtBocVac
            // 
            this.txtBocVac.Enabled = false;
            this.txtBocVac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBocVac.Location = new System.Drawing.Point(605, 443);
            this.txtBocVac.Name = "txtBocVac";
            this.txtBocVac.Size = new System.Drawing.Size(175, 26);
            this.txtBocVac.TabIndex = 82;
            this.txtBocVac.TabStop = false;
            this.txtBocVac.Text = "0";
            this.txtBocVac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBocVac.TextChanged += new System.EventHandler(this.txtBocVac_TextChanged);
            // 
            // txtTongThanhTienCongChoBocVac
            // 
            this.txtTongThanhTienCongChoBocVac.BackColor = System.Drawing.Color.White;
            this.txtTongThanhTienCongChoBocVac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTongThanhTienCongChoBocVac.Location = new System.Drawing.Point(141, 440);
            this.txtTongThanhTienCongChoBocVac.Name = "txtTongThanhTienCongChoBocVac";
            this.txtTongThanhTienCongChoBocVac.ReadOnly = true;
            this.txtTongThanhTienCongChoBocVac.Size = new System.Drawing.Size(175, 26);
            this.txtTongThanhTienCongChoBocVac.TabIndex = 85;
            this.txtTongThanhTienCongChoBocVac.TabStop = false;
            this.txtTongThanhTienCongChoBocVac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTongThanhTienCongChoBocVac
            // 
            this.lblTongThanhTienCongChoBocVac.AutoSize = true;
            this.lblTongThanhTienCongChoBocVac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTongThanhTienCongChoBocVac.Location = new System.Drawing.Point(11, 443);
            this.lblTongThanhTienCongChoBocVac.Name = "lblTongThanhTienCongChoBocVac";
            this.lblTongThanhTienCongChoBocVac.Size = new System.Drawing.Size(124, 20);
            this.lblTongThanhTienCongChoBocVac.TabIndex = 84;
            this.lblTongThanhTienCongChoBocVac.Text = "Tổng thành tiền:";
            // 
            // colSTT
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSTT.DefaultCellStyle = dataGridViewCellStyle3;
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Width = 72;
            // 
            // colSanPham
            // 
            this.colSanPham.HeaderText = "Sản phẩm                                      ";
            this.colSanPham.Name = "colSanPham";
            this.colSanPham.Width = 310;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.HeaderText = "Đơn vị tính                ";
            this.colDonViTinh.Name = "colDonViTinh";
            this.colDonViTinh.ReadOnly = true;
            this.colDonViTinh.Width = 205;
            // 
            // colSoLuong
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSoLuong.DefaultCellStyle = dataGridViewCellStyle4;
            this.colSoLuong.HeaderText = "Số lượng          ";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Width = 164;
            // 
            // colGia
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colGia.DefaultCellStyle = dataGridViewCellStyle5;
            this.colGia.HeaderText = "Giá                          ";
            this.colGia.Name = "colGia";
            this.colGia.Width = 194;
            // 
            // colThanhTien
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colThanhTien.DefaultCellStyle = dataGridViewCellStyle6;
            this.colThanhTien.HeaderText = "Thành tiền                 ";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            this.colThanhTien.Width = 207;
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.txtTongThanhTienCongChoBocVac);
            this.Controls.Add(this.lblTongThanhTienCongChoBocVac);
            this.Controls.Add(this.lblBocVac);
            this.Controls.Add(this.txtBocVac);
            this.Controls.Add(this.chkBocVac);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnNhapHang);
            this.Controls.Add(this.lblDanhSachSanPham);
            this.Controls.Add(this.lblNhaPhanPhoi);
            this.Controls.Add(this.cobKhachHang);
            this.Controls.Add(this.dgdDanhSachSanPham);
            this.MaximizeBox = false;
            this.Name = "frmBanHang";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdDanhSachSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Label lblDanhSachSanPham;
        private System.Windows.Forms.Label lblNhaPhanPhoi;
        private System.Windows.Forms.ComboBox cobKhachHang;
        private System.Windows.Forms.DataGridView dgdDanhSachSanPham;
        private System.Windows.Forms.TextBox txtNoCu;
        private System.Windows.Forms.Label lblNoCu;
        private System.Windows.Forms.TextBox txtTongNo;
        private System.Windows.Forms.Label lblTongNo;
        private System.Windows.Forms.CheckBox chkCongCho;
        private System.Windows.Forms.ComboBox cobXeCho;
        private System.Windows.Forms.TextBox txtCongCho;
        private System.Windows.Forms.Label lblCongCho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBocVac;
        private System.Windows.Forms.Label lblBocVac;
        private System.Windows.Forms.TextBox txtBocVac;
        private System.Windows.Forms.TextBox txtTongThanhTienCongChoBocVac;
        private System.Windows.Forms.Label lblTongThanhTienCongChoBocVac;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
    }
}