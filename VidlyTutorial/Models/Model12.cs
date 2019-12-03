namespace VidlyTutorial.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model12 : DbContext
    {
        public Model12()
            : base("name=Model12")
        {
        }

        public virtual DbSet<academic_year> academic_year { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<academic_year>()
                .Property(e => e.AYID)
                .IsUnicode(false);

            modelBuilder.Entity<academic_year>()
                .Property(e => e.Duration)
                .IsUnicode(false);

            modelBuilder.Entity<academic_year>()
                .Property(e => e.Remark)
                .IsUnicode(false);
        }
    }
}
