using System.Text.RegularExpressions;
using Microsoft.Extensions.Logging;
using IMSBackend.Common;
using IMSBackend.Common.Enums;
using IMSBackend.Domain.Entities.Account;
using IMSBackend.Application.Contracts;
using MediatR;
using IMSBackend.Domain.Shared;
using AutoMapper;

namespace IMSBackend.Application.Features.AuthenticationFeature.Commands.Create;

internal sealed class CreateAuthCommandHandler : IRequestHandler<CreateAuthCommand, Result<string>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly ILogger<CreateAuthCommandHandler> _logger;
    private readonly IJobTestService _jobTestService;
   

    public CreateAuthCommandHandler(ILogger<CreateAuthCommandHandler> logger, IUnitOfWork unitOfWork, IMapper mapper, IJobTestService jobTestService)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _logger = logger;
        _jobTestService = jobTestService;
    }

    public async Task<Result<string>> Handle(CreateAuthCommand command, CancellationToken cancellationToken)
    {
        try
        {

            Regex regex = new Regex(@"^([\w\.\-\+]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(command.userRegistrationModel.EmailAddress);
            if (!match.Success)
            {
                return await Result<string>.FailureAsync("Invalid Email Address");
            }

            var CheckEmail = await _unitOfWork.AccountRepository.GetSingleByExpression(x => x.EmailAddress == command.userRegistrationModel.EmailAddress, cancellationToken);

            if (CheckEmail is not null)
            {
                return await Result<string>.FailureAsync("Email address already exists");

            }
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(command.userRegistrationModel.Password, out passwordHash, out passwordSalt);
            var user = _mapper.Map<Account>(command);
            user.PasswordSalt = passwordSalt;
            user.EmailAddress = command.userRegistrationModel.EmailAddress;
            user.FullName = command.userRegistrationModel.LastName;
            user.UserType = UserTypeEnum.Nominee;
            user.StatusEnum = StatusEnum.Active;
            user.PasswordHashed = passwordHash;
            await _unitOfWork.AccountRepository.AddAsync(user);
            await _unitOfWork.Save(cancellationToken);
            //Send email to user
            //await _jobTestService.SendWelcomeEmail(command.userRegistrationModel.EmailAddress, $"{command.userRegistrationModel.FirstName}{command.userRegistrationModel.LastName}", command.userRegistrationModel.PhoneNumber);

            return await Result<string>.SuccessAsync($"Account created successfully {user.Id}");
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
