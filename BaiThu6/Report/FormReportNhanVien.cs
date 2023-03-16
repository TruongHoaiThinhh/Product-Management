using BaiThu6.Model;
using BaiThu6.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace BaiThu6.Report
{
    public partial class FormReportNhanVien : Form
    {
        public FormReportNhanVien()
        {
            InitializeComponent();
        }

        private void FormReportNhanVien_Load(object sender, EventArgs e)
        {
            PhoneContext context = new PhoneContext();
            List<NhanVien> listNhanVien = context.NhanViens.ToList();
            List<NhanVienReport> listReport = new List<NhanVienReport>();
            foreach (NhanVien nhanvien in listNhanVien)
            {
                NhanVienReport NhanVienReport = new NhanVienReport();
                NhanVienReport.MaNV = nhanvien.MaNV;
                NhanVienReport.HoTen = nhanvien.HoTen;
                NhanVienReport.ChucVu = nhanvien.ChucVu;
                NhanVienReport.DiaChi = nhanvien.DiaChi;
                NhanVienReport.Sdt = nhanvien.SDT;
                NhanVienReport.Luong = (double)nhanvien.Luong;
                NhanVienReport.Email = nhanvien.Email;
                listReport.Add(NhanVienReport);
            }

            reportViewer1.LocalReport.ReportPath = "rptNhanVien.rdlc";

            var source = new ReportDataSource("NhanVienDataSet", listReport);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);

            this.reportViewer1.RefreshReport();
        }
    }
}
