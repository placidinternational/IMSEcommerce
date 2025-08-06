using IMSBackend.Common.Common;

namespace IMSBackend.Domain.Entities.Account;
public class ForgotPasswordOtp : BaseEntity
{
    public Guid UserId { get; set; }
    public string Otp { get; set; }
    public bool IsExpired { get; set; }
    public DateTime ExpectedExpiryDateTime { get; set; }
    public bool IsUsed { get; set; }

    public string HashCode { get; set; }
    public string EmailAddress { get; set; }
}
