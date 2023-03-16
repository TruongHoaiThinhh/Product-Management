namespace BaiThu6.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhomSP")]
    public partial class NhomSP
    {
        [Key]
        [Column("NhomSP")]
        [StringLength(50)]
        public string NhomSP1 { get; set; }

        public string Mota { get; set; }
    }
}
