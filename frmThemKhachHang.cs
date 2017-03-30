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
    public partial class frmThemKhachHang : Form
    {
        frmPMQLBH MainForm;

        private bool ThemKhachHang(string tenKhachHang, string diaChi, string soDienThoai, string loaiKhachHang, string ghiChu)
        {
            QLBH.ChuanHoaXau(ref tenKhachHang);
            QLBH.ChuanHoaXau(ref diaChi);
            QLBH.ChuanHoaXau(ref soDienThoai);
            QLBH.ChuanHoaXau(ref ghiChu);
            try
            {
                if (loaiKhachHang == "Khách hàng thường")
                    QLBH.con.Query(string.Format("insert into khach_hang(ten,dia_chi,sdt,ghi_chu,tg_tao,xe_cho) values('{0}','{1}','{2}','{3}','{4}',{5})", tenKhachHang, diaChi, soDienThoai, ghiChu, QLBH.GetTimeNow(), 0));
                else QLBH.con.Query(string.Format("insert into khach_hang(ten,dia_chi,sdt,ghi_chu,tg_tao,xe_cho) values('{0}','{1}','{2}','{3}','{4}',{5})", tenKhachHang, diaChi, soDienThoai, ghiChu, QLBH.GetTimeNow(), 1));
            }
            catch (Exception er)
            {
                MessageBox.Show("Lỗi: " + er.ToString());
                return false;
            }
            return true;
        }

        public frmThemKhachHang(frmPMQLBH mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void lblTenKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        bool KiemTraThemKhachHang()
        {
            if (txtTenKhachHang.Text == "")
            {
                MessageBox.Show("Tên khách hàng trống!");
                return false;
            }
            if (txtTenKhachHang.Text=="Không tồn tại!!!")
            {
                MessageBox.Show("Tên khách hàng không hợp lệ!");
                return false;
            }
            if (QLBH.TonTaiKhachHang(txtTenKhachHang.Text) == true)
            {
                MessageBox.Show("Khách hàng đã tồn tại!");
                return false;
            }
            return true;
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            if (KiemTraThemKhachHang())
            {
                if (ThemKhachHang(txtTenKhachHang.Text, txtDiaChi.Text, txtSoDienThoai.Text,cobLoaiKhachHang.Text, txtGhiChu.Text))
                {
                    MainForm.ThongBao("Thêm khách hàng " + txtTenKhachHang.Text + " thành công");
                    MainForm.HienThiDanhSachKhachHang();
                    QLBH.CapNhatDanhSachKhachHang();
                    Close();
                }
                else MainForm.ThongBao("Thất bại khi thêm khách hàng " + txtTenKhachHang.Text);
            }
        }

        private void frmThemKhachHang_Load(object sender, EventArgs e)
        {
            cobLoaiKhachHang.SelectedItem = cobLoaiKhachHang.Items[0];
        }
    }
}
