

using IMSBackend.Common;
using MediatR;

namespace IMSBackend.Application.Features.AuthenticationFeature.Commands.Update;

public class UserChangePasswordCommand : IRequest<Result<string>>
{
    public string EmailAddress { get; set; }
    public string Password { get; set; }
    public string OldPassword { get; set; }
}
