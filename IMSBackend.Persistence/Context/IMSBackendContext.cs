using IMSBackend.Domain.Entities.Account;
using IMSBackend.Domain.Entities.Transactions;
using IMSBackend.Domain.Entities.Vendors;
using Microsoft.EntityFrameworkCore;

namespace IMSBackend.Persistence.Context
{
    public class IMSEcommerceContext : DbContext
    {
        public IMSEcommerceContext(DbContextOptions<IMSEcommerceContext> options) : base(options)
        {

        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<ForgotPasswordOtp> ForgotPasswordOtps { get; set; }
        public DbSet<RegistrationOtp> RegistrationOtps { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<VendorCategory> VendorCategories { get; set; }
        public DbSet<BankDetails> BankDetails { get; set; }
    }
}
