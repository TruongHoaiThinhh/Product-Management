
namespace BaiThu6.Forms
{
    partial class FormBaoCaoThongKe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhanvienReport = new System.Windows.Forms.ToolStripMenuItem();
            this.nhomspMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.loaispMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.panelManHinh = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelManHinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhanvienReport,
            this.nhomspMenu,
            this.loaispMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1257, 29);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhanvienReport
            // 
            this.nhanvienReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhanvienReport.Name = "nhanvienReport";
            this.nhanvienReport.Size = new System.Drawing.Size(234, 25);
            this.nhanvienReport.Text = "Báo Cáo Danh Sách Nhân Viên";
            this.nhanvienReport.Click += new System.EventHandler(this.nhanvienReport_Click);
            // 
            // nhomspMenu
            // 
            this.nhomspMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhomspMenu.Name = "nhomspMenu";
            this.nhomspMenu.Size = new System.Drawing.Size(189, 25);
            this.nhomspMenu.Text = "Thống Kê Hàng Tồn Kho";
            this.nhomspMenu.Click += new System.EventHandler(this.nhomspMenu_Click);
            // 
            // loaispMenu
            // 
            this.loaispMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loaispMenu.Name = "loaispMenu";
            this.loaispMenu.Size = new System.Drawing.Size(167, 25);
            this.loaispMenu.Text = "Thống Kê Doanh Thu";
            this.loaispMenu.Click += new System.EventHandler(this.loaispMenu_Click);
            // 
            // panelManHinh
            // 
            this.panelManHinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelManHinh.Controls.Add(this.label1);
            this.panelManHinh.Location = new System.Drawing.Point(0, 33);
            this.panelManHinh.Name = "panelManHinh";
            this.panelManHinh.Size = new System.Drawing.Size(1257, 671);
            this.panelManHinh.TabIndex = 7;
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
            // FormBaoCaoThongKe
            // 
            this.ClientSize = new System.Drawing.Size(1257, 704);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelManHinh);
            this.Name = "FormBaoCaoThongKe";
            this.Text = "Báo Cáo - Thống Kê";
            this.Load += new System.EventHandler(this.FormBaoCaoThongKe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelManHinh.ResumeLayout(false);
            this.panelManHinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhanvienReport;
        private System.Windows.Forms.ToolStripMenuItem nhomspMenu;
        private System.Windows.Forms.ToolStripMenuItem loaispMenu;
        private System.Windows.Forms.Panel panelManHinh;
        private System.Windows.Forms.Label label1;
    }
}