using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Models
{
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; }

            [Column(TypeName="nvarchar(100)")]
            public string ?CustomerName { get; set; }
            public string? MobileNumber { get; set; }

            [Required, EmailAddress]
            public string? Email { get; set; }
    }
}
