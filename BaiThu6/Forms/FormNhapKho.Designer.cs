
namespace BaiThu6.Forms
{
    partial class FormNhapKho
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDT1 = new System.Windows.Forms.TextBox();
            this.txtTenDT1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLoaiDT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRam = new System.Windows.Forms.ComboBox();
            this.cmbBoNho = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btThem = new System.Windows.Forms.Button();
            this.dgvSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBoNhoTrong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLoaiDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDanhSachDT = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Điện Thoại:";
            // 
            // txtMaDT1
            // 
            this.txtMaDT1.Location = new System.Drawing.Point(115, 25);
            this.txtMaDT1.Name = "txtMaDT1";
            this.txtMaDT1.Size = new System.Drawing.Size(274, 22);
            this.txtMaDT1.TabIndex = 1;
            // 
            // txtTenDT1
            // 
            this.txtTenDT1.Location = new System.Drawing.Point(115, 51);
            this.txtTenDT1.Name = "txtTenDT1";
            this.txtTenDT1.Size = new System.Drawing.Size(274, 22);
            this.txtTenDT1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Điện Thoại :";
            // 
            // cmbLoaiDT
            // 
            this.cmbLoaiDT.FormattingEnabled = true;
            this.cmbLoaiDT.Items.AddRange(new object[] {
            "Iphone",
            "Android",
            "Phổ Thông"});
            this.cmbLoaiDT.Location = new System.Drawing.Point(115, 77);
            this.cmbLoaiDT.Name = "cmbLoaiDT";
            this.cmbLoaiDT.Size = new System.Drawing.Size(274, 24);
            this.cmbLoaiDT.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loại Điện Thoại :";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(115, 184);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(274, 22);
            this.txtSoLuong.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(6, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số Lượng :";
            // 
            // cmbRam
            // 
            this.cmbRam.FormattingEnabled = true;
            this.cmbRam.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "8",
            "12"});
            this.cmbRam.Location = new System.Drawing.Point(115, 104);
            this.cmbRam.Name = "cmbRam";
            this.cmbRam.Size = new System.Drawing.Size(274, 24);
            this.cmbRam.TabIndex = 8;
            // 
            // cmbBoNho
            // 
            this.cmbBoNho.FormattingEnabled = true;
            this.cmbBoNho.Items.AddRange(new object[] {
            "8",
            "16",
            "32",
            "64",
            "128",
            "256",
            "512"});
            this.cmbBoNho.Location = new System.Drawing.Point(115, 131);
            this.cmbBoNho.Name = "cmbBoNho";
            this.cmbBoNho.Size = new System.Drawing.Size(274, 24);
            this.cmbBoNho.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(6, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "RAM :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(6, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bộ Nhớ Trong :";
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(115, 158);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(274, 22);
            this.txtTien.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(6, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Giá Tiền :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbBoNho);
            this.groupBox1.Controls.Add(this.cmbRam);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbLoaiDT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenDT1);
            this.groupBox1.Controls.Add(this.txtMaDT1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 224);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Điện Thoại";
            // 
            // btThem
            // 
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(21, 242);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(89, 25);
            this.btThem.TabIndex = 4;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dgvSoLuong
            // 
            this.dgvSoLuong.HeaderText = "Số Lượng Còn";
            this.dgvSoLuong.Name = "dgvSoLuong";
            // 
            // dgvGiaTien
            // 
            this.dgvGiaTien.HeaderText = "Giá Tiền";
            this.dgvGiaTien.Name = "dgvGiaTien";
            // 
            // dgvBoNhoTrong
            // 
            this.dgvBoNhoTrong.HeaderText = "Bộ Nhớ Trong";
            this.dgvBoNhoTrong.Name = "dgvBoNhoTrong";
            // 
            // dgvRam
            // 
            this.dgvRam.HeaderText = "RAM";
            this.dgvRam.Name = "dgvRam";
            // 
            // dgvLoaiDT
            // 
            this.dgvLoaiDT.HeaderText = "Loại Điện Thoại";
            this.dgvLoaiDT.Name = "dgvLoaiDT";
            // 
            // dgvTenDT
            // 
            this.dgvTenDT.HeaderText = "Tên Điện Thoại";
            this.dgvTenDT.Name = "dgvTenDT";
            this.dgvTenDT.Width = 170;
            // 
            // dgvMaDT
            // 
            this.dgvMaDT.HeaderText = "Mã Điện Thoại";
            this.dgvMaDT.Name = "dgvMaDT";
            // 
            // dgvDanhSachDT
            // 
            this.dgvDanhSachDT.AllowUserToAddRows = false;
            this.dgvDanhSachDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaDT,
            this.dgvTenDT,
            this.dgvLoaiDT,
            this.dgvRam,
            this.dgvBoNhoTrong,
            this.dgvGiaTien,
            this.dgvSoLuong});
            this.dgvDanhSachDT.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDanhSachDT.Location = new System.Drawing.Point(420, 12);
            this.dgvDanhSachDT.Name = "dgvDanhSachDT";
            this.dgvDanhSachDT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvDanhSachDT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachDT.Size = new System.Drawing.Size(34, 32);
            this.dgvDanhSachDT.TabIndex = 5;
            // 
            // FormNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 534);
            this.Controls.Add(this.dgvDanhSachDT);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormNhapKho";
            this.Text = "FormNhapKho";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDT1;
        private System.Windows.Forms.TextBox txtTenDT1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLoaiDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbRam;
        private System.Windows.Forms.ComboBox cmbBoNho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBoNhoTrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRam;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLoaiDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaDT;
        private System.Windows.Forms.DataGridView dgvDanhSachDT;
    }
}