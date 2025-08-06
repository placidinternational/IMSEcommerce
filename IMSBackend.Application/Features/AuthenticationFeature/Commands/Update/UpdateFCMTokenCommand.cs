using IMSBackend.Application.Dtos.Auth.Requests;
using IMSBackend.Common;
using MediatR;


namespace IMSBackend.Application.Features.AuthenticationFeature.Commands.Update;
public class UpdateFCMTokenCommand : IRequest<Result<string>>
{
    public UpdateFCMDto UpdateFCMDto { get; set; }
}
