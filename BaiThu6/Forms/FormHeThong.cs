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
    public partial class FormHeThong : Form
    {
        public FormHeThong()
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

        public void LoadUser()
        {
            label1.Text = "Chức vụ: " + UserLoginCache.ChucVu;
        }

        private void doimatkhauMenu_Click(object sender, EventArgs e)
        {
            new FormDoiMatKhau().ShowDialog();
        }

        private void ThoatMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void phânQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormPhanQuyen(), sender);
        }

        private void FormHeThong_LocationChanged(object sender, EventArgs e)
        {

        }

        private void FormHeThong_Load(object sender, EventArgs e)
        {
            LoadUser();
            if (label1.Text == "Chức vụ: Nhân Viên" || label1.Text == "Chức vụ: Quản Lý")
            {
                phânQuyềnToolStripMenuItem.Enabled = false;
            }
        }
    }
}
