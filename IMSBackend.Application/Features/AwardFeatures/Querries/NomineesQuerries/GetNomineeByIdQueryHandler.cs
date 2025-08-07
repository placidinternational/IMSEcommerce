using IMSBackend.Application.Dtos.Nominee.Response;
using IMSBackend.Common;
using IMSBackend.Domain.Shared;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace IMSBackend.Application.Features.AwardFeatures.Querries.NomineesQuerries
{
    public class GetNomineeByIdQueryHandler : IRequestHandler<GetNomineeByIdQuery, Result<NomineeResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetNomineeByIdQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Result<NomineeResponse>> Handle(GetNomineeByIdQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var query = await _unitOfWork.NomineeRepository.GetQueryable().Include(x => x.Account).Include(x=>x.Category) .Where(x => x.Account.Id == request.Id).FirstOrDefaultAsync(cancellationToken);

                if (query is null)
                {
                    return await Result<NomineeResponse>.FailureAsync("No Nominee found");
                }

                // Project to DTO
                var Nominee = new NomineeResponse
                {
                    Id = query.Id,
                    FullName = query.Account.FullName,
                    EmailAddress = query.Account.EmailAddress,
                    DateCreated = query.Account.DateCreated,
                    Address = query.Account.Address,
                    PhoneNumber = query.Account.PhoneNumber,
                    Status = query.Account.StatusEnum,
                    UserType = query.Account.UserType,
                    CompanyName = query.CompanyName,
                    NomineeCode = query.NomineeCode,
                    Picture = query.Picture,
                    Category = query.Category.Name,
                };

                return await Result<NomineeResponse>.SuccessAsync(Nominee, "Fetched successfully");
            }
            catch (Exception ex)
            {
                return await Result<NomineeResponse>.FailureAsync("error occured");
            }
        }
    }
}
