using System.Security.Claims;

namespace IMSBackend.Application.Shared;

public static class ClaimsPrincipalExtensions
{
    public static Guid GetUserId(this ClaimsPrincipal? principal)
    {
        string? userId = principal?.FindFirstValue(ClaimTypes.NameIdentifier);

        return Guid.TryParse(userId, out Guid parsedUserId) ?
            parsedUserId :
            throw new ApplicationException("User id is unavailable");
    }

    public static string GetFullName(this ClaimsPrincipal? principal)
    {
        return principal?.FindFirstValue(ClaimTypes.Name) ??
            throw new ApplicationException("Full name is unavailable");
    }

    public static string GetRoleName(this ClaimsPrincipal? principal)
    {
        return principal?.FindFirstValue(ClaimTypes.Role) ??
            throw new ApplicationException("Role name is unavailable");
    }
}
