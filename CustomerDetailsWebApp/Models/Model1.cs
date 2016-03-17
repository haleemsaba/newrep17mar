namespace CustomerDetailsWebApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<customer> customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<customer>()
                .Property(e => e.CustName)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}
