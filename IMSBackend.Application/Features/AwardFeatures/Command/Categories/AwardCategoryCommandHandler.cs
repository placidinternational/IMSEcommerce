using IMSBackend.Common;
using IMSBackend.Domain.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.AwardFeatures.Command.Categories
{
    public class AwardCategoryCommandHandler : IRequestHandler<AwardCategoryCommand, Result<string>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AwardCategoryCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Result<string>> Handle(AwardCategoryCommand request, CancellationToken cancellationToken)
        {
            try
            {

                var category = await _unitOfWork.CategoryRepository.AddAsync(new Domain.Entities.Award.Category
                {
                    Name = request.Name,
                    Award = request.IsAward,
                    Pitch = request.Ispitch,
                });
                await _unitOfWork.Save(cancellationToken);

                if (category == null)
                {
                    return await Result<string>.FailureAsync("failed to create category");
                }
                return await Result<string>.SuccessAsync(category.Name, "created successfully");
            }
            catch (Exception ex)
            {
                return await Result<string>.FailureAsync("error occured");
            }

        }
    }
}
