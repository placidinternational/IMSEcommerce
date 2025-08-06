using IMSBackend.Common;
using MediatR;

namespace IMSBackend.Application.Features.AuthenticationFeature.Commands.Update;
public class ResetPasswordValidateOtpCommand : IRequest<Result<string>>
{
    public string EmailAddress { get; set; }
    public string OtpCode { get; set; }
    public string HashCode { get; set; }
}
