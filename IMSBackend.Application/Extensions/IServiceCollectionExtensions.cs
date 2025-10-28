using IMSBackend.Application.OpenApiFilters.ApiKeyHelper;
using IMSBackend.Application.PipelineBehaviours;
using IMSBackend.Application.Contracts;
using IMSBackend.Common.Interfaces;
using IMSBackend.Common;
using Microsoft.Extensions.Configuration;
using IMSBackend.Application.Services;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using IMSBackend.Persistence.Jwt;
using MediatR;
using IMSBackend.Application.Features.CheckoutFeatures;

namespace IMSBackend.Application.Extensions;
public static class IServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationLayer(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
        services.AddScoped(typeof(IResult<>), typeof(Result<>));
        services.AddHttpClient();
        services.AddSingleton<IApiKeyValidator, ApiKeyValidator>();
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingBehaviour<,>));
        services.AddHttpContextAccessor();
        services.AddScoped<IUserContext, UserContext>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IJobTestService, JobTestService>();
        services.AddScoped<IJWTService, JWTService>();
        services.AddScoped<IPaymentService, PaymentService>();
        return services;
    }

}
