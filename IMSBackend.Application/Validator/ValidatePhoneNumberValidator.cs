using FluentValidation;
using IMSBackend.Application.Dtos.Auth.Requests;

namespace IMSBackend.Application.Validator;

public class ValidatePhoneNumberValidator : AbstractValidator<ValidatePhoneNumberRequest>
{
    public ValidatePhoneNumberValidator()
    {
        RuleFor(x => x.CustomerId)
            .NotEmpty()
            .WithMessage("Customer Id is mandatory");

        RuleFor(x => x.Otp)
            .NotEmpty()
            .WithMessage("Otp Code is mandatory");
    }
}
