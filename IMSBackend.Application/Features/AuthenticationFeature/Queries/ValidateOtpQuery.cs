using IMSBackend.Common;
using IMSBackend.Application.Dtos.Auth;
using IMSBackend.Application.Contracts;
using MediatR;
using IMSBackend.Domain.Shared;
using AutoMapper;
namespace IMSBackend.Application.Features.AuthenticationFeature.Queries;

public class ValidateOtpQuery : IRequest<Result<SocialGetRegisterResponseDto>>
{
    public string Email { get; set; }
    public string OtpCode { get; set; }
    public string HashCode { get; set; }

    public ValidateOtpQuery(string otpCode, string email, string hashCode)
    {
        OtpCode = otpCode;
        Email = email;
        HashCode = hashCode;
    }
}

internal sealed class ValidateOtpQueryHandler : IRequestHandler<ValidateOtpQuery, Result<SocialGetRegisterResponseDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IJWTService _jwtService;

    public ValidateOtpQueryHandler(IMapper mapper, IUnitOfWork unitOfWork, IJWTService jwtService)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _jwtService = jwtService;
    }

    public async Task<Result<SocialGetRegisterResponseDto>> Handle(ValidateOtpQuery query, CancellationToken cancellationToken)
    {
        try
        {
            var entity = await _unitOfWork.RegistrationOtpRepository.GetSingleByExpression(x => x.Account.EmailAddress == query.Email && x.Otp == query.OtpCode && x.HashCode == query.HashCode, cancellationToken);
            if (entity == null)
            {
                return await Result<SocialGetRegisterResponseDto>.FailureAsync("Invalid otp supplied");
            }
            else if (entity != null && DateTime.UtcNow >= entity.ExpectedExpiryDateTime)
            {
                return await Result<SocialGetRegisterResponseDto>.FailureAsync("Supplied otp has expired");
            }
            else
            {
                entity!.IsUsed = true;
                await _unitOfWork.RegistrationOtpRepository.Update(entity);
                await _unitOfWork.Save(CancellationToken.None);


                //string refreshToken = _jwtService.GenerateRefreshToken();
                //var organizationResponse = await _unitOfWork.AccountRepository.GetByIdAsync(authInfo.Id, cancellationToken);
                //organizationResponse.RefreshToken = refreshToken;
                //organizationResponse.LastLogin = DateTime.UtcNow;
                //organizationResponse.IsEmailVerified = true;
                //await _unitOfWork.Save(cancellationToken);

                //string token = _jwtService.GetTokenforLogin(organizationResponse);

                //var loginResponse = new SocialGetRegisterResponseDto(authInfo.Id, false, token, refreshToken);
                return await Result<SocialGetRegisterResponseDto>.SuccessAsync("Otp code successfully verified.");
            }
        }
        catch (Exception ex)
        {
            return await Result<SocialGetRegisterResponseDto>.FailureAsync(ex.Message);
        }
    }

}
