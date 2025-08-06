using FluentValidation;
using IMSBackend.Application.Dtos.Auth.Requests;

namespace IMSBackend.Application.Validator;

public class RegistrationRequestModelValidator : AbstractValidator<RegistrationRequestModel>
{
    public RegistrationRequestModelValidator()
    {
        RuleFor(x => x.EmailAddress)
                 .NotEmpty()
                 .EmailAddress()
                 .WithMessage("Invalid Email address supplied");

        
    }
}
