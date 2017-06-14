using System.Data.Entity;

namespace EFLinqSqlTask.DB
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DBConnection")
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<PC> PCs { get; set; }
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<Printer> Printers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(p => p.Model);
            modelBuilder.Entity<PC>().HasKey(p => p.Code);
            modelBuilder.Entity<Laptop>().HasKey(p => p.Code);
            modelBuilder.Entity<Printer>().HasKey(p => p.Code);

            base.OnModelCreating(modelBuilder);
        }
    }
}
