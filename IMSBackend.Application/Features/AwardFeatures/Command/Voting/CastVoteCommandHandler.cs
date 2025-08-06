using IMSBackend.Common;
using IMSBackend.Domain.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.AwardFeatures.Command.Voting
{
    public class CastVoteCommandHandler : IRequestHandler<CastVoteCommand, Result<string>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CastVoteCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Result<string>> Handle(CastVoteCommand cmd, CancellationToken cancellationToken)
        {
            await _unitOfWork.VoteRepository.AddAsync(new Domain.Entities.Award.Vote
            {
                Id = Guid.NewGuid(),
                NomineeId = cmd.NomineeId,
                Quantity = cmd.Quantity,
                AmountPaid = cmd.Quantity * 50,
                VoterEmail = cmd.VoterEmail,
                VoterName = cmd.VoterName
            });
            await _unitOfWork.Save(cancellationToken);

            return await Result<string>.SuccessAsync("vote cast successfully");
        }
    }
}
