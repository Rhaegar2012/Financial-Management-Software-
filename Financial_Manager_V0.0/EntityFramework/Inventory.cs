namespace Financial_Manager_V0._0.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inventory")]
    public partial class Inventory
    {
        [Key]
        public int ItemNo { get; set; }

        public int? ItemID { get; set; }

        [StringLength(255)]
        public string ItemName { get; set; }

        public int? ItemQuantity { get; set; }
    }
}
