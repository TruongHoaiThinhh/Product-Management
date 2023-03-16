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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
            dgvNhanVien.EnableHeadersVisualStyles = false;
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phoneUwUDataSet2.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.phoneUwUDataSet2.NhanVien);

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            nhanVienBindingSource.AddNew();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            int i = nhanVienTableAdapter.Update(phoneUwUDataSet2.NhanVien);
            MessageBox.Show("Đã hoàn thành việc lưu mới " + i + " dòng dữ liệu ", "Lưu mới dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa dòng dữ liệu này không?", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                nhanVienBindingSource.RemoveCurrent();
            }
        }
    }
}
