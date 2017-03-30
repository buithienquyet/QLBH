using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using Dapper;

namespace PMQLBH
{
    public partial class frmNhapHang : Form
    {
        frmPMQLBH MainForm;

        public frmNhapHang(frmPMQLBH mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        public bool NhapHang(string nhaPhanPhoi, string thanhTien, string thanhToan, string ghiChu, DataGridView danhSachSanPham)
        {
            ulong ThanhTien;
            ulong ThanhToan;
            ThanhTien = ulong.Parse(thanhTien, NumberStyles.AllowThousands);
            ThanhToan = ulong.Parse(thanhToan);
            QLBH.ChuanHoaXau(ref ghiChu);
            int IdHoaDonNhap = 1;
            SQLiteTransaction tranNhapHang = QLBH.con.BeginTransaction();
            if (QLBH.con.QueryFirst<int>("select count(*) from sqlite_sequence where name='hoa_don_nhap'") != 0)
                IdHoaDonNhap = 1 + QLBH.con.QueryFirst<int>("select seq from sqlite_sequence where name='hoa_don_nhap'");
            try
            {
                QLBH.con.Query(string.Format("insert into hoa_don_nhap(id,id_nha_phan_phoi,thanh_tien,thanh_toan,chiet_khau,ghi_chu,tg_tao) values ({0},{1},{2},{3},{4},'{5}','{6}')", IdHoaDonNhap, QLBH.LayIdNhaPhanPhoiTuTenNPP(nhaPhanPhoi), ThanhTien, ThanhToan, 0, ghiChu, QLBH.GetTimeNow()));
                for (int i = 0; i < danhSachSanPham.RowCount; i++)
                {
                    QLBH.con.Query(string.Format("insert into san_pham_da_nhap(id_hoa_don_nhap,id_san_pham,gia,so_luong,so_luong_km) values({0},{1},{2},{3},{4})", IdHoaDonNhap, QLBH.LayIdTuTenSanPham(danhSachSanPham["colSanPham", i].Value.ToString()), ulong.Parse(danhSachSanPham["colGia", i].Value.ToString(), NumberStyles.AllowThousands), decimal.Parse(danhSachSanPham["colSoLuong", i].Value.ToString()), decimal.Parse(danhSachSanPham["colSoLuongKM", i].Value.ToString())));
                }
                tranNhapHang.Commit();
                return true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Lỗi: " + er.ToString());
                tranNhapHang.Rollback();
                return false;
            }
        }

        private bool KiemTraHoaDonNhapHopLe(string nhaPhanPhoi, ComboBox cobSanPham, ComboBox cobNhaPhanPhoi, string tongThanhTien, string thanhToan, DataGridView danhSachSanPham)
        {
            if (danhSachSanPham.RowCount == 0)
            {
                MessageBox.Show("Danh sách sản phẩm trống!");
                return false;
            }
            else
            {
                for (int i = 0; i < danhSachSanPham.RowCount; i++)
                {
                    if (cobSanPham.Items.Contains(danhSachSanPham["colSanPham", i].Value.ToString()) == false)
                    {

                        MessageBox.Show("Dữ liệu trong danh sách sản phẩm không hợp lệ");
                        return false;
                    }
                    for (int j = 0; j < i; j++)
                        if (danhSachSanPham["colSanPham", j].Value.ToString() == danhSachSanPham["colSanPham", i].Value.ToString())
                        {
                            MessageBox.Show("Dữ liệu trong danh sách sản phẩm không hợp lệ");
                            return false;
                        }
                    for (int j = i + 1; j < danhSachSanPham.RowCount; j++)
                        if (danhSachSanPham["colSanPham", j].Value.ToString() == danhSachSanPham["colSanPham", i].Value.ToString())
                        {
                            MessageBox.Show("Dữ liệu trong danh sách sản phẩm không hợp lệ");
                            return false;
                        }
                }
            }
            if (cobNhaPhanPhoi.Items.Contains(nhaPhanPhoi) == false)
            {
                MessageBox.Show("Nhà phân phối không tồn tại");
                return false;
            }
            try
            {
                ulong.Parse(tongThanhTien, NumberStyles.AllowThousands);
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu thành tiền không hợp lệ");
                return false;
            }
            ulong ThanhToan;
            if (ulong.TryParse(thanhToan, out ThanhToan) == false)
            {
                MessageBox.Show("Dữ liệu thanh toán không hợp lệ");
                return false;
            }
            return true;
        }

        void CapNhatSTTTrongSDSanPham()
        {
            for (int i = 0; i < dgdDanhSachSanPham.RowCount; i++)
                dgdDanhSachSanPham.Rows[i].Cells["colSTT"].Value = (i + 1).ToString();
        }

        void CapNhatDanhSachNhaPP_SanPham_MaSanPham()
        {
            foreach (string SanPham in QLBH.LayDanhSachSanPham())
            {
                cobSanPham.Items.Add(SanPham);
            }
            foreach (string MaSanPham in QLBH.LayDanhSachMaSanPham())
            {
                cobMaSanPham.Items.Add(MaSanPham);
            }
            foreach (string NhaPhanPhoi in QLBH.LayDanhSachNhaPP())
            {
                cobNhaPhanPhoi.Items.Add(NhaPhanPhoi);
            }
        }

        void CapNhatTongThanhTien()
        {
            ulong TongThanhTien = 0;
            if (dgdDanhSachSanPham.RowCount > 0)
            {
                for (int i = 0; i < dgdDanhSachSanPham.RowCount; i++)
                    TongThanhTien += ulong.Parse(dgdDanhSachSanPham.Rows[i].Cells["colThanhTien"].Value.ToString(), System.Globalization.NumberStyles.AllowThousands);
                txtTongThanhTien.Text = TongThanhTien.ToString("0,0");
            }
            else txtTongThanhTien.Text = "0";
        }

        void CapNhatThanhTien()
        {
            ulong Gia;
            if (ulong.TryParse(txtGia.Text, out Gia))
                txtThanhTien.Text = (Math.Round(numudSoLuong.Value, 1) * Gia).ToString("0,0");
        }

        void CapNhatNhanThanhToan() //Cập nhật nhãn thanh toán
        {
            ulong ThanhToan;
            if (ulong.TryParse(txtThanhToan.Text, out ThanhToan))
            {
                lblHienThiThanhToan.Text = ThanhToan.ToString("0,0");
            }
            else lblHienThiThanhToan.Text = "Không hợp lệ!";
        }

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
            if (ulong.TryParse(txtThanhToan.Text, out ThanhToan))
            {
                if (TongThanhTien >= ThanhToan)
                    txtConNo.Text = (TongThanhTien - ThanhToan).ToString("0,0");
                else 
                {
                    txtConNo.Text ="0, trả lại: "+ (ThanhToan-TongThanhTien).ToString("0,0");
                }
            }
            else txtConNo.Text = "Không hợp lệ!";
        }

        int TonTaiSanPham(string tenSanPham)
        {
            for (int i = 0; i < dgdDanhSachSanPham.RowCount; i++)
                if (dgdDanhSachSanPham.Rows[i].Cells["colSanPham"].Value.ToString() == tenSanPham)
                    return i;
            return -1;
        }

        bool KiemTraThemSanPham()
        {
            ulong Gia;
            if (cobSanPham.Items.Contains(cobSanPham.Text) == false)
            {
                MessageBox.Show("Sản phẩm không tồn tại!");
                return false;
            }
            if (ulong.TryParse(txtGia.Text, out Gia) == false)
            {
                MessageBox.Show("Giá nhập chưa hợp lệ!");
                return false;
            }
            else if (Gia == 0)
            {
                MessageBox.Show("Giá nhập bằng 0!");
                return false;
            }
            if (numudSoLuong.Value == 0 && numupSoLuongKM.Value == 0)
            {
                MessageBox.Show("Số lượng và số lượng khuyến mại của sản phẩm đều bằng 0!");
                return false;
            }
            if (TonTaiSanPham(cobSanPham.Text) != -1)
            {
                dgdDanhSachSanPham.CurrentCell = dgdDanhSachSanPham.Rows[TonTaiSanPham(cobSanPham.Text)].Cells[0];
                MessageBox.Show("Sản phẩm đã có trong danh sách, bạn có thể sửa và lưu lại thay đổi!");
                return false;
            }
            return true;
        }

        bool KiemTraLuuSanPham()
        {
            ulong Gia;
            if (dgdDanhSachSanPham.CurrentRow == null)
            {
                MessageBox.Show("Bạn phải chọn một sản phẩm trước khi lưu thay đổi!");
                return false;
            }
            if (cobSanPham.Items.Contains(cobSanPham.Text) == false)
            {
                MessageBox.Show("Sản phẩm không tồn tại!");
                return false;
            }
            if (dgdDanhSachSanPham.CurrentRow.Cells["colSanPham"].Value.ToString() != cobSanPham.Text)
            {
                MessageBox.Show("Tên sản phẩm không hợp lệ để lưu thay đổi");
                return false;
            }
            if (ulong.TryParse(txtGia.Text, out Gia) == false)
            {
                MessageBox.Show("Giá nhập chưa hợp lệ!");
                return false;
            }
            if (numudSoLuong.Value == 0 && numupSoLuongKM.Value == 0)
            {
                MessageBox.Show("Số lượng và số lượng khuyến mại của sản phẩm đều bằng 0!");
                return false;
            }
            return true;
        }

        void LuuSanPham()
        {
            dgdDanhSachSanPham.CurrentRow.Cells["colSanPham"].Value = cobSanPham.Text;
            dgdDanhSachSanPham.CurrentRow.Cells["colSoLuong"].Value = numudSoLuong.Value;
            dgdDanhSachSanPham.CurrentRow.Cells["colSoLuongKM"].Value = numupSoLuongKM.Value;
            dgdDanhSachSanPham.CurrentRow.Cells["colGia"].Value = lblHienThiGia.Text;
            dgdDanhSachSanPham.CurrentRow.Cells["colDonViTinh"].Value = txtDonViTinh.Text;
            dgdDanhSachSanPham.CurrentRow.Cells["colThanhTien"].Value = txtThanhTien.Text;
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            CapNhatDanhSachNhaPP_SanPham_MaSanPham();
            cobNhaPhanPhoi.Select();
        }

        private void numudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            CapNhatThanhTien();
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            ulong Gia;
            if (ulong.TryParse(txtGia.Text, out Gia))
            {
                lblHienThiGia.Text = Gia.ToString("0,0");
                CapNhatThanhTien();
            }
            else lblHienThiGia.Text = "Không hợp lệ!";
        }

        private void cobSanPham_TextChanged(object sender, EventArgs e)
        {
            if (cobSanPham.Items.Contains(cobSanPham.Text))
            {
                txtDonViTinh.Text = QLBH.LayDonViTinhTuTenSanPham(cobSanPham.Text);
                cobMaSanPham.Text = QLBH.LayMaSanPhamTuTenSanPham(cobSanPham.Text);
                numudSoLuong.Value = 0;
                numupSoLuongKM.Value = 0;
                txtGia.Text = "0";
            }
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            if (KiemTraThemSanPham())
            {
                dgdDanhSachSanPham.Rows.Add("", cobSanPham.Text, numudSoLuong.Value.ToString("0.0"), numupSoLuongKM.Value.ToString("0.0"), lblHienThiGia.Text, txtDonViTinh.Text, txtThanhTien.Text);
                CapNhatTongThanhTien();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(decimal.Parse(dgdDanhSachSanPham["colSoLuong", 0].Value.ToString()).ToString(new CultureInfo("en-US")));
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgdDanhSachSanPham.CurrentRow != null)
            {
                dgdDanhSachSanPham.Rows.Remove(dgdDanhSachSanPham.CurrentRow);
                CapNhatTongThanhTien();
            }
            else MessageBox.Show("Bạn phải chọn một sản phẩm trước khi xóa!");
        }

        private void dgdDanhSachSanPham_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CapNhatSTTTrongSDSanPham();
        }

        private void dgdDanhSachSanPham_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CapNhatSTTTrongSDSanPham();
        }

        private void dgdDanhSachSanPham_Sorted(object sender, EventArgs e)
        {
            CapNhatSTTTrongSDSanPham();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (KiemTraLuuSanPham())
            {
                LuuSanPham();
                CapNhatTongThanhTien();
            }
        }

        private void cobMaSanPham_TextChanged(object sender, EventArgs e)
        {
            if (cobMaSanPham.Items.Contains(cobMaSanPham.Text))
                cobSanPham.Text = QLBH.LayTenSanPhamTuMaSanPham(cobMaSanPham.Text);
        }

        private void cobSanPham_Leave(object sender, EventArgs e)
        {
            if (cobSanPham.Items.Contains(cobSanPham.Text) == false)
            {
                cobSanPham.Text = "Không tồn tại!!!";
            }
        }

        private void cobMaSanPham_Leave(object sender, EventArgs e)
        {
            if (cobMaSanPham.Items.Contains(cobMaSanPham.Text) == false)
            {
                cobMaSanPham.Text = "Không tồn tại!!!";
            }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if (KiemTraHoaDonNhapHopLe(cobNhaPhanPhoi.Text, cobSanPham, cobNhaPhanPhoi, txtTongThanhTien.Text, txtThanhToan.Text, dgdDanhSachSanPham))
            {
                if (NhapHang(cobNhaPhanPhoi.Text, txtTongThanhTien.Text, txtThanhToan.Text, txtGhiChu.Text, dgdDanhSachSanPham))
                {
                    MainForm.ThongBao("Nhập hàng thành công");
                    MainForm.HienThiDanhSachHoaDonNhapHang();
                    Close();
                }
                else MainForm.ThongBao("Có lỗi trong quá trình nhập hàng!");
            }
        }

        private void dgdDanhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgdDanhSachSanPham.CurrentRow != null)
            {
                cobSanPham.Text = dgdDanhSachSanPham.CurrentRow.Cells["colSanPham"].Value.ToString();
                numudSoLuong.Value = decimal.Parse(dgdDanhSachSanPham.CurrentRow.Cells["colSoLuong"].Value.ToString());
                numupSoLuongKM.Value = decimal.Parse(dgdDanhSachSanPham.CurrentRow.Cells["colSoLuongKm"].Value.ToString());
                txtGia.Text = ulong.Parse(dgdDanhSachSanPham.CurrentRow.Cells["colGia"].Value.ToString(), NumberStyles.AllowThousands).ToString();
            }
        }

        private void txtThanhToan_TextChanged(object sender, EventArgs e)
        {
            CapNhatNhanThanhToan();
            CapNhatConNo();
        }

        private void txtTongThanhTien_TextChanged(object sender, EventArgs e)
        {
            CapNhatConNo();
        }

        private void btnThanhToanToanBo_Click(object sender, EventArgs e)
        {
            try
            {
                txtThanhToan.Text = ulong.Parse(txtTongThanhTien.Text, NumberStyles.AllowThousands).ToString();
            }
            catch (Exception )
            {
                txtThanhToan.Text = "0";
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            cobNhaPhanPhoi.Items.Clear();
            cobSanPham.Items.Clear();
            cobMaSanPham.Items.Clear();
            dgdDanhSachSanPham.Rows.Clear();
            CapNhatDanhSachNhaPP_SanPham_MaSanPham();
        }

        private void cobNhaPhanPhoi_Leave(object sender, EventArgs e)
        {
            if (cobNhaPhanPhoi.Items.Contains(cobNhaPhanPhoi.Text) == false)
                cobNhaPhanPhoi.Text = "Không tồn tại!!!";
        }
    }
}
