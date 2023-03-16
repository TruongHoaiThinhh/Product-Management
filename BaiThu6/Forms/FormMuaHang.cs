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
    public partial class FormMuaHang : Form
    {
        public FormMuaHang()
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

        private void muahangMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormPhieuMuaHang(), sender);
        }

        private void nccMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDSPhieuMuaHang(), sender);
        }

        public void LoadUser()
        {
            label1.Text = "Chức vụ: " + UserLoginCache.ChucVu;
        }
        private void FormMuaHang_Load(object sender, EventArgs e)
        {
            LoadUser();
            if (label1.Text == "Chức vụ: Nhân Viên")
            {
                muahangMenu.Enabled = false;
                nccMenu.Enabled = false;
            }
        }
    }
}
