using MediatR;
using IMSBackend.Application.Contracts;
using IMSBackend.Common;
using IMSBackend.Domain.Shared;
using AutoMapper;

namespace IMSBackend.Application.Features.AuthenticationFeature.Commands.Create;
internal sealed class CreatePasswordCommandHandler : IRequestHandler<CreatePasswordCommand, Result<string>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IUserContext _userContext;
    public CreatePasswordCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IUserContext userContext)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _userContext = userContext;
    }

    public async Task<Result<string>> Handle(CreatePasswordCommand command, CancellationToken cancellationToken)
    {
        var authInfo = await _unitOfWork.AccountRepository.GetSingleByExpression(x => x.Id == _userContext.UserId, cancellationToken);
        if (authInfo is null)
        {
            return await Result<string>.FailureAsync("Invalid credentials");
        }

        byte[] passwordHash, passwordSalt;
        CreatePasswordHash(command.Password, out passwordHash, out passwordSalt);

        authInfo.PasswordSalt = passwordSalt;
        authInfo.PasswordHashed = passwordHash;
        authInfo.IsFirstLogin = false;
        await _unitOfWork.AccountRepository.Update(authInfo);
        await _unitOfWork.Save(cancellationToken);

        return await Result<string>.SuccessAsync("Password successfully created");
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