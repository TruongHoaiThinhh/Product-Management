using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Domain;

namespace BaiThu6.Forms
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txttaikhoan_Enter(object sender, EventArgs e)
        {
            if(txttaikhoan.Text == "Tên tài khoản")
            {
                txttaikhoan.Text = "";
                txttaikhoan.ForeColor = Color.LightGray;
            }    
        }

        private void txttaikhoan_Leave(object sender, EventArgs e)
        {
            if(txttaikhoan.Text == "")
            {
                txttaikhoan.Text = "Tên tài khoản";
                txttaikhoan.ForeColor = Color.DimGray;
            }    
        }

        private void txtmatkhau_Enter(object sender, EventArgs e)
        {
            if (txtmatkhau.Text == "Mật khẩu")
            {
                txtmatkhau.Text = "";
                txtmatkhau.ForeColor = Color.LightGray;
                txtmatkhau.UseSystemPasswordChar = true;
            }
        }

        private void txtmatkhau_Leave(object sender, EventArgs e)
        {
            if (txtmatkhau.Text == "")
            {
                txtmatkhau.Text = "Mật khẩu";
                txtmatkhau.ForeColor = Color.DimGray;
                txtmatkhau.UseSystemPasswordChar = false;
            }
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormDangNhap_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

         private void msgError(string msg)
        {
            lblLoi.Text = "   " + msg;
            lblLoi.Visible = true;
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (txttaikhoan.Text != "Tên tài khoản")
            {
                if (txtmatkhau.Text != "Mật khẩu")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txttaikhoan.Text, txtmatkhau.Text);
                    if (validLogin == true)
                    {
                        Form1 mainMenu = new Form1();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        msgError("Bạn nhập sai tài khoản hoặc mật khẩu. \n Vui lòng nhập lại");
                        txtmatkhau.Text = "Mật khẩu";
                        txttaikhoan.Focus();
                    }
                }
                else msgError("Vui lòng nhập mật khẩu");
            }
            else msgError("Vui lòng nhập tài khoản");
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtmatkhau.Text = "Mật khẩu";
            txtmatkhau.ForeColor = Color.DimGray;
            txtmatkhau.UseSystemPasswordChar = false;
            txttaikhoan.Text = "Tên tài khoản";
            txttaikhoan.ForeColor = Color.DimGray;
            lblLoi.Visible = false;
            this.Show();

        }
    }
}
