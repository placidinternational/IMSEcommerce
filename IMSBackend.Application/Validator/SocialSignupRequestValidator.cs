using FluentValidation;
using IMSBackend.Application.Dtos.Auth.Requests;

namespace IMSBackend.Application.Validator;
public class SocialSignupRequestValidator : AbstractValidator<SocialSignupRequest>
{
    public SocialSignupRequestValidator()
    {
        RuleFor(x => x.EmailAddress)
            .NotEmpty()
            .EmailAddress()
            .NotNull()
            .WithMessage("Email address is mandantory");

        RuleFor(x => x.FirstName)
           .NotEmpty()
           .NotNull()
           .WithMessage("First Name is mandantory");

        RuleFor(x => x.LastName)
           .NotEmpty()
           .NotNull()
           .WithMessage("Last Name is mandantory");

        RuleFor(x => x.Platform)
           .NotEmpty()
           .NotNull()
           .WithMessage("Platform is mandantory");
    }
}
