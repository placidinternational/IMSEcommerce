namespace IMSBackend.Application.Dtos.Auth.Requests;
public class DeleteAccountRequest
{
    public string AccountDeleteType { get; set; }
    public string? Comments { get; set; }
}
