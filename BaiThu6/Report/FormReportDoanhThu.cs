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
    public partial class FormReportDoanhThu : Form
    {
        public FormReportDoanhThu()
        {
            InitializeComponent();
        }

        private void FormReportDoanhThu_Load(object sender, EventArgs e)
        {
            PhoneContext context = new PhoneContext();
            List<HoaDon> listHoaDon = context.HoaDons.ToList();
            List<DoanhThuReport> listReport = new List<DoanhThuReport>();
            foreach (HoaDon hoadon in listHoaDon)
            {
                DoanhThuReport DoanhThuReport = new DoanhThuReport();
                DoanhThuReport.MaHoaDon = hoadon.MaHoaDon;
                DoanhThuReport.NgayLap = hoadon.NgayLap;
                DoanhThuReport.NgLap = hoadon.NgLap;
                DoanhThuReport.HTTT = hoadon.HTTT;
                DoanhThuReport.TenKH = hoadon.TenKH;
                DoanhThuReport.TongTien = (double)hoadon.TongTien;
                DoanhThuReport.Kho = hoadon.Kho;
                listReport.Add(DoanhThuReport);
            }

            reportViewer1.LocalReport.ReportPath = "rptDoanhThu.rdlc";

            var source = new ReportDataSource("DoanhThuDataSet", listReport);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);

            this.reportViewer1.RefreshReport();
        }
    }
}
