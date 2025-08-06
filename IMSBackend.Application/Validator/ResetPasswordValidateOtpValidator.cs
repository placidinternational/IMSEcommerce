using FluentValidation;
using IMSBackend.Application.Dtos.Auth;

namespace IMSBackend.Application.Validator;
public class ResetPasswordValidateOtpValidator : AbstractValidator<ResetPasswordOtpRequestDto>
{
    public ResetPasswordValidateOtpValidator()
    {
        RuleFor(x => x.EmailAddress)
                 .NotEmpty()
                 .EmailAddress()
                 .WithMessage("Invalid Email supplied");

        RuleFor(x => x.OtpCode)
                 .NotEmpty()
                 .WithMessage("Invalid otpcode supplied");

    }
}