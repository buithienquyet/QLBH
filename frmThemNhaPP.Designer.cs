namespace PMQLBH
{
    partial class frmThemNhaPP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemNhaPP));
            this.lblTenNhaPP = new System.Windows.Forms.Label();
            this.txtTenNhaPP = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.btnThemNhaPP = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTenNhaPP
            // 
            this.lblTenNhaPP.AutoSize = true;
            this.lblTenNhaPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTenNhaPP.Location = new System.Drawing.Point(12, 9);
            this.lblTenNhaPP.Name = "lblTenNhaPP";
            this.lblTenNhaPP.Size = new System.Drawing.Size(95, 20);
            this.lblTenNhaPP.TabIndex = 0;
            this.lblTenNhaPP.Text = "Tên nhà PP:";
            this.lblTenNhaPP.Click += new System.EventHandler(this.lblTenKhachHang_Click);
            // 
            // txtTenNhaPP
            // 
            this.txtTenNhaPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenNhaPP.Location = new System.Drawing.Point(145, 6);
            this.txtTenNhaPP.Name = "txtTenNhaPP";
            this.txtTenNhaPP.Size = new System.Drawing.Size(219, 26);
            this.txtTenNhaPP.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDiaChi.Location = new System.Drawing.Point(145, 38);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(219, 26);
            this.txtDiaChi.TabIndex = 2;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDiaChi.Location = new System.Drawing.Point(12, 41);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(61, 20);
            this.lblDiaChi.TabIndex = 2;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSoDienThoai.Location = new System.Drawing.Point(145, 70);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(219, 26);
            this.txtSoDienThoai.TabIndex = 3;
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSoDienThoai.Location = new System.Drawing.Point(12, 73);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(106, 20);
            this.lblSoDienThoai.TabIndex = 4;
            this.lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGhiChu.Location = new System.Drawing.Point(145, 102);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(219, 77);
            this.txtGhiChu.TabIndex = 4;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGhiChu.Location = new System.Drawing.Point(12, 105);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(68, 20);
            this.lblGhiChu.TabIndex = 6;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // btnThemNhaPP
            // 
            this.btnThemNhaPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThemNhaPP.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNhaPP.Image")));
            this.btnThemNhaPP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNhaPP.Location = new System.Drawing.Point(16, 185);
            this.btnThemNhaPP.Name = "btnThemNhaPP";
            this.btnThemNhaPP.Size = new System.Drawing.Size(170, 42);
            this.btnThemNhaPP.TabIndex = 5;
            this.btnThemNhaPP.Text = "Thêm nhà PP";
            this.btnThemNhaPP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNhaPP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemNhaPP.UseVisualStyleBackColor = true;
            this.btnThemNhaPP.Click += new System.EventHandler(this.btnThemNhaPP_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(192, 185);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(170, 42);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmThemNhaPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 234);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThemNhaPP);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.lblSoDienThoai);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtTenNhaPP);
            this.Controls.Add(this.lblTenNhaPP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmThemNhaPP";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nhà phân phối";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenNhaPP;
        private System.Windows.Forms.TextBox txtTenNhaPP;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Button btnThemNhaPP;
        private System.Windows.Forms.Button btnHuy;
    }
}