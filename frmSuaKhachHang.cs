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
    public partial class frmSuaKhachHang : Form
    {
        string Id,TenKhachHang;
        frmPMQLBH MainForm;

        public bool SuaKhachHang(string id, string tenKhachHang, string diaChi, string soDienThoai, string ghiChu)
        {
            QLBH.ChuanHoaXau(ref tenKhachHang);
            QLBH.ChuanHoaXau(ref diaChi);
            QLBH.ChuanHoaXau(ref soDienThoai);
            QLBH.ChuanHoaXau(ref ghiChu);
            try
            {
                QLBH.con.Query(string.Format("update khach_hang set ten='{0}',dia_chi='{1}',sdt='{2}',ghi_chu='{3}' where id={4}", tenKhachHang, diaChi, soDienThoai, ghiChu, id));
            }
            catch (Exception er)
            {
                MessageBox.Show("Lỗi: " + er.ToString());
                return false;
            }
            return true;
        }

        public frmSuaKhachHang(frmPMQLBH mainForm, string id, string tenKhachHang, string diaChi, string soDienThoai, string ghiChu)
        {
            InitializeComponent();
            TenKhachHang = tenKhachHang;
            Id = id;
            txtTenKhachHang.Text = tenKhachHang;
            txtDiaChi.Text = diaChi;
            txtSoDienThoai.Text = soDienThoai;
            txtGhiChu.Text = ghiChu;
            MainForm = mainForm;
        }

        private void lblTenKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            if (txtTenKhachHang.Text != "")
            {
                if (txtTenKhachHang.Text == TenKhachHang) //Tên khách hàng không thay đổi
                {
                    if (SuaKhachHang(Id, txtTenKhachHang.Text, txtDiaChi.Text, txtSoDienThoai.Text, txtGhiChu.Text) == true)
                    {
                        MainForm.ThongBao("Sửa khách hàng " + TenKhachHang + " thành công");
                        MainForm.HienThiDanhSachKhachHang();
                        QLBH.CapNhatDanhSachKhachHang();
                        Close();
                    }
                    else MainForm.ThongBao("Thất bại khi sửa khách hàng " + TenKhachHang);
                }
                else if (QLBH.TonTaiKhachHang(txtTenKhachHang.Text) == false) //Thay đổi tên khách hàng, kiểm tra có trùng tên không
                {
                    if (SuaKhachHang(Id, txtTenKhachHang.Text, txtDiaChi.Text, txtSoDienThoai.Text, txtGhiChu.Text) == true)
                    {
                        MainForm.ThongBao("Sửa khách hàng " + TenKhachHang + " thành công");
                        MainForm.HienThiDanhSachKhachHang();
                     
                        QLBH.CapNhatDanhSachKhachHang();
                        Close();
                    }
                    else MainForm.ThongBao("Thất bại khi sửa khách hàng " + txtTenKhachHang.Text);
                }
                else MessageBox.Show("Tên khách hàng đã tồn tại!");
            }
            else MessageBox.Show("Tên khách hàng trống!");
        }
    }
}
