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

        public virtual DbSet<Invoice> Invoices { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Invoice>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 0);
        }
    }
}
