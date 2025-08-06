using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Dtos.Auth.Responses;

public class ResendOtpDto
{
    public string OtpHash { get; set; }
    public string EmailAddress { get; set; }
    public string Message { get; set; }
    public string OtpCode { get; set; }
}
public class ForgotPasswordResponsetDto : ResendOtpDto
{

}

public class EditPhoneNumberResponse
{
    public string OtpHash { get; set; }
    public string PhoneNumber { get; set; }
    public string Message { get; set; }

}
