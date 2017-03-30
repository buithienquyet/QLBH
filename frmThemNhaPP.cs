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
    public partial class frmThemNhaPP : Form
    {
        frmPMQLBH MainForm;

        private bool ThemNhaPP(string tenNhaPP, string diaChi, string soDienThoai, string ghiChu)
        {
            QLBH.ChuanHoaXau(ref tenNhaPP);
            QLBH.ChuanHoaXau(ref diaChi);
            QLBH.ChuanHoaXau(ref soDienThoai);
            QLBH.ChuanHoaXau(ref ghiChu);
            try
            {
                QLBH.con.Query(string.Format("insert into nha_phan_phoi(ten,dia_chi,sdt,ghi_chu,tg_tao) values('{0}','{1}','{2}','{3}','{4}')", tenNhaPP, diaChi, soDienThoai, ghiChu, QLBH.GetTimeNow()));
            }
            catch (Exception er)
            {
                MessageBox.Show("Lỗi: " + er.ToString());
                return false;
            }
            return true;
        }

        public frmThemNhaPP(frmPMQLBH mainForm)
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
        private void btnThemNhaPP_Click(object sender, EventArgs e)
        {
            if (txtTenNhaPP.Text != "" && QLBH.TonTaiNhaPP(txtTenNhaPP.Text) == false)
            {
                if (ThemNhaPP(txtTenNhaPP.Text, txtDiaChi.Text, txtSoDienThoai.Text, txtGhiChu.Text))
                {
                    MainForm.ThongBao("Thêm nhà phân phối " + txtTenNhaPP.Text + " thành công");
                    MainForm.HienThiDanhSachNhaPP();
                    QLBH.CapNhatDanhSachNhaPhanPhoi();
                    Close();
                }
                else MainForm.ThongBao("Thất bại khi thêm nhà phân phối " + txtTenNhaPP.Text);
            }
            else
            {
                if (txtTenNhaPP.Text == "")
                {
                    MessageBox.Show("Tên nhà phân phối trống!");
                }
                else
                    MessageBox.Show("Nhà phân phối đã tồn tại!");
            }
        }
    }
}
