using BaiThu6.Model;
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
    public partial class FormPhanQuyen : Form
    {
        public FormPhanQuyen()
        {
            InitializeComponent();
        }
        PhoneContext context = new PhoneContext();

        private void FormPhanQuyen_Load(object sender, EventArgs e)
        {
            try
            {
                List<NhanVien> listNhanVien = context.NhanViens.ToList();

                NCCComboBox(listNhanVien);
                NCC0ComboBox(listNhanVien);
                NCC1ComboBox(listNhanVien);
                NCC2ComboBox(listNhanVien);
                //BindGrid(listChiTietPhieuMua);
                // BindGrid1(listHoaDon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindGrid(List<NhanVien> listNhanVien)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in listNhanVien)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.MaNV;
                dataGridView1.Rows[index].Cells[1].Value = item.TaiKhoan;
                dataGridView1.Rows[index].Cells[2].Value = item.MatKhau;
                dataGridView1.Rows[index].Cells[3].Value = item.HoTen;
                dataGridView1.Rows[index].Cells[4].Value = item.ChucVu;
                dataGridView1.Rows[index].Cells[5].Value = item.Email;
                dataGridView1.Rows[index].Cells[6].Value = item.DiaChi;
                dataGridView1.Rows[index].Cells[7].Value = item.SDT;
                dataGridView1.Rows[index].Cells[8].Value = item.Luong;
            }
        }

        private void NCCComboBox(List<NhanVien> listNhanVien)
        {
            this.cmbNCC.DataSource = listNhanVien;
            this.cmbNCC.DisplayMember = "HoTen";
            this.cmbNCC.ValueMember = "HoTen";
        }

        private void NCC0ComboBox(List<NhanVien> listNhanVien)
        {
            this.cmbMaNCC.DataSource = listNhanVien;
            this.cmbMaNCC.DisplayMember = "MaNV";
            this.cmbMaNCC.ValueMember = "MaNv";
        }

        private void NCC1ComboBox(List<NhanVien> listNhanVien)
        {
            this.cmbNCC1.DataSource = listNhanVien;
            this.cmbNCC1.DisplayMember = "HoTen";
            this.cmbNCC1.ValueMember = "DiaChi";
        }

        private void NCC2ComboBox(List<NhanVien> listNhanVien)
        {
            this.cmbNCC2.DataSource = listNhanVien;
            this.cmbNCC2.DisplayMember = "HoTen";
            this.cmbNCC2.ValueMember = "ChucVu";
        }

        private void cmbNCC2_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbChucVu.Text = cmbNCC2.SelectedValue.ToString();
        }

        private void cmbNCC1_SelectedValueChanged(object sender, EventArgs e)
        {
            txtDiaChi.Text = cmbNCC1.SelectedValue.ToString();
        }

        private void reloadDGV()
        {
            List<NhanVien> listNhanVien = context.NhanViens.ToList();
            BindGrid(listNhanVien);
        }


        private void btLuu_Click(object sender, EventArgs e)
        {
            NhanVien dbUpdate = context.NhanViens.FirstOrDefault(p => p.MaNV == cmbMaNCC.Text);
            if (dbUpdate != null)
            {
                    dbUpdate.ChucVu = cmbChucVu.Text;
                    context.SaveChanges();
                    reloadDGV();
                    MessageBox.Show("Phân quyền thành công thành công", "Thông Báo", MessageBoxButtons.OK);
            }
        }
    }
}
