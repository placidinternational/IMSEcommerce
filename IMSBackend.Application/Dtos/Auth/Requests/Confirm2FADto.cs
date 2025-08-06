using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Dtos.Auth.Requests;
public class Confirm2FADto
{
    public string TwoFAType { get; set; }
    public string Otp { get; set; }
}
