using AutoMapper;
using IMSBackend.Common;
using IMSBackend.Domain.Shared;
using MediatR;

namespace IMSBackend.Application.Features.AuthenticationFeature.Commands.Update;

internal class UserChangePasswordCommandHandler : IRequestHandler<UserChangePasswordCommand, Result<string>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public UserChangePasswordCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Result<string>> Handle(UserChangePasswordCommand command, CancellationToken cancellationToken)
    {
        // CreatePasswordHash(command.OldPassword, out OldpasswordHash, out OldpasswordSalt);
        var user = await _unitOfWork.AccountRepository.GetSingleByExpression(x => x.EmailAddress == command.EmailAddress, cancellationToken);
        bool checkPassword = VerifyPassword(command.OldPassword, user.PasswordHashed, user.PasswordSalt);
        if (checkPassword)
        {
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(command.Password, out passwordHash, out passwordSalt);

            user.PasswordSalt = passwordSalt;
            user.PasswordHashed = passwordHash;
            await _unitOfWork.AccountRepository.Update(user);
            await _unitOfWork.Save(cancellationToken);

           
            return await Result<string>.SuccessAsync("Password changed successfully");
        }
        else
        {
            return await Result<string>.FailureAsync("Incorrect old password supplied");
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
    private bool VerifyPassword(string password, byte[] passwordHash, byte[] passwordSalt)
    {
        using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
        {
            var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            for (int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != passwordHash[i]) return false;
            }
            return true;
        }
    }
}
