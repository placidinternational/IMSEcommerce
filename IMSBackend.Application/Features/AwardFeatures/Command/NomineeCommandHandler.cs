using IMSBackend.Application.Contracts;
using IMSBackend.Common;
using IMSBackend.Common.Enums;
using IMSBackend.Domain.Entities.Award;
using IMSBackend.Domain.Shared;
using MediatR;
using System.Text.RegularExpressions;

namespace IMSBackend.Application.Features.AwardFeatures.Command
{
    public class NomineeCommandHandler : IRequestHandler<NomineeCommand, Result<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IJobTestService _jobTestService;
       

        public NomineeCommandHandler(IUnitOfWork unitOfWork, IJobTestService jobTestService)
        {
            _unitOfWork = unitOfWork;
            _jobTestService = jobTestService;
            
        }
        public async Task<Result<string>> Handle(NomineeCommand request, CancellationToken cancellationToken)
        {
            try
            {

                Regex regex = new Regex(@"^([\w\.\-\+]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(request.EmailAddress);
                if (!match.Success)
                {
                    return await Result<string>.FailureAsync("Invalid Email Address");
                }

                var CheckEmail = await _unitOfWork.AccountRepository.GetSingleByExpression(x => x.EmailAddress ==request.EmailAddress, cancellationToken);

                if (CheckEmail is not null)
                {
                    return await Result<string>.FailureAsync("Email address already exists");

                }
                byte[] passwordHash, passwordSalt;
                CreatePasswordHash(request.Password, out passwordHash, out passwordSalt);
                var createUser = await _unitOfWork.AccountRepository.AddAsync(new Domain.Entities.Account.Account
                {
                    PasswordHashed = passwordHash,
                    PasswordSalt = passwordSalt,
                    EmailAddress = request.EmailAddress,
                    FullName = request.FullName,
                    UserType = UserTypeEnum.Nominee,
                    StatusEnum = StatusEnum.Active,
                    Address = request.Address,
                });
                await _unitOfWork.Save(cancellationToken);

                if (createUser is  null)
                {
                    return await Result<string>.FailureAsync("fail to create");
                }
                string NomineeCode = Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();
                await _unitOfWork.NomineeRepository.AddAsync(new Domain.Entities.Award.Nominee
                {
                    Biography = request.Biography,
                    AccountId = createUser.Id,
                    Picture = request.Picture,
                    Logo= request.Logo,
                    CompanyName = request.CompanyName,
                    CategoryId =request.CategoryId,
                    NomineeCode = NomineeCode,

                });
                await _unitOfWork.Save(cancellationToken);
                //Send email to user
                await _jobTestService.SendWelcomeEmail(request.EmailAddress, request.FullName, request.PhoneNumber, NomineeCode, request.CompanyName);

                return await Result<string>.SuccessAsync($"Account created successfully {createUser.Id}");
            }
            catch (Exception ex)
            {
                return await Result<string>.FailureAsync(ex.Message);
            }
        }
        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
