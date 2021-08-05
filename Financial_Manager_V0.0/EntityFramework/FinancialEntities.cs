namespace Financial_Manager_V0._0.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FinancialEntities : DbContext
    {
        public FinancialEntities()
            : base("name=FinancialEntities")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.ClientName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.ClientEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.ClientAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.ClientCity)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.ClientZIP)
                .IsUnicode(false);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 0);
        }
    }
}
