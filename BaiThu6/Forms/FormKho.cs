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
    public partial class FormKho : Form
    {
        public FormKho()
        {
            InitializeComponent();
            dgvKho.EnableHeadersVisualStyles = false;
        }

        public void LoadUser()
        {
            label1.Text = "Chức vụ: " + UserLoginCache.ChucVu;
        }
        private void FormKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phoneUwUDataSet2.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.phoneUwUDataSet2.Kho);
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

        private void btThem_Click(object sender, EventArgs e)
        {
            khoBindingSource.AddNew();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa dòng dữ liệu này không?", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                khoBindingSource.RemoveCurrent();
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            int i = khoTableAdapter.Update(phoneUwUDataSet2.Kho);
            MessageBox.Show("Đã hoàn thành việc lưu mới " + i + " dòng dữ liệu ", "Lưu mới dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
