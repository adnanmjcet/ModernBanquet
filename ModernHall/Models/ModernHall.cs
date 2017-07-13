namespace ModernHall.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModernHall : DbContext
    {
        public ModernHall()
            : base("name=ModernHall")
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PaymentTypetbl> PaymentTypetbls { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Package>()
                .Property(e => e.PackageName)
                .IsUnicode(false);

            modelBuilder.Entity<Package>()
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.Package)
                .HasForeignKey(e => e.PackageTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Package>()
                .HasMany(e => e.Payments)
                .WithOptional(e => e.Package)
                .HasForeignKey(e => e.PackageTypeId);

            modelBuilder.Entity<PaymentTypetbl>()
                .Property(e => e.PaymentType)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentTypetbl>()
                .HasMany(e => e.Payments)
                .WithOptional(e => e.PaymentTypetbl)
                .HasForeignKey(e => e.PaymentTypeId);
        }
    }
}
