
namespace BaiThu6.Forms
{
    partial class FormQuanLyKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyKho));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.phiếuNhậpKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuXuấtKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchPhiếuNhậpKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchPhiếuXuấtKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelManHinh = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phiếuNhậpKhoToolStripMenuItem,
            this.phiếuXuấtKhoToolStripMenuItem,
            this.danhSáchPhiếuNhậpKhoToolStripMenuItem,
            this.danhSáchPhiếuXuấtKhoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1257, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // phiếuNhậpKhoToolStripMenuItem
            // 
            this.phiếuNhậpKhoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phiếuNhậpKhoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("phiếuNhậpKhoToolStripMenuItem.Image")));
            this.phiếuNhậpKhoToolStripMenuItem.Name = "phiếuNhậpKhoToolStripMenuItem";
            this.phiếuNhậpKhoToolStripMenuItem.ShowShortcutKeys = false;
            this.phiếuNhậpKhoToolStripMenuItem.Size = new System.Drawing.Size(146, 25);
            this.phiếuNhậpKhoToolStripMenuItem.Text = "Phiếu nhập kho";
            this.phiếuNhậpKhoToolStripMenuItem.Click += new System.EventHandler(this.phiếuNhậpKhoToolStripMenuItem_Click);
            // 
            // phiếuXuấtKhoToolStripMenuItem
            // 
            this.phiếuXuấtKhoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phiếuXuấtKhoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("phiếuXuấtKhoToolStripMenuItem.Image")));
            this.phiếuXuấtKhoToolStripMenuItem.Name = "phiếuXuấtKhoToolStripMenuItem";
            this.phiếuXuấtKhoToolStripMenuItem.Size = new System.Drawing.Size(140, 25);
            this.phiếuXuấtKhoToolStripMenuItem.Text = "Phiếu xuất kho";
            this.phiếuXuấtKhoToolStripMenuItem.Click += new System.EventHandler(this.phiếuXuấtKhoToolStripMenuItem_Click);
            // 
            // danhSáchPhiếuNhậpKhoToolStripMenuItem
            // 
            this.danhSáchPhiếuNhậpKhoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhSáchPhiếuNhậpKhoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("danhSáchPhiếuNhậpKhoToolStripMenuItem.Image")));
            this.danhSáchPhiếuNhậpKhoToolStripMenuItem.Name = "danhSáchPhiếuNhậpKhoToolStripMenuItem";
            this.danhSáchPhiếuNhậpKhoToolStripMenuItem.Size = new System.Drawing.Size(222, 25);
            this.danhSáchPhiếuNhậpKhoToolStripMenuItem.Text = "Danh sách phiếu nhập kho";
            this.danhSáchPhiếuNhậpKhoToolStripMenuItem.Click += new System.EventHandler(this.danhSáchPhiếuNhậpKhoToolStripMenuItem_Click);
            // 
            // danhSáchPhiếuXuấtKhoToolStripMenuItem
            // 
            this.danhSáchPhiếuXuấtKhoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhSáchPhiếuXuấtKhoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("danhSáchPhiếuXuấtKhoToolStripMenuItem.Image")));
            this.danhSáchPhiếuXuấtKhoToolStripMenuItem.Name = "danhSáchPhiếuXuấtKhoToolStripMenuItem";
            this.danhSáchPhiếuXuấtKhoToolStripMenuItem.Size = new System.Drawing.Size(216, 25);
            this.danhSáchPhiếuXuấtKhoToolStripMenuItem.Text = "Danh sách phiếu xuất kho";
            this.danhSáchPhiếuXuấtKhoToolStripMenuItem.Click += new System.EventHandler(this.danhSáchPhiếuXuấtKhoToolStripMenuItem_Click);
            // 
            // panelManHinh
            // 
            this.panelManHinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelManHinh.Location = new System.Drawing.Point(0, 32);
            this.panelManHinh.Name = "panelManHinh";
            this.panelManHinh.Size = new System.Drawing.Size(1257, 656);
            this.panelManHinh.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(985, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // FormQuanLyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 704);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelManHinh);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormQuanLyKho";
            this.Text = "Quản Lý Kho";
            this.Load += new System.EventHandler(this.FormQuanLyKho_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem phiếuNhậpKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuXuấtKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchPhiếuNhậpKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchPhiếuXuấtKhoToolStripMenuItem;
        private System.Windows.Forms.Panel panelManHinh;
        private System.Windows.Forms.Label label1;
    }
}