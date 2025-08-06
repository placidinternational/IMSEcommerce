using System.ComponentModel.DataAnnotations;

namespace IMSBackend.Application.Dtos.Auth.Requests;
public class AuthenticationWithSocialMediaRequest
{
    [Required]
    public string Id { get; set; }
    [Required]
    public string Email { get; set; }
    public string SocialPlatform { get; set; }
}
