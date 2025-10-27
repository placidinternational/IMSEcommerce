using IMSBackend.Domain.Entities.Account;
using IMSBackend.Domain.Entities.AccountDomain;
using IMSBackend.Domain.Entities.EventDomain;
using IMSBackend.Domain.Entities.Product;
using IMSBackend.Domain.Entities.Transactions;
using IMSBackend.Domain.Entities.Vendors;
using Microsoft.EntityFrameworkCore;

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
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<BankDetails> BankDetails { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<TicketCategory> TicketCategories { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
    }
}
