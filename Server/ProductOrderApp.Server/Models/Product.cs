using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SingularSystems.ProductOrderApp.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Product Name cannot be longer than 100 characters")]
        public string ProductName { get; set; } = string.Empty;

        [Required]
        [StringLength(500, ErrorMessage = "Product Description cannot be longer than 500 characters")]
        public string ProductDescription { get; set; } = string.Empty;


        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal ProductPrice { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "Image URL cannot be longer than 200 characters")]
        public string ImageUrl { get; set; } = string.Empty;

    }
}
