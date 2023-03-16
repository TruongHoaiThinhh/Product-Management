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
    public partial class FormNCC : Form
    {
        public FormNCC()
        {
            InitializeComponent();
            dgvNCC.EnableHeadersVisualStyles = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormNCC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phoneUwUDataSet2.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter.Fill(this.phoneUwUDataSet2.NhaCungCap);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            new FormThemNCC().ShowDialog();
            this.nhaCungCapTableAdapter.Fill(this.phoneUwUDataSet2.NhaCungCap);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            FormThemNCC frm = new FormThemNCC();
            if (dgvNCC.SelectedRows.Count > 0)
            {
                frm.txtMaNCC.Text = dgvNCC.CurrentRow.Cells[0].Value.ToString();
                frm.txtTenNCC.Text = dgvNCC.CurrentRow.Cells[1].Value.ToString();
                frm.txtDiaChi.Text = dgvNCC.CurrentRow.Cells[2].Value.ToString();
                frm.txtSTK.Text = dgvNCC.CurrentRow.Cells[3].Value.ToString();
                frm.txtDT1.Text = dgvNCC.CurrentRow.Cells[4].Value.ToString();
                frm.txtDT2.Text = dgvNCC.CurrentRow.Cells[5].Value.ToString();
                frm.txtEmail.Text = dgvNCC.CurrentRow.Cells[6].Value.ToString();
                frm.txtWeb.Text = dgvNCC.CurrentRow.Cells[7].Value.ToString();
                frm.txtMota.Text = dgvNCC.CurrentRow.Cells[8].Value.ToString();
                frm.ShowDialog();
                this.nhaCungCapTableAdapter.Fill(this.phoneUwUDataSet2.NhaCungCap);

            }
        }

        private void dgvNCC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormThemNCC frm = new FormThemNCC();
            if (dgvNCC.SelectedRows.Count > 0)
            {
                frm.txtMaNCC.Text = dgvNCC.CurrentRow.Cells[0].Value.ToString();
                frm.txtTenNCC.Text = dgvNCC.CurrentRow.Cells[1].Value.ToString();
                frm.txtDiaChi.Text = dgvNCC.CurrentRow.Cells[2].Value.ToString();
                frm.txtSTK.Text = dgvNCC.CurrentRow.Cells[3].Value.ToString();
                frm.txtDT1.Text = dgvNCC.CurrentRow.Cells[4].Value.ToString();
                frm.txtDT2.Text = dgvNCC.CurrentRow.Cells[5].Value.ToString();
                frm.txtEmail.Text = dgvNCC.CurrentRow.Cells[6].Value.ToString();
                frm.txtWeb.Text = dgvNCC.CurrentRow.Cells[7].Value.ToString();
                frm.txtMota.Text = dgvNCC.CurrentRow.Cells[8].Value.ToString();
                frm.ShowDialog();
                this.nhaCungCapTableAdapter.Fill(this.phoneUwUDataSet2.NhaCungCap);

            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xóa dòng dữ liệu này không?", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                nhaCungCapBindingSource.RemoveCurrent();
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            int i = nhaCungCapTableAdapter.Update(phoneUwUDataSet2.NhaCungCap);
            MessageBox.Show("Đã hoàn thành việc lưu mới " + i + " dòng dữ liệu ", "Lưu mới dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
