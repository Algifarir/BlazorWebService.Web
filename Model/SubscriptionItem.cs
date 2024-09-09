using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BlazorServerCRUD.Web.Model
{
    public class SubscriptionItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ProdukId { get; set; }
        [Required]
        public int TeleponId { get; set; }
        [Required]
        public int Harga { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }
        [Required]
        public string? Sla { get; set; }

        [ForeignKey("Subscription")]
        public int SubscriptionId { get; set; }

        [JsonIgnore]
        public Subscription? Subscription { get; set; }
    }
}