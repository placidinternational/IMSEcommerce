using FluentValidation;
using IMSBackend.Application.Dtos.Auth.Requests;

namespace IMSBackend.Application.Validator;
public class RequestDisableOtpCommandValidator : AbstractValidator<RequestDisableOtpDto>
{
    public RequestDisableOtpCommandValidator()
    {
        RuleFor(x => x.EmailAddress)
            .NotEmpty()
            .NotNull()
            .WithMessage("Email Address is mandantory");
    }
}
