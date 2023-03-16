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
    public partial class FormNhomSanPham : Form
    {

        public FormNhomSanPham()
        {

            InitializeComponent();
            dgvNhomSanPham.EnableHeadersVisualStyles = false;
        }


        private void btThem_Click(object sender, EventArgs e)
        {
            nhomSPBindingSource.AddNew();
        }

        private void btSua_Click(object sender, EventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xóa dòng dữ liệu này không?", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                nhomSPBindingSource.RemoveCurrent();
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            int i = nhomSPTableAdapter.Update(phoneUwUDataSet1.NhomSP);
            MessageBox.Show("Đã hoàn thành việc lưu mới " + i + " dòng dữ liệu ", "Lưu mới dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        public void LoadUser()
        {
            label1.Text = "Chức vụ: " + UserLoginCache.ChucVu;
        }
        private void FormNhomSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phoneUwUDataSet1.NhomSP' table. You can move, or remove it, as needed.
            this.nhomSPTableAdapter.Fill(this.phoneUwUDataSet1.NhomSP);
            LoadUser();
            if (label1.Text == "Chức vụ: Nhân Viên")
            {
                btThem.Enabled = false;
                btThem.BackColor = Color.FromArgb(170, 170, 170);
                btLuu.Enabled = false;
                btLuu.BackColor = Color.FromArgb(170, 170, 170);
                btXoa.Enabled = false;
                btXoa.BackColor = Color.FromArgb(170, 170, 170);
            }

        }
    }
}
