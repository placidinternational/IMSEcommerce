using IMSBackend.Application.Dtos.VotingDto;
using IMSBackend.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.AwardFeatures.Querries.VotingQuerries
{
    public class AdminVoteMetricsQuerry : IRequest<Result<AdminVoteMetric>>
    {
    }
}
