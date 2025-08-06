using Microsoft.Extensions.Configuration;

namespace IMSBackend.Application.OpenApiFilters.ApiKeyHelper;

public class ApiKeyValidator : IApiKeyValidator
{
    private readonly IConfiguration _configuration;

    public ApiKeyValidator(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public bool Validate(string apiKey)
    {
        // Retrieve the expected API key from the app settings
        var expectedApiKey = _configuration.GetValue<string>("ApiKeys:MyApiKey");

        // Compare the provided API key with the expected API key
        return apiKey == expectedApiKey;
    }
}
