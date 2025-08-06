using FluentValidation;
using IMSBackend.Application.Dtos.Auth.Requests;

namespace IMSBackend.Application.Validator;
public class Complete2FaSetupCommandValidator : AbstractValidator<Complete2FaSetupDto>
{
    public Complete2FaSetupCommandValidator()
    {
        RuleFor(x => x.AuthCode)
            .NotEmpty()
            .NotNull()
            .WithMessage("Authenticator code is mandantory");
    }
}
