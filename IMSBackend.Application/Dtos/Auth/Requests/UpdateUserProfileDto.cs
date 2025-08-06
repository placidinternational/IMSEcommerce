namespace IMSBackend.Application.Dtos.Auth.Requests;

public class UpdateUserProfileDto
{
    public string EmailAddress { get; set; }
    public string PhoneNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? FcmToken { get; set; }
}


public class UpdateFCMDto
{
    public string FcmToken { get; set; }
}