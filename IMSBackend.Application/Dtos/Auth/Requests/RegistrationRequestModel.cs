using IMSBackend.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace IMSBackend.Application.Dtos.Auth.Requests;

public sealed class RegistrationRequestModel
{
    public required string EmailAddress { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
   
}


