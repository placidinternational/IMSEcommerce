namespace IMSBackend.Infrastructure.Settings;
public class EmailConfig
{
    public string Host { get; set; }
    public int Port { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string DisplayName { get; set; }
    public string EmailFrom { get; set; }
    public bool SSL { get; set; }

}
