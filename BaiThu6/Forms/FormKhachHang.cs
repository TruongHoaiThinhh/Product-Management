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
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
            dgvKhachHang.EnableHeadersVisualStyles = false;
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phoneUwUDataSet2.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.phoneUwUDataSet2.KhachHang);

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            new FormThemKH().ShowDialog();
            this.khachHangTableAdapter.Fill(this.phoneUwUDataSet2.KhachHang);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            FormThemKH frm = new FormThemKH();
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                frm.txtMaKH.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
                frm.txtTenKH.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
                frm.txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
                frm.txtSTK.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
                frm.txtDT1.Text = dgvKhachHang.CurrentRow.Cells[4].Value.ToString();
                frm.txtEmail.Text = dgvKhachHang.CurrentRow.Cells[5].Value.ToString();
                frm.txtMota.Text = dgvKhachHang.CurrentRow.Cells[6].Value.ToString();
                frm.ShowDialog();
                this.khachHangTableAdapter.Fill(this.phoneUwUDataSet2.KhachHang);

            }
        }

        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormThemKH frm = new FormThemKH();
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                frm.txtMaKH.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
                frm.txtTenKH.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
                frm.txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
                frm.txtSTK.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
                frm.txtDT1.Text = dgvKhachHang.CurrentRow.Cells[4].Value.ToString();
                frm.txtEmail.Text = dgvKhachHang.CurrentRow.Cells[5].Value.ToString();
                frm.txtMota.Text = dgvKhachHang.CurrentRow.Cells[6].Value.ToString();
                frm.ShowDialog();
                this.khachHangTableAdapter.Fill(this.phoneUwUDataSet2.KhachHang);

            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa dòng dữ liệu này không?", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                khachHangBindingSource.RemoveCurrent();
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            int i = khachHangTableAdapter.Update(phoneUwUDataSet2.KhachHang);
            MessageBox.Show("Đã hoàn thành việc lưu mới " + i + " dòng dữ liệu ", "Lưu mới dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
