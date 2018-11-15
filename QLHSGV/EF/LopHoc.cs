namespace QLHSGV.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LopHoc")]
    public partial class LopHoc
    {
        [Key]
        [StringLength(10)]
        public string TenLop { get; set; }

        public int QSo { get; set; }
    }
}
