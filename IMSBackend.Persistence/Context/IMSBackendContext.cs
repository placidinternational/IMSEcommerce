using Microsoft.EntityFrameworkCore;
using IMSBackend.Domain.Entities.Account;
using IMSBackend.Domain.Entities.Award;
using IMSBackend.Domain.Entities.Transactions;
using IMSBackend.Domain.Entities.BusinessPitches;

namespace IMSBackend.Persistence.Context
{
    public class IMSBackendContext : DbContext
    {
        public IMSBackendContext(DbContextOptions<IMSBackendContext> options) : base(options)
        {
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<ForgotPasswordOtp> ForgotPasswordOtps { get; set; }
        public DbSet<RegistrationOtp> RegistrationOtps { get; set; }
        public DbSet<Nominee> Nominees { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<BusinessPitch> BusinessPitch { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<PitchPrice> PitchPrice { get; set; }
        public DbSet<ExibitionStand> ExibitionStands { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Category>().HasData(
            new Category { Id = Guid.NewGuid(), Name = "African Women’s Fashion Talent of the Year", Award=true },
            new Category { Id = Guid.NewGuid(), Name = "Outstanding Fashion Entrepreneur of the Year", Award = true },
            new Category { Id = Guid.NewGuid(), Name = "Beauty and Personal Care Entrepreneur of the Year" , Award = true },
            new Category { Id = Guid.NewGuid(), Name = "Outstanding Beverage Brand of the Year", Award = true },
            new Category { Id = Guid.NewGuid(), Name = "Top Rated, Dessert and Finger Food" , Award = true },
            new Category { Id = Guid.NewGuid(), Name = "Most Creative Baker", Award = true },
            new Category { Id = Guid.NewGuid(), Name = "Most Innovative Product of the Year" , Award = true },
            new Category { Id = Guid.NewGuid(), Name = "Best Indigenous Snack brand", Award = true },
            new Category { Id = Guid.NewGuid(), Name = "Outstanding Quality Hair Entrepreneur of the Year" , Award = true },
            new Category { Id = Guid.NewGuid(), Name = "Craft Mastery Award", Award = true },
            new Category { Id = Guid.NewGuid(), Name = "Best Emerging Food brand of the year" , Award = true },
            new Category { Id = Guid.NewGuid(), Name = "Creative Bridal Hairstylist of the Year", Award = true },
            new Category { Id = Guid.NewGuid(), Name = "Top Rated, Event Catering Brand" , Award = true },
            new Category { Id = Guid.NewGuid(), Name = "Fastest Growing Perfume Business", Award = true },
            new Category { Id = Guid.NewGuid(), Name = "Outstanding Female Fashion Designer of the Year" , Award = true },
            new Category { Id = Guid.NewGuid(), Name = "Outstanding Fenalr Entrepreneur in Agro-Retail", Award = true },
            new Category { Id = Guid.NewGuid(), Name = "Textile Manufacturing Brand of the Year" , Award = true },
            new Category { Id = Guid.NewGuid(), Name = "Outstanding Female Entrepreneur of the Year", Award = true },
            new Category { Id = Guid.NewGuid(), Name = "Fabric Vendor of the Year" , Award = true },
            new Category { Id = Guid.NewGuid(), Name = "Best Emerging Entrepreneur of the Year", Award = true },
            new Category { Id = Guid.NewGuid(), Name = "Best Emerging Fashion Retail Brand of the Year", Award = true },
            new Category { Id = Guid.NewGuid(), Name = "Outstanding Full-Service Beauty SPA", Award = true },
            new Category { Id = Guid.NewGuid(), Name = "Media and Entertainment Brand of the Year", Award = true },
            new Category { Id = Guid.NewGuid(), Name = "Creative Branding and Printing Excellence", Award = true },
            new Category { Id = Guid.NewGuid(), Name = "Health and Wellness Brand of the Year", Award = true },
            new Category { Id = Guid.NewGuid(), Name = "Brand Evolution Excellence Award", Award = true }
        );
            modelBuilder.Entity<PitchPrice>().HasData(
                new PitchPrice
                {
                    Id = Guid.NewGuid(),
                    Price = 15000
                });
        }
    }
}
