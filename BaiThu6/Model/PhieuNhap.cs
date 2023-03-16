namespace BaiThu6.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuNhap")]
    public partial class PhieuNhap
    {
        [Key]
        [StringLength(50)]
        public string MaPhieuNhap { get; set; }

        public DateTime? NgayLap { get; set; }

        [StringLength(50)]
        public string TenNCC { get; set; }

        public double? TongTien { get; set; }

        public string GhiChu { get; set; }

        [StringLength(50)]
        public string NgLap { get; set; }

        [StringLength(50)]
        public string HTTT { get; set; }

        [StringLength(50)]
        public string Kho { get; set; }
    }
}
