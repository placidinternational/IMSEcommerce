using IMSBackend.Common.Common;
using IMSBackend.Domain.Entities.Award;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMSBackend.Domain.Entities.Account;
public class RegistrationOtp : BaseEntity
{
    public string Otp { get; set; }
    public bool IsExpired { get; set; }
    public DateTime ExpectedExpiryDateTime { get; set; }
    public bool IsUsed { get; set; }
    public string HashCode { get; set; }

    public Guid AccountId { get; set; }

    [ForeignKey(nameof(AccountId))]
    public Account Account { get; set; }
}

