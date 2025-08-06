using FluentValidation;
using IMSBackend.Application.Dtos.Auth.Requests;

namespace IMSBackend.Application.Validator;

public class TransactionPinValidator : AbstractValidator<TransactionPinDto>
{
    public TransactionPinValidator()
    {
        RuleFor(x => x.Pin)
            .NotEmpty()
            .MinimumLength(4)
            .NotNull()
            .WithMessage("Pin code is mandantory");
    }
}
