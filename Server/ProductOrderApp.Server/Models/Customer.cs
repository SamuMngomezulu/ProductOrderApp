using System.ComponentModel.DataAnnotations;


namespace SingularSystems.ProductOrderApp.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50, ErrorMessage = "First Name cannot be longer than 50 characters")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50, ErrorMessage = "Last Name cannot be longer than 50 characters")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Address Type is required")]
        public string AddressType { get; set; } = string.Empty;

        [Required(ErrorMessage = "Street Address is required")]
        [StringLength(100, ErrorMessage = "Street Address cannot be longer than 100 characters")]
        public string StreetAddress { get; set; } = string.Empty;

        [Required(ErrorMessage = "Suburb is required")]
        [StringLength(50, ErrorMessage = "Suburb cannot be longer than 50 characters")]
        public string Suburb { get; set; } = string.Empty;

        [Required(ErrorMessage = "City/Town is required")]
        [StringLength(50, ErrorMessage = "City/Town cannot be longer than 50 characters")]
        public string CityTown { get; set; } = string.Empty;

        [Required(ErrorMessage = "Postal Code is required")]
        [StringLength(20, ErrorMessage = "Postal Code cannot be longer than 20 characters")]
        public string PostalCode { get; set; } = string.Empty;

    }
}
