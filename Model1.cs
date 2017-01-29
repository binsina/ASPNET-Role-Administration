namespace RolesAdmin.Models
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

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Purchase>()
                .Property(e => e.PurchasePrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Sale>()
                .Property(e => e.SalePrice)
                .HasPrecision(19, 4);
        }
    }
}
