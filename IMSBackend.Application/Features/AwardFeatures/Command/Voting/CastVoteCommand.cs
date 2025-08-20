using IMSBackend.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.AwardFeatures.Command.Voting
{
    public record CastVoteCommand(Guid NomineeId, int Quantity, string VoterEmail, string VoterName, string CategoryName,string ReferenceNumber) : IRequest<Result<string>>;
}
