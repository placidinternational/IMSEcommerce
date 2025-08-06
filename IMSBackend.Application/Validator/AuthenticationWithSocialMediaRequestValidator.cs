using FluentValidation;
using IMSBackend.Application.Dtos.Auth.Requests;

namespace IMSBackend.Application.Validator;
public class AuthenticationWithSocialMediaRequestValidator : AbstractValidator<AuthenticationWithSocialMediaRequest>
{
    public AuthenticationWithSocialMediaRequestValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress()
            .WithMessage("Email is required");

        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Id is required");

        RuleFor(x => x.SocialPlatform)
            .NotEmpty()
            .WithMessage("Social Platform is required");
    }

}
