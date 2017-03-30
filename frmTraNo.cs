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
    public partial class frmTraNo : Form
    {
        frmPMQLBH MainForm;
        public frmTraNo(frmPMQLBH mainform)
        {
            InitializeComponent();
            MainForm = mainform;
        }

        void CapNhatDanhSachKhachHangNPP()
        {
            if (radioKhachHang.Checked == true)
                foreach (string KhachHang in QLBH.LayDanhSachKhachHang())
                {
                    cobKH_NPP.Items.Add(KhachHang);
                }
            else foreach (string NPP in QLBH.LayDanhSachNhaPP())
                {
                    cobKH_NPP.Items.Add(NPP);
                }
        }

        public bool TraNo(string ten, string soTien, bool laKhachHang)
        {
            ulong SoTien = ulong.Parse(soTien);
            if (laKhachHang)
            {
                try
                {
                    QLBH.con.Query(string.Format("insert into khach_hang_tra_no(id_khach_hang,tien_tra,tg_tao) values({0},{1},'{2}')", QLBH.LayIdKhachHangTuTenKhachHang(ten), SoTien, QLBH.GetTimeNow()));
                }
                catch (Exception e)
                {
                    MessageBox.Show("Lỗi: " + e.ToString());
                    return false;
                }
            }
            else
            {
                try
                {
                    QLBH.con.Query(string.Format("insert into tra_no_nha_phan_phoi(id_nha_phan_phoi,tien_tra,tg_tao) values({0},{1},'{2}')", QLBH.LayIdNhaPhanPhoiTuTenNPP(ten), SoTien, QLBH.GetTimeNow()));
                }
                catch (Exception e)
                {
                    MessageBox.Show("Lỗi: " + e.ToString());
                    return false;
                }
            }
            return true;
        }

        void CapNhatNoMoi()
        {
            ulong No, TraNo;
            try
            {
               No= ulong.Parse(txtNo.Text, System.Globalization.NumberStyles.AllowThousands);
            }
            catch 
            {
                txtNoMoi.Text = "Không hợp lệ!!!";
                return;
            }
            if (ulong.TryParse(txtTraNo.Text,out TraNo)==false)
            {
                txtNoMoi.Text = "Không hợp lệ!!!";
                return;
            }
            if (No < TraNo)
            {
                txtNoMoi.Text = "Không hợp lệ!!!";
                return;
            }
            txtNoMoi.Text = (No - TraNo).ToString("0,0");
        }

        bool KiemTraTraNo(string ten, string soTien, bool laKhachHang)
        {
            ulong SoTien;
            if (laKhachHang)
            {
                if (ten == "")
                {
                    MessageBox.Show("Tên khách hàng trống");
                    return false;
                }
                if (QLBH.TonTaiKhachHang(ten) == false)
                {
                    MessageBox.Show("Khách hàng không tồn tại");
                    return false;
                }
                if (ulong.TryParse(soTien, out SoTien) == false)
                {
                    MessageBox.Show("Số tiền trả không hợp lệ");
                    return false;
                }
                if (SoTien > QLBH.LayNoCuaKhachHang(QLBH.LayIdKhachHangTuTenKhachHang(ten)))
                {
                    MessageBox.Show("Số tiền trả lớn hơn nợ");
                    return false;
                }
            }
            else
            {
                if (ten == "")
                {
                    MessageBox.Show("Tên nhà phân phối trống");
                    return false;
                }
                if (QLBH.TonTaiNhaPP(ten) == false)
                {
                    MessageBox.Show("Nhà phân phối không tồn tại");
                    return false;
                }
                if (ulong.TryParse(soTien, out SoTien) == false)
                {
                    MessageBox.Show("Số tiền trả không hợp lệ");
                    return false;
                }
                if (SoTien > QLBH.LayNoNhaPhanPhoi(QLBH.LayIdNhaPhanPhoiTuTenNPP(ten)))
                {
                    MessageBox.Show("Số tiền trả lớn hơn nợ");
                    return false;
                }
            }
            return true;
        }

        private void radioKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            if (radioKhachHang.Checked == true)
            {
                cobKH_NPP.Text = "";
                cobKH_NPP.Items.Clear();
                CapNhatDanhSachKhachHangNPP();
                lblKH_NPP.Text = "Khách hàng:";
            }
        }

        private void radioNhaPP_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNhaPP.Checked == true)
            {
                cobKH_NPP.Text = "";
                cobKH_NPP.Items.Clear();
                CapNhatDanhSachKhachHangNPP();
                lblKH_NPP.Text = "Nhà phân phối:";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTraNo_Load(object sender, EventArgs e)
        {
            CapNhatDanhSachKhachHangNPP();
        }

        private void txtTraNo_TextChanged(object sender, EventArgs e)
        {
            ulong TraNo;
            if (ulong.TryParse(txtTraNo.Text, out TraNo))
            {
                lblHienThiTraNo.Text = TraNo.ToString("0,0");
                CapNhatNoMoi();
            }
            else lblHienThiTraNo.Text = "Không hợp lệ!!!";
        }

        private void btnTraNo_Click(object sender, EventArgs e)
        {
            if (KiemTraTraNo(cobKH_NPP.Text, txtTraNo.Text, radioKhachHang.Checked))
            {
                if (TraNo(cobKH_NPP.Text, txtTraNo.Text, radioKhachHang.Checked))
                {
                    MainForm.ThongBao("Trả nợ thành công");
                    MainForm.HienThiDanhSachTraNo();
                    Close();
                }
                else MainForm.ThongBao("Có lỗi trong quá trình trả nợ");
            }
        }

        private void cobKH_NPP_TextChanged(object sender, EventArgs e)
        {
            if (radioKhachHang.Checked)
            {
                if (QLBH.TonTaiKhachHang(cobKH_NPP.Text))
                    txtNo.Text = QLBH.LayNoCuaKhachHang(QLBH.LayIdKhachHangTuTenKhachHang(cobKH_NPP.Text)).ToString("0,0");
            }
            else
            {
                if (QLBH.TonTaiNhaPP(cobKH_NPP.Text))
                    txtNo.Text = QLBH.LayNoNhaPhanPhoi(QLBH.LayIdNhaPhanPhoiTuTenNPP(cobKH_NPP.Text)).ToString("0,0");
            }
        }

        private void btnTraHetNo_Click(object sender, EventArgs e)
        {
            try
            {
                txtTraNo.Text=(ulong.Parse(txtNo.Text, System.Globalization.NumberStyles.AllowThousands)).ToString();
            }
            catch
            {
                
            }
        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {
            CapNhatNoMoi();
        }
    }
}
