using FluentValidation;
using IMSBackend.Application.Dtos.Auth;

namespace IMSBackend.Application.Validator;
public class TokenApiModelValidator : AbstractValidator<TokenApiModel>
{
    public TokenApiModelValidator()
    {
        RuleFor(x => x.AccessToken)
            .NotEmpty()
            .WithMessage("Access Token is mandatory");

        RuleFor(x => x.RefreshToken)
            .NotEmpty()
            .WithMessage("Refresh Token is mandatory");
    }
}
