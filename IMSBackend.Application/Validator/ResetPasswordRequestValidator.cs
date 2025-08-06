using FluentValidation;
using IMSBackend.Application.Dtos.Auth;

namespace IMSBackend.Application.Validator;
public class ResetPasswordRequestValidator : AbstractValidator<ResetPasswordRequestDto>
{
    public ResetPasswordRequestValidator()
    {
        RuleFor(x => x.EmailAddress)
            .EmailAddress()
            .NotEmpty()
            .WithMessage("Invalid Email supplied");


        RuleFor(x => x.NewPassword)
            .NotEmpty().WithMessage("Password is Mandatory")
            .MinimumLength(8).WithMessage("Your password length must be at least 8.")
            .Matches(@"[A-Z]+").WithMessage("Your password must contain at least one uppercase letter.")
            .Matches(@"[a-z]+").WithMessage("Your password must contain at least one lowercase letter.")
            .Matches(@"[0-9]+").WithMessage("Your password must contain at least one number.");
    }
}
