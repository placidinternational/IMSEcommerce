using IMSBackend.Common;
using IMSBackend.Domain.Shared;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static IMSBackend.Application.Features.AwardFeatures.Querries.VotingQuerries.VoteWinnersQueryHandler;

namespace IMSBackend.Application.Features.AwardFeatures.Querries.VotingQuerries
{
    public class VoteWinnersQuery : IRequest<WinnerResultDto>
    {
        /// <summary>
        /// Optional filter by category
        /// </summary>
        public Guid? CategoryId { get; set; }
    }

    public class VoteWinnersQueryHandler : IRequestHandler<VoteWinnersQuery, WinnerResultDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        public VoteWinnersQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<WinnerResultDto> Handle(VoteWinnersQuery request, CancellationToken cancellationToken)
        {
            // Step 1: Build base query
            var query = _unitOfWork.NomineeRepository.GetQueryable()
                .Include(n => n.Category)
                .Include(n => n.Votes)
                .Where(n => n.IsActive);

            // ✅ Step 2: Apply Category filter if provided
            if (request.CategoryId.HasValue && request.CategoryId.Value != Guid.Empty)
            {
                query = query.Where(n => n.CategoryId == request.CategoryId.Value);
            }

            // Step 3: Select required data
            var nomineesData = await query
                .Select(n => new
                {
                    n.Id,
                    n.CompanyName,
                    n.Logo,
                    n.Picture,
                    n.Biography,
                    n.CategoryId,
                    CategoryName = n.Category.Name,
                    TotalVotes = n.Votes.Where(v => v.IsSuccessful).Sum(v => v.Quantity), // Only successful votes
                    TotalAmountPaid = n.Votes.Where(v => v.IsSuccessful).Sum(v => v.AmountPaid)
                })
                .ToListAsync(cancellationToken);

            // ✅ Step 4: Filter out nominees with zero votes
            nomineesData = nomineesData.Where(x => x.TotalVotes > 0).ToList();

            // Step 5: Group by Category and pick top nominee
            var winners = nomineesData
                .GroupBy(x => new { x.CategoryId, x.CategoryName })
                .Select(g => g
                    .OrderByDescending(x => x.TotalVotes)
                    .ThenByDescending(x => x.TotalAmountPaid)
                    .First()) // Winner for each category
                .Select(x => new CategoryWinnerDto
                {
                    CategoryId = x.CategoryId,
                    CategoryName = x.CategoryName,
                    NomineeId = x.Id,
                    NomineeName = x.CompanyName,
                    Logo = x.Logo,
                    Picture = x.Picture,
                    Biography = x.Biography,
                    TotalVotes = x.TotalVotes,
                    TotalAmountPaid = x.TotalAmountPaid
                })
                .OrderByDescending(w => w.TotalVotes)
                .ThenByDescending(w => w.TotalAmountPaid)
                .ToList();

            // Get total count of winners
            var totalWinnerCount = winners.Count;

            // Wrap in a response object
            return new WinnerResultDto
            {
                TotalWinners = totalWinnerCount,
                Winners = winners
            };
        }

        // DTO for each category winner
        public class CategoryWinnerDto
        {
            public Guid CategoryId { get; set; }
            public string CategoryName { get; set; }
            public Guid NomineeId { get; set; }
            public string NomineeName { get; set; }
            public string? Logo { get; set; }
            public string? Picture { get; set; }
            public string? Biography { get; set; }
            public int TotalVotes { get; set; }
            public decimal TotalAmountPaid { get; set; }
        }

        // DTO for the query response
        public class WinnerResultDto
        {
            public int TotalWinners { get; set; }
            public List<CategoryWinnerDto> Winners { get; set; }
        }
    }
}
