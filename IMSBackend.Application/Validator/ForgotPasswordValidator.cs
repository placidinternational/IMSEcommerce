using FluentValidation;
using IMSBackend.Application.Dtos.Auth;

namespace IMSBackend.Application.Validator;

public class ForgotPasswordValidator : AbstractValidator<ForgotPasswordDto>
{
    public ForgotPasswordValidator()
    {
        RuleFor(x => x.Email)
                 .NotEmpty()
                 .EmailAddress()
                 .WithMessage("Invalid Email supplied");

    }
}
