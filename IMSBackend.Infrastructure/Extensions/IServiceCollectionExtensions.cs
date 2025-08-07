using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using IMSBackend.Infrastructure.EmailService;
using IMSBackend.Common.Models;
using IMSBackend.Infrastructure.Settings;
using IMSBackend.Persistence.Extentions;
using IMSBackend.Infrastructure.MediaUploadIntegration;
using IMSBackend.Infrastrusture.MediaUploadIntegration;

namespace IMSBackend.Infrastructure.Extensions;
public static class IServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        // Register persistence layer (EF Core, Dapper, etc.)
        //services.AddPersistenceLayer(configuration);
        services.AddSQLRepository(configuration);
        services.AddServices();

        return services;
    }

    private static void AddServices(this IServiceCollection services)
    {
        services.AddOptions<EmailConfig>()
        .BindConfiguration(nameof(EmailConfig));
        services.AddOptions<EmailTemplate>()
            .BindConfiguration(nameof(EmailTemplate));
        services.AddScoped<IEmailService, IMSBackend.Infrastructure.EmailService.EmailService>();
        services.AddScoped<IInfraUnitOfWork, InfraUnitOfWork>();
        services.AddScoped<IMediaUpload, CloudinaryMediaUpload>();

        services.AddOptions<TwiloSettings>()
            .BindConfiguration(nameof(TwiloSettings));

        services.AddOptions<CloudinarySettings>()
         .BindConfiguration(nameof(CloudinarySettings));


    }
}
