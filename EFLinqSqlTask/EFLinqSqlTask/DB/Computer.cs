namespace EFLinqSqlTask
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Computer : DbContext
    {
        public Computer()
            : base("name=Computer")
        {
        }

        public virtual DbSet<Laptop> Laptops { get; set; }
        public virtual DbSet<PC> PCs { get; set; }
        public virtual DbSet<Printer> Printers { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Laptop>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<Laptop>()
                .Property(e => e.price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PC>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<PC>()
                .Property(e => e.cd)
                .IsUnicode(false);

            modelBuilder.Entity<PC>()
                .Property(e => e.price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Printer>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<Printer>()
                .Property(e => e.color)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Printer>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<Printer>()
                .Property(e => e.price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.maker)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Laptops)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.PCs)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Printers)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);
        }
    }
}
