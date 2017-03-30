namespace PMQLBH
{
    partial class frmSuaTraNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaTraNo));
            this.btnTraHetNo = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuuThayDoi = new System.Windows.Forms.Button();
            this.txtNoMoi = new System.Windows.Forms.TextBox();
            this.lblNoMoi = new System.Windows.Forms.Label();
            this.lblHienThiTraNo = new System.Windows.Forms.Label();
            this.txtTraNo = new System.Windows.Forms.TextBox();
            this.lblTraNo = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.radioNhaPP = new System.Windows.Forms.RadioButton();
            this.radioKhachHang = new System.Windows.Forms.RadioButton();
            this.lblKH_NPP = new System.Windows.Forms.Label();
            this.cobKH_NPP = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnTraHetNo
            // 
            this.btnTraHetNo.Location = new System.Drawing.Point(339, 74);
            this.btnTraHetNo.Name = "btnTraHetNo";
            this.btnTraHetNo.Size = new System.Drawing.Size(124, 26);
            this.btnTraHetNo.TabIndex = 95;
            this.btnTraHetNo.TabStop = false;
            this.btnTraHetNo.Text = "Trả toàn bộ";
            this.btnTraHetNo.UseVisualStyleBackColor = true;
            this.btnTraHetNo.Click += new System.EventHandler(this.btnTraHetNo_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(241, 170);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(170, 42);
            this.btnHuy.TabIndex = 94;
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
            this.btnLuuThayDoi.Location = new System.Drawing.Point(65, 170);
            this.btnLuuThayDoi.Name = "btnLuuThayDoi";
            this.btnLuuThayDoi.Size = new System.Drawing.Size(170, 42);
            this.btnLuuThayDoi.TabIndex = 93;
            this.btnLuuThayDoi.Text = "Lưu thay đổi";
            this.btnLuuThayDoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuThayDoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuThayDoi.UseVisualStyleBackColor = true;
            this.btnLuuThayDoi.Click += new System.EventHandler(this.btnLuuThayDoi_Click);
            // 
            // txtNoMoi
            // 
            this.txtNoMoi.Enabled = false;
            this.txtNoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNoMoi.Location = new System.Drawing.Point(135, 138);
            this.txtNoMoi.Name = "txtNoMoi";
            this.txtNoMoi.Size = new System.Drawing.Size(198, 26);
            this.txtNoMoi.TabIndex = 92;
            this.txtNoMoi.TabStop = false;
            this.txtNoMoi.Text = "0";
            // 
            // lblNoMoi
            // 
            this.lblNoMoi.AutoSize = true;
            this.lblNoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNoMoi.Location = new System.Drawing.Point(10, 141);
            this.lblNoMoi.Name = "lblNoMoi";
            this.lblNoMoi.Size = new System.Drawing.Size(62, 20);
            this.lblNoMoi.TabIndex = 91;
            this.lblNoMoi.Text = "Nợ mới:";
            // 
            // lblHienThiTraNo
            // 
            this.lblHienThiTraNo.AutoSize = true;
            this.lblHienThiTraNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblHienThiTraNo.Location = new System.Drawing.Point(339, 103);
            this.lblHienThiTraNo.Name = "lblHienThiTraNo";
            this.lblHienThiTraNo.Size = new System.Drawing.Size(0, 24);
            this.lblHienThiTraNo.TabIndex = 90;
            // 
            // txtTraNo
            // 
            this.txtTraNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTraNo.Location = new System.Drawing.Point(135, 106);
            this.txtTraNo.Name = "txtTraNo";
            this.txtTraNo.Size = new System.Drawing.Size(198, 26);
            this.txtTraNo.TabIndex = 89;
            this.txtTraNo.Text = "0";
            this.txtTraNo.TextChanged += new System.EventHandler(this.txtTraNo_TextChanged);
            // 
            // lblTraNo
            // 
            this.lblTraNo.AutoSize = true;
            this.lblTraNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTraNo.Location = new System.Drawing.Point(10, 109);
            this.lblTraNo.Name = "lblTraNo";
            this.lblTraNo.Size = new System.Drawing.Size(58, 20);
            this.lblTraNo.TabIndex = 88;
            this.lblTraNo.Text = "Trả nợ:";
            // 
            // txtNo
            // 
            this.txtNo.Enabled = false;
            this.txtNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNo.Location = new System.Drawing.Point(135, 74);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(198, 26);
            this.txtNo.TabIndex = 87;
            this.txtNo.TabStop = false;
            this.txtNo.Text = "0";
            this.txtNo.TextChanged += new System.EventHandler(this.txtNo_TextChanged);
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNo.Location = new System.Drawing.Point(10, 77);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(33, 20);
            this.lblNo.TabIndex = 86;
            this.lblNo.Text = "Nợ:";
            // 
            // radioNhaPP
            // 
            this.radioNhaPP.AutoSize = true;
            this.radioNhaPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioNhaPP.Location = new System.Drawing.Point(228, 10);
            this.radioNhaPP.Name = "radioNhaPP";
            this.radioNhaPP.Size = new System.Drawing.Size(130, 24);
            this.radioNhaPP.TabIndex = 85;
            this.radioNhaPP.Text = "Nhà phân phối";
            this.radioNhaPP.UseVisualStyleBackColor = true;
            this.radioNhaPP.CheckedChanged += new System.EventHandler(this.radioNhaPP_CheckedChanged);
            // 
            // radioKhachHang
            // 
            this.radioKhachHang.AutoSize = true;
            this.radioKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioKhachHang.Location = new System.Drawing.Point(110, 10);
            this.radioKhachHang.Name = "radioKhachHang";
            this.radioKhachHang.Size = new System.Drawing.Size(112, 24);
            this.radioKhachHang.TabIndex = 84;
            this.radioKhachHang.Text = "Khách hàng";
            this.radioKhachHang.UseVisualStyleBackColor = true;
            this.radioKhachHang.CheckedChanged += new System.EventHandler(this.radioKhachHang_CheckedChanged);
            // 
            // lblKH_NPP
            // 
            this.lblKH_NPP.AutoSize = true;
            this.lblKH_NPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblKH_NPP.Location = new System.Drawing.Point(10, 43);
            this.lblKH_NPP.Name = "lblKH_NPP";
            this.lblKH_NPP.Size = new System.Drawing.Size(98, 20);
            this.lblKH_NPP.TabIndex = 83;
            this.lblKH_NPP.Text = "Khách hàng:";
            // 
            // cobKH_NPP
            // 
            this.cobKH_NPP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cobKH_NPP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cobKH_NPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cobKH_NPP.FormattingEnabled = true;
            this.cobKH_NPP.Location = new System.Drawing.Point(135, 40);
            this.cobKH_NPP.Name = "cobKH_NPP";
            this.cobKH_NPP.Size = new System.Drawing.Size(198, 28);
            this.cobKH_NPP.TabIndex = 82;
            this.cobKH_NPP.TextChanged += new System.EventHandler(this.cobKH_NPP_TextChanged);
            // 
            // frmSuaTraNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 223);
            this.Controls.Add(this.btnTraHetNo);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuuThayDoi);
            this.Controls.Add(this.txtNoMoi);
            this.Controls.Add(this.lblNoMoi);
            this.Controls.Add(this.lblHienThiTraNo);
            this.Controls.Add(this.txtTraNo);
            this.Controls.Add(this.lblTraNo);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.radioNhaPP);
            this.Controls.Add(this.radioKhachHang);
            this.Controls.Add(this.lblKH_NPP);
            this.Controls.Add(this.cobKH_NPP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSuaTraNo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa trả nợ";
            this.Load += new System.EventHandler(this.SuaTraNo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTraHetNo;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuuThayDoi;
        private System.Windows.Forms.TextBox txtNoMoi;
        private System.Windows.Forms.Label lblNoMoi;
        private System.Windows.Forms.Label lblHienThiTraNo;
        private System.Windows.Forms.TextBox txtTraNo;
        private System.Windows.Forms.Label lblTraNo;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.RadioButton radioNhaPP;
        private System.Windows.Forms.RadioButton radioKhachHang;
        private System.Windows.Forms.Label lblKH_NPP;
        private System.Windows.Forms.ComboBox cobKH_NPP;
    }
}