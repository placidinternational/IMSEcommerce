using IMSBackend.Application.Dtos.Auth;
using IMSBackend.Common;

namespace IMSBackend.Application.Contracts;
public interface IUserService
{
    Task<Result<LoginResponseDto>> RefreshToken(TokenApiModel model, CancellationToken cancellationTokene);
}
