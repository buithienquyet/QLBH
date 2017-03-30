using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using Dapper;
using System.Data;
using System.ComponentModel;
using System.Drawing;


namespace PMQLBH
{
    public static class QLBH
    {
        public static SQLiteConnection con = new SQLiteConnection("Data Source = Database\\Database.db; Version=3;foreign keys=true;");

        public static DataSet DataSetDanhSach = new DataSet();

        //public static BindingList<string> DanhSachKhachHang = new BindingList<string>();

        //public static BindingList<string> DanhSachNhaPhanPhoi = new BindingList<string>();

        //public static BindingList<string> DanhSachSanPham = new BindingList<string>();

        //public static BindingList<string> DanhSachMaSanPham = new BindingList<string>();

        //public static BindingList<string> DanhSachXeCho = new BindingList<string>();

        public static Color DoNhat = Color.FromArgb(245, 69, 69);

        public static Color XanhNhat = Color.FromArgb(171, 245, 174);

        public static string GetTimeNow()
        {
            DateTime datetime = DateTime.Now;
            return datetime.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static void ChuanHoaXau(ref string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '\'')
                {
                    s = s.Insert(i, "'");
                    i++;
                }
            }
        }

        public static string ChuanHoaXau(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '\'')
                {
                    s = s.Insert(i, "'");
                    i++;
                }
            }
            return s;
        }

        public static bool TonTaiKhachHang(string tenKhachHang)
        {
            ChuanHoaXau(ref tenKhachHang);
            if (con.QueryFirst<int>(string.Format("select count(*) from khach_hang where ten='{0}'", tenKhachHang)) > 0)
                return true;
            else return false;
        }

        public static bool TonTaiXeCho(string tenXeCho)
        {
            ChuanHoaXau(ref tenXeCho);
            if (con.QueryFirst<int>(string.Format("select count(*) from khach_hang where ten='{0}' and xe_cho=1", tenXeCho)) > 0)
                return true;
            else return false;
        }

        public static bool TonTaiSanPham(string tenSanPham)
        {
            ChuanHoaXau(ref tenSanPham);
            if (con.QueryFirst<int>(string.Format("select count(*) from san_pham where ten='{0}'", tenSanPham)) > 0)
                return true;
            else return false;
        }

        public static bool TonTaiMaSanPham(string maSanPham)
        {
            ChuanHoaXau(ref maSanPham);
            if (con.QueryFirst<int>(string.Format("select count(*) from san_pham where ma='{0}'", maSanPham)) > 0)
                return true;
            else return false;
        }

        public static bool TonTaiNhaPP(string tenNhaPP)
        {
            ChuanHoaXau(ref tenNhaPP);
            if (con.QueryFirst<int>(string.Format("select count(*) from nha_phan_phoi where ten='{0}'", tenNhaPP)) > 0)
                return true;
            else return false;
        }

        public static string[] LayDanhSachSanPham()
        {
            return con.Query<string>("select ten from san_pham order by ten asc").ToArray();
        }

        public static string[] LayDanhSachMaSanPham()
        {
            return con.Query<string>("select ma from san_pham order by ma asc").ToArray();
        }

        public static string[] LayDanhSachNhaPP()
        {
            return con.Query<string>("select ten from nha_phan_phoi order by ten asc").ToArray();
        }

        public static string[] LayDanhSachKhachHang()
        {
            return con.Query<string>("select ten from khach_hang order by ten asc").ToArray();
        }

        public static string[] LayDanhSachXeCho()
        {
            return con.Query<string>("select ten from khach_hang where xe_cho=1 order by ten asc").ToArray();
        }

        public static string LayGiaTuTenSanPham(string tenSanPham)
        {
            ChuanHoaXau(ref tenSanPham);
            return con.QueryFirst<string>(string.Format("select gia from san_pham where ten='{0}'", tenSanPham));
        }

        public static bool KhachHangLaXeCho(string idKhachHang)
        {
            if (con.QueryFirst<int>("select xe_cho from khach_hang where id=" + idKhachHang) == 1)
                return true;
            else return false;
        }

        public static ulong LayNoCuaKhachHang(string idKhachHang) //Không âm
        {
            ulong No = con.QueryFirst<ulong>("select ifnull(sum(case when thanh_tien>thanh_toan then thanh_tien - thanh_toan else 0 end), 0) from hoa_don_ban where id_khach_hang =" + idKhachHang);
            ulong CongCho = con.QueryFirst<ulong>("select ifnull(sum(tien_cho),0) from cong_cho where id_xe_cho=" + idKhachHang);
            ulong TraNo = con.QueryFirst<ulong>("select ifnull(sum(tien_tra),0) from khach_hang_tra_no where id_khach_hang=" + idKhachHang);
            if (No > (CongCho + TraNo))
                return (No - CongCho - TraNo);
            else return 0;
        }

        public static ulong LayNoNhaPhanPhoi(string idNhaPP) //Không âm
        {
            ulong No = con.QueryFirst<ulong>(string.Format("select ifnull(sum(thanh_tien - thanh_toan), 0) from hoa_don_nhap where thanh_tien>thanh_toan and id_nha_phan_phoi={0}", idNhaPP));
            ulong TraNo = con.QueryFirst<ulong>(string.Format("select ifnull(sum(tien_tra),0) from tra_no_nha_phan_phoi where id_nha_phan_phoi={0}", idNhaPP));
            return No - TraNo;
        }

        public static long LayNoCuaKhachHangTinhDenThoiDiemTruThoiDiemDoKhongAm(string idKhachHang, string thoiGian) //Không âm, không tính thời điểm đó
        {
            long No = con.QueryFirst<long>(string.Format("select ifnull(sum(thanh_tien - thanh_toan), 0) from hoa_don_ban where thanh_tien>thanh_toan and id_khach_hang ={0} and tg_tao<'{1}'", idKhachHang, thoiGian));
            long CongCho = con.QueryFirst<long>(string.Format("select ifnull(sum(cong_cho.tien_cho),0) from cong_cho left join hoa_don_ban on cong_cho.id_hoa_don_ban=hoa_don_ban.id where id_xe_cho={0} and hoa_don_ban.tg_tao<'{1}'", idKhachHang, thoiGian));
            long TraNo = con.QueryFirst<long>(string.Format("select ifnull(sum(tien_tra),0) from khach_hang_tra_no where id_khach_hang={0} and tg_tao<'{1}'", idKhachHang, thoiGian));
            if (No > (CongCho + TraNo))
                return No - CongCho - TraNo;
            else return 0;
        }

        public static long LayNoCuaKhachHangTinhDenThoiDiemCoAm(string idKhachHang, string thoiGian) //Có thể âm, tính cả thời điểm đó
        {
            long No = con.QueryFirst<long>(string.Format("select ifnull(sum(thanh_tien - thanh_toan), 0) from hoa_don_ban where thanh_tien>thanh_toan and id_khach_hang ={0} and tg_tao<='{1}'", idKhachHang, thoiGian));
            long CongCho = con.QueryFirst<long>(string.Format("select ifnull(sum(cong_cho.tien_cho),0) from cong_cho left join hoa_don_ban on cong_cho.id_hoa_don_ban=hoa_don_ban.id where id_xe_cho={0} and hoa_don_ban.tg_tao<='{1}'", idKhachHang, thoiGian));
            long TraNo = con.QueryFirst<long>(string.Format("select ifnull(sum(tien_tra),0) from khach_hang_tra_no where id_khach_hang={0} and tg_tao<='{1}'", idKhachHang, thoiGian));
            return (No - CongCho - TraNo);
        }

        public static long LayNoNhaPPTinhDenThoiDiemTruThoiDiemDo(string idNhaPP, string thoiDiem) //không tính thời điểm đó
        {
            long No = con.QueryFirst<long>(string.Format("select ifnull(sum(thanh_tien - thanh_toan), 0) from hoa_don_nhap where thanh_tien>thanh_toan and id_nha_phan_phoi ={0} and tg_tao<'{1}'", idNhaPP, thoiDiem));
            long TraNo = con.QueryFirst<long>(string.Format("select ifnull(sum(tien_tra),0) from tra_no_nha_phan_phoi where id_nha_phan_phoi={0} and tg_tao<'{1}'", idNhaPP, thoiDiem));
            return No - TraNo;
        }

        public static string LayDonViTinhTuTenSanPham(string tenSanPham)
        {
            ChuanHoaXau(ref tenSanPham);
            return con.QueryFirst<string>(string.Format("select don_vi_tinh from san_pham where ten='{0}'", tenSanPham));
        }

        public static string LayTenSanPhamTuMaSanPham(string maSanPham)
        {
            ChuanHoaXau(ref maSanPham);
            return con.QueryFirst<string>(string.Format("select ten from san_pham where ma='{0}'", maSanPham));
        }

        public static string LayTenSanPhamTuId(string idSanPham)
        {
            return con.QueryFirst<string>(string.Format("select ten from san_pham where id={0}", idSanPham));
        }

        public static string LayDonViTinhSanPhamTuId(string idSanPham)
        {
            return con.QueryFirst<string>(string.Format("select don_vi_tinh from san_pham where id={0}", idSanPham));
        }

        public static string LayGhiChuSanPhamTuId(string idSanPham)
        {
            return con.QueryFirst<string>(string.Format("select ghi_chu from san_pham where id={0}", idSanPham));
        }

        public static string LayIdTuTenSanPham(string tenSanPham)
        {
            ChuanHoaXau(ref tenSanPham);
            return con.QueryFirst<string>(string.Format("select id from san_pham where ten='{0}'", tenSanPham));
        }

        public static string LayMaSanPhamTuTenSanPham(string tenSanPham)
        {
            ChuanHoaXau(ref tenSanPham);
            return con.QueryFirst<string>(string.Format("select ma from san_pham where ten='{0}'", tenSanPham));
        }

        public static string LayMaSanPhamTuIdSanPham(string idSanPham)
        {
            return con.QueryFirst<string>(string.Format("select ma from san_pham where id={0}", idSanPham));
        }

        public static ulong LayGiaSanPhamTuTenSanPham(string tenSanPham)
        {
            ChuanHoaXau(ref tenSanPham);
            return con.QueryFirst<ulong>(string.Format("select gia from san_pham where ten='{0}'", tenSanPham));
        }

        public static string LayIdNhaPhanPhoiTuTenNPP(string tenNhaPhanPhoi)
        {
            ChuanHoaXau(ref tenNhaPhanPhoi);
            return con.QueryFirst<string>(string.Format("select id from nha_phan_phoi where ten='{0}'", tenNhaPhanPhoi));
        }

        public static string LayIdKhachHangTuTenKhachHang(string tenKhachHang)
        {
            ChuanHoaXau(ref tenKhachHang);
            return con.QueryFirst<string>(string.Format("select id from khach_hang where ten='{0}'", tenKhachHang));
        }

        public static string LayIdKhachHangTuIdHoaDonBan(string idHoaDonBan)
        {
            return con.QueryFirst<string>("select id_khach_hang from hoa_don_ban where id=" + idHoaDonBan);
        }

        public static double LaySoLuongBanCuaSanPham(string idSanPham)
        {
            return con.QueryFirst<double>(string.Format("select ifnull(sum(so_luong),0) from san_pham_da_ban where id_san_pham={0}", idSanPham));
        }

        public static double LaySoLuongHienCoCuaSanPham(string idSanPham)
        {
            return con.QueryFirst<double>("select so_luong_ban_dau + ifnull((select sum(so_luong + so_luong_km) from san_pham_da_nhap where id_san_pham = san_pham.id),0) -ifnull((select sum(so_luong) from san_pham_da_ban where id_san_pham = san_pham.id),0) from san_pham where id=" + idSanPham);
        }

        public static double LaySoLuongHienCoCuaSanPhamNhungKhongTinhHoaDonNhap(string idSanPham, string idHoaDonNhap)
        {
            return con.QueryFirst<double>(string.Format("select so_luong_ban_dau + ifnull((select sum(so_luong + so_luong_km) from san_pham_da_nhap where id_san_pham = san_pham.id and id_hoa_don_nhap!={0}),0) -ifnull((select sum(so_luong) from san_pham_da_ban where id_san_pham = san_pham.id),0) from san_pham where id={1}", idHoaDonNhap, idSanPham));
        }

        public static double LaySoLuongHienCoCuaSanPhamNhungKhongTinhHoaDonBan(string idSanPham, string idHoaDonBan)
        {
            return con.QueryFirst<double>(string.Format("select so_luong_ban_dau + ifnull((select sum(so_luong + so_luong_km) from san_pham_da_nhap where id_san_pham = san_pham.id),0) -ifnull((select sum(so_luong) from san_pham_da_ban where id_san_pham = san_pham.id and id_hoa_don_ban !={0}),0) from san_pham where id={1}", idHoaDonBan, idSanPham));
        }

        public static string LayTenNhaPPTuIdHoaDonNhap(string idHoaDonNhap)
        {
            return con.QueryFirst<string>("select (select ten from nha_phan_phoi where id=hoa_don_nhap.id_nha_phan_phoi) from hoa_don_nhap where id=" + idHoaDonNhap);
        }

        public static string LayTenKhachHangTuIdHoaDonBan(string idHoaDonBan)
        {
            return con.QueryFirst<string>("select (select ten from khach_hang where id=hoa_don_ban.id_khach_hang) from hoa_don_ban where id=" + idHoaDonBan);
        }

        public static string LayGhiChuTuIdHoaDonNhap(string idHoaDonNhap)
        {
            return con.QueryFirst<string>("select ghi_chu from hoa_don_nhap where id=" + idHoaDonNhap);
        }

        public static string LayGhiChuTuIdHoaDonBan(string idHoaDonBan)
        {
            return con.QueryFirst<string>("select ghi_chu from hoa_don_ban where id=" + idHoaDonBan);
        }

        public static bool CoXeCho(string idHoaDonBan)
        {
            if (con.QueryFirst<int>("select count(*) from cong_cho where id_hoa_don_ban=" + idHoaDonBan) > 0)
                return true;
            else return false;
        }

        public static string LayXeChoTuIdHoaDonBan(string idHoaDonBan)
        {
            return con.QueryFirst<string>("select (select ten from khach_hang where id=cong_cho.id_xe_cho) from cong_cho where id_hoa_don_ban=" + idHoaDonBan);
        }

        public static ulong LayCongChoTuIdHoaDonBan(string idHoaDonBan)
        {
            return con.QueryFirst<ulong>("select tien_cho from cong_cho where id_hoa_don_ban=" + idHoaDonBan);
        }

        public static ulong LayThanhTienTuIdHoaDonNhap(string idHoaDonNhap)
        {
            return con.QueryFirst<ulong>("select thanh_tien from hoa_don_nhap where id=" + idHoaDonNhap);
        }

        public static ulong LayThanhTienTuIdHoaDonBan(string idHoaDonBan)
        {
            return con.QueryFirst<ulong>("select thanh_tien from hoa_don_ban where id=" + idHoaDonBan);
        }

        public static ulong LayThanhToanTuIdHoaDonNhap(string idHoaDonNhap)
        {
            return con.QueryFirst<ulong>("select thanh_toan from hoa_don_nhap where id=" + idHoaDonNhap);
        }

        public static ulong LayThanhToanTuIdHoaDonBan(string idHoaDonBan)
        {
            return con.QueryFirst<ulong>("select thanh_toan from hoa_don_ban where id=" + idHoaDonBan);
        }

        public static string LayThoiDiemTuIdHoaDonBan(string idHoaDonBan)
        {
            return con.QueryFirst<string>("select tg_tao from hoa_don_ban where id=" + idHoaDonBan);
        }

        public static string LayThoiDiemTuIdHoaDonTraNo(string idHoaDonTraNo, bool laKhachHang)
        {
            if (laKhachHang)
                return con.QueryFirst<string>("select tg_tao from khach_hang_tra_no where id=" + idHoaDonTraNo);
            else return con.QueryFirst<string>("select tg_tao from tra_no_nha_phan_phoi where id=" + idHoaDonTraNo);
        }

        public static string LayTenKhachHang_NhaPPTuIdHoaDonTraNo(string idHoaDonTraNo, bool laKhachHang)
        {
            if (laKhachHang)
                return con.QueryFirst<string>("select (select ten from khach_hang where id=khach_hang_tra_no.id_khach_hang) from khach_hang_tra_no where id=" + idHoaDonTraNo);
            else return con.QueryFirst<string>("select (select ten from nha_phan_phoi where id=tra_no_nha_phan_phoi.id_nha_phan_phoi) from tra_no_nha_phan_phoi where id=" + idHoaDonTraNo);
        }

        public static string LayIdKhachHang_NhaPPTuIdHoaDonTraNo(string idHoaDonTraNo, bool laKhachHang)
        {
            if (laKhachHang)
                return con.QueryFirst<string>("select id_khach_hang from khach_hang_tra_no where id=" + idHoaDonTraNo);
            else return con.QueryFirst<string>("select id_nha_phan_phoi from tra_no_nha_phan_phoi where id=" + idHoaDonTraNo);
        }

        public static long LaySoTienTuIdHoaDonTraNo(string idHoaDonTraNo, bool laKhachHang)
        {
            if (laKhachHang)
                return con.QueryFirst<long>("select tien_tra from khach_hang_tra_no where id=" + idHoaDonTraNo);
            else return con.QueryFirst<long>("select tien_tra from tra_no_nha_phan_phoi where id=" + idHoaDonTraNo);
        }

        public static DataTable LayDanhSachSanPhamTuIdHoaDonNhap(string idHoaDonNhap)
        {
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("select san_pham.ten as [Sản phẩm], san_pham_da_nhap.so_luong as [Số lượng], san_pham_da_nhap.so_luong_km as [Số lượng KM], san_pham_da_nhap.gia as [Giá], san_pham.don_vi_tinh as [Đơn vị tính], round(san_pham_da_nhap.so_luong * san_pham_da_nhap.gia) as [Thành tiền] from san_pham_da_nhap left join san_pham on san_pham_da_nhap.id_san_pham = san_pham.id where san_pham_da_nhap.id_hoa_don_nhap=" + idHoaDonNhap, con);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            return datatable;
        }

        public static DataTable LayDanhSachSanPhamTuIdHoaDonBan(string idHoaDonBan)
        {
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("select san_pham.ten as [Sản phẩm], san_pham_da_ban.so_luong as [Số lượng], san_pham_da_ban.gia as [Giá], san_pham.don_vi_tinh as [Đơn vị tính], san_pham_da_ban.so_luong * san_pham_da_ban.gia as [Thành tiền] from san_pham_da_ban left join san_pham on san_pham_da_ban.id_san_pham = san_pham.id where san_pham_da_ban.id_hoa_don_ban=" + idHoaDonBan, con);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            return datatable;
        }

        public static void CapNhatDanhSachKhachHang()
        {
            SQLiteDataAdapter abc = new SQLiteDataAdapter("select ten from khach_hang", con);
            DataSetDanhSach.Tables["DanhSachKhachHang"].Clear();
            abc.Fill(DataSetDanhSach, "DanhSachKhachHang");
        }

        public static void InitDataSetDanhSach()
        {
            DataSetDanhSach.Tables.Add("DanhSachKhachHang");
            DataSetDanhSach.Tables["DanhSachKhachHang"].Columns.Add("ten", typeof(string));
            DataSetDanhSach.Tables.Add("DanhSachNhaPP");
            DataSetDanhSach.Tables["DanhSachNhaPP"].Columns.Add("ten", typeof(string));
            DataSetDanhSach.Tables.Add("DanhSachSanPham");
            DataSetDanhSach.Tables["DanhSachSanPham"].Columns.Add("ten", typeof(string));
            DataSetDanhSach.Tables["DanhSachSanPham"].Columns.Add("ma", typeof(string));
            DataSetDanhSach.Tables.Add("DanhSachXeCho");
            DataSetDanhSach.Tables["DanhSachXeCho"].Columns.Add("ten", typeof(string));
        }

        public static void CapNhatDanhSachNhaPhanPhoi()
        {
            SQLiteDataAdapter abc = new SQLiteDataAdapter("select ten from nha_phan_phoi", con);
            DataSetDanhSach.Tables["DanhSachNhaPP"].Clear();
            abc.Fill(DataSetDanhSach, "DanhSachNhaPP");
        }

        public static void CapNhatDanhSachSanPham()
        {
            SQLiteDataAdapter abc = new SQLiteDataAdapter("select ten,ma from san_pham", con);
            DataSetDanhSach.Tables["DanhSachSanPham"].Rows.Clear();
            abc.Fill(DataSetDanhSach, "DanhSachSanPham");
        }

        public static void CapNhatDanhSachXeCho()
        {
            SQLiteDataAdapter abc = new SQLiteDataAdapter("select ten from khach_hang where xe_cho=1", con);
            DataSetDanhSach.Tables["DanhSachXeCho"].Clear();
            abc.Fill(DataSetDanhSach, "DanhSachXeCho");
        }

        public static bool AppTonTaiKhachHang(string tenKhachHang)
        {
            for (int i = 0; i < QLBH.DataSetDanhSach.Tables["DanhSachKhachHang"].Rows.Count; i++)
            {
                if ((string)QLBH.DataSetDanhSach.Tables["DanhSachKhachHang"].Rows[i]["ten"] == tenKhachHang)
                    return true;
            }
            return false;
        }

        public static bool AppTonTaiSanPham(string tenSanPham)
        {
            for (int i = 0; i < QLBH.DataSetDanhSach.Tables["DanhSachSanPham"].Rows.Count; i++)
            {
                if ((string)QLBH.DataSetDanhSach.Tables["DanhSachSanPham"].Rows[i]["ten"] == tenSanPham)
                    return true;
            }
            return false;
        }

        public static bool AppTonTaiMaSanPham(string maSanPham)
        {
            for (int i = 0; i < QLBH.DataSetDanhSach.Tables["DanhSachSanPham"].Rows.Count; i++)
            {
                if ((string)QLBH.DataSetDanhSach.Tables["DanhSachSanPham"].Rows[i]["ma"] == maSanPham)
                    return true;
            }
            return false;
        }

        public static bool AppTonTaiXeCho(string tenXeCho)
        {
            for (int i = 0; i < QLBH.DataSetDanhSach.Tables["DanhSachXeCho"].Rows.Count; i++)
            {
                if ((string)QLBH.DataSetDanhSach.Tables["DanhSachXeCho"].Rows[i]["ten"] == tenXeCho)
                    return true;
            }
            return false;
        }
    }
}
