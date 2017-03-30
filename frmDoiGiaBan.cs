using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMQLBH
{
    public partial class frmDoiGiaBan : Form
    {
        frmPMQLBH QLBH;
        string DonViTinh;
        string Id;
        public frmDoiGiaBan(frmPMQLBH mainform,string id, string giaCu, string donViTinh)
        {
            InitializeComponent();
            QLBH = mainform;
            txtGiaCu.Text = ulong.Parse(giaCu).ToString("0,0");
            DonViTinh = donViTinh;
            Id = id;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            ulong gia;
            if (ulong.TryParse(txtGiaMoi.Text, out gia))
            {
                if (QLBH.DoiGiaBan(Id, gia))
                {
                    QLBH.ThongBao("Đổi giá bán từ " + txtGiaCu.Text + " thành " + gia.ToString("0,0") + " thành công");
                    QLBH.HienThiDanhSachSanPham();
                    Close();
                }
                else QLBH.ThongBao("Có lỗi trong quá trình đổi giá bán!");
            }
            else MessageBox.Show("Bạn nhập giá mới chưa hợp lê!");
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtGiaMoi_TextChanged(object sender, EventArgs e)
        {
            ulong gia;
            if (ulong.TryParse(txtGiaMoi.Text, out gia))
            {
                lblHienThiGia.Text = gia.ToString("0,0") + " VND/" + DonViTinh;
            }
            else lblHienThiGia.Text = "Giá không hợp lệ!";
        }
    }
}
