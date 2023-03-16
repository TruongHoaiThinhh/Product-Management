
namespace BaiThu6.Forms
{
    partial class FormHeThong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHeThong));
            this.label1 = new System.Windows.Forms.Label();
            this.panelManHinh = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ThoatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.doimatkhauMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.phânQuyềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(982, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // panelManHinh
            // 
            this.panelManHinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelManHinh.Location = new System.Drawing.Point(0, 33);
            this.panelManHinh.Name = "panelManHinh";
            this.panelManHinh.Size = new System.Drawing.Size(1257, 671);
            this.panelManHinh.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThoatMenu,
            this.doimatkhauMenu,
            this.phânQuyềnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1257, 29);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ThoatMenu
            // 
            this.ThoatMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThoatMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ThoatMenu.Image = ((System.Drawing.Image)(resources.GetObject("ThoatMenu.Image")));
            this.ThoatMenu.Name = "ThoatMenu";
            this.ThoatMenu.Size = new System.Drawing.Size(108, 25);
            this.ThoatMenu.Text = "Đăng xuất";
            this.ThoatMenu.Click += new System.EventHandler(this.ThoatMenu_Click);
            // 
            // doimatkhauMenu
            // 
            this.doimatkhauMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doimatkhauMenu.Image = ((System.Drawing.Image)(resources.GetObject("doimatkhauMenu.Image")));
            this.doimatkhauMenu.Name = "doimatkhauMenu";
            this.doimatkhauMenu.Size = new System.Drawing.Size(131, 25);
            this.doimatkhauMenu.Text = "Đổi mật khẩu";
            this.doimatkhauMenu.Click += new System.EventHandler(this.doimatkhauMenu_Click);
            // 
            // phânQuyềnToolStripMenuItem
            // 
            this.phânQuyềnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phânQuyềnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("phânQuyềnToolStripMenuItem.Image")));
            this.phânQuyềnToolStripMenuItem.Name = "phânQuyềnToolStripMenuItem";
            this.phânQuyềnToolStripMenuItem.Size = new System.Drawing.Size(192, 25);
            this.phânQuyềnToolStripMenuItem.Text = "Phân quyền nhân viên";
            this.phânQuyềnToolStripMenuItem.Click += new System.EventHandler(this.phânQuyềnToolStripMenuItem_Click);
            // 
            // FormHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 704);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelManHinh);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormHeThong";
            this.Text = "Hệ Thống";
            this.Load += new System.EventHandler(this.FormHeThong_Load);
            this.LocationChanged += new System.EventHandler(this.FormHeThong_LocationChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelManHinh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ThoatMenu;
        private System.Windows.Forms.ToolStripMenuItem doimatkhauMenu;
        private System.Windows.Forms.ToolStripMenuItem phânQuyềnToolStripMenuItem;
    }
}