using IMSBackend.Common.Common;
using IMSBackend.Common.Enums;

namespace IMSBackend.Domain.Entities.Account;
public sealed class Account : BaseEntity
{
    public string? FullName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public string EmailAddress { get; set; }
    public byte[] PasswordHashed { get; set; }
    public byte[] PasswordSalt { get; set; }
    public StatusEnum StatusEnum { get; set; }
    public bool IsEmailVerified { get; set; } = false;
    public bool IsPhoneNumberVerified { get; set; } = false;
    public bool IsFirstLogin {  get; set; } = false;
    public DateTime? EmailValidationDate { get; set; }
    public DateTime? PhoneValidationDate { get; set; }
    public DateTime? LastLogin { get; set; }
    public string? RefreshToken { get; set; }
    public UserTypeEnum? UserType { get; set; }
    
}