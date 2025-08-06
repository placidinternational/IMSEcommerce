using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Dtos.Auth.Requests;
public class Complete2FaSetupDto
{
    public string AuthCode { get; set; }
}
