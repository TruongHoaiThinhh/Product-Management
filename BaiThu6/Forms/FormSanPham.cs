
using BaiThu6.Model;
using Common.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThu6.Forms
{
    public partial class FormSanPham : Form
    {
        public FormSanPham()
        {
            InitializeComponent();
            dgvDanhSachDT.EnableHeadersVisualStyles = false;

        }
        PhoneContext context = new PhoneContext();
        public void LoadUser()
        {
            label3.Text = "Chức vụ: " + UserLoginCache.ChucVu;
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phoneUwUDataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.phoneUwUDataSet.SanPham);
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dgvDanhSachDT.Columns[13];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
            LoadUser();
            if (label3.Text == "Chức vụ: Nhân Viên")
            {
                btThem.Enabled = false;
                btThem.BackColor = Color.FromArgb(170, 170, 170);
                btSua.Enabled = false;
                btSua.BackColor = Color.FromArgb(170, 170, 170);
                btLuu.Enabled = false;
                btLuu.BackColor = Color.FromArgb(170, 170, 170);
                btXoa.Enabled = false;
                btXoa.BackColor = Color.FromArgb(170, 170, 170);
            }
        }

        private void dgvDanhSachDT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            new FormThemSP().ShowDialog();
            this.sanPhamTableAdapter.Fill(this.phoneUwUDataSet.SanPham);
        }

        private void btSua_Click_1(object sender, EventArgs e)
        {
            FormThemSP frm = new FormThemSP();

            if (dgvDanhSachDT.SelectedRows.Count > 0)
            {
                frm.cmbNhomSP.SelectedItem = dgvDanhSachDT.CurrentRow.Cells[0].Value.ToString();
                frm.cmbLoaiSP.SelectedItem = dgvDanhSachDT.CurrentRow.Cells[1].Value.ToString();
                frm.txtMaSP.Text = dgvDanhSachDT.CurrentRow.Cells[2].Value.ToString();
                frm.txtTenSP.Text = dgvDanhSachDT.CurrentRow.Cells[3].Value.ToString();
                frm.txtKichThuoc.Text = dgvDanhSachDT.CurrentRow.Cells[4].Value.ToString();
                frm.txtMauSac.Text = dgvDanhSachDT.CurrentRow.Cells[5].Value.ToString();
                frm.txtBaoHanh.Text = dgvDanhSachDT.CurrentRow.Cells[6].Value.ToString();
                frm.txtNSX.Text = dgvDanhSachDT.CurrentRow.Cells[7].Value.ToString();
                frm.txtGiaBan.Text = dgvDanhSachDT.CurrentRow.Cells[8].Value.ToString();
                frm.txtGiaNhap.Text = dgvDanhSachDT.CurrentRow.Cells[9].Value.ToString();
                frm.txtSLC.Text = dgvDanhSachDT.CurrentRow.Cells[10].Value.ToString();
                frm.txtTrangThai.Text = dgvDanhSachDT.CurrentRow.Cells[11].Value.ToString();
                frm.txtMota.Text = dgvDanhSachDT.CurrentRow.Cells[12].Value.ToString();
                MemoryStream ms = new MemoryStream((byte[])dgvDanhSachDT.CurrentRow.Cells[13].Value);
                frm.pic1.Image = Image.FromStream(ms);
                frm.ShowDialog();
                this.sanPhamTableAdapter.Fill(this.phoneUwUDataSet.SanPham);

            }
        }

        private void dgvDanhSachDT_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            FormThemSP frm = new FormThemSP();
            if (dgvDanhSachDT.SelectedRows.Count > 0)
            {
                frm.cmbNhomSP.SelectedItem = dgvDanhSachDT.CurrentRow.Cells[0].Value.ToString();
                frm.cmbLoaiSP.SelectedItem = dgvDanhSachDT.CurrentRow.Cells[1].Value.ToString();
                frm.txtMaSP.Text = dgvDanhSachDT.CurrentRow.Cells[2].Value.ToString();
                frm.txtTenSP.Text = dgvDanhSachDT.CurrentRow.Cells[3].Value.ToString();
                frm.txtKichThuoc.Text = dgvDanhSachDT.CurrentRow.Cells[4].Value.ToString();
                frm.txtMauSac.Text = dgvDanhSachDT.CurrentRow.Cells[5].Value.ToString();
                frm.txtBaoHanh.Text = dgvDanhSachDT.CurrentRow.Cells[6].Value.ToString();
                frm.txtNSX.Text = dgvDanhSachDT.CurrentRow.Cells[7].Value.ToString();
                frm.txtGiaBan.Text = dgvDanhSachDT.CurrentRow.Cells[8].Value.ToString();
                frm.txtGiaNhap.Text = dgvDanhSachDT.CurrentRow.Cells[9].Value.ToString();
                frm.txtSLC.Text = dgvDanhSachDT.CurrentRow.Cells[10].Value.ToString();
                frm.txtTrangThai.Text = dgvDanhSachDT.CurrentRow.Cells[11].Value.ToString();
                frm.txtMota.Text = dgvDanhSachDT.CurrentRow.Cells[12].Value.ToString();
                //MemoryStream ms = new MemoryStream((byte[])dgvDanhSachDT.CurrentRow.Cells[13].Value);
                //frm.pic1.Image = Image.FromStream(ms);
                frm.ShowDialog();
                this.sanPhamTableAdapter.Fill(this.phoneUwUDataSet.SanPham);
            }
        }

        private void btXoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa dòng dữ liệu này không?", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sanPhamBindingSource.RemoveCurrent();
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            int i = sanPhamTableAdapter.Update(phoneUwUDataSet.SanPham);
            MessageBox.Show("Đã hoàn thành việc lưu mới " + i + " dòng dữ liệu ", "Lưu mới dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btTim_Click(object sender, EventArgs e)
        {

        }
    }
}


