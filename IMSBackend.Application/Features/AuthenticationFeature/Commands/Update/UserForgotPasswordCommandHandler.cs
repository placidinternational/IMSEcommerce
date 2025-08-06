using IMSBackend.Application.Dtos.Auth.Responses;
using MediatR;
using AutoMapper;
using IMSBackend.Common;
using IMSBackend.Common.Helpers;
using IMSBackend.Domain.Entities.Account;
using IMSBackend.Application.Contracts;
using IMSBackend.Domain.Shared;


namespace IMSBackend.Application.Features.AuthenticationFeature.Commands.Update;

public class UserForgotPasswordCommandHandler : IRequestHandler<UserForgotPasswordCommand, Result<ForgotPasswordResponsetDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IJobTestService _jobTestService;
    public UserForgotPasswordCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IJobTestService jobTestService)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _jobTestService = jobTestService;
    }

    public async Task<Result<ForgotPasswordResponsetDto>> Handle(UserForgotPasswordCommand command, CancellationToken cancellationToken)
    {
        try
        {
            string[] saAllowedCharacters = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            string sRandomOTP = GenerateRandomOTP(6, saAllowedCharacters); // otp to send
            string hashCode = CommonHelper.GetRandomNumber(20);

            //check if the email exist first
            Account validateEmail = await _unitOfWork.AccountRepository.GetSingleByExpression(x => x.EmailAddress == command.EmailAddress, cancellationToken);
            if (validateEmail == null)
            {
                return await Result<ForgotPasswordResponsetDto>.FailureAsync(new ForgotPasswordResponsetDto() { Message = "Forgot password reset email sent with otp code" });
            }
            var getAuthenticationInfo = await _unitOfWork.ForgotPasswordOtpRepository.GetSingleByExpression(x => x.EmailAddress == command.EmailAddress, cancellationToken);
            if (getAuthenticationInfo is null)
            {
                await _unitOfWork.ForgotPasswordOtpRepository.AddAsync(new Domain.Entities.Account.ForgotPasswordOtp()
                {
                    ExpectedExpiryDateTime = DateTime.UtcNow.AddMinutes(5),
                    IsExpired = false,
                    IsUsed = false,
                    Otp = sRandomOTP,
                    HashCode = CommonHelper.Sha256(hashCode),
                    EmailAddress = command.EmailAddress,
                    UserId = validateEmail!.Id
                });
                await _unitOfWork.Save(cancellationToken);
                await _jobTestService.SendForgotPasswordEmailCode(command.EmailAddress, sRandomOTP);
               
                return await Result<ForgotPasswordResponsetDto>.SuccessAsync(new ForgotPasswordResponsetDto() { Message = "Forgot password reset email sent with otp code", EmailAddress = command.EmailAddress, OtpHash = CommonHelper.Sha256(hashCode) });
            }
            else
            {
                //already exist
                getAuthenticationInfo.ExpectedExpiryDateTime = DateTime.UtcNow.AddMinutes(5);
                getAuthenticationInfo.Otp = sRandomOTP;
                getAuthenticationInfo.HashCode = CommonHelper.Sha256(hashCode);
                await _unitOfWork.ForgotPasswordOtpRepository.Update(getAuthenticationInfo);
                await _unitOfWork.Save(cancellationToken);

                await _jobTestService.SendForgotPasswordEmailCode(getAuthenticationInfo.EmailAddress, sRandomOTP);

                return await Result<ForgotPasswordResponsetDto>.SuccessAsync(new ForgotPasswordResponsetDto() { Message = "Forgot password reset email sent with otp code", EmailAddress = command.EmailAddress, OtpHash = CommonHelper.Sha256(hashCode) });
            }
        }
        catch (Exception ex)
        {
            return await Result<ForgotPasswordResponsetDto>.FailureAsync(new ForgotPasswordResponsetDto() { Message = $"{ex.Message}" });
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
