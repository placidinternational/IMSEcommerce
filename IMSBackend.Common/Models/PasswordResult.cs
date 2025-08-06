namespace IMSBackend.Common.Models;

public class PasswordResult
{
    public string Password { get; set; }
    public byte[] PasswordSalt { get; set; }
    public byte[] PasswordHash { get; set; }
}
