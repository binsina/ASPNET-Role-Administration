namespace RolesAdmin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sale
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(50)]
        public string ProductSold { get; set; }

        [StringLength(50)]
        public string Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? SalePrice { get; set; }

        [StringLength(50)]
        public string NDC { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ExpirationDate { get; set; }
    }
}
