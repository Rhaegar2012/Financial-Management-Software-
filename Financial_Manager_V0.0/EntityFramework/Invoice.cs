namespace Financial_Manager_V0._0.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Invoice")]
    public partial class Invoice
    {
        public int InvoiceID { get; set; }

        public int? InvoiceNo { get; set; }

        [StringLength(50)]
        public string ClientName { get; set; }

        [StringLength(50)]
        public string AccountType { get; set; }

        [StringLength(50)]
        public string ItemName { get; set; }

        public int? Quantity { get; set; }

        public decimal? UnitPrice { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }
    }
}
