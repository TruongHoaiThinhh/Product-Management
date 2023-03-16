using BaiThu6.Model;
using Common.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThu6.Forms
{
    public partial class FormThemSP : Form
    {
        public FormThemSP()
        {
            InitializeComponent();
        }
        PhoneContext context = new PhoneContext();
        public void LoadUser()
        {
            label13.Text = "Chức vụ: " + UserLoginCache.ChucVu;
        }
        private void FormThemSP_Load(object sender, EventArgs e)
        {

            try
            {
                PhoneContext context = new PhoneContext();
                List<SanPham> listSanPham = context.SanPhams.ToList();
                List<LoaiSP> listLoaiSP = context.LoaiSPs.ToList();
                List<NhomSP> listNhomSP = context.NhomSPs.ToList();
                LoaiSanPhamCombobox(listLoaiSP);
                NhomSanPhamCombobox(listNhomSP);
                BindGrid(listSanPham);
                LoadUser();
                if (label13.Text == "Chức vụ: Nhân Viên")
                {
                    btThem.Enabled = false;
                    btThem.BackColor = Color.FromArgb(170, 170, 170);
                    btLuu.Enabled = false;
                    btLuu.BackColor = Color.FromArgb(170, 170, 170);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoaiSanPhamCombobox(List<LoaiSP> listLoaiSP)
        {
            this.cmbLoaiSP.DataSource = listLoaiSP;
            this.cmbLoaiSP.ValueMember = "LoaiSP1";
            this.cmbLoaiSP.DisplayMember = "LoaiSP1";
        }

        private void NhomSanPhamCombobox(List<NhomSP> listNhomSP)
        {
            this.cmbNhomSP.DataSource = listNhomSP;
            this.cmbNhomSP.ValueMember = "NhomSP1";
            this.cmbNhomSP.DisplayMember = "NhomSP1";
        }

        private void BindGrid(List<SanPham> listDienThoai)
        {
            dgvThemSP.Rows.Clear();
            foreach (var item in listDienThoai)
            {
                int index = dgvThemSP.Rows.Add();
                dgvThemSP.Rows[index].Cells[0].Value = item.MaSP;
                dgvThemSP.Rows[index].Cells[1].Value = item.TenSP;
                dgvThemSP.Rows[index].Cells[2].Value = item.KichThuoc;
                dgvThemSP.Rows[index].Cells[3].Value = item.MauSac;
                dgvThemSP.Rows[index].Cells[4].Value = item.BaoHanh;
                dgvThemSP.Rows[index].Cells[5].Value = item.NSX;
                dgvThemSP.Rows[index].Cells[6].Value = item.GiaNhap;
                dgvThemSP.Rows[index].Cells[7].Value = item.GiaBan;
                dgvThemSP.Rows[index].Cells[8].Value = item.SoLuong;
                dgvThemSP.Rows[index].Cells[9].Value = item.TrangThai;
                dgvThemSP.Rows[index].Cells[10].Value = item.MoTa;
                dgvThemSP.Rows[index].Cells[11].Value = item.HinhAnh;
                dgvThemSP.Rows[index].Cells[12].Value = item.NhomSP;
                dgvThemSP.Rows[index].Cells[13].Value = item.LoaiSP;

            }
        }
        private int GetSelectedRow(string MaSP)
        {
            for (int i = 0; i < dgvThemSP.Rows.Count; i++)
            {
                if (dgvThemSP.Rows[i].Cells[0].Value.ToString() == MaSP)
                {
                    return i;
                }
            }
            return -1;
        }

        private void reloadDGV()
        {
            List<SanPham> listSanPham = context.SanPhams.ToList();
            BindGrid(listSanPham);
        }

        private void refresh()
        {
            cmbLoaiSP.SelectedIndex = 0;
            cmbNhomSP.SelectedIndex = 0;
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtKichThuoc.Text = "";
            txtMauSac.Text = "";
            txtBaoHanh.Text = "";
            txtNSX.Text = "";
            txtGiaNhap.Text = "";
            txtGiaBan.Text = "";
            txtSLC.Text = "";
            txtMota.Text = "";
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "" || txtTenSP.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            { 
                if (GetSelectedRow(txtMaSP.Text) == -1)
                {
                    SanPham s = new SanPham()
                    {
                        MaSP = txtMaSP.Text,
                        TenSP = txtTenSP.Text,
                        KichThuoc = txtKichThuoc.Text,
                        MauSac = txtMauSac.Text,
                        BaoHanh = txtBaoHanh.Text,
                        NSX = txtNSX.Text,
                        GiaBan = int.Parse(txtGiaBan.Text),
                        GiaNhap = int.Parse(txtGiaNhap.Text),
                        SoLuong = int.Parse(txtSLC.Text),
                        TrangThai = txtTrangThai.Text,
                        LoaiSP = cmbLoaiSP.Text,
                        NhomSP = cmbNhomSP.Text, 
                        MoTa = txtMota.Text,
                        HinhAnh = ImageToBase64(pic1.Image, pic1.Image.RawFormat)
                    };
                    context.SanPhams.Add(s);
                    context.SaveChanges();

                    reloadDGV();
                    refresh();
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại", "Thông Báo", MessageBoxButtons.OK);
                }
            }
    }



        private void btLuu_Click(object sender, EventArgs e)
        {
            SanPham dbUpdate = context.SanPhams.FirstOrDefault(p => p.MaSP == txtMaSP.Text);
            if (dbUpdate != null)
            {
                dbUpdate.MaSP = txtMaSP.Text;
                dbUpdate.TenSP = txtTenSP.Text;
                dbUpdate.KichThuoc = txtKichThuoc.Text;
                dbUpdate.MauSac = txtMauSac.Text;
                dbUpdate.BaoHanh = txtBaoHanh.Text;
                dbUpdate.NSX = txtNSX.Text;
                dbUpdate.GiaBan = int.Parse(txtGiaBan.Text);
                dbUpdate.GiaNhap = int.Parse(txtGiaNhap.Text);
                dbUpdate.SoLuong = int.Parse(txtSLC.Text);
                dbUpdate.TrangThai = txtTrangThai.Text;
                dbUpdate.LoaiSP = cmbLoaiSP.Text;
                dbUpdate.NhomSP = cmbNhomSP.Text;
                dbUpdate.MoTa = txtMota.Text;
                dbUpdate.HinhAnh = ImageToBase64(pic1.Image, pic1.Image.RawFormat);

                context.SaveChanges();
                reloadDGV();
                refresh();
                MessageBox.Show("Lưu dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã sản phẩm cần sửa", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbLoaiSP_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Picture file (.png,.jpg)|*.png;*.jpg";
            if(openfile.ShowDialog()==DialogResult.OK)
            {
                pic1.Image = Image.FromFile(openfile.FileName);
                pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        public byte[] ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                return imageBytes;
            }
        }
        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

    }
}
