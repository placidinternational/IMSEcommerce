using AutoMapper;
using IMSBackend.Common;
using IMSBackend.Domain.Shared;
using MediatR;


namespace IMSBackend.Application.Features.AuthenticationFeature.Commands.Update;
internal sealed class ResetPasswordValidateOtpCommandHandler : IRequestHandler<ResetPasswordValidateOtpCommand, Result<string>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public ResetPasswordValidateOtpCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Result<string>> Handle(ResetPasswordValidateOtpCommand command, CancellationToken cancellationToken)
    {
        var authInfo = await _unitOfWork.AccountRepository.GetSingleByExpression(x => x.EmailAddress == command.EmailAddress, cancellationToken);
        if (authInfo is null)
        {
            return await Result<string>.FailureAsync("Invalid credentials");
        }

        var forgotPasswordCode = await _unitOfWork.ForgotPasswordOtpRepository.GetSingleByExpression(x => x.EmailAddress == command.EmailAddress && x.Otp == command.OtpCode && x.HashCode == command.HashCode, cancellationToken);
        if (forgotPasswordCode is null)
        {
            return await Result<string>.FailureAsync("Invalid otp code supplied");
        }
        else if (forgotPasswordCode != null && DateTime.UtcNow >= forgotPasswordCode.ExpectedExpiryDateTime)
        {
            return await Result<string>.FailureAsync("Supplied otp has expired");
        }

        return await Result<string>.SuccessAsync("Otp Code validate Successfully");
    }

}