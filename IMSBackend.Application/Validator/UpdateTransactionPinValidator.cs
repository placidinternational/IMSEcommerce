using FluentValidation;
using IMSBackend.Application.Dtos.Auth.Requests;

namespace IMSBackend.Application.Validator;
public class UpdateTransactionPinValidator : AbstractValidator<UpdateTransactionPinDto>
{
    public UpdateTransactionPinValidator()
    {
        RuleFor(x => x.OldPin)
            .NotEmpty()
            .MinimumLength(4)
            .NotNull()
            .WithMessage("Old Pin code is mandantory");

        RuleFor(x => x.NewPin)
           .NotEmpty()
           .MinimumLength(4)
           .NotNull()
           .WithMessage("New Pin code is mandantory");
    }
}

