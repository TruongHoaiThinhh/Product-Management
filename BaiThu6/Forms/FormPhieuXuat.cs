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
    public partial class FormPhieuXuat : Form
    {
        public FormPhieuXuat()
        {
            InitializeComponent();
            dataGridView1.EnableHeadersVisualStyles = false;
        }
        PhoneContext context = new PhoneContext();
        Random rd = new Random();

        public void LoadUser()
        {
            txtNguoiLap.Text = UserLoginCache.HoTen;
        }

        private void FormPhieuXuat_Load(object sender, EventArgs e)
        {

            try
            {
                this.KeyPreview = true;
                List<SanPham> listSanPham = context.SanPhams.ToList();
                List<Kho> listKho = context.Khoes.ToList();
                List<KhachHang> listKhachHang = context.KhachHangs.ToList();
                Random rd = new Random();
                TenSanPhamCombobox(listSanPham);
                GiaTienCombobox(listSanPham);
                KhoComboBox(listKho);
                NCCComboBox(listKhachHang);
                NCC0ComboBox(listKhachHang);
                NCC1ComboBox(listKhachHang);
                NCC2ComboBox(listKhachHang);
                MaSanPhamCombobox(listSanPham);
                LoadUser();
                txtPM.Text = "PN" + rd.Next().ToString();
                txtTong.Text = "0";
                txtTongTien.Text = "0";
                txtShip.Text = "0";
                txtSL.Text = "0";
                //BindGrid(listChiTietPhieuMua);
                // BindGrid1(listHoaDon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<ChiTietPhieuXuat> listChiTietPhieuXuat)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in listChiTietPhieuXuat)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.MaPX;
                dataGridView1.Rows[index].Cells[1].Value = item.MaSP;
                dataGridView1.Rows[index].Cells[2].Value = item.TenSP;
                dataGridView1.Rows[index].Cells[3].Value = item.Gia;
                dataGridView1.Rows[index].Cells[4].Value = item.SoLuong;
                dataGridView1.Rows[index].Cells[5].Value = item.ThanhTien;
                dataGridView1.Rows[index].Cells[6].Value = item.GhiChu;

            }
        }

        private void TenSanPhamCombobox(List<SanPham> listSanPham)
        {
            this.cmbTenDT.DataSource = listSanPham;
            this.cmbTenDT.DisplayMember = "TenSP";
            this.cmbTenDT.ValueMember = "TenSP";
        }

        private void MaSanPhamCombobox(List<SanPham> listSanPham)
        {
            this.cmbMaSP.DataSource = listSanPham;
            this.cmbMaSP.DisplayMember = "MaSP";
            this.cmbMaSP.ValueMember = "TenSP";
        }

        private void GiaTienCombobox(List<SanPham> listSanPham)
        {
            this.cmbTenSP1.DataSource = listSanPham;
            this.cmbTenSP1.DisplayMember = "TenSP";
            this.cmbTenSP1.ValueMember = "GiaBan";
        }

        private void KhoComboBox(List<Kho> listKho)
        {
            this.cmbKho.DataSource = listKho;
            this.cmbKho.DisplayMember = "Kho1";
            this.cmbKho.ValueMember = "Kho1";
        }

        private void NCCComboBox(List<KhachHang> listKhachHang)
        {
            this.cmbNCC.DataSource = listKhachHang;
            this.cmbNCC.DisplayMember = "TenKH";
            this.cmbNCC.ValueMember = "TenKH";
        }

        private void NCC0ComboBox(List<KhachHang> listKhachHang)
        {
            this.cmbMaNCC.DataSource = listKhachHang;
            this.cmbMaNCC.DisplayMember = "MaKH";
            this.cmbMaNCC.ValueMember = "MaKH";
        }

        private void NCC1ComboBox(List<KhachHang> listKhachHang)
        {
            this.cmbNCC1.DataSource = listKhachHang;
            this.cmbNCC1.DisplayMember = "TenKH";
            this.cmbNCC1.ValueMember = "DiaChi";
        }

        private void NCC2ComboBox(List<KhachHang> listKhachHang)
        {
            this.cmbNCC2.DataSource = listKhachHang;
            this.cmbNCC2.DisplayMember = "TenNCC";
            this.cmbNCC2.ValueMember = "Dt1";
        }

        private int GetSelectedRow(string TenSP)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[2].Value.ToString() == TenSP)
                {
                    return i;
                }
            }
            return -1;
        }
        private void reloadDGV1()
        {
            List<ChiTietPhieuXuat> listChiTietPhieuXuat = context.ChiTietPhieuXuats.ToList();
            BindGrid(listChiTietPhieuXuat);
        }

        private void cmbTenDT_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbTenSP1.Text = cmbTenDT.SelectedValue.ToString();
        }

        private void cmbTenSP1_SelectedValueChanged(object sender, EventArgs e)
        {
            txtGiaTien.Text = cmbTenSP1.SelectedValue.ToString();
        }

        private void FormPhieuXuat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btThemSP.PerformClick();
            }
            if (e.KeyCode == Keys.F3)
            {
                XoaSP.PerformClick();
            }
        }

        private void btThemSP_Click(object sender, EventArgs e)
        {
            if (GetSelectedRow(cmbTenDT.Text) == -1)
            {
                ChiTietPhieuXuat s = new ChiTietPhieuXuat()
                {
                    MaPX = txtPM.Text,
                    MaSP = cmbMaSP.Text,
                    TenSP = cmbTenDT.Text,
                    Gia = int.Parse(txtGiaTien.Text),
                    SoLuong = int.Parse(txtSL.Text),
                    ThanhTien = float.Parse(txtThanhTien.Text),
                    GhiChu = txtGhiChu.Text,
                };
                context.ChiTietPhieuXuats.Add(s);
                context.SaveChanges();

                reloadDGV1();

                List<ChiTietPhieuXuat> timMA = context.ChiTietPhieuXuats.Where(p => (string.IsNullOrEmpty(txtPM.Text) || p.MaPX.Contains(txtPM.Text))).ToList();
                BindGrid(timMA);
                SumTien();
                SumThanhTIen();
            }
            else
            {
                MessageBox.Show("Sản phẫm đã tồn tại", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void cmbNCC_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbMaNCC.Text = cmbNCC.SelectedValue.ToString();
            cmbNCC1.Text = cmbNCC.SelectedValue.ToString();
            cmbNCC2.Text = cmbNCC.SelectedValue.ToString();
        }

        private void cmbNCC1_SelectedValueChanged(object sender, EventArgs e)
        {
            txtDiaChi.Text = cmbNCC1.SelectedValue.ToString();
        }

        private void cmbNCC2_SelectedValueChanged(object sender, EventArgs e)
        {
            txtSDT.Text = cmbNCC2.SelectedValue.ToString();
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(txtGiaTien.Text);
                float number2 = float.Parse(txtSL.Text);
                float result = number1 * number2;
                txtThanhTien.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập số lượng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbTenDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtThanhTien.Text = "0";
        }

        private void XoaSP_Click(object sender, EventArgs e)
        {
            ChiTietPhieuXuat dbDelete1 = context.ChiTietPhieuXuats.FirstOrDefault(p => p.MaSP == cmbMaSP.Text);
            ChiTietPhieuXuat dbDelete2 = context.ChiTietPhieuXuats.FirstOrDefault(p => p.MaPX == txtPM.Text);
            if (dbDelete1 != null)
            {
                if (dbDelete2 != null)
                {
                    context.ChiTietPhieuXuats.Remove(dbDelete2);
                    context.SaveChanges();
                    reloadDGV1();

                    List<ChiTietPhieuXuat> timMA = context.ChiTietPhieuXuats.Where(p => (string.IsNullOrEmpty(txtPM.Text) || p.MaPX.Contains(txtPM.Text))).ToList();
                    BindGrid(timMA);
                    SumTien();
                    SumThanhTIen();
                }
            }
            else
            {

            }
        }

        private void SumTien()
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["dgvThanhTien"].Value);
            }
            txtTong.Text = sum.ToString();
        }

        private void SumThanhTIen()
        {
            try
            {
                float number0 = float.Parse(txtTong.Text);

                float number3 = float.Parse(txtShip.Text);
                float result = number0 + number3;
                txtTongTien.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập tiền mua hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    cmbMaSP.Text = dataGridView1.Rows[e.RowIndex].Cells["dgvMaSP"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {

            if (GetSelectedRow(txtPM.Text) == -1)
            {
                PhieuXuat s = new PhieuXuat()
                {
                    MaPhieuXuat = txtPM.Text,
                    NgayLap = dateTimePicker1.Value,
                    TenKH = cmbNCC.Text,
                    GhiChu = txtDienGiai.Text,
                    HTTT = cmbHTTT.Text,
                    Kho = cmbKho.Text,
                    NgLap = txtNguoiLap.Text,
                    TongTien = double.Parse(txtTongTien.Text)
                };


                context.PhieuXuats.Add(s);

                context.SaveChanges();
                MessageBox.Show("Thêm phiếu xuất thành công!", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {

            }
        }

        private void txtShip_TextChanged(object sender, EventArgs e)
        {
            if (txtShip.Text != null)
            {
                SumThanhTIen();
            }
            else
            {
                txtShip.Text = "0";
            }
        }
    }
}
