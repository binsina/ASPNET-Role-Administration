namespace RolesAdmin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Purchase")]
    public partial class Purchase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(50)]
        public string Product { get; set; }

        [StringLength(50)]
        public string Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? PurchasePrice { get; set; }

        [StringLength(50)]
        public string NDC { get; set; }

        [StringLength(50)]
        public string Vendor { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ExpirationDate { get; set; }

        public int? Discount { get; set; }
    }
}
