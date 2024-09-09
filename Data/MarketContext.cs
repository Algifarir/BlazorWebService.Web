using Microsoft.EntityFrameworkCore;
using BlazorServerCRUD.Web.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BlazorServerCRUD.Web.Data
{
    public class MarketContext : IdentityDbContext<ApplicationUser>
    {
        public MarketContext(DbContextOptions<MarketContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Lokasi> Lokasi { get; set; }

        public DbSet<Subscription> Subscriptions { get; set; }

        public DbSet<SubscriptionItem> SubscriptionItems { get; set; }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Customer and Subscription relationship
            modelBuilder.Entity<Subscription>()
                .HasOne(e => e.Customer)
                .WithMany(e => e.Subscriptions)
                .HasForeignKey(e => e.CustomerId)
                .IsRequired();

            // Lokasi and Subscription relationship
            modelBuilder.Entity<Subscription>()
                .HasOne(e => e.Lokasi)
                .WithMany(e => e.Subscriptions)
                .HasForeignKey(e => e.LokasiId)
                .IsRequired();
                
            modelBuilder.Entity<SubscriptionItem>()
                .HasOne(e => e.Subscription)
                .WithMany(e => e.SubscriptionItems)
                .HasForeignKey(e => e.SubscriptionId)
                .IsRequired();
                    

            
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = 1,
                    Nama = "John Doe",
                    Email = "john.doe@example.com",
                    NoTelp = "123456789",
                    JenisDok = "KTP",
                    NoDok = "1234567890",
                    ImgDok = "john_doe_ktp.png",
                    JenisCustomer = "Regular"
                },
                new Customer
                {
                    Id = 2,
                    Nama = "Jane Smith",
                    Email = "jane.smith@example.com",
                    NoTelp = "987654321",
                    JenisDok = "SIM",
                    NoDok = "0987654321",
                    ImgDok = "jane_smith_sim.png",
                    JenisCustomer = "VIP"
                }
            );
        }
    }
}