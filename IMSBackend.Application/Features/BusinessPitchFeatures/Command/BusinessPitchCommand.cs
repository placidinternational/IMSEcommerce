using IMSBackend.Application.Dtos.BusinessPitchDto;
using IMSBackend.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.BusinessPitchFeatures.Command
{
    public class BusinessPitchCommand : IRequest<Result<string>>
    {
        public BusinessPitchRequest Request { get; set; }
    }
}
