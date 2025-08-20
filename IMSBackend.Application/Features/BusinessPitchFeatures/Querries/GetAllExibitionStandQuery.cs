using IMSBackend.Application.Dtos.BusinessPitchDto;
using IMSBackend.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.BusinessPitchFeatures.Querries
{
    public class GetAllExibitionStandQuery : IRequest<Result<List<ExibitionStandResponse>>>
    {
    }
}
