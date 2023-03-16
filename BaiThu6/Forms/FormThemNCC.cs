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
    public partial class FormThemNCC : Form
    {
        public FormThemNCC()
        {
            InitializeComponent();
        }
        PhoneContext context = new PhoneContext();

        private void FormThemNCC_Load(object sender, EventArgs e)
        {
            try
            {

                List<NhaCungCap> listNhaCungCap = context.NhaCungCaps.ToList();
                BindGrid(listNhaCungCap);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<NhaCungCap> listNhaCungCap)
        {
            dgvNCC.Rows.Clear();
            foreach (var item in listNhaCungCap)
            {
                int index = dgvNCC.Rows.Add();
                dgvNCC.Rows[index].Cells[0].Value = item.MaNCC;
                dgvNCC.Rows[index].Cells[1].Value = item.TenNCC;
                dgvNCC.Rows[index].Cells[2].Value = item.Diachi;
                dgvNCC.Rows[index].Cells[3].Value = item.Stk;
                dgvNCC.Rows[index].Cells[4].Value = item.Dt1;
                dgvNCC.Rows[index].Cells[5].Value = item.Dt2;
                dgvNCC.Rows[index].Cells[6].Value = item.Email;
                dgvNCC.Rows[index].Cells[7].Value = item.Website;
                dgvNCC.Rows[index].Cells[8].Value = item.Mota;
            }
        }
        private int GetSelectedRow(string MaNCC)
        {
            for (int i = 0; i < dgvNCC.Rows.Count; i++)
            {
                if (dgvNCC.Rows[i].Cells[0].Value.ToString() == MaNCC)
                {
                    return i;
                }
            }
            return -1;
        }

        private void reloadDGV()
        {
            List<NhaCungCap> listNhaCungCap = context.NhaCungCaps.ToList();
            BindGrid(listNhaCungCap);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "" || txtTenNCC.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                if (GetSelectedRow(txtMaNCC.Text) == -1)
                {
                    NhaCungCap s = new NhaCungCap()
                    {
                        MaNCC = txtMaNCC.Text,
                        TenNCC = txtTenNCC.Text,
                        Diachi = txtDiaChi.Text,
                        Stk = txtSTK.Text,
                        Dt1 = txtDT1.Text,
                        Dt2 = txtDT2.Text,
                        Email = txtEmail.Text,
                        Website = txtWeb.Text,
                        Mota = txtMota.Text,
                    };
                    context.NhaCungCaps.Add(s);
                    context.SaveChanges();

                    reloadDGV();
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Mã nhà cung cấp đã tồn tại", "Thông Báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {

            NhaCungCap dbUpdate = context.NhaCungCaps.FirstOrDefault(p => p.MaNCC == txtMaNCC.Text);
            if (dbUpdate != null)
            {
                dbUpdate.MaNCC = txtMaNCC.Text;
                dbUpdate.TenNCC = txtTenNCC.Text;
                dbUpdate.Diachi = txtDiaChi.Text;
                dbUpdate.Stk = txtSTK.Text;
                dbUpdate.Dt1 = txtDT1.Text;
                dbUpdate.Dt2 = txtDT2.Text;
                dbUpdate.Email = txtEmail.Text;
                dbUpdate.Website = txtWeb.Text;
                dbUpdate.Mota = txtMota.Text;

                context.SaveChanges();
                reloadDGV();
                MessageBox.Show("Lưu dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã nhà cung cấp cần sửa", "Thông Báo", MessageBoxButtons.OK);
            }
        }
    }
}
