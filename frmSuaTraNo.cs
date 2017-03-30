using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using Dapper;

namespace PMQLBH
{
    public partial class frmSuaTraNo : Form
    {
        string IdHoaDon;
        string Loai;
        string ThoiDiem;
        frmPMQLBH MainForm;
        public frmSuaTraNo(frmPMQLBH mainForm, string idHoaDon, string loai)
        {
            InitializeComponent();
            MainForm = mainForm;
            IdHoaDon = idHoaDon;
            Loai = loai;
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

        void CapNhatNoMoi()
        {
            ulong No, TraNo;
            try
            {
                No = ulong.Parse(txtNo.Text, System.Globalization.NumberStyles.AllowThousands);
            }
            catch
            {
                txtNoMoi.Text = "Không hợp lệ!!!";
                return;
            }
            if (ulong.TryParse(txtTraNo.Text, out TraNo) == false)
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
                if (SoTien > (ulong)QLBH.LayNoCuaKhachHangTinhDenThoiDiemTruThoiDiemDoKhongAm(QLBH.LayIdKhachHangTuTenKhachHang(cobKH_NPP.Text), ThoiDiem))
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
                if (SoTien > (ulong)QLBH.LayNoNhaPPTinhDenThoiDiemTruThoiDiemDo(QLBH.LayIdNhaPhanPhoiTuTenNPP(cobKH_NPP.Text), ThoiDiem))
                {
                    MessageBox.Show("Số tiền trả lớn hơn nợ");
                    return false;
                }
            }
            return true;
        }

        bool LuuThayDoiTraNo(string ten, string soTien, bool laKhachHang)
        {
            SQLiteTransaction transLuuThayDoi = QLBH.con.BeginTransaction();
            try
            {
                if (Loai == "Khách hàng")
                    QLBH.con.Query("delete from khach_hang_tra_no where id=" + IdHoaDon);
                else QLBH.con.Query("delete from tra_no_nha_phan_phoi where id=" + IdHoaDon);

                if (laKhachHang)
                    QLBH.con.Query(string.Format("insert into khach_hang_tra_no(id_khach_hang,tien_tra,tg_tao) values({0},{1},'{2}')", QLBH.LayIdKhachHangTuTenKhachHang(ten), soTien, ThoiDiem));
                else QLBH.con.Query(string.Format("insert into tra_no_nha_phan_phoi(id_nha_phan_phoi,tien_tra,tg_tao) values({0},{1},'{2}')", QLBH.LayIdNhaPhanPhoiTuTenNPP(ten), soTien, ThoiDiem));
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.ToString());
                return false;
            }
            return true;
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

        private void SuaTraNo_Load(object sender, EventArgs e)
        {
            if (Loai == "Khách hàng")
            {
                radioKhachHang.Checked = true;
                ThoiDiem = QLBH.LayThoiDiemTuIdHoaDonTraNo(IdHoaDon, true);
                cobKH_NPP.Text = QLBH.LayTenKhachHang_NhaPPTuIdHoaDonTraNo(IdHoaDon, true);
                txtTraNo.Text = QLBH.LaySoTienTuIdHoaDonTraNo(IdHoaDon, true).ToString();
            }
            else
            {
                radioNhaPP.Checked = true;
                ThoiDiem = QLBH.LayThoiDiemTuIdHoaDonTraNo(IdHoaDon, false);
                cobKH_NPP.Text = QLBH.LayTenKhachHang_NhaPPTuIdHoaDonTraNo(IdHoaDon, false);
                txtTraNo.Text = QLBH.LaySoTienTuIdHoaDonTraNo(IdHoaDon, false).ToString();
            }
        }

        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            if (KiemTraTraNo(cobKH_NPP.Text, txtTraNo.Text, radioKhachHang.Checked))
                if (LuuThayDoiTraNo(cobKH_NPP.Text, txtTraNo.Text, radioKhachHang.Checked))
                {
                    MainForm.ThongBao("Lưu thay đổi thành công");
                    MainForm.HienThiDanhSachTraNo();
                    Close();
                }
                else MainForm.ThongBao("Có lỗi trong quá trình lưu thay đổi");
        }

        private void cobKH_NPP_TextChanged(object sender, EventArgs e)
        {
            if (radioKhachHang.Checked)
            {
                if (QLBH.TonTaiKhachHang(cobKH_NPP.Text))
                    txtNo.Text = QLBH.LayNoCuaKhachHangTinhDenThoiDiemTruThoiDiemDoKhongAm(QLBH.LayIdKhachHangTuTenKhachHang(cobKH_NPP.Text), ThoiDiem).ToString("0,0");
            }
            else
            {
                if (QLBH.TonTaiNhaPP(cobKH_NPP.Text))
                    txtNo.Text = QLBH.LayNoNhaPPTinhDenThoiDiemTruThoiDiemDo(QLBH.LayIdNhaPhanPhoiTuTenNPP(cobKH_NPP.Text), ThoiDiem).ToString("0,0");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
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

        private void txtNo_TextChanged(object sender, EventArgs e)
        {
            CapNhatNoMoi();
        }

        private void btnTraHetNo_Click(object sender, EventArgs e)
        {
            try
            {
                txtTraNo.Text = (ulong.Parse(txtNo.Text, System.Globalization.NumberStyles.AllowThousands)).ToString();
            }
            catch
            {

            }
        }
    }
}
