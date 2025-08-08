using IMSBackend.Common;
using IMSBackend.Common.Enums;
using IMSBackend.Domain.Entities.BusinessPitches;
using IMSBackend.Domain.Shared;
using MediatR;
using System.Text.RegularExpressions;

namespace IMSBackend.Application.Features.BusinessPitchFeatures.Command
{
    public class BusinessPitchCommandHandler : IRequestHandler<BusinessPitchCommand, Result<string>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public BusinessPitchCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Result<string>> Handle(BusinessPitchCommand cmd, CancellationToken cancellationToken)
        {
            try
            {

                Regex regex = new Regex(@"^([\w\.\-\+]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(cmd.Request.EmailAddress);
                if (!match.Success)
                {
                    return await Result<string>.FailureAsync("Invalid Email Address");
                }

                var CheckEmail = await _unitOfWork.AccountRepository.GetSingleByExpression(x => x.EmailAddress == cmd.Request.EmailAddress, cancellationToken);

                if (CheckEmail is not null)
                {
                    return await Result<string>.FailureAsync("Email address already exists");

                }
                string password = Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();
                byte[] passwordHash, passwordSalt;
                CreatePasswordHash(password, out passwordHash, out passwordSalt);
                var createUser = await _unitOfWork.AccountRepository.AddAsync(new Domain.Entities.Account.Account
                {
                    PasswordHashed = passwordHash,
                    PasswordSalt = passwordSalt,
                    EmailAddress = cmd.Request.EmailAddress,
                    FullName = cmd.Request.FullName,
                    UserType = UserTypeEnum.Pitch,
                    StatusEnum = StatusEnum.Active,
                    Address = cmd.Request.Address,
                    PhoneNumber = cmd.Request.PhoneNumber,
                });
                await _unitOfWork.Save(cancellationToken);

                if (createUser is null)
                {
                    return await Result<string>.FailureAsync("fail to create");
                }
                string NomineeCode = Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();
                await _unitOfWork.BusinessPitchRepository.AddAsync(new BusinessPitch
                {
                    AccountId = createUser.Id,
                    OwnersPicture = cmd.Request.Picture,
                    BusinessLogo = cmd.Request.Logo,
                    BusinessName = cmd.Request.BusinessName,
                    BusinessCategoryId = cmd.Request.BusinessCategoryId

                });
                await _unitOfWork.Save(cancellationToken);

                //var categoryName = await _unitOfWork.CategoryRepository.GetByIdAsync(request.CategoryId, cancellationToken);
                //Send email to user
                //await _jobTestService.SendWelcomeEmail(request.EmailAddress, request.FullName, request.PhoneNumber, NomineeCode, categoryName.Name);

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
