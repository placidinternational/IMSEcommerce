using Newtonsoft.Json;
using IMSBackend.Application.Dtos.Admin;

namespace IMSBackend.Application.Dtos.Auth;

public class LoginResponseDto
{
    public string AccessToken { get; set; }
    public string RefreshToken { get; set; }
    public int ExpiresIn { get; set; }
    public string Email { get; set; }
    public bool IsRegistrationCompleted { get; set; }
    public Guid UserId { get; set; }
    public string AgentNumber { get; set; }
    public string CompanyName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string  Address { get; set; }
    public string PhoneNumber { get; set; }
    public string UserType { get; set; }
    public List<PermissionObject>? permissionObjects { get; set; }

}

public class InitialLoginResponseDto
{
    [JsonProperty("otp_hash")]
    public string OtpHash { get; set; }

    [JsonProperty("user_id")]
    public Guid UserId { get; set; }

    [JsonProperty("last_login_date")]
    public DateTime LastLoginDate { get; set; }
}
