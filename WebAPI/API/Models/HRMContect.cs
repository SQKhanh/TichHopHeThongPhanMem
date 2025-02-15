using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace API.Models
{
    public partial class HRMContect : DbContext
    {
        public HRMContect()
            : base("name=HRMContect")
        {
        }

        public virtual DbSet<SinhVien> SinhViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SinhVien>()
                .Property(e => e.code)
                .IsUnicode(false);
        }
    }
}
