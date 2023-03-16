namespace BaiThu6.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiSP")]
    public partial class LoaiSP
    {
        [Key]
        [Column("LoaiSP")]
        [StringLength(50)]
        public string LoaiSP1 { get; set; }

        public string Mota { get; set; }
    }
}
