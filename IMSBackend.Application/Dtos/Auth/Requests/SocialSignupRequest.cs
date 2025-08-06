using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Dtos.Auth.Requests;

public class SocialSignupRequest
{
    [Required]
    public string Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string EmailAddress { get; set; }

    public string? PhoneNumber { get; set; }
    public string Platform { get; set; }
}
