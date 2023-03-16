
namespace BaiThu6.Forms
{
    partial class FormDanhMuc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDanhMuc));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhomspMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.loaispMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.khoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelManHinh = new System.Windows.Forms.Panel();
            this.sanphamMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.nccMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.khachMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanvienMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelManHinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sanphamMenu,
            this.nhomspMenu,
            this.loaispMenu,
            this.nccMenu,
            this.khachMenu,
            this.nhanvienMenu,
            this.khoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1257, 29);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhomspMenu
            // 
            this.nhomspMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhomspMenu.Image = ((System.Drawing.Image)(resources.GetObject("nhomspMenu.Image")));
            this.nhomspMenu.Name = "nhomspMenu";
            this.nhomspMenu.Size = new System.Drawing.Size(156, 25);
            this.nhomspMenu.Text = "Nhóm Sản Phẩm";
            this.nhomspMenu.Click += new System.EventHandler(this.nhomspMenu_Click);
            // 
            // loaispMenu
            // 
            this.loaispMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loaispMenu.Image = ((System.Drawing.Image)(resources.GetObject("loaispMenu.Image")));
            this.loaispMenu.Name = "loaispMenu";
            this.loaispMenu.Size = new System.Drawing.Size(141, 25);
            this.loaispMenu.Text = "Loại Sản Phẩm";
            this.loaispMenu.Click += new System.EventHandler(this.loaispMenu_Click);
            // 
            // khoToolStripMenuItem
            // 
            this.khoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("khoToolStripMenuItem.Image")));
            this.khoToolStripMenuItem.Name = "khoToolStripMenuItem";
            this.khoToolStripMenuItem.Size = new System.Drawing.Size(65, 25);
            this.khoToolStripMenuItem.Text = "Kho";
            this.khoToolStripMenuItem.Click += new System.EventHandler(this.khoToolStripMenuItem_Click_1);
            // 
            // panelManHinh
            // 
            this.panelManHinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelManHinh.Controls.Add(this.label1);
            this.panelManHinh.Location = new System.Drawing.Point(0, 32);
            this.panelManHinh.Name = "panelManHinh";
            this.panelManHinh.Size = new System.Drawing.Size(1257, 671);
            this.panelManHinh.TabIndex = 5;
            // 
            // sanphamMenu
            // 
            this.sanphamMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sanphamMenu.Image = ((System.Drawing.Image)(resources.GetObject("sanphamMenu.Image")));
            this.sanphamMenu.Name = "sanphamMenu";
            this.sanphamMenu.Size = new System.Drawing.Size(108, 25);
            this.sanphamMenu.Text = "Sản Phẩm";
            this.sanphamMenu.Click += new System.EventHandler(this.sanphamMenu_Click);
            // 
            // nccMenu
            // 
            this.nccMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nccMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nccMenu.Image = ((System.Drawing.Image)(resources.GetObject("nccMenu.Image")));
            this.nccMenu.Name = "nccMenu";
            this.nccMenu.Size = new System.Drawing.Size(139, 25);
            this.nccMenu.Text = "Nhà Cung Cấp";
            this.nccMenu.Click += new System.EventHandler(this.nccMenu_Click);
            // 
            // khachMenu
            // 
            this.khachMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khachMenu.Image = ((System.Drawing.Image)(resources.GetObject("khachMenu.Image")));
            this.khachMenu.Name = "khachMenu";
            this.khachMenu.Size = new System.Drawing.Size(121, 25);
            this.khachMenu.Text = "Khách Hàng";
            this.khachMenu.Click += new System.EventHandler(this.khachMenu_Click);
            // 
            // nhanvienMenu
            // 
            this.nhanvienMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhanvienMenu.Image = ((System.Drawing.Image)(resources.GetObject("nhanvienMenu.Image")));
            this.nhanvienMenu.Name = "nhanvienMenu";
            this.nhanvienMenu.Size = new System.Drawing.Size(111, 25);
            this.nhanvienMenu.Text = "Nhân Viên";
            this.nhanvienMenu.Click += new System.EventHandler(this.nhanvienMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 638);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // FormDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 704);
            this.Controls.Add(this.panelManHinh);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDanhMuc";
            this.Text = "Danh Mục";
            this.Load += new System.EventHandler(this.FormKho_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelManHinh.ResumeLayout(false);
            this.panelManHinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sanphamMenu;
        private System.Windows.Forms.ToolStripMenuItem nccMenu;
        private System.Windows.Forms.Panel panelManHinh;
        private System.Windows.Forms.ToolStripMenuItem khachMenu;
        private System.Windows.Forms.ToolStripMenuItem nhanvienMenu;
        private System.Windows.Forms.ToolStripMenuItem nhomspMenu;
        private System.Windows.Forms.ToolStripMenuItem loaispMenu;
        private System.Windows.Forms.ToolStripMenuItem khoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}