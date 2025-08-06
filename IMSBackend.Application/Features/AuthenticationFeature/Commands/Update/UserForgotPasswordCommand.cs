using IMSBackend.Application.Dtos.Auth.Responses;
using IMSBackend.Common;
using MediatR;


namespace IMSBackend.Application.Features.AuthenticationFeature.Commands.Update
{
    public class UserForgotPasswordCommand : IRequest<Result<ForgotPasswordResponsetDto>>
    {
        public string EmailAddress { get; set; }
    }
}
