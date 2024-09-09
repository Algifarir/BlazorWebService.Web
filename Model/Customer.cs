using System.ComponentModel.DataAnnotations;

namespace BlazorServerCRUD.Web.Model
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string? Nama { get; set; }
        [Required]
        [MaxLength(255)]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [MaxLength(255)]
        [Phone]
        public string? NoTelp { get; set; }
        [Required]
        [MaxLength(255)]
        public string? JenisDok { get; set; }
        [Required]
        [MaxLength(255)]
        public string? NoDok { get; set; }
        [Required]
        [MaxLength(255)]
        public string? ImgDok { get; set; }
        [Required]
        [MaxLength(255)]
        public string? JenisCustomer { get; set; }

        public ICollection<Subscription> Subscriptions { get; } = new List<Subscription>();
    }
}