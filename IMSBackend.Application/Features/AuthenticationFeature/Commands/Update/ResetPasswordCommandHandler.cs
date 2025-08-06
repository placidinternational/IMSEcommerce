using AutoMapper;
using IMSBackend.Common;
using IMSBackend.Domain.Shared;
using MediatR;


namespace IMSBackend.Application.Features.AuthenticationFeature.Commands.Update;

internal class ResetPasswordCommandhandler : IRequestHandler<ResetPasswordCommand, Result<string>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ResetPasswordCommandhandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Result<string>> Handle(ResetPasswordCommand command, CancellationToken cancellationToken)
    {
        var authInfo = await _unitOfWork.AccountRepository.GetSingleByExpression(x => x.EmailAddress == command.EmailAddress, cancellationToken);
        if (authInfo is null)
        {
            return await Result<string>.FailureAsync("Invalid credentials");
        }

        byte[] passwordHash, passwordSalt;
        CreatePasswordHash(command.NewPassword, out passwordHash, out passwordSalt);

        authInfo.PasswordSalt = passwordSalt;
        authInfo.PasswordHashed = passwordHash;
        authInfo.IsFirstLogin = true;
        await _unitOfWork.AccountRepository.Update(authInfo);
        await _unitOfWork.Save(cancellationToken);
        return await Result<string>.SuccessAsync("Password successfully changed");
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