namespace IMSBackend.Application.Dtos.Auth.Requests;
public class AddReferralRequest
{
    public string ReferralCode { get; set; }
    public Guid UserId { get; set; }
}
