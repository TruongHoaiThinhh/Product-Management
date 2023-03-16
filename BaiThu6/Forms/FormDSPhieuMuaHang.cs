using BaiThu6.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThu6.Forms
{
    public partial class FormDSPhieuMuaHang : Form
    {
        public FormDSPhieuMuaHang()
        {
            InitializeComponent();
            dgvDSPhieuMua.EnableHeadersVisualStyles = false;
            dgvCTPhieuMua.EnableHeadersVisualStyles = false;
        }
        PhoneContext context = new PhoneContext();

        private void FormDSPhieuMuaHang_Load(object sender, EventArgs e)
        {
            List<PhieuMua> listPhieuMua = context.PhieuMuas.ToList();
            List<ChiTietPhieuMua> listChiTietPhieuMua = context.ChiTietPhieuMuas.ToList();
            BindGrid(listPhieuMua);
            //BindGrid1(listChiTietPhieuMua);
        }

        private void BindGrid(List<PhieuMua> listPhieuMua)
        {
            dgvDSPhieuMua.Rows.Clear();
            foreach (var item in listPhieuMua)
            {
                int index = dgvDSPhieuMua.Rows.Add();
                dgvDSPhieuMua.Rows[index].Cells[0].Value = item.MaPhieuMua;
                dgvDSPhieuMua.Rows[index].Cells[1].Value = item.NgayLap;
                dgvDSPhieuMua.Rows[index].Cells[2].Value = item.TenNCC;
                dgvDSPhieuMua.Rows[index].Cells[3].Value = item.TongTien;
                dgvDSPhieuMua.Rows[index].Cells[4].Value = item.GhiChu;
                dgvDSPhieuMua.Rows[index].Cells[5].Value = item.NgLap;
                dgvDSPhieuMua.Rows[index].Cells[6].Value = item.HTTT;
                dgvDSPhieuMua.Rows[index].Cells[7].Value = item.Kho;
            }
        }

        private void BindGrid1(List<ChiTietPhieuMua> listChiTietPhieuMua)
        {
            dgvCTPhieuMua.Rows.Clear();
            foreach (var item in listChiTietPhieuMua)
            {
                int index = dgvCTPhieuMua.Rows.Add();
                dgvCTPhieuMua.Rows[index].Cells[0].Value = item.MaPM;
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
            List<ChiTietPhieuMua> timMA = context.ChiTietPhieuMuas.Where(p => (string.IsNullOrEmpty(txtMaPM.Text) || p.MaPM.Contains(txtMaPM.Text))).ToList();
            BindGrid1(timMA);
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            List<PhieuMua> timPM = context.PhieuMuas.Where(p => (string.IsNullOrEmpty(txtTim.Text) || p.MaPhieuMua.Contains(txtTim.Text))).ToList();
            BindGrid(timPM);
        }
    }
}
