namespace PMQLBH
{
    partial class frmXemHoaDonNhap
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
            this.lblHienThiThanhToan = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtConNo = new System.Windows.Forms.TextBox();
            this.lblConNo = new System.Windows.Forms.Label();
            this.txtThanhToan = new System.Windows.Forms.TextBox();
            this.lblThanhToan = new System.Windows.Forms.Label();
            this.txtTongThanhTien = new System.Windows.Forms.TextBox();
            this.lblTongThanhTien = new System.Windows.Forms.Label();
            this.lblDanhSachSanPham = new System.Windows.Forms.Label();
            this.lblNhaPhanPhoi = new System.Windows.Forms.Label();
            this.dgdDanhSachSanPham = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNhaPhanPhoi = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDanhSachSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHienThiThanhToan
            // 
            this.lblHienThiThanhToan.AutoSize = true;
            this.lblHienThiThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblHienThiThanhToan.Location = new System.Drawing.Point(366, 493);
            this.lblHienThiThanhToan.Name = "lblHienThiThanhToan";
            this.lblHienThiThanhToan.Size = new System.Drawing.Size(0, 24);
            this.lblHienThiThanhToan.TabIndex = 70;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGhiChu.Location = new System.Drawing.Point(373, 428);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(68, 20);
            this.lblGhiChu.TabIndex = 69;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Enabled = false;
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGhiChu.Location = new System.Drawing.Point(377, 451);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(792, 100);
            this.txtGhiChu.TabIndex = 68;
            this.txtGhiChu.TabStop = false;
            // 
            // txtConNo
            // 
            this.txtConNo.Enabled = false;
            this.txtConNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtConNo.Location = new System.Drawing.Point(138, 525);
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
            this.lblConNo.Location = new System.Drawing.Point(8, 528);
            this.lblConNo.Name = "lblConNo";
            this.lblConNo.Size = new System.Drawing.Size(64, 20);
            this.lblConNo.TabIndex = 66;
            this.lblConNo.Text = "Còn nợ:";
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.Enabled = false;
            this.txtThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtThanhToan.Location = new System.Drawing.Point(138, 493);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.Size = new System.Drawing.Size(222, 26);
            this.txtThanhToan.TabIndex = 65;
            this.txtThanhToan.TabStop = false;
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.AutoSize = true;
            this.lblThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblThanhToan.Location = new System.Drawing.Point(8, 496);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.Size = new System.Drawing.Size(94, 20);
            this.lblThanhToan.TabIndex = 64;
            this.lblThanhToan.Text = "Thanh toán:";
            // 
            // txtTongThanhTien
            // 
            this.txtTongThanhTien.Enabled = false;
            this.txtTongThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTongThanhTien.Location = new System.Drawing.Point(138, 461);
            this.txtTongThanhTien.Name = "txtTongThanhTien";
            this.txtTongThanhTien.ReadOnly = true;
            this.txtTongThanhTien.Size = new System.Drawing.Size(222, 26);
            this.txtTongThanhTien.TabIndex = 63;
            this.txtTongThanhTien.TabStop = false;
            // 
            // lblTongThanhTien
            // 
            this.lblTongThanhTien.AutoSize = true;
            this.lblTongThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTongThanhTien.Location = new System.Drawing.Point(8, 464);
            this.lblTongThanhTien.Name = "lblTongThanhTien";
            this.lblTongThanhTien.Size = new System.Drawing.Size(124, 20);
            this.lblTongThanhTien.TabIndex = 62;
            this.lblTongThanhTien.Text = "Tổng thành tiền:";
            // 
            // lblDanhSachSanPham
            // 
            this.lblDanhSachSanPham.AutoSize = true;
            this.lblDanhSachSanPham.Font = new System.Drawing.Font("Arial", 16F);
            this.lblDanhSachSanPham.Location = new System.Drawing.Point(459, 15);
            this.lblDanhSachSanPham.Name = "lblDanhSachSanPham";
            this.lblDanhSachSanPham.Size = new System.Drawing.Size(266, 25);
            this.lblDanhSachSanPham.TabIndex = 41;
            this.lblDanhSachSanPham.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // lblNhaPhanPhoi
            // 
            this.lblNhaPhanPhoi.AutoSize = true;
            this.lblNhaPhanPhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNhaPhanPhoi.Location = new System.Drawing.Point(8, 428);
            this.lblNhaPhanPhoi.Name = "lblNhaPhanPhoi";
            this.lblNhaPhanPhoi.Size = new System.Drawing.Size(116, 20);
            this.lblNhaPhanPhoi.TabIndex = 40;
            this.lblNhaPhanPhoi.Text = "Nhà phân phối:";
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
            this.colSTT});
            this.dgdDanhSachSanPham.EnableHeadersVisualStyles = false;
            this.dgdDanhSachSanPham.Location = new System.Drawing.Point(12, 43);
            this.dgdDanhSachSanPham.MultiSelect = false;
            this.dgdDanhSachSanPham.Name = "dgdDanhSachSanPham";
            this.dgdDanhSachSanPham.ReadOnly = true;
            this.dgdDanhSachSanPham.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgdDanhSachSanPham.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgdDanhSachSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdDanhSachSanPham.Size = new System.Drawing.Size(1157, 379);
            this.dgdDanhSachSanPham.TabIndex = 39;
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
            // txtNhaPhanPhoi
            // 
            this.txtNhaPhanPhoi.Enabled = false;
            this.txtNhaPhanPhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNhaPhanPhoi.Location = new System.Drawing.Point(138, 428);
            this.txtNhaPhanPhoi.Name = "txtNhaPhanPhoi";
            this.txtNhaPhanPhoi.ReadOnly = true;
            this.txtNhaPhanPhoi.Size = new System.Drawing.Size(222, 26);
            this.txtNhaPhanPhoi.TabIndex = 71;
            this.txtNhaPhanPhoi.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnOK.Image = global::PMQLBH.Properties.Resources.Check_icon2;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(507, 557);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(170, 42);
            this.btnOK.TabIndex = 58;
            this.btnOK.TabStop = false;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmXemHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.txtNhaPhanPhoi);
            this.Controls.Add(this.lblHienThiThanhToan);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtConNo);
            this.Controls.Add(this.lblConNo);
            this.Controls.Add(this.txtThanhToan);
            this.Controls.Add(this.lblThanhToan);
            this.Controls.Add(this.txtTongThanhTien);
            this.Controls.Add(this.lblTongThanhTien);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblDanhSachSanPham);
            this.Controls.Add(this.lblNhaPhanPhoi);
            this.Controls.Add(this.dgdDanhSachSanPham);
            this.MaximizeBox = false;
            this.Name = "frmXemHoaDonNhap";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem hóa đơn nhập";
            this.Load += new System.EventHandler(this.frmXemHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdDanhSachSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHienThiThanhToan;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtConNo;
        private System.Windows.Forms.Label lblConNo;
        private System.Windows.Forms.TextBox txtThanhToan;
        private System.Windows.Forms.Label lblThanhToan;
        private System.Windows.Forms.TextBox txtTongThanhTien;
        private System.Windows.Forms.Label lblTongThanhTien;
        private System.Windows.Forms.Label lblDanhSachSanPham;
        private System.Windows.Forms.Label lblNhaPhanPhoi;
        private System.Windows.Forms.DataGridView dgdDanhSachSanPham;
        private System.Windows.Forms.TextBox txtNhaPhanPhoi;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
    }
}