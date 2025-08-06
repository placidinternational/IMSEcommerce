using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace IMSBackend.Application.OpenApiFilters.ApiKeyHelper;

public class ApiKeyMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IConfiguration _configuration;
    public ApiKeyMiddleware(RequestDelegate next, IConfiguration configuration)
    {
        _next = next;
        _configuration = configuration;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var expectedApiKey = _configuration.GetValue<string>("ApiKeys:MyApiKey");

        if (!context.Request.Headers.TryGetValue("X-API-KEY", out var apiKey))
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync("API key missing");
            return;
        }

        if (apiKey != expectedApiKey)
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync("Invalid API key");
            return;
        }

        await _next(context);
    }
}
