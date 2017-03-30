namespace PMQLBH
{
    partial class frmThayDoiThongTinSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThayDoiThongTinSanPham));
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuuThayDoi = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.lblMaSanPham = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.lblSoLuongBanDau = new System.Windows.Forms.Label();
            this.numudSoLuongBanDau = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numudSoLuongBanDau)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(192, 217);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(170, 42);
            this.btnHuy.TabIndex = 24;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuuThayDoi
            // 
            this.btnLuuThayDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLuuThayDoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuThayDoi.Image")));
            this.btnLuuThayDoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuThayDoi.Location = new System.Drawing.Point(16, 217);
            this.btnLuuThayDoi.Name = "btnLuuThayDoi";
            this.btnLuuThayDoi.Size = new System.Drawing.Size(170, 42);
            this.btnLuuThayDoi.TabIndex = 22;
            this.btnLuuThayDoi.Text = "Lưu thay đổi";
            this.btnLuuThayDoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuThayDoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuThayDoi.UseVisualStyleBackColor = true;
            this.btnLuuThayDoi.Click += new System.EventHandler(this.btnLuuThayDoi_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGhiChu.Location = new System.Drawing.Point(145, 134);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(219, 77);
            this.txtGhiChu.TabIndex = 20;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGhiChu.Location = new System.Drawing.Point(12, 137);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(68, 20);
            this.lblGhiChu.TabIndex = 21;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDonViTinh.Location = new System.Drawing.Point(145, 70);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(219, 26);
            this.txtDonViTinh.TabIndex = 16;
            // 
            // lblDonViTinh
            // 
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDonViTinh.Location = new System.Drawing.Point(12, 73);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Size = new System.Drawing.Size(87, 20);
            this.lblDonViTinh.TabIndex = 18;
            this.lblDonViTinh.Text = "Đơn vị tính:";
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaSanPham.Location = new System.Drawing.Point(145, 38);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(219, 26);
            this.txtMaSanPham.TabIndex = 14;
            // 
            // lblMaSanPham
            // 
            this.lblMaSanPham.AutoSize = true;
            this.lblMaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMaSanPham.Location = new System.Drawing.Point(12, 41);
            this.lblMaSanPham.Name = "lblMaSanPham";
            this.lblMaSanPham.Size = new System.Drawing.Size(109, 20);
            this.lblMaSanPham.TabIndex = 15;
            this.lblMaSanPham.Text = "Mã sản phẩm:";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenSanPham.Location = new System.Drawing.Point(145, 6);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(219, 26);
            this.txtTenSanPham.TabIndex = 13;
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTenKhachHang.Location = new System.Drawing.Point(12, 9);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(114, 20);
            this.lblTenKhachHang.TabIndex = 12;
            this.lblTenKhachHang.Text = "Tên sản phẩm:";
            // 
            // lblSoLuongBanDau
            // 
            this.lblSoLuongBanDau.AutoSize = true;
            this.lblSoLuongBanDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSoLuongBanDau.Location = new System.Drawing.Point(12, 105);
            this.lblSoLuongBanDau.Name = "lblSoLuongBanDau";
            this.lblSoLuongBanDau.Size = new System.Drawing.Size(138, 20);
            this.lblSoLuongBanDau.TabIndex = 26;
            this.lblSoLuongBanDau.Text = "Số lượng ban đầu:";
            // 
            // numudSoLuongBanDau
            // 
            this.numudSoLuongBanDau.DecimalPlaces = 1;
            this.numudSoLuongBanDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numudSoLuongBanDau.Location = new System.Drawing.Point(145, 103);
            this.numudSoLuongBanDau.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numudSoLuongBanDau.Name = "numudSoLuongBanDau";
            this.numudSoLuongBanDau.Size = new System.Drawing.Size(219, 26);
            this.numudSoLuongBanDau.TabIndex = 27;
            // 
            // frmThayDoiThongTinSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 269);
            this.Controls.Add(this.numudSoLuongBanDau);
            this.Controls.Add(this.lblSoLuongBanDau);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuuThayDoi);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.lblDonViTinh);
            this.Controls.Add(this.txtMaSanPham);
            this.Controls.Add(this.lblMaSanPham);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.lblTenKhachHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmThayDoiThongTinSanPham";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi thông tin sản phẩm";
            this.Load += new System.EventHandler(this.frmThayDoiThongTinSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numudSoLuongBanDau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuuThayDoi;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.Label lblDonViTinh;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.Label lblMaSanPham;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.Label lblSoLuongBanDau;
        private System.Windows.Forms.NumericUpDown numudSoLuongBanDau;
    }
}