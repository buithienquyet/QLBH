using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using Dapper;
using System.Data.SQLite;

namespace PMQLBH
{
    public partial class frmSuaHoaDonBan : Form
    {
        frmPMQLBH MainForm;
        string IdHoaDonBan;
        public frmSuaHoaDonBan(frmPMQLBH mainForm, string idHoaDonBan)
        {
            InitializeComponent();
            MainForm = mainForm;
            IdHoaDonBan = idHoaDonBan;
        }

        private bool KiemTraHoaDonBanHopLe(ComboBox cobSanPham, ComboBox cobKhachHang, ComboBox cobXeCho, DataGridView danhSachSanPham, string khachHang, string tongThanhTien, string thanhToan, bool coCongCho, string xeCho, string congCho)
        {
            ulong ThanhToan;
            ulong CongCho;
            if (cobKhachHang.Items.Contains(khachHang) == false)
            {
                MessageBox.Show("Khách hàng không tồn tại");
                return false;
            }
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
                    for (int j = i + 1; j < danhSachSanPham.RowCount; j++)
                        if (danhSachSanPham["colSanPham", j].Value.ToString() == danhSachSanPham["colSanPham", i].Value.ToString())
                        {
                            MessageBox.Show("Dữ liệu trong danh sách sản phẩm không hợp lệ");
                            return false;
                        }
                }
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

            if (ulong.TryParse(thanhToan, out ThanhToan) == false)
            {
                MessageBox.Show("Dữ liệu thanh toán không hợp lệ");
                return false;
            }
            if (coCongCho == true)
            {
                if (cobXeCho.Items.Contains(xeCho) == false)
                {
                    MessageBox.Show("Xe chở không tồn tại");
                    return false;
                }
                if (ulong.TryParse(congCho, out CongCho) == false)
                {
                    MessageBox.Show("Công chở nhập chưa hợp lệ!");
                    return false;
                }
                if (CongCho == 0)
                {
                    MessageBox.Show("Công chở bạn nhập bằng 0");
                    return false;
                }
            }
            return true;
        }

        private bool LuuThayDoiHoaDonBan(string khachHang, string thanhTien, string thanhToan, string ghiChu, DataGridView danhSachSanPham, bool coXeCho, string xeCho, string congCho, string idHoaDonBanCu)
        {
            ulong ThanhTien;
            ulong ThanhToan;
            ThanhTien = ulong.Parse(thanhTien, NumberStyles.AllowThousands);
            ThanhToan = ulong.Parse(thanhToan);
            QLBH.ChuanHoaXau(ref ghiChu);
            SQLiteTransaction tranLuuThayDoiHoaDonBan = QLBH.con.BeginTransaction();
            try
            {
                QLBH.con.Query("delete from san_pham_da_ban where id_hoa_don_ban=" + idHoaDonBanCu);
                QLBH.con.Query("delete from cong_cho where id_hoa_don_ban=" + idHoaDonBanCu);
                QLBH.con.Query(string.Format("update hoa_don_ban set id_khach_hang={0},thanh_tien={1},thanh_toan={2},ghi_chu='{3}' where id={4}", QLBH.LayIdKhachHangTuTenKhachHang(khachHang), ThanhTien, ThanhToan, ghiChu, idHoaDonBanCu));
                for (int i = 0; i < danhSachSanPham.RowCount; i++)
                {
                    QLBH.con.Query(string.Format("insert into san_pham_da_ban(id_hoa_don_ban,id_san_pham,gia,so_luong) values({0},{1},{2},{3})", idHoaDonBanCu, QLBH.LayIdTuTenSanPham(danhSachSanPham["colSanPham", i].Value.ToString()), ulong.Parse(danhSachSanPham["colGia", i].Value.ToString(), NumberStyles.AllowThousands), decimal.Parse(danhSachSanPham["colSoLuong", i].Value.ToString())));
                }
                if (coXeCho == true)
                {
                    QLBH.con.Query(string.Format("insert into cong_cho(id_hoa_don_ban, id_xe_cho, tien_cho) values({0},{1},{2})", idHoaDonBanCu, QLBH.LayIdKhachHangTuTenKhachHang(xeCho), ulong.Parse(congCho)));
                }
                tranLuuThayDoiHoaDonBan.Commit();
                return true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Lỗi: " + er.ToString());
                tranLuuThayDoiHoaDonBan.Rollback();
                return false;
            }
        }

        void CapNhatThanhTien()
        {
            try
            {
                txtThanhTien.Text = (Math.Round(numudSoLuong.Value, 1) * ulong.Parse(txtGia.Text, System.Globalization.NumberStyles.AllowThousands)).ToString("0,0");
            }
            catch (Exception)
            {

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

        void CapNhatNoMoi()
        {
            ulong ThanhToan, TongThanhTien;
            try
            {
                TongThanhTien = ulong.Parse(txtTongThanhTien.Text, NumberStyles.AllowThousands);
            }
            catch (Exception )
            {
                txtNoMoi.Text = "Không hợp lệ!";
                return;
            }
            if (ulong.TryParse(txtThanhToan.Text, out ThanhToan))
            {
                if (TongThanhTien >= ThanhToan)
                    txtNoMoi.Text = (TongThanhTien - ThanhToan).ToString("0,0");
                else
                {
                    txtNoMoi.Text = "0, trả lại: " + (ThanhToan - TongThanhTien).ToString("0,0");
                }
            }
            else txtNoMoi.Text = "Không hợp lệ!";
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
            catch (Exception)
            {
                txtTongNo.Text = "Không hợp lệ!";
                return;
            }
            txtTongNo.Text = (NoMoi + NoCu).ToString("0,0");
        }

        void CapNhatDanhSachKhachHang_XeCho_SanPham_MaSanPham()
        {
            foreach (string SanPham in QLBH.LayDanhSachSanPham())
            {
                cobSanPham.Items.Add(SanPham);
            }
            foreach (string MaSanPham in QLBH.LayDanhSachMaSanPham())
            {
                cobMaSanPham.Items.Add(MaSanPham);
            }
            foreach (string KhachHang in QLBH.LayDanhSachKhachHang())
            {
                cobKhachHang.Items.Add(KhachHang);
            }

            foreach (string XeCho in QLBH.LayDanhSachXeCho())
            {
                cobXeCho.Items.Add(XeCho);
            }
        }

        int TonTaiSanPham(string tenSanPham)
        {
            for (int i = 0; i < dgdDanhSachSanPham.RowCount; i++)
                if (dgdDanhSachSanPham.Rows[i].Cells["colSanPham"].Value.ToString() == tenSanPham)
                    return i;
            return -1;
        }

        void CapNhatSTTTrongDSSanPham()
        {
            for (int i = 0; i < dgdDanhSachSanPham.RowCount; i++)
                dgdDanhSachSanPham.Rows[i].Cells["colSTT"].Value = (i + 1).ToString();
        }

        bool KiemTraThemSanPham()
        {
            if (cobSanPham.Items.Contains(cobSanPham.Text) == false)
            {
                MessageBox.Show("Sản phẩm không tồn tại!");
                return false;
            }
            if (numudSoLuong.Value == 0)
            {
                MessageBox.Show("Bạn chưa nhập số lượng của sản phẩm!");
                return false;
            }
            if ((double)numudSoLuong.Value > QLBH.LaySoLuongHienCoCuaSanPhamNhungKhongTinhHoaDonBan(QLBH.LayIdTuTenSanPham(cobSanPham.Text), IdHoaDonBan))
            {
                MessageBox.Show("Mặt hàng hiện chỉ còn lại số lượng là " + QLBH.LaySoLuongHienCoCuaSanPhamNhungKhongTinhHoaDonBan(QLBH.LayIdTuTenSanPham(cobSanPham.Text), IdHoaDonBan).ToString() + " nhỏ hơn số lượng bạn đã nhập nên không thể thực hiện thao tác này!");
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
            if (numudSoLuong.Value == 0)
            {
                MessageBox.Show("Bạn chưa nhập số lượng của sản phẩm!");
                return false;
            }
            if ((double)numudSoLuong.Value > QLBH.LaySoLuongHienCoCuaSanPhamNhungKhongTinhHoaDonBan(QLBH.LayIdTuTenSanPham(cobSanPham.Text), IdHoaDonBan))
            {
                MessageBox.Show("Mặt hàng hiện chỉ còn lại số lượng là " + QLBH.LaySoLuongHienCoCuaSanPhamNhungKhongTinhHoaDonBan(QLBH.LayIdTuTenSanPham(cobSanPham.Text), IdHoaDonBan).ToString() + " nhỏ hơn số lượng bạn đã nhập nên không thể thực hiện thao tác này!");
                return false;
            }
            return true;
        }

        void LuuSanPham()
        {
            dgdDanhSachSanPham.CurrentRow.Cells["colSanPham"].Value = cobSanPham.Text;
            dgdDanhSachSanPham.CurrentRow.Cells["colSoLuong"].Value = numudSoLuong.Value;
            dgdDanhSachSanPham.CurrentRow.Cells["colGia"].Value = ulong.Parse(txtGia.Text, System.Globalization.NumberStyles.AllowThousands).ToString("0,0");
            dgdDanhSachSanPham.CurrentRow.Cells["colDonViTinh"].Value = txtDonViTinh.Text;
            dgdDanhSachSanPham.CurrentRow.Cells["colThanhTien"].Value = txtThanhTien.Text;
        }

        void CapNhatNoCu()
        {
            if (cobKhachHang.Items.Contains(cobKhachHang.Text))
            {
                txtNoCu.Text = QLBH.LayNoCuaKhachHangTinhDenThoiDiemTruThoiDiemDoKhongAm(QLBH.LayIdKhachHangTuTenKhachHang(cobKhachHang.Text), QLBH.LayThoiDiemTuIdHoaDonBan(IdHoaDonBan)).ToString("0,0");
            }
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

        void ThemSanPham()
        {
            dgdDanhSachSanPham.Rows.Add("", cobSanPham.Text, numudSoLuong.Value.ToString("0.0"), ulong.Parse(txtGia.Text, System.Globalization.NumberStyles.AllowThousands).ToString("0,0"), txtDonViTinh.Text, txtThanhTien.Text);
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {

        }

        private void frmSuaHoaDonBan_Load(object sender, EventArgs e)
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
            CapNhatDanhSachKhachHang_XeCho_SanPham_MaSanPham();
            cobKhachHang.Text = QLBH.LayTenKhachHangTuIdHoaDonBan(IdHoaDonBan);
            txtTongThanhTien.Text = QLBH.LayThanhTienTuIdHoaDonBan(IdHoaDonBan).ToString("0,0");
            txtThanhToan.Text = QLBH.LayThanhToanTuIdHoaDonBan(IdHoaDonBan).ToString();
            txtGhiChu.Text = QLBH.LayGhiChuTuIdHoaDonBan(IdHoaDonBan);
            if (QLBH.CoXeCho(IdHoaDonBan))
            {
                cobXeCho.Text = QLBH.LayXeChoTuIdHoaDonBan(IdHoaDonBan);
                txtCongCho.Text = QLBH.LayCongChoTuIdHoaDonBan(IdHoaDonBan).ToString();
                chkCongCho.Checked = true;
            }
            cobKhachHang.Select();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cobKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (cobKhachHang.Items.Contains(cobKhachHang.Text))
            {
                CapNhatNoCu();
                if (QLBH.KhachHangLaXeCho(QLBH.LayIdKhachHangTuTenKhachHang(cobKhachHang.Text)))
                {
                    chkCongCho.Checked = false;
                    chkCongCho.Enabled = false;
                }
                else chkCongCho.Enabled = true;
            }
        }

        private void chkCongCho_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCongCho.Checked == false)
            {
                cobXeCho.Enabled = false;
                txtCongCho.Enabled = false;
            }
            else
            {
                cobXeCho.Enabled = true;
                txtCongCho.Enabled = true;
            }
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            if (KiemTraThemSanPham())
            {
                ThemSanPham();
                CapNhatTongThanhTien();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (KiemTraLuuSanPham())
            {
                LuuSanPham();
                CapNhatTongThanhTien();
            }
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

        private void cobSanPham_TextChanged(object sender, EventArgs e)
        {
            if (cobSanPham.Items.Contains(cobSanPham.Text))
            {
                txtDonViTinh.Text = QLBH.LayDonViTinhTuTenSanPham(cobSanPham.Text);
                cobMaSanPham.Text = QLBH.LayMaSanPhamTuTenSanPham(cobSanPham.Text);
                txtGia.Text = QLBH.LayGiaSanPhamTuTenSanPham(cobSanPham.Text).ToString("0,0");
                numudSoLuong.Value = 0;
            }
        }

        private void cobSanPham_Leave(object sender, EventArgs e)
        {
            if (cobSanPham.Items.Contains(cobSanPham.Text) == false)
            {
                cobSanPham.Text = "Không tồn tại!!!";
            }
        }

        private void cobMaSanPham_TextChanged(object sender, EventArgs e)
        {
            if (cobMaSanPham.Items.Contains(cobMaSanPham.Text))
                cobSanPham.Text = QLBH.LayTenSanPhamTuMaSanPham(cobMaSanPham.Text);
        }

        private void cobMaSanPham_Leave(object sender, EventArgs e)
        {
            if (cobMaSanPham.Items.Contains(cobMaSanPham.Text) == false)
            {
                cobMaSanPham.Text = "Không tồn tại!!!";
            }
        }

        private void dgdDanhSachSanPham_Sorted(object sender, EventArgs e)
        {
            CapNhatSTTTrongDSSanPham();
        }

        private void dgdDanhSachSanPham_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CapNhatSTTTrongDSSanPham();
        }

        private void dgdDanhSachSanPham_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CapNhatSTTTrongDSSanPham();
        }

        private void numudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            CapNhatThanhTien();
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

        private void txtTongThanhTien_TextChanged(object sender, EventArgs e)
        {
            CapNhatNoMoi();
        }

        private void txtThanhToan_TextChanged(object sender, EventArgs e)
        {
            CapNhatNoMoi();
            CapNhatNhanThanhToan();
        }

        private void txtNoMoi_TextChanged(object sender, EventArgs e)
        {
            CapNhatTongNo();
        }

        private void txtNoCu_TextChanged(object sender, EventArgs e)
        {
            CapNhatTongNo();
        }

        private void dgdDanhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgdDanhSachSanPham.CurrentRow != null)
            {
                cobSanPham.Text = dgdDanhSachSanPham.CurrentRow.Cells["colSanPham"].Value.ToString();
                numudSoLuong.Value = decimal.Parse(dgdDanhSachSanPham.CurrentRow.Cells["colSoLuong"].Value.ToString());
                txtGia.Text = ulong.Parse(dgdDanhSachSanPham.CurrentRow.Cells["colGia"].Value.ToString(), NumberStyles.AllowThousands).ToString();
            }
        }

        private void dgdDanhSachSanPham_Enter(object sender, EventArgs e)
        {

        }

        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            if (KiemTraHoaDonBanHopLe(cobSanPham, cobKhachHang, cobXeCho, dgdDanhSachSanPham, cobKhachHang.Text, txtTongThanhTien.Text, txtThanhToan.Text, chkCongCho.Checked, cobXeCho.Text, txtCongCho.Text))
                if (LuuThayDoiHoaDonBan(cobKhachHang.Text, txtTongThanhTien.Text, txtThanhToan.Text, txtGhiChu.Text, dgdDanhSachSanPham, chkCongCho.Checked, cobXeCho.Text, txtCongCho.Text, IdHoaDonBan))
                {
                    MainForm.ThongBao("Thay đổi hóa đơn bán thành công");
                    MainForm.HienThiDanhSachHoaDonBanHang();
                    Close();
                }
                else MainForm.ThongBao("Có lỗi trong quá trình thay đổi hóa đơn bán");
        }

        private void txtCongCho_TextChanged(object sender, EventArgs e)
        {
            ulong CongCho;
            if (ulong.TryParse(txtCongCho.Text, out CongCho))
            {
                lblCongCho.Text = CongCho.ToString("0,0");
            }
            else lblCongCho.Text = "Không hợp lệ!";
        }

    }
}
