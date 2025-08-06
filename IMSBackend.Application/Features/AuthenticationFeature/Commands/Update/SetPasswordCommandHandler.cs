using IMSBackend.Application.Dtos.Auth;
using MediatR;
using AutoMapper;
using IMSBackend.Common;
using IMSBackend.Application.Contracts;
using IMSBackend.Domain.Shared;

namespace IMSBackend.Application.Features.AuthenticationFeature.Commands.Update;

internal sealed class SetPasswordCommandHandler : IRequestHandler<SetPasswordCommand, Result<SocialGetRegisterResponseDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IJWTService _jwtService;

    public SetPasswordCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IJWTService jwtService)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _jwtService = jwtService;
    }

    public async Task<Result<SocialGetRegisterResponseDto>> Handle(SetPasswordCommand command, CancellationToken cancellationToken)
    {
        var authInfo = await _unitOfWork.AccountRepository.GetSingleByExpression(x => x.Id == command.CustomerId, cancellationToken);
        if (authInfo is null)
        {
            return await Result<SocialGetRegisterResponseDto>.FailureAsync("Invalid credentials.");
        }

        byte[] passwordHash, passwordSalt;
        CreatePasswordHash(command.Password, out passwordHash, out passwordSalt);

        authInfo.PasswordSalt = passwordSalt;
        authInfo.PasswordHashed = passwordHash;
        authInfo.IsFirstLogin = false;
        await _unitOfWork.AccountRepository.Update(authInfo);
        await _unitOfWork.Save(cancellationToken);

        string refreshToken = _jwtService.GenerateRefreshToken();
        var organizationResponse = await _unitOfWork.AccountRepository.GetByIdAsync(authInfo.Id, cancellationToken);
        organizationResponse.RefreshToken = refreshToken;
        organizationResponse.LastLogin = DateTime.UtcNow;
        organizationResponse.IsEmailVerified = true;
        await _unitOfWork.Save(cancellationToken);

        string token = _jwtService.GetTokenforLogin(organizationResponse);
        
        var loginResponse = new SocialGetRegisterResponseDto(authInfo.Id, false, token, refreshToken);
        return await Result<SocialGetRegisterResponseDto>.SuccessAsync(loginResponse, "Password set successfully.");
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