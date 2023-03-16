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
    public partial class FormDSHoaDon : Form
    {
        public FormDSHoaDon()
        {
            InitializeComponent();
            dgvDSPhieuMua.EnableHeadersVisualStyles = false;
            dgvCTPhieuMua.EnableHeadersVisualStyles = false;
        }
        PhoneContext context = new PhoneContext();

        private void FormDSHoaDon_Load(object sender, EventArgs e)
        {
            List<HoaDon> listHoadon = context.HoaDons.ToList();
            List<ChiTietHoaDon> listChiTietHoaDon = context.ChiTietHoaDons.ToList();
            BindGrid(listHoadon);
        }

        private void BindGrid(List<HoaDon> listHoadon)
        {
            dgvDSPhieuMua.Rows.Clear();
            foreach (var item in listHoadon)
            {
                int index = dgvDSPhieuMua.Rows.Add();
                dgvDSPhieuMua.Rows[index].Cells[0].Value = item.MaHoaDon;
                dgvDSPhieuMua.Rows[index].Cells[1].Value = item.NgayLap;
                dgvDSPhieuMua.Rows[index].Cells[2].Value = item.TenKH;
                dgvDSPhieuMua.Rows[index].Cells[3].Value = item.TongTien;
                dgvDSPhieuMua.Rows[index].Cells[4].Value = item.GhiChu;
                dgvDSPhieuMua.Rows[index].Cells[5].Value = item.NgLap;
                dgvDSPhieuMua.Rows[index].Cells[6].Value = item.HTTT;
                dgvDSPhieuMua.Rows[index].Cells[7].Value = item.Kho;
            }
        }

        private void BindGrid1(List<ChiTietHoaDon> listChiTietHoaDon)
        {
            dgvCTPhieuMua.Rows.Clear();
            foreach (var item in listChiTietHoaDon)
            {
                int index = dgvCTPhieuMua.Rows.Add();
                dgvCTPhieuMua.Rows[index].Cells[0].Value = item.MaHD;
                dgvCTPhieuMua.Rows[index].Cells[1].Value = item.MaSP;
                dgvCTPhieuMua.Rows[index].Cells[2].Value = item.TenSP;
                dgvCTPhieuMua.Rows[index].Cells[3].Value = item.Gia;
                dgvCTPhieuMua.Rows[index].Cells[4].Value = item.SoLuong;
                dgvCTPhieuMua.Rows[index].Cells[5].Value = item.ThanhTien;
                dgvCTPhieuMua.Rows[index].Cells[6].Value = item.VAT;
                dgvCTPhieuMua.Rows[index].Cells[7].Value = item.CK;
                dgvCTPhieuMua.Rows[index].Cells[8].Value = item.GhiChu;
                dgvCTPhieuMua.Rows[index].Cells[9].Value = item.TienVAT;
                dgvCTPhieuMua.Rows[index].Cells[10].Value = item.TienCK;

            }
        }

        private void dgvCTPhieuMua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMaPM_TextChanged(object sender, EventArgs e)
        {
            List<ChiTietHoaDon> timMA = context.ChiTietHoaDons.Where(p => (string.IsNullOrEmpty(txtMaPM.Text) || p.MaHD.Contains(txtMaPM.Text))).ToList();
            BindGrid1(timMA);
        }

        private void dgvDSPhieuMua_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDSPhieuMua.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvDSPhieuMua.CurrentRow.Selected = true;
                    txtMaPM.Text = dgvDSPhieuMua.Rows[e.RowIndex].Cells["dgvMaPM"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            List<HoaDon> timHD = context.HoaDons.Where(p => (string.IsNullOrEmpty(txtTim.Text) || p.MaHoaDon.Contains(txtTim.Text))).ToList();
            BindGrid(timHD);
        }
    }
}
