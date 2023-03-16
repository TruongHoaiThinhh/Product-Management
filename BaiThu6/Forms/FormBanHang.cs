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
    public partial class FormBanHang : Form
    {
        public FormBanHang()
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

        private void banhangMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHoaDon(), sender);
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {

        }

        private void dsbanhangMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDSHoaDon(), sender);
        }
    }
}
