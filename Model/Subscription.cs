using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BlazorServerCRUD.Web.Model
{
    public class Subscription
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string? NoKontak { get; set; }
        [Required]
        [MaxLength(255)]
        public string? Status { get; set; }
        [Required]
        public DateTime TglAwal { get; set; }
        [Required]
        public DateTime TglAkhir { get; set; }
        [Required]
        public bool IsPpn { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [JsonIgnore]
        public Customer? Customer { get; set; }

        [ForeignKey("Lokasi")]
        public int LokasiId { get; set; }

        [JsonIgnore]
        public Lokasi? Lokasi { get; set; }

        public ICollection<SubscriptionItem> SubscriptionItems { get; set;} = new List<SubscriptionItem>();
    }
}