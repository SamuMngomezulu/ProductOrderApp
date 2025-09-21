using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SingularSystems.ProductOrderApp.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }

        [ForeignKey("OrderId")]
        public int OrderId { get; set; }

        [ForeignKey("ProductId")]
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        /// <summary>
        /// Navigation properties
        /// <summary>

        public Order? Order { get; set; }
        public Product? Product { get; set; }

    }
}
