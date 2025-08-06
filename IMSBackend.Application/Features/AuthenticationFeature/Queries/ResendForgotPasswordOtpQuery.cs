using IMSBackend.Application.Dtos.Auth.Responses;
using IMSBackend.Application.Constants;
using IMSBackend.Common;
using IMSBackend.Common.Helpers;
using IMSBackend.Common.Models;
using MediatR;
using IMSBackend.Domain.Shared;
using AutoMapper;

namespace IMSBackend.Application.Features.AuthenticationFeature.Queries;

public class ResendForgotPasswordOtpQuery : IRequest<Result<ForgotPasswordResponsetDto>>
{
    public string Email { get; set; }

    public ResendForgotPasswordOtpQuery(string email)
    {
        Email = email;
    }
}


internal sealed class ResendForgotPasswordOtpQueryHandler : IRequestHandler<ResendForgotPasswordOtpQuery, Result<ForgotPasswordResponsetDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public ResendForgotPasswordOtpQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<ForgotPasswordResponsetDto>> Handle(ResendForgotPasswordOtpQuery query, CancellationToken cancellationToken)
    {
        try
        {
            string hashCode = CommonHelper.GetRandomNumber(20);
            string[] saAllowedCharacters = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            string sRandomOTP = GenerateRandomOTP(6, saAllowedCharacters); // otp to send
            var entity = await _unitOfWork.ForgotPasswordOtpRepository.GetSingleByExpression(x => x.EmailAddress == query.Email, cancellationToken);
            if (entity != null)
            {
                entity.Otp = sRandomOTP;
                entity.IsExpired = false;
                entity.IsUsed = false;
                entity.HashCode = CommonHelper.Sha256(hashCode);
                entity.ExpectedExpiryDateTime = DateTime.UtcNow.AddMinutes(5);
                await _unitOfWork.ForgotPasswordOtpRepository.Update(entity);
                await _unitOfWork.Save(cancellationToken);

                //await _emailNotificationService.SendOTP(new NotificationRequest()
                //{
                //    Name = query.Email,
                //    To = query.Email,
                //    Subject = EmailSubjectConstant.OtpSubject,
                //    Body = string.Empty,
                //    Data = new Dictionary<string, string>()
                //    {
                //        {"otp",sRandomOTP },
                //        {"email", query.Email },
                //        {"subject", EmailSubjectConstant.OtpSubject },
                //        {"expiry_date","5" },
                //    }
                //});

                return await Result<ForgotPasswordResponsetDto>.SuccessAsync(new ForgotPasswordResponsetDto() { Message = "Otp code successfully resent", EmailAddress = query.Email, OtpHash = CommonHelper.Sha256(hashCode) });
            }
            else
            {
                //get the organization Id
                var getAuthenticationRecord = await _unitOfWork.AccountRepository.GetSingleByExpression(x => x.EmailAddress == query.Email, cancellationToken);
                var otp = new Domain.Entities.Account.ForgotPasswordOtp();
                otp.ExpectedExpiryDateTime = DateTime.UtcNow.AddMinutes(5);
                otp.IsExpired = false;
                otp.IsUsed = false;
                otp.UserId = getAuthenticationRecord.Id;
                otp.Otp = sRandomOTP;
                otp.HashCode = CommonHelper.Sha256(hashCode);
                var result = await _unitOfWork.ForgotPasswordOtpRepository.AddAsync(otp);
                await _unitOfWork.Save(cancellationToken);

                //await _emailNotificationService.SendOTP(new NotificationRequest()
                //{
                //    Name = query.Email,
                //    To = query.Email,
                //    Subject = EmailSubjectConstant.OtpSubject,
                //    Body = string.Empty,
                //    Data = new Dictionary<string, string>()
                //    {
                //        {"otp",sRandomOTP },
                //        {"email", query.Email },
                //        {"subject", EmailSubjectConstant.OtpSubject },
                //        {"expiry_date","5" },
                //    }
                //});

                return await Result<ForgotPasswordResponsetDto>.SuccessAsync(new ForgotPasswordResponsetDto() { Message = "Otp code successfully resent", EmailAddress = query.Email, OtpHash = CommonHelper.Sha256(hashCode) });
            }
        }
        catch (Exception ex)
        {
            return await Result<ForgotPasswordResponsetDto>.FailureAsync(ex.Message);
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
