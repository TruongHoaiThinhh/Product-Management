using BaiThu6.Model;
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
    public partial class FormDoiMatKhau : Form
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }
        PhoneContext context = new PhoneContext();
        public void LoadUser()
        {
            label1.Text = UserLoginCache.ChucVu;
            txtTaiKhoan.Text = label1.Text;
        }

        private void FormDoiMatKhau_Load(object sender, EventArgs e)
        {
            try
            {
                PhoneContext context = new PhoneContext();
                List<NhanVien> listNhanVien = context.NhanViens.ToList();
                BindGrid(listNhanVien);
                LoadUser();
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
        private int GetSelectedRow(string MaSP)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == MaSP)
                {
                    return i;
                }
            }
            return -1;
        }

        private void reloadDGV()
        {
            List<NhanVien> listNhanVien = context.NhanViens.ToList();
            BindGrid(listNhanVien);
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            NhanVien dbUpdate = context.NhanViens.FirstOrDefault(p => p.MaNV == txtTaiKhoan.Text);
            NhanVien dbUpdate1 = context.NhanViens.FirstOrDefault(p => p.MatKhau == txtMatKhauCu.Text);
            if (dbUpdate != null)
            {
                if(dbUpdate1 != null)
                {
                    dbUpdate.MatKhau = txtMatKhauMoi.Text;
                    context.SaveChanges();
                    reloadDGV();
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu", "Thông Báo", MessageBoxButtons.OK);
                }
            }
        }
    }
}
