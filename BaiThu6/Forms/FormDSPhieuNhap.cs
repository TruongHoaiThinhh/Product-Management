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
    public partial class FormDSPhieuNhap : Form
    {
        public FormDSPhieuNhap()
        {
            InitializeComponent();
            dgvDSPhieuMua.EnableHeadersVisualStyles = false;
            dgvCTPhieuMua.EnableHeadersVisualStyles = false;
        }
        PhoneContext context = new PhoneContext();
        private void FormDSPhieuNhap_Load(object sender, EventArgs e)
        {
            List<PhieuNhap> listPhieuNhap = context.PhieuNhaps.ToList();
            List<ChiTietPhieuNhap> listChiTietPhieuNhap = context.ChiTietPhieuNhaps.ToList();
            BindGrid(listPhieuNhap);
            //BindGrid1(listChiTietPhieuMua);
        }

        private void BindGrid(List<PhieuNhap> listPhieuNhap)
        {
            dgvDSPhieuMua.Rows.Clear();
            foreach (var item in listPhieuNhap)
            {
                int index = dgvDSPhieuMua.Rows.Add();
                dgvDSPhieuMua.Rows[index].Cells[0].Value = item.MaPhieuNhap;
                dgvDSPhieuMua.Rows[index].Cells[1].Value = item.NgayLap;
                dgvDSPhieuMua.Rows[index].Cells[2].Value = item.TenNCC;
                dgvDSPhieuMua.Rows[index].Cells[3].Value = item.TongTien;
                dgvDSPhieuMua.Rows[index].Cells[4].Value = item.GhiChu;
                dgvDSPhieuMua.Rows[index].Cells[5].Value = item.NgLap;
                dgvDSPhieuMua.Rows[index].Cells[6].Value = item.HTTT;
                dgvDSPhieuMua.Rows[index].Cells[7].Value = item.Kho;
            }
        }

        private void BindGrid1(List<ChiTietPhieuNhap> listChiTietPhieuNhap)
        {
            dgvCTPhieuMua.Rows.Clear();
            foreach (var item in listChiTietPhieuNhap)
            {
                int index = dgvCTPhieuMua.Rows.Add();
                dgvCTPhieuMua.Rows[index].Cells[0].Value = item.MaPX;
                dgvCTPhieuMua.Rows[index].Cells[1].Value = item.MaSP;
                dgvCTPhieuMua.Rows[index].Cells[2].Value = item.TenSP;
                dgvCTPhieuMua.Rows[index].Cells[3].Value = item.Gia;
                dgvCTPhieuMua.Rows[index].Cells[4].Value = item.SoLuong;
                dgvCTPhieuMua.Rows[index].Cells[5].Value = item.ThanhTien;
                dgvCTPhieuMua.Rows[index].Cells[6].Value = item.GhiChu;


            }
        }

        private void dgvDSPhieuMua_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void txtMaPM_TextChanged(object sender, EventArgs e)
        {
            List<ChiTietPhieuNhap> timMA = context.ChiTietPhieuNhaps.Where(p => (string.IsNullOrEmpty(txtMaPM.Text) || p.MaPX.Contains(txtMaPM.Text))).ToList();
            BindGrid1(timMA);
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            List<PhieuNhap> timPN = context.PhieuNhaps.Where(p => (string.IsNullOrEmpty(txtTim.Text) || p.MaPhieuNhap.Contains(txtTim.Text))).ToList();
            BindGrid(timPN);
        }
    }
}
