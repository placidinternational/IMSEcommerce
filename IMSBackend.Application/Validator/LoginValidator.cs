using FluentValidation;
using IMSBackend.Application.Dtos.Auth;

namespace IMSBackend.Application.Validator;

public class LoginValidator : AbstractValidator<AuthenticationLoginDto>
{
    public LoginValidator()
    {
        RuleFor(x => x.Username)
                 .NotEmpty()
                 .WithMessage("Invalid Email/PhoneNumber supplied");

        RuleFor(x => x.Password)
            .NotEmpty().WithMessage("Password is Mandatory")
            .MinimumLength(8).WithMessage("Your password length must be at least 8.")
            .Matches(@"[A-Z]+").WithMessage("Your password must contain at least one uppercase letter.")
            .Matches(@"[a-z]+").WithMessage("Your password must contain at least one lowercase letter.")
            .Matches(@"[0-9]+").WithMessage("Your password must contain at least one number.");
    }
}
