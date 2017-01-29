namespace RolesAdmin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        [Column("Product")]
        [StringLength(50)]
        public string Product1 { get; set; }

        [StringLength(50)]
        public string Quantity { get; set; }

        public decimal? Price { get; set; }

        [StringLength(50)]
        public string NDC { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ExpirationDate { get; set; }
    }
}
