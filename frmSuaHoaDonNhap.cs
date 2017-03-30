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
    public partial class frmSuaHoaDonNhap : Form
    {
        frmPMQLBH MainForm;
        string IdHoaDonNhap;

        public frmSuaHoaDonNhap(frmPMQLBH mainForm, string idHoaDonNhap)
        {
            InitializeComponent();
            IdHoaDonNhap = idHoaDonNhap;
            MainForm = mainForm;
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

        private bool LuuThayDoiHoaDonNhap(string idHoaDonNhap, string nhaPhanPhoi, string thanhTien, string thanhToan, string ghiChu, DataGridView danhSachSanPham)
        {
            ulong ThanhTien;
            ulong ThanhToan;
            ThanhTien = ulong.Parse(thanhTien, NumberStyles.AllowThousands);
            ThanhToan = ulong.Parse(thanhToan);
            QLBH.ChuanHoaXau(ref ghiChu);
            SQLiteTransaction tranLuuThayDoiHoaDonNhap = QLBH.con.BeginTransaction();
            try
            {
                QLBH.con.Query(string.Format("update hoa_don_nhap set id_nha_phan_phoi={0},thanh_tien={1},thanh_toan={2},chiet_khau={3},ghi_chu='{4}' where id={5}", QLBH.LayIdNhaPhanPhoiTuTenNPP(nhaPhanPhoi), ThanhTien, ThanhToan, 0, ghiChu, idHoaDonNhap)); //Cập nhật thông tin hóa đơn
                QLBH.con.Query("delete from san_pham_da_nhap where id_hoa_don_nhap=" + idHoaDonNhap); //Xóa danh sách hàng cũ đã nhập
                for (int i = 0; i < danhSachSanPham.RowCount; i++)
                {
                    QLBH.con.Query(string.Format("insert into san_pham_da_nhap(id_hoa_don_nhap,id_san_pham,gia,so_luong,so_luong_km) values({0},{1},{2},{3},{4})", idHoaDonNhap, QLBH.LayIdTuTenSanPham(danhSachSanPham["colSanPham", i].Value.ToString()), ulong.Parse(danhSachSanPham["colGia", i].Value.ToString(), NumberStyles.AllowThousands), decimal.Parse(danhSachSanPham["colSoLuong", i].Value.ToString()), decimal.Parse(danhSachSanPham["colSoLuongKM", i].Value.ToString()))); //Thêm hàng mới vào danh sách
                }
                tranLuuThayDoiHoaDonNhap.Commit();
                return true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Lỗi: " + er.ToString());
                tranLuuThayDoiHoaDonNhap.Rollback();
                return false;
            }
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
                if (TongThanhTien <= ThanhToan)
                    txtConNo.Text = "0";
                else txtConNo.Text = (TongThanhTien - ThanhToan).ToString("0,0");
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
            if (numudSoLuong.Value == 0 && numupSoLuongKM.Value == 0)
            {
                MessageBox.Show("Số lượng và số lượng khuyến mại của sản phẩm đều bằng 0!");
                return false;
            }
            if (ulong.TryParse(txtGia.Text, out Gia) == false)
            {
                MessageBox.Show("Giá nhập chưa hợp lệ!");
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
            if (dgdDanhSachSanPham.CurrentRow.Cells["colSanPham"].Value.ToString() != cobSanPham.Text)
            {
                MessageBox.Show("Sản phẩm không hợp lệ để lưu thay đổi");
                return false;
            }
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
            if (numudSoLuong.Value == 0 && numupSoLuongKM.Value == 0)
            {
                MessageBox.Show("Số lượng và số lượng khuyến mại của sản phẩm đều bằng 0!");
                return false;
            }
            double SoLuongSanPhamNhungKhongTinhHoaDonNhapCu = double.Parse(numudSoLuong.Value.ToString("0.0")) + double.Parse(numupSoLuongKM.Value.ToString("0.0")) + QLBH.LaySoLuongHienCoCuaSanPhamNhungKhongTinhHoaDonNhap(QLBH.LayIdTuTenSanPham(cobSanPham.Text), IdHoaDonNhap);//Lấy số lượng có nhưng không tính hóa đơn cũ + số lượng định thêm
            if (SoLuongSanPhamNhungKhongTinhHoaDonNhapCu<0)
            {
                MessageBox.Show("Số lượng bán của sản phẩm đã vượt quá số lượng nhập nên bạn không thể thực hiện thao tác này");
                return false;
            }
            return true;
        }

        void LuuSanPham()
        {
            dgdDanhSachSanPham.CurrentRow.Cells["colSanPham"].Value = cobSanPham.Text;
            dgdDanhSachSanPham.CurrentRow.Cells["colSoLuong"].Value = numudSoLuong.Value.ToString("0.0");
            dgdDanhSachSanPham.CurrentRow.Cells["colSoLuongKM"].Value = numupSoLuongKM.Value.ToString("0.0");
            dgdDanhSachSanPham.CurrentRow.Cells["colGia"].Value = lblHienThiGia.Text;
            dgdDanhSachSanPham.CurrentRow.Cells["colDonViTinh"].Value = txtDonViTinh.Text;
            dgdDanhSachSanPham.CurrentRow.Cells["colThanhTien"].Value = txtThanhTien.Text;
        }

        bool KiemTraXoaSanPham()
        {
            double SoLuongSanPhamNhungKhongTinhHoaDonNhapCu = double.Parse(numudSoLuong.Value.ToString("0.0")) + double.Parse(numupSoLuongKM.Value.ToString("0.0")) + QLBH.LaySoLuongHienCoCuaSanPhamNhungKhongTinhHoaDonNhap(QLBH.LayIdTuTenSanPham(dgdDanhSachSanPham.CurrentRow.Cells["colSanPham"].Value.ToString()), IdHoaDonNhap);//Lấy số lượng của sản phẩm nhưng không tính hóa đơn này + số lượng định thêm
            if (SoLuongSanPhamNhungKhongTinhHoaDonNhapCu<0)
            {
                MessageBox.Show("Số lượng bán của sản phẩm đã vượt quá số lượng nhập nên bạn không thể thực hiện thao tác này");
                return false;
            }
            return true;
        }

        private void numudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            ulong ThanhTien;
            if (ulong.TryParse(txtGia.Text, out ThanhTien))
                txtThanhTien.Text = (numudSoLuong.Value * ThanhTien).ToString("0,0");
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            ulong Gia;
            if (ulong.TryParse(txtGia.Text, out Gia))
            {
                lblHienThiGia.Text = Gia.ToString("0,0");
                txtThanhTien.Text = (numudSoLuong.Value * Gia).ToString("0,0");
            }
            else lblHienThiGia.Text = "Không hợp lệ!";
        }

        private void cobSanPham_TextChanged(object sender, EventArgs e)
        {
            if (cobSanPham.Items.Contains(cobSanPham.Text))
            {
                txtDonViTinh.Text = QLBH.LayDonViTinhTuTenSanPham(cobSanPham.Text);
                cobMaSanPham.Text = QLBH.LayMaSanPhamTuTenSanPham(cobSanPham.Text);
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
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgdDanhSachSanPham.CurrentRow != null)
            {
                if (KiemTraXoaSanPham())
                {
                    dgdDanhSachSanPham.Rows.Remove(dgdDanhSachSanPham.CurrentRow);
                    CapNhatTongThanhTien();
                }
            }
            else MessageBox.Show("Bạn phải chọn một sản phẩm trước khi xóa!");
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

        private void dgdDanhSachSanPham_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dgdDanhSachSanPham.RowCount; i++)
                dgdDanhSachSanPham.Rows[i].Cells["colSTT"].Value = (i + 1).ToString();
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

        private void cobMaSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cobSanPham_Leave(object sender, EventArgs e)
        {
            if (cobSanPham.Items.Contains(cobSanPham.Text) == false)
            {
                MessageBox.Show("Tên sản phẩm không tồn tại!");
            }
        }

        private void cobMaSanPham_Leave(object sender, EventArgs e)
        {
            if (cobMaSanPham.Items.Contains(cobMaSanPham.Text) == false)
            {
                MessageBox.Show("Mã sản phẩm không tồn tại!");
                cobMaSanPham.Text = "Không hợp lệ!";
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
            catch (Exception)
            {
                txtThanhToan.Text = "0";
            }
        }

        private void frmSuaHoaDonNhap_Load(object sender, EventArgs e)
        {
            DataTable abc = QLBH.LayDanhSachSanPhamTuIdHoaDonNhap(IdHoaDonNhap);
            for (int i = 0; i < abc.Rows.Count; i++)
            {
                string SanPham = abc.Rows[i]["Sản phẩm"].ToString();
                double SoLuong = double.Parse(abc.Rows[i]["Số lượng"].ToString());
                double SoLuongKM = double.Parse(abc.Rows[i]["Số lượng KM"].ToString());
                ulong Gia = ulong.Parse(abc.Rows[i]["Giá"].ToString());
                string DonViTinh = abc.Rows[i]["Đơn vị tính"].ToString();
                ulong ThanhTien = ulong.Parse(abc.Rows[i]["Thành tiền"].ToString());
                dgdDanhSachSanPham.Rows.Add("", SanPham, SoLuong.ToString("0.0"), SoLuongKM.ToString("0.0"), Gia.ToString("0,0"), DonViTinh, ThanhTien.ToString("0,0"));
            }
            cobNhaPhanPhoi.Text = QLBH.LayTenNhaPPTuIdHoaDonNhap(IdHoaDonNhap);
            txtTongThanhTien.Text = QLBH.LayThanhTienTuIdHoaDonNhap(IdHoaDonNhap).ToString("0,0");
            txtThanhToan.Text = QLBH.LayThanhToanTuIdHoaDonNhap(IdHoaDonNhap).ToString();
            txtGhiChu.Text = QLBH.LayGhiChuTuIdHoaDonNhap(IdHoaDonNhap);
            CapNhatDanhSachNhaPP_SanPham_MaSanPham();
            cobNhaPhanPhoi.Select();
        }

        private void dgdDanhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgdDanhSachSanPham.CurrentRow != null)
            {
                cobSanPham.Text = dgdDanhSachSanPham.CurrentRow.Cells["colSanPham"].Value.ToString();
                numudSoLuong.Value = decimal.Parse(dgdDanhSachSanPham.CurrentRow.Cells["colSoLuong"].Value.ToString());
                numupSoLuongKM.Value = decimal.Parse(dgdDanhSachSanPham.CurrentRow.Cells["colSoLuongKM"].Value.ToString());
                txtGia.Text = ulong.Parse(dgdDanhSachSanPham.CurrentRow.Cells["colGia"].Value.ToString(), NumberStyles.AllowThousands).ToString();
            }
        }

        private void btnLuuHoaDonNhap_Click(object sender, EventArgs e)
        {
            if (KiemTraHoaDonNhapHopLe(cobNhaPhanPhoi.Text, cobSanPham, cobNhaPhanPhoi, txtTongThanhTien.Text, txtThanhToan.Text, dgdDanhSachSanPham))
            {
                if (LuuThayDoiHoaDonNhap(IdHoaDonNhap, cobNhaPhanPhoi.Text, txtTongThanhTien.Text, txtThanhToan.Text, txtGhiChu.Text, dgdDanhSachSanPham))
                {
                    MainForm.ThongBao("Lưu thay đổi hóa đơn nhập thành công");
                    MainForm.HienThiDanhSachHoaDonNhapHang();
                    Close();
                }
                else MainForm.ThongBao("Có lỗi trong quá trình lưu thay đổi");
            }
        }
       
    }
}
