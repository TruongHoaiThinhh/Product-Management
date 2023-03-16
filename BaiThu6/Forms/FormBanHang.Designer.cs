
namespace BaiThu6.Forms
{
    partial class FormBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanHang));
            this.panelManHinh = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.banhangMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dsbanhangMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelManHinh
            // 
            this.panelManHinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelManHinh.Location = new System.Drawing.Point(0, 33);
            this.panelManHinh.Name = "panelManHinh";
            this.panelManHinh.Size = new System.Drawing.Size(1257, 671);
            this.panelManHinh.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.banhangMenu,
            this.dsbanhangMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1257, 29);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // banhangMenu
            // 
            this.banhangMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banhangMenu.Image = ((System.Drawing.Image)(resources.GetObject("banhangMenu.Image")));
            this.banhangMenu.Name = "banhangMenu";
            this.banhangMenu.Size = new System.Drawing.Size(105, 25);
            this.banhangMenu.Text = "Bán Hàng";
            this.banhangMenu.Click += new System.EventHandler(this.banhangMenu_Click);
            // 
            // dsbanhangMenu
            // 
            this.dsbanhangMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsbanhangMenu.Image = ((System.Drawing.Image)(resources.GetObject("dsbanhangMenu.Image")));
            this.dsbanhangMenu.Name = "dsbanhangMenu";
            this.dsbanhangMenu.Size = new System.Drawing.Size(226, 25);
            this.dsbanhangMenu.Text = "Danh Sách Phiếu Bán Hàng";
            this.dsbanhangMenu.Click += new System.EventHandler(this.dsbanhangMenu_Click);
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 704);
            this.Controls.Add(this.panelManHinh);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormBanHang";
            this.Text = "Bán Hàng";
            this.Load += new System.EventHandler(this.FormBanHang_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelManHinh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem banhangMenu;
        private System.Windows.Forms.ToolStripMenuItem dsbanhangMenu;
    }
}