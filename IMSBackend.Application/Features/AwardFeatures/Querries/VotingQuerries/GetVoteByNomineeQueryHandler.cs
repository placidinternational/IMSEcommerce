using IMSBackend.Application.Contracts;
using IMSBackend.Application.Dtos.NewFolder;
using IMSBackend.Application.Services;
using IMSBackend.Common;
using IMSBackend.Common.Extensions;
using IMSBackend.Domain.Entities.Award;
using IMSBackend.Domain.Shared;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.AwardFeatures.Querries.VotingQuerries
{
    public class GetVoteByNomineeQueryHandler : IRequestHandler<GetVoteByNomineeQuery, PaginatedResult<VotingResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserContext _userContext;

        public GetVoteByNomineeQueryHandler(IUnitOfWork unitOfWork, IUserContext userContext)

        {
            _unitOfWork = unitOfWork;
            _userContext = userContext;
        }
        public async Task<PaginatedResult<VotingResponse>> Handle(GetVoteByNomineeQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var user = await _unitOfWork.NomineeRepository.GetSingleByExpression(x=>x.AccountId == _userContext.UserId, cancellationToken);

                var query = _unitOfWork.VoteRepository.GetQueryable()
                    .Include(x => x.Nominee)
                        .ThenInclude(a => a.Account).Where(x=>x.NomineeId == user.Id)
                    .AsQueryable();
         
                // Apply search filter
                if (!string.IsNullOrEmpty(request.SearchParam))
                {
                    query = query.Where(a =>
                        a.Nominee.Account.FullName.Contains(request.SearchParam) ||
                        a.Nominee.CompanyName.Contains(request.SearchParam) ||
                        a.Nominee.NomineeCode.Contains(request.SearchParam));
                }

                // Apply status filter
                if (request.Status.HasValue)
                {
                    query = query.Where(a => a.Nominee.Account.StatusEnum == request.Status.Value);
                }


                var totalCount = query.Count();

                var data = await query
                    .OrderByDescending(x => x.DateCreated)
                    .Skip((request.PageNumber - 1) * request.PageSize)
                    .Take(request.PageSize)
                    .Select(x => new VotingResponse
                    {
                        AmountPaid = x.AmountPaid,
                        DateVoted = x.DateCreated,
                        Nominee = x.Nominee.Account.FullName,
                        Quantity = x.Quantity,
                        VoterEmail = x.VoterEmail,
                        VoterName = x.VoterName,
                }).ToPaginatedListAsync(request.PageNumber, request.PageSize, cancellationToken);

                return data;
            }
            catch (Exception)
            {
                return new PaginatedResult<VotingResponse>
                {
                    PageSize = request.PageSize,
                    TotalCount = 0,
                    Succeeded = false,
                    Data = new List<VotingResponse>()
                };
            }
        }
    }
}
