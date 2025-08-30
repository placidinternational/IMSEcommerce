using IMSBackend.Application.Contracts;
using IMSBackend.Application.Dtos.NewFolder;
using IMSBackend.Application.Dtos.Nominee.Response;
using IMSBackend.Common;
using IMSBackend.Common.Extensions;
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
    public class GetAllVotesQueryHandler : IRequestHandler<GetAllVotesQuery, PaginatedResult<VotingResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllVotesQueryHandler(IUnitOfWork unitOfWork, IUserContext userContext)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<PaginatedResult<VotingResponse>> Handle(GetAllVotesQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var query = _unitOfWork.VoteRepository.GetQueryable()
                    .Include(x => x.Nominee)
                        .ThenInclude(a => a.Account)
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

                // Fetch paginated votes first
                var pagedVotes = await query
                    .OrderByDescending(a => a.DateCreated)
                    .ToPaginatedListAsync(request.PageNumber, request.PageSize, cancellationToken);

                // Map to VotingResponse (including async category fetches)
                var data = new List<VotingResponse>();
                foreach (var vote in pagedVotes.Data)
                {
                    var category = await _unitOfWork.CategoryRepository.GetByIdAsync(vote.Nominee.CategoryId, cancellationToken);

                    data.Add(new VotingResponse
                    {
                        AmountPaid = vote.AmountPaid,
                        DateVoted = vote.DateCreated,
                        VoterEmail = vote.VoterEmail,
                        VoterName = vote.VoterName,
                        Nominee = vote.Nominee.Account.FullName,
                        Quantity = vote.Quantity,
                        Category = category.Name
                    });
                }

                return new PaginatedResult<VotingResponse>
                {
                    PageSize = pagedVotes.PageSize,
                    TotalCount = pagedVotes.TotalCount,
                    Succeeded = true,
                    Data = data
                };
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

