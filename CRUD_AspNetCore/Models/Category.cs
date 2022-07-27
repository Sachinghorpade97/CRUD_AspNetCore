using System.ComponentModel.DataAnnotations;

namespace CRUD_AspNetCore.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Manufacturer { get; set; }
        [Range(1, 100, ErrorMessage = "Shipping Number must be between 1 and 100 only!!")]
        public int ShippingNo { get; set; }
        public int RetailPrice { get; set; }
    }
}
