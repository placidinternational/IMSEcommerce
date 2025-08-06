using IMSBackend.Common;
using MediatR;

namespace IMSBackend.Application.Features.AuthenticationFeature.Commands.Delete;

public class DeleteAccountRequestCommand : IRequest<Result<Guid>>
{
    public string AccountDeleteType { get; set; }
    public string? Comments { get; set; }
}

