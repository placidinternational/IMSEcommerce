using FluentValidation;
using IMSBackend.Application.Dtos.Auth;

namespace IMSBackend.Application.Validator;

public class ChangePasswordValidator : AbstractValidator<ChangePasswordDto>
{
    public ChangePasswordValidator()
    {
        RuleFor(x => x.NewPassword)
            .NotEmpty()
            .WithMessage("New password is mandatory");

        RuleFor(x => x.OldPassword)
            .NotEmpty()
            .WithMessage("Old passsword is mandatory");
    }
}
