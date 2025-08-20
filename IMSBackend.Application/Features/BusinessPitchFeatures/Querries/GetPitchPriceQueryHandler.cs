using IMSBackend.Application.Dtos.BusinessPitchDto;
using IMSBackend.Common;
using IMSBackend.Domain.Shared;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace IMSBackend.Application.Features.BusinessPitchFeatures.Querries
{
    public class GetPitchPriceQueryHandler : IRequestHandler<GetPitchPriceQuery, Result<PitchPriceDto>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetPitchPriceQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Result<PitchPriceDto>> Handle(GetPitchPriceQuery request, CancellationToken cancellationToken)
        {
            var pitchPrice = await _unitOfWork.PitchPriceRepository
                .GetQueryable()
                .Select(p => p.Price)
                .FirstOrDefaultAsync(cancellationToken);

            // Assuming Price is decimal, FirstOrDefaultAsync returns 0 if not found
            if (pitchPrice <= 0)
            {
                return await Result<PitchPriceDto>.FailureAsync("Pitch price not found.");
            }

            var priceDto = new PitchPriceDto
            {
                Price = pitchPrice
            };

            return await Result<PitchPriceDto>.SuccessAsync(priceDto, "Fetched successfully");
        }
    }
}
