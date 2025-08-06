namespace IMSBackend.Application.Dtos.Auth.Requests;

public class UserEmailRequestModel
{
    public string Email { get; set; }
    public string OtpCode { get; set; }
}

public class UserEmailResendequestModel
{
    public string Email { get; set; }
}

public class SetPasswordRequest
{
    public string Password { get; set; }
    public Guid CustomerId { get; set; }
}

public class ValidatePhoneNumberRequest
{
    public string PhoneNumber { get; set; }
    public string Otp { get; set; }
    public Guid CustomerId { get; set; }
}

public class SetServiceProvider
{
    public Guid ServiceProviderId { get; set; }
}

public class DriverMode
{
    public Guid DriverModeId { get; set; }
}