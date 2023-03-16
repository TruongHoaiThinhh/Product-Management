namespace BaiThu6.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPhieuMua")]
    public partial class ChiTietPhieuMua
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MaPM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MaSP { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string TenSP { get; set; }

        public double? Gia { get; set; }

        public double? SoLuong { get; set; }

        public double? ThanhTien { get; set; }

        public double? VAT { get; set; }

        public double? CK { get; set; }

        public string GhiChu { get; set; }

        public double? TienVAT { get; set; }

        public double? TienCK { get; set; }
    }
}
