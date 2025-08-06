namespace IMSBackend.Application.OpenApiFilters.ApiKeyHelper;

public interface IApiKeyValidator
{
    bool Validate(string apiKey);
}
