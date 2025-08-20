using IMSBackend.Application.Dtos.Auth;
using IMSBackend.Common;
using IMSBackend.Common.Enums;
using IMSBackend.Domain.Entities.Account;
using IMSBackend.Application.Contracts;
using Microsoft.EntityFrameworkCore;
using IMSBackend.Application.Dtos.Admin;
using Microsoft.AspNetCore.Http;
using MediatR;
using IMSBackend.Domain.Shared;

namespace IMSBackend.Application.Features.AuthenticationFeature.Queries;

public class ValidateLoginQuery : IRequest<Result<LoginResponseDto>>
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string IP { get; set; }
    public string Browser { get; set; }

    public ValidateLoginQuery(string email, string password, string ip, string browser)
    {
        Email = email;
        Password = password;
        IP = ip;
        Browser = browser;
    }
}

internal sealed class ValidateLoginQueryHandler : IRequestHandler<ValidateLoginQuery, Result<LoginResponseDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IJobTestService _jobTestService;
    private readonly IJWTService _jwtTokenService;

    public ValidateLoginQueryHandler(IUnitOfWork unitOfWork, IJobTestService jobTestService, IJWTService jwtTokenService)
    {
        _unitOfWork = unitOfWork;
        _jobTestService = jobTestService;
        _jwtTokenService = jwtTokenService;
    }

    public async Task<Result<LoginResponseDto>> Handle(ValidateLoginQuery query, CancellationToken cancellationToken)
    {
        try
        {
           
            var user = await _unitOfWork.AccountRepository.Login(query.Email, query.Password, cancellationToken);

            if (user is null)
            {
                return await Result<LoginResponseDto>.FailureAsync("Invalid credential supplied");
            }

            var getUser = await _unitOfWork.AccountRepository.GetByIdAsync(user.Id, cancellationToken);
            if (getUser == null)
            {
                return await Result<LoginResponseDto>.FailureAsync("User not found.");
            }

            getUser.RefreshToken = _jwtTokenService.GenerateRefreshToken();
            getUser.LastLogin = DateTime.UtcNow;
            getUser.IsEmailVerified = true;
            await _unitOfWork.Save(cancellationToken);

            //await _jobTestService.SendLogin(query.IP, getUser.FullName, query.Browser, DateTime.UtcNow, getUser.EmailAddress, cancellationToken);

            string token;
            List<PermissionObject> permissions = null;
                token = _jwtTokenService.GetAdminToken(getUser, permissions);
            return await Result<LoginResponseDto>.SuccessAsync(new LoginResponseDto
            {
                AccessToken = token,
                RefreshToken = getUser.RefreshToken,
                Email = getUser.EmailAddress,
                UserId = getUser.Id,
                FirstName = getUser.FullName,
                PhoneNumber = getUser.PhoneNumber,
                UserType = getUser.UserType.ToString(),
 
            }, "Login successful");
        }
        catch (Exception ex)
        {
            return await Result<LoginResponseDto>.FailureAsync($"An error occurred: {ex.Message}");
        }
    }

    
}
