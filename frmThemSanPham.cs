using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SQLite;
using Dapper;

namespace PMQLBH
{
    public partial class frmThemSanPham : Form
    {
        frmPMQLBH MainForm;
        public frmThemSanPham(frmPMQLBH mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        public bool KiemTraThemSanPham(string tenSanPham, string maSanPham, string donViTinh, string gia, string ghiChu)
        {
            ulong Gia;
            double SoLuong;
            if (tenSanPham == "")
            {
                MessageBox.Show("Tên sản phẩm trống!");
                return false;
            }
            if (tenSanPham == "Không hợp lệ!!!")
            {
                MessageBox.Show("Tên sản phẩm không hợp lệ!");
                return false;
            }
            if (QLBH.TonTaiSanPham(tenSanPham))
            {
                MessageBox.Show("Tên sản phẩm đã tồn tại!");
                return false;
            }
            if (maSanPham == "")
            {
                MessageBox.Show("Mã sản phẩm trống!");
                return false;
            }
            if (QLBH.TonTaiMaSanPham(maSanPham))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!");
                return false;
            }
            if (donViTinh == "")
            {
                MessageBox.Show("Đơn vị tính trống!");
                return false;
            }
            return true;
        }

        public bool ThemSanPham(string tenSanPham, string maSanPham, string donViTinh, string gia, string ghiChu)
        {
            QLBH.ChuanHoaXau(ref tenSanPham);
            QLBH.ChuanHoaXau(ref maSanPham);
            QLBH.ChuanHoaXau(ref donViTinh);
            QLBH.ChuanHoaXau(ref ghiChu);
            ulong Gia;
            double SoLuong;
            Gia = ulong.Parse(gia);
            try
            {
                QLBH.con.Query(string.Format("insert into san_pham(ten,ma,don_vi_tinh,gia,so_luong,so_luong_ban_dau,ghi_chu,tg_tao) values('{0}','{1}','{2}',{3},{4},{5},'{6}','{7}')", tenSanPham, maSanPham, donViTinh, Gia, 0, numudSoLuongBanDau.Value.ToString("0.0"), ghiChu, QLBH.GetTimeNow()));
            }
            catch (Exception er)
            {
                MessageBox.Show("Lỗi: " + er.ToString());
                return false;
            }
            return true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            ulong gia;
            if (ulong.TryParse(txtGia.Text, out gia))
            {
                lblHienThiGia.Text = gia.ToString("0,0") + " VND/" + txtDonViTinh.Text;
            }
            else lblHienThiGia.Text = "Giá không hợp lệ!";
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            if (KiemTraThemSanPham(txtTenSanPham.Text, txtMaSanPham.Text, txtDonViTinh.Text, txtGia.Text, txtGhiChu.Text))
                if (ThemSanPham(txtTenSanPham.Text, txtMaSanPham.Text, txtDonViTinh.Text, txtGia.Text, txtGhiChu.Text))
                {
                    MainForm.ThongBao("Thêm sản phẩm " + txtTenSanPham.Text + " thành công");
                    MainForm.HienThiDanhSachSanPham();
                    QLBH.CapNhatDanhSachSanPham();
                    Close();
                }
                else MainForm.ThongBao("Thất bại khi thêm sản phẩm " + txtTenSanPham.Text);
        }

        private void txtDonViTinh_TextChanged(object sender, EventArgs e)
        {
            ulong gia;
            if (ulong.TryParse(txtGia.Text, out gia))
            {
                lblHienThiGia.Text = gia.ToString("0,0") + " VND/" + txtDonViTinh.Text;
            }
            else lblHienThiGia.Text = "Giá không hợp lệ!";
        }
    }
}
