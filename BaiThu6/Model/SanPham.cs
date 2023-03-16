namespace BaiThu6.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]
        [StringLength(50)]
        public string MaSP { get; set; }

        [Required]
        [StringLength(50)]
        public string TenSP { get; set; }

        [StringLength(50)]
        public string KichThuoc { get; set; }

        [StringLength(50)]
        public string MauSac { get; set; }

        [StringLength(50)]
        public string BaoHanh { get; set; }

        [StringLength(50)]
        public string NSX { get; set; }

        public double? GiaNhap { get; set; }

        public double? GiaBan { get; set; }

        public double? SoLuong { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        public string MoTa { get; set; }

        public byte[] HinhAnh { get; set; }

        [Required]
        [StringLength(50)]
        public string NhomSP { get; set; }

        [Required]
        [StringLength(50)]
        public string LoaiSP { get; set; }
    }
}
