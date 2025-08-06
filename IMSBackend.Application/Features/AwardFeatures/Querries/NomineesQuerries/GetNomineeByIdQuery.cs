using IMSBackend.Application.Dtos.Nominee.Response;
using IMSBackend.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.AwardFeatures.Querries.NomineesQuerries
{
    public class GetNomineeByIdQuery : IRequest<Result<NomineeResponse>>
    {
        public Guid Id { get; set; }
    }
}
