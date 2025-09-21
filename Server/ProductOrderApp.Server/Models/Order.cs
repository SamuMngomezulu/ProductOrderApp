using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SingularSystems.ProductOrderApp.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;

        [Column(TypeName = "decimal(10, 2)")]
        public decimal OrderTotal { get; set; }

        /// <summary>
        /// Navigation properties
        /// </summary>
        public Customer? Customer { get; set; }

    }
}
