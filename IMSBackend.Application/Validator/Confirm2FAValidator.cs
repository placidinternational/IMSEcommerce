using FluentValidation;
using IMSBackend.Application.Dtos.Auth.Requests;

namespace IMSBackend.Application.Validator;
public class Confirm2FAValidator : AbstractValidator<Confirm2FADto>
{
    public Confirm2FAValidator()
    {
        RuleFor(x => x.Otp)
            .NotNull()
            .NotEmpty()
            .WithMessage("Otp code is mandatory");
    }
}
