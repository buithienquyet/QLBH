using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SQLite;
using Dapper;

namespace PMQLBH
{
    public partial class frmBanHang : Form
    {
        frmPMQLBH MainForm;

        public frmBanHang(frmPMQLBH mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private bool KiemTraHoaDonBanHopLe()
        {
            ulong ThanhToan;
            ulong CongCho;
            if (QLBH.TonTaiKhachHang(cobKhachHang.Text) == false)
            {
                MessageBox.Show("Khách hàng không tồn tại");
                return false;
            }
            if (dgdDanhSachSanPham.RowCount == 0)
            {
                MessageBox.Show("Danh sách sản phẩm trống!");
                return false;
            }
            else
            {
                for (int i = 0; i < dgdDanhSachSanPham.RowCount; i++)
                {
                    if (KiemTraSanPham(dgdDanhSachSanPham["colSanPham", i].Value.ToString(), double.Parse(dgdDanhSachSanPham["colSoLuong", i].Value.ToString()), ulong.Parse(dgdDanhSachSanPham["colGia", i].Value.ToString(), NumberStyles.AllowThousands), dgdDanhSachSanPham["colDonViTinh", i].Value.ToString()) == false)
                    {
                        MessageBox.Show("Dữ liệu trong danh sách sản phẩm không hợp lệ");
                        return false;
                    }
                    for (int j = i + 1; j < dgdDanhSachSanPham.RowCount; j++)
                        if (dgdDanhSachSanPham["colSanPham", j].Value.ToString() == dgdDanhSachSanPham["colSanPham", i].Value.ToString())
                        {
                            MessageBox.Show("Dữ liệu trong danh sách sản phẩm không hợp lệ");
                            return false;
                        }
                }
            }
            try
            {
                ulong.Parse(txtTongThanhTien.Text, NumberStyles.AllowThousands);
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu thành tiền không hợp lệ");
                return false;
            }
            if (ulong.TryParse(txtThanhToan.Text, out ThanhToan) == false)
            {
                MessageBox.Show("Dữ liệu thanh toán không hợp lệ");
                return false;
            }
            if (chkCongCho.Checked == true)
            {
                if (QLBH.TonTaiXeCho(cobXeCho.Text) == false)
                {
                    MessageBox.Show("Xe chở không tồn tại");
                    return false;
                }
                if (ulong.TryParse(txtCongCho.Text, out CongCho) == false)
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

        private bool BanHang(string khachHang, string thanhTien, string thanhToan, string ghiChu, DataGridView danhSachSanPham, bool coXeCho, string xeCho, string congCho)
        {
            ulong ThanhTien;
            ulong ThanhToan;
            ThanhTien = ulong.Parse(thanhTien, NumberStyles.AllowThousands);
            ThanhToan = ulong.Parse(thanhToan);
            QLBH.ChuanHoaXau(ref ghiChu);
            ulong IdHoaDonBan = 1;
            SQLiteTransaction tranBanHang = QLBH.con.BeginTransaction();
            if (QLBH.con.QueryFirst<ulong>("select count(*) from sqlite_sequence where name='hoa_don_ban'") != 0)
                IdHoaDonBan = 1 + QLBH.con.QueryFirst<ulong>("select seq from sqlite_sequence where name='hoa_don_ban'");
            try
            {
                QLBH.con.Query(string.Format("insert into hoa_don_ban(id,id_khach_hang,thanh_tien,thanh_toan,ghi_chu,tg_tao) values ({0},{1},{2},{3},'{4}','{5}')", IdHoaDonBan, QLBH.LayIdKhachHangTuTenKhachHang(khachHang), ThanhTien, ThanhToan, ghiChu, QLBH.GetTimeNow()));
                for (int i = 0; i < danhSachSanPham.RowCount; i++)
                {
                    QLBH.con.Query(string.Format("insert into san_pham_da_ban(id_hoa_don_ban,id_san_pham,gia,so_luong) values({0},{1},{2},{3})", IdHoaDonBan, QLBH.LayIdTuTenSanPham(danhSachSanPham["colSanPham", i].Value.ToString()), ulong.Parse(danhSachSanPham["colGia", i].Value.ToString(), NumberStyles.AllowThousands), decimal.Parse(danhSachSanPham["colSoLuong", i].Value.ToString())));
                }
                if (coXeCho == true)
                {
                    QLBH.con.Query(string.Format("insert into cong_cho(id_hoa_don_ban, id_xe_cho, tien_cho) values({0},{1},{2})", IdHoaDonBan, QLBH.LayIdKhachHangTuTenKhachHang(xeCho), ulong.Parse(congCho)));
                }
                tranBanHang.Commit();
                return true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Lỗi: " + er.ToString());
                tranBanHang.Rollback();
                return false;
            }
        }

        void CapNhatSTTTrongDSSanPham()
        {
            for (int i = 0; i < dgdDanhSachSanPham.RowCount; i++)
                dgdDanhSachSanPham.Rows[i].Cells["colSTT"].Value = (i + 1).ToString();
        }

        void CapNhatThanhTien()
        {
            ulong TongThanhTien = 0;
            if (dgdDanhSachSanPham.RowCount > 0)
            {
                for (int i = 0; i < dgdDanhSachSanPham.RowCount; i++)
                {
                    string thanhTien;
                    if (dgdDanhSachSanPham.Rows[i].Cells["colThanhTien"].Value == null)
                        continue;
                    else
                    {
                        thanhTien = dgdDanhSachSanPham.Rows[i].Cells["colThanhTien"].Value.ToString();
                    }
                    if (thanhTien == "")
                        continue;
                    else if (thanhTien == "###")
                    {
                        txtTongThanhTien.Text = "###";
                        break;
                    }
                    else
                    {
                        TongThanhTien += ulong.Parse(dgdDanhSachSanPham.Rows[i].Cells["colThanhTien"].Value.ToString(), System.Globalization.NumberStyles.AllowThousands);
                    }
                }
                txtTongThanhTien.Text = TongThanhTien.ToString("#,0");
            }
            else txtTongThanhTien.Text = "###";
        }

        void CapNhatThanhTienTrongDSSanPham(int row)
        {
            if (row >= dgdDanhSachSanPham.Rows.Count)
                MessageBox.Show("Lỗi!");
            try
            {
                double soLuong = double.Parse(dgdDanhSachSanPham[3, row].Value.ToString());
                ulong gia = ulong.Parse(dgdDanhSachSanPham[4, row].Value.ToString());
                dgdDanhSachSanPham[5, row].Value = (soLuong * gia).ToString("#,0");
            }
            catch
            {
                dgdDanhSachSanPham[5, row].Value = "###";
            }
        }

        void CapNhatNhanThanhToan() //Cập nhật nhãn thanh toán
        {
            ulong ThanhToan;
            if (ulong.TryParse(txtThanhToan.Text, out ThanhToan))
            {
                lblHienThiThanhToan.Text = ThanhToan.ToString("#,0");
            }
            else lblHienThiThanhToan.Text = "Không hợp lệ!";
        }

        bool KiemTraSanPham(string tenSanPham, double soLuong, ulong gia, string donViTinh)
        {
            if (QLBH.TonTaiSanPham(tenSanPham) == false)
            {
                MessageBox.Show("Sản phẩm " + tenSanPham + " không tồn tại!");
                return false;
            }
            if (soLuong == 0)
            {
                MessageBox.Show("Số lượng của sản phẩm bằng 0!");
                return false;
            }
            if (soLuong > QLBH.LaySoLuongHienCoCuaSanPham(QLBH.LayIdTuTenSanPham(tenSanPham)))
            {
                MessageBox.Show("Mặt hàng " + tenSanPham + " hiện chỉ còn lại số lượng là " + QLBH.LaySoLuongHienCoCuaSanPham(QLBH.LayIdTuTenSanPham(tenSanPham)).ToString() + " nhỏ hơn số lượng bạn đã nhập nên không thể thực hiện thao tác này!");
                return false;
            }
            if (QLBH.LayGiaSanPhamTuTenSanPham(tenSanPham) != gia)
            {
                MessageBox.Show("Mặt hàng " + tenSanPham + " có giá chưa hợp lệ!");
                return false;
            }
            if (QLBH.LayDonViTinhTuTenSanPham(tenSanPham) != donViTinh)
            {
                MessageBox.Show("Mặt hàng " + tenSanPham + " có đơn vị tính chưa hợp lệ!");
                return false;
            }
            return true;
        }

        //bool KiemTraThemSanPham()
        //{
        //    if (ChiSoSanPham(cobSanPham.Text) != -1)
        //    {
        //        dgdDanhSachSanPham.CurrentCell = dgdDanhSachSanPham.Rows[ChiSoSanPham(cobSanPham.Text)].Cells[0];
        //        MessageBox.Show("Sản phẩm đã có trong danh sách, bạn có thể sửa và lưu lại thay đổi!");
        //        return false;
        //    }
        //    if (KiemTraSanPham(cobSanPham.Text, (double)numudSoLuong.Value, ulong.Parse(txtGia.Text, NumberStyles.AllowThousands), txtDonViTinh.Text) == false)
        //        return false;
        //    return true;
        //}

        void ThemSanPham()
        {
            //dgdDanhSachSanPham.Rows.Add("", cobSanPham.Text, txtDonViTinh.Text, numudSoLuong.Value.ToString("0.0"), ulong.Parse(txtGia.Text, System.Globalization.NumberStyles.AllowThousands).ToString("#,0"), txtThanhTien.Text);
        }

        //bool KiemTraLuuSanPham()
        //{
        //    if (dgdDanhSachSanPham.CurrentRow == null)
        //    {
        //        MessageBox.Show("Bạn phải chọn một sản phẩm trước khi lưu thay đổi!");
        //        return false;
        //    }
        //    if (QLBH.AppTonTaiSanPham(cobSanPham.Text) == false)
        //    {
        //        MessageBox.Show("Sản phẩm không tồn tại!");
        //        return false;
        //    }
        //    if (dgdDanhSachSanPham.CurrentRow.Cells["colSanPham"].Value.ToString() != cobSanPham.Text)
        //    {
        //        MessageBox.Show("Tên sản phẩm không hợp lệ để lưu thay đổi");
        //        return false;
        //    }
        //    if (numudSoLuong.Value == 0)
        //    {
        //        MessageBox.Show("Bạn chưa nhập số lượng của sản phẩm!");
        //        return false;
        //    }
        //    if ((double)numudSoLuong.Value > QLBH.LaySoLuongHienCoCuaSanPham(QLBH.LayIdTuTenSanPham(cobSanPham.Text)))
        //    {
        //        MessageBox.Show("Mặt hàng hiện chỉ còn lại số lượng là " + QLBH.LaySoLuongHienCoCuaSanPham(QLBH.LayIdTuTenSanPham(cobSanPham.Text)).ToString() + " nhỏ hơn số lượng bạn đã nhập nên không thể thực hiện thao tác này!");
        //        return false;
        //    }
        //    return true;
        //}

        int ChiSoSanPham(string tenSanPham)
        {
            for (int i = 0; i < dgdDanhSachSanPham.RowCount; i++)
                if (dgdDanhSachSanPham.Rows[i].Cells["colSanPham"].Value.ToString() == tenSanPham)
                    return i;
            return -1;
        }

        //void CapNhatDanhSachKhachHang_XeCho_SanPham_MaSanPham()
        //{
        //    foreach (string SanPham in QLBH.LayDanhSachSanPham())
        //    {
        //        cobSanPham.Items.Add(SanPham);
        //    }
        //    foreach (string MaSanPham in QLBH.LayDanhSachMaSanPham())
        //    {
        //        cobMaSanPham.Items.Add(MaSanPham);
        //    }
        //    foreach (string KhachHang in QLBH.LayDanhSachKhachHang())
        //    {
        //        cobKhachHang.Items.Add(KhachHang);
        //    }

        //    foreach (string XeCho in QLBH.LayDanhSachXeCho())
        //    {
        //        cobXeCho.Items.Add(XeCho);
        //    }
        //}

        void CapNhatNoMoi()
        {
            ulong ThanhToan, TongThanhTien;
            try
            {
                TongThanhTien = ulong.Parse(txtTongThanhTien.Text, NumberStyles.AllowThousands);
            }
            catch
            {
                txtNoMoi.Text = "Không hợp lệ!";
                return;
            }
            if (ulong.TryParse(txtThanhToan.Text, out ThanhToan))
            {
                if (TongThanhTien >= ThanhToan)
                    txtNoMoi.Text = (TongThanhTien - ThanhToan).ToString("#,0");
                else
                {
                    txtNoMoi.Text = "0, trả lại: " + (ThanhToan - TongThanhTien).ToString("#,0");
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
            txtTongNo.Text = (NoMoi + NoCu).ToString("#,0");
        }

        void CapNhatNoCu()
        {
            if (cobKhachHang.Items.Contains(cobKhachHang.Text))
            {
                txtNoCu.Text = QLBH.LayNoCuaKhachHang(QLBH.LayIdKhachHangTuTenKhachHang(cobKhachHang.Text)).ToString("#,0");
            }
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            //CapNhatDanhSachKhachHang_XeCho_SanPham_MaSanPham();
            //cobKhachHang.DisplayMember = "ten";
            //cobKhachHang.DataSource = QLBH.DataSetDanhSach.Tables["DanhSachKhachHang"];
            //cobSanPham.DisplayMember = "ten";
            //cobSanPham.DataSource = QLBH.DataSetDanhSach.Tables["DanhSachSanPham"];
            //cobMaSanPham.DisplayMember = "ma";
            //cobMaSanPham.DataSource = QLBH.DataSetDanhSach.Tables["DanhSachSanPham"];
            //cobXeCho.DisplayMember = "ten";
            //cobXeCho.DataSource = QLBH.DataSetDanhSach.Tables["DanhSachXeCho"];
            //cobKhachHang.Select();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cobSanPham_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(QLBH.DataSetDanhSach.Tables["DanhSachSanPham"].Rows.Count.ToString());
            //if (QLBH.AppTonTaiSanPham(cobSanPham.Text))
            //{
            //    txtDonViTinh.Text = QLBH.LayDonViTinhTuTenSanPham(cobSanPham.Text);
            //    cobMaSanPham.Text = QLBH.LayMaSanPhamTuTenSanPham(cobSanPham.Text);
            //    txtGia.Text = QLBH.LayGiaSanPhamTuTenSanPham(cobSanPham.Text).ToString();
            //    numudSoLuong.Value = 0;
            //    cobSanPham.BackColor = QLBH.XanhNhat;
            //}
            //else cobSanPham.BackColor = Color.White;
        }

        private void cobSanPham_Leave(object sender, EventArgs e)
        {
            //if (QLBH.AppTonTaiSanPham(cobSanPham.Text))
            //    cobSanPham.BackColor = QLBH.XanhNhat;
            //else cobSanPham.BackColor = QLBH.DoNhat;
        }

        private void cobMaSanPham_TextChanged(object sender, EventArgs e)
        {
            //if (QLBH.AppTonTaiMaSanPham(cobMaSanPham.Text))
            //{
            //    cobSanPham.Text = QLBH.LayTenSanPhamTuMaSanPham(cobMaSanPham.Text);
            //    cobMaSanPham.BackColor = QLBH.XanhNhat;
            //}
            //else cobMaSanPham.BackColor = Color.White;
        }

        private void cobMaSanPham_Leave(object sender, EventArgs e)
        {
            //if (QLBH.AppTonTaiMaSanPham(cobMaSanPham.Text))
            //    cobMaSanPham.BackColor = QLBH.XanhNhat;
            //else cobMaSanPham.BackColor = QLBH.DoNhat;
        }

        private void numudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            CapNhatThanhTien();
        }

        //private void btnThemSanPham_Click(object sender, EventArgs e)
        //{
        //    if (KiemTraThemSanPham())
        //    {
        //        ThemSanPham();
        //        CapNhatTongThanhTien();
        //    }
        //}

        private void dgdDanhSachSanPham_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CapNhatSTTTrongDSSanPham();
        }

        private void dgdDanhSachSanPham_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CapNhatSTTTrongDSSanPham();
        }

        private void dgdDanhSachSanPham_Sorted(object sender, EventArgs e)
        {
            CapNhatSTTTrongDSSanPham();
        }



        //private void btnLuu_Click(object sender, EventArgs e)
        //{
        //    if (KiemTraLuuSanPham())
        //    {
        //        LuuSanPham();
        //        CapNhatTongThanhTien();
        //    }
        //}

        private void txtTongThanhTien_TextChanged(object sender, EventArgs e)
        {
            CapNhatNoMoi();
        }

        private void txtThanhToan_TextChanged(object sender, EventArgs e)
        {
            CapNhatNhanThanhToan();
            CapNhatNoMoi();
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

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if (KiemTraHoaDonBanHopLe())
            {
                if (BanHang(cobKhachHang.Text, txtTongThanhTien.Text, txtThanhToan.Text, txtGhiChu.Text, dgdDanhSachSanPham, chkCongCho.Checked, cobXeCho.Text, txtCongCho.Text))
                {
                    MainForm.ThongBao("Bán hàng thành công");
                    MainForm.HienThiDanhSachHoaDonBanHang();
                    Close();
                }
                else MainForm.ThongBao("Có lỗi trong quá trình nhập hàng!");
            }
        }

        private void cobKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (QLBH.AppTonTaiKhachHang(cobKhachHang.Text))
            {
                txtNoCu.Text = QLBH.LayNoCuaKhachHang(QLBH.LayIdKhachHangTuTenKhachHang(cobKhachHang.Text)).ToString("#,0");
                if (QLBH.KhachHangLaXeCho(QLBH.LayIdKhachHangTuTenKhachHang(cobKhachHang.Text)))
                {
                    chkCongCho.Checked = false;
                    chkCongCho.Enabled = false;
                }
                else chkCongCho.Enabled = true;
                cobKhachHang.BackColor = QLBH.XanhNhat;
            }
            else cobKhachHang.BackColor = Color.White;
        }

        private void txtNoMoi_TextChanged(object sender, EventArgs e)
        {
            CapNhatTongNo();
        }

        private void txtNoCu_TextChanged(object sender, EventArgs e)
        {
            CapNhatTongNo();
        }

        private void txtCongCho_TextChanged(object sender, EventArgs e)
        {
            ulong CongCho;
            if (ulong.TryParse(txtCongCho.Text, out CongCho))
            {
                lblCongCho.Text = CongCho.ToString("#,0");
            }
            else lblCongCho.Text = "Không hợp lệ!";
        }

        private void dgdDanhSachSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgdDanhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgdDanhSachSanPham.CurrentRow != null)
            //{
            //    cobSanPham.Text = dgdDanhSachSanPham.CurrentRow.Cells["colSanPham"].Value.ToString();
            //    numudSoLuong.Value = decimal.Parse(dgdDanhSachSanPham.CurrentRow.Cells["colSoLuong"].Value.ToString());
            //    txtGia.Text = ulong.Parse(dgdDanhSachSanPham.CurrentRow.Cells["colGia"].Value.ToString(), NumberStyles.AllowThousands).ToString();
            //}
        }

        private void cobKhachHang_Leave(object sender, EventArgs e)
        {
            if (QLBH.AppTonTaiKhachHang(cobKhachHang.Text))
                cobKhachHang.BackColor = QLBH.XanhNhat;
            else cobKhachHang.BackColor = QLBH.DoNhat;
        }

        private void cobSanPham_Enter(object sender, EventArgs e)
        {
            //cobSanPham.BackColor = Color.White;
        }

        private void cobKhachHang_Enter(object sender, EventArgs e)
        {
            cobKhachHang.BackColor = Color.White;
        }

        private void cobMaSanPham_Enter(object sender, EventArgs e)
        {
            //cobMaSanPham.BackColor = Color.White;
        }

        private void cobXeCho_TextChanged(object sender, EventArgs e)
        {
            if (QLBH.AppTonTaiXeCho(cobXeCho.Text))
                cobXeCho.BackColor = QLBH.XanhNhat;
            else cobXeCho.BackColor = Color.White;
        }

        private void cobXeCho_Leave(object sender, EventArgs e)
        {
            if (QLBH.AppTonTaiXeCho(cobXeCho.Text))
                cobXeCho.BackColor = QLBH.XanhNhat;
            else cobXeCho.BackColor = QLBH.DoNhat;
        }

        private void cobXeCho_Enter(object sender, EventArgs e)
        {
            cobXeCho.BackColor = Color.White;
        }

        private void cobKhachHang_TextUpdate(object sender, EventArgs e)
        {
            //  MessageBox.Show("Run");
        }

        private void lblTongThanhTien_Click(object sender, EventArgs e)
        {

        }

        private void chkBocVac_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBocVac.Checked == true)
                txtBocVac.Enabled = true;
            else txtBocVac.Enabled = false;
        }

        private void txtBocVac_TextChanged(object sender, EventArgs e)
        {
            ulong BocVac;
            if (ulong.TryParse(txtBocVac.Text, out BocVac))
            {
                lblBocVac.Text = BocVac.ToString("#,0");
            }
            else lblBocVac.Text = "Không hợp lệ!";
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            //ulong Gia;
            //if (ulong.TryParse(txtGia.Text, out Gia))
            //{
            //    lblHienThiGia.Text = Gia.ToString("#,0");
            //    CapNhatThanhTien();
            //}
            //else lblHienThiGia.Text = "Không hợp lệ!";
        }

        private void dgdDanhSachSanPham_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            switch (dgdDanhSachSanPham.CurrentCell.ColumnIndex)
            {
                case 1:     //cell thuộc col sản phẩm
                    {
                        var txtTenSanPham = e.Control as TextBox;
                        var sanPhamCollection = new AutoCompleteStringCollection();
                        sanPhamCollection.AddRange(QLBH.LayDanhSachSanPham());
                        txtTenSanPham.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        txtTenSanPham.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        txtTenSanPham.AutoCompleteCustomSource = sanPhamCollection;
                    }
                    break;
                case 3:   //cell thuộc col số lượng
                    {
                        (e.Control as TextBox).AutoCompleteMode = AutoCompleteMode.None;
                    }
                    break;
                case 4: //cell thuộc col giá
                    {
                        (e.Control as TextBox).AutoCompleteMode = AutoCompleteMode.None;
                    }
                    break;
                default:
                    {

                    }
                    break;
            }
        }

        private void dgdDanhSachSanPham_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int colIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            if (dgdDanhSachSanPham[colIndex, rowIndex].Value != null) //Kiểm tra sau khi edit giá trị trong cell có null hay không
            {
                switch (colIndex)
                {
                    case 1: //cell thuộc col tên sản phẩm
                        {
                            if (QLBH.TonTaiSanPham(dgdDanhSachSanPham[colIndex, rowIndex].Value.ToString())) // Kiểm tra tên sản phẩm nhập vào hợp lệ
                            {
                                dgdDanhSachSanPham[2, rowIndex].Value = QLBH.LayDonViTinhTuTenSanPham(dgdDanhSachSanPham[colIndex, rowIndex].Value.ToString()); //Lấy đơn vị tính và đưa thông tin vào bảng
                                dgdDanhSachSanPham[3, rowIndex].Value = "";
                                dgdDanhSachSanPham[4, rowIndex].Value = "";
                            }
                            else
                            {
                                dgdDanhSachSanPham[colIndex, rowIndex].Value = "###";
                                dgdDanhSachSanPham[2, rowIndex].Value = "###";
                            }
                        }
                        break;
                    case 3: //cell thuộc col số lượng
                        {
                            double soLuong;
                            double soLuongHienCoCuaSanPham;
                            string tenSanPham;
                            if (double.TryParse(dgdDanhSachSanPham[colIndex, rowIndex].Value.ToString(), out soLuong)) // thử kiểm tra số lượng nhập vào hợp lệ
                            {
                                tenSanPham = dgdDanhSachSanPham[1, rowIndex].Value.ToString();
                                if (QLBH.TonTaiSanPham(tenSanPham)) //Kiểm tra sự tồn tại của sản phẩm
                                {
                                    soLuongHienCoCuaSanPham = QLBH.LaySoLuongHienCoCuaSanPham(QLBH.LayIdTuTenSanPham(tenSanPham));
                                    dgdDanhSachSanPham[3, rowIndex].Value = soLuong.ToString("0.0");
                                    if (soLuong > soLuongHienCoCuaSanPham) //Kiêm tra số lượng nhập có lớn hơn số lượng hiện có hay không
                                    {
                                        MessageBox.Show("Số lượng bạn nhập là " + soLuong.ToString() + " lớn hơn số lượng hiện có của sản phẩm là " + soLuongHienCoCuaSanPham.ToString() + Environment.NewLine + "Vui lòng kiểm tra lại!");
                                        dgdDanhSachSanPham[3, rowIndex].Value = "0.0";
                                    }
                                    else
                                    {
                                        dgdDanhSachSanPham[3, rowIndex].Value = soLuong.ToString("0.0");
                                    }
                                }
                                else //Sản phẩm không tồn tại
                                {
                                    MessageBox.Show("Sản phẩm không tồn tại!");
                                    dgdDanhSachSanPham[3, rowIndex].Value = "0.0";
                                }
                            }
                            else
                            {
                                dgdDanhSachSanPham[3, rowIndex].Value = "0.0";
                            }
                        }
                        break;
                    case 4: //cell thuộc col giá
                        {
                            ulong gia;
                            if (ulong.TryParse(dgdDanhSachSanPham[colIndex, rowIndex].Value.ToString(), out gia))
                            {
                                dgdDanhSachSanPham[colIndex, rowIndex].Value = gia.ToString();
                            }
                            else
                            {
                                dgdDanhSachSanPham[colIndex, rowIndex].Value = "0";
                            }
                        }
                        break;
                    default:
                        {

                        }
                        break;
                }
                CapNhatThanhTienTrongDSSanPham(rowIndex);
                CapNhatThanhTien();
            }
        }
    }
}
