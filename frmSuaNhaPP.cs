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
    public partial class frmSuaNhaPP : Form
    {
        string Id,TenNhaPP;
        frmPMQLBH MainForm;
        public frmSuaNhaPP(frmPMQLBH mainForm, string id, string tenNhaPP, string diaChi, string soDienThoai, string ghiChu)
        {
            InitializeComponent();
            TenNhaPP = tenNhaPP;
            Id = id;
            txtTenNhaPP.Text = tenNhaPP;
            txtDiaChi.Text = diaChi;
            txtSoDienThoai.Text = soDienThoai;
            txtGhiChu.Text = ghiChu;
            MainForm = mainForm;
        }

        public bool SuaNhaPP(string id, string tenNhaPP, string diaChi, string soDienThoai, string ghiChu)
        {
            QLBH.ChuanHoaXau(ref tenNhaPP);
            QLBH.ChuanHoaXau(ref diaChi);
            QLBH.ChuanHoaXau(ref soDienThoai);
            QLBH.ChuanHoaXau(ref ghiChu);
            try
            {
                QLBH.con.Query(string.Format("update nha_phan_phoi set ten='{0}',dia_chi='{1}',sdt='{2}',ghi_chu='{3}' where id={4}", tenNhaPP, diaChi, soDienThoai, ghiChu, id));
            }
            catch (Exception er)
            {
                MessageBox.Show("Lỗi: " + er.ToString());
                return false;
            }
            return true;
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
            if (txtTenNhaPP.Text != "")
            {
                if (txtTenNhaPP.Text == TenNhaPP) //Tên nhà phân phối không thay đổi
                {
                    if (SuaNhaPP(Id, txtTenNhaPP.Text, txtDiaChi.Text, txtSoDienThoai.Text, txtGhiChu.Text) == true)
                    {
                        MainForm.ThongBao("Sửa nhà phân phối " + TenNhaPP + " thành công");
                        MainForm.HienThiDanhSachNhaPP();
                        QLBH.CapNhatDanhSachNhaPhanPhoi();
                        Close();
                    }
                    else MainForm.ThongBao("Thất bại khi sửa nhà phân phối " + TenNhaPP);
                }
                else if (QLBH.TonTaiNhaPP(txtTenNhaPP.Text) == false) //Thay đổi tên nhà phân phối, kiểm tra có trùng tên không
                {
                    if (SuaNhaPP(Id, txtTenNhaPP.Text, txtDiaChi.Text, txtSoDienThoai.Text, txtGhiChu.Text) == true)
                    {
                        MainForm.ThongBao("Sửa nhà phân phối " + TenNhaPP + " thành công");
                        MainForm.HienThiDanhSachNhaPP();
                        QLBH.CapNhatDanhSachNhaPhanPhoi();
                        Close();
                    }
                    else MainForm.ThongBao("Thất bại khi sửa nhà phân phối " + txtTenNhaPP.Text);
                }
                else MessageBox.Show("Tên nhà phân phối đã tồn tại!");
            }
            else MessageBox.Show("Tên nhà phân phối trống!");
        }
    }
}
