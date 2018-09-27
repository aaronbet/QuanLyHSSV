namespace QLHSGV.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HocSinh")]
    public partial class HocSinh
    {

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(10)]
        public string TenLop { get; set; }
    }
}
