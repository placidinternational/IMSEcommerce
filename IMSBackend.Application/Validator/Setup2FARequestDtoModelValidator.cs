using FluentValidation;
using IMSBackend.Application.Dtos.Auth.Requests;
namespace IMSBackend.Application.Validator;

public class Setup2FARequestDtoModelValidator : AbstractValidator<Setup2FARequestDtoModel>
{
    public Setup2FARequestDtoModelValidator()
    {
        RuleFor(x => x.TwoFAType)
                 .NotEmpty()
                 .NotNull()
                 .WithMessage("Invalid Email supplied");

    }
}

