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
    public partial class FormThemKH : Form
    {
        public FormThemKH()
        {
            InitializeComponent();
        }
        PhoneContext context = new PhoneContext();

        private void FormThemKH_Load(object sender, EventArgs e)
        {
            try
            {

                List<KhachHang> listKhachHang = context.KhachHangs.ToList();
                BindGrid(listKhachHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<KhachHang> listKhachHang)
        {
            dgvKH.Rows.Clear();
            foreach (var item in listKhachHang)
            {
                int index = dgvKH.Rows.Add();
                dgvKH.Rows[index].Cells[0].Value = item.MaKH;
                dgvKH.Rows[index].Cells[1].Value = item.TenKH;
                dgvKH.Rows[index].Cells[2].Value = item.Diachi;
                dgvKH.Rows[index].Cells[3].Value = item.Stk;
                dgvKH.Rows[index].Cells[4].Value = item.Dt1;
                dgvKH.Rows[index].Cells[6].Value = item.Email;
                dgvKH.Rows[index].Cells[8].Value = item.Mota;
            }
        }
        private int GetSelectedRow(string MaKH)
        {
            for (int i = 0; i < dgvKH.Rows.Count; i++)
            {
                if (dgvKH.Rows[i].Cells[0].Value.ToString() == MaKH)
                {
                    return i;
                }
            }
            return -1;
        }

        private void reloadDGV()
        {
            List<KhachHang> listKhachHang = context.KhachHangs.ToList();
            BindGrid(listKhachHang);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "" || txtTenKH.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                if (GetSelectedRow(txtMaKH.Text) == -1)
                {
                    KhachHang s = new KhachHang()
                    {
                        MaKH = txtMaKH.Text,
                        TenKH = txtTenKH.Text,
                        Diachi = txtDiaChi.Text,
                        Stk = txtSTK.Text,
                        Dt1 = txtDT1.Text,
                        Email = txtEmail.Text,
                        Mota = txtMota.Text,
                    };
                    context.KhachHangs.Add(s);
                    context.SaveChanges();

                    reloadDGV();
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại", "Thông Báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            KhachHang dbUpdate = context.KhachHangs.FirstOrDefault(p => p.MaKH == txtMaKH.Text);
            if (dbUpdate != null)
            {
                dbUpdate.MaKH = txtMaKH.Text;
                dbUpdate.TenKH = txtTenKH.Text;
                dbUpdate.Diachi = txtDiaChi.Text;
                dbUpdate.Stk = txtSTK.Text;
                dbUpdate.Dt1 = txtDT1.Text;
                dbUpdate.Email = txtEmail.Text;
                dbUpdate.Mota = txtMota.Text;

                context.SaveChanges();
                reloadDGV();
                MessageBox.Show("Lưu dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã khách hàng cần sửa", "Thông Báo", MessageBoxButtons.OK);
            }
        }
    }
}
