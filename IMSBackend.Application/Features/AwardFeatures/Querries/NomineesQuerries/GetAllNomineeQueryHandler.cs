using IMSBackend.Application.Dtos.Nominee.Response;
using IMSBackend.Common;
using IMSBackend.Common.Enums;
using IMSBackend.Common.Extensions;
using IMSBackend.Domain.Shared;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.AwardFeatures.Querries.NomineesQuerries
{
    public class GetAllNomineeQueryHandler : IRequestHandler<GetAllNomineeQuery, PaginatedResult<NomineeResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllNomineeQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<PaginatedResult<NomineeResponse>> Handle(GetAllNomineeQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var query = _unitOfWork.NomineeRepository.GetQueryable().Include(x => x.Account).Include(a=>a.Category).Where(x=>x.Account.UserType ==UserTypeEnum.Nominee && x.IsActive).AsQueryable();

                // Apply search filter
                if (!string.IsNullOrEmpty(request.SearchParam))
                {
                    query = query.Where(a =>
                        a.Account.FullName.Contains(request.SearchParam) ||
                        a.CompanyName.Contains(request.SearchParam) ||
                        a.NomineeCode.Contains(request.SearchParam));
                }

                // Apply status filter
                if (request.Status.HasValue)
                {
                    query = query.Where(a => a.Account.StatusEnum == request.Status.Value);
                }
                if (!string.IsNullOrEmpty(request.Category))
                {
                    query  = query.Where(a => a.Category.Name ==  request.Category);
                }
                // Project to DTO
                var nominee = query.Select(a => new NomineeResponse
                {
                    Id = a.Account.Id,
                    FullName = a.Account.FullName,
                    EmailAddress = a.Account.EmailAddress,
                    DateCreated = a.Account.DateCreated,
                    Address = a.Account.Address,
                    PhoneNumber = a.Account.PhoneNumber,
                    Status = a.Account.StatusEnum,
                    UserType = a.Account.UserType,
                    CompanyName = a.CompanyName,
                    NomineeCode = a.NomineeCode,
                    Picture = a.Picture,
                    Category = a.Category.Name
                })
                .OrderByDescending(a => a.DateCreated);

                // Apply pagination
                var Nominee = await nominee.ToPaginatedListAsync(request.PageNumber, request.PageSize, cancellationToken);

                return Nominee;
            }
            catch (Exception ex)
            {
                return new PaginatedResult<NomineeResponse>
                {
                    PageSize = request.PageSize,
                    TotalCount = 0,
                    Succeeded = false,
                    Data = new List<NomineeResponse>()
                };
            }
        }
    }
}
