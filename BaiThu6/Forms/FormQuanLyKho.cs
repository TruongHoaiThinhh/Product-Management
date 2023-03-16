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
    public partial class FormQuanLyKho : Form
    {
        public FormQuanLyKho()
        {
            InitializeComponent();
        }

        private Form activeForm;

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelManHinh.Controls.Add(childForm);
            this.panelManHinh.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void phiếuNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormPhieuNhap(), sender);
        }

        private void danhSáchPhiếuNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDSPhieuNhap(), sender);
        }

        private void phiếuXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormPhieuXuat(), sender);
        }

        private void danhSáchPhiếuXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDSPhieuXuat(), sender);
        }

        public void LoadUser()
        {
            label1.Text = "Chức vụ: " + UserLoginCache.ChucVu;
        }
        private void FormQuanLyKho_Load(object sender, EventArgs e)
        {
            LoadUser();
            if (label1.Text == "Chức vụ: Nhân Viên")
            {
                phiếuNhậpKhoToolStripMenuItem.Enabled = false;
                phiếuXuấtKhoToolStripMenuItem.Enabled = false;
                danhSáchPhiếuNhậpKhoToolStripMenuItem.Enabled = false;
                danhSáchPhiếuXuấtKhoToolStripMenuItem.Enabled = false;
            }
        }

    }
}
