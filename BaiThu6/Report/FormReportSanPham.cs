using BaiThu6.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThu6.Report
{
    public partial class FormReportSanPham : Form
    {
        public FormReportSanPham()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            PhoneContext context = new PhoneContext();
            List<SanPham> listSanPham = context.SanPhams.ToList();
            List<SanPhamReport> listReport = new List<SanPhamReport>();
            foreach (SanPham sanpham in listSanPham)
            {
                SanPhamReport SanPhamReport = new SanPhamReport();
                SanPhamReport.MaSP = sanpham.MaSP;
                SanPhamReport.LoaiSP = sanpham.LoaiSP;
                SanPhamReport.NhomSP = sanpham.NhomSP;
                SanPhamReport.TenSP = sanpham.TenSP;
                SanPhamReport.GiaNhap = (double)sanpham.GiaNhap;
                SanPhamReport.GiaBan = (double)sanpham.GiaBan;
                SanPhamReport.SoLuong = (double)sanpham.SoLuong;
                SanPhamReport.TrangThai = sanpham.TrangThai;
                listReport.Add(SanPhamReport);
            }

            reportViewer1.LocalReport.ReportPath = "rptSanPham.rdlc";

            var source = new ReportDataSource("SanPhamDataSet", listReport);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);

            this.reportViewer1.RefreshReport();
        }
    }
}
