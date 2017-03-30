using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dapper;

namespace PMQLBH
{
    public partial class frmThayDoiThongTinSanPham : Form
    {
        frmPMQLBH MainForm;
        string IdCu;
        string TenSanPhamCu;
        string MaSanPhamCu;
        public frmThayDoiThongTinSanPham(frmPMQLBH mainForm, string id)
        {
            InitializeComponent();
            MainForm = mainForm;
            IdCu = id;
            txtTenSanPham.Text = TenSanPhamCu = QLBH.LayTenSanPhamTuId(id);
            txtMaSanPham.Text = MaSanPhamCu = QLBH.LayMaSanPhamTuIdSanPham(id);
            txtDonViTinh.Text = QLBH.LayDonViTinhSanPhamTuId(id);
            txtGhiChu.Text = QLBH.LayGhiChuSanPhamTuId(id);
            numudSoLuongBanDau.Value = QLBH.con.QueryFirst<decimal>("select so_luong_ban_dau from san_pham where id=" + id);
        }

        private bool ThayDoiThongTinSanPham(string id, string tenSanPham, string maSanPham, string donViTinh, string ghiChu)
        {
            QLBH.ChuanHoaXau(ref tenSanPham);
            QLBH.ChuanHoaXau(ref maSanPham);
            QLBH.ChuanHoaXau(ref donViTinh);
            QLBH.ChuanHoaXau(ref ghiChu);
            try
            {
                QLBH.con.Query(string.Format("update san_pham set ten='{0}',ma='{1}',don_vi_tinh='{2}',so_luong_ban_dau ={3},ghi_chu='{4}' where id={5}", tenSanPham, maSanPham, donViTinh,numudSoLuongBanDau.Value.ToString("0.0"), ghiChu, id));
            }
            catch (Exception er)
            {
                MessageBox.Show("Lỗi: " + er.ToString());
                return false;
            }
            return true;
        }

        bool KiemTraLuuThayDoi()
        {
           
            if (txtTenSanPham.Text == "")
            {
                MessageBox.Show("Tên sản phẩm trống!");
                return false;
            }
            if (txtTenSanPham.Text == "Không hợp lệ!!!")
            {
                MessageBox.Show("Tên sản phẩm không hợp lệ!");
                return false;
            }
            if (txtMaSanPham.Text == "")
            {
                MessageBox.Show("Mã sản phẩm trống!");
                return false;
            }
            if (txtMaSanPham.Text == "Không hợp lệ!!!")
            {
                MessageBox.Show("Mã sản phẩm không hợp lệ!");
                return false;
            }
            if (txtDonViTinh.Text == "")
            {
                MessageBox.Show("Đơn vị tính trống!");
                return false;
            }
            if (txtTenSanPham.Text != TenSanPhamCu)
                if (QLBH.TonTaiSanPham(txtTenSanPham.Text))
                {
                    MessageBox.Show("Tên sản phẩm đã tồn tại!");
                    return false;
                    
                }
            if (txtMaSanPham.Text != MaSanPhamCu)
                if (QLBH.TonTaiMaSanPham(txtMaSanPham.Text))
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại!");
                    return false;
                }
            return true;
        }

        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            if (KiemTraLuuThayDoi())
                if (ThayDoiThongTinSanPham(IdCu, txtTenSanPham.Text, txtMaSanPham.Text, txtDonViTinh.Text, txtGhiChu.Text))
                {
                    MainForm.ThongBao("Thay đổi thông tin sản phẩm " + TenSanPhamCu + " thành công");
                    MainForm.HienThiDanhSachSanPham();
                    QLBH.CapNhatDanhSachSanPham();
                    Close();
                }
                else MessageBox.Show("Thay đổi thông tin sản phẩm " + TenSanPhamCu + " thất bại");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmThayDoiThongTinSanPham_Load(object sender, EventArgs e)
        {

        }
    }
}
