namespace PMQLBH
{
    partial class frmDoiGiaBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiGiaBan));
            this.lblHienThiGia = new System.Windows.Forms.Label();
            this.txtGiaMoi = new System.Windows.Forms.TextBox();
            this.lblGiaMoi = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtGiaCu = new System.Windows.Forms.TextBox();
            this.lblGiaCu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHienThiGia
            // 
            this.lblHienThiGia.AutoSize = true;
            this.lblHienThiGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblHienThiGia.Location = new System.Drawing.Point(135, 73);
            this.lblHienThiGia.Name = "lblHienThiGia";
            this.lblHienThiGia.Size = new System.Drawing.Size(0, 24);
            this.lblHienThiGia.TabIndex = 14;
            // 
            // txtGiaMoi
            // 
            this.txtGiaMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGiaMoi.Location = new System.Drawing.Point(139, 44);
            this.txtGiaMoi.Name = "txtGiaMoi";
            this.txtGiaMoi.Size = new System.Drawing.Size(219, 26);
            this.txtGiaMoi.TabIndex = 12;
            this.txtGiaMoi.TextChanged += new System.EventHandler(this.txtGiaMoi_TextChanged);
            // 
            // lblGiaMoi
            // 
            this.lblGiaMoi.AutoSize = true;
            this.lblGiaMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGiaMoi.Location = new System.Drawing.Point(13, 44);
            this.lblGiaMoi.Name = "lblGiaMoi";
            this.lblGiaMoi.Size = new System.Drawing.Size(67, 20);
            this.lblGiaMoi.TabIndex = 13;
            this.lblGiaMoi.Text = "Giá mới:";
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(188, 100);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(170, 42);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(12, 100);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(170, 42);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "Lưu thay đổi";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtGiaCu
            // 
            this.txtGiaCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGiaCu.Location = new System.Drawing.Point(139, 12);
            this.txtGiaCu.Name = "txtGiaCu";
            this.txtGiaCu.ReadOnly = true;
            this.txtGiaCu.Size = new System.Drawing.Size(219, 26);
            this.txtGiaCu.TabIndex = 17;
            // 
            // lblGiaCu
            // 
            this.lblGiaCu.AutoSize = true;
            this.lblGiaCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGiaCu.Location = new System.Drawing.Point(13, 12);
            this.lblGiaCu.Name = "lblGiaCu";
            this.lblGiaCu.Size = new System.Drawing.Size(59, 20);
            this.lblGiaCu.TabIndex = 18;
            this.lblGiaCu.Text = "Giá cũ:";
            // 
            // frmDoiGiaBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 153);
            this.Controls.Add(this.txtGiaCu);
            this.Controls.Add(this.lblGiaCu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblHienThiGia);
            this.Controls.Add(this.txtGiaMoi);
            this.Controls.Add(this.lblGiaMoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDoiGiaBan";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi giá bán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHienThiGia;
        private System.Windows.Forms.TextBox txtGiaMoi;
        private System.Windows.Forms.Label lblGiaMoi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtGiaCu;
        private System.Windows.Forms.Label lblGiaCu;
    }
}