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
using System.Globalization;
using System.Threading;

namespace PMQLBH
{
    public partial class frmPMQLBH : Form
    {
        public bool TaiLaiBanHang = false;
        public bool TaiLaiNhapHang = true;
        public bool TaiLaiKhachHang = true;
        public bool TaiLaiNhaPP = true;
        public bool TaiLaiSoNo_TrNo = false;
        public bool TaiLaiSanPham = true;

        int ThoiGianThongBao = 0;
       
        public void ThongBao(string thongBao)
        {
            ThoiGianThongBao = 8;
            lblThongBao.Text = thongBao;
            tmrThongBao.Enabled = true;
        }

        

        

        public void HienThiDanhSachKhachHang()
        {
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("select * from khach_hang_view", QLBH.con);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dgdKH_DanhSachKhachHang.DataSource = datatable;
            dgdKH_DanhSachKhachHang.Columns[0].Visible = false;
            dgdKH_DanhSachKhachHang.CurrentCell = dgdKH_DanhSachKhachHang.Rows[0].Cells[1];
        }

        public void HienThiSoNo_DanhSachKhachHang()
        {
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("select * from khach_hang_no_view", QLBH.con);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dgdSoNo_DanhSachKhachHang.DataSource = datatable;
            dgdSoNo_DanhSachKhachHang.Columns["id"].Visible = false;
        }

        public void HienThiDanhSachHoaDonNhapHang()
        {
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("select * from hoa_don_nhap_view", QLBH.con);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dgdNH_DanhSachHoaDonNhap.DataSource = datatable;
        }

        public void HienThiDanhSachTraNo()
        {
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("select * from khach_hang_nha_phan_phoi_tra_no_view", QLBH.con);
            DataTable datatable = new DataTable();
            datatable.Columns.Add("Mã hóa đơn", typeof(string));
            datatable.Columns.Add("Tên khách hàng/Nhà phân phối", typeof(string));
            datatable.Columns.Add("Loại", typeof(string));
            datatable.Columns.Add("Số tiền", typeof(string));
            datatable.Columns.Add("Thời gian tạo", typeof(string));
            datatable.Columns.Add("tg_tao", typeof(string));
            dataadapter.Fill(datatable);
            foreach (DataRow row in datatable.Rows)
            {
                row["Số tiền"] = long.Parse(row["Số tiền"].ToString()).ToString("0,0");
            }
            dgdSN_SoNo_DanhSachTraNo.DataSource = datatable;
            dgdSN_SoNo_DanhSachTraNo.Columns["tg_tao"].Visible = false;
            dgdSN_SoNo_DanhSachTraNo.Columns["Số tiền"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        public void HienThiDanhSachHoaDonBanHang()
        {
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("select * from hoa_don_ban_view", QLBH.con);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dgdBH_DanhSachHoaDonBan.DataSource = datatable;
        }

        public void HienThiDanhSachSanPham()
        {
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("select * from san_pham_view", QLBH.con);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dgdSP_DanhSachSanPham.DataSource = datatable;
            dgdSP_DanhSachSanPham.Columns[0].Visible = false;
        }

        public void HienThiLichSuNoCuaKhachHang(string idKhachHang)
        {
            string sql = string.Format("select id as [Mã hóa đơn], (select ten from khach_hang where id=hoa_don_ban.id_khach_hang) as [Tên khách hàng], thanh_tien - thanh_toan as [Số tiền], substr('Nợ',1,2) as [Loại],strftime('%d-%m-%Y %H:%M:%S',tg_tao) as [Thời gian tạo], tg_tao as tg_tao from hoa_don_ban where thanh_tien>thanh_toan and id_khach_hang={0} union all select cong_cho.id_hoa_don_ban as [Mã hóa đơn], khach_hang.ten as [Tên khách hàng], tien_cho as [Số tiền], substr('Công chở', 1, 8) as [Loại], strftime('%d-%m-%Y %H:%M:%S', hoa_don_ban.tg_tao) as [Thời gian tạo], hoa_don_ban.tg_tao as tg_tao from cong_cho left join hoa_don_ban on cong_cho.id_hoa_don_ban = hoa_don_ban.id left join khach_hang on hoa_don_ban.id_khach_hang = khach_hang.id where cong_cho.id_xe_cho ={0} union all select khach_hang_tra_no.id as [Mã hóa đơn], khach_hang.ten as [Tên khách hàng], khach_hang_tra_no.tien_tra as [Số tiền], substr('Trả nợ', 1, 6) as [Loại], strftime('%d-%m-%Y %H:%M:%S', khach_hang_tra_no.tg_tao) as [Thời gian tạo], khach_hang_tra_no.tg_tao as tg_tao from khach_hang_tra_no left join khach_hang on khach_hang_tra_no.id_khach_hang = khach_hang.id where khach_hang_tra_no.id_khach_hang = {0}", idKhachHang);
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter(sql, QLBH.con);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            datatable.Columns.Add("colNo");
            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                datatable.Rows[i]["colNo"] = QLBH.LayNoCuaKhachHangTinhDenThoiDiemCoAm(idKhachHang, datatable.Rows[i]["tg_tao"].ToString()).ToString("0,0");
            }
            dgdSoNo_LichSuNoCuaKhachHang.DataSource = datatable;
            dgdSoNo_LichSuNoCuaKhachHang.Columns["colNo"].HeaderText = "Nợ";
            dgdSoNo_LichSuNoCuaKhachHang.Sort(dgdSoNo_LichSuNoCuaKhachHang.Columns["tg_tao"], ListSortDirection.Descending);
            dgdSoNo_LichSuNoCuaKhachHang.Columns["tg_tao"].Visible = false;
        }

        public void HienThiDanhSachNhaPP()
        {
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("select * from nha_phan_phoi_view", QLBH.con);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dgdNPP_DanhSachNhaPP.DataSource = datatable;
            dgdNPP_DanhSachNhaPP.Columns[0].Visible = false;
            dgdNPP_DanhSachNhaPP.CurrentCell = dgdNPP_DanhSachNhaPP.Rows[0].Cells[1];
        }

        bool KiemTraXoaKhachHang()
        {
            if (dgdKH_DanhSachKhachHang.CurrentRow == null)
            {
                MessageBox.Show("Bạn phải chọn một khách hàng trước khi xóa!");
                return false;
            }
            if (MessageBox.Show("Bạn có muốn xóa khách hàng " + dgdKH_DanhSachKhachHang.CurrentRow.Cells["Tên khách hàng"].Value.ToString() + "?", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return false;
            else
            {
                string IdKhachHang = dgdKH_DanhSachKhachHang.CurrentRow.Cells["id"].Value.ToString();
                if (QLBH.con.QueryFirst<ulong>("select count(*) from hoa_don_ban where id_khach_hang=" + IdKhachHang) > 0)
                {
                    MessageBox.Show("Bạn đã giao dịch với khách hàng này, nên không thể thực hiện thao tác xóa!");
                    return false;
                }
            }
            return true;
        }

        private bool XoaKhachHang()
        {
            string IdKhachHang = dgdKH_DanhSachKhachHang.CurrentRow.Cells["id"].Value.ToString();
            try
            {
                QLBH.con.Query(string.Format("delete from khach_hang where id={0}", IdKhachHang));
            }
            catch (Exception er)
            {
                MessageBox.Show("Lỗi: " + er.ToString());
                return false;
            }
            return true;
        }

        private bool XoaNhaPP()
        {
            string IdNhaPP = dgdNPP_DanhSachNhaPP.CurrentRow.Cells["id"].Value.ToString();
            try
            {
                QLBH.con.Query(string.Format("delete from nha_phan_phoi where id={0}", IdNhaPP));
            }
            catch (Exception er)
            {
                MessageBox.Show("Lỗi: " + er.ToString());
                return false;
            }
            return true;
        }

        public bool DoiGiaBan(string id, ulong giaMoi)
        {
            try
            {
                QLBH.con.Query(string.Format("update san_pham set gia={0} where id={1}", giaMoi, id));
            }
            catch (Exception er)
            {
                MessageBox.Show("Lỗi: " + er.ToString());
                return false;
            }
            return true;
        }

        private bool XoaSanPham()
        {
            string IdSanPham = dgdSP_DanhSachSanPham.CurrentRow.Cells["id"].Value.ToString();
            try
            {
                QLBH.con.Query(string.Format("delete from san_pham where id={0}", IdSanPham));
            }
            catch (Exception er)
            {
                MessageBox.Show("Lỗi: " + er.ToString());
                return false;
            }
            return true;
        }

        public bool KiemTraXoaSanPham()
        {
            if (dgdSP_DanhSachSanPham.CurrentRow == null)
            {
                MessageBox.Show("Bạn phải chọn một sản phẩm trước khi xóa!");
                return false;
            }
            if (MessageBox.Show("Bạn có muốn xóa sản phẩm " + dgdSP_DanhSachSanPham.CurrentRow.Cells["Tên sản phẩm"].Value.ToString() + "?", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return false;
            }
            string IdSanPham = dgdSP_DanhSachSanPham.CurrentRow.Cells["id"].Value.ToString();
            if (QLBH.con.QueryFirst<ulong>("select count(*) from san_pham_da_nhap where id_san_pham=" + IdSanPham) > 0)
            {
                MessageBox.Show("Bạn đã nhập sản phẩm này nên không thể xóa sản phẩm!");
                return false;
            }
            if (QLBH.con.QueryFirst<ulong>("select count(*) from san_pham_da_ban where id_san_pham=" + IdSanPham) > 0)
            {
                MessageBox.Show("Bạn đã bán sản phẩm này nên không thể xóa sản phẩm!");
                return false;
            }
            return true;
        }

        bool KiemTraHuyHoaDonNhap()
        {
            if (dgdNH_DanhSachHoaDonNhap.CurrentRow == null)
            {
                MessageBox.Show("Bạn phải chọn một hóa đơn trước khi hủy hóa đơn!");
                return false;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy hóa đơn?", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return false;
            }
            string idHoaDon = dgdNH_DanhSachHoaDonNhap["Mã hóa đơn", dgdNH_DanhSachHoaDonNhap.CurrentRow.Index].Value.ToString();
            string[] DanhSachIdSanPham = QLBH.con.Query<string>("select id_san_pham from san_pham_da_nhap where id_hoa_don_nhap=" + idHoaDon).ToArray(); //Danh sách id sản phẩm có trong hóa đơn
            foreach (string id in DanhSachIdSanPham)
            {
                double SoLuongSanPhamNhungKhongTinhHoaDonNhapCu = QLBH.LaySoLuongHienCoCuaSanPhamNhungKhongTinhHoaDonNhap(id, idHoaDon);
                if (SoLuongSanPhamNhungKhongTinhHoaDonNhapCu < 0)
                {
                    MessageBox.Show("Số lượng bán của mặt hàng " + QLBH.LayTenSanPhamTuId(id) + " đã vượt quá số lượng nhập, nên không thể thực hiện thao tác hủy hóa đơn này");
                    return false;
                }
            }
            return true;
        }

        bool KiemTraHuyHoaDonBan()
        {
            if (dgdBH_DanhSachHoaDonBan.CurrentRow == null)
            {
                MessageBox.Show("Bạn phải chọn một hóa đơn trước khi hủy hóa đơn!");
                return false;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy hóa đơn?", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return false;
            }
            return true;
        }

        bool KiemTraXoaNhaPP()
        {
            if (dgdNPP_DanhSachNhaPP.CurrentRow == null)
            {
                MessageBox.Show("Bạn phải chọn một nhà phân phối trước khi xóa!");
                return false;
            }

            if (MessageBox.Show("Bạn có muốn xóa nhà phân phối " + dgdNPP_DanhSachNhaPP.CurrentRow.Cells["Tên nhà phân phối"].Value.ToString() + "?", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return false;
            else
            {
                string IdNhaPP = dgdNPP_DanhSachNhaPP.CurrentRow.Cells["id"].Value.ToString();
                if (QLBH.con.QueryFirst<ulong>("select count(*) from hoa_don_nhap where id_nha_phan_phoi=" + IdNhaPP) > 0)
                {
                    MessageBox.Show("Bạn đã giao dịch với nhà phân phối này, nên không thể thực hiện thao tác xóa!");
                    return false;
                }
            }
            return true;
        }

        bool HuyHoaDonNhap()
        {
            string idHoaDon = dgdNH_DanhSachHoaDonNhap["Mã hóa đơn", dgdNH_DanhSachHoaDonNhap.CurrentRow.Index].Value.ToString();
            SQLiteTransaction transHuyHoaDon = QLBH.con.BeginTransaction();
            try
            {

                QLBH.con.Query("delete from san_pham_da_nhap where id_hoa_don_nhap =" + idHoaDon);
                QLBH.con.Query("delete from hoa_don_nhap where id=" + idHoaDon);
                transHuyHoaDon.Commit();
            }
            catch (Exception er)
            {
                transHuyHoaDon.Rollback();
                MessageBox.Show("Lỗi: " + er.ToString());
                return false;
            }
            return true;
        }

        bool HuyHoaDonBan()
        {
            string idHoaDon = dgdBH_DanhSachHoaDonBan["Mã hóa đơn", dgdBH_DanhSachHoaDonBan.CurrentRow.Index].Value.ToString();
            SQLiteTransaction transHuyHoaDon = QLBH.con.BeginTransaction();
            try
            {

                QLBH.con.Query("delete from san_pham_da_ban where id_hoa_don_ban =" + idHoaDon);
                QLBH.con.Query("delete from cong_cho where id_hoa_don_ban=" + idHoaDon);
                QLBH.con.Query("delete from hoa_don_ban where id=" + idHoaDon);
                transHuyHoaDon.Commit();
            }
            catch (Exception er)
            {
                transHuyHoaDon.Rollback();
                MessageBox.Show("Lỗi: " + er.ToString());
                return false;
            }
            return true;
        }

        bool KiemTraHuyTraNo()
        {
            if (dgdSN_SoNo_DanhSachTraNo.CurrentRow == null)
            {
                MessageBox.Show("Bạn phải chọn một hóa đơn trước khi xóa");
                return false;
            }
            if (MessageBox.Show("Bạn có chắn chắn muốn xóa trả nợ của khách hàng/nhà phân phối " + dgdSN_SoNo_DanhSachTraNo.CurrentRow.Cells["Tên khách hàng/Nhà phân phối"].Value.ToString() + " ?", "???", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
                return false;
            return true;
        }

        bool HuyTraNo(string idHoaDon, string loai)
        {
            if (loai=="Khách hàng")
            {
                try
                {
                    QLBH.con.Query("delete from khach_hang_tra_no where id=" + idHoaDon);
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
                    QLBH.con.Query("delete from tra_no_nha_phan_phoi where id=" + idHoaDon);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Lỗi: " + e.ToString());
                    return false;
                }
            }
            return true;
        }

        public frmPMQLBH()
        {
            InitializeComponent();
            CultureInfo vn = new CultureInfo("vi-VN");
            vn.NumberFormat.NumberDecimalSeparator = ".";
            vn.NumberFormat.NumberGroupSeparator = ",";
            Thread.CurrentThread.CurrentCulture = vn;
            Thread.CurrentThread.CurrentUICulture = vn;
        }

        private void frmPMQLBH_Load(object sender, EventArgs e)
        {
            ilsChucNang.Images.Clear();
            ilsChucNang.Images.Add(PMQLBH.Properties.Resources.banhang);
            ilsChucNang.Images.Add(PMQLBH.Properties.Resources.khachhang);
            ilsChucNang.Images.Add(PMQLBH.Properties.Resources.nhaphanphoi);
            ilsChucNang.Images.Add(PMQLBH.Properties.Resources.nhaphang);
            ilsChucNang.Images.Add(PMQLBH.Properties.Resources.sanpham);
            ilsChucNang.Images.Add(PMQLBH.Properties.Resources.appicns_Address_Book_icon);
            ilsChucNang.Images.Add(PMQLBH.Properties.Resources.thongke);
            try
            {
                QLBH.con.Open();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
            HienThiDanhSachHoaDonBanHang();
            HienThiDanhSachTraNo();
            QLBH.InitDataSetDanhSach();
            QLBH.CapNhatDanhSachKhachHang();
            QLBH.CapNhatDanhSachNhaPhanPhoi();
            QLBH.CapNhatDanhSachSanPham();
            QLBH.CapNhatDanhSachXeCho();
            QLBH.CapNhatDanhSachKhachHang();
            cobSoNo_LichSuTraNoCuaKH_TenKH.DisplayMember = "ten";
            cobSoNo_LichSuTraNoCuaKH_TenKH.DataSource = QLBH.DataSetDanhSach.Tables["DanhSachKhachHang"];
        }

        private void btnKH_ThemKhachHang_Click(object sender, EventArgs e)
        {
            frmThemKhachHang ThemKhachHang = new frmThemKhachHang(this);
            ThemKhachHang.Show();
        }

        private void btnKH_TaiLai_Click(object sender, EventArgs e)
        {
            HienThiDanhSachKhachHang();
        }

        private void btnKH_XoaKhachHang_Click(object sender, EventArgs e)
        {
            if (KiemTraXoaKhachHang())
            {
                string TenKhachHang = dgdKH_DanhSachKhachHang.CurrentRow.Cells["Tên khách hàng"].Value.ToString();
                if (XoaKhachHang())
                {
                    ThongBao("Đã xóa khách hàng " + TenKhachHang);
                    HienThiDanhSachKhachHang();
                    QLBH.CapNhatDanhSachKhachHang();
                }
                else ThongBao("Thất bại khi xóa khách hàng " + TenKhachHang);
            }
        }

        private void tmrThongBao_Tick(object sender, EventArgs e)
        {
            if (ThoiGianThongBao == 0)
            {
                lblThongBao.Text = "";
                tmrThongBao.Enabled = false;
            }
            ThoiGianThongBao--;
        }

        private void btnKH_SuaKhachHang_Click(object sender, EventArgs e)
        {
            string Id, TenKhachHang, DiaChi, SoDienThoai, GhiChu;
            if (dgdKH_DanhSachKhachHang.CurrentRow != null)
            {
                Id = dgdKH_DanhSachKhachHang.CurrentRow.Cells["id"].Value.ToString();
                TenKhachHang = dgdKH_DanhSachKhachHang.CurrentRow.Cells["Tên khách hàng"].Value.ToString();
                DiaChi = dgdKH_DanhSachKhachHang.CurrentRow.Cells["Địa chỉ"].Value.ToString();
                SoDienThoai = dgdKH_DanhSachKhachHang.CurrentRow.Cells["Số điện thoại"].Value.ToString();
                GhiChu = dgdKH_DanhSachKhachHang.CurrentRow.Cells["Ghi chú"].Value.ToString();
                frmSuaKhachHang SuaKhachHang = new frmSuaKhachHang(this, Id, TenKhachHang, DiaChi, SoDienThoai, GhiChu);
                SuaKhachHang.Show();
            }
            else MessageBox.Show("Bạn phải chọn một khách hàng trước khi sửa!");
        }

        private void btnNPP_ThemNPP_Click(object sender, EventArgs e)
        {
            frmThemNhaPP ThemNhaPP = new frmThemNhaPP(this);
            ThemNhaPP.Show();
        }

        private void btnNPP_TaiLai_Click(object sender, EventArgs e)
        {
            HienThiDanhSachNhaPP();
        }

        private void btnNPP_SuaNPP_Click(object sender, EventArgs e)
        {
            string Id, TenNhaPP, DiaChi, SoDienThoai, GhiChu;
            if (dgdNPP_DanhSachNhaPP.CurrentRow != null)
            {
                Id = dgdNPP_DanhSachNhaPP.CurrentRow.Cells["id"].Value.ToString();
                TenNhaPP = dgdNPP_DanhSachNhaPP.CurrentRow.Cells["Tên nhà phân phối"].Value.ToString();
                DiaChi = dgdNPP_DanhSachNhaPP.CurrentRow.Cells["Địa chỉ"].Value.ToString();
                SoDienThoai = dgdNPP_DanhSachNhaPP.CurrentRow.Cells["Số điện thoại"].Value.ToString();
                GhiChu = dgdNPP_DanhSachNhaPP.CurrentRow.Cells["Ghi chú"].Value.ToString();
                frmSuaNhaPP SuaNhaPP = new frmSuaNhaPP(this, Id, TenNhaPP, DiaChi, SoDienThoai, GhiChu);
                SuaNhaPP.Show();
            }
            else MessageBox.Show("Bạn phải chọn một nhà phân phối trước khi sửa!");
        }

        private void btnNPP_XoaNPP_Click(object sender, EventArgs e)
        {
            if (KiemTraXoaNhaPP())
            {
                string TenNhaPP = dgdNPP_DanhSachNhaPP.CurrentRow.Cells["Tên nhà phân phối"].Value.ToString();
                if (XoaNhaPP())
                {
                    ThongBao("Đã xóa nhà phân phối " + TenNhaPP);
                    HienThiDanhSachNhaPP();
                }
                else ThongBao("Thất bại khi xóa nhà phân phối" + TenNhaPP);
            }
        }

        private void frmPMQLBH_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
            else
            {
                QLBH.con.Close();
            }
        }

        private void btnSP_ThemSanPham_Click(object sender, EventArgs e)
        {
            frmThemSanPham ThemSanPham = new frmThemSanPham(this);
            ThemSanPham.ShowDialog();
        }

        private void btnSP_TaiLai_Click(object sender, EventArgs e)
        {
            HienThiDanhSachSanPham();
        }

        private void btnSP_XoaSanPham_Click(object sender, EventArgs e)
        {
            if (KiemTraXoaSanPham())
            {
                string TenSanPham = dgdSP_DanhSachSanPham.CurrentRow.Cells["Tên sản phẩm"].Value.ToString();
                if (XoaSanPham())
                {
                    ThongBao("Xóa sản phẩm " + TenSanPham + " thành công");
                    QLBH.CapNhatDanhSachSanPham();
                    HienThiDanhSachSanPham();
                }
                else ThongBao("Thất bại khi xóa sản phẩm " + TenSanPham);
            }
        }

        private void btnSP_SuaThongTinSP_Click(object sender, EventArgs e)
        {
            if (dgdSP_DanhSachSanPham.CurrentRow != null)
            {
                frmThayDoiThongTinSanPham ThayDoiThongTinSanPham = new frmThayDoiThongTinSanPham(this, dgdSP_DanhSachSanPham.CurrentRow.Cells["id"].Value.ToString());
                ThayDoiThongTinSanPham.Show();
            }
            else MessageBox.Show("Bạn phải chọn một sản phẩm trước khi thay thông tin!");

        }

        private void btnSP_DoiGiaBan_Click(object sender, EventArgs e)
        {
            if (dgdSP_DanhSachSanPham.CurrentRow != null)
            {
                frmDoiGiaBan DoiGiaBan = new frmDoiGiaBan(this, dgdSP_DanhSachSanPham.CurrentRow.Cells["id"].Value.ToString(), dgdSP_DanhSachSanPham.CurrentRow.Cells["Giá"].Value.ToString(), dgdSP_DanhSachSanPham.CurrentRow.Cells["Đơn vị tính"].Value.ToString());
                DoiGiaBan.Show();
            }
            else MessageBox.Show("Bạn phải chọn một sản phẩm trước khi thay đổi giá bán!");
        }

        private void btnNH_NhapHang_Click(object sender, EventArgs e)
        {
            frmNhapHang NhapHang = new frmNhapHang(this);
            NhapHang.Show();
        }

        private void btnNH_TaiLai_Click(object sender, EventArgs e)
        {
            HienThiDanhSachHoaDonNhapHang();
        }

        private void btnNH_HuyHoaDon_Click(object sender, EventArgs e)
        {
            if (KiemTraHuyHoaDonNhap())
            {
                if (HuyHoaDonNhap())
                {
                    ThongBao("Hủy hóa đơn nhập thành công");
                    HienThiDanhSachHoaDonNhapHang();
                }
                else ThongBao("Có lỗi trong quá trình hủy hóa đơn nhập");
            }
        }

        private void btnBH_TaiLai_Click(object sender, EventArgs e)
        {
            HienThiDanhSachHoaDonBanHang();
        }

        private void btnNH_XemHoaDonNhap_Click(object sender, EventArgs e)
        {
            if (dgdNH_DanhSachHoaDonNhap.CurrentRow != null)
            {
                frmXemHoaDonNhap XemHoaDonNhap = new frmXemHoaDonNhap(this, dgdNH_DanhSachHoaDonNhap["Mã hóa đơn", dgdNH_DanhSachHoaDonNhap.CurrentRow.Index].Value.ToString());
                XemHoaDonNhap.Show();
            }
            else MessageBox.Show("Bạn phải chọn một hóa đơn để xem");
        }

        private void btnNH_SuaHoaDonNhap_Click(object sender, EventArgs e)
        {
            if (dgdNH_DanhSachHoaDonNhap.CurrentRow != null)
            {
                frmSuaHoaDonNhap SuaHoaDonNhap = new frmSuaHoaDonNhap(this, dgdNH_DanhSachHoaDonNhap["Mã hóa đơn", dgdNH_DanhSachHoaDonNhap.CurrentRow.Index].Value.ToString());
                SuaHoaDonNhap.Show();
            }
            else MessageBox.Show("Bạn phải chọn một hóa đơn trước khi sửa");
        }

        private void btnBH_BanHang_Click(object sender, EventArgs e)
        {
            frmBanHang BanHang = new frmBanHang(this);
            BanHang.Show();
        }

        private void tabSanPham_Click(object sender, EventArgs e)
        {

        }

        private void btnBH_HuyHoaDon_Click(object sender, EventArgs e)
        {
            if (KiemTraHuyHoaDonBan())
            {
                if (HuyHoaDonBan())
                {
                    ThongBao("Hủy hóa đơn bán thành công");
                    HienThiDanhSachHoaDonBanHang();
                }
                else ThongBao("Có lỗi trong quá trình hủy hóa đơn bán");
            }
        }

        private void btnBH_SuaHoaDonBan_Click(object sender, EventArgs e)
        {
            if (dgdBH_DanhSachHoaDonBan.CurrentRow != null)
            {
                frmSuaHoaDonBan SuaHoaDonBan = new frmSuaHoaDonBan(this, dgdBH_DanhSachHoaDonBan["Mã hóa đơn", dgdBH_DanhSachHoaDonBan.CurrentRow.Index].Value.ToString());
                SuaHoaDonBan.Show();
            }
            else MessageBox.Show("Bạn phải chọn một hóa đơn trước khi sửa");
        }

        private void btnBH_XemHoaDonBan_Click(object sender, EventArgs e)
        {
            frmXemHoaDonBan XemHoaDonBan = new frmXemHoaDonBan(this, dgdBH_DanhSachHoaDonBan["Mã hóa đơn", dgdBH_DanhSachHoaDonBan.CurrentRow.Index].Value.ToString());
            XemHoaDonBan.Show();
        }

        private void tabDanhSachKhachHang_Enter(object sender, EventArgs e)
        {

        }

        private void btnSoNo_DanhSachNoCuaKH_LocDanhSach_Click(object sender, EventArgs e)
        {
            if (QLBH.TonTaiKhachHang(cobSoNo_LichSuTraNoCuaKH_TenKH.Text))
                HienThiLichSuNoCuaKhachHang(QLBH.LayIdKhachHangTuTenKhachHang(cobSoNo_LichSuTraNoCuaKH_TenKH.Text));
            else MessageBox.Show("Khách hàng không tồn tại");
        }

        private void btnSoNo_TraNo_TraNo_Click(object sender, EventArgs e)
        {
            frmTraNo TraNo = new frmTraNo(this);
            TraNo.Show();
        }

        private void tabSoNo_TraNo_Click(object sender, EventArgs e)
        {

        }

        private void btnSoNo_SoNo_TaiLai_Click(object sender, EventArgs e)
        {
            HienThiDanhSachTraNo();
        }

        private void tabSoNo_TraNo_Enter(object sender, EventArgs e)
        {
            //MessageBox.Show("");
        }

        private void btnBH_InHoaDon_Click(object sender, EventArgs e)
        {
            if (dgdBH_DanhSachHoaDonBan.CurrentRow != null)
            {
                frmInHoaDonBan In = new frmInHoaDonBan(dgdBH_DanhSachHoaDonBan.CurrentRow.Cells["Mã hóa đơn"].Value.ToString());
                In.Show();
            }
        }

        private void btnSoNo_SoNo_Xoa_Click(object sender, EventArgs e)
        {
            if (KiemTraHuyTraNo())
            {
                string Id = dgdSN_SoNo_DanhSachTraNo.CurrentRow.Cells["Mã hóa đơn"].Value.ToString();
                string Loai= dgdSN_SoNo_DanhSachTraNo.CurrentRow.Cells["Loại"].Value.ToString();
                string Ten= dgdSN_SoNo_DanhSachTraNo.CurrentRow.Cells["Tên khách hàng/Nhà phân phối"].Value.ToString();
                if (HuyTraNo(Id,Loai))
                {
                    if (Loai == "Khách hàng")
                        ThongBao("Xóa trả nợ của khách hàng " + Ten + " thành công");
                    else ThongBao("Xóa trả nợ nhà phân phối " + Ten + " thành công");
                    HienThiDanhSachTraNo();
                }
            }
        }

        private void btnSN_DanhSachKhachHang_TaiLai_Click(object sender, EventArgs e)
        {
            HienThiSoNo_DanhSachKhachHang();
        }

        private void btnSoNo_SoNo_Sua_Click(object sender, EventArgs e)
        {
            if (dgdSN_SoNo_DanhSachTraNo.CurrentRow != null)
            {
                frmSuaTraNo SuaTraNo = new frmSuaTraNo(this, dgdSN_SoNo_DanhSachTraNo.CurrentRow.Cells["Mã hóa đơn"].Value.ToString(), dgdSN_SoNo_DanhSachTraNo.CurrentRow.Cells["Loại"].Value.ToString());
                SuaTraNo.Show();
            }
            else MessageBox.Show("Bạn phải chọn một hóa đơn trước khi sửa");
        }

        private void tabNhapHang_Enter(object sender, EventArgs e)
        {
            if (TaiLaiNhapHang == true)
            {
                HienThiDanhSachHoaDonNhapHang();
            }
        }

        private void tabNhaPP_Enter(object sender, EventArgs e)
        {
            if (TaiLaiNhaPP==true)
            {
                HienThiDanhSachNhaPP();
            }
        }

        private void tabKhachHang_Enter(object sender, EventArgs e)
        {
            if (TaiLaiKhachHang==true)
            {
                HienThiDanhSachKhachHang();
            }
        }

        private void tabSanPham_Enter(object sender, EventArgs e)
        {
            if (TaiLaiSanPham==true)
            {
                HienThiDanhSachSanPham();
            }
        }

        private void tabSoNo_LichSuNoCuaKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void tabSoNo_LichSuNoCuaKhachHang_Enter(object sender, EventArgs e)
        {
           
        }

        private void danhSachKhachHangBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
