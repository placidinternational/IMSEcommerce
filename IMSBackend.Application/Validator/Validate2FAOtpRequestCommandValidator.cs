using FluentValidation;
using IMSBackend.Application.Dtos.Auth.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Validator;
public class Validate2FAOtpRequestCommandValidator : AbstractValidator<Validate2FAOtpRequestDto>
{
    public Validate2FAOtpRequestCommandValidator()
    {
        RuleFor(x => x.AuthCode)
            .NotEmpty()
            .NotNull()
            .WithMessage("Authenticator code is mandantory");
    }
}
