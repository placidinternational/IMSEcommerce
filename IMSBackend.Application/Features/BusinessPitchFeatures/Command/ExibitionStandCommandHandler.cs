using Hangfire.States;
using IMSBackend.Common;
using IMSBackend.Domain.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.BusinessPitchFeatures.Command
{
    public class ExibitionStandCommandHandler : IRequestHandler<ExibitionStandCommand, Result<string>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExibitionStandCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Result<string>> Handle(ExibitionStandCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var stand = await _unitOfWork.ExibitionStandRepository.AddAsync(new Domain.Entities.BusinessPitches.ExibitionStand
                {
                    FullName = request.FullName,
                    BusinessName = request.BusinessName,
                    Email = request.Email,
                    PhoneNumber = request.PhoneNumber,
                });
                if (stand == null)
                {
                    return await Result<string>.FailureAsync("failed to create");
                }

                else
                {
                    return await Result<string>.SuccessAsync("created successfully");
                }
            }
            catch (Exception ex)
            {
                return await Result<string>.FailureAsync("error");
            }

        }
    }
}
