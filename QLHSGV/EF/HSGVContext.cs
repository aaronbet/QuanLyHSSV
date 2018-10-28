namespace QLHSGV.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HSGVContext : DbContext
    {
        public HSGVContext()
            : base("name=HSGVContext")
        {
        }

        public virtual DbSet<GiaoVien> GiaoViens { get; set; }
        public virtual DbSet<HocSinh> HocSinhs { get; set; }
        public virtual DbSet<LopHoc> LopHocs { get; set; }
        public virtual DbSet<ThongTinGiangDay> ThongTinGiangDays { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
