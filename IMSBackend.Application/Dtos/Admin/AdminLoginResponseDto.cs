using Newtonsoft.Json;

namespace IMSBackend.Application.Dtos.Admin;
public class AdminLoginResponseDto
{
    [JsonProperty("access_token")]
    public string AccessToken { get; set; }

    [JsonProperty("refresh_token")]
    public string RefreshToken { get; set; }

    [JsonProperty("expires_in")]
    public int ExpiresIn { get; set; }

    [JsonProperty("userId")]
    public Guid UserId { get; set; }

    [JsonProperty("firstName")]
    public string FirstName { get; set; }

    [JsonProperty("role")]
    public string Role { get; set; }

    [JsonProperty("emailAddress")]
    public string EmailAddress { get; set; }
}
