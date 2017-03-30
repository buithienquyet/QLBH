using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace PMQLBH
{
    public partial class frmXemHoaDonBan : Form
    {
        frmPMQLBH MainForm;
        string IdHoaDonBan;

        void CapNhatNoCu()
        {
            txtNoCu.Text = txtNoCu.Text = QLBH.LayNoCuaKhachHangTinhDenThoiDiemTruThoiDiemDoKhongAm(QLBH.LayIdKhachHangTuTenKhachHang(cobKhachHang.Text), QLBH.LayThoiDiemTuIdHoaDonBan(IdHoaDonBan)).ToString("0,0");
        }

        void CapNhatNoMoi()
        {
            ulong ThanhToan, TongThanhTien;
            TongThanhTien = ulong.Parse(txtTongThanhTien.Text, NumberStyles.AllowThousands);
            ThanhToan = ulong.Parse(txtThanhToan.Text, NumberStyles.AllowThousands);
            if (TongThanhTien >= ThanhToan)
                txtNoMoi.Text = (TongThanhTien - ThanhToan).ToString("0,0");
            else
            {
                txtNoMoi.Text = "0, trả lại: " + (ThanhToan - TongThanhTien).ToString("0,0");
            }
        }

        void CapNhatTongNo()
        {
            ulong NoMoi;
            ulong NoCu;
            try
            {
                NoMoi = ulong.Parse(txtNoMoi.Text, NumberStyles.AllowThousands);
            }
            catch (FormatException)
            {
                if (txtNoMoi.Text.Contains("0, trả lại:"))
                    NoMoi = 0;
                else
                {
                    txtTongNo.Text = "Không hợp lệ!";
                    return;
                }
            }
            try
            {
                NoCu = ulong.Parse(txtNoCu.Text, NumberStyles.AllowThousands);
            }
            catch (Exception )
            {
                txtTongNo.Text = "Không hợp lệ!";
                return;
            }
            txtTongNo.Text = (NoMoi + NoCu).ToString("0,0");
        }

        public frmXemHoaDonBan(frmPMQLBH mainForm, string idHoaDonBan)
        {
            InitializeComponent();
            MainForm = mainForm;
            IdHoaDonBan = idHoaDonBan;
        }

        private void frmXemHoaDonBan_Load(object sender, EventArgs e)
        {
            DataTable abc = QLBH.LayDanhSachSanPhamTuIdHoaDonBan(IdHoaDonBan);
            for (int i = 0; i < abc.Rows.Count; i++)
            {
                string SanPham = abc.Rows[i]["Sản phẩm"].ToString();
                double SoLuong = double.Parse(abc.Rows[i]["Số lượng"].ToString());
                ulong Gia = ulong.Parse(abc.Rows[i]["Giá"].ToString());
                string DonViTinh = abc.Rows[i]["Đơn vị tính"].ToString();
                ulong ThanhTien = ulong.Parse(abc.Rows[i]["Thành tiền"].ToString());
                dgdDanhSachSanPham.Rows.Add("", SanPham, SoLuong.ToString("0.0"), Gia.ToString("0,0"), DonViTinh, ThanhTien.ToString("0,0"));
            }
            cobKhachHang.Text = QLBH.LayTenKhachHangTuIdHoaDonBan(IdHoaDonBan);
            txtTongThanhTien.Text = QLBH.LayThanhTienTuIdHoaDonBan(IdHoaDonBan).ToString("0,0");
            txtThanhToan.Text = QLBH.LayThanhToanTuIdHoaDonBan(IdHoaDonBan).ToString("0,0");
            txtGhiChu.Text = QLBH.LayGhiChuTuIdHoaDonBan(IdHoaDonBan);
            CapNhatNoCu();
            CapNhatNoMoi();
            CapNhatTongNo();
            if (QLBH.CoXeCho(IdHoaDonBan))
            {
                cobXeCho.Text = QLBH.LayXeChoTuIdHoaDonBan(IdHoaDonBan);
                txtCongCho.Text = QLBH.LayCongChoTuIdHoaDonBan(IdHoaDonBan).ToString("0,0");
                chkCongCho.Checked = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgdDanhSachSanPham_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dgdDanhSachSanPham.RowCount; i++)
                dgdDanhSachSanPham.Rows[i].Cells["colSTT"].Value = (i + 1).ToString();
        }

        private void dgdDanhSachSanPham_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgdDanhSachSanPham.RowCount; i++)
                dgdDanhSachSanPham.Rows[i].Cells["colSTT"].Value = (i + 1).ToString();
        }

        private void dgdDanhSachSanPham_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (int i = 0; i < dgdDanhSachSanPham.RowCount; i++)
                dgdDanhSachSanPham.Rows[i].Cells["colSTT"].Value = (i + 1).ToString();
        }
    }
}
