using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;
using Dapper;

namespace PMQLBH
{
    public partial class frmInHoaDonBan : Form
    {
        string IdHoaDon;
        public frmInHoaDonBan(string idHoaDon)
        {
            InitializeComponent();
            IdHoaDon = idHoaDon;
            HienBaoCao();
        }
        private void frmInHoaDonBan_Load(object sender, EventArgs e)
        {
            //this.reportViewerHoaDonBan.RefreshReport();
        }
        void HienHoiThoaiIn(object sender, RenderingCompleteEventArgs e)
        {
            reportViewerHoaDonBan.PrintDialog();
        }
        string No()
        {
            string IdKhachHang = QLBH.LayIdKhachHangTuIdHoaDonBan(IdHoaDon);
            string ThoiGian = QLBH.LayThoiDiemTuIdHoaDonBan(IdHoaDon);
            return QLBH.LayNoCuaKhachHangTinhDenThoiDiemTruThoiDiemDoKhongAm(IdKhachHang, ThoiGian).ToString();
        }
        void HienBaoCao()
        {
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("select san_pham.ten as [colTen], san_pham_da_ban.so_luong as [colSoLuong], san_pham_da_ban.gia as [colGia], san_pham.don_vi_tinh as [colDonViTinh], san_pham_da_ban.so_luong * san_pham_da_ban.gia as [colThanhTien] from san_pham_da_ban left join san_pham on san_pham_da_ban.id_san_pham = san_pham.id where san_pham_da_ban.id_hoa_don_ban=" + IdHoaDon, QLBH.con);
            DataTable datatable = new DataTable();
            datatable.Columns.Add("colSTT",typeof(string));
            dataadapter.Fill(datatable);
            for (int i = 0; i < datatable.Rows.Count; i++)
                datatable.Rows[i]["colSTT"] = (i + 1).ToString();
            reportViewerHoaDonBan.Clear();
            reportViewerHoaDonBan.LocalReport.ReportEmbeddedResource = "PMQLBH.HoaDonBan.rdlc";
            reportViewerHoaDonBan.LocalReport.DataSources.Clear();
            reportViewerHoaDonBan.LocalReport.DataSources.Add(new ReportDataSource("DanhSachSanPham", datatable));
            reportViewerHoaDonBan.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewerHoaDonBan.ZoomMode = ZoomMode.Percent;
            reportViewerHoaDonBan.ZoomPercent = 100;
            PageSettings ps = reportViewerHoaDonBan.GetPageSettings();
            ps.Landscape = true;
            reportViewerHoaDonBan.SetPageSettings(ps);
            ReportParameter[] ThamSoReport= new ReportParameter[6];
            ThamSoReport[0] = new ReportParameter("ThanhTien", QLBH.LayThanhTienTuIdHoaDonBan(IdHoaDon).ToString());
            ThamSoReport[1] = new ReportParameter("ThanhToan", QLBH.LayThanhToanTuIdHoaDonBan(IdHoaDon).ToString());
            ThamSoReport[2] = new ReportParameter("NoCu", No());
            ThamSoReport[3] = new ReportParameter("MaHoaDon", IdHoaDon);
            ThamSoReport[4] = new ReportParameter("ThoiGian", QLBH.con.QueryFirst<string>("select strftime('%d-%m-%Y %H:%M:%S',tg_tao) from hoa_don_ban where id=" + IdHoaDon));
            ThamSoReport[5] = new ReportParameter("TenKhachHang", QLBH.LayTenKhachHangTuIdHoaDonBan(IdHoaDon));
            reportViewerHoaDonBan.LocalReport.SetParameters(ThamSoReport);
            reportViewerHoaDonBan.RefreshReport();
            reportViewerHoaDonBan.RenderingComplete += new RenderingCompleteEventHandler(HienHoiThoaiIn);
        }
    }
}
