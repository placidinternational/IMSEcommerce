using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Dtos.Auth.Requests
{
    public class UploadModelDto
    {
        public IFormFile Image { get; set; }
    }
}
