using IMSBackend.Application.Dtos.NewFolder;
using IMSBackend.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.AwardFeatures.Querries.VotingQuerries
{
    public class GetVoteByIdQuery : IRequest<Result<VotingResponse>>
    {
        public Guid Id { get; set; }
    }
}
