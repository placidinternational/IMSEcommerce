using IMSBackend.Application.Dtos.BusinessPitchDto;
using IMSBackend.Common;
using IMSBackend.Domain.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.BusinessPitchFeatures.Querries
{
    public class GetAllExibitionStandQueryHandler : IRequestHandler<GetAllExibitionStandQuery, Result<List<ExibitionStandResponse>>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllExibitionStandQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Result<List<ExibitionStandResponse>>> Handle(GetAllExibitionStandQuery request, CancellationToken cancellationToken)
        {
           var query = await _unitOfWork.ExibitionStandRepository.GetAllAsync(cancellationToken);
          

            var stand = query.Select(a=>new ExibitionStandResponse
            {
                Id = a.Id,
                FullName = a.FullName,
                Address = a.Address,
                PhoneNumber = a.PhoneNumber,
                Email = a.Email,
                BusinessName = a.BusinessName,
            }).OrderDescending().ToList();

            return await Result<List<ExibitionStandResponse>>.SuccessAsync(stand, "fetched successfully");
        }
    }
}
