using IMSBackend.Common;
using MediatR;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.BusinessPitchFeatures.Querries
{
    public class GetAllBusinessPitchQuery : IRequest<PaginatedResult<string>>
    {
    }

    public class GetAllBusinessPitchQueryHandler : IRequestHandler<GetAllBusinessPitchQuery, PaginatedResult<string>>
    {
        public Task<PaginatedResult<string>> Handle(GetAllBusinessPitchQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
