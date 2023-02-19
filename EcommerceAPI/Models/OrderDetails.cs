using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EcommerceAPI.Models
{
    public class OrderDetails
    {
        [Key]
        public long OrderDetailId { get; set; }
        public long OrderMasterId { get; set; }
        public int ProductId { get; set; }
        public int ProductPrice { get; set; }
        public int Quantity { get; set; }
        [JsonIgnore]
        public Product ?product { get; set; }
    }
}
        