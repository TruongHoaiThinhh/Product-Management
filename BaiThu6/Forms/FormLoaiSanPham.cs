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
    public partial class FormLoaiSanPham : Form
    {
        public FormLoaiSanPham()
        {
            InitializeComponent();
            dgvLoaiSanPham.EnableHeadersVisualStyles = false;

        }

        public void LoadUser()
        {
            label1.Text = "Chức vụ: " + UserLoginCache.ChucVu;
        }

        private void FormLoaiSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phoneUwUDataSet2.LoaiSP' table. You can move, or remove it, as needed.
            this.loaiSPTableAdapter.Fill(this.phoneUwUDataSet2.LoaiSP);

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

        private void btThem_Click_1(object sender, EventArgs e)
        {
                loaiSPBindingSource2.AddNew();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa dòng dữ liệu này không?","Xóa dữ liệu",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                loaiSPBindingSource2.RemoveCurrent();
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            int i = loaiSPTableAdapter.Update(phoneUwUDataSet2.LoaiSP);
            MessageBox.Show("Đã hoàn thành việc lưu mới " + i + " dòng dữ liệu ", "Lưu mới dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
