namespace IMSBackend.Application.Dtos.Auth.Responses;
public class TwoFactorAuthenticationResponse
{
    public string Key { get; set; }
    public string QrCodeUrl { get; set; }
    public string ManualCode { get; set; }
    public string EmailAddress { get; set; }
}
