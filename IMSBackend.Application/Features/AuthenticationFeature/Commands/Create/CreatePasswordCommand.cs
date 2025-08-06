using MediatR;
using IMSBackend.Common;

namespace IMSBackend.Application.Features.AuthenticationFeature.Commands.Create;
public class CreatePasswordCommand : IRequest<Result<string>>
{
    public string Password { get; set; }
}


