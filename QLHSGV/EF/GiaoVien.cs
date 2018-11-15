namespace QLHSGV.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiaoVien")]
    public partial class GiaoVien
    {
        [Key]
        [StringLength(10)]
        public string MaGV { get; set; }

        [Required]
        [StringLength(50)]
        public string HoTen { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [StringLength(10)]
        public string GT { get; set; }

        [StringLength(20)]
        public string DiaChi { get; set; }

        [StringLength(20)]
        public string MonHoc { get; set; }
    }
}
