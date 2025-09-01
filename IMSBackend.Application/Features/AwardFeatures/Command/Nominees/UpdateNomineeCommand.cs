using IMSBackend.Common;
using IMSBackend.Domain.Shared;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.AwardFeatures.Command.Nominees
{
    public class UpdateNomineeCommand : IRequest<Result<string>>
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string Logo { get; set; }
        public string Picture { get; set; }
        public string Biography { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class UpdateNomineeCommandHandler : IRequestHandler<UpdateNomineeCommand, Result<string>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateNomineeCommandHandler(IUnitOfWork unitOfWork)
        {
           _unitOfWork = unitOfWork;
        }
        public async Task<Result<string>> Handle(UpdateNomineeCommand request, CancellationToken cancellationToken)
        {
            var nominee = await _unitOfWork.NomineeRepository.GetQueryable().Include(x => x.Account).Include(x => x.Category).Where(x => x.Account.Id == request.Id).FirstOrDefaultAsync(cancellationToken);

           
            if (nominee == null) 
            {
                return await Result<string>.FailureAsync("Nominee Not found");
            }

            nominee.Picture = request.Picture;
            nominee.UpdatedBy = nominee.Id;
            nominee.DateUpdated = nominee.DateUpdated;
            nominee.Biography = request.Biography;
            nominee.CompanyName = request.CompanyName;
            nominee.Account.FullName = request.FullName;
            nominee.Account.PhoneNumber = request.PhoneNumber;
            nominee.Account.DateUpdated = DateTime.UtcNow;
            nominee.Logo = request.Logo;

            await _unitOfWork.NomineeRepository.Update(nominee);
            await _unitOfWork.Save(cancellationToken);
            return await Result<string>.SuccessAsync("Updated successfully");
        }
    }
}
