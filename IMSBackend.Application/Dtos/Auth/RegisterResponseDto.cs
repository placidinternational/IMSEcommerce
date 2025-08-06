namespace IMSBackend.Application.Dtos.Auth;

public record RegisterResponseDto(string accessToken, Guid identifier, string otpHashCode, string otpCode);

public record GetRegisterResponseDto(Guid identifier, string otpHashCode, string otpCode);

public record SocialGetRegisterResponseDto(Guid identifier, bool isAccountCompleted, string accessToken, string refreshToken);