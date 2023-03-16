using BaiThu6.Report;
using Common.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThu6.Forms
{
    public partial class FormBaoCaoThongKe : Form
    {
        public FormBaoCaoThongKe()
        {
            InitializeComponent();
        }

        public void LoadUser()
        {
            label1.Text = "Chức vụ: " + UserLoginCache.ChucVu;
        }
        private void nhanvienReport_Click(object sender, EventArgs e)
        {
            new FormReportNhanVien().ShowDialog();
        }

        private void nhomspMenu_Click(object sender, EventArgs e)
        {
            new FormReportSanPham().ShowDialog();
        }

        private void loaispMenu_Click(object sender, EventArgs e)
        {
            new FormReportDoanhThu().ShowDialog();
        }

        private void FormBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            LoadUser();
            if (label1.Text == "Chức vụ: Nhân Viên" || label1.Text == "Chức vụ: Quản Lý")
            {
                nhomspMenu.Enabled = false;
                loaispMenu.Enabled = false;
                nhanvienReport.Enabled = false;
            }
        }
    }
}
