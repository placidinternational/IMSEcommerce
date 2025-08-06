using IMSBackend.Application.Dtos.Auth.Responses;
using IMSBackend.Common;
using IMSBackend.Common.Helpers;
using IMSBackend.Application.Contracts;
using IMSBackend.Domain.Entities.Account;
using MediatR;
using IMSBackend.Domain.Shared;
using AutoMapper;

namespace IMSBackend.Application.Features.AuthenticationFeature.Queries;

public class ResendOtpQuery : IRequest<Result<ResendOtpDto>>
{
    public string Email { get; set; }

    public ResendOtpQuery(string email)
    {
        Email = email;
    }
}

internal class ResendOtpQueryHandler : IRequestHandler<ResendOtpQuery, Result<ResendOtpDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IJobTestService _jobTestService;
    public ResendOtpQueryHandler(IMapper mapper, IUnitOfWork unitOfWork, IJobTestService jobTestService)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _jobTestService = jobTestService;
    }

    public async Task<Result<ResendOtpDto>> Handle(ResendOtpQuery query, CancellationToken cancellationToken)
    {
        try
        {
            string hashCode = CommonHelper.GetRandomNumber(20);
            string[] saAllowedCharacters = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            string sRandomOTP = GenerateRandomOTP(6, saAllowedCharacters); // otp to send
            var entity = await _unitOfWork.RegistrationOtpRepository.GetSingleByExpression(x => x.Account.EmailAddress == query.Email, cancellationToken);
            if (entity != null)
            {
                entity.Otp = sRandomOTP;
                entity.IsExpired = false;
                entity.IsUsed = false;
                entity.HashCode = CommonHelper.Sha256(hashCode);
                entity.ExpectedExpiryDateTime = DateTime.UtcNow.AddMinutes(5);
                await _unitOfWork.RegistrationOtpRepository.Update(entity);
                await _unitOfWork.Save(cancellationToken);

                await _jobTestService.SendOTPCode(sRandomOTP, query.Email);

                return await Result<ResendOtpDto>.SuccessAsync(new ResendOtpDto() { Message = "Otp code successfully resent", EmailAddress = query.Email, OtpHash = CommonHelper.Sha256(hashCode), OtpCode = sRandomOTP });
            }
            else
            {
                var checkAccount = await _unitOfWork.AccountRepository.GetSingleByExpression(x => x.EmailAddress == query.Email, cancellationToken);
                if (checkAccount is null)
                {
                    return await Result<ResendOtpDto>.FailureAsync("No account found.");
                }

                await _unitOfWork.RegistrationOtpRepository.AddAsync(new RegistrationOtp()
                {
                    Otp = sRandomOTP,
                    IsExpired = false,
                    IsUsed = false,
                    HashCode = CommonHelper.Sha256(hashCode),
                    ExpectedExpiryDateTime = DateTime.UtcNow.AddMinutes(5),
                    AccountId = checkAccount.Id,
                });
                await _unitOfWork.Save(cancellationToken);
                await _jobTestService.SendOTPCode(sRandomOTP, query.Email);
                return await Result<ResendOtpDto>.SuccessAsync(new ResendOtpDto() { Message = "Otp code successfully resent", EmailAddress = query.Email, OtpHash = CommonHelper.Sha256(hashCode), OtpCode = sRandomOTP });
            }
        }
        catch (Exception ex)
        {
            return await Result<ResendOtpDto>.FailureAsync(ex.Message);
        }
    }

    private static string GenerateRandomOTP(int iOTPLength, string[] saAllowedCharacters)
    {
        string sOTP = String.Empty;
        string sTempChars = String.Empty;
        Random rand = new Random();

        for (int i = 0; i < iOTPLength; i++)
        {
            int p = rand.Next(0, saAllowedCharacters.Length);

            sTempChars = saAllowedCharacters[rand.Next(0, saAllowedCharacters.Length)];

            sOTP += sTempChars;
        }

        return sOTP;
    }
}
