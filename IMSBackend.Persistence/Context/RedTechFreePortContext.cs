using Microsoft.EntityFrameworkCore;
using IMSBackend.Domain.Entities.Account;
using IMSBackend.Domain.Entities.Award;

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
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = Guid.NewGuid(),
                Name = "Technology",
            });
        }
    }
}
