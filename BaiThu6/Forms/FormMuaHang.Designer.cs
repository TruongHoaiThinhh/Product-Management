
namespace BaiThu6.Forms
{
    partial class FormMuaHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMuaHang));
            this.panelManHinh = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.muahangMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.nccMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
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
            this.muahangMenu,
            this.nccMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1257, 29);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // muahangMenu
            // 
            this.muahangMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muahangMenu.Image = ((System.Drawing.Image)(resources.GetObject("muahangMenu.Image")));
            this.muahangMenu.Name = "muahangMenu";
            this.muahangMenu.Size = new System.Drawing.Size(110, 25);
            this.muahangMenu.Text = "Mua Hàng";
            this.muahangMenu.Click += new System.EventHandler(this.muahangMenu_Click);
            // 
            // nccMenu
            // 
            this.nccMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nccMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nccMenu.Image = ((System.Drawing.Image)(resources.GetObject("nccMenu.Image")));
            this.nccMenu.Name = "nccMenu";
            this.nccMenu.Size = new System.Drawing.Size(227, 25);
            this.nccMenu.Text = "Danh sách phiếu mua hàng";
            this.nccMenu.Click += new System.EventHandler(this.nccMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(982, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // FormMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 704);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelManHinh);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMuaHang";
            this.Text = "Mua Hàng";
            this.Load += new System.EventHandler(this.FormMuaHang_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelManHinh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem muahangMenu;
        private System.Windows.Forms.ToolStripMenuItem nccMenu;
        private System.Windows.Forms.Label label1;
    }
}