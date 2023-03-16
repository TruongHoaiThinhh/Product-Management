using Common.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThu6
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            btThoat.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture(); 
        
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //Methods

        public void LoadUser()
        {
            lblMa.Text = "Mã: " + UserLoginCache.MaNV;
            lblTen.Text = "Họ tên: " + UserLoginCache.HoTen;
            lblChucvu.Text ="Chức vụ: " + UserLoginCache.ChucVu;
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ChuDe.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ChuDe.ColorList.Count);
            }
            tempIndex = index;
            string color = ChuDe.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelThanhChuDe.BackColor = color;
                    panelThanhChuDeDuoi.BackColor = color;
                    panelLogo.BackColor = ChuDe.ChangeColorBrightness(color, -0.3);
                    ChuDe.PrimaryColor = color;
                    ChuDe.SecondaryColor = ChuDe.ChangeColorBrightness(color, -0.3);
                    btThoat.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDT.Controls.Add(childForm);
            this.panelDT.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbltittle.Text = childForm.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void btKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDanhMuc(), sender);
        }

        private void btMuaHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMuaHang(), sender);
        }

        private void btBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormBanHang(), sender);
        }


        private void Reset()
        {
            DisableButton();
            lbltittle.Text = "HOME";
            panelThanhChuDe.BackColor = Color.FromArgb(0, 150, 136);
            panelThanhChuDeDuoi.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btThoat.Visible = false;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void panelThanhChuDeDuoi_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

                lblTime.Text = DateTime.Now.ToString("hh:mm:ss ");
                lblTime1.Text = DateTime.Now.ToLongDateString();

        }

        private void panelThanhChuDe_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btSize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btThuXuong_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btKho_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormQuanLyKho(), sender);
        }

        private void btHeThonh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHeThong(), sender);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btBaoCao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormBaoCaoThongKe(), sender);
        }
    }
}
