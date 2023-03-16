namespace BaiThu6.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPhieuXuat")]
    public partial class ChiTietPhieuXuat
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MaPX { get; set; }

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

        public string GhiChu { get; set; }
    }
}
