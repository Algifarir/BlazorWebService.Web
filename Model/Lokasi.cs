using System.ComponentModel.DataAnnotations;

namespace BlazorServerCRUD.Web.Model
{
    public class Lokasi
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string? Nama { get; set; }
        [Required]
        [MaxLength(255)]
        public string? Alamat { get; set; }
        [Required]
        [MaxLength(255)]
        [Url]
        public string? MapsUrl { get; set; }
        [Required]
        [MaxLength(255)]
        public string? Deskripsi { get; set; }
        [Required]
        
        public bool IsArea { get; set; }

        public ICollection<Subscription> Subscriptions { get; } = new List<Subscription>();
    }
}