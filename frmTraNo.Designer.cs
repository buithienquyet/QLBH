namespace PMQLBH
{
    partial class frmTraNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraNo));
            this.lblKH_NPP = new System.Windows.Forms.Label();
            this.cobKH_NPP = new System.Windows.Forms.ComboBox();
            this.radioKhachHang = new System.Windows.Forms.RadioButton();
            this.radioNhaPP = new System.Windows.Forms.RadioButton();
            this.txtTraNo = new System.Windows.Forms.TextBox();
            this.lblTraNo = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblHienThiTraNo = new System.Windows.Forms.Label();
            this.txtNoMoi = new System.Windows.Forms.TextBox();
            this.lblNoMoi = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTraNo = new System.Windows.Forms.Button();
            this.btnTraHetNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKH_NPP
            // 
            this.lblKH_NPP.AutoSize = true;
            this.lblKH_NPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblKH_NPP.Location = new System.Drawing.Point(8, 45);
            this.lblKH_NPP.Name = "lblKH_NPP";
            this.lblKH_NPP.Size = new System.Drawing.Size(98, 20);
            this.lblKH_NPP.TabIndex = 42;
            this.lblKH_NPP.Text = "Khách hàng:";
            // 
            // cobKH_NPP
            // 
            this.cobKH_NPP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cobKH_NPP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cobKH_NPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cobKH_NPP.FormattingEnabled = true;
            this.cobKH_NPP.Location = new System.Drawing.Point(133, 42);
            this.cobKH_NPP.Name = "cobKH_NPP";
            this.cobKH_NPP.Size = new System.Drawing.Size(198, 28);
            this.cobKH_NPP.TabIndex = 41;
            this.cobKH_NPP.TextChanged += new System.EventHandler(this.cobKH_NPP_TextChanged);
            // 
            // radioKhachHang
            // 
            this.radioKhachHang.AutoSize = true;
            this.radioKhachHang.Checked = true;
            this.radioKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioKhachHang.Location = new System.Drawing.Point(108, 12);
            this.radioKhachHang.Name = "radioKhachHang";
            this.radioKhachHang.Size = new System.Drawing.Size(112, 24);
            this.radioKhachHang.TabIndex = 43;
            this.radioKhachHang.TabStop = true;
            this.radioKhachHang.Text = "Khách hàng";
            this.radioKhachHang.UseVisualStyleBackColor = true;
            this.radioKhachHang.CheckedChanged += new System.EventHandler(this.radioKhachHang_CheckedChanged);
            // 
            // radioNhaPP
            // 
            this.radioNhaPP.AutoSize = true;
            this.radioNhaPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioNhaPP.Location = new System.Drawing.Point(226, 12);
            this.radioNhaPP.Name = "radioNhaPP";
            this.radioNhaPP.Size = new System.Drawing.Size(130, 24);
            this.radioNhaPP.TabIndex = 44;
            this.radioNhaPP.Text = "Nhà phân phối";
            this.radioNhaPP.UseVisualStyleBackColor = true;
            this.radioNhaPP.CheckedChanged += new System.EventHandler(this.radioNhaPP_CheckedChanged);
            // 
            // txtTraNo
            // 
            this.txtTraNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTraNo.Location = new System.Drawing.Point(133, 108);
            this.txtTraNo.Name = "txtTraNo";
            this.txtTraNo.Size = new System.Drawing.Size(198, 26);
            this.txtTraNo.TabIndex = 74;
            this.txtTraNo.Text = "0";
            this.txtTraNo.TextChanged += new System.EventHandler(this.txtTraNo_TextChanged);
            // 
            // lblTraNo
            // 
            this.lblTraNo.AutoSize = true;
            this.lblTraNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTraNo.Location = new System.Drawing.Point(8, 111);
            this.lblTraNo.Name = "lblTraNo";
            this.lblTraNo.Size = new System.Drawing.Size(58, 20);
            this.lblTraNo.TabIndex = 73;
            this.lblTraNo.Text = "Trả nợ:";
            // 
            // txtNo
            // 
            this.txtNo.Enabled = false;
            this.txtNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNo.Location = new System.Drawing.Point(133, 76);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(198, 26);
            this.txtNo.TabIndex = 72;
            this.txtNo.TabStop = false;
            this.txtNo.Text = "0";
            this.txtNo.TextChanged += new System.EventHandler(this.txtNo_TextChanged);
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNo.Location = new System.Drawing.Point(8, 79);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(33, 20);
            this.lblNo.TabIndex = 71;
            this.lblNo.Text = "Nợ:";
            // 
            // lblHienThiTraNo
            // 
            this.lblHienThiTraNo.AutoSize = true;
            this.lblHienThiTraNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblHienThiTraNo.Location = new System.Drawing.Point(337, 105);
            this.lblHienThiTraNo.Name = "lblHienThiTraNo";
            this.lblHienThiTraNo.Size = new System.Drawing.Size(0, 24);
            this.lblHienThiTraNo.TabIndex = 76;
            // 
            // txtNoMoi
            // 
            this.txtNoMoi.Enabled = false;
            this.txtNoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNoMoi.Location = new System.Drawing.Point(133, 140);
            this.txtNoMoi.Name = "txtNoMoi";
            this.txtNoMoi.Size = new System.Drawing.Size(198, 26);
            this.txtNoMoi.TabIndex = 78;
            this.txtNoMoi.TabStop = false;
            this.txtNoMoi.Text = "0";
            // 
            // lblNoMoi
            // 
            this.lblNoMoi.AutoSize = true;
            this.lblNoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNoMoi.Location = new System.Drawing.Point(8, 143);
            this.lblNoMoi.Name = "lblNoMoi";
            this.lblNoMoi.Size = new System.Drawing.Size(62, 20);
            this.lblNoMoi.TabIndex = 77;
            this.lblNoMoi.Text = "Nợ mới:";
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(239, 172);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(170, 42);
            this.btnHuy.TabIndex = 80;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTraNo
            // 
            this.btnTraNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTraNo.Image = ((System.Drawing.Image)(resources.GetObject("btnTraNo.Image")));
            this.btnTraNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraNo.Location = new System.Drawing.Point(63, 172);
            this.btnTraNo.Name = "btnTraNo";
            this.btnTraNo.Size = new System.Drawing.Size(170, 42);
            this.btnTraNo.TabIndex = 79;
            this.btnTraNo.Text = "Trả nợ";
            this.btnTraNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTraNo.UseVisualStyleBackColor = true;
            this.btnTraNo.Click += new System.EventHandler(this.btnTraNo_Click);
            // 
            // btnTraHetNo
            // 
            this.btnTraHetNo.Location = new System.Drawing.Point(337, 76);
            this.btnTraHetNo.Name = "btnTraHetNo";
            this.btnTraHetNo.Size = new System.Drawing.Size(124, 26);
            this.btnTraHetNo.TabIndex = 81;
            this.btnTraHetNo.TabStop = false;
            this.btnTraHetNo.Text = "Trả toàn bộ";
            this.btnTraHetNo.UseVisualStyleBackColor = true;
            this.btnTraHetNo.Click += new System.EventHandler(this.btnTraHetNo_Click);
            // 
            // frmTraNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 223);
            this.Controls.Add(this.btnTraHetNo);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTraNo);
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
            this.MaximizeBox = false;
            this.Name = "frmTraNo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trả nợ";
            this.Load += new System.EventHandler(this.frmTraNo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKH_NPP;
        private System.Windows.Forms.ComboBox cobKH_NPP;
        private System.Windows.Forms.RadioButton radioKhachHang;
        private System.Windows.Forms.RadioButton radioNhaPP;
        private System.Windows.Forms.TextBox txtTraNo;
        private System.Windows.Forms.Label lblTraNo;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblHienThiTraNo;
        private System.Windows.Forms.TextBox txtNoMoi;
        private System.Windows.Forms.Label lblNoMoi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTraNo;
        private System.Windows.Forms.Button btnTraHetNo;
    }
}