using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;
using Microsoft.Extensions.Configuration;
using IMSBackend.Domain.Entities.Account;
using Newtonsoft.Json;
using IMSBackend.Application.Dtos.Admin;
using IMSBackend.Application.Contracts;

namespace IMSBackend.Persistence.Jwt;

public class JWTService : IJWTService
{
    private readonly IConfiguration config;
    public JWTService(IConfiguration _config)
    {
        this.config = _config;
    }

    public string GenerateRefreshToken()
    {
        var randomNumber = new byte[64];
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(randomNumber);
            return Convert.ToBase64String(randomNumber);
        }
    }

    public ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
    {
        var secretKey = config.GetSection("JWT:Secret").Value;
        var tokenValidationParameters = new TokenValidationParameters
        {
            ValidateAudience = false, //you might want to validate the audience and issuer depending on your use case
            ValidateIssuer = false,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),
            ValidateLifetime = false //here we are saying that we don't care about the token's expiration date
        };
        var tokenHandler = new JwtSecurityTokenHandler();
        SecurityToken securityToken;
        var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);
        var jwtSecurityToken = securityToken as JwtSecurityToken;
        if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
            throw new SecurityTokenException("Invalid token");
        return principal;
    }

    public string GetAdminToken(Account user, List<PermissionObject> getPermission)
    {
        var claims = new[]
         {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Email , user.EmailAddress),
            new Claim(ClaimTypes.Name , user.Id.ToString()),
            new Claim("FullName" , user.FullName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim("permissions", JsonConvert.SerializeObject(getPermission)),
        };

        var secretKey = config.GetSection("JWT:Secret").Value;
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));

        var crediential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.UtcNow.AddDays(1),
            SigningCredentials = crediential,
            Issuer = config.GetSection("JWT:ValidIssuer").Value,
            Audience = config.GetSection("JWT:ValidAudience").Value,
        };

        var tokenHandler = new JwtSecurityTokenHandler();

        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
    public string GetToken(Account account)
    {

        var claims = new[]
        {
            new Claim(ClaimTypes.NameIdentifier, account.Id.ToString()),
            new Claim(ClaimTypes.Email , account.EmailAddress),
            new Claim(ClaimTypes.Name , account.Id.ToString()),
            new Claim("FullName" , account.FullName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        };

        var secretKey = config.GetSection("JWT:Secret").Value;
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));

        var crediential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.UtcNow.AddDays(1),
            SigningCredentials = crediential,
            Issuer = config.GetSection("JWT:ValidIssuer").Value,
            Audience = config.GetSection("JWT:ValidAudience").Value,
        };

        var tokenHandler = new JwtSecurityTokenHandler();

        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }

    public string GetTokenforLogin(Account account)
    {

        var claims = new[]
        {
            new Claim(ClaimTypes.NameIdentifier, account.Id.ToString()),
            new Claim(ClaimTypes.Email , account.EmailAddress),
            new Claim(ClaimTypes.Name , account.Id.ToString()),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        };

        var secretKey = config.GetSection("JWT:Secret").Value;
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));

        var crediential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.UtcNow.AddDays(1),
            SigningCredentials = crediential,
            Issuer = config.GetSection("JWT:ValidIssuer").Value,
            Audience = config.GetSection("JWT:ValidAudience").Value,
        };

        var tokenHandler = new JwtSecurityTokenHandler();

        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }

    public string CreateToken(List<Claim> authClaims)
    {
        var secretKey = config.GetSection("JWT:Secret").Value;
        var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));

        var crediential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(authClaims),
            Expires = DateTime.UtcNow.AddMinutes(30),
            SigningCredentials = crediential,
            Issuer = config.GetSection("JWT:ValidIssuer").Value,
            Audience = config.GetSection("JWT:ValidAudience").Value,

        };

        var tokenHandler = new JwtSecurityTokenHandler();

        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }

}