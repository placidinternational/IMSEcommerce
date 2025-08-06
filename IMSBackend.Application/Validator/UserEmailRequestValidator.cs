using FluentValidation;
using IMSBackend.Application.Dtos.Auth.Requests;

namespace IMSBackend.Application.Validator;

public class UserEmailRequestValidator : AbstractValidator<UserEmailRequestModel>
{
    public UserEmailRequestValidator()
    {
        RuleFor(x => x.Email)
            .EmailAddress()
            .NotEmpty()
            .WithMessage("Invalid Email Address supplied");

        RuleFor(x => x.OtpCode)
            .NotEmpty()
            .WithMessage("Invalid Otp code supplied");
    }
}
