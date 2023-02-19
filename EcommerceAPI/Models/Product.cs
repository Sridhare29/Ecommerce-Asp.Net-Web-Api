using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace EcommerceAPI.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string? Image { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string ?ProductName { get; set; }
        public decimal? Price { get; set; }
    }
}
