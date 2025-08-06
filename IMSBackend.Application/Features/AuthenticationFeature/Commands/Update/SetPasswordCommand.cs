using IMSBackend.Application.Dtos.Auth;
using IMSBackend.Common;
using MediatR;


namespace IMSBackend.Application.Features.AuthenticationFeature.Commands.Update;

public class SetPasswordCommand : IRequest<Result<SocialGetRegisterResponseDto>>
{
    public string Password { get; set; }
    public Guid CustomerId { get; set; }
}
