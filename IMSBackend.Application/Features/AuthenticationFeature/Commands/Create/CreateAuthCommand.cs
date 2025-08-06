using IMSBackend.Application.Dtos.Auth.Requests;
using IMSBackend.Common;
using MediatR;

namespace IMSBackend.Application.Features.AuthenticationFeature.Commands.Create;

public class CreateAuthCommand : IRequest<Result<string>>
{
    public RegistrationRequestModel userRegistrationModel { get; set; }
}
