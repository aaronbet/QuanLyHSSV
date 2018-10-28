namespace QLHSGV.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinGiangDay")]
    public partial class ThongTinGiangDay
    {
        [Key]
        [StringLength(10)]
        public string MaKip { get; set; }

        [Required]
        [StringLength(10)]
        public string MaGV { get; set; }

        [Required]
        [StringLength(10)]
        public string TenLop { get; set; }

        [Required]
        [StringLength(20)]
        public string MonHoc { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngay { get; set; }

        public int SoTiet { get; set; }
    }
}
