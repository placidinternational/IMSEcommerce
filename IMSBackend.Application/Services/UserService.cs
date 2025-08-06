using IMSBackend.Application.Contracts;
using IMSBackend.Application.Dtos.Auth;
using IMSBackend.Common;
using IMSBackend.Domain.Entities.Account;
using IMSBackend.Domain.Shared;

namespace IMSBackend.Application.Services;
internal class UserService : IUserService
{
    private readonly IJWTService _jWTService;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserContext _userContext;
    public UserService(IJWTService jWTService, IUnitOfWork unitOfWork,
        IUserContext userContext)
    {
        _jWTService = jWTService;
        _unitOfWork = unitOfWork;
        _userContext = userContext;
    }

    public async Task<Result<LoginResponseDto>> RefreshToken(TokenApiModel tokenApiModel, CancellationToken cancellationToken)
    {
        try
        {
            if (tokenApiModel is null)
                return await Result<LoginResponseDto>.FailureAsync("Invalid client request");
            string accessToken = tokenApiModel.AccessToken;
            string refreshToken = tokenApiModel.RefreshToken;
            var principal = _jWTService.GetPrincipalFromExpiredToken(accessToken);
            var username = principal.Identity.Name;
            Guid userId = Guid.Parse(username);

            Account usr = await _unitOfWork.AccountRepository.GetByIdAsync(userId, cancellationToken);

            if (usr.RefreshToken != refreshToken)
                return await Result<LoginResponseDto>.FailureAsync("Invalid client request");

            var newAccessToken = _jWTService.CreateToken(principal.Claims.ToList());
            var newRefreshToken = _jWTService.GenerateRefreshToken();

            usr.RefreshToken = newRefreshToken;
            await _unitOfWork.AccountRepository.Update(usr);
            await _unitOfWork.Save(CancellationToken.None);

            return await Result<LoginResponseDto>.SuccessAsync(new LoginResponseDto()
            {
                AccessToken = newAccessToken,
                RefreshToken = newRefreshToken,
                UserId = userId
            });

        }
        catch (Exception ex)
        {
            return await Result<LoginResponseDto>.FailureAsync("Invalid client request" + ex.Message);
        }
    }

}
