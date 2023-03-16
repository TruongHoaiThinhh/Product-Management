namespace BaiThu6.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhaCungCap")]
    public partial class NhaCungCap
    {
        [Key]
        [StringLength(50)]
        public string MaNCC { get; set; }

        [Required]
        [StringLength(50)]
        public string TenNCC { get; set; }

        [StringLength(50)]
        public string Diachi { get; set; }

        [StringLength(50)]
        public string Stk { get; set; }

        [StringLength(11)]
        public string Dt1 { get; set; }

        [StringLength(11)]
        public string Dt2 { get; set; }

        public string Email { get; set; }

        [StringLength(50)]
        public string Website { get; set; }

        public string Mota { get; set; }
    }
}
