namespace IMSBackend.Application.Dtos.Auth;

public class LoginDto
{
    public string EmailAddress { get; set; }
    public string Password { get; set; }
}

public class AuthenticationLoginDto
{
    public string Username { get; set; }
    public string Password { get; set; }
}
