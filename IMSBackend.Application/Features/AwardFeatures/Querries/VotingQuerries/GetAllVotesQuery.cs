using IMSBackend.Application.Dtos.NewFolder;
using IMSBackend.Application.Dtos.Nominee.Response;
using IMSBackend.Common;
using IMSBackend.Common.Enums;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.AwardFeatures.Querries.VotingQuerries
{
    public class GetAllVotesQuery : IRequest<PaginatedResult<VotingResponse>>
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string? SearchParam { get; set; }
        public string? Category { get; set; }
        public StatusEnum? Status { get; set; }

    }
}
