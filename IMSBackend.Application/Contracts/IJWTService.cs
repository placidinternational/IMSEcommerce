using IMSBackend.Application.Dtos.Admin;
using IMSBackend.Domain.Entities.Account;
using System.Security.Claims;

namespace IMSBackend.Application.Contracts;

public interface IJWTService
{
    //string GetToken(Account usr, string UserGroup, Country country, bool isVerified, bool isKycCompleted, bool isAdditionalDocRequired);
    string CreateToken(List<Claim> authClaims);
    string GenerateRefreshToken();
    string GetAdminToken(Account user, List<PermissionObject> permissions);
    ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    string GetToken(Account account);
    string GetTokenforLogin(Account account);
}
