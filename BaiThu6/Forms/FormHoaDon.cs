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
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
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

        private void FormHoaDon_Load(object sender, EventArgs e)
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
                txtPM.Text = "HD" + rd.Next().ToString();
                txtTong.Text = "0";
                txtCK.Text = "0";
                txtVAT.Text = "0";
                txtTongTien.Text = "0";
                txtShip.Text = "0";
                txtSL.Text = "0";
                txtGTGT.Text = "0";
                txtChietKhau.Text = "0";
                //BindGrid(listChiTietPhieuMua);
                // BindGrid1(listHoaDon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<ChiTietHoaDon> listChiTietHoaDon)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in listChiTietHoaDon)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.MaHD;
                dataGridView1.Rows[index].Cells[1].Value = item.MaSP;
                dataGridView1.Rows[index].Cells[2].Value = item.TenSP;
                dataGridView1.Rows[index].Cells[3].Value = item.Gia;
                dataGridView1.Rows[index].Cells[4].Value = item.SoLuong;
                dataGridView1.Rows[index].Cells[5].Value = item.ThanhTien;
                dataGridView1.Rows[index].Cells[6].Value = item.VAT;
                dataGridView1.Rows[index].Cells[7].Value = item.CK;
                dataGridView1.Rows[index].Cells[8].Value = item.GhiChu;
                dataGridView1.Rows[index].Cells[9].Value = item.TienVAT;
                dataGridView1.Rows[index].Cells[10].Value = item.TienCK;

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
            List<ChiTietHoaDon> listChiTietHoaDon = context.ChiTietHoaDons.ToList();
            BindGrid(listChiTietHoaDon);
        }

        private void btThemSP_Click(object sender, EventArgs e)
        {
            if (GetSelectedRow(cmbTenDT.Text) == -1)
            {
                ChiTietHoaDon s = new ChiTietHoaDon()
                {
                    MaHD = txtPM.Text,
                    MaSP = cmbMaSP.Text,
                    TenSP = cmbTenDT.Text,
                    Gia = int.Parse(txtGiaTien.Text),
                    SoLuong = int.Parse(txtSL.Text),
                    ThanhTien = float.Parse(txtThanhTien.Text),
                    VAT = int.Parse(txtGTGT.Text),
                    CK = int.Parse(txtChietKhau.Text),
                    GhiChu = txtGhiChu.Text,
                    TienVAT = float.Parse(txtTienVAT.Text),
                    TienCK = float.Parse(txtTienCK.Text),

                };
                context.ChiTietHoaDons.Add(s);
                context.SaveChanges();

                reloadDGV1();

                List<ChiTietHoaDon> timMA = context.ChiTietHoaDons.Where(p => (string.IsNullOrEmpty(txtPM.Text) || p.MaHD.Contains(txtPM.Text))).ToList();
                BindGrid(timMA);
                SumTien();
                SumCK();
                SumVAT();
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
 
            }
        }

        private void txtGTGT_TextChanged(object sender, EventArgs e)
        {
            int x = 1;
            try
            {
                float number1 = float.Parse(txtThanhTien.Text);
                float number2 = float.Parse(txtGTGT.Text);
                float number3 = number2 - x;
                float result = number1 * number3 / 100;
                txtTienVAT.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập %VAT", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbTenDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtThanhTien.Text = "0";
            txtTienCK.Text = "0";
            txtTienVAT.Text = "0";
            txtChietKhau.Text = "0";
            txtGTGT.Text = "0";
        }

        private void txtChietKhau_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(txtThanhTien.Text);
                float number2 = float.Parse(txtChietKhau.Text);
                float result = number1 * number2 / 100;
                txtTienCK.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập %CK", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XoaSP_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon dbDelete1 = context.ChiTietHoaDons.FirstOrDefault(p => p.MaSP == cmbMaSP.Text);
            ChiTietHoaDon dbDelete2 = context.ChiTietHoaDons.FirstOrDefault(p => p.MaHD == txtPM.Text);
            if (dbDelete1 != null)
            {
                if (dbDelete2 != null)
                {
                    context.ChiTietHoaDons.Remove(dbDelete2);
                    context.SaveChanges();
                    reloadDGV1();

                    List<ChiTietHoaDon> timMA = context.ChiTietHoaDons.Where(p => (string.IsNullOrEmpty(txtPM.Text) || p.MaHD.Contains(txtPM.Text))).ToList();
                    BindGrid(timMA);
                    SumTien();
                    SumCK();
                    SumVAT();
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

        private void SumCK()
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["dgvTienCK"].Value);
            }
            txtCK.Text = sum.ToString();
        }

        private void SumVAT()
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["dgvTienVAT"].Value);
            }
            txtVAT.Text = sum.ToString();
        }

        private void SumThanhTIen()
        {
            try
            {
                float number0 = float.Parse(txtTong.Text);
                float number1 = float.Parse(txtCK.Text);
                float number2 = float.Parse(txtVAT.Text);
                float number3 = float.Parse(txtShip.Text);
                float result = number0 - number1 + number2 + number3;
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
                HoaDon s = new HoaDon()
                {
                    MaHoaDon = txtPM.Text,
                    NgayLap = dateTimePicker1.Value,
                    TenKH = cmbNCC.Text,
                    GhiChu = txtDienGiai.Text,
                    HTTT = cmbHTTT.Text,
                    Kho = cmbKho.Text,
                    NgLap = txtNguoiLap.Text,
                    TongTien = double.Parse(txtTongTien.Text)
                };


                context.HoaDons.Add(s);

                context.SaveChanges();
                MessageBox.Show("Thêm hóa đơn thành công!", "Thông Báo", MessageBoxButtons.OK);
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

        private void cmbTenDT_SelectedValueChanged_1(object sender, EventArgs e)
        {
            cmbTenSP1.Text = cmbTenDT.SelectedValue.ToString();
        }

        private void cmbTenSP1_SelectedValueChanged_1(object sender, EventArgs e)
        {
            txtGiaTien.Text = cmbTenSP1.SelectedValue.ToString();
        }

        private void FormHoaDon_KeyDown(object sender, KeyEventArgs e)
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
    }
}
