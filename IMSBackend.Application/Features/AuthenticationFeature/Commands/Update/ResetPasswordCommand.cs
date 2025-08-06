using IMSBackend.Common;
using MediatR;

namespace IMSBackend.Application.Features.AuthenticationFeature.Commands.Update;

public class ResetPasswordCommand : IRequest<Result<string>>
{
    public string EmailAddress { get; set; }
    public string NewPassword { get; set; }
}
