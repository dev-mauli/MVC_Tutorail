namespace VidlyTutorial.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model145 : DbContext
    {
        public Model145()
            : base("name=Model145")
        {
        }

        public virtual DbSet<edu_Sub_Institute> edu_Sub_Institute { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.trust_id)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.sub_institute_id)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.sub_institute_name)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.sub_institute_type)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.address_line1)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.address_line2)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.pincode)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.contact_no)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.email_id)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.website)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.url)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.doc_path)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.person_fname)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.person_mname)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.person_lname)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.person_contact)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.person_email)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.total_students)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.total_staff)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.approved_by)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.medium)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.standard)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.extra1)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.extra2)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.extra3)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.extra4)
                .IsUnicode(false);

            modelBuilder.Entity<edu_Sub_Institute>()
                .Property(e => e.extra5)
                .IsUnicode(false);
        }
    }
}
