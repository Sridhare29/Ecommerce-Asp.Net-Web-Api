using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EcommerceAPI.Models
{
    public class OrderMaster
    {
        [Key]
        public long OrderMasterId { get; set; }

        [Column(TypeName = "nvarchar(75)")]
        public String ?OrderNumber { get; set; }
        public int CustomerId { get; set; }
        [JsonIgnore]
        public Customers? customers { get; set; }

        [Column(TypeName = "nvarchar(75)")]
        public String ?PaymentMethod { get; set; }
        public decimal Total { get; set; }
        public List<OrderDetails>? Details { get; set; }
    }
}
