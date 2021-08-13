namespace Financial_Manager_V0._0.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        public int ClientID { get; set; }

        [StringLength(255)]
        public string ClientName { get; set; }

        [StringLength(255)]
        public string ClientEmail { get; set; }

        public int? ClientPhone { get; set; }

        [StringLength(255)]
        public string ClientAddress { get; set; }

        [StringLength(255)]
        public string ClientCity { get; set; }

        [StringLength(255)]
        public string ClientZIP { get; set; }
    }
}
