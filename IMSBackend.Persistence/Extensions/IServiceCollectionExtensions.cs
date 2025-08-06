using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using IMSBackend.Domain.Common;
using IMSBackend.Domain.Shared;
using IMSBackend.Domain.UseCases;
using IMSBackend.Persistence.Context;
using IMSBackend.Persistence.Repositories;
using IMSBackend.Persistence.Repositories.UseCases;

namespace IMSBackend.Persistence.Extentions
{
    public static class IServiceCollectionExtensions
    {
        private const int RetryCount = 3;
        private const double RetryInSeconds = 1.1;
        public static IServiceCollection AddPersistenceLayer(this IServiceCollection services)
        {
            services.AddRepositories();
            return services;
        }

        public static IServiceCollection AddSQLRepository(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString(nameof(IMSBackendContext));
            services.AddDbContext<IMSBackendContext>(options =>
            {
                //UseNpgsql
                options.UseSqlServer(connectionString,
                opt =>
                opt.EnableRetryOnFailure(
                   RetryCount,
                    TimeSpan.FromSeconds(
                        RetryInSeconds),
                    null));
            }, ServiceLifetime.Scoped);

            return services;
        }
        private static void AddRepositories(this IServiceCollection services)
        {
            services
                  .AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork))
                  .AddScoped(typeof(IRepository<>), typeof(Repository<>))
                  .AddScoped<IRegistrationOtpRepository, RegistrationOtpRepository>()
                  .AddScoped<IForgotPasswordOtpRepository, ForgotPasswordOtpRepository>()
                  .AddScoped<IAccountRepository, AccountRepository>();
        }
    }
}
