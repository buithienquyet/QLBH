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
    public partial class frmXemHoaDonNhap : Form
    {
        frmPMQLBH MainForm;
        string IdHoaDonNhap;
        void CapNhatConNo()
        {
            ulong ThanhToan, TongThanhTien;
            try
            {
                TongThanhTien = ulong.Parse(txtTongThanhTien.Text, NumberStyles.AllowThousands);
            }
            catch (Exception )
            {
                txtConNo.Text = "Không hợp lệ!";
                return;
            }
            try
            {
                ThanhToan = ulong.Parse(txtThanhToan.Text, NumberStyles.AllowThousands);
            }
            catch (Exception )
            {
                txtConNo.Text = "Không hợp lệ!";
                return;
            }
            if (TongThanhTien <= ThanhToan)
                txtConNo.Text = "0";
            else txtConNo.Text = (TongThanhTien - ThanhToan).ToString("0,0");
        }

        public frmXemHoaDonNhap(frmPMQLBH mainForm, string idHoaDonNhap)
        {
            InitializeComponent();
            IdHoaDonNhap = idHoaDonNhap;
            MainForm = mainForm;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmXemHoaDonNhap_Load(object sender, EventArgs e)
        {
            dgdDanhSachSanPham.DataSource = QLBH.LayDanhSachSanPhamTuIdHoaDonNhap(IdHoaDonNhap);
            txtNhaPhanPhoi.Text = QLBH.LayTenNhaPPTuIdHoaDonNhap(IdHoaDonNhap);
            txtThanhToan.Text = QLBH.LayThanhToanTuIdHoaDonNhap(IdHoaDonNhap).ToString("0,0");
            txtTongThanhTien.Text = QLBH.LayThanhTienTuIdHoaDonNhap(IdHoaDonNhap).ToString("0,0");
            txtGhiChu.Text = QLBH.LayGhiChuTuIdHoaDonNhap(IdHoaDonNhap);
            CapNhatConNo();
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
