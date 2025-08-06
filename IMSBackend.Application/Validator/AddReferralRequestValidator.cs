using FluentValidation;
using IMSBackend.Application.Dtos.Auth.Requests;

namespace IMSBackend.Application.Validator;
public class AddReferralRequestValidator : AbstractValidator<AddReferralRequest>
{
    public AddReferralRequestValidator()
    {
        RuleFor(x => x.ReferralCode)
            .NotEmpty()
            .WithMessage("Referral code is mandatory");

        RuleFor(x => x.UserId)
            .NotEmpty()
            .WithMessage("User ID is mandatory");
    }
}
